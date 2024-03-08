using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;

namespace OOP_Keywords.Models;

internal class PetShop
{
    public List<Bird> birds = new List<Bird>();
    public List<Fish> fish = new List<Fish>();
    public List<Dog> dogs = new List<Dog>();
    public List<Cat> cats = new List<Cat>();


    public PetShop(List<Bird> birds, List<Fish> fish, List<Dog> dogs, List<Cat> cats)
    {
        this.birds.AddRange(birds);
        this.fish.AddRange(fish);
        this.dogs.AddRange(dogs);
        this.cats.AddRange(cats);
    }

    public void showPets(int choice)
    {
        switch (choice)
        {
            case 1:
                foreach (Bird bird in birds)
                {
                    bird.showPet();
                }
                break;
            case 2:
                foreach (Fish fishs in fish)
                {
                    fishs.showPet();
                }
                break;
            case 3:
                foreach (Dog dog in dogs)
                {
                    dog.showPet();
                }
                break;
            case 4:
                foreach (Cat cat in cats)
                {
                    cat.showPet();
                }
                break;
            default:
                Console.WriteLine("enter correct variant!");
                Thread.Sleep(1000);
                break;



        }
    }

    public void showPet(int choice, string nickName)
    {
        bool check = false;

        switch (choice)
        {

            case 1:
                foreach (Bird bird in birds)
                {
                    if (bird.Nickname == nickName) { bird.showPet(); check = true; break; }
                    else check = false;

                }
                if (check) break;
                else Console.WriteLine("Your pet is not here!");
                break;
            case 2:
                foreach (Fish fishs in fish)
                {
                    if (fishs.Nickname == nickName) { fishs.showPet(); check = true; break; }
                    else check = false;
                }
                if (check) break;
                else Console.WriteLine("Your pet is not here!");
                break;
            case 3:
                foreach (Dog dog in dogs)
                {
                    if (dog.Nickname == nickName) { dog.showPet(); check = true; break; }

                    else check = false;
                }
                if (check) break;
                else Console.WriteLine("Your pet is not here!");
                break;
            case 4:
                foreach (Cat cat in cats)
                {
                    if (cat.Nickname == nickName) { cat.showPet(); check = true; break; }
                    else check = false;
                }
                if (check) break;
                else Console.WriteLine("Your pet is not here!");
                break;
            default:
                Console.WriteLine("Enter correct choice!");
                Thread.Sleep(1000);
                break;

        }
    }


    public void eatPet(int choice, string nickName)
    {
        bool check = false;

        switch (choice)
        {

            case 1:
                foreach (Bird bird in birds)
                {
                    if (bird.Nickname == nickName) { bird.Eat(); check = true; break; }
                    else check = false;

                }
                if (check) break;
                else Console.WriteLine("Your pet is not here!");
                break;
            case 2:
                foreach (Fish fishs in fish)
                {
                    if (fishs.Nickname == nickName) { fishs.Eat(); check = true; break; }
                    else check = false;
                }
                if (check) break;
                else Console.WriteLine("Your pet is not here!");
                break;
            case 3:
                foreach (Dog dog in dogs)
                {
                    if (dog.Nickname == nickName) { dog.Eat(); check = true; break; }

                    else check = false;
                }
                if (check) break;
                else Console.WriteLine("Your pet is not here!");
                break;
            case 4:
                foreach (Cat cat in cats)
                {
                    if (cat.Nickname == nickName) { cat.Eat(); check = true; break; }
                    else check = false;
                }
                if (check) break;
                else Console.WriteLine("Your pet is not here!");
                break;
            default:
                Console.WriteLine("Enter correct choice!");
                Thread.Sleep(1000);
                break;

        }
    }



    public void playPet(int choice, string nickName)
    {
        bool check = false;

        switch (choice)
        {

            case 1:
                foreach (Bird bird in birds)
                {
                    if (bird.Nickname == nickName) { bird.Play(); check = true; break; }
                    else check = false;

                }
                if (check) break;
                else Console.WriteLine("Your pet is not here!");
                break;
            case 2:
                foreach (Fish fishs in fish)
                {
                    if (fishs.Nickname == nickName) { fishs.Play(); check = true; break; }
                    else check = false;
                }
                if (check) break;
                else Console.WriteLine("Your pet is not here!");
                break;
            case 3:
                foreach (Dog dog in dogs)
                {
                    if (dog.Nickname == nickName) { dog.Play(); check = true; break; }

                    else check = false;
                }
                if (check) break;
                else Console.WriteLine("Your pet is not here!");
                break;
            case 4:
                foreach (Cat cat in cats)
                {
                    if (cat.Nickname == nickName) { cat.Play(); check = true; break; }
                    else check = false;
                }
                if (check) break;
                else Console.WriteLine("Your pet is not here!");
                break;
            default:
                Console.WriteLine("Enter correct choice!");
                Thread.Sleep(1000);
                break;

        }
    }


    public void sleepPet(int choice, string nickName)
    {
        bool check = false;

        switch (choice)
        {

            case 1:
                foreach (Bird bird in birds)
                {
                    if (bird.Nickname == nickName) { bird.Sleep(); check = true; break; }
                    else check = false;

                }
                if (check) break;
                else Console.WriteLine("Your pet is not here!");
                break;
            case 2:
                foreach (Fish fishs in fish)
                {
                    if (fishs.Nickname == nickName) { fishs.Sleep(); check = true; break; }
                    else check = false;
                }
                if (check) break;
                else Console.WriteLine("Your pet is not here!");
                break;
            case 3:
                foreach (Dog dog in dogs)
                {
                    if (dog.Nickname == nickName) { dog.Sleep(); check = true; break; }

                    else check = false;
                }
                if (check) break;
                else Console.WriteLine("Your pet is not here!");
                break;
            case 4:
                foreach (Cat cat in cats)
                {
                    if (cat.Nickname == nickName) { cat.Sleep(); check = true; break; }
                    else check = false;
                }
                if (check) break;
                else Console.WriteLine("Your pet is not here!");
                break;
            default:
                Console.WriteLine("Enter correct choice!");
                Thread.Sleep(1000);
                break;

        }
    }

    public void mealQuantityPet(int choice, string nickName)
    {
        bool check = false;

        switch (choice)
        {

            case 1:
                foreach (Bird bird in birds)
                {
                    if (bird.Nickname == nickName) {Console.WriteLine(bird.mealQuantity); check = true; break; }
                    else check = false;

                }
                if (check) break;
                else Console.WriteLine("Your pet is not here!");
                break;
            case 2:
                foreach (Fish fishs in fish)
                {
                    if (fishs.Nickname == nickName) { Console.WriteLine(fishs.mealQuantity); check = true; break; }
                    else check = false;
                }
                if (check) break;
                else Console.WriteLine("Your pet is not here!");
                break;
            case 3:
                foreach (Dog dog in dogs)
                {
                    if (dog.Nickname == nickName) { Console.WriteLine(dog.mealQuantity); check = true; break; }

                    else check = false;
                }
                if (check) break;
                else Console.WriteLine("Your pet is not here!");
                break;
            case 4:
                foreach (Cat cat in cats)
                {
                    if (cat.Nickname == nickName) { Console.WriteLine(cat.mealQuantity); check = true; break; }
                    else check = false;
                }
                if (check) break;
                else Console.WriteLine("Your pet is not here!");
                break;
            default:
                Console.WriteLine("Enter correct choice!");
                Thread.Sleep(1000);
                break;

        }
    }
    public void removeByNickName(int choice, string nickName)
    {
        bool check = false;

        switch (choice)
        {

            case 1:
                foreach (Bird bird in birds)
                {
                    if (bird.Nickname == nickName) { birds.Remove(bird);Console.WriteLine("Say hi for your new Friend :)"); check = true; break; }
                    else check = false;

                }
                if (check) break;
                else Console.WriteLine("Your pet is not here!");
                break;
            case 2:
                foreach (Fish fishs in fish)
                {
                    if (fishs.Nickname == nickName) { fish.Remove(fishs); Console.WriteLine("Say hi for your new Friend :)"); check = true; break; }
                    else check = false;
                }
                if (check) break;
                else Console.WriteLine("Your pet is not here!");
                break;
            case 3:
                foreach (Dog dog in dogs)
                {
                    if (dog.Nickname == nickName) { dogs.Remove(dog); Console.WriteLine("Say hi for your new Friend :)"); check = true; break; }

                    else check = false;
                }
                if (check) break;
                else Console.WriteLine("Your pet is not here!");
                break;
            case 4:
                foreach (Cat cat in cats)
                {
                    if (cat.Nickname == nickName) { cats.Remove(cat); Console.WriteLine("Say hi for your new Friend :)"); check = true; break; }
                    else check = false;
                }
                if (check) break;
                else Console.WriteLine("Your pet is not here!");
                break;
            default:
                Console.WriteLine("Enter correct choice!");
                Thread.Sleep(1000);
                break;

        }
    }




    
    




}
