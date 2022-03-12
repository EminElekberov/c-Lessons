using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masterClassTask
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  https://gist.github.com/6c74021c158b023aa735d7df69e17fc5.git
            //ArrayList array = new ArrayList();
            //array.Add(10);
            //array.Add(20);
            //array.Add(35);
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}



            //Stack s = new Stack();
            //s.Push(20);
            //s.Push(50);
            //s.Push("emin");
            //foreach (var item in s)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("-------------");
            //s.Pop();
            //foreach (var item in s)
            //{
            //    Console.WriteLine(item);
            //}


            //Queue queue = new Queue();
            //queue.Enqueue(25);
            //queue.Enqueue(89);
            //queue.Enqueue("emin");
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("-----------");
            //queue.Dequeue();
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}


            //Hashtable hashtable = new Hashtable();
            //hashtable.Add(1, "Ramiz");
            //hashtable.Add(2, "Elsen");
            //foreach (DictionaryEntry item in hashtable)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}
            //hashtable.Remove(1);
            //Console.WriteLine("-----------");
            //foreach (DictionaryEntry item in hashtable)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);

            //}


            //List<string> strings = new List<string>();
            //strings.Add("emin");
            //strings.Add("rasim");
            //foreach (var item in strings)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("------");
            //Console.WriteLine(strings.Count());



            //Stack<int> stack = new Stack<int>();
            //stack.Push(20);
            //stack.Push(50);
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}


            //Dictionary<string, int> keyValues = new Dictionary<string, int>();
            //keyValues.Add("emin", 1);
            //keyValues.Add("rahim", 2);

            //foreach (var item in keyValues)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}

            #endregion

            #region 2
            //Dictionary<int, string> dictionary = new Dictionary<int, string>();
            //dictionary.Add(1, "Rehman");
            //dictionary.Add(2, "Emin");
            //Console.WriteLine(dictionary[1]);
            #endregion
            
            //


            
            
            #region  4
            //Master master = new Master();
            //var type = master.GetType();
            //foreach (var item in type.GetProperties())
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("---------");
            //foreach (var item in type.GetMethods())
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("-------");
            //var type2 = typeof(Master);
            //Console.WriteLine("typeof " + type2.GetMethods().Length);
            //Console.ReadLine();
            #endregion



        }
    }
    public class Master
    {
        public string name { get; set; }
        public string surname { get; set; }
        public int Age { get; set; }
        public void PrintInfo()
        {
            Console.WriteLine("Sucess");
        }
    }
}
