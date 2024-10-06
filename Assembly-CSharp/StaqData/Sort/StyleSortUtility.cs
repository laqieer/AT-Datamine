// Decompiled with JetBrains decompiler
// Type: StaqData.Sort.StyleSortUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace StaqData.Sort
{
  [Token(Token = "0x20021AB")]
  public static class StyleSortUtility
  {
    [Token(Token = "0x600CDB4")]
    [Address(RVA = "0x4B5ED84", Offset = "0x4B5ED84", VA = "0x4B5ED84")]
    public static StyleSortCondition GetCurrentSortCondition() => new StyleSortCondition();

    [Token(Token = "0x600CDB5")]
    [Address(RVA = "0x4B5EE0C", Offset = "0x4B5EE0C", VA = "0x4B5EE0C")]
    public static string GetCurrenttLocalizedSorText() => (string) null;

    [Token(Token = "0x600CDB6")]
    [Address(RVA = "0x4B5EE1C", Offset = "0x4B5EE1C", VA = "0x4B5EE1C")]
    public static EquipmentSortCondition GetCurrentSortCondition(EquipmentType equipmentType)
    {
      return new EquipmentSortCondition();
    }

    [Token(Token = "0x600CDB7")]
    [Address(RVA = "0x4B5EF04", Offset = "0x4B5EF04", VA = "0x4B5EF04")]
    public static string GetCurrenttLocalizedSorText(EquipmentType equipmentType) => (string) null;

    [Token(Token = "0x600CDB8")]
    [Address(RVA = "0x4B5EF18", Offset = "0x4B5EF18", VA = "0x4B5EF18")]
    public static List<Style> SortStyleList(List<Style> list, List<int> organizationList)
    {
      return (List<Style>) null;
    }

    [Token(Token = "0x600CDB9")]
    [Address(RVA = "0x4B5EFCC", Offset = "0x4B5EFCC", VA = "0x4B5EFCC")]
    public static List<Style> SortStyleList(
      List<Style> list,
      StyleSortCondition condition,
      StyleSortOrder order,
      bool isEquip,
      List<int> organizationList)
    {
      return (List<Style>) null;
    }

    [Token(Token = "0x600CDBA")]
    private static IOrderedEnumerable<Style> OrderBy<T>(
      this List<Style> source,
      StyleSortOrder order,
      Func<Style, T> selector)
    {
      return (IOrderedEnumerable<Style>) null;
    }

    [Token(Token = "0x600CDBB")]
    private static IOrderedEnumerable<Style> ThenBy<T>(
      this IOrderedEnumerable<Style> source,
      StyleSortOrder order,
      Func<Style, T> selector)
    {
      return (IOrderedEnumerable<Style>) null;
    }

    [Token(Token = "0x600CDBC")]
    [Address(RVA = "0x4B5F134", Offset = "0x4B5F134", VA = "0x4B5F134")]
    private static IOrderedEnumerable<Style> ThenByCondition(
      this IOrderedEnumerable<Style> tmpSorted,
      StyleSortCondition condition,
      StyleSortOrder order)
    {
      return (IOrderedEnumerable<Style>) null;
    }
  }
}
