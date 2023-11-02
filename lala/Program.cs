using System;
using System.Collections;
using System.Collections.Generic;
using lala.classes;
using lala.classes.fabrics;


Doctors doctor1 = DoctorsFabric.Create("Антон", 37, "КДЦ", 50000);
Doctors doctor2 = DoctorsFabric.Create("Арсений", 38, "КДЦ", 55000);
Doctors doctor3 = DoctorsFabric.Create("Стас", 40, "КДЦ", 63000);
Nurses nurses1 = NursesFabric.Create("Оксана", 25, "КДЦ", 28000);
Nurses nurses2 = NursesFabric.Create("Сергей", 37, "КДЦ", 30000);
Nurses nurses3 = NursesFabric.Create("Дмитрий", 36, "КДЦ", 32000);
Administrators administrators1 = AdministratorsFabric.Create("Савина", 26, "КДЦ", 25000);
Administrators administrators2 = AdministratorsFabric.Create("Павел", 19, "КДЦ", 25000);
List<Workers> people = new List<Workers> { doctor1, doctor2, doctor3, nurses1, nurses2, nurses3, administrators1, administrators2 };
BubbleSortByZp(people);
void ListOutput()
{
    foreach (Workers person in people)
    {
        person.PrintP();
    }
}


void BubbleSortByZp(List<Workers> people)
{
    for (int j = 0; j < people.Count; j++)
    {
        for (int i = 0; i < people.Count-1; i++)
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