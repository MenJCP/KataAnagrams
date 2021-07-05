using System;
using System.Collections;

namespace KataGrupal
{
     public class Program
    {
        public class Anagram
        {
            public Hashtable ListAnagrams;
            public Hashtable Index;
           
           public string[] readTxt(string path){

            string[] Words = new string[];
            int i = 0;
                while ((line = file.ReadLine()) != null)
                {
                    Words[i] = line;
                    i++;
                }

           }
           
           
            public void FindAnagrams(string[] words)
            {
                
                ListAnagrams = new Hastable();
                Index = new Hastable();

                for (int i = 0; i < words; i++)
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
                        ListAnagrams.Add(Word, Words[i]);
                    }
                }
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
