using System;

namespace QueenAttack.Pieces
{
  public class Piece
  {
    public int XCoord {get; set;}
    public int YCoord {get; set;}
    public string Name;

    public Piece(string name)
    {
      Name = name;
    }
  }
}