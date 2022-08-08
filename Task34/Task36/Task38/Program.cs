// Задача 38 
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива. 
 
double[] arreyNumbers = new double[10]; 
 
for (int i = 0; i < arreyNumbers.Length; i++) 
{ 
    arreyNumbers[i] = new Random().Next(1, 10); 
    Console.Write(arreyNumbers[i] + " "); 
} 
 
double maxNumber = arreyNumbers[0]; 
double minNumber = arreyNumbers[0]; 
 
for (int i = 1; i < arreyNumbers.Length; i++) 
{ 
    if (maxNumber < arreyNumbers[i]) 
    { 
        maxNumber = arreyNumbers[i]; 
    } 
    if (minNumber > arreyNumbers[i]) 
    { 
        minNumber = arreyNumbers[i]; 
    } 
} 
 
double decision = maxNumber - minNumber; 

Console.WriteLine();
 
Console.WriteLine($"Разница между максимальным ({maxNumber}) и минимальным ({minNumber}) элементами: {decision}");
