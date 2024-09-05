// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.ActionRecoveryEffectData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x200276E")]
  public class ActionRecoveryEffectData : EffectData
  {
    [Token(Token = "0x600F660")]
    [Address(RVA = "0x1ED60E8", Offset = "0x1ED60E8", VA = "0x1ED60E8")]
    public static ActionRecoveryEffectData Create(EffectSource source)
    {
      return (ActionRecoveryEffectData) null;
    }

    [Token(Token = "0x600F661")]
    [Address(RVA = "0x1ED6184", Offset = "0x1ED6184", VA = "0x1ED6184")]
    protected ActionRecoveryEffectData(EffectSource source)
    {
    }

    [Token(Token = "0x600F662")]
    [Address(RVA = "0x1ED6394", Offset = "0x1ED6394", VA = "0x1ED6394", Slot = "5")]
    public override bool IsEffectable(UnitParameterData from, UnitParameterData to) => new bool();
  }
}
