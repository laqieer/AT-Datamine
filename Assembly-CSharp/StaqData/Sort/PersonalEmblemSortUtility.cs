// Decompiled with JetBrains decompiler
// Type: StaqData.Sort.PersonalEmblemSortUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.PlayerInfo.PlayerProfile;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace StaqData.Sort
{
  [Token(Token = "0x2002197")]
  public static class PersonalEmblemSortUtility
  {
    [Token(Token = "0x600CD7F")]
    [Address(RVA = "0x4B5AE48", Offset = "0x4B5AE48", VA = "0x4B5AE48")]
    public static PersonalEmblemSortUtility.PersonalEmblemSortCondition GetCurrentSortCondition()
    {
      return new PersonalEmblemSortUtility.PersonalEmblemSortCondition();
    }

    [Token(Token = "0x600CD80")]
    [Address(RVA = "0x4B5AED0", Offset = "0x4B5AED0", VA = "0x4B5AED0")]
    public static string GetCurrenttLocalizedSorText() => (string) null;

    [Token(Token = "0x600CD81")]
    [Address(RVA = "0x4B5AEE0", Offset = "0x4B5AEE0", VA = "0x4B5AEE0")]
    public static List<PersonalEmblemListItem.PersonalEmblemInfo> SortPersonalEmblemList(
      List<PersonalEmblemListItem.PersonalEmblemInfo> list,
      int setEmblemId)
    {
      return (List<PersonalEmblemListItem.PersonalEmblemInfo>) null;
    }

    [Token(Token = "0x600CD82")]
    [Address(RVA = "0x4B5AF84", Offset = "0x4B5AF84", VA = "0x4B5AF84")]
    public static List<PersonalEmblemListItem.PersonalEmblemInfo> SortPersonalEmblemList(
      List<PersonalEmblemListItem.PersonalEmblemInfo> list,
      PersonalEmblemSortUtility.PersonalEmblemSortCondition condition,
      PersonalEmblemSortUtility.PersonalEmblemSortOrder order,
      bool isEquip,
      int setEmblemId)
    {
      return (List<PersonalEmblemListItem.PersonalEmblemInfo>) null;
    }

    [Token(Token = "0x600CD83")]
    private static IOrderedEnumerable<PersonalEmblemListItem.PersonalEmblemInfo> OrderBy<T>(
      this List<PersonalEmblemListItem.PersonalEmblemInfo> source,
      PersonalEmblemSortUtility.PersonalEmblemSortOrder order,
      Func<PersonalEmblemListItem.PersonalEmblemInfo, T> selector)
    {
      return (IOrderedEnumerable<PersonalEmblemListItem.PersonalEmblemInfo>) null;
    }

    [Token(Token = "0x600CD84")]
    private static IOrderedEnumerable<PersonalEmblemListItem.PersonalEmblemInfo> ThenBy<T>(
      this IOrderedEnumerable<PersonalEmblemListItem.PersonalEmblemInfo> source,
      PersonalEmblemSortUtility.PersonalEmblemSortOrder order,
      Func<PersonalEmblemListItem.PersonalEmblemInfo, T> selector)
    {
      return (IOrderedEnumerable<PersonalEmblemListItem.PersonalEmblemInfo>) null;
    }

    [Token(Token = "0x600CD85")]
    [Address(RVA = "0x4B5B060", Offset = "0x4B5B060", VA = "0x4B5B060")]
    private static IOrderedEnumerable<PersonalEmblemListItem.PersonalEmblemInfo> ThenByCondition(
      this IOrderedEnumerable<PersonalEmblemListItem.PersonalEmblemInfo> tmpSorted,
      PersonalEmblemSortUtility.PersonalEmblemSortCondition condition,
      PersonalEmblemSortUtility.PersonalEmblemSortOrder order)
    {
      return (IOrderedEnumerable<PersonalEmblemListItem.PersonalEmblemInfo>) null;
    }

    [Token(Token = "0x2002198")]
    public enum PersonalEmblemSortCondition
    {
      [Token(Token = "0x4008E7D")] Id,
      [Token(Token = "0x4008E7E")] CreatedAt,
      [Token(Token = "0x4008E7F")] Rarity,
    }

    [Token(Token = "0x2002199")]
    public enum PersonalEmblemSortOrder
    {
      [Token(Token = "0x4008E81")] Ascend,
      [Token(Token = "0x4008E82")] Descend,
    }
  }
}
