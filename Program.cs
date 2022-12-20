// // //  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Введите число a: ");
// int numa = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите число b: ");
// int numb = int.Parse(Console.ReadLine()!);
// if(numa > numb)
// {
// Console.WriteLine($"Число {numa} больше числа {numb}");
// }
// else if (numa < numb)
// {
//      Console.WriteLine($"Число {numb} больше числа {numa}");
//   }
//   else
//   {
//       Console.WriteLine("Число numa равно числу numb");
//  }

// // Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// // 2, 3, 7 -> 7
// // 44 5 78 -> 78
// // 22 3 9 -> 22

//   Console.WriteLine("Введите число a: ");
//   int numa = int.Parse(Console.ReadLine()!);
//     Console.WriteLine("Введите число b: ");
//   int numb = int.Parse(Console.ReadLine()!);
//   Console.WriteLine("Введите число c: ");
//   int numc = int.Parse(Console.ReadLine()!);
//   int max = numa;
//   if (max == numb)
//  Console.WriteLine($"Число {numa} является максимальным");
//   else
//  {  
//      if (numb > max)
//      Console.WriteLine($"Число {numb} является максимальным");
//   else if (numc > max) max = numc;
//   }
//   Console.WriteLine($"Число {numc} является максимальным");


// // // Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// // // 4 -> да
// // // -3 -> нет
// // // 7 -> нет

//   Console.WriteLine("Введите число: ");
//   int num = int.Parse(Console.ReadLine()!);
//   if (num%2 == 0)
//    Console.WriteLine($"Число {num} является чётным");   
//   else
//    Console.WriteLine($"Число {num} не является чётным");   


// // Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// //  5 -> 2, 4
// //  8 -> 2, 4, 6, 8


//   Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine()!);
//   int i = 1; 
//   while (i <= num)
//   {
//       if (i % 2 == 0)
//       {
//           Console.WriteLine($"{i} ");
//           }
//           i++;
//   }
