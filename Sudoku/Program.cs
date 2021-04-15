using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sudoku
{
    class Program
    {
        static void Main(string[] args)
        {

            string sudoku =
                     @"1 3 2 5 7 9 4 6 8
                       4 9 8 2 6 1 3 7 5  
                       7 5 6 3 8 4 2 1 9  
                       6 4 3 1 5 8 7 9 2
                       5 2 1 7 9 3 8 4 6
                       9 8 7 4 2 6 5 3 1
                       2 1 4 9 3 5 6 8 7
                       3 6 5 8 1 7 9 2 4
                       8 7 9 6 4 2 1 5 3";

            

            int[,] linhasSudoku = new int[9, 9];
            int[,] colunasSudoku = new int[9, 9];
            int[,] numerosNoBloco = new int[9, 9];

            using (StringReader sudokuReader = new StringReader(sudoku))
            {
                
                //
                string linhaSudoku = "";
                for (int x = 0; x < 9; x++)
                {
                    linhaSudoku = sudokuReader.ReadLine();

                    string[] valores = linhaSudoku.Trim().Split();

                    for (int y = 0; y < 9; y++)
                    {
                        linhasSudoku[x, y] = Convert.ToInt32(valores[y]);
                    }

                }
                
                //

                for (int x = 0; x < 9; x++)
                {
                    for (int y = 0; y < 9; y++)
                        colunasSudoku[x, y] = linhasSudoku[y, x];

                }
                
                //
                int bloco = 0;
                for (int b = 0; b < 9; b++)
                {
                    bloco = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            int x = i + b % 3 * 3;
                            int y = j + b / 3 * 3;
                            numerosNoBloco[b, bloco] = linhasSudoku[x, y];
                            bloco++;
                        }
                    }


//----------------------------------------------------------                
                }   
            }
        } 
    }
}
