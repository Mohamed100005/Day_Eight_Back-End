namespace P01_SalesDatabase.Models {
    internal class Sale {
        public int SaleId { get; set; }
        public int CustomerId { get; set; }
        public DateTime Date { get; set; }
        public int ProductId { get; set; }
        public int StoreId { get; set; }
    }
}
