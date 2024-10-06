// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Battle.ResultRetry.ResultRetryModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections;

#nullable disable
namespace Scenes.OutGame.Battle.ResultRetry
{
  [Token(Token = "0x20037C1")]
  public class ResultRetryModel
  {
    [Token(Token = "0x400F3B3")]
    [FieldOffset(Offset = "0x20")]
    private QuestInfo _questInfo;
    [Token(Token = "0x400F3B4")]
    [FieldOffset(Offset = "0x28")]
    private RetryQuestCtrl _retryQuest;
    [Token(Token = "0x400F3B5")]
    [FieldOffset(Offset = "0x30")]
    private NextQuestCtrl _nextQuest;
    [Token(Token = "0x400F3B6")]
    [FieldOffset(Offset = "0x38")]
    private BackToQuestSelectCtrl _backToQuestSelect;

    [Token(Token = "0x6015F16")]
    [Address(RVA = "0x232AA98", Offset = "0x232AA98", VA = "0x232AA98")]
    public ResultRetryModel(QuestTypeEnum questType, int questId)
    {
    }

    [Token(Token = "0x17004893")]
    public QuestInfo QuestInfo
    {
      [Token(Token = "0x6015F17"), Address(RVA = "0x232AB90", Offset = "0x232AB90", VA = "0x232AB90")] get
      {
        return (QuestInfo) null;
      }
    }

    [Token(Token = "0x17004894")]
    public bool CanRetry
    {
      [Token(Token = "0x6015F18"), Address(RVA = "0x232AB98", Offset = "0x232AB98", VA = "0x232AB98")] get
      {
        return new bool();
      }
      [Token(Token = "0x6015F19"), Address(RVA = "0x232ABA0", Offset = "0x232ABA0", VA = "0x232ABA0")] private set
      {
      }
    }

    [Token(Token = "0x17004895")]
    public Action RetryQuestFailedCallback
    {
      [Token(Token = "0x6015F1A"), Address(RVA = "0x232ABAC", Offset = "0x232ABAC", VA = "0x232ABAC")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6015F1B"), Address(RVA = "0x232ABB4", Offset = "0x232ABB4", VA = "0x232ABB4")] set
      {
      }
    }

    [Token(Token = "0x17004896")]
    public bool IsExistNextQuest
    {
      [Token(Token = "0x6015F1C"), Address(RVA = "0x232ABBC", Offset = "0x232ABBC", VA = "0x232ABBC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004897")]
    public bool IsReleasedNextQuest
    {
      [Token(Token = "0x6015F1D"), Address(RVA = "0x232ABE0", Offset = "0x232ABE0", VA = "0x232ABE0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004898")]
    public BattleComsumeCostTypeEnum CostType
    {
      [Token(Token = "0x6015F1E"), Address(RVA = "0x232AC14", Offset = "0x232AC14", VA = "0x232AC14")] get
      {
        return new BattleComsumeCostTypeEnum();
      }
    }

    [Token(Token = "0x17004899")]
    private bool OccupancyProcessing
    {
      [Token(Token = "0x6015F1F"), Address(RVA = "0x232AC30", Offset = "0x232AC30", VA = "0x232AC30")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6015F20")]
    [Address(RVA = "0x232AC80", Offset = "0x232AC80", VA = "0x232AC80")]
    public void OnBackToQuestSelect()
    {
    }

    [Token(Token = "0x6015F21")]
    [Address(RVA = "0x232AD20", Offset = "0x232AD20", VA = "0x232AD20")]
    public IEnumerator OnRetryQuestAsync() => (IEnumerator) null;

    [Token(Token = "0x6015F22")]
    [Address(RVA = "0x232ADB0", Offset = "0x232ADB0", VA = "0x232ADB0")]
    public void OnNextQuest()
    {
    }

    [Token(Token = "0x6015F23")]
    [Address(RVA = "0x232ADE4", Offset = "0x232ADE4", VA = "0x232ADE4")]
    public bool TryGetConsumeCost(
      out BattleComsumeCostTypeEnum costType,
      out int cost,
      out int costItemId)
    {
      return new bool();
    }

    [Token(Token = "0x6015F24")]
    [Address(RVA = "0x232ADF0", Offset = "0x232ADF0", VA = "0x232ADF0")]
    public bool TryGetNextConsumeCost(
      out BattleComsumeCostTypeEnum costType,
      out int cost,
      out int costItemId)
    {
      return new bool();
    }

    [Token(Token = "0x6015F25")]
    [Address(RVA = "0x232AE0C", Offset = "0x232AE0C", VA = "0x232AE0C")]
    public bool IsNotEnoughEp() => new bool();
  }
}
