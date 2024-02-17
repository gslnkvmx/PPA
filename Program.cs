static double InputDouble(bool onlyPositive = false){
    bool gotDouble;
    double num;

    gotDouble = Double.TryParse(Console.ReadLine(), out num);
    while((onlyPositive & num<0) || !gotDouble){
        Console.WriteLine("Значение введено некорректно, повторите ввод");
        gotDouble = Double.TryParse(Console.ReadLine(), out num);
    }
    return num;
}

static int InputInt(bool onlyPositive = false){
    bool gotInt;
    int num;
     
    gotInt = int.TryParse(Console.ReadLine(), out num);
    while((onlyPositive & num<0) || !gotInt){
        Console.WriteLine("Значение введено некорректно, повторите ввод");
        gotInt = int.TryParse(Console.ReadLine(), out num);
    }
    return num;
}

double X0End, Y0End, hxEnd, hyEnd;
int NEnd;

Console.WriteLine("Введите первое значение X0");
X0End = InputDouble();

Console.WriteLine("Введите первое значение Y0");
Y0End = InputDouble();

Console.WriteLine("Введите шаг по X - только больше нуля");
hxEnd = InputDouble(true);

Console.WriteLine("Введите шаг по Y - только больше нуля");
hyEnd = InputDouble(true);

Console.WriteLine("Введите Количество шагов - только больше нуля");
NEnd = InputInt(true);

for (int i = 0; i < NEnd; i++)
{
    Console.WriteLine((Math.Sqrt(X0End+Y0End)*Math.Log(Y0End))+(Math.Abs(Math.Log(Y0End)))/(Math.Sqrt(X0End*X0End-Y0End*Y0End+3.2)));
    X0End += hxEnd;
    Y0End += hyEnd;
}