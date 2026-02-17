using System.ComponentModel;
using System.Globalization;
using System.Net.Mail;

public class Animal
{
    private string _species = "";

    private string _name = "";
    private int _age = 0;
    private string _diet = "";
    private int _daysBeforeStarvation = 0;
    private bool _sex = true;
    private int _sexualMaturity = 0;
    private int _endOfReproduction = 0;
    private int _lifeTime = 0;
    private bool _illOrNot = false;

    public void Cry()
    {
        Console.WriteLine(" ");
    }

    // public void IllOrNot()
    // {
    //     if (_illOrNot == false) {
    //         _illOrNot = "Not Ill";
    //     }
    //      if (_illOrNot == true) {
    //         Console.WriteLine("Ill");
    //     }
    // }
    public void ShowInfo(){
                Console.WriteLine($"\nSpecies : {_species}\nName : {_name}\nAge (month): {_age}\nSex : {_sex}\nDiet : {_diet}\nDays before starvation : {_daysBeforeStarvation}\nSexual maturity : {_sexualMaturity}\nAge of the end of reproduction (years): {_endOfReproduction}\nLife time (years): {_lifeTime}\nIllness : {_illOrNot}\n");
        }
        public Animal(string species, string name, int age, string diet, int daysBeforeStarvation, bool sex, int sexualMaturity, int endOfReproduction,int lifeTime, bool illOrNot)
    {
        _species = species;
        _name = name;
        _age = age;
        _diet = diet;
        _daysBeforeStarvation = daysBeforeStarvation;
        _sex = sex;
        _sexualMaturity = sexualMaturity;
        _endOfReproduction = endOfReproduction;
        _lifeTime = lifeTime;
        _illOrNot = illOrNot;
    }
}
