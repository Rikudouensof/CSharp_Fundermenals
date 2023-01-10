using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundermenals.Basics.DataTpes
{
  public class PointerDataType
  {

    public static void Get_Pointer_DataType()
    {
      unsafe
      {
        int tempValue = 8;
        int* value = &tempValue;
        //End


        string result = $"Value form pointer datatype; address:{(int)value}, Value: {tempValue}";
        Console.WriteLine(result);
      }
     

    }
  }
}
