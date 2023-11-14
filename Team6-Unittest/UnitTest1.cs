using System.Diagnostics;
using Scheduling;
namespace Team6_Unittest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void OverrideToString_Test ()
        {
            //ARRANGE
            PCB myPcb = new PCB();
            myPcb.ProcessName = "A";
            myPcb.ProcessPriority = 2;

            //ACT
            var result = myPcb.ToString(); 

            //ASSERT
            Assert.AreEqual(result, "A(2)");
        }
    }
}