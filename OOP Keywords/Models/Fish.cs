namespace OOP_Keywords.Models;

internal class Fish : Animal
{

    public int flipperCount { get; set; }


    public Fish(string nickName, double age, bool gender, int energy, int price, int mealQuantity, int flipperCount)
        : base(nickName, age, gender, energy, price, mealQuantity)
    {
        this.flipperCount = flipperCount;
    }



    public override void Eat()
    {
        if (mealQuantity - 3 >= 0) { mealQuantity -= 3; }
        else Console.WriteLine($"{Nickname}'s stomach was full");
        Console.WriteLine($"{this.Nickname} is eating...");
        Thread.Sleep(1000);
        energy += 14;
        price += 10;
        


    }

    public override void Play()
    {

        Console.WriteLine($"{this.Nickname} is playing with other fish)...");
        Thread.Sleep(1000);
        energy -= 8;
        if (energy == 0)
        {
            Console.WriteLine($"{this.Nickname} is so tired.It need to some sleep...");
            Sleep();
        }


    }

    public override void Sleep()
    {
        if (energy < 100)
        {
            Console.WriteLine($"{this.Nickname} is sleeping. Byee)...");
            Thread.Sleep(1000);
            energy += 15;
        }
        else Console.WriteLine($"{this.Nickname} dont need sleep.{this.Nickname} wont to play with something.");
    }
}
