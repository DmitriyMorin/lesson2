// Найти из 9 чисел максимальное значение

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int a1 = 15;
int b1 = 27;
int c1 = 8;
int a2 = 184;
int b2 = 45;
int c2 = 164;
int a3 = 32;
int b3 = 522;
int c3 = 200;

//int max1 = Max(a1, b1, c1);
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3, b3, c3);
//int max = Max(max1, max2, max3);
int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3)); 
// Тоже действие, что и выше в комминтарии, написано короче

Console.WriteLine(max);
