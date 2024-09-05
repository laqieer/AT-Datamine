// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.MoveRecoveryEffectData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027CC")]
  public class MoveRecoveryEffectData : EffectData
  {
    [Token(Token = "0x170035B0")]
    public int RecoverPoint
    {
      [Token(Token = "0x600F8AC"), Address(RVA = "0x44BC208", Offset = "0x44BC208", VA = "0x44BC208")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600F8AD")]
    [Address(RVA = "0x44BC25C", Offset = "0x44BC25C", VA = "0x44BC25C")]
    public static MoveRecoveryEffectData Create(EffectSource source)
    {
      return (MoveRecoveryEffectData) null;
    }

    [Token(Token = "0x600F8AE")]
    [Address(RVA = "0x44BC2FC", Offset = "0x44BC2FC", VA = "0x44BC2FC")]
    protected MoveRecoveryEffectData(EffectSource source)
    {
    }

    [Token(Token = "0x600F8AF")]
    [Address(RVA = "0x44BC330", Offset = "0x44BC330", VA = "0x44BC330", Slot = "5")]
    public override bool IsEffectable(UnitParameterData from, UnitParameterData to) => new bool();

    [Token(Token = "0x20027CD")]
    private enum ContextType
    {
      [Token(Token = "0x400A97F")] RecoverPoint,
    }
  }
}
