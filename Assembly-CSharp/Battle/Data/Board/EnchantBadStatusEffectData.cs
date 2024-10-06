// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.EnchantBadStatusEffectData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x200277F")]
  public class EnchantBadStatusEffectData : EffectData
  {
    [Token(Token = "0x170034D1")]
    public BattleBadStatusDetailData BadStatusDetail
    {
      [Token(Token = "0x600F696"), Address(RVA = "0x1ED7050", Offset = "0x1ED7050", VA = "0x1ED7050")] get
      {
        return (BattleBadStatusDetailData) null;
      }
      [Token(Token = "0x600F697"), Address(RVA = "0x1ED7058", Offset = "0x1ED7058", VA = "0x1ED7058")] private set
      {
      }
    }

    [Token(Token = "0x170034D2")]
    public int ApplyRate
    {
      [Token(Token = "0x600F698"), Address(RVA = "0x1ED7060", Offset = "0x1ED7060", VA = "0x1ED7060")] get
      {
        return new int();
      }
      [Token(Token = "0x600F699"), Address(RVA = "0x1ED7068", Offset = "0x1ED7068", VA = "0x1ED7068")] private set
      {
      }
    }

    [Token(Token = "0x170034D3")]
    public BadStatusEffectData BadStatusEffect
    {
      [Token(Token = "0x600F69A"), Address(RVA = "0x1ED7070", Offset = "0x1ED7070", VA = "0x1ED7070")] get
      {
        return (BadStatusEffectData) null;
      }
      [Token(Token = "0x600F69B"), Address(RVA = "0x1ED7078", Offset = "0x1ED7078", VA = "0x1ED7078")] private set
      {
      }
    }

    [Token(Token = "0x600F69C")]
    [Address(RVA = "0x1ED7080", Offset = "0x1ED7080", VA = "0x1ED7080")]
    public static EnchantBadStatusEffectData Create(EnchantBadStatusEffectSource source)
    {
      return (EnchantBadStatusEffectData) null;
    }

    [Token(Token = "0x600F69D")]
    [Address(RVA = "0x1ED7140", Offset = "0x1ED7140", VA = "0x1ED7140")]
    protected EnchantBadStatusEffectData(EffectSource source)
    {
    }

    [Token(Token = "0x600F69E")]
    [Address(RVA = "0x1ED7260", Offset = "0x1ED7260", VA = "0x1ED7260", Slot = "7")]
    protected override void CreateKey()
    {
    }

    [Token(Token = "0x2002780")]
    public enum ContextType
    {
      [Token(Token = "0x400A883")] BadStatusId,
      [Token(Token = "0x400A884")] ApplyRate,
      [Token(Token = "0x400A885")] Turn,
      [Token(Token = "0x400A886")] Value,
    }
  }
}
