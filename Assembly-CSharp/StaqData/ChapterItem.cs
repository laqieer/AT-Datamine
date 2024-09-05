// Decompiled with JetBrains decompiler
// Type: StaqData.ChapterItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Scenes.OutGame;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002013")]
  public class ChapterItem : Item
  {
    [Token(Token = "0x4008899")]
    [FieldOffset(Offset = "0x28")]
    private ChapterItemData baseData;
    [Token(Token = "0x400889A")]
    [FieldOffset(Offset = "0x30")]
    private BookInfo bookInfo;

    [Token(Token = "0x170027B0")]
    public ChapterItemData MasterData
    {
      [Token(Token = "0x600BF16"), Address(RVA = "0x20052C4", Offset = "0x20052C4", VA = "0x20052C4")] get
      {
        return (ChapterItemData) null;
      }
    }

    [Token(Token = "0x170027B1")]
    public BookInfo Book
    {
      [Token(Token = "0x600BF17"), Address(RVA = "0x2005398", Offset = "0x2005398", VA = "0x2005398")] get
      {
        return (BookInfo) null;
      }
      [Token(Token = "0x600BF18"), Address(RVA = "0x200542C", Offset = "0x200542C", VA = "0x200542C")] set
      {
      }
    }

    [Token(Token = "0x170027B2")]
    public override string Name
    {
      [Token(Token = "0x600BF19"), Address(RVA = "0x2005434", Offset = "0x2005434", VA = "0x2005434", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170027B3")]
    public override ItemTypeEnum ItemType
    {
      [Token(Token = "0x600BF1A"), Address(RVA = "0x2005450", Offset = "0x2005450", VA = "0x2005450", Slot = "5")] get
      {
        return new ItemTypeEnum();
      }
    }

    [Token(Token = "0x170027B4")]
    public override RarityTypeEnum Rarity
    {
      [Token(Token = "0x600BF1B"), Address(RVA = "0x200546C", Offset = "0x200546C", VA = "0x200546C", Slot = "6")] get
      {
        return new RarityTypeEnum();
      }
    }

    [Token(Token = "0x170027B5")]
    public override bool IsSellable
    {
      [Token(Token = "0x600BF1C"), Address(RVA = "0x2005488", Offset = "0x2005488", VA = "0x2005488", Slot = "7")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170027B6")]
    public int ItemID
    {
      [Token(Token = "0x600BF1D"), Address(RVA = "0x20054A4", Offset = "0x20054A4", VA = "0x20054A4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170027B7")]
    public int ItemCount
    {
      [Token(Token = "0x600BF1E"), Address(RVA = "0x20054AC", Offset = "0x20054AC", VA = "0x20054AC")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170027B8")]
    public int UseCount
    {
      [Token(Token = "0x600BF1F"), Address(RVA = "0x20054B4", Offset = "0x20054B4", VA = "0x20054B4")] get
      {
        return new int();
      }
      [Token(Token = "0x600BF20"), Address(RVA = "0x20054BC", Offset = "0x20054BC", VA = "0x20054BC")] private set
      {
      }
    }

    [Token(Token = "0x600BF21")]
    [Address(RVA = "0x20054C4", Offset = "0x20054C4", VA = "0x20054C4")]
    public ChapterItem(int itemID)
    {
    }

    [Token(Token = "0x600BF22")]
    [Address(RVA = "0x200557C", Offset = "0x200557C", VA = "0x200557C")]
    public void SetValue(int itemCount, int useCount)
    {
    }

    [Token(Token = "0x600BF23")]
    [Address(RVA = "0x2005588", Offset = "0x2005588", VA = "0x2005588")]
    public ItemListData GetItemListData(ItemUtility.Parameter parameter) => (ItemListData) null;
  }
}
