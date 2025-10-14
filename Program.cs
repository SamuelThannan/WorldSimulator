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
            Society.Add(adam.MakeChild(eve));
            Society.Add(adam.MakeChild(eve));
            Society.Add(adam.MakeChild(eve));
            Society.Add(adam.MakeChild(eve));
            Society.Add(adam.MakeChild(eve));
            Society.Add(adam.MakeChild(eve));
            Society.Add(adam.MakeChild(eve));

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

            var peopleOver10 = Society.Where(h => h.Age > 8).ToString();

            

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
