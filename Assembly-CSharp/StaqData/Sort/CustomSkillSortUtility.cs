// Decompiled with JetBrains decompiler
// Type: StaqData.Sort.CustomSkillSortUtility
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
  [Token(Token = "0x2002175")]
  public static class CustomSkillSortUtility
  {
    [Token(Token = "0x600CCD4")]
    [Address(RVA = "0x1BB3100", Offset = "0x1BB3100", VA = "0x1BB3100")]
    public static CustomSkillSortCondition GetCurrentSortCondition()
    {
      return new CustomSkillSortCondition();
    }

    [Token(Token = "0x600CCD5")]
    [Address(RVA = "0x1BB3188", Offset = "0x1BB3188", VA = "0x1BB3188")]
    public static string GetCurrenttLocalizedSorText() => (string) null;

    [Token(Token = "0x600CCD6")]
    [Address(RVA = "0x1BB3198", Offset = "0x1BB3198", VA = "0x1BB3198")]
    public static List<CustomSkill> SortCustomSkillList(List<CustomSkill> list)
    {
      return (List<CustomSkill>) null;
    }

    [Token(Token = "0x600CCD7")]
    [Address(RVA = "0x1BB33A0", Offset = "0x1BB33A0", VA = "0x1BB33A0")]
    public static List<CustomSkill> SortCustomSkillList(
      List<CustomSkill> list,
      List<UniqueID> equipList)
    {
      return (List<CustomSkill>) null;
    }

    [Token(Token = "0x600CCD8")]
    [Address(RVA = "0x1BB3454", Offset = "0x1BB3454", VA = "0x1BB3454")]
    public static List<CustomSkill> SortCustomSkillList(
      List<CustomSkill> list,
      CustomSkillSortCondition condition,
      CustomSkillSortOrder order,
      bool isEquip,
      List<UniqueID> equipList)
    {
      return (List<CustomSkill>) null;
    }

    [Token(Token = "0x600CCD9")]
    private static IOrderedEnumerable<CustomSkill> OrderBy<T>(
      this List<CustomSkill> source,
      CustomSkillSortOrder order,
      Func<CustomSkill, T> selector)
    {
      return (IOrderedEnumerable<CustomSkill>) null;
    }

    [Token(Token = "0x600CCDA")]
    private static IOrderedEnumerable<CustomSkill> ThenBy<T>(
      this IOrderedEnumerable<CustomSkill> source,
      CustomSkillSortOrder order,
      Func<CustomSkill, T> selector)
    {
      return (IOrderedEnumerable<CustomSkill>) null;
    }

    [Token(Token = "0x600CCDB")]
    [Address(RVA = "0x1BB35A0", Offset = "0x1BB35A0", VA = "0x1BB35A0")]
    private static IOrderedEnumerable<CustomSkill> ThenByCondition(
      this IOrderedEnumerable<CustomSkill> tmpSorted,
      CustomSkillSortCondition condition,
      CustomSkillSortOrder order)
    {
      return (IOrderedEnumerable<CustomSkill>) null;
    }
  }
}
