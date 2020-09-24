using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Codility
{
    public static class Codility
    {
        /// <summary>
        /// Binary Gap
        /// https://app.codility.com/programmers/lessons/1-iterations/binary_gap/
        /// </summary>
        /// <param name="n">Input</param>
        /// <returns>The length of its longest binary gap</returns>
        public static int BinaryGap(int n)
        {
            int output = 0;
            char[] binary = Convert.ToString(n, 2).ToCharArray();

            for (int i = 0; i < binary.Length; i++)
            {
                char c = binary[i];

                if (c == '1')
                {
                    i++;
                    c = binary[i];
                    int counter = 0;

                    while (c == '0')
                    {
                        counter++;
                        i++;
                        c = binary[i];
                    }
                }
            }

            return output;
        }

        /// <summary>
        /// CyclicRotation
        /// https://app.codility.com/programmers/lessons/2-arrays/cyclic_rotation/
        /// </summary>
        /// <param name="A">An array</param>
        /// <param name="K">Number of times to rotate array</param>
        /// <returns>Rotated array</returns>
        public static int[] CyclicRotation(int[] A, int K)
        {
            int skip = K % A.Length;
            int take = A.Length - skip;
            var tmp = A.Skip(skip).Take(take);

            if (skip != 0)
            {
                tmp.Concat(A.Skip(0).Take(skip));
            }

            return tmp.ToArray();
        }
    }
}
