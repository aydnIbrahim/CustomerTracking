using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerTracking
{
    internal class CustomerManager
    {

        
        public static void Add(int customerId, string customerFirstName, string customerLastName) { 
            var result = "Müşteri Eklendi : " + customerId + "-" + customerFirstName + " " + customerLastName;
            Console.WriteLine(result);
        }   

        public static void Delete(int customerId, string customerFirstName, string customerLastName)
        {
            var result = "Müşteri bilgileri silindi : "+customerId+ "-" + customerFirstName + " " +customerLastName;
            Console.WriteLine(result);
        }

        public static void Update(int customerId, string customerFirstName, string customerLastName, int ordersCount) {

            var result = "Müşteri bilgileri güncellendi : " + customerId + "-" + customerFirstName + " " + customerLastName + "-" + ordersCount;
            Console.WriteLine(result);
        }

    }
}
