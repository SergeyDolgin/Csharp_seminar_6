// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int[] FillArray(int size)
            {
            int[] mas = new int[size];

            for (int i=0;i<size;i++) 
                {
                    Console.WriteLine($"Enter INTEGER {i}-element");
                    mas[i] = int.Parse(Console.ReadLine());
                    // mas[i]= new Random().Next(-100,101);
                }
            return mas;
            }
void PrintArray(int[] m)
            {
            for (int i=0;i<m.Length;i++) 
                {
                    if (i!=m.Length-1) Console.Write($"{m[i]}, ");
                    else Console.WriteLine($"{m[i]}");
                }
            }

int CheckPositive (int [] m)
{
    int count = 0;
    for (int i=0;i<m.Length;i++)
    {
        if ( m[i] > 0) count++;
    }
    return count;
}

Console.WriteLine("Enter dimension of your massive"); 
try 
{
    int m = int.Parse(Console.ReadLine());
    int[] array = FillArray(m);
    Console.Write("Your massive is: "); 
    PrintArray(array);
    Console.WriteLine($"There was/were {CheckPositive(array)} elements in your massive");
}
catch 
{
    Console.WriteLine("You've entered something wrong"); 
}
