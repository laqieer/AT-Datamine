// Decompiled with JetBrains decompiler
// Type: StaqData.Deck
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2001FF1")]
  public class Deck
  {
    [Token(Token = "0x4008846")]
    public const int PartyCapacity = 5;
    [Token(Token = "0x400884F")]
    [FieldOffset(Offset = "0x38")]
    private DeckSlot[] slots;

    [Token(Token = "0x1700275A")]
    public DeckTypeEnum Type
    {
      [Token(Token = "0x600BDF8"), Address(RVA = "0x1FFCB40", Offset = "0x1FFCB40", VA = "0x1FFCB40")] get
      {
        return new DeckTypeEnum();
      }
      [Token(Token = "0x600BDF9"), Address(RVA = "0x1FFCB48", Offset = "0x1FFCB48", VA = "0x1FFCB48")] private set
      {
      }
    }

    [Token(Token = "0x1700275B")]
    public int Idx
    {
      [Token(Token = "0x600BDFA"), Address(RVA = "0x1FFCB50", Offset = "0x1FFCB50", VA = "0x1FFCB50")] get
      {
        return new int();
      }
      [Token(Token = "0x600BDFB"), Address(RVA = "0x1FFCB58", Offset = "0x1FFCB58", VA = "0x1FFCB58")] private set
      {
      }
    }

    [Token(Token = "0x1700275C")]
    public string Name
    {
      [Token(Token = "0x600BDFC"), Address(RVA = "0x1FFCB60", Offset = "0x1FFCB60", VA = "0x1FFCB60")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600BDFD"), Address(RVA = "0x1FFCB68", Offset = "0x1FFCB68", VA = "0x1FFCB68")] private set
      {
      }
    }

    [Token(Token = "0x1700275D")]
    public int CostLimit
    {
      [Token(Token = "0x600BDFE"), Address(RVA = "0x1FFCB70", Offset = "0x1FFCB70", VA = "0x1FFCB70")] get
      {
        return new int();
      }
      [Token(Token = "0x600BDFF"), Address(RVA = "0x1FFCB78", Offset = "0x1FFCB78", VA = "0x1FFCB78")] private set
      {
      }
    }

    [Token(Token = "0x1700275E")]
    public int MemberLimit
    {
      [Token(Token = "0x600BE00"), Address(RVA = "0x1FFCB80", Offset = "0x1FFCB80", VA = "0x1FFCB80")] get
      {
        return new int();
      }
      [Token(Token = "0x600BE01"), Address(RVA = "0x1FFCB88", Offset = "0x1FFCB88", VA = "0x1FFCB88")] private set
      {
      }
    }

    [Token(Token = "0x1700275F")]
    public int AiTypeID
    {
      [Token(Token = "0x600BE02"), Address(RVA = "0x1FFCB90", Offset = "0x1FFCB90", VA = "0x1FFCB90")] get
      {
        return new int();
      }
      [Token(Token = "0x600BE03"), Address(RVA = "0x1FFCB98", Offset = "0x1FFCB98", VA = "0x1FFCB98")] private set
      {
      }
    }

    [Token(Token = "0x17002760")]
    public int ItemSetId
    {
      [Token(Token = "0x600BE04"), Address(RVA = "0x1FFCBA0", Offset = "0x1FFCBA0", VA = "0x1FFCBA0")] get
      {
        return new int();
      }
      [Token(Token = "0x600BE05"), Address(RVA = "0x1FFCBA8", Offset = "0x1FFCBA8", VA = "0x1FFCBA8")] private set
      {
      }
    }

    [Token(Token = "0x17002761")]
    public bool IsItemSetSetting
    {
      [Token(Token = "0x600BE06"), Address(RVA = "0x1FFCBB0", Offset = "0x1FFCBB0", VA = "0x1FFCBB0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600BE07"), Address(RVA = "0x1FFCBB8", Offset = "0x1FFCBB8", VA = "0x1FFCBB8")] private set
      {
      }
    }

    [Token(Token = "0x17002762")]
    public IReadOnlyList<DeckSlot> Slots
    {
      [Token(Token = "0x600BE08"), Address(RVA = "0x1FFCBC4", Offset = "0x1FFCBC4", VA = "0x1FFCBC4")] get
      {
        return (IReadOnlyList<DeckSlot>) null;
      }
    }

    [Token(Token = "0x17002763")]
    public Dictionary<string, List<DeckSlot>> WeaponEquippedSlotsByUniqueID
    {
      [Token(Token = "0x600BE09"), Address(RVA = "0x1FFCBCC", Offset = "0x1FFCBCC", VA = "0x1FFCBCC")] get
      {
        return (Dictionary<string, List<DeckSlot>>) null;
      }
    }

    [Token(Token = "0x17002764")]
    public string DefaultName
    {
      [Token(Token = "0x600BE0A"), Address(RVA = "0x1FFCBD4", Offset = "0x1FFCBD4", VA = "0x1FFCBD4")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600BE0B"), Address(RVA = "0x1FFCBDC", Offset = "0x1FFCBDC", VA = "0x1FFCBDC")] private set
      {
      }
    }

    [Token(Token = "0x17002765")]
    public DeckTypeData DeckTypeData
    {
      [Token(Token = "0x600BE0C"), Address(RVA = "0x1FFCBE4", Offset = "0x1FFCBE4", VA = "0x1FFCBE4")] get
      {
        return (DeckTypeData) null;
      }
      [Token(Token = "0x600BE0D"), Address(RVA = "0x1FFCBEC", Offset = "0x1FFCBEC", VA = "0x1FFCBEC")] private set
      {
      }
    }

    [Token(Token = "0x600BE0E")]
    [Address(RVA = "0x1FFCBF4", Offset = "0x1FFCBF4", VA = "0x1FFCBF4")]
    private Deck()
    {
    }

    [Token(Token = "0x600BE0F")]
    [Address(RVA = "0x1FFCCA4", Offset = "0x1FFCCA4", VA = "0x1FFCCA4")]
    public static Deck CreateByServerData(PlayerDeckType entity) => (Deck) null;

    [Token(Token = "0x600BE10")]
    [Address(RVA = "0x1FFD1EC", Offset = "0x1FFD1EC", VA = "0x1FFD1EC")]
    public static Deck CreateByDummyData(
      DeckTypeEnum deckType,
      int index,
      IList<string> unitUniqueIds)
    {
      return (Deck) null;
    }

    [Token(Token = "0x600BE11")]
    [Address(RVA = "0x1FFD53C", Offset = "0x1FFD53C", VA = "0x1FFD53C")]
    public static Deck CreateForArenaOpponent(
      List<PlayerDeckSlotInfo> entity,
      DeckTypeEnum deckType,
      PlayerProfile playerProfile)
    {
      return (Deck) null;
    }

    [Token(Token = "0x600BE12")]
    [Address(RVA = "0x1FFCF4C", Offset = "0x1FFCF4C", VA = "0x1FFCF4C")]
    private void ApplyByDeckTypeData(DeckTypeData deckTypeData)
    {
    }

    [Token(Token = "0x600BE13")]
    [Address(RVA = "0x1FFCF80", Offset = "0x1FFCF80", VA = "0x1FFCF80")]
    private void UpdateEquippedSlotCache()
    {
    }

    [Token(Token = "0x600BE14")]
    [Address(RVA = "0x1FFD8D4", Offset = "0x1FFD8D4", VA = "0x1FFD8D4")]
    public string GetNameOrDefaultName() => (string) null;
  }
}
