// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равнв 3 символа.

void PrintArray(string[] array) { 
    for (int i = 0; i < array.Length; i++) {
        Console.Write($"{array[i]}\t"); 
    }
}
string[] array = {"one","two","three","four","five","six","seven"};
Console.WriteLine();
string[] result = new string[array.Length];
int count = 0;
for (int i = 0; i < array.Length-1; i++) {
    if (array[i].Length <= 3) {
        result[count] = array[i];
        count++;
    }
}
PrintArray(result);