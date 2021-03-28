namespace ACM.BL {
    public class OrderItem {
        public OrderItem() {
        }
        public OrderItem(int orderItemId) {
        }

        public int OrderItemId { get; set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }

        public OrderItem Retrieve(int orderItemId) {
            // Code that retrieves the defined order item
            return new OrderItem();
        }

        public bool Save() {
            // Code thta saves the defined order item
            return true;
        }

        public bool Validate() {
            var isValid = true;
            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;
            return isValid;
        }
    }
}