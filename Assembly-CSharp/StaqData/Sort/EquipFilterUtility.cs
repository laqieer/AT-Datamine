// Decompiled with JetBrains decompiler
// Type: StaqData.Sort.EquipFilterUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace StaqData.Sort
{
  [Token(Token = "0x200217A")]
  public static class EquipFilterUtility
  {
    [Token(Token = "0x600CCEC")]
    [Address(RVA = "0x1BB3EA4", Offset = "0x1BB3EA4", VA = "0x1BB3EA4")]
    public static bool IsAnyFiltered(EquipmentType equipmentType) => new bool();

    [Token(Token = "0x600CCED")]
    [Address(RVA = "0x1BB404C", Offset = "0x1BB404C", VA = "0x1BB404C")]
    public static List<Equipment> FilterEquipList(EquipmentType equipmentType, List<Equipment> list)
    {
      return (List<Equipment>) null;
    }

    [Token(Token = "0x600CCEE")]
    [Address(RVA = "0x1BB4408", Offset = "0x1BB4408", VA = "0x1BB4408")]
    public static List<Equipment> FilterEquipList(
      EquipmentType equipmentType,
      List<Equipment> list,
      EquipmentFilterCondition filterCondition,
      bool[] filter)
    {
      return (List<Equipment>) null;
    }

    [Token(Token = "0x600CCEF")]
    [Address(RVA = "0x1BB44A0", Offset = "0x1BB44A0", VA = "0x1BB44A0")]
    private static List<Equipment> FilteringRarity(List<Equipment> list, bool[] filter)
    {
      return (List<Equipment>) null;
    }

    [Token(Token = "0x600CCF0")]
    [Address(RVA = "0x1BB48AC", Offset = "0x1BB48AC", VA = "0x1BB48AC")]
    private static List<Equipment> FilteringWeaponType(List<Equipment> list, bool[] filter)
    {
      return (List<Equipment>) null;
    }

    [Token(Token = "0x600CCF1")]
    [Address(RVA = "0x1BB4DF0", Offset = "0x1BB4DF0", VA = "0x1BB4DF0")]
    private static List<Equipment> FilteringWeaponClassification(
      List<Equipment> list,
      bool[] filter)
    {
      return (List<Equipment>) null;
    }

    [Token(Token = "0x600CCF2")]
    [Address(RVA = "0x1BB5944", Offset = "0x1BB5944", VA = "0x1BB5944")]
    private static List<Equipment> FilteringAttackType(List<Equipment> list, bool[] filter)
    {
      return (List<Equipment>) null;
    }

    [Token(Token = "0x600CCF3")]
    [Address(RVA = "0x1BB4F84", Offset = "0x1BB4F84", VA = "0x1BB4F84")]
    private static List<Equipment> FilteringAccessorieType(List<Equipment> list, bool[] filter)
    {
      return (List<Equipment>) null;
    }

    [Token(Token = "0x600CCF4")]
    [Address(RVA = "0x1BB5258", Offset = "0x1BB5258", VA = "0x1BB5258")]
    private static List<Equipment> FilteringAccessorieClassification(
      List<Equipment> list,
      bool[] filter)
    {
      return (List<Equipment>) null;
    }

    [Token(Token = "0x600CCF5")]
    [Address(RVA = "0x1BB579C", Offset = "0x1BB579C", VA = "0x1BB579C")]
    private static List<Equipment> FilteringLimitBreak(
      EquipmentType equipmentType,
      List<Equipment> list,
      bool[] filter)
    {
      return (List<Equipment>) null;
    }
  }
}
