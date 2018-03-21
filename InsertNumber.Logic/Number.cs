using System;

namespace InsertNumber.Logic
{
    /// <summary>
    /// Class contains methods for working with numbers.
    /// </summary>
    public static class Number
    {
        /// <summary>
        /// Insert one number into another from bit i to bit j.
        /// </summary>
        /// <param name="sourceNumber">The number in with another is inserted.</param>
        /// <param name="insertNumber">Insertion number.</param>
        /// <param name="i">Number of bit where insert start.</param>
        /// <param name="j">Number of bit where insert finish. </param>
        public static int InsertNumber(int sourceNumber, int insertNumber, int i, int j)
        {
            const int SIZE = sizeof(int) * 8;

            if (i > j)
            {
                throw new ArgumentException(nameof(i));
            }

            if (i < 0 || i >= SIZE)
            {
                throw new ArgumentOutOfRangeException(nameof(i));
            }

            if (j < 0 || j >= SIZE)
            {
                throw new ArgumentOutOfRangeException(nameof(j));
            }

            int firstTemp = ((int.MaxValue >> SIZE - 2 - i) & sourceNumber) | ((sourceNumber >> j + 1) << j + 1);
            int secondTemp = ((int.MaxValue >> SIZE - 2 - (j - i + 1)) & insertNumber) << i;
            return firstTemp | secondTemp;
        }
    }
}
