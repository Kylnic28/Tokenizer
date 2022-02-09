using System.Collections;
using System.Collections.Generic;

namespace Sharp.Tokenizer
{
    public class Tokenizer
    {
        private Array _Array { get; init; }
        public Tokenizer(string content, char separator) => _Array = content.Split(separator);

        /// <summary>
        /// Return the value stored into the specified index.
        /// </summary>
        /// <param name="index">Index</param>
        /// <returns>Dynamic value</returns>
        public dynamic? this[int index]
        {
            get
            {
                if (index < 0 || index > Length)
                    throw new IndexOutOfRangeException($"Index {index} is out of range. Length of this tokenizer is {Length}!");

       
                return _Array.GetValue(index);
            }
        }

        /// <summary>
        /// Return the size of this tokenizer.
        /// </summary>
        public int Length => _Array.Length;

        /// <summary>
        /// Check if this tokenizer is empty or not. 
        /// </summary>
        public bool IsEmpty => Length < 0;
    }

}