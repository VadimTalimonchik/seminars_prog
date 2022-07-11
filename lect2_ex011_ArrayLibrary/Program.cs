// 
void FillArray(int[] collection)
{
    int length = collection.Length; // определим длину массива
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        //index = index + 1;
        index++;
    }

}

void PrintArray(int[] col)
{
    int count = col.Length; //колличество элементов
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; //если элемента нет (который мы хотим найти), то ставим -1 для обозначения несуществующего элемента, иначе 0
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

int[] array = new int[10]; //определим массив array с 10 элементами

FillArray(array); //вызвали метод FillArray, который заполнил массив
array[4] = 4; //"принудительно" вставим в массив четвёрку на 4 позицию
array[6] = 4; // и на 6 позицию

PrintArray(array); //вызвали метод PrintArray, который распечатал массив из случайных чисел
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);