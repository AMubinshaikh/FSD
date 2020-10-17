using System;

namespace SudokuSolver {
    class Program {
        static void Main (string[] args) {

            int[, ] puzzle = {

                { 5, 3, 0, 0, 7, 0, 0, 0, 0 },
                { 6, 0, 0, 1, 9, 5, 0, 0, 0 },
                { 0, 9, 8, 0, 0, 0, 0, 6, 0 },

                { 8, 0, 0, 0, 6, 0, 0, 0, 3 },
                { 4, 0, 0, 8, 0, 3, 0, 0, 1 },
                { 7, 0, 0, 0, 2, 0, 0, 0, 6 },

                { 0, 6, 0, 0, 0, 0, 2, 8, 0 },
                { 0, 0, 0, 4, 1, 9, 0, 0, 5 },
                { 0, 0, 0, 0, 8, 0, 0, 7, 9 }

            };

            if (SudokuPuzzle.SolveSudoku (puzzle, 0, 0)) {
                Console.WriteLine ("+-----+-----+-----+");

                for (int outer = 1; outer < 10; ++outer) {
                    for (int inner = 1; inner < 10; ++inner) {
                        Console.Write ("|{0}", puzzle[outer - 1, inner - 1]);
                    }

                    Console.WriteLine ("|");
                    if (outer % 3 == 0) {
                        Console.WriteLine ("+-----+-----+-----+");
                    }
                }
            }
        }
    }
}