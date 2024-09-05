// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.BarrierReviveEffectData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x2002784")]
  public class BarrierReviveEffectData : EffectData
  {
    [Token(Token = "0x170034E4")]
    public EffectValue EffectValue
    {
      [Token(Token = "0x600F6B8"), Address(RVA = "0x1ED7364", Offset = "0x1ED7364", VA = "0x1ED7364")] get
      {
        return new EffectValue();
      }
      [Token(Token = "0x600F6B9"), Address(RVA = "0x1ED736C", Offset = "0x1ED736C", VA = "0x1ED736C")] private set
      {
      }
    }

    [Token(Token = "0x600F6BA")]
    [Address(RVA = "0x1ED7374", Offset = "0x1ED7374", VA = "0x1ED7374")]
    public static BarrierReviveEffectData Create(EffectSource source)
    {
      return (BarrierReviveEffectData) null;
    }

    [Token(Token = "0x600F6BB")]
    [Address(RVA = "0x1ED7410", Offset = "0x1ED7410", VA = "0x1ED7410")]
    protected BarrierReviveEffectData(EffectSource source)
    {
    }

    [Token(Token = "0x2002785")]
    private enum ContextType
    {
      [Token(Token = "0x400A893")] Value,
    }
  }
}
