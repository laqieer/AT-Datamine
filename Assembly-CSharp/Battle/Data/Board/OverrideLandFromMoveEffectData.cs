// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.OverrideLandFromMoveEffectData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027D3")]
  public class OverrideLandFromMoveEffectData : EffectData
  {
    [Token(Token = "0x400A98C")]
    [FieldOffset(Offset = "0x88")]
    private string landTagText;

    [Token(Token = "0x170035B3")]
    public LandTagEnum LandTag
    {
      [Token(Token = "0x600F8B8"), Address(RVA = "0x44BC6FC", Offset = "0x44BC6FC", VA = "0x44BC6FC")] get
      {
        return new LandTagEnum();
      }
      [Token(Token = "0x600F8B9"), Address(RVA = "0x44BC704", Offset = "0x44BC704", VA = "0x44BC704")] private set
      {
      }
    }

    [Token(Token = "0x170035B4")]
    public int Value
    {
      [Token(Token = "0x600F8BA"), Address(RVA = "0x44BC70C", Offset = "0x44BC70C", VA = "0x44BC70C")] get
      {
        return new int();
      }
      [Token(Token = "0x600F8BB"), Address(RVA = "0x44BC714", Offset = "0x44BC714", VA = "0x44BC714")] private set
      {
      }
    }

    [Token(Token = "0x170035B5")]
    public override string DisplayName
    {
      [Token(Token = "0x600F8BC"), Address(RVA = "0x44BC71C", Offset = "0x44BC71C", VA = "0x44BC71C", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600F8BD")]
    [Address(RVA = "0x44BC730", Offset = "0x44BC730", VA = "0x44BC730")]
    public static OverrideLandFromMoveEffectData Create(EffectSource source)
    {
      return (OverrideLandFromMoveEffectData) null;
    }

    [Token(Token = "0x600F8BE")]
    [Address(RVA = "0x44BC7CC", Offset = "0x44BC7CC", VA = "0x44BC7CC")]
    protected OverrideLandFromMoveEffectData(EffectSource source)
    {
    }

    [Token(Token = "0x600F8BF")]
    [Address(RVA = "0x44BC944", Offset = "0x44BC944", VA = "0x44BC944", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x20027D4")]
    private enum ContextType
    {
      [Token(Token = "0x400A98E")] LandTag,
      [Token(Token = "0x400A98F")] Value,
    }
  }
}
