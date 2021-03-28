﻿namespace ACM.BL {
    public class Customer {
        public Customer() {
        }
        public Customer(int customerId) {
            CustomerId = customerId;
        }
        public int CustomerId { get; private set; }
        public string FirstName { get; set; }
        public string EmailAddress { get; set; }
        public static int InstanceCount { get; set; }

        private string _lastName;
        public string LastName { 
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string FullName { 
            get {
                string fullName = LastName;
                if (!string.IsNullOrEmpty(FirstName)) {
                    if (!string.IsNullOrEmpty(fullName)) {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            } 
        }

        public bool Validate() {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;
            return isValid;
        }
    }
}