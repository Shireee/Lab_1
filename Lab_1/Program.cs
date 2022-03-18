
namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab N1 - Encapsulation ");
            Console.WriteLine("Bagdeev Vladimir");

            // Creare complex numbers
            Complex a = new Complex() { Real = 3, Imag = 0.5 };
            Complex b = new Complex() { Real = 2, Imag = 0.8 };

            a.Add(b);
            b.Subtract(a);

            Console.WriteLine("a = {0} + {1}i",a.Real,a.Imag);
            Console.WriteLine("b = {0} + {1}i", b.Real, b.Imag);

            a.Divide(b);
            Console.WriteLine("a = {0} + {1}i", a.Real, a.Imag);
            b.Multiplicate(a);
            Console.WriteLine("b = {0} + {1}i", b.Real, b.Imag);
            Console.WriteLine();
            Console.WriteLine();
            // Creare student 
            Student s1 = new Student() { age = 19, haircolor = "ashy", hobbi = "self-development", gender = "male", Name = "Vladimir" };
            Student s2 = new Student() { age = 18, haircolor = "brown", hobbi = "language learning", gender = "female", Name = "Kristina" };
            Student s3 = new Student() { age = 20, haircolor = "brown", hobbi = "degradation", gender = "male", Name = "Sergay" };

            Console.WriteLine(s1.StudAdd(s1));
            Console.WriteLine(s1.StudAdd(s3));
            Console.WriteLine(s2.StudAdd(s3));

           

        }
    }
}