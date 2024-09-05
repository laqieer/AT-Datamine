// Decompiled with JetBrains decompiler
// Type: Battle.Data.BarrierContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x2002717")]
  public class BarrierContainer
  {
    [Token(Token = "0x400A73C")]
    [FieldOffset(Offset = "0x20")]
    private BarrierData master;

    [Token(Token = "0x170033A9")]
    public int MasterId
    {
      [Token(Token = "0x600F2B8"), Address(RVA = "0x41BA654", Offset = "0x41BA654", VA = "0x41BA654")] get
      {
        return new int();
      }
      [Token(Token = "0x600F2B9"), Address(RVA = "0x41BA65C", Offset = "0x41BA65C", VA = "0x41BA65C")] private set
      {
      }
    }

    [Token(Token = "0x170033AA")]
    public List<BarrierParameter> BarrierList
    {
      [Token(Token = "0x600F2BA"), Address(RVA = "0x41BA664", Offset = "0x41BA664", VA = "0x41BA664")] get
      {
        return (List<BarrierParameter>) null;
      }
      [Token(Token = "0x600F2BB"), Address(RVA = "0x41BA66C", Offset = "0x41BA66C", VA = "0x41BA66C")] private set
      {
      }
    }

    [Token(Token = "0x170033AB")]
    public int Resist
    {
      [Token(Token = "0x600F2BC"), Address(RVA = "0x41BA674", Offset = "0x41BA674", VA = "0x41BA674")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170033AC")]
    public bool IsBreakableCounter
    {
      [Token(Token = "0x600F2BD"), Address(RVA = "0x41BA68C", Offset = "0x41BA68C", VA = "0x41BA68C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170033AD")]
    public int EnableBarrierCount
    {
      [Token(Token = "0x600F2BE"), Address(RVA = "0x41BA6AC", Offset = "0x41BA6AC", VA = "0x41BA6AC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170033AE")]
    public bool HasBarrier
    {
      [Token(Token = "0x600F2BF"), Address(RVA = "0x41BA810", Offset = "0x41BA810", VA = "0x41BA810")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600F2C0")]
    [Address(RVA = "0x41BA860", Offset = "0x41BA860", VA = "0x41BA860")]
    public BarrierContainer Copy() => (BarrierContainer) null;

    [Token(Token = "0x600F2C1")]
    [Address(RVA = "0x41BAB2C", Offset = "0x41BAB2C", VA = "0x41BAB2C")]
    public BarrierContainer(int masterId, IReadOnlyList<BarrierParameter> barrierList)
    {
    }

    [Token(Token = "0x600F2C2")]
    [Address(RVA = "0x41BAC6C", Offset = "0x41BAC6C", VA = "0x41BAC6C")]
    public bool IsWeak(ElementTypeEnum element) => new bool();

    [Token(Token = "0x600F2C3")]
    [Address(RVA = "0x41BAC88", Offset = "0x41BAC88", VA = "0x41BAC88")]
    public bool Exsist(int x, int y) => new bool();

    [Token(Token = "0x600F2C4")]
    [Address(RVA = "0x41BACA0", Offset = "0x41BACA0", VA = "0x41BACA0")]
    public BarrierParameter GetBarrier(int x, int y) => (BarrierParameter) null;

    [Token(Token = "0x600F2C5")]
    [Address(RVA = "0x41BAD44", Offset = "0x41BAD44", VA = "0x41BAD44")]
    public int GetIndex(int x, int y) => new int();

    [Token(Token = "0x600F2C6")]
    [Address(RVA = "0x41BADF8", Offset = "0x41BADF8", VA = "0x41BADF8")]
    public string GetBarrierName(int index) => (string) null;

    [Token(Token = "0x600F2C7")]
    [Address(RVA = "0x41BAF20", Offset = "0x41BAF20", VA = "0x41BAF20")]
    public void Apply(BarrierContainer src)
    {
    }

    [Token(Token = "0x600F2C8")]
    [Address(RVA = "0x41BB10C", Offset = "0x41BB10C", VA = "0x41BB10C", Slot = "3")]
    public override string ToString() => (string) null;
  }
}
