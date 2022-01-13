using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using static examp.Program;

namespace examp
{
   public static  class Program
    {
         public enum GameType
        {
            Shooter,
            Action,
            Quest
        }
        static void Main(string[] args)
        {
            #region
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
        GameRecorder gameRecorder = new GameRecorder();
            Game game = new Game
            {
                name = "test1",
                Type = GameType.Action
            };
            Game game2 = new Game
            {
                name = "test2",
                Type = GameType.Quest
            };
            Game game3 = new Game
            {
                name = "test3",
                Type = GameType.Shooter
            };
            ConsoleServices console = new ConsoleServices();
            gameRecorder.GameRecorded += console.OnGameRecorded;
            gameRecorder.Record(game);
            gameRecorder.Record(game2);
            gameRecorder.Record(game3);
        }
    }

    
}