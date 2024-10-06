// Decompiled with JetBrains decompiler
// Type: StaqData.WeaponPieceItem
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
  [Token(Token = "0x2002040")]
  public sealed class WeaponPieceItem : Item
  {
    [Token(Token = "0x4008925")]
    [FieldOffset(Offset = "0x28")]
    private WeaponPieceData baseData;

    [Token(Token = "0x17002897")]
    public WeaponPieceData MasterData
    {
      [Token(Token = "0x600C165"), Address(RVA = "0x1939D78", Offset = "0x1939D78", VA = "0x1939D78")] get
      {
        return (WeaponPieceData) null;
      }
    }

    [Token(Token = "0x17002898")]
    public override string Name
    {
      [Token(Token = "0x600C166"), Address(RVA = "0x1939E4C", Offset = "0x1939E4C", VA = "0x1939E4C", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002899")]
    public override ItemTypeEnum ItemType
    {
      [Token(Token = "0x600C167"), Address(RVA = "0x1939E68", Offset = "0x1939E68", VA = "0x1939E68", Slot = "5")] get
      {
        return new ItemTypeEnum();
      }
    }

    [Token(Token = "0x1700289A")]
    public override RarityTypeEnum Rarity
    {
      [Token(Token = "0x600C168"), Address(RVA = "0x1939E84", Offset = "0x1939E84", VA = "0x1939E84", Slot = "6")] get
      {
        return new RarityTypeEnum();
      }
    }

    [Token(Token = "0x1700289B")]
    public override bool IsSellable
    {
      [Token(Token = "0x600C169"), Address(RVA = "0x1939EA0", Offset = "0x1939EA0", VA = "0x1939EA0", Slot = "7")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600C16A")]
    [Address(RVA = "0x1939EBC", Offset = "0x1939EBC", VA = "0x1939EBC")]
    private WeaponPieceItem()
    {
    }

    [Token(Token = "0x600C16B")]
    [Address(RVA = "0x1939EC4", Offset = "0x1939EC4", VA = "0x1939EC4")]
    public void Apply(PlayerWeaponPieceType entity)
    {
    }

    [Token(Token = "0x600C16C")]
    [Address(RVA = "0x1939F7C", Offset = "0x1939F7C", VA = "0x1939F7C")]
    public void Reset()
    {
    }

    [Token(Token = "0x600C16D")]
    [Address(RVA = "0x1939F84", Offset = "0x1939F84", VA = "0x1939F84")]
    public static WeaponPieceItem CreateByServerData(PlayerWeaponPieceType entity)
    {
      return (WeaponPieceItem) null;
    }

    [Token(Token = "0x600C16E")]
    [Address(RVA = "0x193A064", Offset = "0x193A064", VA = "0x193A064")]
    public static WeaponPieceItem CreateByDummyData(int id) => (WeaponPieceItem) null;

    [Token(Token = "0x600C16F")]
    [Address(RVA = "0x193A140", Offset = "0x193A140", VA = "0x193A140")]
    public ItemListData GetItemListData(ItemUtility.Parameter parameter) => (ItemListData) null;
  }
}
