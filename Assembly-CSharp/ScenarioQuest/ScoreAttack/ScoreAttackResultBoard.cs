// Decompiled with JetBrains decompiler
// Type: ScenarioQuest.ScoreAttack.ScoreAttackResultBoard
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.ScoreAttack;
using Il2CppDummyDll;
using Network.Param;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

#nullable disable
namespace ScenarioQuest.ScoreAttack
{
  [Token(Token = "0x2000848")]
  public class ScoreAttackResultBoard : MonoBehaviour
  {
    [Token(Token = "0x4002769")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextMeshProUGUI difficultyText;
    [Token(Token = "0x400276A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI difficultyScoreText;
    [Token(Token = "0x400276B")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private TextMeshProUGUI killPointText;
    [Token(Token = "0x400276C")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TextMeshProUGUI killCountText;
    [Token(Token = "0x400276D")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TextMeshProUGUI maxDamageText;
    [Token(Token = "0x400276E")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private TextMeshProUGUI surviveUnitsCountText;
    [Token(Token = "0x400276F")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private TextMeshProUGUI turnText;
    [Token(Token = "0x4002770")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private TextMeshProUGUI finalScoreText;
    [Token(Token = "0x4002771")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private TextMeshProUGUI remainHpScoreText;
    [Token(Token = "0x4002772")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private TextMeshProUGUI totalDealDamageText;
    [Token(Token = "0x4002773")]
    [FieldOffset(Offset = "0x68")]
    private Dictionary<Result.ScoreType, int> scoreDictionary;
    [Token(Token = "0x4002774")]
    [FieldOffset(Offset = "0x70")]
    private PlayerScoreAttackResultScoreType _scoreData;
    [Token(Token = "0x4002775")]
    [FieldOffset(Offset = "0x78")]
    private ScoreAttackResultTimeLine _resultTimeLine;

    [Token(Token = "0x6002FA9")]
    [Address(RVA = "0x3E7354C", Offset = "0x3E7354C", VA = "0x3E7354C")]
    public void Initialize(
      PlayerScoreAttackResultScoreType scoreData,
      ScoreAttackResultTimeLine timeLine)
    {
    }

    [Token(Token = "0x6002FAA")]
    [Address(RVA = "0x3E73814", Offset = "0x3E73814", VA = "0x3E73814")]
    public void Initialize(PlayerScoreAttackResultScoreType scoreData)
    {
    }

    [Token(Token = "0x6002FAB")]
    [Address(RVA = "0x3E73A64", Offset = "0x3E73A64", VA = "0x3E73A64")]
    public IEnumerator StartEffect(bool isHighScore) => (IEnumerator) null;

    [Token(Token = "0x6002FAC")]
    [Address(RVA = "0x3E73B08", Offset = "0x3E73B08", VA = "0x3E73B08")]
    private IEnumerator StartCountup(TextMeshProUGUI text, int score, float time)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6002FAD")]
    [Address(RVA = "0x3E73BB8", Offset = "0x3E73BB8", VA = "0x3E73BB8")]
    private void PlayLoopCountUpSe()
    {
    }

    [Token(Token = "0x6002FAE")]
    [Address(RVA = "0x3E73C4C", Offset = "0x3E73C4C", VA = "0x3E73C4C")]
    private void PlayLoopFinalCountUpSe()
    {
    }

    [Token(Token = "0x6002FAF")]
    [Address(RVA = "0x3E73CE0", Offset = "0x3E73CE0", VA = "0x3E73CE0")]
    private void StopLoopCountUpSe()
    {
    }

    [Token(Token = "0x6002FB0")]
    [Address(RVA = "0x3E73D74", Offset = "0x3E73D74", VA = "0x3E73D74")]
    private void PlayFinalCountUpSe()
    {
    }

    [Token(Token = "0x6002FB1")]
    [Address(RVA = "0x3E73E08", Offset = "0x3E73E08", VA = "0x3E73E08")]
    private void PlayHighScoreSe()
    {
    }

    [Token(Token = "0x6002FB2")]
    [Address(RVA = "0x3E736A0", Offset = "0x3E736A0", VA = "0x3E736A0")]
    private void Clear(int questId)
    {
    }

    [Token(Token = "0x6002FB3")]
    [Address(RVA = "0x3E73E9C", Offset = "0x3E73E9C", VA = "0x3E73E9C")]
    private TextMeshProUGUI GetTextObj(Result.ScoreType type) => (TextMeshProUGUI) null;

    [Token(Token = "0x6002FB4")]
    [Address(RVA = "0x3E73F04", Offset = "0x3E73F04", VA = "0x3E73F04")]
    private void NextIn()
    {
    }

    [Token(Token = "0x6002FB5")]
    [Address(RVA = "0x3E73F34", Offset = "0x3E73F34", VA = "0x3E73F34")]
    private void HighScoreIn()
    {
    }

    [Token(Token = "0x6002FB6")]
    [Address(RVA = "0x3E739EC", Offset = "0x3E739EC", VA = "0x3E739EC")]
    private (int, int) GetKillPointScore(int questId, int score) => ();

    [Token(Token = "0x6002FB7")]
    [Address(RVA = "0x3E74058", Offset = "0x3E74058", VA = "0x3E74058")]
    public ScoreAttackResultBoard()
    {
    }
  }
}
