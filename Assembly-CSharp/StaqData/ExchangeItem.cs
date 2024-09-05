// Decompiled with JetBrains decompiler
// Type: StaqData.ExchangeItem
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
  [Token(Token = "0x2002033")]
  public sealed class ExchangeItem : Item
  {
    [Token(Token = "0x4008913")]
    [FieldOffset(Offset = "0x28")]
    private ExchangeData baseData;

    [Token(Token = "0x1700284B")]
    public ExchangeData MasterData
    {
      [Token(Token = "0x600C0D8"), Address(RVA = "0x2011214", Offset = "0x2011214", VA = "0x2011214")] get
      {
        return (ExchangeData) null;
      }
    }

    [Token(Token = "0x1700284C")]
    public override string Name
    {
      [Token(Token = "0x600C0D9"), Address(RVA = "0x20112E8", Offset = "0x20112E8", VA = "0x20112E8", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700284D")]
    public override ItemTypeEnum ItemType
    {
      [Token(Token = "0x600C0DA"), Address(RVA = "0x2011304", Offset = "0x2011304", VA = "0x2011304", Slot = "5")] get
      {
        return new ItemTypeEnum();
      }
    }

    [Token(Token = "0x1700284E")]
    public override RarityTypeEnum Rarity
    {
      [Token(Token = "0x600C0DB"), Address(RVA = "0x2011320", Offset = "0x2011320", VA = "0x2011320", Slot = "6")] get
      {
        return new RarityTypeEnum();
      }
    }

    [Token(Token = "0x1700284F")]
    public override bool IsSellable
    {
      [Token(Token = "0x600C0DC"), Address(RVA = "0x201133C", Offset = "0x201133C", VA = "0x201133C", Slot = "7")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600C0DD")]
    [Address(RVA = "0x2011358", Offset = "0x2011358", VA = "0x2011358")]
    private ExchangeItem()
    {
    }

    [Token(Token = "0x600C0DE")]
    [Address(RVA = "0x2011360", Offset = "0x2011360", VA = "0x2011360")]
    public void Apply(PlayerExchangeItemType entity)
    {
    }

    [Token(Token = "0x600C0DF")]
    [Address(RVA = "0x201137C", Offset = "0x201137C", VA = "0x201137C")]
    public static ExchangeItem CreateByServerData(PlayerExchangeItemType entity)
    {
      return (ExchangeItem) null;
    }

    [Token(Token = "0x600C0E0")]
    [Address(RVA = "0x201145C", Offset = "0x201145C", VA = "0x201145C")]
    public ItemListData GetItemListData(ItemUtility.Parameter parameter) => (ItemListData) null;
  }
}
