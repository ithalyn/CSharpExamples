using System;

namespace DelegateExample{

    public class ItemController{

        public ItemController(string startingMessage, ItemShipper shipper,
            ItemShipper.ShippingNotificationDelegate notificationCallback){
            Message = startingMessage;
            ShippingProvider = shipper;
            shipper.NotificationCallback += notificationCallback;
            shipper.NotificationCallback += NotifyShippingCallback;
        }

        public string Message { get; set; }

        public ItemShipper ShippingProvider { get; protected set; }

        public void PerformShippment(){
            ShippingProvider.ShipItems();
        }

        private string NotifyShippingCallback(string message){
            Message += message;
            Console.WriteLine(Message);
            return Message;
        }
    }

    internal class Program{

        public static string ShippingCallback(string message){
            string retval = message + "def";
            Console.WriteLine(retval);
            return retval;
        }

        private static void Main(string[] args){
            var shipper = new ItemShipper();
            var controller = new ItemController("Default ", shipper, ShippingCallback);

            controller.PerformShippment();
        }
    }
}