using System;

namespace DocumentManagementSystem.UI.Models
{
    public class SupplierModel
    {
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string SupplierDescription { get; set; }
        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }
        public string CustomerID { get; set; }
    }
}
