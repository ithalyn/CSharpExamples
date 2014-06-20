using System;

namespace DelegateExample {

    public class ItemShipper {

        public delegate string ShippingNotificationDelegate(string message);

        public ShippingNotificationDelegate NotificationCallback { get; set; }

        public void ShipItems() {
            Console.WriteLine("Processing Shippment");
            Console.WriteLine("Shipped Item");
            NotificationCallback("abc");
            Console.WriteLine("Cleaning up workstation");
        }
    }
}