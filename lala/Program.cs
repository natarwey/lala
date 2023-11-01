using System;
using System.Collections;
using System.Collections.Generic;
using lala.classes;

List<Workers> people = new List<Workers>();
people.Add(new Doctors("Антон", 37, "КДЦ", 50000));
people.Add(new Doctors("Арсений", 38, "КДЦ", 55000));
people.Add(new Doctors("Стас", 40, "КДЦ", 63000));
people.Add(new Nurses("Оксана", 25, "КДЦ", 28000));
people.Add(new Nurses("Сергей", 37, "КДЦ", 30000));
people.Add(new Nurses("Дмитрий", 36, "КДЦ", 32000));
people.Add(new Administrators("Савина", 26, "КДЦ", 25000));
people.Add(new Administrators("Павел", 19, "КДЦ", 25000));
BubbleSortByZp(people);
void ListOutput()
{
    foreach (Workers people in people)
    {
        Console.WriteLine(people.PrintP());
    }
}


void BubbleSortByZp(List<Workers> people)
{
    for (int j = 0; j < people.Count; j++)
    {
        for (int i = 0; i < people.Count; i++)
        {
            if (people[i].Zp > people[i + 1].Zp)
            {
                var temp = people[i];
                people[i] = people[i + 1];
                people[i + 1] = temp;
            }                   
        }            
    }
     ListOutput();
}