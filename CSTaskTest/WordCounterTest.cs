using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSTask;
using System.Collections.Generic;

namespace CSTaskTest
{
    [TestClass]
    public class WordCounterTest
    {
        [TestMethod]
        public void WordCounterCountExample()
        {
            string sentence = "This is a statement, and so is this.";
            WordCounter wordCounter = new WordCounter();
            Dictionary<string, int> actual = wordCounter.Count(sentence);
            Dictionary<string, int> expected = new Dictionary<string, int>();
            expected.Add("this", 2);
            expected.Add("is", 2);
            expected.Add("a", 1);
            expected.Add("statement", 1);
            expected.Add("and", 1);
            expected.Add("so", 1);
            CollectionAssert.AreEqual(expected, actual);

        }
    }
}
