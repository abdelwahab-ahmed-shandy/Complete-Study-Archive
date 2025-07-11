/*
Inheritance with Customization:

Create a parent class named Animal that contains the properties:
Name
Sound

Create subclasses like:
Dog adds a Breed property and a function that displays the dog's name, breed, and sound.
Cat adds a Color property and a function that displays the cat's color, name, and sound.
 */
namespace Inheritance_with_Customization
{
    class Animal
    {
        public Animal(string name, string sound)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("Enter A Valid Name");
            if (string.IsNullOrWhiteSpace(sound))
                throw new ArgumentNullException("Enter A Valid Sound");
            
            Name = name;
            Sound = sound;
        }

        public string Name { get; set; }
        public string Sound { get; set; }
    }
    class Dog : Animal
    {
        public Dog(string name, string breed, string sound) : base(name, sound)
        {
            if (string.IsNullOrWhiteSpace(Name))
                throw new ArgumentNullException("Enter A Valid Breed");
            Breed = breed;
        }
        public string Breed { get; set; }

        public void PrintInfoDog()
        {
            Console.WriteLine($"The Dog Name is {Name} And Breed Is {Breed} And The Sound Is {Sound}");
        }
    }
    class Cat : Animal
    {
        public Cat(string name, string breed, string sound) : base(name, sound)
        {
            if (string.IsNullOrWhiteSpace(Name))
                throw new ArgumentNullException("Enter A Valid Breed");
            Breed = breed;
        }
        public string Breed { get; set; }

        public void PrintInfoCat()
        {
            Console.WriteLine($"The Dog Name is {Name} And Breed Is {Breed} And The Sound Is {Sound}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("bosy", "Siamese Cat" , "NoNo");
            Dog dog = new Dog("Ayy Hagaa", "Alaskan Malamute", "HwwHww");
            
            cat.PrintInfoCat();
            dog.PrintInfoDog();
        }
    }
}


