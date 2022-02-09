using System.Collections;
using System.Collections.Generic;

namespace Sharp.Tokenizer
{
    [Flags]
    public enum TokenizerFlags
    {
        /// <summary>
        /// Do nothing.
        /// </summary>
        None = StringSplitOptions.None,

        /// <summary>
        /// Remove empty entries.
        /// </summary>
        RemoveEmptyEntries = StringSplitOptions.RemoveEmptyEntries,

        /// <summary>
        /// Trim white-space characters from each substring in the result.
        /// </summary>
        TrimEntries = StringSplitOptions.TrimEntries,
    }
    public class Tokenizer
    {
        private Array _Array { get; init; }

        /// <summary>
        /// Initialize a new Tokenizer class.
        /// </summary>
        /// <param name="content">Content, must be a string.</param>
        /// <param name="separator">Char which separates the content.</param>
        public Tokenizer(string content, char separator, TokenizerFlags flags = TokenizerFlags.None) => _Array = content.Split(separator, (StringSplitOptions)flags);

        /// <summary>
        /// Initialize a new Tokenizer class.
        /// </summary>
        /// <param name="content">Content, must be a string.</param>
        /// <param name="separator">String which separates the content.</param>
        public Tokenizer(string content, string separator, TokenizerFlags flags = TokenizerFlags.None) => _Array = content.Split(separator, (StringSplitOptions)flags);

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