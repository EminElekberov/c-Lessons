using System;

namespace video7
{
    class Program
    {
        static void Main(string[] args)
        {
            #region INheritiance
            Bird bird = new Bird("qaranqus",17);
            bird.name = "Qaranqus";
            Console.WriteLine(bird.name);
            bird.Eat();
            #endregion

            //CalculateSquare calculate = new CalculateSquare();
            //calculate.x = 5;
            //calculate.y = 6;
            //calculate.Calcualte();
            //Console.WriteLine(calculate.Sahe);
        }
    }

    #region INheritiance Lesson
    // base class yeni esass klasdir valideyndir
    abstract class Animal
    {
        public string name { get; set; }
        public Animal(string nm)
        {
            name = nm;
        }
        public virtual void Eat()
        {
            Console.WriteLine("eat");
        }
        public abstract void eat();
    }
    //derived class yeni base klasdan toreyenler
    class Bird : Animal
    {
        public int Age { get; set; }
        public Bird(string birdName, int age) : base(birdName)
        {
            Age = age;

        }
        public override void Eat()
        {
            Console.WriteLine("birdden gelen metod");
        }

        public override void eat()
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    class CalculateSquare
    {
        public int x { get; set; }
        public int y { get; set; }
        private int _sahe;
        public int Sahe { get { return this._sahe; } }

        public void Calcualte()
        {
            this._sahe = this.x * this.y;
        }
    }
}
