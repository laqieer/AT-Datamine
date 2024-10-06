// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.GridDataUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Unit;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027EA")]
  public static class GridDataUtility
  {
    [Token(Token = "0x400A9E1")]
    public const int INVALID_DISTANCE = -1;

    [Token(Token = "0x600F943")]
    [Address(RVA = "0x44BFEB8", Offset = "0x44BFEB8", VA = "0x44BFEB8")]
    public static bool IsSamePosition(IGridData a, IGridData b) => new bool();

    [Token(Token = "0x600F944")]
    [Address(RVA = "0x44BFFD8", Offset = "0x44BFFD8", VA = "0x44BFFD8")]
    public static int Distance(IGridData a, IGridData b) => new int();

    [Token(Token = "0x600F945")]
    [Address(RVA = "0x44C0228", Offset = "0x44C0228", VA = "0x44C0228")]
    public static int Distance(IGridData a, int bx, int by) => new int();

    [Token(Token = "0x600F946")]
    [Address(RVA = "0x44C03C4", Offset = "0x44C03C4", VA = "0x44C03C4")]
    public static int Distance(Vector2Int from, Vector2Int to) => new int();

    [Token(Token = "0x600F947")]
    [Address(RVA = "0x44C03D4", Offset = "0x44C03D4", VA = "0x44C03D4")]
    public static int Distance(int fromX, int fromY, int toX, int toY) => new int();

    [Token(Token = "0x600F948")]
    [Address(RVA = "0x44C0498", Offset = "0x44C0498", VA = "0x44C0498")]
    public static int Distance(IEnumerable<(int x, int y)> aList, IEnumerable<(int x, int y)> bList)
    {
      return new int();
    }

    [Token(Token = "0x600F949")]
    [Address(RVA = "0x44C0A2C", Offset = "0x44C0A2C", VA = "0x44C0A2C")]
    public static int Distance(int ax, int ay, IReadableUnitGridShapeData aShape, IGridData bGrid)
    {
      return new int();
    }

    [Token(Token = "0x600F94A")]
    [Address(RVA = "0x44C0C7C", Offset = "0x44C0C7C", VA = "0x44C0C7C")]
    public static int Distance(
      IGridData aMain,
      IEnumerable<GridData> aSubs,
      IGridData bMain,
      IEnumerable<IGridData> bSubs)
    {
      return new int();
    }

    [Token(Token = "0x600F94B")]
    [Address(RVA = "0x44C0E48", Offset = "0x44C0E48", VA = "0x44C0E48")]
    public static int Distance(IEnumerable<IGridData> aGrids, IEnumerable<IGridData> bGrids)
    {
      return new int();
    }

    [Token(Token = "0x600F94C")]
    [Address(RVA = "0x44C13D4", Offset = "0x44C13D4", VA = "0x44C13D4")]
    public static (int, int) DistanceXY(IGridData a, IGridData b) => ();

    [Token(Token = "0x600F94D")]
    [Address(RVA = "0x44C1654", Offset = "0x44C1654", VA = "0x44C1654")]
    public static bool IsStraightLine(IGridData a, IGridData b) => new bool();

    [Token(Token = "0x600F94E")]
    [Address(RVA = "0x44C1830", Offset = "0x44C1830", VA = "0x44C1830")]
    public static Actor.Direction GetDirection(Vector2Int from, Vector2Int to)
    {
      return new Actor.Direction();
    }

    [Token(Token = "0x600F94F")]
    [Address(RVA = "0x44C1924", Offset = "0x44C1924", VA = "0x44C1924")]
    public static Actor.Direction GetDirection(IGridData from, IGridData to)
    {
      return new Actor.Direction();
    }

    [Token(Token = "0x600F950")]
    [Address(RVA = "0x44C1A30", Offset = "0x44C1A30", VA = "0x44C1A30")]
    public static Actor.Direction GetDirectionLeftRight(
      IGridData from,
      IGridData to,
      Actor.Direction defaultDirection)
    {
      return new Actor.Direction();
    }

    [Token(Token = "0x600F951")]
    [Address(RVA = "0x44C1B58", Offset = "0x44C1B58", VA = "0x44C1B58")]
    public static Actor.Direction GetDirection(UnitParameterData unit, Vector2Int to)
    {
      return new Actor.Direction();
    }

    [Token(Token = "0x600F952")]
    [Address(RVA = "0x44C1D38", Offset = "0x44C1D38", VA = "0x44C1D38")]
    public static (int, int) GetDirectionXY(IGridData from, IGridData to) => ();

    [Token(Token = "0x600F953")]
    [Address(RVA = "0x44C1F38", Offset = "0x44C1F38", VA = "0x44C1F38")]
    public static (int, IGridData) GetNearest(IGridData[] froms, IGridData to) => ();
  }
}
