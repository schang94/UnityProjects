//namespace _05_13_CSharp
//{
//    #region
//    readonly struct RGBColor
//    {
//        public readonly byte R;
//        public readonly byte G;
//        public readonly byte B;

//        public RGBColor(byte r, byte g, byte b)
//        {
//            this.R = r;
//            this.G = g;
//            this.B = b;
//        }
//    }
//    #endregion
//    internal class Program
//    {
//        static void Main()
//        {
//            //RGBColor red = new(255, 0, 0);
//            ////red.R = 254; // Error : readonly struct는 생성자에서만 초기화
//            //RGBColor green = new(0, 255, 0);

//            #region 튜플 tuple
//            //var tuple = (123, 456);
//            //Console.WriteLine($"{tuple.Item1} {tuple.Item2}");

//            //var tuple2 = (Name : "서예지", Age : 35);
//            //Console.WriteLine($"{tuple2.Name} {tuple2.Age}");

//            //var tuple3 = (Name : "유아인", Age : 38, Address : "서울");
//            //var (name, age, address) = tuple3;
//            //Console.WriteLine($"이름 : {name}, 나이 : {age}, 주소 : {address}");

//            //var num = (Name: "김문수", Age: 75);
//            //(name, _) = num;
//            //Console.WriteLine($"이름 : {name}");

//            //var (name2, age2) = ("서예지", 35);
//            //Console.WriteLine($"{name2}, {age2}");

//            //var unnamed = ("슈퍼맨", 9999);
//            //var named = (Name: "배트맨", Age: 46);
//            //named = unnamed;
//            //Console.WriteLine($"{named.Name}, {named.Age}");
//            //unnamed.Item2 = 8888;
//            //Console.WriteLine($"{named.Name}, {named.Age}");
//            #endregion

//            #region
//            var a = ("슈퍼맨", 9999);
//            Console.WriteLine($"{a.Item1}, {a.Item2}");
//            var b = (Name: "배트맨", Age: 46);
//            Console.WriteLine($"{b.Name}, {b.Age}");
//            // 분해
//            var (name, age) = b;
//            Console.WriteLine($"{name}, {age}");
//            // 분해2
//            var (name2, age2) = ("서예지", 35);
//            Console.WriteLine($"{name2}, {age2}");
//            //명명된 튜플 = 명명이 되지 않은 튜플
//            b = a;
//            Console.WriteLine($"{b.Name}, {b.Age}");
//            #endregion
//        }
//    }
//}
