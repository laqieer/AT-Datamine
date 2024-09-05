// Decompiled with JetBrains decompiler
// Type: ScenarioQuest.ScoreAttack.ScoreAttackResultView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using Network.Param;
using Scenes.OutGame;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace ScenarioQuest.ScoreAttack
{
  [Token(Token = "0x200084D")]
  public class ScoreAttackResultView : MonoBehaviour
  {
    [Token(Token = "0x4002786")]
    [FieldOffset(Offset = "0x18")]
    [Header("タイムライン")]
    [SerializeField]
    private UITimelineController timeline;
    [Token(Token = "0x4002787")]
    [FieldOffset(Offset = "0x20")]
    [Header("スタイル画像")]
    [Space(5f)]
    [SerializeField]
    private StyleImage styleUI;
    [Token(Token = "0x4002788")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    [Header("ボタン")]
    private CommonButton buttonBack;
    [Token(Token = "0x4002789")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private CommonButton buttonTapNext;
    [Token(Token = "0x400278A")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    [Space(5f)]
    [Header("スコアボード")]
    private ScoreAttackResultBoard boardUI;
    [Token(Token = "0x400278B")]
    [FieldOffset(Offset = "0x40")]
    private ScoreAttackResultTimeLine _resultTimeLine;
    [Token(Token = "0x400278C")]
    [FieldOffset(Offset = "0x48")]
    private AssetCachedSpawner _spawner;

    [Token(Token = "0x6002FCE")]
    [Address(RVA = "0x3E74BC0", Offset = "0x3E74BC0", VA = "0x3E74BC0")]
    public void Initialize(
      ScoreAttackBattleResultSubScene.Parameter parameter,
      PlayerScoreAttackResultScoreType scoreData)
    {
    }

    [Token(Token = "0x6002FCF")]
    [Address(RVA = "0x3E750AC", Offset = "0x3E750AC", VA = "0x3E750AC")]
    public void Initialize(PlayerScoreAttackResultScoreType scoreData, int styleId)
    {
    }

    [Token(Token = "0x6002FD0")]
    [Address(RVA = "0x3E74D10", Offset = "0x3E74D10", VA = "0x3E74D10")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6002FD1")]
    [Address(RVA = "0x3E75278", Offset = "0x3E75278", VA = "0x3E75278")]
    public IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6002FD2")]
    [Address(RVA = "0x3E75308", Offset = "0x3E75308", VA = "0x3E75308")]
    public IEnumerator StartCountUpEffect(bool isHighScore) => (IEnumerator) null;

    [Token(Token = "0x6002FD3")]
    [Address(RVA = "0x3E753AC", Offset = "0x3E753AC", VA = "0x3E753AC")]
    public bool CheckInitialized() => new bool();

    [Token(Token = "0x6002FD4")]
    [Address(RVA = "0x3E753C8", Offset = "0x3E753C8", VA = "0x3E753C8")]
    public bool CheckTimeLineEnd() => new bool();

    [Token(Token = "0x6002FD5")]
    [Address(RVA = "0x3E753E4", Offset = "0x3E753E4", VA = "0x3E753E4")]
    public void TimelineIn()
    {
    }

    [Token(Token = "0x6002FD6")]
    [Address(RVA = "0x3E75408", Offset = "0x3E75408", VA = "0x3E75408")]
    public void TimelineOut()
    {
    }

    [Token(Token = "0x6002FD7")]
    [Address(RVA = "0x3E7542C", Offset = "0x3E7542C", VA = "0x3E7542C")]
    public void OpenRewardScoreReward(
      List<Network.Param.Reward> rewards,
      BaseScoreAttackRewardReceivePopup.RewardType type,
      Action closeAction = null)
    {
    }

    [Token(Token = "0x6002FD8")]
    [Address(RVA = "0x3E755EC", Offset = "0x3E755EC", VA = "0x3E755EC")]
    public void SetStyleImage()
    {
    }

    [Token(Token = "0x6002FD9")]
    [Address(RVA = "0x3E755D0", Offset = "0x3E755D0", VA = "0x3E755D0")]
    public void StartSpawnerRequest()
    {
    }

    [Token(Token = "0x6002FDA")]
    [Address(RVA = "0x3E75640", Offset = "0x3E75640", VA = "0x3E75640")]
    public IEnumerator WaitSpawnerRequest() => (IEnumerator) null;

    [Token(Token = "0x6002FDB")]
    [Address(RVA = "0x3E751EC", Offset = "0x3E751EC", VA = "0x3E751EC")]
    private void CreateSpawner()
    {
    }

    [Token(Token = "0x6002FDC")]
    [Address(RVA = "0x3E756D0", Offset = "0x3E756D0", VA = "0x3E756D0")]
    private void Back(int questId)
    {
    }

    [Token(Token = "0x6002FDD")]
    [Address(RVA = "0x3E74D7C", Offset = "0x3E74D7C", VA = "0x3E74D7C")]
    private int GetRandomStyleId(
      ScoreAttackBattleResultSubScene.Parameter parameter)
    {
      return new int();
    }

    [Token(Token = "0x6002FDE")]
    [Address(RVA = "0x3E757DC", Offset = "0x3E757DC", VA = "0x3E757DC")]
    public ScoreAttackResultView()
    {
    }
  }
}
