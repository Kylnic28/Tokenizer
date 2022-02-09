namespace Tokenizer
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
        /// Convert this tokenizer into a enumerable.
        /// </summary>
        /// <returns>A dynamic enumerable.</returns>
        public IEnumerable<dynamic> ToEnumerable() => _Array.OfType<object>().Select(o => o);

        /// <summary>
        /// Return the size of this tokenizer.
        /// </summary>
        public int Length => _Array.Length;

        /// <summary>
        /// Check if this tokenizer is empty or not. 
        /// </summary>
        public bool IsEmpty => Length < 0;

        /// <summary>
        /// Print the unformatted data.
        /// </summary>
        /// <returns>Unformatted data.</returns>
        public override string ToString()
        {
            string unformattedData = string.Empty;

            foreach (var data in ToEnumerable().ToArray())
                unformattedData += data;

            return unformattedData;
        }
    }

}