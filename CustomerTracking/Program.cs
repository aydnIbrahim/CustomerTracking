using System; 

namespace CustomerTracking
{
    class Program
    {

        static void Main()
        {
            CustomerManager.Add(1,"İbrahim Hakkı","Aydın");
            CustomerManager.Update(1,"İbrahim Hakkı","Aydın",6);
            CustomerManager.Delete(1,"İbrahim Hakkı","Aydın");
        }

    }
        
    
}
