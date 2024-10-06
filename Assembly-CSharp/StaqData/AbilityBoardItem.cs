// Decompiled with JetBrains decompiler
// Type: StaqData.AbilityBoardItem
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
  [Token(Token = "0x200200E")]
  public sealed class AbilityBoardItem : Item
  {
    [Token(Token = "0x4008894")]
    [FieldOffset(Offset = "0x28")]
    private AbilityBoardItemData baseData;

    [Token(Token = "0x17002794")]
    public AbilityBoardItemData MasterData
    {
      [Token(Token = "0x600BEE4"), Address(RVA = "0x2003F7C", Offset = "0x2003F7C", VA = "0x2003F7C")] get
      {
        return (AbilityBoardItemData) null;
      }
    }

    [Token(Token = "0x17002795")]
    public override string Name
    {
      [Token(Token = "0x600BEE5"), Address(RVA = "0x2004050", Offset = "0x2004050", VA = "0x2004050", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002796")]
    public override ItemTypeEnum ItemType
    {
      [Token(Token = "0x600BEE6"), Address(RVA = "0x200406C", Offset = "0x200406C", VA = "0x200406C", Slot = "5")] get
      {
        return new ItemTypeEnum();
      }
    }

    [Token(Token = "0x17002797")]
    public override RarityTypeEnum Rarity
    {
      [Token(Token = "0x600BEE7"), Address(RVA = "0x2004088", Offset = "0x2004088", VA = "0x2004088", Slot = "6")] get
      {
        return new RarityTypeEnum();
      }
    }

    [Token(Token = "0x17002798")]
    public override bool IsSellable
    {
      [Token(Token = "0x600BEE8"), Address(RVA = "0x20040A4", Offset = "0x20040A4", VA = "0x20040A4", Slot = "7")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600BEE9")]
    [Address(RVA = "0x20040C0", Offset = "0x20040C0", VA = "0x20040C0")]
    private AbilityBoardItem()
    {
    }

    [Token(Token = "0x600BEEA")]
    [Address(RVA = "0x20040D0", Offset = "0x20040D0", VA = "0x20040D0")]
    public void Apply(PlayerAbilityBoardItemType entity)
    {
    }

    [Token(Token = "0x600BEEB")]
    [Address(RVA = "0x2004188", Offset = "0x2004188", VA = "0x2004188")]
    public void Reset()
    {
    }

    [Token(Token = "0x600BEEC")]
    [Address(RVA = "0x2004190", Offset = "0x2004190", VA = "0x2004190")]
    public static AbilityBoardItem CreateByServerData(PlayerAbilityBoardItemType entity)
    {
      return (AbilityBoardItem) null;
    }

    [Token(Token = "0x600BEED")]
    [Address(RVA = "0x2004270", Offset = "0x2004270", VA = "0x2004270")]
    public static AbilityBoardItem CreateByDummyData(int id) => (AbilityBoardItem) null;

    [Token(Token = "0x600BEEE")]
    [Address(RVA = "0x200434C", Offset = "0x200434C", VA = "0x200434C")]
    public ItemListData GetItemListData(ItemUtility.Parameter parameter) => (ItemListData) null;
  }
}
