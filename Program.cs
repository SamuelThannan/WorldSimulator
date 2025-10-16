namespace WorldSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Human adam = new Human("Adam", Gender.Male, "Garden of Eden", true);
            Human eve = new Human("Eve", Gender.Female, "Garden of Eden", true);

            adam.Age = 35;
            eve.Age = 33;
            List<Human> Society = new List<Human>();


            Console.WriteLine("The beginning of humanity... ");

            Society.Add(adam);
            Society.Add(eve);
            Society.Add(adam.MakeChild(eve, adam));
            Society.Add(adam.MakeChild(eve, adam));
            Society.Add(adam.MakeChild(eve, adam));
            Society.Add(adam.MakeChild(eve, adam));
            Society.Add(adam.MakeChild(eve, adam));
            Society.Add(adam.MakeChild(eve, adam));
            Society.Add(adam.MakeChild(eve, adam));

            Society[2].GetOlder();
            Society[2].GetOlder();
            Society[2].GetOlder();
            Society[2].GetOlder();
            Society[2].GetOlder();
            Society[2].GetOlder();
            Society[2].GetOlder();
            Society[2].GetOlder();
            Society[2].GetOlder();
            Society[2].GetOlder();

            Console.WriteLine($"{Society[2].Name}'s father is {Society[2].Father} and mother {Society[2].Mother}");

            var peopleOver10 = Society.Where(h => h.Age > 8).ToString();

            foreach (Human h in Society)
            {
                Console.WriteLine(h.ToString());
            }

            Console.WriteLine(Human.Population);

            var humanfemales = Society.Where(f => f.Gender == Gender.Female);
            foreach (Human f in humanfemales)
            {
                Console.WriteLine(f.ToString());
            }

            var maleOver20 = Society.Where(m => m.Age > 20 && m.Gender == Gender.Male);

            var childenOfAdamEve = Society.Where(h => h.Age < 20 && h.HomeLocation == "Garden of Eve");

            var oldestAge = Society.Max(h => h.Age);
            var oldestHuman = Society.First(h => h.Age == oldestAge);
            
            Console.WriteLine(oldestHuman.Age + oldestHuman.Name);

            foreach(Human h in Society)
            {
                h.GetOlder();
            }

            var averageAge = Society.Average(h => h.Age);

            adam.Die();
            Console.WriteLine(Human.Population);

            var humansByAge = Society.OrderByDescending(h => h.Age);
            foreach(Human h in humansByAge)
            {
                Console.WriteLine(h.ToString());
            }

            var groups = Society.GroupBy(h => h.Gender);

            foreach(Human h in groups)
            {
                Console.WriteLine(h.ToString());
            }

            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //List<int> evenNumbers = new List<int>();

            //foreach(int number in numbers)
            //{
            //    if(number % 2 == 0)
            //    {
            //        evenNumbers.Add(number);
            //    }
            //}

            //var evenNumbers2 = numbers.Where(n => n % 2 == 0).ToList();
            //foreach(int number in evenNumbers2)
            //{
            //    Console.WriteLine(number);
            //}



        }

    }
}
