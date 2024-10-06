// Decompiled with JetBrains decompiler
// Type: ScenarioQuest.ScoreAttack.ScoreAttackUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.UIControls;
using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace ScenarioQuest.ScoreAttack
{
  [Token(Token = "0x2000857")]
  public class ScoreAttackUtility
  {
    [Token(Token = "0x6002FFE")]
    [Address(RVA = "0x3E6F504", Offset = "0x3E6F504", VA = "0x3E6F504")]
    public static ScoreAttackEventData GetScoreAttackMasterData(int scoreAttackId)
    {
      return (ScoreAttackEventData) null;
    }

    [Token(Token = "0x6002FFF")]
    [Address(RVA = "0x3E7586C", Offset = "0x3E7586C", VA = "0x3E7586C")]
    public static ScoreAttackEventData GetScoreAttackEventDataFromQuestId(int questId)
    {
      return (ScoreAttackEventData) null;
    }

    [Token(Token = "0x6003000")]
    [Address(RVA = "0x3E71908", Offset = "0x3E71908", VA = "0x3E71908")]
    public static ScoreAttackQuestData GetQuestData(int questId) => (ScoreAttackQuestData) null;

    [Token(Token = "0x6003001")]
    [Address(RVA = "0x3E6F450", Offset = "0x3E6F450", VA = "0x3E6F450")]
    public static QuestStageData GetQuestStage(int questId) => (QuestStageData) null;

    [Token(Token = "0x6003002")]
    [Address(RVA = "0x3E7237C", Offset = "0x3E7237C", VA = "0x3E7237C")]
    public static StoryScenarioQuestData GetStoryScenarioQuestData(int scoreAttackId)
    {
      return (StoryScenarioQuestData) null;
    }

    [Token(Token = "0x6003003")]
    [Address(RVA = "0x3E71990", Offset = "0x3E71990", VA = "0x3E71990")]
    public static string GetDifficultyName(int diffId) => (string) null;

    [Token(Token = "0x6003004")]
    [Address(RVA = "0x3E75CE8", Offset = "0x3E75CE8", VA = "0x3E75CE8")]
    private static int GetScoreAttackDetailId(int scoreAttackId) => new int();

    [Token(Token = "0x6003005")]
    [Address(RVA = "0x3E71B44", Offset = "0x3E71B44", VA = "0x3E71B44")]
    public static List<DifficultyScoreData> GetDifficultyScoreGroup(int scoreAttackId)
    {
      return (List<DifficultyScoreData>) null;
    }

    [Token(Token = "0x6003006")]
    [Address(RVA = "0x3E73F64", Offset = "0x3E73F64", VA = "0x3E73F64")]
    public static DifficultyScoreData GetDifficultyScoreDataFromQuestId(int questId)
    {
      return (DifficultyScoreData) null;
    }

    [Token(Token = "0x6003007")]
    [Address(RVA = "0x3E75D14", Offset = "0x3E75D14", VA = "0x3E75D14")]
    public static bool IsOpen(int scoreAttackId) => new bool();

    [Token(Token = "0x6003008")]
    [Address(RVA = "0x3E70C94", Offset = "0x3E70C94", VA = "0x3E70C94")]
    public static void LogError(string s = "不明なエラー")
    {
    }

    [Token(Token = "0x6003009")]
    [Address(RVA = "0x3E6EF20", Offset = "0x3E6EF20", VA = "0x3E6EF20")]
    public static bool IsReleaseQuest(int questId) => new bool();

    [Token(Token = "0x600300A")]
    [Address(RVA = "0x3E75DF4", Offset = "0x3E75DF4", VA = "0x3E75DF4")]
    public static void ShowRewardIcons(
      ItemIcon itemPrefab,
      List<ScoreAttackRankingRewardData> rewards,
      AssetCachedSpawner spawner,
      int count = -1)
    {
    }

    [Token(Token = "0x600300B")]
    [Address(RVA = "0x3E75FDC", Offset = "0x3E75FDC", VA = "0x3E75FDC")]
    public static void ShowRewardIcons(
      ItemIcon itemPrefab,
      List<ScoreAttackScoreRewardData> rewards,
      AssetCachedSpawner spawner,
      int count = -1)
    {
    }

    [Token(Token = "0x600300C")]
    [Address(RVA = "0x3E6D1F4", Offset = "0x3E6D1F4", VA = "0x3E6D1F4")]
    public static void ShowRewardIcons(
      ItemIcon itemPrefab,
      List<Network.Param.Reward> rewards,
      AssetCachedSpawner spawner,
      Transform transform)
    {
    }

    [Token(Token = "0x600300D")]
    [Address(RVA = "0x3E76124", Offset = "0x3E76124", VA = "0x3E76124")]
    public static void PlayBGM()
    {
    }

    [Token(Token = "0x600300E")]
    [Address(RVA = "0x3E75F48", Offset = "0x3E75F48", VA = "0x3E75F48")]
    private static IEnumerator ShowRewardIcon(
      ItemIcon itemPrefab,
      Reward reward,
      AssetCachedSpawner spawner,
      Transform transform = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600300F")]
    [Address(RVA = "0x3E762F4", Offset = "0x3E762F4", VA = "0x3E762F4")]
    public ScoreAttackUtility()
    {
    }
  }
}
