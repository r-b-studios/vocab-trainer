using System.Collections.Generic;
using System;

namespace VocabTrainer
{
    internal class Vocabulary
    {
        private readonly List<string> leftCol = new List<string>();
        private readonly List<string[]> rightCol = new List<string[]>();

        public int Size => leftCol.Count;

        public KeyValuePair<string, string[]> this[int index]
            => new KeyValuePair<string, string[]>(leftCol[index], rightCol[index]);

        public void Add(string left, string[] right)
        {
            leftCol.Add(left);
            rightCol.Add(right);
        }

        public void RemoveAt(int index)
        {
            leftCol.RemoveAt(index);
            rightCol.RemoveAt(index);
        }

        public void Clear()
        {
            leftCol.Clear();
            rightCol.Clear();
        }

        public void ForEach(Action<string, string[]> loop)
        {
            for (int i = 0; i < leftCol.Count; i++)
                loop.Invoke(leftCol[i], rightCol[i]);
        }
    }
}