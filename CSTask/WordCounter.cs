using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTask
{
    /// <summary>
    /// Implements words counting in sentence
    /// </summary>
    public class WordCounter:ICounter
    {

        public Dictionary<string,int> Count(string sentence)
        {
            string[] words = sentence.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
            var res = from word in words
                      group word by word.ToLower() into g
                      select new { Word = g.Key, Count = g.Count() };
            return res.ToDictionary(p => p.Word,p=>p.Count);
        }
    }
}
