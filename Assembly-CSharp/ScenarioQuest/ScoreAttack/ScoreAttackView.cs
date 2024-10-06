// Decompiled with JetBrains decompiler
// Type: ScenarioQuest.ScoreAttack.ScoreAttackView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using Network.API;
using System;
using System.Collections;
using UI.Direction;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace ScenarioQuest.ScoreAttack
{
  [Token(Token = "0x2000860")]
  public class ScoreAttackView : MonoBehaviour
  {
    [Token(Token = "0x40027B6")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [Header("タイムライン")]
    private UITimelineController timeline;
    [Token(Token = "0x40027B7")]
    [FieldOffset(Offset = "0x20")]
    [Header("ハイスコアランキング")]
    [SerializeField]
    private HighScoreRanking hightScoreRanking;
    [Token(Token = "0x40027B8")]
    [FieldOffset(Offset = "0x28")]
    [Space(5f)]
    [Header("クエスト選択")]
    [SerializeField]
    private ScoreAttackQuestView questView;
    [Token(Token = "0x40027B9")]
    [FieldOffset(Offset = "0x30")]
    [Header("スコア報酬")]
    [Space(5f)]
    [SerializeField]
    private ScoreReward scoreReward;
    [Token(Token = "0x40027BA")]
    [FieldOffset(Offset = "0x38")]
    [Header("トップUI")]
    [SerializeField]
    [Space(5f)]
    private TopUI topUI;
    [Token(Token = "0x40027BB")]
    [FieldOffset(Offset = "0x40")]
    [Header("スタイル画像")]
    [Space(5f)]
    [SerializeField]
    private StyleImage styleUI;
    [Token(Token = "0x40027BC")]
    [FieldOffset(Offset = "0x48")]
    [Space(5f)]
    [SerializeField]
    [Header("クエスト開始ボタン")]
    private QuestStartButton startButton;
    [Token(Token = "0x40027BD")]
    [FieldOffset(Offset = "0x50")]
    private AssetCachedSpawner _spawner;
    [Token(Token = "0x40027BE")]
    [FieldOffset(Offset = "0x58")]
    private ScoreAttackTopTimeLine _topTimeLine;

    [Token(Token = "0x6003024")]
    [Address(RVA = "0x3E76738", Offset = "0x3E76738", VA = "0x3E76738")]
    public void Initialize(int scoreAttackId, int questId)
    {
    }

    [Token(Token = "0x6003025")]
    [Address(RVA = "0x3E76990", Offset = "0x3E76990", VA = "0x3E76990")]
    public IEnumerator InitializeAsync(APIScoreAttackResponse response, int scoreAttackId)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6003026")]
    [Address(RVA = "0x3E76A38", Offset = "0x3E76A38", VA = "0x3E76A38")]
    public void CreateHighScoreRanking(APIScoreAttackResponse response, int scoreAttackId)
    {
    }

    [Token(Token = "0x6003027")]
    [Address(RVA = "0x3E76A50", Offset = "0x3E76A50", VA = "0x3E76A50")]
    public void CreateScoreReward(APIScoreAttackResponse response)
    {
    }

    [Token(Token = "0x6003028")]
    [Address(RVA = "0x3E76C60", Offset = "0x3E76C60", VA = "0x3E76C60")]
    public void StartSpawnerRequest()
    {
    }

    [Token(Token = "0x6003029")]
    [Address(RVA = "0x3E76C7C", Offset = "0x3E76C7C", VA = "0x3E76C7C")]
    public IEnumerator WaitSpawnerRequest() => (IEnumerator) null;

    [Token(Token = "0x600302A")]
    [Address(RVA = "0x3E76D0C", Offset = "0x3E76D0C", VA = "0x3E76D0C")]
    public void SetImage()
    {
    }

    [Token(Token = "0x600302B")]
    [Address(RVA = "0x3E76D50", Offset = "0x3E76D50", VA = "0x3E76D50")]
    public void SetRuleButtonAction(UnityAction action)
    {
    }

    [Token(Token = "0x600302C")]
    [Address(RVA = "0x3E76DB8", Offset = "0x3E76DB8", VA = "0x3E76DB8")]
    public void SetHowToButtonAction(UnityAction action)
    {
    }

    [Token(Token = "0x600302D")]
    [Address(RVA = "0x3E76E20", Offset = "0x3E76E20", VA = "0x3E76E20")]
    public void GetStartButtonApNumActon(Func<int> action)
    {
    }

    [Token(Token = "0x600302E")]
    [Address(RVA = "0x3E76E38", Offset = "0x3E76E38", VA = "0x3E76E38")]
    public void OnChangeQuest(int questId)
    {
    }

    [Token(Token = "0x600302F")]
    [Address(RVA = "0x3E76E54", Offset = "0x3E76E54", VA = "0x3E76E54")]
    public void SetPlayButtonAction(UnityAction action)
    {
    }

    [Token(Token = "0x6003030")]
    [Address(RVA = "0x3E76E6C", Offset = "0x3E76E6C", VA = "0x3E76E6C")]
    public void SetBackButtonAction(UnityAction action)
    {
    }

    [Token(Token = "0x6003031")]
    [Address(RVA = "0x3E76ED4", Offset = "0x3E76ED4", VA = "0x3E76ED4")]
    public int ChangeQuest() => new int();

    [Token(Token = "0x6003032")]
    [Address(RVA = "0x3E76F0C", Offset = "0x3E76F0C", VA = "0x3E76F0C")]
    public bool CheckInitialized() => new bool();

    [Token(Token = "0x6003033")]
    [Address(RVA = "0x3E76F28", Offset = "0x3E76F28", VA = "0x3E76F28")]
    public bool CheckTimeLineEnd() => new bool();

    [Token(Token = "0x6003034")]
    [Address(RVA = "0x3E76F44", Offset = "0x3E76F44", VA = "0x3E76F44")]
    public void TimelineIn()
    {
    }

    [Token(Token = "0x6003035")]
    [Address(RVA = "0x3E76F68", Offset = "0x3E76F68", VA = "0x3E76F68")]
    public void TimelineOut()
    {
    }

    [Token(Token = "0x6003036")]
    [Address(RVA = "0x3E76880", Offset = "0x3E76880", VA = "0x3E76880")]
    private void CreateSpawner()
    {
    }

    [Token(Token = "0x6003037")]
    [Address(RVA = "0x3E76F8C", Offset = "0x3E76F8C", VA = "0x3E76F8C")]
    public ScoreAttackView()
    {
    }
  }
}
