// в данном случае, если в массиве будет несколько
// одинаковых чисел, то алгоритм покажет их все
/*int[] array = { 1, 12, 31, 4, 15, 18, 16, 17, 18 };

int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
    }
    //index = index + 1;
    index++; // короткая форма
}
*/

//
int[] array = { 1, 12, 31, 4, 15, 18, 16, 17, 18 };

int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index + 1;
    index++; // короткая форма
}