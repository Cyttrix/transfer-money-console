using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTransfer
{
    internal class Simulation
    {
        public Simulation()
        {
            
        }

        
        
        public void RunSimulation()
        {
            Console.WriteLine("Starting simulation");
            //TODO 5: Instantiate two Person objects, with unique names and money amounts. Two lines
            Person Person1 = new Person("Jack", 1500);
            Person Person2 = new Person("Alice", 1000);
            //TODO 6: Call the .DisplayInfo() method on each person object, one at a time. This will show their initial money amount. Two lines.
            Person1.DisplayInfo();
            Person2.DisplayInfo();

            //TEST THE APPLICATION AFTER TODOS 5 AND 6!!
            Person receiver = Person2;
            //TODO 9: Call the .TransferMoney() method on one person object (giver), making sure to pass in the second person object (receiver), and the amount being transfered. One line.
            Person1.TransferMoney(Person2, 300);

            //TODO 10: Call the .DisplayInfo() method on each person object again, showing that each person's balance has changed. Two lines.
            Person1.DisplayInfo();
            Person2.DisplayInfo();

            Console.WriteLine("Simulation complete.");
        }
    }
}
