﻿using System;

namespace ACM.BL {
    public class Order {
        public Order() {
        }
        public Order(int orderId) {
        }

        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; set; }

        public bool Validate() {
            var isValid = true;
            if (OrderDate == null) isValid = false;
            return isValid;
        }
    }
}