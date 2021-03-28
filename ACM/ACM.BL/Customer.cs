using System.Collections.Generic;

namespace ACM.BL {
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


        public List<Customer> Retrieve() {
            // Code that retrieves all of the customers
            return new List<Customer>();
        }
        public Customer Retrieve(int customerId) {
            // Code that retrieves the identified customer.
            return new Customer();
        }

        public bool Save() {
            // Code that saves the identified customer
            return true;
        }
    }
}