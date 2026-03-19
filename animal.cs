using System.ComponentModel;
using System.Globalization;
using System.Net.Mail;
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

    // public void IllOrNot()
    // {
    //     if (_illOrNot == false) {
    //         _illOrNot = "Not Ill";
    //     }
    //      if (_illOrNot == true) {
    //         Console.WriteLine("Ill");
    //     }
    // }
            public Animal(string species, string name, int age, string diet, int daysBeforeStarvation,double kgPerDay, bool sex, int sexualMaturity, int endOfReproduction,int lifeTime, bool illOrNot, bool firstMonth)
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
    }

    public void ShowInfo(){
                Console.WriteLine($"\nSpecies : {_species}\nName : {_name}\nAge (month): {_age}\nSex : {_sex}\nDiet : {_diet}\nHow much I eat per day (Kg): {_kgPerDay}\nDays before starvation : {_daysBeforeStarvation}\nSexual maturity (years) : {_sexualMaturity}\nAge of the end of reproduction (years): {_endOfReproduction / 12}\nLife time (years): {_lifeTime / 12}\nIllness : {_illOrNot}\n");
        }

}
