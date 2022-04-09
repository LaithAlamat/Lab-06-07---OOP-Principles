using System;

namespace OOP_Part1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Lion c = new Lion();
            Bear  b= new Bear();
            Cow m = new Cow();
            Mamels x = new Mamels();

            Mamels n = new Lion();
            Duck e = new Duck();

            x.Eat();
            c.Eat();
            b.Eat();
            m.Eat();
            m.Multiply();
            e.Sleep();
            n.Eat();

        }
    }
    public abstract class Animal
    {

        public abstract int Number  
        {
            get;
            set;
        }

        public abstract int Age
        {
            get;
            set;
        }

        protected virtual int height { get; } = 1;
        protected virtual int Weight { get; } = 1;



        public virtual string  Eat()
        {
            Console.WriteLine("All Animals eat");
            string ans = "All Animals eat";
            return ans;
            
        }
        public virtual string Sleep()
        {
            Console.WriteLine("All animals sleep");
            string ans = "All animals eat";
            return ans;
        }
        abstract public void Sound();

        abstract public void Multiply();
        
    }

    public interface Abilities
    {
        public string run();
        public void swim();

    }

    public interface LivesIn
    {
        public void Lives();
    }
    public class Mamels : Animal, Abilities, LivesIn
    {

        public override int Number
        {
            get { return 3; }
            set { }
        }
        public override int Age
        {
            get { return 50; }
            set { }
        }

        protected override int height { get; } = 2;

        protected override int Weight { get; } = 2;

        public override string Eat()
        {
            Console.WriteLine("All Mamels eat");
            string ans = "All Mammels eat";
            return ans;
        }
        public override string Sleep()
        {
            Console.WriteLine("All Mamels sleep");
            string ans = "All Mamels eat";
            return ans;
        }
        public override void Sound()
        {
            Console.WriteLine("All Mamels has a sound");
        }
        public override void Multiply()
        {
            Console.WriteLine("All Mamels multiply by birth");
        }

        public void Lives()
        {
            Console.WriteLine("Most Mammels lives on land");
        }

        public string run()
        {
            Console.WriteLine("Most Mammels can run");
            string ans = "most Mammels run";
            return ans;
        }

        public void swim()
        {
            Console.WriteLine("Most Mammels can't swim");
        }
    }
       
    public class Lion : Mamels,LivesIn,Abilities
    {
        public override string Eat()
        {
            Console.WriteLine("All Lions eat");
            string ans = "All Lions eat";
            return ans;
        }
        public override string Sleep()
        {
            Console.WriteLine("All Lions sleep");
            string ans = "All lions sleep";
            return ans;
        }
        public override void Sound()
        {
            Console.WriteLine("Roar");
        }
        public override void Multiply()
        {
            Console.WriteLine("Lions multiply by birth");
        }
        public void Lives()
        {
            Console.WriteLine("Lions lives on land");
        }

        public string run()
        {
            Console.WriteLine("Lions can run");
            string ans = "All Lions run";
            return ans;
        }

        public void swim()
        {
            Console.WriteLine("Lions can't swim");
        }

    }
    public class Bear : Mamels
    {
        public override string Eat()
        {
            Console.WriteLine("Bears eats meat and grass");
            string ans = "All Bears eat";
            return ans;
        }
        public override string Sleep()
        {
            Console.WriteLine("All Bears sleep");
            string ans = "All Bears sleep";
            return ans;
        }
        public override void Sound()
        {
            Console.WriteLine("Growl");
        }
        public override void Multiply()
        {
            Console.WriteLine("Bears multiply bu birth");
        }
    }
    public class Cow: Mamels
    {
        public override string Eat()
        {
            Console.WriteLine("Cows eat grass");
            string ans = "All Cows eat";
            return ans;
        }
        public override string Sleep()
        {
            Console.WriteLine("All Cows sleep");
            string ans = "All Cows sleep";
            return ans;
        }
        public override void Sound()
        {
            Console.WriteLine("Moo");
        }
        public override void Multiply()
        {
            Console.WriteLine("Cows multiply by birth");
        }
    }
    public abstract class Birds : Animal
    {
        public override string Eat()
        {
            Console.WriteLine("All Birds eat");
            string ans = "All Birds eat";
            return ans;
        }
        public override string Sleep()
        {
            Console.WriteLine("All Birds sleep");
            string ans = "All birds sleep";
            return ans;
        }
        public override void Sound()
        {
            Console.WriteLine("All Birds has a sound");
        }
        public override void Multiply()
        {
            Console.WriteLine("All Birds multiply by laying eggs");
        }
    }

    public class Duck : Birds
    {
        public override int Number
        {
            get { return 1; }
            set { }
        }
        public override int Age
        {
            get { return 50; }
            set { }
        }

        protected override int height { get; } = 2;

        protected override int Weight { get; } = 2;
        public override string  Eat()
        {
            Console.WriteLine("Ducks eat grass");
            string ans= "Ducks eat grass";
            return ans;
        }
        public override string Sleep()
        {
            Console.WriteLine("All ducks sleep");
            string ans = "All Cows eat sleep";
            return ans;
        }
        public override void Sound()
        {
            Console.WriteLine("Quack");
        }
        public override void Multiply()
        {
            Console.WriteLine("Ducks multiply by laying eggs");
        }
    }
    public class fish: Animal

    {
        public override int Number
        {
            get { return 1; }
            set { }
        }
        public override int Age
        {
            get { return 50; }
            set { }
        }

        protected override int height { get; } = 2;

        protected override int Weight { get; } = 2;
        public override string Eat()
        {
            Console.WriteLine("All fish eat");
            string ans = "All fish eat";
            return ans;
        }
        public override string Sleep()
        {
            Console.WriteLine("Fish don't sleep");
            string ans = "fish don't sleep";
            return ans;
        }
        public override void Sound()
        {
            Console.WriteLine("Not all fish has a a sound");
        }
        public override void Multiply()
        {
            Console.WriteLine("Fish multiply by laying eggs");
        }
    }
}


