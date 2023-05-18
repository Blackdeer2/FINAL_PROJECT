using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_1_Vysotskyi
{
   [DataContract]
   public class RadioPhone : IPhone, IComparable<IPhone>
   {
      [DataMember]
      private string _name;
      [DataMember]
      private double _price;
      [DataMember]
      private bool _hasAnsweringMachine;
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
      [DataMember]
      public bool HasAnsweringMachine
      {
         get { return _hasAnsweringMachine; }
         set { _hasAnsweringMachine = value; }
      }

      public RadioPhone(string name, double price, bool hasAnsweringMachine)
      {
         _name = name;
         _price = price;
         _hasAnsweringMachine = hasAnsweringMachine;
      }
      public string Info()
      {

         return $"Info about the device \nRadio Phone\nName: {_name} \nPrice: {_price} \nHas Answering Machine {_hasAnsweringMachine} \n";

      }
      public void Print() { Console.WriteLine($"Name phone {_name}, {_price}"); }


      public int CompareTo(IPhone other)
      {
         return _price.CompareTo(other.Price);
      }
   }
}
