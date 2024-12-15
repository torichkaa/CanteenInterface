using System;

namespace CanteenInterface
{
    public partial class CafeteriaStaff
    {
        public int StaffId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime HireDate { get; set; }

        public string DisplayInfo
        {
            get
            {
                return $"{FirstName} {LastName} - {Role}";
            }
        }
    }

    public partial class Dish
    {
        public int DishId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Ingredients { get; set; }
        public int Calories { get; set; }

        public string DisplayInfo
        {
            get
            {
                return $"{Name} - {Type}";
            }
        }
    }

    public class Feedback
    {
        public int FeedbackId { get; set; }
        public string SubmittedBy { get; set; }
        public string Content { get; set; }
        public DateTime SubmissionDate { get; set; }
        public string Response { get; set; }

        public string DisplayInfo
        {
            get
            {
                return $"{SubmittedBy} - {SubmissionDate.ToString("yyyy-MM-dd")}";
            }
        }
    }

    public partial class MealConsumption
    {
        public int ConsumptionId { get; set; }
        public int ChildId { get; set; }
        public DateTime Date { get; set; }
        public string MealTime { get; set; }
        public int DishId { get; set; }
        public string PortionSize { get; set; }
        public string Remarks { get; set; }
        public string DishName { get; set; }

        public string DisplayInfo
        {
            get
            {
                return $"Дитина ID: {ChildId}, {Date.ToString("yyyy-MM-dd")}, {MealTime}, Страва: {DishName}, Порція: {PortionSize}";
            }
        }
    }

    public partial class Supply
    {
        public int SupplyId { get; set; }
        public string ItemName { get; set; }
        public string Quantity { get; set; }
        public string Supplier { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal Cost { get; set; }

        public string DisplayInfo
        {
            get
            {
                return $"{ItemName} - {Quantity} від {Supplier}";
            }
        }
    }

    public partial class Menu
    {
        public int MenuId { get; set; }
        public DateTime Date { get; set; }
        public int GroupId { get; set; }
        public int DishId { get; set; }
        public string MealTime { get; set; }
        public string DishName { get; set; }

        public string DisplayInfo
        {
            get
            {
                return $"{MealTime} - {DishName}";
            }
        }
    }
}