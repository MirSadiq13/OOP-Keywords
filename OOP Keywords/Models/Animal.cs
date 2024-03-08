namespace OOP_Keywords.Models;


public abstract class Animal
{
    public string? Nickname { get; set; }
    public double age { get; set; }
    public bool Gender { get; set; }
    public int energy { get; set; }
    public int price { get; set; }
    public int mealQuantity { get; set; }

    public Animal(string nickName, double age, bool gender, int energy, int price, int mealQuantity)
    {
        this.Nickname = nickName;
        this.age = age;
        this.Gender = gender;
        this.energy = energy;
        this.price = price;
        this.mealQuantity = mealQuantity;
    }

    public void showPet()
    {
        
        Console.WriteLine("Nickname: " + Nickname);
        Console.WriteLine("Age: " + age);
        if (Gender == true) Console.WriteLine("Gender: Male");
        else Console.WriteLine("Gender: Famale");
        Console.WriteLine("Energy: "+ energy);
        Console.WriteLine("price: " + price);
        Console.WriteLine("mealQuantity: " + mealQuantity);
        Console.WriteLine();
    }


    
    public abstract void Eat();
    public abstract void Sleep();
    public abstract void Play();

}






