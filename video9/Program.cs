using System;
using System.IO;

namespace video9
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleLog log = new ConsoleLog();
            log.Write("program is started ");
            Filelog file = new Filelog();
            file.Write("program is started");
        }
    }
    public abstract class check
    {

    }
    interface ILog
    {
        void Write(String action);
        public void Check()
        {

        }
    }
    class ConsoleLog : ILog
    {
        public void Write(string action)
        {
            Console.WriteLine(DateTime.Now.ToString("dd.MM.yyyy" + " "+action));
        }
       
    }
    class Filelog : ILog
    {
        public void Write(string action)
        {
            string text = DateTime.Now.ToString("dd.MM.yyyy" + " " + action);
            using (StreamWriter word = File.AppendText(@"D:\qasimc#\mina_teacher\newtext.txt"))
            {
                word.WriteLine(text);
            }
        }
    }

    #region Inheritiance Lesson
    interface Isocial
    {
        int x { get; set; }

        void Add();
        void Update();
        void Read();
    }
    interface Isocial2
    {
        void delete();
    }
    public class Base : Isocial, Isocial2
    {
        public int x { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void delete()
        {
            throw new NotImplementedException();
        }

        public void Read()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
    #endregion
}
