using FINAL_1_Vysotskyi;
using System.Xml.Linq;

namespace MobilePhone_Test
{
   [TestClass]
   public class MobilePhone_Test
   {
      [TestMethod]
      public void Info_ReturnsCorrectInformation()
      {
         string name = "iPhone 13";
         double price = 31499.99;
         MobilePhone mobilePhone = new MobilePhone(name, price);

         string expectedInfo = $"Info about the device \nMobile Phone\nName: iPhone 13 \nPrice: 31499,99 \n";
         string info = mobilePhone.Info();

         Assert.AreEqual(expectedInfo, info);
      }
      [TestMethod]
      public void CompareTo_ReturnsNegativeValue()
      {
         MobilePhone mobilePhone1 = new MobilePhone("iPhone 13", 31499.99);
         MobilePhone mobilePhone2 = new MobilePhone("Samsung Galaxy S22", 32000.99);

         int resultCom = mobilePhone1.CompareTo(mobilePhone2);
         Assert.AreEqual(resultCom, -1);
      }
   }

}