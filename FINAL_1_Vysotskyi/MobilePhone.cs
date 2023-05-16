using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_1_Vysotskyi
{
   [DataContract]
   public class MobilePhone : IPhone, IComparable<IPhone>
   {
      [DataMember]
      private string _name;
      [DataMember]
      private double _price;

      public MobilePhone(string name, double price)
      {
         _name = name;
         _price = price;
      }
      [DataMember]
      public string Name
      {
         get { return _name; }
         set { _name = value; }
      }
      [DataMember]
      public double Price
      {
         get { return _price; }
         set { _price = value; }
      }

      public string Info()
      {

        return $"Info about the device \nMobile Phone\nName: {_name} \nPrice: {_price} \n";

      }
      public void Print() { Console.WriteLine($"Name phone {_name}, {_price}"); }

      public int CompareTo(IPhone other)
      {
         return _price.CompareTo(other.Price);
      }
      public string ToString(IPhone other)
      {
         return $"{other.Name}, {other.Price}";
      }
   }
}
