﻿void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++; //index = index + 1
    }

}

void PrintArray(int [] col)
{
    int count = col.Length;
    int pasition = 0;
    while (pasition < count)
    {
        Console.WriteLine(col[pasition]);
        pasition++;
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

int[] array = new int[10];

FillArray(array);
array[4] = 4;
array[6] = 4;
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 444);
Console.WriteLine(pos);