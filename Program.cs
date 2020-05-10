using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankTests{    
[TestClass]
    public class BankAccountTests    
    {        [TestMethod] 
        publicvoidTestMethod1() {
            try {
                double getal1;
                double getal2;
                double uitkomst;
                uitkomst = getal1 / getal2;
            }
            catch(devidedByzeroExeption)
            {
                global::System.Console.WriteLine("Cannot devide by zero");
            }
        }    }

}