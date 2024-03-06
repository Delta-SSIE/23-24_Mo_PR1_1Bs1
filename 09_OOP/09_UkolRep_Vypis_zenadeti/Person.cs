using System;


enum SexType : byte { Male, Female }

class Person
{
    public string Name;
    public string Surname;
    public int Age;
    public SexType Sex;

    public string IntroduceSelf()
    {
        string text = $"{Name}, {Surname}, ({Sex}, {Age} years)";
        return text;
    }
}
