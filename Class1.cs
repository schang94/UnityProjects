using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_13_CSharp
{


    internal class Class1
    {
        //private static double GetDiscountRate(object client)
        //{
        //    return client switch
        //    {
        //        ("학생", int n) when n < 18 => 0.2,  // 학생 & 18세 미만
        //        ("학생", _) => 0.1,                  // 학생 & 18세 이상
        //        ("일반", int n) when n < 18 => 0.1,  // 일반 & 18세 미만
        //        ("일반", _) => 0.05,                 // 일반 & 18세 이상
        //        _ => 0,
        //    };
        //}

        private static double GetDiscountRate(object client)
        {
            switch(client)
            {
                case ("학생", int n) when n < 18:
                    return 0.2;
                case ("학생", _):
                    return 0.1;
                case ("일반", int n) when n < 18:
                    return 0.1;
                case ("일반", _):
                    return 0.05;
                default:
                    return 0;
            }
        }
        static void Main(string[] args)
        {
            var allice = (Job: "학생", Age: 17);
            var bob = (Job: "학생", Age: 23);
            var charlie = (Job: "일반", Age: 15);
            var dave = (Job: "일반", Age: 25);
            Console.WriteLine($"allice : {GetDiscountRate(allice)}");
            Console.WriteLine($"bob : {GetDiscountRate(bob)}");
            Console.WriteLine($"charlie : {GetDiscountRate(charlie)}");
            Console.WriteLine($"dave : {GetDiscountRate(dave)}");
        }
    }
}
