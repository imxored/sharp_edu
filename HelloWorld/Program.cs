using System;


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
            if (false) { 
            Console.Write("Введиме первое слагаемое:");
            int mX = Int32.Parse(Console.ReadLine());
            
            Console.Write("Введиме второе слагаемое:");
            int mY = Int32.Parse(Console.ReadLine());
            
            int result = Sum(mX, mY);
            Console.WriteLine($"Результат: {result}");

            int x = 10;
            GetData(x, 15, out int area, out int perimetr);
            Console.WriteLine("Площадь : " + area);
            Console.WriteLine("Периметр : " + perimetr);

            Addition(1, 2, 3, 4, 5);

            int[] array = new int[] { 1, 2, 3, 4 };
            Addition(array);
             //если у метода вставлен params можно не передавать параметр
             //addition();
             Fibonachi(7);

             Operation op;
             op = Operation.Add;
             Console.WriteLine((int)op); // add
            //перечисления enum
            // Тип операции задаем с помощью константы Operation.Add, которая равна 1
            MathOp(10, 5, Operation.Add);
            // Тип операции задаем с помощью константы Operation.Multiply, которая равна 3
            MathOp(11, 5, Operation.Multiply);
            
            //кортежи
            var (name, age) = ("Tom", 23);
            Console.WriteLine(name);    // Tom
            Console.WriteLine(age);     // 23
            var tuple = (count: 5, sum: 10);
            Console.WriteLine(tuple.count); // 5
            Console.WriteLine(tuple.sum); // 10     

            var tuple2 = GetNamedValues(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            Console.WriteLine(tuple2.count);
            Console.WriteLine(tuple2.sum);

            var (names, ages) = GetTuple(("Tom", 23), 12);
            Console.WriteLine(name);    // Tom
            Console.WriteLine(age);     // 35
            TwoClass ntc = new TwoClass();
            ntc.start();

            //структуры
            User tom = new User("Tom", 34);
            tom.DisplayInfo();

            User bob = new User();
            bob.DisplayInfo();
            }

            State state1 = new State();

            // присвоить значение переменной a у нас не получится,
            // так как она закрытая и класс Program ее не видит
            // И данную строку среда подчеркнет как неправильную

            state1.a = 4; //Ошибка, получить доступ нельзя

            // то же самое относится и к переменной b
            state1.b = 3; // Ошибка, получить доступ нельзя

            // присвоить значение переменной с то же не получится,
            // так как класс Program не является классом-наследником класса State
            state1.c = 1; // Ошибка, получить доступ нельзя

            // переменная d с модификатором internal доступна из любого места программы
            // поэтому спокойно присваиваем ей значение
            state1.d = 5;

            // переменная e так же доступна из любого места программы
            state1.e = 8;

            // переменная f общедоступна
            state1.f = 8;

            // Попробуем вывести значения переменных

            // Так как этот метод объявлен как private, мы можем использовать его только внутри класса State
            state1.Display_f();  // Ошибка, получить доступ нельзя

            // Так как этот метод объявлен как protected, а класс Program не является наследником класса State
            state1.Display_e();  // Ошибка, получить доступ нельзя

            // Общедоступный метод
            state1.Display_a();

            // Метод доступен из любого места программы
            state1.Display_b();

        }
        static void Saymsg(string msg)
        {
            Console.WriteLine(msg);
        }
        static int GetSum()
        {
            int x = 2;
            int y = 3;
            return x + y;
        }
        static int Sum(int x, int y)
        {
            return x + y;
        }
        //параметры возвращаемые out
        static void GetData(int x, int y, out int area, out int perim)
        {
        area = x * y;
        perim = (x + y) * 2;
        }
        static void Addition(params int[] integers)
        {
            int result = 0;
            for (int i = 0; i < integers.Length; i++)
            {
                result += integers[i];
            }
            Console.WriteLine(result);
        }
        //рекурсивный метод
        static int Fibonachi(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return Fibonachi(n - 1) + Fibonachi(n - 2);
            }
        }
        static void MathOp(double x, double y, Operation op)
        {
            double result = 0.0;

            switch (op)
            {
                case Operation.Add:
                    result = x + y;
                    break;
                case Operation.Subtract:
                    result = x - y;
                    break;
                case Operation.Multiply:
                    result = x * y;
                    break;
                case Operation.Divide:
                    result = x / y;
                    break;
            }

            Console.WriteLine("Результат операции равен {0}", result);
        }
        private static (int sum, int count) GetNamedValues(int[] numbers)
        {
            var result = (sum: 0, count: 0);
            for (int i = 0; i < numbers.Length; i++)
            {
                result.sum += numbers[i];
                result.count++;
            }
            return result;
        }
        private static (string names, int ages) GetTuple((string n, int a) tuple, int x)
        {
            var result = (name: tuple.n, age: tuple.a + x);
            return result;
        }

    }
    class TwoClass
    {   
        public void start() { 
        Person tom = new Person();          // вызов 1-ого конструктора без параметров
        Person bob = new Person("Bob");     //вызов 2-ого конструктора с одним параметром
        Person sam = new Person("Sam", 25); // вызов 3-его конструктора с двумя параметрами

        Persona valera = new Persona("Валера", 17);
        valera.GetInfo();
        }

    }
    /*
    class Person
    {
        public string name;
        public int age;

        public Person() { name = "Неизвестно"; age = 18; }      // 1 конструктор

        public Person(string n) { name = n; age = 18; }         // 2 конструктор

        public Person(string n, int a) { name = n; age = a; }   // 3 конструктор

        public void GetInfo()
        {
            Console.WriteLine($"Имя: {name}  Возраст: {age}");
        }
    }
    class Persona
    {
        public string name;
        public int age;
        //this
        public Persona() : this("Неизвестно")
        {
        }
        public Persona(string name) : this(name, 18)
        {
        }
        public Persona(string name, int age)
        {
            //this. - обращение к переменным класса, а не параметрам конструктора
            this.name = name;
            this.age = age;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Имя: {name}  Возраст: {age}");
        }
    }
    struct User
    {
        public string name;
        public int age;
        public User(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}  Age: {age}");
        }
    }
    public class State
    {
        int a; // все равно, что private int a;
        private int b; // поле доступно только из текущего класса
        protected int c; // доступно из текущего класса и производных классов
        internal int d; // доступно в любом месте программы
        protected internal int e; // доступно в любом месте программы и из классов-наследников
        public int f; // доступно в любом месте программы, а также для других программ и сборок
        protected private int g; // доступно из текущего класса и производных классов, которые определены в том же проекте

        private void Display_f()
        {
            Console.WriteLine($"Переменная f = {f}");
        }

        public void Display_a()
        {
            Console.WriteLine($"Переменная a = {a}");
        }

        internal void Display_b()
        {
            Console.WriteLine($"Переменная b = {b}");
        }

        protected void Display_e()
        {
            Console.WriteLine($"Переменная e = {e}");
        }
    }
    */
}