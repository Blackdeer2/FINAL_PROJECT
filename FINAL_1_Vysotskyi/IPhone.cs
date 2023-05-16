using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_1_Vysotskyi
{
   public interface IPhone : IComparable<IPhone>
   {
      [DataMember]
      string Name { get; set; }
      [DataMember]
      double Price { get; set; }
      string Info();
      void Print();
   }
}
