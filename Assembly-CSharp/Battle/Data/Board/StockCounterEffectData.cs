// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.StockCounterEffectData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027D5")]
  public class StockCounterEffectData : EffectData
  {
    [Token(Token = "0x170035B6")]
    public int StockCounterType
    {
      [Token(Token = "0x600F8C0"), Address(RVA = "0x44BCA14", Offset = "0x44BCA14", VA = "0x44BCA14")] get
      {
        return new int();
      }
      [Token(Token = "0x600F8C1"), Address(RVA = "0x44BCA1C", Offset = "0x44BCA1C", VA = "0x44BCA1C")] private set
      {
      }
    }

    [Token(Token = "0x170035B7")]
    public int Value
    {
      [Token(Token = "0x600F8C2"), Address(RVA = "0x44BCA24", Offset = "0x44BCA24", VA = "0x44BCA24")] get
      {
        return new int();
      }
      [Token(Token = "0x600F8C3"), Address(RVA = "0x44BCA2C", Offset = "0x44BCA2C", VA = "0x44BCA2C")] private set
      {
      }
    }

    [Token(Token = "0x600F8C4")]
    [Address(RVA = "0x44BCA34", Offset = "0x44BCA34", VA = "0x44BCA34")]
    public static StockCounterEffectData Create(EffectSource source)
    {
      return (StockCounterEffectData) null;
    }

    [Token(Token = "0x600F8C5")]
    [Address(RVA = "0x44BCAD0", Offset = "0x44BCAD0", VA = "0x44BCAD0")]
    protected StockCounterEffectData(EffectSource source)
    {
    }

    [Token(Token = "0x20027D6")]
    private enum ContextType
    {
      [Token(Token = "0x400A993")] StockCounterType,
      [Token(Token = "0x400A994")] Value,
    }
  }
}
