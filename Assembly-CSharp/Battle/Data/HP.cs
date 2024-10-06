// Decompiled with JetBrains decompiler
// Type: Battle.Data.HP
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x200272B")]
  public class HP
  {
    [Token(Token = "0x400A776")]
    [FieldOffset(Offset = "0x10")]
    private int current;
    [Token(Token = "0x400A777")]
    [FieldOffset(Offset = "0x14")]
    private int max;

    [Token(Token = "0x170033F0")]
    public int Current
    {
      [Token(Token = "0x600F3A5"), Address(RVA = "0x1FA4D4C", Offset = "0x1FA4D4C", VA = "0x1FA4D4C")] get
      {
        return new int();
      }
      [Token(Token = "0x600F3A6"), Address(RVA = "0x1FA4B8C", Offset = "0x1FA4B8C", VA = "0x1FA4B8C")] set
      {
      }
    }

    [Token(Token = "0x170033F1")]
    public int Max
    {
      [Token(Token = "0x600F3A7"), Address(RVA = "0x1FA4D54", Offset = "0x1FA4D54", VA = "0x1FA4D54")] get
      {
        return new int();
      }
      [Token(Token = "0x600F3A8"), Address(RVA = "0x1FA49B8", Offset = "0x1FA49B8", VA = "0x1FA49B8")] set
      {
      }
    }

    [Token(Token = "0x170033F2")]
    public int BaseHP
    {
      [Token(Token = "0x600F3A9"), Address(RVA = "0x1FA4D5C", Offset = "0x1FA4D5C", VA = "0x1FA4D5C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170033F3")]
    public Decimal Percentage
    {
      [Token(Token = "0x600F3AA"), Address(RVA = "0x1FA4510", Offset = "0x1FA4510", VA = "0x1FA4510")] get
      {
        return 0M;
      }
    }

    [Token(Token = "0x170033F4")]
    public int PercentageInt
    {
      [Token(Token = "0x600F3AB"), Address(RVA = "0x1FA45DC", Offset = "0x1FA45DC", VA = "0x1FA45DC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170033F5")]
    public float Ratio
    {
      [Token(Token = "0x600F3AC"), Address(RVA = "0x1FA4668", Offset = "0x1FA4668", VA = "0x1FA4668")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x170033F6")]
    public bool IsEmpty
    {
      [Token(Token = "0x600F3AD"), Address(RVA = "0x1FA476C", Offset = "0x1FA476C", VA = "0x1FA476C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600F3AE")]
    [Address(RVA = "0x1FA416C", Offset = "0x1FA416C", VA = "0x1FA416C")]
    public HP Copy() => (HP) null;

    [Token(Token = "0x600F3AF")]
    [Address(RVA = "0x1FA4DB0", Offset = "0x1FA4DB0", VA = "0x1FA4DB0")]
    public HP(int baseHp)
    {
    }

    [Token(Token = "0x600F3B0")]
    [Address(RVA = "0x1FA4D64", Offset = "0x1FA4D64", VA = "0x1FA4D64")]
    public HP(int baseHp, int max, int current)
    {
    }

    [Token(Token = "0x600F3B1")]
    [Address(RVA = "0x1FA4DBC", Offset = "0x1FA4DBC", VA = "0x1FA4DBC")]
    public void Fill()
    {
    }

    [Token(Token = "0x600F3B2")]
    [Address(RVA = "0x1FA4978", Offset = "0x1FA4978", VA = "0x1FA4978")]
    public void Reset()
    {
    }

    [Token(Token = "0x600F3B3")]
    [Address(RVA = "0x1FA4DC4", Offset = "0x1FA4DC4", VA = "0x1FA4DC4")]
    public int Add(int value) => new int();

    [Token(Token = "0x600F3B4")]
    [Address(RVA = "0x1FA4DF0", Offset = "0x1FA4DF0", VA = "0x1FA4DF0", Slot = "3")]
    public override string ToString() => (string) null;
  }
}
