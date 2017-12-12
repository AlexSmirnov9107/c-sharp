﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice14
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = @" Вот дом, 
 Который построил Джек. 

 А это пшеница, 
 Которая в темном чулане хранится 
 В доме, 
 Который построил Джек. 

 А это веселая птица-синица, 
 Которая часто ворует пшеницу, 
 Которая в темном чулане хранится 
 В доме, 
 Который построил Джек. 

 Вот кот, 
 Который пугает и ловит синицу, 
 Которая часто ворует пшеницу, 
 Которая в темном чулане хранится 
 В доме, 
 Который построил Джек. 

 Вот пес без хвоста, 
 Который за шиворот треплет кота, 
 Который пугает и ловит синицу, 
 Которая часто ворует пшеницу, 
 Которая в темном чулане хранится 
 В доме, 
 Который построил Джек. 

 А это корова безрогая, 
 Лягнувшая старого пса без хвоста, 
 Который за шиворот треплет кота, 
 Который пугает и ловит синицу, 
 Которая часто ворует пшеницу, 
 Которая в темном чулане хранится 
 В доме, 
 Который построил Джек. 

 А это старушка, седая и строгая, 
 Которая доит корову безрогую, 
 Лягнувшую старого пса без хвоста, 
 Который за шиворот треплет кота, 
 Который пугает и ловит синицу, 
 Которая часто ворует пшеницу, 
 Которая в темном чулане хранится 
 В доме, 
 Который построил Джек. 

 А это ленивый и толстый пастух, 
 Который бранится с коровницей строгою, 
 Которая доит корову безрогую, 
 Лягнувшую старого пса без хвоста, 
 Который за шиворот треплет кота, 
 Который пугает и ловит синицу, 
 Которая часто ворует пшеницу, 
 Которая в темном чулане хранится 
 В доме, 
 Который построил Джек. 

 Вот два петуха, 
 Которые будят того пастуха, 
 Который бранится с коровницей строгою, 
 Которая доит корову безрогую, 
 Лягнувшую старого пса без хвоста, 
 Который за шиворот треплет кота, 
 Который пугает и ловит синицу, 
 Которая часто ворует пшеницу, 
 Которая в темном чулане хранится 
 В доме, 
 Который построил Джек.";

            
           
            
            List<string> words = new List<string>(text.Replace(".", " ").Replace(",", " ").Replace("\n", " ").Replace("\r"," ").Split(' '));
            HashSet<string> unicWords = new HashSet<string>(words);
            Dictionary<string, int> countWords = new Dictionary<string, int>();
            foreach (var item in unicWords)
            {
                countWords.Add(item, words.FindAll(word => word == item).Count );
            }
            int i = 0;
            Console.WriteLine("   \t {0,16}", "Слово");
            foreach (var item in countWords)
            {
                Console.WriteLine("{0}. \t {1,15} {2,17}", i++, item.Key,item.Value);
            }
            Console.ReadKey();
        }
    }
}
