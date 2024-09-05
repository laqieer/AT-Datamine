// Decompiled with JetBrains decompiler
// Type: StaqData.Sort.ItemFilterUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace StaqData.Sort
{
  [Token(Token = "0x200218F")]
  public static class ItemFilterUtility
  {
    [Token(Token = "0x600CD6B")]
    [Address(RVA = "0x4B59B4C", Offset = "0x4B59B4C", VA = "0x4B59B4C")]
    public static bool IsAnyFiltered() => new bool();

    [Token(Token = "0x600CD6C")]
    [Address(RVA = "0x4B59BD4", Offset = "0x4B59BD4", VA = "0x4B59BD4")]
    public static List<Item> FilterItemList(List<Item> list) => (List<Item>) null;

    [Token(Token = "0x600CD6D")]
    [Address(RVA = "0x4B59D58", Offset = "0x4B59D58", VA = "0x4B59D58")]
    public static List<Item> FilterItemList(
      List<Item> list,
      ItemFilterCondition filterCondition,
      bool[] filter)
    {
      return (List<Item>) null;
    }

    [Token(Token = "0x600CD6E")]
    [Address(RVA = "0x4B59D68", Offset = "0x4B59D68", VA = "0x4B59D68")]
    private static List<Item> FilterByItemFilterType(List<Item> list, bool[] filter)
    {
      return (List<Item>) null;
    }

    [Token(Token = "0x600CD6F")]
    [Address(RVA = "0x4B5A000", Offset = "0x4B5A000", VA = "0x4B5A000")]
    private static bool IsEqual(ItemFilterType ItemFilterType, ItemTypeEnum itemType) => new bool();
  }
}
