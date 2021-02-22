using System;
using QueenAttack.Pieces;

namespace QueenAttack
{
  public class Program 
  {
    public static void Main()
    {
      Piece queen = new Piece("Queen");
      Piece pawn = new Piece("Pawn");

      Console.WriteLine("Enter the X coordinate for the Queen's position:");
      string stringQueenXCoord = Console.ReadLine();
      queen.XCoord = int.Parse(stringQueenXCoord);

      Console.WriteLine("Enter the Y coordinate for the Queen's position:");
      string stringQueenYCoord = Console.ReadLine();
      queen.YCoord = int.Parse(stringQueenYCoord);

      Console.WriteLine("Enter the X coordinate for the Pawn's position:");
      string stringPawnXCoord = Console.ReadLine();
      pawn.XCoord = int.Parse(stringPawnXCoord);

      Console.WriteLine("Enter the Y coordinate for the Pawn's position:");
      string stringPawnYCoord = Console.ReadLine();
      pawn.YCoord = int.Parse(stringPawnYCoord);

      if (queen.XCoord == pawn.XCoord)
      {
        Console.WriteLine("Pawn is dead");
      }
      else if (queen.YCoord == pawn.YCoord)
      {
        Console.WriteLine("Pawn is dead");
      }
      else if (queen.XCoord - pawn.XCoord == queen.YCoord - pawn.YCoord)
      {
        Console.WriteLine("Pawn is dead");
      }
      else
      {
        Console.WriteLine("Pawn is safe");
      }
    }
  }
}