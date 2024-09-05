// Decompiled with JetBrains decompiler
// Type: StaqData.Sort.EquipSortUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace StaqData.Sort
{
  [Token(Token = "0x2002187")]
  public static class EquipSortUtility
  {
    [Token(Token = "0x600CD08")]
    [Address(RVA = "0x4B54CF4", Offset = "0x4B54CF4", VA = "0x4B54CF4")]
    public static EquipmentSortCondition GetCurrentSortCondition(EquipmentType equipmentType)
    {
      return new EquipmentSortCondition();
    }

    [Token(Token = "0x600CD09")]
    [Address(RVA = "0x4B54DDC", Offset = "0x4B54DDC", VA = "0x4B54DDC")]
    public static string GetCurrentLocalizedSorText(EquipmentType equipmentType) => (string) null;

    [Token(Token = "0x600CD0A")]
    [Address(RVA = "0x4B54DF0", Offset = "0x4B54DF0", VA = "0x4B54DF0")]
    public static List<Equipment> SortEquipList(EquipmentType equipmentType, List<Equipment> list)
    {
      return (List<Equipment>) null;
    }

    [Token(Token = "0x600CD0B")]
    [Address(RVA = "0x4B54FF4", Offset = "0x4B54FF4", VA = "0x4B54FF4")]
    public static List<Equipment> SortEquipList(
      EquipmentType equipmentType,
      List<Equipment> list,
      List<UniqueID> equipList)
    {
      return (List<Equipment>) null;
    }

    [Token(Token = "0x600CD0C")]
    [Address(RVA = "0x4B551C8", Offset = "0x4B551C8", VA = "0x4B551C8")]
    public static List<Equipment> SortEquipList(
      EquipmentType equipmentType,
      List<Equipment> list,
      EquipmentSortCondition condition,
      EquipmentSortOrder order,
      bool isEquip,
      List<UniqueID> equipList)
    {
      return (List<Equipment>) null;
    }

    [Token(Token = "0x600CD0D")]
    private static IOrderedEnumerable<Equipment> OrderBy<T>(
      this List<Equipment> source,
      EquipmentSortOrder order,
      Func<Equipment, T> selector)
    {
      return (IOrderedEnumerable<Equipment>) null;
    }

    [Token(Token = "0x600CD0E")]
    private static IOrderedEnumerable<Equipment> ThenBy<Equipment, T>(
      this IOrderedEnumerable<Equipment> source,
      EquipmentSortOrder order,
      Func<Equipment, T> selector)
    {
      return (IOrderedEnumerable<Equipment>) null;
    }

    [Token(Token = "0x600CD0F")]
    private static IOrderedEnumerable<Equipment> ThenByForCommon<T>(
      this IOrderedEnumerable<Equipment> tmpSorted,
      EquipmentSortOrder order,
      Func<Equipment, T> selector)
    {
      return (IOrderedEnumerable<Equipment>) null;
    }

    [Token(Token = "0x600CD10")]
    [Address(RVA = "0x4B55314", Offset = "0x4B55314", VA = "0x4B55314")]
    private static IOrderedEnumerable<Equipment> ThenByCondition(
      this IOrderedEnumerable<Equipment> tmpSorted,
      EquipmentSortCondition condition,
      EquipmentSortOrder order)
    {
      return (IOrderedEnumerable<Equipment>) null;
    }

    [Token(Token = "0x600CD11")]
    [Address(RVA = "0x4B58650", Offset = "0x4B58650", VA = "0x4B58650")]
    private static int ID(Equipment equipment) => new int();

    [Token(Token = "0x600CD12")]
    [Address(RVA = "0x4B58668", Offset = "0x4B58668", VA = "0x4B58668")]
    private static RarityTypeEnum Rarity(Equipment equipment) => new RarityTypeEnum();

    [Token(Token = "0x600CD13")]
    [Address(RVA = "0x4B58684", Offset = "0x4B58684", VA = "0x4B58684")]
    private static int LimitBreak(Equipment equipment) => new int();

    [Token(Token = "0x600CD14")]
    [Address(RVA = "0x4B58740", Offset = "0x4B58740", VA = "0x4B58740")]
    private static int Level(Equipment equipment) => new int();

    [Token(Token = "0x600CD15")]
    [Address(RVA = "0x4B5881C", Offset = "0x4B5881C", VA = "0x4B5881C")]
    private static int SkillLevel(Equipment equipment) => new int();

    [Token(Token = "0x600CD16")]
    [Address(RVA = "0x4B58B40", Offset = "0x4B58B40", VA = "0x4B58B40")]
    private static int Durable(Equipment equipment) => new int();

    [Token(Token = "0x600CD17")]
    [Address(RVA = "0x4B58BAC", Offset = "0x4B58BAC", VA = "0x4B58BAC")]
    private static int Power(Equipment equipment) => new int();

    [Token(Token = "0x600CD18")]
    [Address(RVA = "0x4B58C18", Offset = "0x4B58C18", VA = "0x4B58C18")]
    private static int Weight(Equipment equipment) => new int();

    [Token(Token = "0x600CD19")]
    [Address(RVA = "0x4B58CE8", Offset = "0x4B58CE8", VA = "0x4B58CE8")]
    private static int Trust(Equipment equipment) => new int();
  }
}
