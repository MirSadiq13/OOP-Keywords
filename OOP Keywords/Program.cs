
using OOP_Keywords.Models;



Fish fish_1 = new Fish("bob", 0.3, true, 20, 30, 20, 6);
Fish fish_2 = new Fish("tob", 0.4, false, 25, 30, 20, 6);
Fish fish_3 = new Fish("yob", 0.5, true, 20, 30, 20, 6);
Fish fish_4 = new Fish("lob", 0.6, false, 30, 30, 20, 6);
Fish fish_5 = new Fish("rob", 0.7, true, 40, 30, 20, 6);

List<Fish> fishList = new List<Fish>();
fishList.Add(fish_1);
fishList.Add(fish_2);
fishList.Add(fish_3);
fishList.Add(fish_4);
fishList.Add(fish_5);
Dog dog_1 = new Dog("Alex", 1, true, 100, 200, 150, true);
Dog dog_2 = new Dog("Tyrex", 1.5, true, 150, 200, 250, true);
Dog dog_3 = new Dog("Holll", 1, false, 100, 200, 200, false);

List<Dog> dogList = new List<Dog>();
dogList.Add(dog_1);
dogList.Add(dog_2);
dogList.Add(dog_3);

Bird bird_1 = new Bird("lisa", 0.5, false, 50, 80, 40, true);
Bird bird_2 = new Bird("Mia", 0.7, true, 60, 70, 30, true);
Bird bird_3 = new Bird("lisa", 1, false, 70, 95, 45, true);
List<Bird> birdList = new List<Bird>();
birdList.Add(bird_1);
birdList.Add(bird_2);
birdList.Add(bird_3);

Cat cat_1 = new Cat("Mestan", 0.8, false, 60, 300, 70, false);
Cat cat_2 = new Cat("Era", 1.5, true, 90, 200, 80, false);
Cat cat_3 = new Cat("Mestan", 1, false, 80, 180, 100, true);
List<Cat> catList = new List<Cat>();
catList.Add(cat_1);
catList.Add(cat_2);
catList.Add(cat_3);

PetShop petShop = new PetShop(birdList, fishList, dogList, catList);

int display()
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine();
    Console.WriteLine(" 1 -> Show pets");
    Console.WriteLine(" 2 -> buy pet");
    Console.WriteLine(" 3 -> feed pet");
    Console.WriteLine(" 4 -> put the pet to sleep ");
    Console.WriteLine(" 5 -> play with pet");
    Console.WriteLine(" 6 -> mealQuantity of pet");
    Console.WriteLine(" 7 -> Show pet by NickName");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("\nYour choice: ");
    string input = Console.ReadLine();
    return Convert.ToInt32(input);
}

string getName()
{
    Console.WriteLine("Enter your pet name: ");
    string Name = Console.ReadLine();
    return Name;
}
int animals()
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine();
    Console.WriteLine(" 1 -> Birds");
    Console.WriteLine(" 2 -> Fish");
    Console.WriteLine(" 3 -> Dogs");
    Console.WriteLine(" 4 -> Cats");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("\nYour choice: ");
    string input = Console.ReadLine();
    return Convert.ToInt32(input);
}


while (true)
{


    switch (display())
    {
        case 1:
            petShop.showPets(animals());
            break;
        case 2:
            
            petShop.removeByNickName(animals(), getName());
            break;
        case 3:
            
            petShop.eatPet(animals(), getName());
            break;
        case 4:
            petShop.sleepPet(animals(), getName());
            break;
        case 5:
            petShop.playPet(animals(), getName());
            break;

        case 6:
            petShop.mealQuantityPet(animals(), getName());
            break;
        case 7:
            
            petShop.showPet(animals(), getName());
            break;
        default:
            break;

    }
    Console.WriteLine("Click Enter for next.");
    Console.ReadLine();
    //Thread.Sleep(3000);
    Console.Clear();

}
