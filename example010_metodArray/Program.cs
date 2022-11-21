// Имеется одномерный массив array из n элементов, требуется найти элемент массива = find

int[] array = { 12, 42, 31, 41, 5, 76, 75, 5 };
int n = array.Length;
int find = 5;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; // заканчивает работы, если массив уже найден.
    }
    index = index + 1; // index++;
}