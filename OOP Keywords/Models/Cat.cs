using System.Reflection.Emit;

namespace OOP_Keywords.Models;

internal class Cat : Animal
{
    public bool barren { get; set; }
    public Cat(string nickName, double age, bool gender, int energy, int price, int mealQuantity, bool barren)
        : base(nickName, age, gender, energy, price, mealQuantity)
    {
        this.barren = barren;
    }

    public override void Eat()
    {
        if (mealQuantity - 8 >= 0) { mealQuantity -= 8; }
        else Console.WriteLine($"{Nickname}'s stomach was full");
        Console.WriteLine($"{this.Nickname} is eating...");
        Thread.Sleep(1000);
        energy += 10;
        price += 30;
        
    }

    public override void Play()
    {

        Console.WriteLine($"{this.Nickname} is playing with your fingers)...");
        Thread.Sleep(1000);
        energy -= 5;
        if(energy == 0)
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
            energy += 10;
        }
        else Console.WriteLine($"{this.Nickname} dont need sleep.{this.Nickname} wont to play with something.");
    }
}
