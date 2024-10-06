// Decompiled with JetBrains decompiler
// Type: Battle.Data.UnitGridShapeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x2002745")]
  public sealed class UnitGridShapeData : IReadableUnitGridShapeData
  {
    [Token(Token = "0x400A7BF")]
    [FieldOffset(Offset = "0x0")]
    public static readonly UnitGridShapeData DefaultOneCellData;
    [Token(Token = "0x400A7C3")]
    [FieldOffset(Offset = "0x20")]
    private List<(int x, int y)> gridList;

    [Token(Token = "0x17003448")]
    public int Id
    {
      [Token(Token = "0x600F4B3"), Address(RVA = "0x1FAFB00", Offset = "0x1FAFB00", VA = "0x1FAFB00", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003449")]
    public UnitGridShapeTypeEnum Shape
    {
      [Token(Token = "0x600F4B4"), Address(RVA = "0x1FAFB08", Offset = "0x1FAFB08", VA = "0x1FAFB08", Slot = "5")] get
      {
        return new UnitGridShapeTypeEnum();
      }
    }

    [Token(Token = "0x1700344A")]
    public int ShapeSize
    {
      [Token(Token = "0x600F4B5"), Address(RVA = "0x1FAFB10", Offset = "0x1FAFB10", VA = "0x1FAFB10", Slot = "6")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700344B")]
    public IReadOnlyList<(int x, int y)> GridList
    {
      [Token(Token = "0x600F4B6"), Address(RVA = "0x1FAFB18", Offset = "0x1FAFB18", VA = "0x1FAFB18", Slot = "7")] get
      {
        return (IReadOnlyList<(int, int)>) null;
      }
    }

    [Token(Token = "0x600F4B7")]
    [Address(RVA = "0x1FAFB20", Offset = "0x1FAFB20", VA = "0x1FAFB20")]
    public UnitGridShapeData(UnitGridShapeTypeEnum shape, int size)
    {
    }

    [Token(Token = "0x600F4B8")]
    [Address(RVA = "0x1FAFCE8", Offset = "0x1FAFCE8", VA = "0x1FAFCE8", Slot = "8")]
    public int FindIndexByDistance(int x, int y) => new int();

    [Token(Token = "0x600F4B9")]
    [Address(RVA = "0x1FAFD94", Offset = "0x1FAFD94", VA = "0x1FAFD94")]
    static UnitGridShapeData()
    {
    }
  }
}
