using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace video15
{
    class Program
    {
        static void Main(string[] args)
        {
            #region foreach
            //    Console.OutputEncoding = System.Text.Encoding.UTF8;
            //    List<string> words = new List<string>();
            //START:
            //    for (int i = 0; i < 3; i++)
            //    {
            //        Console.WriteLine("bir soz daxil edin: ");
            //        string word = Console.ReadLine();
            //        words.Add(word);
            //    }
            //    Console.WriteLine("helede soz daxil edilsinmi? (y/n)");
            //    if (Console.ReadKey().Key == ConsoleKey.Y)
            //    {
            //        goto START;
            //    }
            //    Console.WriteLine("icinde a herfi olan sozler:");
            //    foreach (string i in PasswordList(words, i => i.Contains("a")))
            //    {
            //        Console.WriteLine(i);
            //    }
            //    Console.WriteLine("5 herfden uzunnolan sozler");
            //    foreach (string i in PasswordList(words, i => i.Length >= 5))
            //    {
            //        Console.WriteLine(i);
            //    }
            //    Console.WriteLine("terkibinde u herfi olanlari silme");
            //    foreach (string i in PasswordList(words, i => i.Contains("u")))
            //    {
            //        words.Remove(i);
            //        Console.WriteLine(i);
            //    }
            //    Console.WriteLine("terkibinde o herfi olan sozleri not acceptle evezlemek");
            //    foreach (string i in PasswordList(words, i => i.Contains("")))
            //    {
            //        Console.WriteLine(i.Replace("o", "not accept"));
            //    }
            //}
            //public delegate bool FilterString(string word);
            //public static List<string> PasswordList(List<string> words, FilterString filter)
            //{
            //    List<string> newWords = new List<string>();
            //    foreach (var item in words)
            //    {
            //        if (filter(item))
            //        {
            //            newWords.Add(item);
            //        }
            //    }
            //    return newWords;
            //}
            #endregion
            ObservableCollection<string> words = new ObservableCollection<string>()
                {
                    "Hello","car","home"
                };
             words.CollectionChanged += Word_Collection;
            words.Add("Lemon");
            words[0] = "Apple";
            words.Remove("car");
        }
        public static void Word_Collection(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Console.WriteLine($"your words added {e.NewItems[0]}");
                    break;
                case NotifyCollectionChangedAction.Remove:
                    Console.WriteLine($"your words added {e.OldItems[0]}");
                    break;
                case NotifyCollectionChangedAction.Replace:
                    Console.WriteLine($"your words added {e.OldItems[0]}=> {e.NewItems[0]}");
                    break;
            }
        }

    }
}
