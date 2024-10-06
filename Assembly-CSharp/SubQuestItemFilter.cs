// Decompiled with JetBrains decompiler
// Type: SubQuestItemFilter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using System.Collections.Generic;

#nullable disable
[Token(Token = "0x20001CF")]
public static class SubQuestItemFilter
{
  [Token(Token = "0x6000BBB")]
  [Address(RVA = "0x4C7085C", Offset = "0x4C7085C", VA = "0x4C7085C")]
  public static IEnumerable<SubQuestData> WhereReceiptable(this IEnumerable<SubQuestData> list)
  {
    return (IEnumerable<SubQuestData>) null;
  }

  [Token(Token = "0x6000BBC")]
  [Address(RVA = "0x4C709F0", Offset = "0x4C709F0", VA = "0x4C709F0")]
  public static SubQuestData WhereReceiptingSingleOrDefault(this IEnumerable<SubQuestData> list)
  {
    return (SubQuestData) null;
  }

  [Token(Token = "0x6000BBD")]
  [Address(RVA = "0x4C70B04", Offset = "0x4C70B04", VA = "0x4C70B04")]
  public static IEnumerable<SubQuestData> WhereReceipting(this IEnumerable<SubQuestData> list)
  {
    return (IEnumerable<SubQuestData>) null;
  }

  [Token(Token = "0x6000BBE")]
  [Address(RVA = "0x4C70BFC", Offset = "0x4C70BFC", VA = "0x4C70BFC")]
  public static IEnumerable<SubQuestData> WhereCompleted(this IEnumerable<SubQuestData> list)
  {
    return (IEnumerable<SubQuestData>) null;
  }

  [Token(Token = "0x6000BBF")]
  [Address(RVA = "0x4C70CF4", Offset = "0x4C70CF4", VA = "0x4C70CF4")]
  public static IEnumerable<SubQuestData> WhereInTerm(this IEnumerable<SubQuestData> list)
  {
    return (IEnumerable<SubQuestData>) null;
  }

  [Token(Token = "0x6000BC0")]
  [Address(RVA = "0x4C70D68", Offset = "0x4C70D68", VA = "0x4C70D68")]
  public static IEnumerable<SubQuestData> WhereInTerm(
    this IEnumerable<SubQuestData> list,
    int calendarID)
  {
    return (IEnumerable<SubQuestData>) null;
  }

  [Token(Token = "0x6000BC1")]
  [Address(RVA = "0x4C70E44", Offset = "0x4C70E44", VA = "0x4C70E44")]
  public static IEnumerable<SubQuestData> WhereTermExpired(this IEnumerable<SubQuestData> list)
  {
    return (IEnumerable<SubQuestData>) null;
  }

  [Token(Token = "0x6000BC2")]
  [Address(RVA = "0x4C70EB8", Offset = "0x4C70EB8", VA = "0x4C70EB8")]
  public static IEnumerable<SubQuestData> WhereTermExpired(
    this IEnumerable<SubQuestData> list,
    int calendarID)
  {
    return (IEnumerable<SubQuestData>) null;
  }

  [Token(Token = "0x6000BC3")]
  [Address(RVA = "0x4C70FE0", Offset = "0x4C70FE0", VA = "0x4C70FE0")]
  public static IEnumerable<SubQuestTaskInfo> WhereInTime(this IEnumerable<SubQuestTaskInfo> list)
  {
    return (IEnumerable<SubQuestTaskInfo>) null;
  }

  [Token(Token = "0x6000BC4")]
  [Address(RVA = "0x4C710D8", Offset = "0x4C710D8", VA = "0x4C710D8")]
  public static IEnumerable<SubQuestTaskInfo> WhereInTime(
    this IEnumerable<SubQuestTaskInfo> list,
    StoryTimeSlotTypeEnum timeslot)
  {
    return (IEnumerable<SubQuestTaskInfo>) null;
  }
}
