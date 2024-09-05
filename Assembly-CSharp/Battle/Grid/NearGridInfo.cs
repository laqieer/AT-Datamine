// Decompiled with JetBrains decompiler
// Type: Battle.Grid.NearGridInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Grid
{
  [Token(Token = "0x2002539")]
  public struct NearGridInfo
  {
    [Token(Token = "0x400A006")]
    [FieldOffset(Offset = "0x0")]
    public static readonly NearGridInfo Empty;
    [Token(Token = "0x400A007")]
    [FieldOffset(Offset = "0x0")]
    public readonly IReadOnlyList<GridData> Grids;
    [Token(Token = "0x400A008")]
    [FieldOffset(Offset = "0x8")]
    public readonly IReadOnlyList<UnitParameterData> Units;

    [Token(Token = "0x600E5FA")]
    [Address(RVA = "0x486B47C", Offset = "0x486B47C", VA = "0x486B47C")]
    public NearGridInfo(IReadOnlyList<GridData> grids, IReadOnlyList<UnitParameterData> units)
    {
    }

    [Token(Token = "0x600E5FB")]
    [Address(RVA = "0x486B484", Offset = "0x486B484", VA = "0x486B484")]
    public bool IsNear(GridData grid) => new bool();

    [Token(Token = "0x600E5FC")]
    [Address(RVA = "0x486B4DC", Offset = "0x486B4DC", VA = "0x486B4DC")]
    public bool IsNear(UnitParameterData unit) => new bool();

    [Token(Token = "0x600E5FD")]
    [Address(RVA = "0x486B534", Offset = "0x486B534", VA = "0x486B534")]
    public bool ContainsEnemy(BoardData board, UnitParameterData unit) => new bool();

    [Token(Token = "0x600E5FE")]
    [Address(RVA = "0x486B6F4", Offset = "0x486B6F4", VA = "0x486B6F4")]
    public bool ContainsAlly(BoardData board, UnitParameterData unit) => new bool();

    [Token(Token = "0x600E5FF")]
    [Address(RVA = "0x486B8B4", Offset = "0x486B8B4", VA = "0x486B8B4")]
    public IReadOnlyList<UnitParameterData> GetAllies(BoardData board, UnitParameterData unit)
    {
      return (IReadOnlyList<UnitParameterData>) null;
    }

    [Token(Token = "0x600E600")]
    [Address(RVA = "0x486BB24", Offset = "0x486BB24", VA = "0x486BB24")]
    static NearGridInfo()
    {
    }
  }
}
