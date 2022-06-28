void FillArray(int[] collection) //Метод заполняющий массив
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }


}

void PrintArray(int[] col) //Метод распечатывающий массив
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int[10];  // Определили массив из 10 элементов

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

FillArray(array);  //Вызов метода, заполняющего массив

array[4] = 4;
array[6] = 4;
PrintArray(array); //Вызов метода, распечатывающего массив

Console.WriteLine(); //Пустая строчка,отделит массив от значения

int pos = IndexOf(array, 444); // В переменную пишем результат работы метода IndexOf
Console.WriteLine(pos);