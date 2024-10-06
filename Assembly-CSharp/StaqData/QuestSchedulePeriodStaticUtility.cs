// Decompiled with JetBrains decompiler
// Type: StaqData.QuestSchedulePeriodStaticUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x200207D")]
  public static class QuestSchedulePeriodStaticUtility
  {
    [Token(Token = "0x600C467")]
    [Address(RVA = "0x19F66CC", Offset = "0x19F66CC", VA = "0x19F66CC")]
    public static bool CheckNowSchedule(
      SchedulePeriodTypeEnum periodType,
      DateTime? scheduleStartAt,
      DateTime? scheduleEndAt)
    {
      return new bool();
    }

    [Token(Token = "0x600C468")]
    [Address(RVA = "0x19F7898", Offset = "0x19F7898", VA = "0x19F7898")]
    public static bool CheckSchedule(
      DateTime now,
      SchedulePeriodTypeEnum periodType,
      DateTime? scheduleStartAt,
      DateTime? scheduleEndAt)
    {
      return new bool();
    }

    [Token(Token = "0x600C469")]
    [Address(RVA = "0x19F78F8", Offset = "0x19F78F8", VA = "0x19F78F8")]
    private static bool GetOnlyEndPeriod(DateTime now, DateTime? endAt) => new bool();

    [Token(Token = "0x600C46A")]
    [Address(RVA = "0x19F7998", Offset = "0x19F7998", VA = "0x19F7998")]
    private static bool GetOnlyStartPeriod(DateTime now, DateTime? startAt) => new bool();

    [Token(Token = "0x600C46B")]
    [Address(RVA = "0x19F7A38", Offset = "0x19F7A38", VA = "0x19F7A38")]
    private static bool GetStartAndEndPeriod(DateTime now, DateTime? startAt, DateTime? endAt)
    {
      return new bool();
    }
  }
}
