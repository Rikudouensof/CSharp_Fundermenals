using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundermenals.Basics.DataTpes
{
  public class ValueDataTypes
  {



    public static void Get_Signed_Data_Type_Values()
    {

      // the value data types start;                                                                                                                                                                                                           
      int signedInt32 = 21;
      short signedInt16 = -32767;
      sbyte singedInt8 = -128;
      long sinnedInt64 = -31355353;

      //value datatype End 


      string result = $"signed Int in Base 8 result: {singedInt8}" +
       $"signed Int in Base 16 result:{signedInt16} " +
       $"signed Int in Base 32 result: {signedInt32}" +
       $"signed Int in Base 64 result: {sinnedInt64}";

      Console.WriteLine(result);

    }
    public static void Get_UnSigned_Data_Type_Values()
    {

      // the value data types start;                                                                                                                                                                                                           

      byte unsignedInt8 = 200;
      ushort usingnedInt16 = 65535;
      uint unsignedInt32 = 433635635;
      ulong unsignedInt64 = 24542435535;
      //value datatype End 


      string result = $"unsigned Int in Base 8 result: {unsignedInt8}" +
       $"unsigned Int in Base 16 result:{usingnedInt16} " +
       $"unsigned Int in Base 32 result: {unsignedInt32}" +
       $"unsigned Int in Base 64 result: {unsignedInt64}";
      Console.WriteLine(result);
    }

    public static void Get_Char_DataType()
    {
      char characterValue = 'C';
      Console.WriteLine(characterValue);
    }

    public static void Get_FloatingPoint_DataTpe()
    {
      float mantisa32 = -1.6867565425F;
      double mantisa64 = -24.424553;

      //End

      string result = $"float:{mantisa32}, while double:{mantisa64}";
      Console.WriteLine(result);
    }

    public static void Get_Decimal_DataTpe()
    {
      decimal value = 42353665.3536436M;
      Console.WriteLine(value);
    }

    public static void Get_Bool_DataTpe()
    {
     bool value = true;
      Console.WriteLine(value);
      
    }

  }
}
