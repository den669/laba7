using System;
using System.Collections.Generic;

// Клас, що представляє мураху
public class Ant
{
    public int X { get; set; } // Координата X
    public int Y { get; set; } // Координата Y
    public string Type { get; set; } // Тип мурахи

    public void Move()
    {
        Console.WriteLine($"Мураха типу {Type} рухається до ({X}, {Y})");
    }
}

// Фабрика мурашок, яка використовує патерн "Легковаговик"
public class AntFactory
{
    private Dictionary<string, Ant> ants = new Dictionary<string, Ant>();

    public Ant GetAnt(string type)
    {
        if (ants.ContainsKey(type))
        {
            return ants[type];
        }
        else
        {
            Ant ant;
            if (type == "тип1")
            {
                ant = new Ant { Type = "тип1", X = 0, Y = 0 };
            }
            else if (type == "тип2")
            {
                ant = new Ant { Type = "тип2", X = 10, Y = 5 };
            }
            else
            {
                // Інші типи мурах можна додати за потреби
                throw new ArgumentException("Невідомий тип мурахи");
            }
            ants.Add(type, ant);
            return ant;
        }
    }
}


