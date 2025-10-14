using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldSimulator
{
    public enum Gender
    {
        Male,
        Female
    }
    class Human
    {
        public static long Population = 0;
        // CORE IDENTITY
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public Guid DNA { get; set; }
        public bool IsAlive { get; set; }

        // Biogical and physical
        public double Health { get; set; } = 100.0;
        public double Height { get; set; }
        public double Weight { get; set; }
        public double EnergyLevel { get; set; }
        public double Strength { get; set; }
        public double Endurance { get; set; }
        public double ImmuneSystemStrength { get; set; }
        public double SleepQuality { get; set; }
        public double Hunger { get; set; } = 0.0;
        public double Thirst { get; set; } = 0.0;
        public string BloodType { get; set; }

        // Emotional and Cognitive
        public int Intelligence { get; set; }
        public int Empathy { get; set; }
        public double Creativity { get; set; }
        public double MemoryRetention { get; set; }
        public double Focus {  get; set; }
        public double Curiosity { get; set; }
        public double StressLevel { get; set; }
        public double Wisdom {  get; set; }
        public double Happiness { get; set; }

        // Social
        public List <Human> SocialConnections { get; set; } = new List<Human>();
        public List <string> Skills { get; set; } = new List<string>();
        public double Reputation { get; set; }
        public double Charisma { get; set; }
        public double Integrity { get; set; }

        // Economic and survival
        public decimal Wealth { get; set; }
        public string Occupation { get; set; }
        public string EducationLevel { get; set; }
        public string HomeLocation { get; set; }

        // Existansial
        public string Purpose { get; set; }
        public bool IsReligious { get; set; }
        public double FaithLevel { get; set; }
        public string MoralLevel { get; set; }
        public double LegacyScore { get; set; }

        public Human(string name, Gender gender, string birthLocation, bool isAlive)
        {
            Name = name;
            Gender = gender;
            Age = 0;
            Intelligence = 20;
            Empathy = 20;
            Strength = 5;
            Creativity = 5;
            DNA = Guid.NewGuid();

            IsAlive = isAlive;
            Population++;

        }

        public Human MakeChild(Human partner)
        {
            Random random = new Random();
            string[] maleNames = { "Noah", "Kane", "Abel", "Disable", "Frank", "Abraham" };
            string[] femaleNames = { "Lilith", "Sheniqua", "Sara", "Eva", "Alina", "Beyonce" };

            Gender childGender;
            string childName;

            if(random.Next(0, 2)  == 0)
            {
                childGender = Gender.Male;
                childName = maleNames[random.Next(maleNames.Length)];
            }
            else
            {
                childGender = Gender.Female;
                childName = femaleNames[random.Next(femaleNames.Length)];
            }

            
            Human child = new Human(childName, childGender, partner.HomeLocation, true);
            return child;
        }

        public void GetOlder()
        {
            Age++;
        }

        public override string ToString()
        {
            return $"{Name} {DNA} {Gender} {Age}";
        }

        //public string SkinColor { get; set; }
        //public string EyeColor { get; set; }
        //public bool HasHair { get; set; }
        //public bool HasBeard { get; set; }
        //public int BodyHairLevel { get; set; }
        //public string HairColor { get; set; }
        //public int ArmsAmount { get; set; }
        //public int LegsAmount { get; set; }
        //public double Speed { get; set; }
        //public int ToesAmount { get; set; }
        //public int FingersAmount { get; set; }
        //public int LimbernessLevel { get; set; }
        //public int VisionStrength { get; set; }
        //public int AudioStrength { get; set; }
        //public int PatienceLevel { get; set; }
        //public int SiblingAmount { get; set; }
        //public int ParentAmount { get; set; }
        //public int GrandParentAmount { get; set; }
        //public int FriendAmount { get; set; }
        //public string Hobby { get; set; }




    }
}
