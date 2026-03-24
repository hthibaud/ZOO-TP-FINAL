using System.ComponentModel;
using System.Globalization;
using System.Net.Mail;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics.X86;

public class Animal
{
        private string _species = "";
        private string _name = "";
        private int _age = 0;
        private string _diet = "";
        private double _kgPerDay = 0.0;
        private int _daysBeforeStarvation = 0;
        private bool _sex = true;
        private int _sexualMaturity = 0;
        private int _endOfReproduction = 0;
        private int _lifeTime = 0;
        private bool _illOrNot = false;
        private bool _firstMonth = true;
        private double _daysHungry = 0;
        private int _subvention = 0;
        private float _nbPeopleVisited_low = 0;
        private float _nbPeopleVisited_high = 0;
        private bool _pregnant = false;

        private int _gestationTime = 0;

        private int _numberOfKids = 0;

        //Constructor of all animals
        public Animal(string species, string name, int age, string diet, int daysBeforeStarvation, double kgPerDay, bool sex, int sexualMaturity, int endOfReproduction, int lifeTime, bool illOrNot, bool firstMonth, double daysHungry, int subvention, float nbPeopleVisited_low, float nbPeopleVisited_high, bool pregnant, int gestationTime, int numberOfKids)
        {
                _species = species;
                _name = name;
                _age = age;
                _diet = diet;
                _kgPerDay = kgPerDay;
                _daysBeforeStarvation = daysBeforeStarvation;
                _sex = sex;
                _sexualMaturity = sexualMaturity;
                _endOfReproduction = endOfReproduction;
                _lifeTime = lifeTime;
                _illOrNot = illOrNot;
                _firstMonth = firstMonth;
                _daysHungry = daysHungry;
                _subvention = subvention;
                _nbPeopleVisited_low = nbPeopleVisited_low;
                _nbPeopleVisited_high = nbPeopleVisited_high;
                _pregnant = pregnant;
                _gestationTime = gestationTime;
                _numberOfKids = numberOfKids;
        }


        //Shows the info of animals
        public void ShowInfo()
        {
                Console.WriteLine($"\nName : {_name}\nAge (months): {_age}\nSpecies : {_species}\nIllness : {_illOrNot}\n");
        }


        //adds 1 to the age of animals
        public void GrowUpMonths()
        {
                _age++;
        }

        //adds 1 to the gestation time for females (to calculate pregnancy)
        public void AddTimeToGestation()
        {
                _gestationTime++;
        }

        //Sets the "firstMonth" to false
        public void SetFirstMonthToFalse()
        {
                _firstMonth = false;
        }

        //returns the value of firstMonth
        public bool FirstMonth()
        {
                return _firstMonth;
        }

        //makes the animals age from one year to the next one        
        public void GrowUpYears()
        {
                _age += 12;
        }

        //returns the species
        public string GetSpecies()
        {
                return _species;

        }


        //returns how many Kg the animals eat
        public double GetKgPerDay()
        {
                return _kgPerDay;
        }

        //returns the name of the animal 
        public string GetName()
        {
                return _name;
        }


        //returns the age of the animal
        public int GetAge()
        {
                return _age;
        }

        //returns the life time of the animal
        public int GetLifeTime()
        {
                return _lifeTime;
        }


        //returns the number of day they can wait before having starvation
        public int GetDaysBeforeStarvation()
        {
                return _daysBeforeStarvation;
        }

        //sets the number of days they didn't eat
        public void SetHunger(double days)
        {
                _daysHungry = days;
        }

        //returns the number of days they didn't eat
        public double GetHunger()
        {
                return _daysHungry;
        }


        //returns the subvention of the animal
        public int GetSubvention()
        {
                return _subvention;
        }


        //returns how much money this animal make during the low season (nb visitors * price ticket)
        public float GetPriceVisitors_low()
        {
                return _nbPeopleVisited_low * 15; //15 = price of one ticket to make it easier
        }


        //returns how much money this animal make during the high season (nb visitors * price ticket)
        public float GetPriceVisitors_high()
        {
                return _nbPeopleVisited_high * 15;
        }


        //returns how many visitors come see this animal during the low season
        public float GetNbVisitors_low()
        {
                return _nbPeopleVisited_low;
        }


        //returns how many visitors come see this animal during the high season
        public float GetNbVisitors_high()
        {
                return _nbPeopleVisited_high;
        }

        //returns if the animal is pregnant
        public bool IsPregnant()
        {
                return _pregnant;
        }


        //Sets the animal to "pregnant"
        public void SetPregnantTrue()
        {
                _pregnant = true;
        }


        //returns the current gestation time for this animal
        public int GetGestationTime()
        {
                return _gestationTime;
        }


        //Resets the gestation time and the pregnancy of the animal so they don't stay pregnant all their life etc
        public void ResetGestation()
        {
                _gestationTime = 0;
                _pregnant = false;
        }


        //returns the number of kids of the animal
        public int GetNumberOfKids()
        {
                return _numberOfKids;
        }


        //increments the number of kids of the animal
        public void IncrNumberOfKids()
        {
                _numberOfKids++;
        }
}
