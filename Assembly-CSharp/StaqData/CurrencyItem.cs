// Decompiled with JetBrains decompiler
// Type: StaqData.CurrencyItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;
using Scenes.OutGame;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002014")]
  public sealed class CurrencyItem : Item
  {
    [Token(Token = "0x400889C")]
    public const int ZENY_ID = 201010001;
    [Token(Token = "0x400889D")]
    public const int CHAPTER_COIN_ID = 201020001;
    [Token(Token = "0x400889E")]
    [FieldOffset(Offset = "0x28")]
    private CurrencyData baseData;

    [Token(Token = "0x170027B9")]
    public CurrencyData MasterData
    {
      [Token(Token = "0x600BF24"), Address(RVA = "0x20057D8", Offset = "0x20057D8", VA = "0x20057D8")] get
      {
        return (CurrencyData) null;
      }
    }

    [Token(Token = "0x170027BA")]
    public override string Name
    {
      [Token(Token = "0x600BF25"), Address(RVA = "0x20058AC", Offset = "0x20058AC", VA = "0x20058AC", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170027BB")]
    public override ItemTypeEnum ItemType
    {
      [Token(Token = "0x600BF26"), Address(RVA = "0x20058C8", Offset = "0x20058C8", VA = "0x20058C8", Slot = "5")] get
      {
        return new ItemTypeEnum();
      }
    }

    [Token(Token = "0x170027BC")]
    public override RarityTypeEnum Rarity
    {
      [Token(Token = "0x600BF27"), Address(RVA = "0x20058E4", Offset = "0x20058E4", VA = "0x20058E4", Slot = "6")] get
      {
        return new RarityTypeEnum();
      }
    }

    [Token(Token = "0x170027BD")]
    public override bool IsSellable
    {
      [Token(Token = "0x600BF28"), Address(RVA = "0x2005900", Offset = "0x2005900", VA = "0x2005900", Slot = "7")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600BF29")]
    [Address(RVA = "0x200591C", Offset = "0x200591C", VA = "0x200591C")]
    private CurrencyItem()
    {
    }

    [Token(Token = "0x600BF2A")]
    [Address(RVA = "0x2005924", Offset = "0x2005924", VA = "0x2005924")]
    public void Apply(PlayerCurrencyItemType entity)
    {
    }

    [Token(Token = "0x600BF2B")]
    [Address(RVA = "0x2005940", Offset = "0x2005940", VA = "0x2005940")]
    public static CurrencyItem CreateByServerData(PlayerCurrencyItemType entity)
    {
      return (CurrencyItem) null;
    }

    [Token(Token = "0x600BF2C")]
    [Address(RVA = "0x2005A20", Offset = "0x2005A20", VA = "0x2005A20")]
    public ItemListData GetItemListData(ItemUtility.Parameter parameter) => (ItemListData) null;
  }
}
