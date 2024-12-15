using System;
using System.Windows.Forms;

namespace CanteenInterface
{
    public partial class SupplyDetailsForm : Form
    {
        public Supply Supply { get; private set; }

        public SupplyDetailsForm()
        {
            InitializeComponent();
        }

        public SupplyDetailsForm(Supply supply) : this()
        {
            Supply = supply;
            textBoxItemName.Text = Supply.ItemName;
            textBoxQuantity.Text = Supply.Quantity;
            textBoxSupplier.Text = Supply.Supplier;
            dateTimePickerPurchaseDate.Value = Supply.PurchaseDate;
            numericUpDownCost.Value = Supply.Cost;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (Supply == null)
                Supply = new Supply();

            Supply.ItemName = textBoxItemName.Text;
            Supply.Quantity = textBoxQuantity.Text;
            Supply.Supplier = textBoxSupplier.Text;
            Supply.PurchaseDate = dateTimePickerPurchaseDate.Value.Date;
            Supply.Cost = numericUpDownCost.Value;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}