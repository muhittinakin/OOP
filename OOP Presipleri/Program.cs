using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Presipleri
{

    // INHERITANCE (Miras Alma)
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Ses çıkarmak.");
        }
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Hav hav!");
        }
    }

    // ENCAPSULATION (Kapsülleme)
    public class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    // ABSTRACTION (Soyutlama)
    public abstract class Shape
    {
        public abstract double CalculateArea();
    }

    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double CalculateArea()
        {
            return Width * Height;
        }
    }

    // POLYMORPHISM (Çok Biçimlilik)
    public class Printer
    {
        public virtual void PrintDocument()
        {
            Console.WriteLine("Belge yazdırılıyor...");
        }
    }

    public class LaserPrinter : Printer
    {
        public override void PrintDocument()
        {
            Console.WriteLine("Lazer yazıcı ile belge yazdırılıyor...");
        }
    }

    public class InkjetPrinter : Printer
    {
        public override void PrintDocument()
        {
            Console.WriteLine("Inkjet yazıcı ile belge yazdırılıyor...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // INHERITANCE (Miras Alma)
            Animal animal = new Animal();
            animal.MakeSound();

            Dog dog = new Dog();
            dog.MakeSound();

            // ENCAPSULATION (Kapsülleme)
            Person person = new Person();
            person.Name = "John";
            Console.WriteLine("Kişinin adı: " + person.Name);

            // ABSTRACTION (Soyutlama)
            Rectangle rectangle = new Rectangle();
            rectangle.Width = 5;
            rectangle.Height = 10;
            Console.WriteLine("Dikdörtgenin alanı: " + rectangle.CalculateArea());

            // POLYMORPHISM (Çok Biçimlilik)
            Printer printer = new Printer();
            printer.PrintDocument();

            LaserPrinter laserPrinter = new LaserPrinter();
            laserPrinter.PrintDocument();

            InkjetPrinter inkjetPrinter = new InkjetPrinter();
            inkjetPrinter.PrintDocument();

            Console.ReadLine();
        }
    }
}
