﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjCharGenerator
{
    public class BigrammChar : Generator
    {
        char[] alphabet = "абвгдежзиклмнопрстуфхцчшщьыъэюя".ToArray();
        int[] weights =
            {
                2, 12, 35, 8, 14, 7, 6, 15, 7, 7, 19, 27, 19, 45, 5, 11, 26, 31, 27, 3, 1, 10, 6, 7, 10, 1, 0, 0, 2, 6, 9,
                5, 0, 0, 0, 0, 9, 1, 0, 6, 0, 0, 6, 0, 2, 21, 0, 8, 1, 0, 6, 0, 0, 0, 0, 0, 1, 11, 0, 0, 0, 2,
                35, 1, 5, 3, 3, 32, 0, 2, 17, 0, 7, 10, 3, 9, 58, 6, 6, 19, 6, 7, 0, 1, 1, 2, 4, 1, 18, 1, 2, 0, 3,
                7, 0, 0, 0, 3, 3, 0, 0, 5, 0, 1, 5, 0, 1, 50, 0, 7, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                25, 0, 3, 1, 1, 29, 1, 1, 13, 0, 1, 5, 1, 13, 22, 3, 6, 8, 1, 10, 0, 0, 1, 1, 1, 0, 5, 1, 0, 0, 1,
                2, 9, 18, 11, 27, 7, 5, 10, 6, 15, 13, 35, 24, 63, 7, 16, 39, 37, 33, 3, 1, 8, 3, 7, 3, 3, 0, 0, 1, 1, 2,
                5, 1, 0, 0, 6, 12, 0, 0, 5, 0, 0, 0, 0, 6, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                35, 1, 7, 1, 5, 3, 0, 0, 4, 0, 2, 1, 2, 9, 9, 1, 3, 1, 0, 2, 0, 0, 0, 0, 0, 0, 4, 0, 0, 0, 4,
                4, 6, 22, 5, 10, 21, 2, 23, 19, 11, 19, 21, 20, 32, 8, 13, 11, 29, 29, 3, 1, 17, 3, 11, 1, 1, 0, 0, 1, 3, 17,
                1, 1, 4, 1, 3, 0, 1, 2, 4, 0, 5, 1, 2, 7, 9, 7, 3, 10, 2, 0, 0, 0, 1, 3, 2, 0, 0, 0, 0, 0, 0,
                24, 1, 4, 1, 0, 4, 1, 1, 26, 0, 1, 4, 1, 2, 66, 2, 10, 3, 7, 10, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0,
                25, 1, 1, 1, 1, 33, 2, 1, 36, 0, 1, 2, 1, 8, 30, 2, 0, 3, 1, 6, 0, 4, 0, 1, 0, 0, 3, 20,  0, 4, 9,
                18, 2, 4, 1, 1, 21, 1, 2, 23, 0, 3, 1, 3, 7, 19, 5, 2, 5, 3, 9, 1, 0, 0, 2, 0, 0, 5, 1, 1, 0, 3,
                54, 1, 2, 3, 3, 34, 0, 0, 58, 0, 3, 0, 1, 24, 67, 2, 1, 9, 9, 7, 1, 0, 5, 2, 0, 0, 36, 3, 0, 0, 5,
                1, 28, 84, 32, 47, 15, 7, 18, 12, 29, 19, 41, 38, 30, 9, 18, 43, 50, 39, 3, 2, 5, 2, 12, 4, 3, 0, 0, 2, 3, 2,
                7, 0, 0, 0, 0, 15, 0, 0, 4, 0, 0, 9, 0, 1, 46, 0, 41, 1, 0, 6, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 2,
                55, 1, 4, 4, 3, 37, 3, 1, 24, 0, 3, 1, 3, 7, 56, 2, 1, 5, 9, 16, 0, 1, 1, 1, 2, 0, 8, 3, 0, 0, 5,
                8, 1, 7, 1, 2, 25, 0, 0, 6, 0, 40, 13, 3, 9, 27, 11, 4, 11, 82, 6, 0, 1, 1, 2, 2, 0, 1, 8, 0, 0, 17,
                35, 1, 27, 1, 3, 31, 0, 1, 28, 0, 5, 1, 1, 11, 56, 4, 26, 18, 2, 10, 0, 0, 0, 1, 0, 0, 11, 21, 0, 0, 4,
                1, 4, 4, 4, 11, 2, 6, 3, 2, 0, 8, 5, 5, 5, 1, 5, 7, 14, 7, 0, 0, 1, 0, 8, 3, 2, 0, 0, 0, 9, 1,
                2, 0, 0, 0, 0, 2, 0, 0, 2, 0, 0, 0, 0, 0, 1, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                4, 1, 4, 1, 3, 1, 0, 2, 3, 0, 4, 3, 3, 4, 18, 5, 3, 4, 2, 2, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0,
                3, 0, 0, 0, 0, 7, 0, 0, 10, 0, 2, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0,
                12, 0, 0, 0, 0, 23, 0, 0, 13, 0, 2, 0, 0, 6, 0, 0, 0, 0, 7, 1, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0,
                5, 0, 0, 0, 0, 11, 0, 0, 14, 0, 1, 2, 0, 2, 2, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0,
                3, 0, 0, 0, 0, 8, 0, 0, 6, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 1, 9, 1, 3, 12, 0, 2, 4, 7, 3, 6, 6, 3, 2, 10, 3, 9, 4, 1, 0, 16, 0, 1, 2, 0, 0, 0, 0, 0, 0,
                0, 2, 4, 1, 1, 2, 0, 2, 2, 0, 6, 0, 3, 13, 2, 4, 1, 11, 3, 0, 0, 0, 0, 1, 4, 0, 0, 0, 1, 3, 1,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 1, 9, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 2, 1, 2, 1, 0, 0, 3, 1, 0, 1, 0, 1, 1, 1, 3, 1, 1, 7, 0, 0, 0, 1, 1, 0, 4, 0, 0, 0, 0, 0,
                1, 3, 9, 1, 3, 3, 1, 5, 3, 2, 3, 3, 4, 6, 3, 6, 3, 6, 10, 0, 0, 2, 1, 4, 1, 1, 0, 0, 1, 1, 1
            };

        string[] CreateComb()
        {
            string[] combChars = new string[alphabet.Length * alphabet.Length];

            for (int i = 0, count = 0; i < alphabet.Length; i++)
                for (int j = 0; j < alphabet.Length; j++, count++)
                    combChars[count] = alphabet[i].ToString() + alphabet[j].ToString();

            return combChars;
        }


        public BigrammChar(Random rd = null) : base(rd) { }

        protected override void InitilizeWeightAndItems()
        {
            _weights = weights;
            _items = CreateComb();
        }
    }
}
