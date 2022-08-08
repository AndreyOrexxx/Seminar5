// Задача 34  
// Задайте массив заполненный случайными положительными числами. Напишите программу, которая покажет колличество четных чисел в массиве. 
 
// Возьмем например массив из 10 чисел. 
// Создаем пустой массив размером 10. 
// Заполняем случайными числами от 100 до 999. 
// Находим колличество четных чисел 
// Выводим результат в консоль. 
 
int[] arrey = new int[10]; 
 
void FillArrey(int[] arrey) 
{ 
    for(int i = 0; i < arrey.Length; i++) 
    { 
        arrey[i] = new Random().Next(100, 1000); 
    } 
} 
 
void PrintArrey(int[] arr) 
{ 
 for(int pos = 0; pos < arr.Length; pos++) 
 { 
    Console.Write($" {arr[pos]} "); 
 } 
} 
FillArrey(arrey); 
PrintArrey(arrey); 
 
int QuantityPositive(int[] array) 
{ 
    int quantity = 0; 
    for (int i = 0; i < array.Length; i++) 
    { 
        if (array[i] % 2 == 0) 
        { 
         quantity++; 
        } 
    } 
    return quantity; 
} 
Console.WriteLine(); 
 
int quantity = QuantityPositive(arrey); 
Console.WriteLine($"Колличество четных чисел в массиве: {quantity} ");
