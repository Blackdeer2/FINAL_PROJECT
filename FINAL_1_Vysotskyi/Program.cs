using System;
using System.ComponentModel;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Serialization.Json;
using System.Text.Json;
using System.Xml;
using System.IO;


namespace FINAL_1_Vysotskyi
{
   internal class Program
   {
      static void Main(string[] args)
      {
         List<IPhone> phoneList = new List<IPhone>()
                  {
                   new MobilePhone("iPhone 13", 31499.99),
                   new RadioPhone("Panasonic KX-TGD310", 1249.99,true),
                   new MobilePhone("Samsung Galaxy S22", 32000.99),
                   new RadioPhone("Siemens Gigaset A540", 719.99,false),
                   new MobilePhone("Samsung Galaxy S21", 29899.99),
                   new MobilePhone("iPhone 12 Pro Max", 27399.99),
                   new RadioPhone("Panasonic KX-TGF575S", 299.99, true),
                   new RadioPhone("VTech CS6719-2", 99.99, false)
                  };

         PhoneListWrapper phoneListWrapper = new PhoneListWrapper(phoneList);

         string jsonString;
         using (Stream stream = new FileStream("person4.json", FileMode.Create))
         {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(PhoneListWrapper));
            serializer.WriteObject(stream, phoneListWrapper);
            stream.Position = 0;
            StreamReader reader = new StreamReader(stream);
            jsonString = reader.ReadToEnd();
         }

         using (Stream stream = new FileStream("person4.json", FileMode.Open))
         {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(PhoneListWrapper));
            PhoneListWrapper phoneListWrapperDSer = (PhoneListWrapper)serializer.ReadObject(stream);
            Console.WriteLine("Deserialization JSON");
                /*            foreach (var phone in phoneListWrapperDSer.Phones)
                            {
                               Console.WriteLine(phone.ToString());
                            }*/
                Console.WriteLine();
            }


         /* foreach (IPhone phone in phones)
          {
             Console.WriteLine(phone.Info());
          }
          Console.WriteLine();

          foreach (IPhone phone in phones)
          {
             phone.Info();
          }
          Console.WriteLine();

          phones.Sort();
          Console.WriteLine("Sorted ");
          foreach (IPhone phone in phones)
          {
             phone.Print();
          }

          double sum = 0;
          foreach (IPhone phone in phones)
          {
             sum += phone.Price;
          }
          Console.WriteLine($"Total sum {sum}\n");

          foreach (IPhone phone in phones)
          {
             if (phone is RadioPhone && ((RadioPhone)phone).HasAnsweringMachine)
             {
                Console.WriteLine(phone.Info());
             }
          }*/
      }
   }
}
