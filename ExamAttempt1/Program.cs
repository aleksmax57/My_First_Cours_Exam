// Написать програму, которая из имеющегося массива строк формирует новый массив
// из строк, длина которого меньше либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения
// алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.
// Например: ["Hello", "2", "wold", ":-)"] => ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] => ["-2"]
// ["Russia", "Danmark", "Kazan"] =>[]

Console.Write("Введите количество элементов массива: "); // Определение размера массива
int size = Convert.ToInt32(Console.ReadLine());
string[] firstArray = new string[size]; // Исходный массив
string[] secondArray = new string[firstArray.Length]; // Итоговый массив
void creatArray(string[] firstArray) // Заполнение исходного массива
{
    for( int i = 0; i < firstArray.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        firstArray[i] = Console.ReadLine()!;
    }
}
void Print(string[] firstArray) // Вывщд исходного массива на экран
{
    Console.Write("Исходный массив: [");
    for(int i = 0; i < firstArray.Length; i++)
    {
        Console.Write($"'{firstArray[i]}', ");
    }
    Console.Write("]");
}
string[] symbol(string[] firstArray) // Определение размера каждого элемента исходного массива
{
    int j = 0;
    for(int i = 0; i < firstArray.Length; i++)
    {
        if(firstArray[i].Length < 4) // Определение элементов, размер которых <= 3
        {
            secondArray[j] = firstArray[i];
            j++;
        }
    }
    return secondArray;  // Возврат найденного элемента в итоговый массив
}
void PrintA(string[] firstArray) // Вывод итогового массива на экран
{
    Console.Write("\nИтоговый массив: [");
    for(int i = 0; i < firstArray.Length; i++)
    {
        Console.Write($"'{firstArray[i]}', ");
    }
    Console.Write("]");
}
void Main()
{
    creatArray(firstArray);
    Print(firstArray);
    PrintA(symbol(firstArray));
}
Main();
