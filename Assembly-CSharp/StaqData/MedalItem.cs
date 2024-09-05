// Decompiled with JetBrains decompiler
// Type: StaqData.MedalItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;
using Scenes.OutGame;
using System;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x200203A")]
  public sealed class MedalItem : Item
  {
    [Token(Token = "0x400891D")]
    [FieldOffset(Offset = "0x28")]
    private MedalData baseData;

    [Token(Token = "0x17002874")]
    public MedalData MasterData
    {
      [Token(Token = "0x600C125"), Address(RVA = "0x20127B4", Offset = "0x20127B4", VA = "0x20127B4")] get
      {
        return (MedalData) null;
      }
    }

    [Token(Token = "0x17002875")]
    public override string Name
    {
      [Token(Token = "0x600C126"), Address(RVA = "0x2012888", Offset = "0x2012888", VA = "0x2012888", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002876")]
    public override ItemTypeEnum ItemType
    {
      [Token(Token = "0x600C127"), Address(RVA = "0x20128A4", Offset = "0x20128A4", VA = "0x20128A4", Slot = "5")] get
      {
        return new ItemTypeEnum();
      }
    }

    [Token(Token = "0x17002877")]
    public override RarityTypeEnum Rarity
    {
      [Token(Token = "0x600C128"), Address(RVA = "0x20128C0", Offset = "0x20128C0", VA = "0x20128C0", Slot = "6")] get
      {
        return new RarityTypeEnum();
      }
    }

    [Token(Token = "0x17002878")]
    public override bool IsSellable
    {
      [Token(Token = "0x600C129"), Address(RVA = "0x20128DC", Offset = "0x20128DC", VA = "0x20128DC", Slot = "7")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002879")]
    public override bool HasExpirationDate
    {
      [Token(Token = "0x600C12A"), Address(RVA = "0x20128F8", Offset = "0x20128F8", VA = "0x20128F8", Slot = "8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700287A")]
    public override DateTime ExpirationBeginDate
    {
      [Token(Token = "0x600C12B"), Address(RVA = "0x2012900", Offset = "0x2012900", VA = "0x2012900", Slot = "9")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x1700287B")]
    public override DateTime ExpirationEndDate
    {
      [Token(Token = "0x600C12C"), Address(RVA = "0x2012908", Offset = "0x2012908", VA = "0x2012908", Slot = "10")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x600C12D")]
    [Address(RVA = "0x2012910", Offset = "0x2012910", VA = "0x2012910")]
    private MedalItem()
    {
    }

    [Token(Token = "0x600C12E")]
    [Address(RVA = "0x2012918", Offset = "0x2012918", VA = "0x2012918")]
    public void Apply(PlayerMedalType entity)
    {
    }

    [Token(Token = "0x600C12F")]
    [Address(RVA = "0x20129CC", Offset = "0x20129CC", VA = "0x20129CC")]
    public static MedalItem CreateByServerData(PlayerMedalType entity) => (MedalItem) null;

    [Token(Token = "0x600C130")]
    [Address(RVA = "0x2012AAC", Offset = "0x2012AAC", VA = "0x2012AAC")]
    public static MedalItem CreateByDummyData(int itemId, int stackCount = 0) => (MedalItem) null;

    [Token(Token = "0x600C131")]
    [Address(RVA = "0x2012B8C", Offset = "0x2012B8C", VA = "0x2012B8C")]
    public ItemListData GetItemListData(ItemUtility.Parameter parameter) => (ItemListData) null;
  }
}
