using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjCharGenerator
{
    public class BigrammPairWord : Generator
    {
        string path = "sourse/WordPair.txt";

        string[] items;
        int[] weights;

        public BigrammPairWord(Random rd = null, int linesRead = 100) : base(rd) { }

        void CreateItemsAndWeights()
        {
            int lines = 200;

            weights = new int[lines];
            items = new string[lines];

            StreamReader reader = new StreamReader(path);

            for (int i = 0; i < lines; i++)
            {
                string line = reader.ReadLine();

                string[] splitLine = line.Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries);

                weights[i] = Convert.ToInt32(splitLine[0]);
                items[i] = splitLine[1].ToLower() + " " + splitLine[2].ToLower();
            }
        }

        protected override void InitilizeWeightAndItems()
        {
            CreateItemsAndWeights();

            _weights = weights;
            _items = items;
        }
    }
}
