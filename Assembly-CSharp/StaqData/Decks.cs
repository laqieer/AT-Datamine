// Decompiled with JetBrains decompiler
// Type: StaqData.Decks
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
  [Token(Token = "0x2001FF2")]
  public class Decks
  {
    [Token(Token = "0x4008854")]
    [FieldOffset(Offset = "0x18")]
    private Deck[] deckArray;
    [Token(Token = "0x4008855")]
    [FieldOffset(Offset = "0x20")]
    private Dictionary<string, List<Deck>> WeaponEquippedDecksByUniqueID;
    [Token(Token = "0x4008856")]
    [FieldOffset(Offset = "0x28")]
    private HashSet<string> EquippedIDsCache;

    [Token(Token = "0x17002766")]
    public int LatestDeckIndex
    {
      [Token(Token = "0x600BE15"), Address(RVA = "0x1FFD904", Offset = "0x1FFD904", VA = "0x1FFD904")] get
      {
        return new int();
      }
      [Token(Token = "0x600BE16"), Address(RVA = "0x1FFD90C", Offset = "0x1FFD90C", VA = "0x1FFD90C")] private set
      {
      }
    }

    [Token(Token = "0x17002767")]
    public IReadOnlyList<Deck> DeckArray
    {
      [Token(Token = "0x600BE17"), Address(RVA = "0x1FFD914", Offset = "0x1FFD914", VA = "0x1FFD914")] get
      {
        return (IReadOnlyList<Deck>) null;
      }
    }

    [Token(Token = "0x17002768")]
    public Deck CurrentDeck
    {
      [Token(Token = "0x600BE18"), Address(RVA = "0x1FFD91C", Offset = "0x1FFD91C", VA = "0x1FFD91C")] get
      {
        return (Deck) null;
      }
    }

    [Token(Token = "0x600BE19")]
    [Address(RVA = "0x1FFD950", Offset = "0x1FFD950", VA = "0x1FFD950")]
    private Decks(int deckLimit)
    {
    }

    [Token(Token = "0x600BE1A")]
    [Address(RVA = "0x1FFDA44", Offset = "0x1FFDA44", VA = "0x1FFDA44")]
    public bool IsFirst() => new bool();

    [Token(Token = "0x600BE1B")]
    [Address(RVA = "0x1FFDA54", Offset = "0x1FFDA54", VA = "0x1FFDA54")]
    public bool IsLast() => new bool();

    [Token(Token = "0x600BE1C")]
    [Address(RVA = "0x1FFDA80", Offset = "0x1FFDA80", VA = "0x1FFDA80")]
    public void SetLatestDeckIndex(int index)
    {
    }

    [Token(Token = "0x600BE1D")]
    [Address(RVA = "0x1FFDAB0", Offset = "0x1FFDAB0", VA = "0x1FFDAB0")]
    public bool NextDeck(out Deck deck) => new bool();

    [Token(Token = "0x600BE1E")]
    [Address(RVA = "0x1FFDB0C", Offset = "0x1FFDB0C", VA = "0x1FFDB0C")]
    public bool PrevDeck(out Deck deck) => new bool();

    [Token(Token = "0x600BE1F")]
    [Address(RVA = "0x1FFDB4C", Offset = "0x1FFDB4C", VA = "0x1FFDB4C")]
    public Deck GetDeck(int deckIndex) => (Deck) null;

    [Token(Token = "0x600BE20")]
    [Address(RVA = "0x1FFDCA8", Offset = "0x1FFDCA8", VA = "0x1FFDCA8")]
    public Deck GetPvPDeck(DeckTypeEnum deckType) => (Deck) null;

    [Token(Token = "0x600BE21")]
    [Address(RVA = "0x1FFDE14", Offset = "0x1FFDE14", VA = "0x1FFDE14")]
    public bool IsSetEquipment(UniqueID uniqueID) => new bool();

    [Token(Token = "0x600BE22")]
    [Address(RVA = "0x1FFDE9C", Offset = "0x1FFDE9C", VA = "0x1FFDE9C")]
    public bool IsSetWeapon(UniqueID uniqueID) => new bool();

    [Token(Token = "0x600BE23")]
    [Address(RVA = "0x1FFDF24", Offset = "0x1FFDF24", VA = "0x1FFDF24")]
    public int GetUnitSetDeckNum() => new int();

    [Token(Token = "0x600BE24")]
    [Address(RVA = "0x1FFE4B8", Offset = "0x1FFE4B8", VA = "0x1FFE4B8")]
    public void ApplyDeckData(PlayerDeckType entity)
    {
    }

    [Token(Token = "0x600BE25")]
    [Address(RVA = "0x1FFE620", Offset = "0x1FFE620", VA = "0x1FFE620")]
    public void ApplyPvPDeckData(PlayerDeckType entity)
    {
    }

    [Token(Token = "0x600BE26")]
    [Address(RVA = "0x1FFE778", Offset = "0x1FFE778", VA = "0x1FFE778")]
    public static Decks CreateEmptyDeck() => (Decks) null;

    [Token(Token = "0x600BE27")]
    [Address(RVA = "0x1FFE7D4", Offset = "0x1FFE7D4", VA = "0x1FFE7D4")]
    public static Decks CreateEmptyPvPDeck() => (Decks) null;

    [Token(Token = "0x600BE28")]
    [Address(RVA = "0x1FFE830", Offset = "0x1FFE830", VA = "0x1FFE830")]
    public static Decks CreateByServerData(List<PlayerDeckType> entities) => (Decks) null;

    [Token(Token = "0x600BE29")]
    [Address(RVA = "0x1FFE960", Offset = "0x1FFE960", VA = "0x1FFE960")]
    public static Decks CreateByServerDataPvP(List<PlayerDeckType> entities) => (Decks) null;

    [Token(Token = "0x600BE2A")]
    [Address(RVA = "0x1FFEA8C", Offset = "0x1FFEA8C", VA = "0x1FFEA8C")]
    public static Decks CreateForArenaOpponent(
      List<PlayerDeckSlotInfo> entities,
      DeckTypeEnum deckType,
      PlayerProfile playerProfile)
    {
      return (Decks) null;
    }

    [Token(Token = "0x600BE2B")]
    [Address(RVA = "0x1FFEB5C", Offset = "0x1FFEB5C", VA = "0x1FFEB5C")]
    public static Decks CreateTemplateEmptyDeck() => (Decks) null;

    [Token(Token = "0x600BE2C")]
    [Address(RVA = "0x1FFEBCC", Offset = "0x1FFEBCC", VA = "0x1FFEBCC")]
    public static Decks CreateTemplateByServerData(List<PlayerDeckType> entities) => (Decks) null;

    [Token(Token = "0x600BE2D")]
    [Address(RVA = "0x1FFECF0", Offset = "0x1FFECF0", VA = "0x1FFECF0")]
    public static Decks CreateByDummyData(DeckTypeEnum deckType) => (Decks) null;

    [Token(Token = "0x600BE2E")]
    [Address(RVA = "0x1FFE608", Offset = "0x1FFE608", VA = "0x1FFE608")]
    private void UpdateCache()
    {
    }

    [Token(Token = "0x600BE2F")]
    [Address(RVA = "0x1FFF480", Offset = "0x1FFF480", VA = "0x1FFF480")]
    private void UpdateEquippedDeckCache()
    {
    }

    [Token(Token = "0x600BE30")]
    [Address(RVA = "0x1FFF00C", Offset = "0x1FFF00C", VA = "0x1FFF00C")]
    private void UpdateEquippedIDsCache()
    {
    }

    [Token(Token = "0x600BE31")]
    [Address(RVA = "0x1FFF7CC", Offset = "0x1FFF7CC", VA = "0x1FFF7CC")]
    public HashSet<UniqueID> CustomSkillEquipedIds() => (HashSet<UniqueID>) null;
  }
}
