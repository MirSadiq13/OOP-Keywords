namespace OOP_Keywords.Models;

public class Bird : Animal
{
    public bool abilityToFly { get; set; }



    public Bird(string nickName, double age, bool gender, int energy, int price, int mealQuantity, bool abilityToFly)
        : base(nickName, age, gender, energy, price, mealQuantity)
    {
        this.abilityToFly = abilityToFly;
    }

    public override void Eat()
    {
        if (mealQuantity - 5 >= 0) { mealQuantity -= 5; }
        else Console.WriteLine($"{Nickname}'s stomach was full");
        Console.WriteLine($"{this.Nickname} is eating...");
        Thread.Sleep(1000);
        energy += 10;
        price += 15;
        


    }

    public override void Play()
    {

        Console.WriteLine($"{this.Nickname} is playing with your toys)...");
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
            energy += 10;
        }
        else Console.WriteLine($"{this.Nickname} dont need sleep.{this.Nickname} wont to play with something.");
    }
}
