using FINAL_1_Vysotskyi;
using System.Xml.Linq;

namespace RadioPhone_Test
{
   [TestClass]
   public class RadioPhone_Test
   {
      [TestMethod]
      public void Info_ReturnsCorrectInformation()
      {
         RadioPhone radioPhone = new RadioPhone("Panasonic KX-TGD310", 1249.99, true);

         string expectedInfo = $"Info about the device \nRadio Phone\nName: Panasonic KX-TGD310 \nPrice: 1249,99 \nHas Answering Machine True \n";
         string info = radioPhone.Info();

         Assert.AreEqual(expectedInfo, info);
      }
      [TestMethod]
      public void CompareTo_ReturnsPosetiveValue()
      {
         RadioPhone radioPhone1 = new RadioPhone("Panasonic KX-TGD310", 1249.99, true);
         RadioPhone radioPhone2 = new RadioPhone("Siemens Gigaset A540", 719.99, false);

         int resultCom = radioPhone1.CompareTo(radioPhone2);
         Assert.AreEqual(resultCom, 1);
      }
   }
}