using System;

namespace Laba6
{
    internal class Program
    {
        class Animal
        {
            public string NameAnimal;
            public string food;
            public string location;

            public Animal(string NameAnimal, string food, string location) //конструктор
            {
                this.NameAnimal = NameAnimal;
                this.food = food;
                this.location = location;
            }
            public void eat()
            {
                Console.WriteLine("ест");
            }
            public void makeNoise()
            {
                Console.WriteLine("шумит");
            }
            public void sleep()
            {

                Console.WriteLine("дрыхнет");
            }
        }
        class Dog : Animal //наследуем класс
        {
            public string NameAnimal;

            public Dog(string NameAnimal, string food, string location) : base(NameAnimal, food, location)
            {
            }
            public void eat()
            {
                Console.WriteLine($"{NameAnimal} ест " + food);
            }
            public void makeNoise()
            {
                Console.WriteLine($"{NameAnimal} гавкает");
            }

            public void sleep()
            {
                Console.WriteLine($"{NameAnimal} спит");
            }
        }

        class Cat : Animal //наследуем класс
        {
            public string NameAnimal;

            public Cat(string NameAnimal, string food, string location) : base(NameAnimal, food, location)
            {
            }
            public void eat()
            {
                Console.WriteLine($"{NameAnimal} ест " + food);
            }
            public void makeNoise()
            {
                Console.WriteLine($"{NameAnimal} мяукает");
            }

            public void sleep()
            {
                Console.WriteLine($"{NameAnimal} спит");
            }
        }

        class Hourse : Animal //наследуем класс
        {
            public string NameAnimal;

            public Hourse(string NameAnimal, string food, string location) : base(NameAnimal, food, location)
            {
            }
            public void eat()
            {
                Console.WriteLine($"{NameAnimal} ест " + food);
            }
            public void makeNoise()
            {
                Console.WriteLine($"{NameAnimal} цокает");
            }

            public void sleep()
            {
                Console.WriteLine($"{NameAnimal} спит");
            }
        }

        class Veterenar
        {
            public void ReceptionAnimal(Animal animal)
            {
                Console.Title = "Инфа о животных";
                Console.WriteLine(animal.NameAnimal + " ест: " + animal.food);
                Console.WriteLine("и живёт в " + animal.location + ".");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Сейчас на приёме у Ветеринара\n");
                Console.ResetColor();
            }
        }
        static void Main(string[] args)
        {
            Veterenar veterenar = new Veterenar();

            Dog dog = new Dog("Гафкалкин", "мясо", "домике"); //создаём объекты животных
            Cat cat = new Cat("Мяукалкин", "макароны", "домике");
            Hourse hourse = new Hourse("Фыркунчик", "яблоки", "домике");

            veterenar.ReceptionAnimal(dog);
            veterenar.ReceptionAnimal(cat);
            veterenar.ReceptionAnimal(hourse);
        }
    }
}
