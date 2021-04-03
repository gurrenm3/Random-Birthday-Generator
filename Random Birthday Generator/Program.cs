 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Birthday_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            var birthdays = GenerateBirthdays();
            foreach (var item in birthdays)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadLine();
        }

        static List<Birthday> GenerateBirthdays()
        {
            List<Birthday> birthdays = new List<Birthday>();
            const int numBirthdays = 50;
            for (int i = 0; i < numBirthdays; i++)
            {
                var tempBirthday = new Birthday();
                tempBirthday.RandomizeBirthday();

                Birthday? duplicate = birthdays.FirstOrDefault(item => item.IsEqual(tempBirthday));
                while (duplicate.HasValue)
                {
                    tempBirthday.RandomizeBirthday();
                    duplicate = birthdays.FirstOrDefault(item => item.IsEqual(tempBirthday));
                }

                birthdays.Add(tempBirthday);
            }

            return birthdays;
        }
    }
}
