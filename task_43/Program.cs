// // //  Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// // double CheckDot (int b1, int b2, int k1, int k2)
// // {
// //         double sum1 =0;
// //         double sum2 =-1;
// //         double rez;
// //        for (double x = -100; x < 100; x = x+0.01) 
// //             {
// //             sum1 = k1*x+b1;
// //             sum2 = k2*x+b2;
// //             if (sum1 == sum2) rez = x;
// //             else
// //             {
// //                 sum1 =0;
// //                 sum2=0;
// //                 rez=0;
// //             }
// //             }
// //         return sum1;   
// // }

// // try
// // {
// //     Console.WriteLine("Enter b1 ");
// //     int b1 = int.Parse(Console.ReadLine());
// //     Console.WriteLine("Enter k1 ");
// //     int k1 = int.Parse(Console.ReadLine());
// //     Console.WriteLine("Enter b2 ");
// //     int b2 = int.Parse(Console.ReadLine());
// //     Console.WriteLine("Enter k2 ");
// //     int k2 = int.Parse(Console.ReadLine());
// //     double res1 = 0;
// //     double res2 = 0;
// //     res1 = CheckDot(b1, b2, k1, k2);
// //     res2 = k1*res1+b1;
// //     Console.WriteLine(res1+" "+res2);
// // }
// // catch 
// // {
// //    Console.WriteLine("You've entered something wrong"); 
// // }

// Console.WriteLine("Enter b1 ");
//     int b1 = int.Parse(Console.ReadLine());
//     Console.WriteLine("Enter k1 ");
//     int k1 = int.Parse(Console.ReadLine());
//     Console.WriteLine("Enter b2 ");
//     int b2 = int.Parse(Console.ReadLine());
//     Console.WriteLine("Enter k2 ");
//     int k2 = int.Parse(Console.ReadLine());

// double CheckDot (int b1, int b2, int k1, int k2)
// {
//         double sum1 =0;
//         double sum2 =-1;
//         double rez;
//        for (double x = -10; x < 10; x = x+0.5) 
//             {
//             sum1 = k1*x+b1;
//             sum2 = k2*x+b2;
//             if (sum1 == sum2) rez = x;
//             else
//             {
//                 sum1=0;
//                 sum2=0;
//             }
//             }
//         return sum1;   
// }

//     double res1 = CheckDot (b1, b2, k1, k2);
//     double res2 = k1*res1+b1;
// Console.WriteLine(res1+" "+res2);

Console.WriteLine("Введите уравнения двух прямых вида у = Ki*x + Bi");

Double[] array = new Double[4];

Console.WriteLine("Введите коэффициент K1");
array[0] = double.Parse(Console.ReadLine());
Console.WriteLine("Введите коэффициент B1");
array[1]  = double.Parse(Console.ReadLine());
Console.WriteLine("Введите коэффициент K2");
array[2]  = double.Parse(Console.ReadLine());
Console.WriteLine("Введите коэффициент B2");
array[3]  = double.Parse(Console.ReadLine());
try
{    
double rezX = (array[3]-array[1])/(array[0]-array[2]);
double rezY = array[0]*rezX + array[1];
Console.WriteLine($"Прямые y = {array[0]}*x + {array[1]}  и  y = {array[2]}*x + {array[3]} пересекаются в точке с координатами:");
if (array[0] == array[2] && array[1] == array[3]) Console.WriteLine("Коэффициенты K1 и K2, а так же B1 B2 должны отличаться");
else Console.WriteLine("x= "+ rezX +" y= "+ rezY);
}
catch
{
    Console.WriteLine("Коэффициенты должны быть числами");
}