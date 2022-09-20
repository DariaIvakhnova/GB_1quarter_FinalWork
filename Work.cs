// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых
// меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на
// старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
//исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] originalArrayOfStrings = new string[5] {"Work", "hard", "dream", "big", ":-)"};
string[] newArrayOfStrings = new string[originalArrayOfStrings.Length];
int elementSize = 3;
int count = 0;
for (int i = 0; i < originalArrayOfStrings.Length; i++)
{
    if (originalArrayOfStrings[i].Length <= elementSize)
    {
    newArrayOfStrings[count] = originalArrayOfStrings[i];  
    count++;
    }
}
Array.Resize(ref newArrayOfStrings, count);
Console.Write($"[{String.Join(", ", originalArrayOfStrings)}] -> ");
Console.Write($"[{String.Join(", ", newArrayOfStrings)}]");