// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.ConsumableMaterialList.ItemListModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.ConsumableMaterialList
{
  [Token(Token = "0x2003BEE")]
  public class ItemListModel
  {
    [Token(Token = "0x401098D")]
    [FieldOffset(Offset = "0x10")]
    private List<ItemGroup> _itemGroups;

    [Token(Token = "0x17004C84")]
    private static string LabelSoul
    {
      [Token(Token = "0x60178E4"), Address(RVA = "0x237A0D4", Offset = "0x237A0D4", VA = "0x237A0D4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17004C85")]
    private static string LabelEnhance
    {
      [Token(Token = "0x60178E5"), Address(RVA = "0x237A154", Offset = "0x237A154", VA = "0x237A154")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60178E6")]
    [Address(RVA = "0x237A1D4", Offset = "0x237A1D4", VA = "0x237A1D4")]
    public static ItemListModel CreateForStyleList() => (ItemListModel) null;

    [Token(Token = "0x60178E7")]
    [Address(RVA = "0x237A4CC", Offset = "0x237A4CC", VA = "0x237A4CC")]
    public static ItemListModel CreateForWeaponList() => (ItemListModel) null;

    [Token(Token = "0x60178E8")]
    [Address(RVA = "0x237A720", Offset = "0x237A720", VA = "0x237A720")]
    public static ItemListModel CreateForAccessoryList() => (ItemListModel) null;

    [Token(Token = "0x60178E9")]
    [Address(RVA = "0x237A7B8", Offset = "0x237A7B8", VA = "0x237A7B8")]
    public static ItemListModel CreateForMindequipmentList() => (ItemListModel) null;

    [Token(Token = "0x60178EA")]
    [Address(RVA = "0x237A830", Offset = "0x237A830", VA = "0x237A830")]
    public static ItemListModel CreateForTrustList() => (ItemListModel) null;

    [Token(Token = "0x60178EB")]
    [Address(RVA = "0x237A8C8", Offset = "0x237A8C8", VA = "0x237A8C8")]
    public static ItemListModel CreateForCustomSkillList() => (ItemListModel) null;

    [Token(Token = "0x17004C86")]
    public IReadOnlyList<ItemGroup> ItemGroups
    {
      [Token(Token = "0x60178EC"), Address(RVA = "0x237A940", Offset = "0x237A940", VA = "0x237A940")] get
      {
        return (IReadOnlyList<ItemGroup>) null;
      }
    }

    [Token(Token = "0x17004C87")]
    public int ItemCount
    {
      [Token(Token = "0x60178ED"), Address(RVA = "0x237A948", Offset = "0x237A948", VA = "0x237A948")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004C88")]
    public bool IsMiniSize
    {
      [Token(Token = "0x60178EE"), Address(RVA = "0x237AA9C", Offset = "0x237AA9C", VA = "0x237AA9C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60178EF")]
    [Address(RVA = "0x237A268", Offset = "0x237A268", VA = "0x237A268")]
    private ItemListModel()
    {
    }

    [Token(Token = "0x60178F0")]
    [Address(RVA = "0x237A2E8", Offset = "0x237A2E8", VA = "0x237A2E8")]
    private static List<ItemParam> GetBlueSoul() => (List<ItemParam>) null;

    [Token(Token = "0x60178F1")]
    [Address(RVA = "0x237A564", Offset = "0x237A564", VA = "0x237A564")]
    private static List<ItemParam> GetRedSoul() => (List<ItemParam>) null;

    [Token(Token = "0x60178F2")]
    [Address(RVA = "0x237AB04", Offset = "0x237AB04", VA = "0x237AB04")]
    private static List<ItemParam> GetSoul(SoulTypeEnum soulType) => (List<ItemParam>) null;

    [Token(Token = "0x60178F3")]
    [Address(RVA = "0x237A368", Offset = "0x237A368", VA = "0x237A368")]
    private static List<ItemParam> GetAbilityBoardItem() => (List<ItemParam>) null;

    [Token(Token = "0x60178F4")]
    [Address(RVA = "0x237A56C", Offset = "0x237A56C", VA = "0x237A56C")]
    private static List<ItemParam> GetEquipmentSkillEnhanceData(ItemTypeEnum itemType)
    {
      return (List<ItemParam>) null;
    }

    [Token(Token = "0x60178F5")]
    [Address(RVA = "0x237AC6C", Offset = "0x237AC6C", VA = "0x237AC6C")]
    private void AddGroup(ItemGroup itemGroup)
    {
    }

    [Token(Token = "0x60178F6")]
    [Address(RVA = "0x237A2F0", Offset = "0x237A2F0", VA = "0x237A2F0")]
    private void AddGroup(string name, List<ItemParam> items)
    {
    }
  }
}
