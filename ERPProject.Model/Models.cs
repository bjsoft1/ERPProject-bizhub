using System;
using System.ComponentModel;
namespace ERPProject.Model
{
    public class BaseModel
    {
        public int Id { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime? LastModifiedTime { get; set; }
        public int? CreatorUserId { get; set; }
        public UserModel CreatorUser { get; set; }
        public int? LastModifiedUserId { get; set; }
        public UserModel LastModifiedUser { get; set; }
    }

    public class UserModel : BaseModel
    {
        public string FullName { get; set; }
        public string UserEmail { get; set; }
        public string UserMobile { get; set; }
        public string UserAddress { get; set; }
    }

    public class ProductModel : BaseModel
    {
        //TODO: Add Product Category, Sub-Category ... and more.
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public float ProductSellingPrice { get; set; }
        public float ProductPurchasePrice { get; set; }
    }
    public class OrderDetailsModel : BaseModel
    {
        public ProductModel Product { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public float Amount { get; set; }

        public OrderModel Order { get; set; }
        public int OrderId { get; set; }
    }
    public class OrderModel : BaseModel
    {
        public CustomerModel Customer { get; set; }
        public int CustomerId { get; set; }

        public float TotalAmount { get; set; }
        public ESaleOrderStatus OrderStatus { get; set; }
    }
    public class CustomerModel : BaseModel
    {
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerMobile { get; set; }
        public string CustomerAddress { get; set; }
    }
    public enum ESaleOrderStatus
    {
        [Description("Pending")]
        Pending = 0,
        [Description("Rejected")]
        Rejected = 1,

        [Description("SDA")]
        SaleDepartmentApproved = 2,
        [Description("SDR")]
        SaleDepartmentRejected = 3,

        [Description("ADA")]
        AccountDepartmentApproved = 4,
        [Description("ADR")]
        AccountDepartmentRejected = 5,

        [Description("FDA")]
        FinalDepartmentApproved = 6,
        [Description("FDR")]
        FinalDepartmentRejected = 7
    }
}
