using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrdenacaoAPI.Models;

namespace Ordenacaotest
{

    [TestClass]
    public class NumbersOrdersTest
    {
         NumbersOrders numbers = new  NumbersOrders();
        [TestMethod]
         public void ChangeTest()
        {
            int[] expected = new int[] {4,6};
            int[] result;
           
            result=numbers.Change(6,4);
        

            CollectionAssert.AreEqual(expected,result);
        }

        [TestMethod]
         public void ChangeNegativeTestValuePositive()
        {
            int expected = -2;
            int result;
           
            result=numbers.ChangeNegative(2);

            Assert.AreEqual(expected,result);
        }

        [TestMethod]
         public void ChangeNegativeTestValueNegative()
        {
            int expected = 2;
            int result;
            
            result=numbers.ChangeNegative(-2);

            Assert.AreEqual(expected,result);
        }
    }
}