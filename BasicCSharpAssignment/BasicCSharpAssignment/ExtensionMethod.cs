using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpAssignment
{
    public static class ExtensionMethod
    {
        public static int add(this Calculator ob, int num1,int num2)
        {
            return num1+num2;
        }
        public static int sub(this Calculator obb,int num1,int num2)
        {
            return num1-num2;
        }
        public static int mul(this Calculator obb, int num1, int num2)
        {
            return num1 * num2;
        }
        public static int div(this Calculator obb, int num1, int num2)
        {
            try
            {
               int result= num1 / num2;
                return result;
            }catch(DivideByZeroException ex)
            {
                string v = $"You are trying to divisible by Zero {ex.Message}";
                throw new DivideByZeroException(v);
            }
        }
        public static int mod(this Calculator obb,int num1,int num2)
        {
            return num1 % num2;
        }


    }
}
