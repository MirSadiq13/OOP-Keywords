namespace OOP_Keywords.Models;

internal class Dog : Animal
{
    public bool leash { get; set; }
    public Dog(string nickName, double age, bool gender, int energy, int price, int mealQuantity,bool leash) 
        : base(nickName, age, gender, energy, price, mealQuantity)
    {
        this.leash = leash;
    }


    public override void Eat()
    {
        if (mealQuantity - 10 >= 0) { mealQuantity -= 10; }
        else Console.WriteLine($"{Nickname}'s stomach was full");
        Console.WriteLine($"{this.Nickname} is eating...");
        Thread.Sleep(1000);
        energy += 30;
        price += 50;
        


    }

    public override void Play()
    {

        Console.WriteLine($"{this.Nickname} is playing with your ball)...");
        Thread.Sleep(1000);
        energy -= 20;
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
            energy += 20;
        }
        else Console.WriteLine($"{this.Nickname} dont need sleep.{this.Nickname} wont to play with something.");
    }
}
