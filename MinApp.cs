

//namespace _05_13_CSharp
//{
//    internal class MinApp
//    {
//        static double GetDiscountReate(object clinet)
//        {
//            return clinet switch // switch 식이라고 부른다.
//            {
//                ("학생", int n) when n < 18 => 0.2, // 학생 & 18세 미만
//                ("학생", _) => 0.1,
//                ("일반", int n) when n < 18 => 0.1, // 일반 & 18세 미만
//                ("일반", _) => 0.1,
//                _ => 0
//            };
//            // case문을 사용하지 않고도 패턴 매칭을 할수 있다.
            
//        }
//        static void Main(string[] args)
//        {
//            var allice = (Job : "학생", Age : 17);
//            var bob = (Job: "학생", Age: 23);
//            var charlie = (Job: "일반", Age: 15);
//            var dave = (Job: "일반", Age: 25);
//            Console.WriteLine($"allice : {GetDiscountReate(allice)}");
//            Console.WriteLine($"bob : {GetDiscountReate(bob)}");
//            Console.WriteLine($"charlie : {GetDiscountReate(charlie)}");
//            Console.WriteLine($"dave : {GetDiscountReate(dave)}");
//        }
//    }
//}
