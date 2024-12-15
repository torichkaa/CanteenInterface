using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace CanteenInterface
{
    public partial class FeedbackForm : Form
    {
        private List<Feedback> feedbackList = new List<Feedback>();

        public FeedbackForm()
        {
            InitializeComponent();
            LoadFeedbacks();
        }

        private void LoadFeedbacks()
        {
            feedbackList.Clear();
            string query = "SELECT * FROM feedback";
            using (SQLiteConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Feedback feedback = new Feedback
                    {
                        FeedbackId = reader.GetInt32(0),
                        SubmittedBy = reader.GetString(1),
                        Content = reader.GetString(2),
                        SubmissionDate = DateTime.Parse(reader.GetString(3)),
                        Response = reader.IsDBNull(4) ? null : reader.GetString(4)
                    };
                    feedbackList.Add(feedback);
                }
                reader.Close();
                conn.Close();
            }
            listBoxFeedbacks.DataSource = null;
            listBoxFeedbacks.DataSource = feedbackList;
            listBoxFeedbacks.DisplayMember = "DisplayInfo";
        }

        private void listBoxFeedbacks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFeedbacks.SelectedItem != null)
            {
                Feedback selectedFeedback = (Feedback)listBoxFeedbacks.SelectedItem;
                textBoxContent.Text = selectedFeedback.Content;
                textBoxResponse.Text = selectedFeedback.Response;
            }
            else
            {
                textBoxContent.Clear();
                textBoxResponse.Clear();
            }
        }

        private void buttonAddResponse_Click(object sender, EventArgs e)
        {
            if (listBoxFeedbacks.SelectedItem != null)
            {
                Feedback selectedFeedback = (Feedback)listBoxFeedbacks.SelectedItem;
                ResponseForm responseForm = new ResponseForm(selectedFeedback);
                if (responseForm.ShowDialog() == DialogResult.OK)
                {
                    string updatedResponse = responseForm.ResponseText;
                    string query = "UPDATE feedback SET response=@Response WHERE feedback_id=@FeedbackId";
                    using (SQLiteConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        SQLiteCommand cmd = new SQLiteCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Response", updatedResponse);
                        cmd.Parameters.AddWithValue("@FeedbackId", selectedFeedback.FeedbackId);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    LoadFeedbacks();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxFeedbacks.SelectedItem != null)
            {
                Feedback selectedFeedback = (Feedback)listBoxFeedbacks.SelectedItem;
                DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити цей відгук?", "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string query = "DELETE FROM feedback WHERE feedback_id=@FeedbackId";
                    using (SQLiteConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        SQLiteCommand cmd = new SQLiteCommand(query, conn);
                        cmd.Parameters.AddWithValue("@FeedbackId", selectedFeedback.FeedbackId);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    LoadFeedbacks();
                }
            }
        }

        private void buttonAddFeedback_Click(object sender, EventArgs e)
        {
            NewFeedbackForm newFeedbackForm = new NewFeedbackForm();
            if (newFeedbackForm.ShowDialog() == DialogResult.OK)
            {
                Feedback newFeedback = newFeedbackForm.Feedback;
                string query = "INSERT INTO feedback (submitted_by, content, submission_date) VALUES (@SubmittedBy, @Content, @SubmissionDate)";
                using (SQLiteConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@SubmittedBy", newFeedback.SubmittedBy);
                    cmd.Parameters.AddWithValue("@Content", newFeedback.Content);
                    cmd.Parameters.AddWithValue("@SubmissionDate", newFeedback.SubmissionDate.ToString("yyyy-MM-dd"));
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                LoadFeedbacks();
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string search = textBoxSearch.Text.ToLower();
            var filteredList = feedbackList.FindAll(f => f.SubmittedBy.ToLower().Contains(search) || f.Content.ToLower().Contains(search));
            listBoxFeedbacks.DataSource = null;
            listBoxFeedbacks.DataSource = filteredList;
            listBoxFeedbacks.DisplayMember = "DisplayInfo";
        }
    }
}