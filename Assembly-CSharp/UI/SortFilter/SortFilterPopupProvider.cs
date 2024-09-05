// Decompiled with JetBrains decompiler
// Type: UI.SortFilter.SortFilterPopupProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using Scenes.OutGame;
using StaqData;
using System;
using System.Collections.Generic;
using TeamOrganization;
using UnityEngine;

#nullable disable
namespace UI.SortFilter
{
  [Token(Token = "0x2000940")]
  public static class SortFilterPopupProvider
  {
    [Token(Token = "0x4002AF2")]
    private const string ASSETBUNDLE_NAME = "ui_page_sortfilter_prefab";

    [Token(Token = "0x600341C")]
    [Address(RVA = "0x362DA8C", Offset = "0x362DA8C", VA = "0x362DA8C")]
    public static AssetSpawnOperation<GameObject> RequestStyle(
      AssetCachedSpawner spawner,
      List<Style> possessionList,
      List<Style> notPossessionList,
      List<int> setStyleIDs,
      Action<List<Style>> sortAction)
    {
      return (AssetSpawnOperation<GameObject>) null;
    }

    [Token(Token = "0x600341D")]
    [Address(RVA = "0x362DBB4", Offset = "0x362DBB4", VA = "0x362DBB4")]
    public static AssetSpawnOperation<GameObject> RequestStyle(
      AssetCachedSpawner spawner,
      Action<List<Style>> sortAction)
    {
      return (AssetSpawnOperation<GameObject>) null;
    }

    [Token(Token = "0x600341E")]
    [Address(RVA = "0x362DC94", Offset = "0x362DC94", VA = "0x362DC94")]
    public static AssetSpawnOperation<GameObject> RequestStyleEdit(
      AssetCachedSpawner spawner,
      List<int> setStyleIDs,
      Action<List<Style>> sortAction)
    {
      return (AssetSpawnOperation<GameObject>) null;
    }

    [Token(Token = "0x600341F")]
    [Address(RVA = "0x362DD98", Offset = "0x362DD98", VA = "0x362DD98")]
    public static AssetSpawnOperation<GameObject> RequestWeapon(
      AssetCachedSpawner spawner,
      Action<List<Equipment>> sortAction)
    {
      return (AssetSpawnOperation<GameObject>) null;
    }

    [Token(Token = "0x6003420")]
    [Address(RVA = "0x362E10C", Offset = "0x362E10C", VA = "0x362E10C")]
    public static AssetSpawnOperation<GameObject> RequestWeaponEdit(
      AssetCachedSpawner spawner,
      List<Equipment> equipList,
      List<UniqueID> setUniqueIDs,
      Action<List<Equipment>> sortAction)
    {
      return (AssetSpawnOperation<GameObject>) null;
    }

    [Token(Token = "0x6003421")]
    [Address(RVA = "0x362E17C", Offset = "0x362E17C", VA = "0x362E17C")]
    public static AssetSpawnOperation<GameObject> RequestAccessory(
      AssetCachedSpawner spawner,
      Action<List<Equipment>> sortAction)
    {
      return (AssetSpawnOperation<GameObject>) null;
    }

    [Token(Token = "0x6003422")]
    [Address(RVA = "0x362E3E4", Offset = "0x362E3E4", VA = "0x362E3E4")]
    public static AssetSpawnOperation<GameObject> RequestAccessoryEdit(
      AssetCachedSpawner spawner,
      List<Equipment> equipList,
      List<UniqueID> setUniqueIDs,
      Action<List<Equipment>> sortAction)
    {
      return (AssetSpawnOperation<GameObject>) null;
    }

    [Token(Token = "0x6003423")]
    [Address(RVA = "0x362E454", Offset = "0x362E454", VA = "0x362E454")]
    public static AssetSpawnOperation<GameObject> RequestMindEquipment(
      AssetCachedSpawner spawner,
      List<MindEquipment> mindEquipments,
      Action<List<Equipment>> sortAction)
    {
      return (AssetSpawnOperation<GameObject>) null;
    }

    [Token(Token = "0x6003424")]
    [Address(RVA = "0x362E6A0", Offset = "0x362E6A0", VA = "0x362E6A0")]
    public static AssetSpawnOperation<GameObject> RequestMindEquipmentEdit(
      AssetCachedSpawner spawner,
      List<Equipment> equipList,
      List<UniqueID> setUniqueIDs,
      Action<List<Equipment>> sortAction)
    {
      return (AssetSpawnOperation<GameObject>) null;
    }

    [Token(Token = "0x6003425")]
    [Address(RVA = "0x362E710", Offset = "0x362E710", VA = "0x362E710")]
    public static AssetSpawnOperation<GameObject> RequestTrust(
      AssetCachedSpawner spawner,
      Action<List<Equipment>> sortAction)
    {
      return (AssetSpawnOperation<GameObject>) null;
    }

    [Token(Token = "0x6003426")]
    [Address(RVA = "0x362E978", Offset = "0x362E978", VA = "0x362E978")]
    public static AssetSpawnOperation<GameObject> RequestTrustEdit(
      AssetCachedSpawner spawner,
      List<Equipment> equipList,
      List<UniqueID> setUniqueIDs,
      Action<List<Equipment>> sortAction)
    {
      return (AssetSpawnOperation<GameObject>) null;
    }

    [Token(Token = "0x6003427")]
    [Address(RVA = "0x362E9E8", Offset = "0x362E9E8", VA = "0x362E9E8")]
    public static AssetSpawnOperation<GameObject> RequestCustomSkill(
      string assetName,
      AssetCachedSpawner spawner,
      List<CustomSkill> customSkills,
      List<UniqueID> setUniqueIDs,
      Action<List<CustomSkill>> sortAction,
      Transform buttonTrans = null)
    {
      return (AssetSpawnOperation<GameObject>) null;
    }

    [Token(Token = "0x6003428")]
    [Address(RVA = "0x362EAFC", Offset = "0x362EAFC", VA = "0x362EAFC")]
    public static AssetSpawnOperation<GameObject> RequestCustomSkill(
      string assetName,
      AssetCachedSpawner spawner,
      List<UniqueID> setUniqueIDs,
      Action<List<CustomSkill>> sortAction,
      Transform buttonTrans = null)
    {
      return (AssetSpawnOperation<GameObject>) null;
    }

    [Token(Token = "0x6003429")]
    [Address(RVA = "0x362ED60", Offset = "0x362ED60", VA = "0x362ED60")]
    public static AssetSpawnOperation<GameObject> RequestCustomSkill(
      AssetCachedSpawner spawner,
      Action<List<CustomSkill>> sortAction)
    {
      return (AssetSpawnOperation<GameObject>) null;
    }

    [Token(Token = "0x600342A")]
    [Address(RVA = "0x362EDBC", Offset = "0x362EDBC", VA = "0x362EDBC")]
    public static AssetSpawnOperation<GameObject> RequestCustomSkillEdit(
      AssetCachedSpawner spawner,
      List<UniqueID> setUniqueIDs,
      Action<List<CustomSkill>> sortAction)
    {
      return (AssetSpawnOperation<GameObject>) null;
    }

    [Token(Token = "0x600342B")]
    [Address(RVA = "0x362EE1C", Offset = "0x362EE1C", VA = "0x362EE1C")]
    public static AssetSpawnOperation<GameObject> RequestEquipEdit(
      OrganizationEquipmentSlot.EquipmentSlotType slotType,
      AssetCachedSpawner spawner,
      List<Equipment> equipList,
      List<UniqueID> setUniqueIDs,
      Action<List<Equipment>> sortAction)
    {
      return (AssetSpawnOperation<GameObject>) null;
    }

    [Token(Token = "0x600342C")]
    [Address(RVA = "0x362E000", Offset = "0x362E000", VA = "0x362E000")]
    private static AssetSpawnOperation<GameObject> RequestEquip(
      string assetName,
      AssetCachedSpawner spawner,
      List<Equipment> equipList,
      List<UniqueID> setEquipmentUniqueIDs,
      Action<List<Equipment>> sortAction)
    {
      return (AssetSpawnOperation<GameObject>) null;
    }

    [Token(Token = "0x600342D")]
    [Address(RVA = "0x362EEA0", Offset = "0x362EEA0", VA = "0x362EEA0")]
    public static AssetSpawnOperation<GameObject> RequestSaleItem(
      AssetCachedSpawner spawner,
      Dictionary<int, List<ItemListData>> categoryItemMap,
      Action<Dictionary<int, List<ItemListData>>> sortAction)
    {
      return (AssetSpawnOperation<GameObject>) null;
    }

    [Token(Token = "0x600342E")]
    [Address(RVA = "0x362EFB4", Offset = "0x362EFB4", VA = "0x362EFB4")]
    public static AssetSpawnOperation<GameObject> RequestItem(
      AssetCachedSpawner spawner,
      List<Item> itemList,
      Action<List<Item>> sortAction)
    {
      return (AssetSpawnOperation<GameObject>) null;
    }
  }
}
