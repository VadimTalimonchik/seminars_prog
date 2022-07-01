Console.Clear();
//Console.SetCursorPosition(10, 2);
//Console.WriteLine("+");

int xa = 30; //отступ по х - 1 символ
int ya = 1; //отступ по y - 1 символ
int xb = 1;
int yb = 15;
int xc = 60;
int yc = 15;

//или можно записать так:
//int xa = 1, ya = 1,
//    xb = 1, yb = 30,
//   xc = 40, yc = 30;

//покажим вершины
Console.SetCursorPosition(xa, ya); //устанавливаем начальную точку
Console.WriteLine("+");//показываем в консоле (на экране) эту точку

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");


int x = xa, y = xb; // определим случайную точку

int count = 10; //счетчик

while(count < 10000)
{
    int what = new Random().Next(0, 3); // [0;3] 0 1 2
    if(what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if(what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if(what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;

}

// фрактальное изображение - треугольник серпинского