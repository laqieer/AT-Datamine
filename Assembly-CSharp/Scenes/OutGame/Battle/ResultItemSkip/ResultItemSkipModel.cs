// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Battle.ResultItemSkip.ResultItemSkipModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using System.Collections.Generic;

#nullable disable
namespace Scenes.OutGame.Battle.ResultItemSkip
{
  [Token(Token = "0x20037D9")]
  public class ResultItemSkipModel
  {
    [Token(Token = "0x6015F9C")]
    [Address(RVA = "0x232DE6C", Offset = "0x232DE6C", VA = "0x232DE6C")]
    public static ResultItemSkipModel FromResultData(
      BattleResultSubScene.Parameter parameter,
      ResultData resultData,
      bool[] missionClear)
    {
      return (ResultItemSkipModel) null;
    }

    [Token(Token = "0x6015F9D")]
    [Address(RVA = "0x232E5C8", Offset = "0x232E5C8", VA = "0x232E5C8")]
    public ResultItemSkipModel(
      QuestInfo questInfo,
      bool[] missionClear,
      List<SkipRewardModel> rewards,
      List<ResultData.ItemData> unreceivedRewards)
    {
    }

    [Token(Token = "0x170048B0")]
    public QuestInfo QuestInfo
    {
      [Token(Token = "0x6015F9E"), Address(RVA = "0x232E608", Offset = "0x232E608", VA = "0x232E608")] get
      {
        return (QuestInfo) null;
      }
      [Token(Token = "0x6015F9F"), Address(RVA = "0x232E610", Offset = "0x232E610", VA = "0x232E610")] private set
      {
      }
    }

    [Token(Token = "0x170048B1")]
    public bool[] MissionClear
    {
      [Token(Token = "0x6015FA0"), Address(RVA = "0x232E618", Offset = "0x232E618", VA = "0x232E618")] get
      {
        return (bool[]) null;
      }
      [Token(Token = "0x6015FA1"), Address(RVA = "0x232E620", Offset = "0x232E620", VA = "0x232E620")] private set
      {
      }
    }

    [Token(Token = "0x170048B2")]
    public List<SkipRewardModel> SkipRewards
    {
      [Token(Token = "0x6015FA2"), Address(RVA = "0x232E628", Offset = "0x232E628", VA = "0x232E628")] get
      {
        return (List<SkipRewardModel>) null;
      }
      [Token(Token = "0x6015FA3"), Address(RVA = "0x232E630", Offset = "0x232E630", VA = "0x232E630")] private set
      {
      }
    }

    [Token(Token = "0x170048B3")]
    public List<ResultData.ItemData> UnreceivedRewards
    {
      [Token(Token = "0x6015FA4"), Address(RVA = "0x232E638", Offset = "0x232E638", VA = "0x232E638")] get
      {
        return (List<ResultData.ItemData>) null;
      }
      [Token(Token = "0x6015FA5"), Address(RVA = "0x232E640", Offset = "0x232E640", VA = "0x232E640")] private set
      {
      }
    }

    [Token(Token = "0x6015FA6")]
    [Address(RVA = "0x232CE30", Offset = "0x232CE30", VA = "0x232CE30")]
    public SkipRewardModel TotalReward() => (SkipRewardModel) null;

    [Token(Token = "0x6015FA7")]
    [Address(RVA = "0x232E8FC", Offset = "0x232E8FC", VA = "0x232E8FC")]
    public void OnClickNext()
    {
    }
  }
}
