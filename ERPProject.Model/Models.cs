using System;
namespace ERPProject.Model
{
    public class BaseModel
    {
        public int Id { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime? LastModifiedTime { get; set; }
        public int CreatorUserId { get; set; }
        public int? LastModifiedUserId { get; set; }
    }
    public class ProductModel : BaseModel
    {
        //TODO: Add Product Category, Sub-Category ... and more.
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public float ProductSellingPrice { get; set; }
        public float ProductPurchasePrice { get; set; }
    }
    public class SalesOrderModel : BaseModel
    {
        public CustomerModel customer { get; set; }
        public int CustomerId { get; set; }

        public ProductModel Product { get; set; }
        public int ProductId { get; set; }

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
        Pending = 0,
        Approved = 1,
        Rejected = 2
    }
}
