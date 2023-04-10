class Program
{
    static void Main(string[] args)
    {
        // Створення фабрики мурашок
        AntFactory antFactory = new AntFactory();

        // Отримання мурах за допомогою фабрики
        Ant ant1 = antFactory.GetAnt("тип1");
        Ant ant2 = antFactory.GetAnt("тип2");
        Ant ant3 = antFactory.GetAnt("тип1");

        // Рух мурах
        ant1.Move();
        ant2.Move();
        ant3.Move();

        // Виведення результату:
        // Мураха типу тип1 рухається до (0, 0)
        // Мураха типу тип2 рухається до (10, 5)
        // Мураха типу тип1 рухається до (0, 0)
    }
}