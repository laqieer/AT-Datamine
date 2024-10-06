// Decompiled with JetBrains decompiler
// Type: StaqData.QuestInfoUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002071")]
  public static class QuestInfoUtility
  {
    [Token(Token = "0x600C43D")]
    [Address(RVA = "0x19F58AC", Offset = "0x19F58AC", VA = "0x19F58AC")]
    public static AreaQuestAreaNodeData GetAreaNodeIdByAreaNodeQuestId(int areaNodeQuestId)
    {
      return (AreaQuestAreaNodeData) null;
    }

    [Token(Token = "0x600C43E")]
    [Address(RVA = "0x19F0714", Offset = "0x19F0714", VA = "0x19F0714")]
    public static bool DecreaseLP(QuestTypeEnum questType) => new bool();

    [Token(Token = "0x600C43F")]
    [Address(RVA = "0x19F0DBC", Offset = "0x19F0DBC", VA = "0x19F0DBC")]
    public static int GetTodayClearCountInPlayData(int questId) => new int();

    [Token(Token = "0x600C440")]
    [Address(RVA = "0x19F0D20", Offset = "0x19F0D20", VA = "0x19F0D20")]
    public static int GetTotalClearCountInPlayData(int questId) => new int();

    [Token(Token = "0x600C441")]
    [Address(RVA = "0x19F0754", Offset = "0x19F0754", VA = "0x19F0754")]
    public static int GetStoryLoopCountInPlayData(QuestTypeEnum questType, int questId)
    {
      return new int();
    }

    [Token(Token = "0x600C442")]
    [Address(RVA = "0x19F0C7C", Offset = "0x19F0C7C", VA = "0x19F0C7C")]
    public static bool IsClearedInPlayData(int questId) => new bool();

    [Token(Token = "0x600C443")]
    [Address(RVA = "0x19F0BE0", Offset = "0x19F0BE0", VA = "0x19F0BE0")]
    public static bool IsReleasedByQuestClearPlayData(int releaseConditionQquestId) => new bool();

    [Token(Token = "0x600C444")]
    [Address(RVA = "0x19F3154", Offset = "0x19F3154", VA = "0x19F3154")]
    public static bool IsReleaseByPlayCommuAndPlayClearData(
      int releaseConditionQquestId,
      int targetCommunicationGroupId,
      int targetCommunicationGroupCount)
    {
      return new bool();
    }

    [Token(Token = "0x600C445")]
    [Address(RVA = "0x19F0FB0", Offset = "0x19F0FB0", VA = "0x19F0FB0")]
    public static void TryGetBaseDataByQuestMasterData(
      IStoryQuestData targetData,
      out QuestStageData questStageData,
      out IReadOnlyList<BattleRewardDescriptionData> firstClearRewards,
      out IReadOnlyList<BattleRewardDescriptionData> clearRewards,
      out IReadOnlyList<BattleMissionData> missions,
      out int numberOfClearsPerDay)
    {
    }

    [Token(Token = "0x600C446")]
    [Address(RVA = "0x19F5EE0", Offset = "0x19F5EE0", VA = "0x19F5EE0")]
    public static int? NextQuestId(QuestTypeEnum questType, int baseQuestId) => new int?();

    [Token(Token = "0x600C447")]
    [Address(RVA = "0x19F60C4", Offset = "0x19F60C4", VA = "0x19F60C4")]
    public static bool TryGetConsumeCost(
      QuestInfo questInfo,
      out BattleComsumeCostTypeEnum costType,
      out int cost,
      out int costItemId)
    {
      return new bool();
    }

    [Token(Token = "0x600C448")]
    [Address(RVA = "0x19F0B8C", Offset = "0x19F0B8C", VA = "0x19F0B8C")]
    public static bool IsReleaseConditionByQuestDifficultyType(QuestDifficultyTypeEnum diffType)
    {
      return new bool();
    }

    [Token(Token = "0x600C449")]
    [Address(RVA = "0x19F6268", Offset = "0x19F6268", VA = "0x19F6268")]
    public static bool IsEndPlayable(QuestTypeEnum questType, int questId) => new bool();
  }
}
