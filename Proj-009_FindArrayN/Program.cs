Console.Clear();
// Нахождение индекса элемента массива
int[] array = {5, 12, 44, 6, 1, 7, 13, 6, 93, 9, 17}; // Некоторый массив
int n = array.Length;
int find = 6; // Число, индекс которого ищем
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
