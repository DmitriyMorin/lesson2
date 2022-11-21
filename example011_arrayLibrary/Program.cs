void FillArray(int[] collection) // void - не убирает 
{
    int length = collection.Length; //Длинна нашего массива
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col) // печать массива
{
    int count = col.Length; //Количество эллементов
    int position = 0; // Текущая позиция
    while (position < count)
    {
        Console.WriteLine(col[position]); // выводим значение текущего элемента
        position++;
    }
}


int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
    
        index++;
    }
    return position;
}

int[] array = new int[10]; // Определяем новый массив, и указываем, что в нем 10 элементов

FillArray(array); // заполняет массив
PrintArray(array);
Console.WriteLine(); //пустая строка 

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
