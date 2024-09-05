// Decompiled with JetBrains decompiler
// Type: StaqData.AccessoryPieceItem
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
  [Token(Token = "0x200200F")]
  public sealed class AccessoryPieceItem : Item
  {
    [Token(Token = "0x17002799")]
    public AccessoryPieceData MasterData
    {
      [Token(Token = "0x600BEEF"), Address(RVA = "0x2004560", Offset = "0x2004560", VA = "0x2004560")] get
      {
        return (AccessoryPieceData) null;
      }
      [Token(Token = "0x600BEF0"), Address(RVA = "0x2004568", Offset = "0x2004568", VA = "0x2004568")] private set
      {
      }
    }

    [Token(Token = "0x1700279A")]
    public override string Name
    {
      [Token(Token = "0x600BEF1"), Address(RVA = "0x2004570", Offset = "0x2004570", VA = "0x2004570", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700279B")]
    public override ItemTypeEnum ItemType
    {
      [Token(Token = "0x600BEF2"), Address(RVA = "0x200458C", Offset = "0x200458C", VA = "0x200458C", Slot = "5")] get
      {
        return new ItemTypeEnum();
      }
    }

    [Token(Token = "0x1700279C")]
    public override RarityTypeEnum Rarity
    {
      [Token(Token = "0x600BEF3"), Address(RVA = "0x2004594", Offset = "0x2004594", VA = "0x2004594", Slot = "6")] get
      {
        return new RarityTypeEnum();
      }
    }

    [Token(Token = "0x1700279D")]
    public override bool IsSellable
    {
      [Token(Token = "0x600BEF4"), Address(RVA = "0x20045B0", Offset = "0x20045B0", VA = "0x20045B0", Slot = "7")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600BEF5")]
    [Address(RVA = "0x20045CC", Offset = "0x20045CC", VA = "0x20045CC")]
    private AccessoryPieceItem()
    {
    }

    [Token(Token = "0x600BEF6")]
    [Address(RVA = "0x20045D4", Offset = "0x20045D4", VA = "0x20045D4")]
    public void Apply(PlayerAccessoryPieceType entity)
    {
    }

    [Token(Token = "0x600BEF7")]
    [Address(RVA = "0x200468C", Offset = "0x200468C", VA = "0x200468C")]
    public void Reset()
    {
    }

    [Token(Token = "0x600BEF8")]
    [Address(RVA = "0x2004694", Offset = "0x2004694", VA = "0x2004694")]
    public static AccessoryPieceItem CreateByServerData(PlayerAccessoryPieceType entity)
    {
      return (AccessoryPieceItem) null;
    }

    [Token(Token = "0x600BEF9")]
    [Address(RVA = "0x20047F8", Offset = "0x20047F8", VA = "0x20047F8")]
    public static AccessoryPieceItem CreateByDummyData(int id) => (AccessoryPieceItem) null;

    [Token(Token = "0x600BEFA")]
    [Address(RVA = "0x2004950", Offset = "0x2004950", VA = "0x2004950")]
    public ItemListData GetItemListData(ItemUtility.Parameter parameter) => (ItemListData) null;
  }
}
