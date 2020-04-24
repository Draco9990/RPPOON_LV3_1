using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_LV3_1
{
    class MatrixGenerator
    {
        public static MatrixGenerator instance;
        private RandomGenerator random;

        private MatrixGenerator()
        {
            random = RandomGenerator.GetInstance();
        }

        public static MatrixGenerator GetInstance()
        {
            if(instance == null)
            {
                instance = new MatrixGenerator();
            }
            return instance;
        }

        //Zadatak 2
        public float[][] CreateMatrix(int width, int height)
        {
            float[][] matrix = new float[height][];
            for(int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new float[width];
            }

            for(int i = 0; i < height; i++)
            {
                for(int j= 0; j < width; j++)
                {
                    matrix[i][j] = (float)random.NextDouble();
                }
            }

            return matrix;
            //3 odgovornosti
        }
    }
}
