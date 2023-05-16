using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_1_Vysotskyi
{
   [DataContract]
   [KnownType(typeof(MobilePhone))]
   [KnownType(typeof(RadioPhone))]
   public class PhoneListWrapper
   {
      [DataMember]
      public List<IPhone> Phones { get; set; }

      public PhoneListWrapper(List<IPhone> phones)
      {
         Phones = phones;
      }

      public void Print()
      {
         foreach (IPhone phone in Phones)
         {
            Console.WriteLine(phone.ToString());
         }
      }
   }
}
