// Decompiled with JetBrains decompiler
// Type: Battle.Data.BarrierParameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x2002718")]
  public class BarrierParameter
  {
    [Token(Token = "0x400A73F")]
    [FieldOffset(Offset = "0x18")]
    private int current;
    [Token(Token = "0x400A740")]
    [FieldOffset(Offset = "0x1C")]
    private int max;

    [Token(Token = "0x170033AF")]
    public int X
    {
      [Token(Token = "0x600F2C9"), Address(RVA = "0x41BB434", Offset = "0x41BB434", VA = "0x41BB434")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170033B0")]
    public int Y
    {
      [Token(Token = "0x600F2CA"), Address(RVA = "0x41BB43C", Offset = "0x41BB43C", VA = "0x41BB43C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170033B1")]
    public int Current
    {
      [Token(Token = "0x600F2CB"), Address(RVA = "0x41BB444", Offset = "0x41BB444", VA = "0x41BB444")] get
      {
        return new int();
      }
      [Token(Token = "0x600F2CC"), Address(RVA = "0x41BB090", Offset = "0x41BB090", VA = "0x41BB090")] set
      {
      }
    }

    [Token(Token = "0x170033B2")]
    public int Max
    {
      [Token(Token = "0x600F2CD"), Address(RVA = "0x41BB44C", Offset = "0x41BB44C", VA = "0x41BB44C")] get
      {
        return new int();
      }
      [Token(Token = "0x600F2CE"), Address(RVA = "0x41BB454", Offset = "0x41BB454", VA = "0x41BB454")] set
      {
      }
    }

    [Token(Token = "0x170033B3")]
    public float Ratio
    {
      [Token(Token = "0x600F2CF"), Address(RVA = "0x41BB4E8", Offset = "0x41BB4E8", VA = "0x41BB4E8")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x170033B4")]
    public bool IsBroken
    {
      [Token(Token = "0x600F2D0"), Address(RVA = "0x41BA800", Offset = "0x41BA800", VA = "0x41BA800")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170033B5")]
    public bool IsTriggeredBroken
    {
      [Token(Token = "0x600F2D1"), Address(RVA = "0x41BB598", Offset = "0x41BB598", VA = "0x41BB598")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F2D2"), Address(RVA = "0x41BB5A0", Offset = "0x41BB5A0", VA = "0x41BB5A0")] private set
      {
      }
    }

    [Token(Token = "0x600F2D3")]
    [Address(RVA = "0x41BAAB0", Offset = "0x41BAAB0", VA = "0x41BAAB0")]
    public BarrierParameter Copy() => (BarrierParameter) null;

    [Token(Token = "0x600F2D4")]
    [Address(RVA = "0x41BB5FC", Offset = "0x41BB5FC", VA = "0x41BB5FC")]
    public BarrierParameter(int x, int y, int max)
    {
    }

    [Token(Token = "0x600F2D5")]
    [Address(RVA = "0x41BB5AC", Offset = "0x41BB5AC", VA = "0x41BB5AC")]
    public BarrierParameter(int x, int y, int max, int current)
    {
    }

    [Token(Token = "0x600F2D6")]
    [Address(RVA = "0x41BB604", Offset = "0x41BB604", VA = "0x41BB604")]
    public int UpdateBarrierDurability(int value) => new int();

    [Token(Token = "0x600F2D7")]
    [Address(RVA = "0x41BB630", Offset = "0x41BB630", VA = "0x41BB630")]
    public void MarkTriggeredBroken()
    {
    }

    [Token(Token = "0x600F2D8")]
    [Address(RVA = "0x41BB63C", Offset = "0x41BB63C", VA = "0x41BB63C")]
    public void ResetTriggered()
    {
    }

    [Token(Token = "0x600F2D9")]
    [Address(RVA = "0x41BB644", Offset = "0x41BB644", VA = "0x41BB644")]
    public void Reset()
    {
    }

    [Token(Token = "0x600F2DA")]
    [Address(RVA = "0x41BB660", Offset = "0x41BB660", VA = "0x41BB660", Slot = "3")]
    public override string ToString() => (string) null;
  }
}
