// Имеется одномерный массив array из n элементов, треубется найти элемент массива, равный find

int[] array = { 13, 12, 37, 44, 25, 46, 7, 44 };

int n = array.Length;

int find = 44;

int index = 0;

while (index < n)
{
    if(array[index] == find){
        Console.WriteLine(index);
        break;
    }
    index++;
}