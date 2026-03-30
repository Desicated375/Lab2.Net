using System;
using System.Linq;

namespace ClassLibraryLab2;

public class StringAndArrayTools
    {
        public int CountCharOccurrences(string text, char target)
        {
            if (string.IsNullOrEmpty(text)) return 0;
            
            int count = 0;
            foreach (char c in text)
            {
                if (c == target) count++;
            }
            return count;
        }

        public void SortArrayAscending(int[] array)
        {
            if (array == null) return;
            Array.Sort(array); 
        }
    }
