using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcodeinterviewquestions.Design
{
    public class RandomizedSet
    {
        Dictionary<int, int> data;
        Random rnd;
        public RandomizedSet()
        {
            data = new Dictionary<int, int>();
            rnd = new Random();
        }
        public bool Insert(int val)
        {
            if (data.ContainsKey(val))
                return false;
            data.Add(val, val);
            return true;
        }
        public bool Remove(int val)
        {
            return data.Remove(val);
        }
        public int GetRandom()
        {
            var keyN = rnd.Next(0, data.Keys.Count);
            return data.Keys.ElementAt(keyN);
        }
    }
}
