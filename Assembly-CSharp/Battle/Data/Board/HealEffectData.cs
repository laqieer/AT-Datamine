// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.HealEffectData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027B0")]
  public class HealEffectData : EffectData
  {
    [Token(Token = "0x17003554")]
    public EffectValue EffectValue
    {
      [Token(Token = "0x600F7CC"), Address(RVA = "0x1EDDDF4", Offset = "0x1EDDDF4", VA = "0x1EDDDF4")] get
      {
        return new EffectValue();
      }
      [Token(Token = "0x600F7CD"), Address(RVA = "0x1EDDDFC", Offset = "0x1EDDDFC", VA = "0x1EDDDFC")] private set
      {
      }
    }

    [Token(Token = "0x600F7CE")]
    [Address(RVA = "0x1EDC05C", Offset = "0x1EDC05C", VA = "0x1EDC05C")]
    public static HealEffectData Create(EffectSource source) => (HealEffectData) null;

    [Token(Token = "0x600F7CF")]
    [Address(RVA = "0x1EDDE04", Offset = "0x1EDDE04", VA = "0x1EDDE04")]
    protected HealEffectData(EffectSource source)
    {
    }

    [Token(Token = "0x600F7D0")]
    [Address(RVA = "0x1EDDEAC", Offset = "0x1EDDEAC", VA = "0x1EDDEAC", Slot = "5")]
    public override bool IsEffectable(UnitParameterData from, UnitParameterData to) => new bool();

    [Token(Token = "0x20027B1")]
    public enum ContextType
    {
      [Token(Token = "0x400A927")] ValueType,
      [Token(Token = "0x400A928")] Value,
    }
  }
}
