namespace BUS
{
    class bus
    {
        private int id;
        public string color;
        public string marka;
        private int people;
        private int speed = 0;
        
        


        public void Print()
        {
            Console.WriteLine("Характеристики:");
            Console.WriteLine($"Номер: {id}");
            Console.WriteLine($"Цвет: {color}");
            Console.WriteLine($"Марка: {marka}");
            Console.WriteLine($"Пасажиры: {people}");
            
            
        }

        public void SpeedFor()///передает инормацио о скорости
        {
            if (speed == 0)
            {
                Console.WriteLine($"Автобус остановился");
            }
            if (speed > 0)
            {
                Console.WriteLine($"Автобус едет со скоростью {speed} км/ч");
            }
        }
        public void SpeedMore() ///скорость увеличилась
        {
            speed += 50;
        }
        public void SpeedStop() // автобус остановился
        {
            speed = 0;
        }


        static bus GetInf() /// заполняем класс
        {
            var bus1 = new bus();

            bus1.id = 626152;
            bus1.color = "black";
            bus1.marka = "ABC";
            bus1.people = 50;
            return bus1;
        }

        internal class Program /// запускаем методы, выводим характеристики
        {
            static void Main(string[] args)
            {
                Console.WriteLine("\t\t== Автобус ==");

                var bus2 = new bus();
                bus2.SpeedFor();
                bus2.SpeedMore();
                bus2.SpeedFor();
                bus2.SpeedStop();
                bus2.SpeedFor();

                bus bus1 = GetInf();
               
                bus1.Print();
                Console.ReadLine();
            }
        }
    }
}