using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace HomeWorkFileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             1.	В файле записана непустая последовательность целых чисел, являющихся числами Фибоначчи. Приписать еще столько же чисел этой последовательности.
2.	Сложить два целых числа А и В.
Входные данные
В единственной строке входного файла INPUT.TXT записано два натуральных числа через пробел.
Выходные данные
В единственную строку выходного файла OUTPUT.TXT нужно вывести одно целое число — сумму чисел А и В.
             */
            Console.Write("1)  ");
            using (StreamReader stream = new StreamReader("NumbersFibanachi.txt"))
            {
                string str = stream.ReadLine();
                var numbers = str.Split(' ').ToList();
                int count = numbers.Count;
                for (int i = 0; i < count; i++)
                {
                    int num = int.Parse(numbers[numbers.Count - 2]) + int.Parse(numbers[numbers.Count - 1]);
                    numbers.Add(num.ToString());
                }
                foreach (var num in numbers)
                {
                    Console.Write("{0} ", num);
                }

            }

            Console.WriteLine();
            Console.Write("2)  ");
            int SUM = 0;
            using (StreamReader stream = new StreamReader("INPUT.txt"))
            {
                string str = stream.ReadLine();
                var numbers = str.Split(' ').ToList();
                int sum = 0;
                for (int i = 0;i < numbers.Count;i++)
                {
                    sum += int.Parse(numbers[i]);
                }
                Console.WriteLine(sum);
                SUM = sum;
            }
            using (StreamWriter stream = new StreamWriter("OUTPUT.txt"))
            {
                stream.Write("Сумма чисел A и B : " + SUM);
            }

                Console.ReadLine();


        }
     
    }
}
