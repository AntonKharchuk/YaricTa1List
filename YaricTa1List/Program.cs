using System;

namespace YaricTa1List
{
    class Program
    {
        static void Main(string[] args)
        {
          
            MyList<int> IntList = new MyList<int>();

            Random random = new Random();


            for (int i = 0; i < 20; i++)
            {
                IntList.Add(random.Next(100));
            }

            Console.WriteLine($"{IntList} мiстить:");
            for (int i = 0; i < IntList.Length(); i++)
            {
                Console.Write(IntList[i] +", ");
            }
            Console.WriteLine();
            Console.WriteLine("---------");


            //-------

            MyList<char> CharList = new MyList<char>();

            for (int i = 0; i < 20; i++)
            {
                CharList.Add((char)random.Next(50));
            }

            Console.WriteLine($"{CharList} мiстить:");
            for (int i = 0; i < CharList.Length(); i++)
            {
                Console.Write(CharList[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("---------");



            //-------

            string[] sArr = { "melanholy","boy", "grosstry", "sheeesh", "magic", "show", "tree", "lambda", "georgia", "lava", "bee", "lily", "koala", "wind", "deck", "war", "happyness", "honey", "mouse", "house", "horse", "treet", "cow", "pan", "world", "jam", "ball", "cat", "limbo", "monitor", "troop", "medicine", "baby", "day", "six", "table", };

            MyList<string> StringList = new MyList<string>();

            for (int i = 0; i < sArr.Length; i++)
            {
                StringList.Add(sArr[i]);
            }
            Console.WriteLine($"{StringList} мiстить:");
            for (int i = 0; i < StringList.Length(); i++)
            {
                Console.Write(StringList[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("---------");



            Console.WriteLine($"Видаляемо: sheeesh, magic, show, tree, lambda, georgia, lava, bee, lily, koala, wind, deck з {StringList}");

            string[] rem = { "sheeesh", "magic", "show", "tree", "lambda", "georgia", "lava", "bee", "lily", "koala", "wind", "deck" };

            foreach (var word in rem)
            {
                StringList.Remove(word);
            }
            Console.WriteLine($"{StringList} мiстить:");
            for (int i = 0; i < StringList.Length(); i++)
            {
                Console.Write(StringList[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("---------");

            Console.WriteLine($"Видаляемо: 10-й, 16-й елементи з {IntList}");

            IntList.RemoveAt(9);
            IntList.RemoveAt(15);

            Console.WriteLine($"{IntList} мiстить:");
            for (int i = 0; i < IntList.Length(); i++)
            {
                Console.Write(IntList[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("---------");

            Console.WriteLine($"Доповнюємо {IntList}");

            IntList.Add(82);
          
            IntList.Add(4);
        
            IntList.Add(57);
            
            IntList[9] = 3;
           
            IntList[0] = 99;

      
            Console.WriteLine($"{IntList} мiстить:");
            for (int i = 0; i < IntList.Length(); i++)
            {
                Console.Write(IntList[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("---------");

            Console.WriteLine($"Вставляємо у {IntList} на позицiї 5, 12, IntList.Length-1");

            IntList.SetInto(5,555);
            IntList.SetInto(12, 1000);
            IntList.SetInto(IntList.Length() - 1, 33);




            Console.WriteLine($"{IntList} мiстить:");
            for (int i = 0; i < IntList.Length(); i++)
            {
                Console.Write(IntList[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("---------");
        }
    }
}
