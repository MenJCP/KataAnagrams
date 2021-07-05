using Microsoft.VisualStudio.TestTools.UnitTesting;
using KataGrupal;
using System;


namespace AnagramTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TimeTester()
        {
            var instance = new Program.Anagram();
            string[] Words = {"amor","roma","moro","",""};
        

            DateTime startTime= DateTime.Now;
            instance.FindAnagrams(Words);
            TimeSpan result = (DateTime.Now - startTime);


            TimeSpan Test = new TimeSpan(0, 0, 0, 2);
            Assert.IsTrue(TimeSpan.Compare(result, Test) < 1);
        }
    }
}