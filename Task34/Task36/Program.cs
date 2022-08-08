// Задача 36 
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечетных позициях. 
// [3, 7, 23, 12] -> 19 
 
// Возьмем например массив из 5 чисел. 
// Создаем пустой массив, размером 5. 
// Заполняем случайными числами от 1 до 20. 
// Находим числа стоящие на нечетных позициях. 
// Находим их сумму. 
// Выводим результат в консоль. 
 
int[] arrey = new int[5]; 
 
void FillArrey(int[] arrey) 
{ 
    for(int i = 0; i < arrey.Length; i++) 
    { 
        arrey[i] = new Random().Next(1, 21); 
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
 
int sum = arrey[0] + arrey[2] + arrey[4]; 
 
Console.WriteLine(); 
 
Console.Write($"Сумма чисел стоящих на нечетных позициях: {sum} ");
