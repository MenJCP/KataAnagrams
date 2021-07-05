using System.Collections.Generic;
using System;
using System.Collections;
using System.Linq;

namespace KataGrupal
{
     public class Program
    {
        public class Anagram
        {
            public Hashtable ListAnagrams;
            public Hashtable Index;
           
           public List<string> readTxt(string path){

            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            List<string> Words = new List<string>();
            int o = 0;
                while ((line = file.ReadLine()) != null)
                {
                    Words[o] = line;
                    o++;
                }
            return Words;
           }
           
           
            public void FindAnagrams(string[] words)
            {
                
                ListAnagrams = new Hashtable();
                Index = new Hashtable();

                for (int i = 0; i < words.Count(); i++)
                {

                    //Ordenar la palabra
                    string Word = new String(words[i].OrderBy(x => x).ToArray());

                    //Verificar si la palabra se encuentra en el hashtable
                    if (ListAnagrams.ContainsKey(Word))
                    {
                        //concatenar la palabra sin ordenar al grupo de anagramas
                        ListAnagrams[Word] = (ListAnagrams[Word] + ", " + words[i]);

                        //si la palabra no se encuentra en INDEX se agrega para tener
                        //una lista de las palagras que si son anagramas
                        if (!Index.ContainsKey(Word)) {
                            Index.Add(Word, Word);
                        }
                    }else
                    {
                        ListAnagrams.Add(Word, words[i]);
                    }
                }
                
                 //IMPRIMIR LA LISTA DE ANAGRAMAS EN BASE A *INDEX*
                int a = 0;
                foreach (DictionaryEntry item in Index)
                 {
                    a++;
                     Console.WriteLine(ListAnagrams[item.Value]);
                 }
                Console.WriteLine("cantidad " + a);
        }
            }
            
        
       
        


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    
}
}