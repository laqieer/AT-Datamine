// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.MedalShop.MedalShopUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.MedalShop
{
  [Token(Token = "0x2003B2E")]
  public static class MedalShopUtility
  {
    [Token(Token = "0x6017498")]
    [Address(RVA = "0x271CAD8", Offset = "0x271CAD8", VA = "0x271CAD8")]
    public static DateTime GetRenewalDateTimeInDaily(
      int renewalHour,
      int renewalMinute,
      int renewalSecond)
    {
      return new DateTime();
    }

    [Token(Token = "0x6017499")]
    [Address(RVA = "0x271CCA8", Offset = "0x271CCA8", VA = "0x271CCA8")]
    public static DateTime GetRenewalDateTimeInWeekly(
      DayOfWeek renewalDayOfWeek,
      int renewalHour,
      int renewalMinute,
      int renewalSecond)
    {
      return new DateTime();
    }

    [Token(Token = "0x601749A")]
    [Address(RVA = "0x271CED8", Offset = "0x271CED8", VA = "0x271CED8")]
    public static DateTime GetRenewalDateTimeInMonthly(
      int renewalDay,
      int renewalHour,
      int renewalMinute,
      int renewalSecond)
    {
      return new DateTime();
    }
  }
}
