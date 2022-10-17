// Калинин Павел 17.10.2022 
// Знакомство с языками программирования (семинары)
// Урок 6. Двумерные массивы и рекурсия
// Домашняя работа

bool isRepeat = true; 
string s = "";
string taskName = "";

void FillArray(double[,] aAr) {
    Random random = new Random();
    for(int i=0; i<aAr.GetLength(0); i++)
        for(int j=0; j<aAr.GetLength(1); j++)
            aAr[i,j] = random.NextDouble();
}
void PrintArray(double[,] aAr) {
    for(int i=0; i<aAr.GetLength(0); i++) {
        for(int j=0; j<aAr.GetLength(1); j++)
            Console.Write($"{aAr[i,j]} ");
        Console.WriteLine();
    }    
}

// if(false) { // выборочно отключить для отладки

double[,] ar = null;

taskName = "Задание  №1. Показать двумерный массив размером mxn заполненный вещественными числами.";
isRepeat = true;
while(isRepeat) {
    Console.WriteLine("------------------------------------------------\n\r"+taskName);
    Console.WriteLine("Введите количество Столбцов двумерного массива: ");
    int qtyCol = int.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine("Введите количество Строк двумерного массива: ");
    int qtyRow = int.Parse(Console.ReadLine() ?? "0");
    ar = new double[qtyCol,qtyRow];
    FillArray(ar);    
    Console.WriteLine("Ответ:");
    PrintArray(ar);
    Console.WriteLine("");
    Console.Write("----\n\rВыполнить задание еще раз? (0-нет, 1-да):");
    s = Console.ReadLine() ?? "0";
    isRepeat = s != "0";
}    

taskName = "Задание  №2. Задать двумерный массив следующим правилом: Amn = m+n.";
isRepeat = true;
while(isRepeat) {
    Console.WriteLine("------------------------------------------------\n\r"+taskName);
    for(int i=0; i<ar.GetLength(0); i++)
        for(int j=0; j<ar.GetLength(1); j++)
            ar[i,j] = i+j;
    Console.WriteLine("Ответ:");
    PrintArray(ar);
    Console.WriteLine("");
//    Console.Write("----\n\rВыполнить задание еще раз? (0-нет, 1-да):");
//   s = Console.ReadLine() ?? "0";
//   isRepeat = s != "0";
    isRepeat = false;
}    

taskName = "Задание  №3. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты.";
isRepeat = true;
while(isRepeat) {
    Console.WriteLine("------------------------------------------------\n\r"+taskName);
    for(int i=0; i<ar.GetLength(0); i+=2)
        for(int j=0; j<ar.GetLength(1); j+=2)
            ar[i,j] *= ar[i,j];
    Console.WriteLine("Ответ:");
    PrintArray(ar);
    Console.WriteLine("");
//    Console.Write("----\n\rВыполнить задание еще раз? (0-нет, 1-да):");
//   s = Console.ReadLine() ?? "0";
//   isRepeat = s != "0";
    isRepeat = false;
}    


// }