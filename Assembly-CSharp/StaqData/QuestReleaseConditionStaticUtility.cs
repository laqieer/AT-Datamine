// Decompiled with JetBrains decompiler
// Type: StaqData.QuestReleaseConditionStaticUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002079")]
  public static class QuestReleaseConditionStaticUtility
  {
    [Token(Token = "0x600C45C")]
    [Address(RVA = "0x19F690C", Offset = "0x19F690C", VA = "0x19F690C")]
    public static bool IsClearAreaGroupReleaseCondition(
      int areaGroupReleaseConditionId,
      Func<int, bool> clearedAreaNodeIdCheck,
      Func<int, int> storyChapterLoopNum)
    {
      return new bool();
    }

    [Token(Token = "0x600C45D")]
    [Address(RVA = "0x19F72D0", Offset = "0x19F72D0", VA = "0x19F72D0")]
    public static bool IsClearAreaReleaseCondition(
      int areaReleaseConditionId,
      Func<int, bool> clearedAreaNodeIdCheck,
      Func<int, int> storyChapterLoopNum)
    {
      return new bool();
    }

    [Token(Token = "0x600C45E")]
    [Address(RVA = "0x19F74D8", Offset = "0x19F74D8", VA = "0x19F74D8")]
    public static bool IsClearAreaNodeReleaseCondition(
      int areaNodeReleaseConditionId,
      Func<int, bool> clearedAreaNodeIdCheck,
      Func<int, int> storyChapterLoopNum)
    {
      return new bool();
    }

    [Token(Token = "0x600C45F")]
    [Address(RVA = "0x19F76E0", Offset = "0x19F76E0", VA = "0x19F76E0")]
    public static bool IsStoryMainHardSelectCondition(
      Func<int, bool> clearedAreaNodeIdCheck,
      Func<int, int> storyChapterLoopNum)
    {
      return new bool();
    }

    [Token(Token = "0x600C460")]
    [Address(RVA = "0x19F6B14", Offset = "0x19F6B14", VA = "0x19F6B14")]
    private static bool IsClearAreaQuestReleaseCondition(
      IEnumerable<IQuestReleaseConditionDescriptionData> conds,
      Func<int, bool> clearedAreaNodeIdCheck,
      Func<int, int> storyChapterLoopNum)
    {
      return new bool();
    }
  }
}
