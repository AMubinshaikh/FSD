using System;
 
namespace SudokuSolver
{
  class SudokuPuzzle
  {
    public static bool SolveSudoku(int[,] puzzle, int row, int col)
    {
	   if (row < 9 && col < 9)
	   {
		   if (puzzle[row, col] != 0)
		   {
			if ((col + 1) < 9) 
			{
			return SolveSudoku(puzzle, row, col + 1);
			}
			  else 
			  {
                if ((row + 1) < 9) 
			    {
				  return SolveSudoku(puzzle, row + 1, 0);
			    }
			  else
			  {
                 return true;
			  } 
		      }
	       }
		     else
		   {
			  for (int arrayLoop = 0; arrayLoop < 9; ++arrayLoop)
			  {
				  if (IsAvailable(puzzle, row, col, arrayLoop + 1))
				  {
					 puzzle[row, col] = arrayLoop + 1;

					 if ((col + 1) < 9)
					 {
						if (SolveSudoku(puzzle, row, col + 1))
						{
                          return true;
						} 
						else 
						{
							puzzle[row, col] = 0;
						}
					}
					 else 
					 {
						if ((row + 1) < 9)
					    {
						if (SolveSudoku(puzzle, row + 1, 0)) 
						{
							return true;
						}
						else 
						{
							puzzle[row, col] = 0;
						}
					    }
					
					 else 
					 {
						return true;
					 }
					 }
				  }
			  }
		   }   

		    return false;
	    }
	    else 
	    {
		   return true;
	    }
    }

     private static bool IsAvailable(int[,] puzzle, int row, int col, int num)
     {
	     int rowStart = (row / 3) * 3;
	     int colStart = (col / 3) * 3;

	     for (int arrayLoop = 0; arrayLoop < 9; ++arrayLoop)
	     {
		     if (puzzle[row, arrayLoop] == num) 
			 {
				 return false;
			 }
		     if (puzzle[arrayLoop, col] == num) 
			 {
				 return false;
			 }
		     if (puzzle[rowStart + (arrayLoop % 3), colStart + (arrayLoop / 3)] == num) 
			 {
				 return false;
			 }
	     }

	        return true;
      }
   
  }
}

