﻿using System;


namespace HelloApp
{
    enum Operation
    {
        Add = 1,
        Subtract,
        Multiply,
        Divide
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //если то иначе. забавная хрень switch
            int num1 = 8;
            int num2 = 6;
            if (num1 > num2)
            {
                Console.WriteLine($"Число {num1} больше числа {num2}");
            }
            else if (num1 < num2)
            {
                Console.WriteLine($"Число {num1} меньше числа {num2}");
            }
            else
            {
                Console.WriteLine("Число num1 равно числу num2");
            }

            if (num1 > num2 && num1 == 8)
            {
                Console.WriteLine($"Число {num1} больше числа {num2}");
            }

            Console.WriteLine("Нажмите Y или N");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "Y":
                    Console.WriteLine("Вы нажали букву Y");
                    break;
                case "y":
                    Console.WriteLine("Вы нажали букву Y");
                    break;
                case "N":
                    Console.WriteLine("Вы нажали букву N");
                    break;
                default:
                    Console.WriteLine("Вы нажали неизвестную букву");
                    break;
            }

            //Циклы
            //continue; Продолжить
            //break Прервать
            int i = 0;
            //for (int i = 0; i < 9; i=i+1)
            for (; i < 9;)
            {
                Console.WriteLine($"Квадрат числа {i} равен {i * i}");
                i = i + 1;
            }
            Console.WriteLine("-------------------------------------------------");
            i = 6;
            do
            {
                Console.WriteLine(i);

                i--;
            }
            while (i > 0);

            Console.WriteLine("-------------------------------------------------");
            i = 6;
            while (i > 0)
            {
                Console.WriteLine(i);
                i--;
            }
            Console.WriteLine("-------------для каждого---------------------------");
            //массивы
            int[] nums2 = new int[4] { 1, 2, 3, 5 };
            foreach (int elm in nums2)  //цикл для каждого из 
                                        //последовательно извлекает элементы контейнера и только для чтения
            {
                Console.WriteLine(elm);
            }

            Console.WriteLine("-------------пока----------------");
            //каждый раз объявлять ебучие переменные? а если я ниче не знаю про тип данных?
            int nElem;
            for (nElem = 0; nElem < nums2.Length; nElem++)
            {
                nums2[nElem] = nums2[nElem] * 2;
                Console.WriteLine(nums2[nElem]);
            }

            Console.WriteLine("------------многомерный массив--------------------");

            //многомерный массив
            /*
            Варианты определения двумерных массивов
            int[,] nums1;
            int[,] nums2 = new int[2, 3];
            int[,] nums3 = new int[2, 3] { { 0, 1, 2 }, { 3, 4, 5 } };
            int[,] nums4 = new int[,] { { 0, 1, 2 }, { 3, 4, 5 } };
            int[,] nums5 = new[,] { { 0, 1, 2 }, { 3, 4, 5 } };
            int[,] nums6 = { { 0, 1, 2 }, { 3, 4, 5 } };
            */
            /*
            int[,] mas = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };
            foreach (int x in mas)
                Console.Write($"{x} ");
            Console.WriteLine();

            Console.WriteLine("-------------фор-------------------");
            int[,] mnogomas = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };

            int rows = mnogomas.GetUpperBound(0) + 1;
            int columns = mnogomas.Length / rows;
            // или так
            // int columns = mas.GetUpperBound(1) + 1;


            for (int iz = 0; iz < rows; iz++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mas[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("---------массив массивов------------------");

            //массив массивов
            int[][] numsmm = new int[3][];
            numsmm[0] = new int[] { 1, 2 };
            numsmm[1] = new int[] { 1, 2, 3 };
            numsmm[2] = new int[] { 1, 2, 3, 4, 5 };
            foreach (int[] row in numsmm)
            {
                foreach (int number in row)
                {
                    Console.Write($"{number} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------перебор пока----------------");
            // перебор с помощью цикла for
            for (int ri = 0; ri < numsmm.Length; ri++)
            {

                for (int rj = 0; rj < numsmm[ri].Length; rj++)
                {
                    Console.Write($"{numsmm[ri][rj]} \t");
                }
            }
            Console.WriteLine();
            Console.WriteLine("---------инверсия массива-------------------");
            //инверсия массива
            int[] massiv = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
            int teks;
            int kolvo = massiv.Length;
            int seredina;
            int tmp;

            seredina = kolvo / 2;

            for (teks = 0; teks < seredina; teks++)
            {
                tmp = massiv[teks];
                massiv[teks] = massiv[kolvo - teks - 1];
                massiv[kolvo - teks - 1] = tmp;
                //if (teks > seredina)
                //{
                //    break;
                //}
            }
            foreach (int elemMas in massiv)
            {
                Console.WriteLine(elemMas);
            }


            //сортировка массива, без sort ?
            // ввод чисел
            int[] msc = new int[7];
            Console.WriteLine("Введите семь чисел");
            for (int rce = 0; rce < msc.Length; rce++)
            {
                Console.Write("{0}-е число: ", rce + 1);
                msc[rce] = Int32.Parse(Console.ReadLine());
            }
            //это если с читами
            //Array.Sort(msc);

            //пузырьковая сортировка
            //int temp = 0;
            //int ksim = msc.Length;
            //for (int tsim = 0; tsim < ksim; tsim++) //перебираем весь массив
            //{
            //    for (int tsimin = tsim + 1; tsimin < ksim; tsimin++) //сравниваем оставшуюся часть массива с текущим элементом
            //    {
            //        if (msc[tsimin] < msc[tsim]) //если тек елемент больше то меняем местами
            //        {
            //            temp = msc[tsim];
            //            msc[tsim] = msc[tsimin];
            //            msc[tsimin] = temp;
            //        }
            //    }
            //}

            //сортировка с выбором
            int mintemp = 0;
            int temp = 0;
            int ksim = msc.Length;
            for (int tsim = 0; tsim < ksim; tsim++)  //проходим весь массив
            {
                mintemp = tsim;
                for (int tsimin = tsim + 1; tsimin < ksim; tsimin++)//ищем минимальное значение в остиавшемся массиве
                {
                    if (msc[tsimin] < msc[mintemp]) { mintemp = tsimin; }
                }
                if (msc[mintemp] == msc[tsim]) { continue; } //если минимальное это текущее, то пропускаем
                //меняем местами
                temp = msc[tsim];
                msc[tsim] = msc[mintemp];
                msc[mintemp] = temp;

            }

            // Сортировка вставками {
                //пузырек идет по очереди и меняет местами все подряд, вставками идем по очереди, проверяем "лувую часть" и пихаем на нужное место, если элемент селва меньш текущего
                //быстрая сортировка, делим массив рандомно на две части, проходимся по нему, то что меньше кидаем налево, то что больше на право, затем рекурсией идем в каждую из частей и делаем тоже саамое (сначала левая, потом правая, опять делим и тп)



                foreach (int elemmas in msc)
                {
                    Console.WriteLine(elemmas);
                }



            /*
            Console.Write("Введите свое имя: ");
            string name = Console.ReadLine();       // вводим имя
            Console.WriteLine($"Привет {name}");    // выводим имя на консоль   
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Компания \"Рога и копыта\"");
            Console.WriteLine("Привет \nмир");

            string name_ = "Tom";
            int age = 33;
            bool isEmployed = false;
            double weight = 78.65;
            double height = 1.9;
            Console.WriteLine($"Имя: {name_}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Вес: {weight}");
            Console.WriteLine($"Работает: {isEmployed}");

            Console.WriteLine($"Имя: {name}  Возраст: {age}  Рост: {height}м");
            Console.WriteLine("Имя: {0}  Возраст: {2}  Рост: {1}м", name, height, age);

            Console.Write("Введите имя: ");
            try
            {
                string nameka = Console.ReadLine();
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);

            }

            Console.Write("Введите возраст: ");
            int age3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите рост: ");
            double height3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите размер зарплаты: ");
            decimal salary3 = Convert.ToDec
            imal(Console.ReadLine());
            string name3 = "";
            Console.WriteLine($"Имя: {name3}  Возраст: {age3}  Рост: {height3}м  Зарплата: {salary3}");

            try
            {
                int a = 33;
                int b = 600;
                byte c = checked((byte)(a + b));
                Console.WriteLine(c);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Saymsg("во дела");
            int rez = GetSum();
            Saymsg(rez.ToString());
            */
            main2();
            Console.ReadKey(); //ждет ввона anykey
            }
        static void main2()
        {
           

        }
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    class Account
    {
        private int sum;
        public int Sum
        {
            get { return sum; }
            set
            {
                if (value > 0)
                {
                    sum = value;
                }
            }
        }
    }

}
