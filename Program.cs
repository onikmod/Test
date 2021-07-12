using System;

namespace predator_0._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("臭風");
            Console.WriteLine("Разработка  год 1989");
            Console.WriteLine("Протокол Хищник");
            Console.WriteLine("Версия 1.0");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("ИНИЦИАЛИЗАЦИЯ ПРОТОКОЛА ХИЩНИК");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Подтвердите инициализацию протокола.");
            Console.Write("\nВведите подтверждение:");
            string Activation = Console.ReadLine();
            Console.ReadLine();

            if (Activation.Equals("Подтверждаю", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Инициализация подтверждена!");
            }

            else
            {
                Console.WriteLine("В инициализации ОТКАЗАНО");
                Console.WriteLine("*****");
                Console.WriteLine(" СОСИ");
                Console.WriteLine("  ГУБОЙ");
                Console.WriteLine("   ТРЯСИ");
                goto Finish;
                
            }

             Console.ReadLine();

            
            Console.Write("Введите имя подопытного:");
            string name = Console.ReadLine();
            Console.WriteLine("\nНачата инициация протокола ОТРИЦАНИЕ");
            Console.WriteLine($"\nНулевой Пациент: {name} ");
            Console.ReadLine();
            Console.WriteLine("\nПротокол ОТРИЦАНИЕ инициирован...........");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("...........Три...........\n...........Два...........\n...........Один..........");
            Console.ReadLine();
            Console.WriteLine($"(-_-(-_-)-_-) Я МЫ - {name}  (-_-(-_-)-_-)");
            Console.ReadLine();
            Console.Clear();



            Console.WriteLine($"Привет,{name}. Я твой Личный помошник, помогу тебе с твоими Личными делами");
            Console.WriteLine($"\nНапомни {name} какой сегодня день недели?");
            Console.WriteLine("\nВведите день недели:");
            string VovanistiePlani = Console.ReadLine();
            if (VovanistiePlani.Equals("Понедельник", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("\nВот НАШИ планы на Понедельник:");
                Console.WriteLine("1. Помочь Бабушке.");
                Console.WriteLine("2. Съездить к дедушке.");
                Console.WriteLine("3. Приготовить еды.");
                Console.WriteLine("4. Хорошенько РАССЛАБИТЬСЯ.");

            }
            else if ((VovanistiePlani.Equals("Вторник", StringComparison.CurrentCultureIgnoreCase)))
            {
                Console.WriteLine("\nВот НАШИ планы на Вторник:");
                Console.WriteLine("1. Выгулять собаку.");
                Console.WriteLine("2. Навестить внучатого племянника бабы сраки.");
                Console.WriteLine("3. Поесъци");
                Console.WriteLine("4. Хорошенько РАССЛАБИТЬСЯ.");
            }
            else if ((VovanistiePlani.Equals("Среда", StringComparison.CurrentCultureIgnoreCase)))
            {
                Console.WriteLine("\nВот НАШИ планы на Среду:");
                Console.WriteLine("1. Построить далекоидущие планы на выходные.");
                Console.WriteLine("2. Оговорить договоренности на выходные с Батей.");
                Console.WriteLine("3. Приготовить еды.");
                Console.WriteLine("4. Хорошенько РАССЛАБИТЬСЯ.");
            }
            else if ((VovanistiePlani.Equals("Четверг", StringComparison.CurrentCultureIgnoreCase)))
            {
                Console.WriteLine("\nВот НАШИ планы на Четверг:");
                Console.WriteLine("1. Оговорить с друзьями далекоидущие планы на далекоидущие выходные.");
                Console.WriteLine("2. Уже наверняка договориться что поедешь с батей, а не с друзьями.");
                Console.WriteLine("3. Приготовить еды.");
                Console.WriteLine("4. Хорошенько РАССЛАБИТЬСЯ.");

            }
            else if ((VovanistiePlani.Equals("Пятница", StringComparison.CurrentCultureIgnoreCase)))
            {
                Console.WriteLine("\nВот НАШИ планы на Пятницу:");
                Console.WriteLine("1. Отменить далекоидущие планы с друзьями, чтобы уехать с батей на дачу.");
                Console.WriteLine("2. Играть с мамой в карты.");
                Console.WriteLine("3. Приготовить еды.");
                Console.WriteLine("4. Гулять с собайкой и маминой подругой.");
                Console.WriteLine("5. Немножечко выпить чтобы ХОРОШЕЧНО РАССЛАБИТЬСЯ.");
                Console.WriteLine("6. Хорошенько РАССЛАБИТЬСЯ.");
            }
            else if ((VovanistiePlani.Equals("Суббота", StringComparison.CurrentCultureIgnoreCase)))
            {
                Console.WriteLine("\nВот НАШИ планы на Субботу:");
                Console.WriteLine("1. Отменить далекоидущие планы с друзьями, чтобы уехать с батей на дачу.");
                Console.WriteLine("2. Играть с мамой в карты.");
                Console.WriteLine("3. Приготовить еды.");
                Console.WriteLine("4. Гулять с собайкой и маминой подругой.");
                Console.WriteLine("5. Немножечко выпить чтобы ХОРОШЕЧНО РАССЛАБИТЬСЯ.");
                Console.WriteLine("6. Хорошенько РАССЛАБИТЬСЯ.");
            }
            else if ((VovanistiePlani.Equals("Воскресенье", StringComparison.CurrentCultureIgnoreCase)))
            {
                Console.WriteLine("\nВот НАШИ планы на Воскресенье:");
                Console.WriteLine("1. Отменить далекоидущие планы с друзьями, чтобы уехать с батей на дачу.");
                Console.WriteLine("2. Играть с мамой в карты.");
                Console.WriteLine("3. Приготовить еды.");
                Console.WriteLine("4. Гулять с собайкой и маминой подругой.");
                Console.WriteLine("5. Немножечко выпить чтобы ХОРОШЕЧНО РАССЛАБИТЬСЯ.");
                Console.WriteLine("6. Хорошенько РАССЛАБИТЬСЯ.");
            }


            Console.ReadLine();
            Console.WriteLine("\nОй, и напомни пожалуйста, сколько это МЫ там весим?");
            Console.Write("\nВведите вес:");
            int Fweight = Convert.ToInt32(Console.ReadLine());
            Fweight = Fweight - 12;
            var Zdorovyak = Fweight >= 100 ? $"Здоровяк, Здоровяк. Так держать {name}!" : $"Надо бы поднажать.{name} кушай, кушай никого не слушай!";
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"НАШ вес на сегодняшний день равен {Fweight} килограмма");
            Console.WriteLine(Zdorovyak);
            Console.ReadLine();
            Console.WriteLine($"Удачного НАМ дня {name}!");
            Console.WriteLine("И главное помни ЧТО СЪЕЛ - ТО *****");
            Console.WriteLine("(_I_)");
            Console.ReadLine();





        Finish:
            Console.WriteLine("Завершение протокола Хищник");
            Console.ReadLine();
        }
    }
}


