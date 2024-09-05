// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Battle.ResultCommon.BattleResultQuestTitle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using TMPro;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Battle.ResultCommon
{
  [Token(Token = "0x20037E7")]
  public class BattleResultQuestTitle : MonoBehaviour
  {
    [Token(Token = "0x400F447")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextMeshProUGUI _questTitleText;
    [Token(Token = "0x400F448")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject difficultyRoot;
    [Token(Token = "0x400F449")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject difficultyHard;
    [Token(Token = "0x400F44A")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject difficultyVeryHard;

    [Token(Token = "0x6015FE0")]
    [Address(RVA = "0x232FDE8", Offset = "0x232FDE8", VA = "0x232FDE8")]
    public void Initialize(BattleResultSubScene.Parameter parameter)
    {
    }

    [Token(Token = "0x6015FE1")]
    [Address(RVA = "0x232FE24", Offset = "0x232FE24", VA = "0x232FE24")]
    public void Initialize(QuestTypeEnum questType, int questID)
    {
    }

    [Token(Token = "0x6015FE2")]
    [Address(RVA = "0x232EF5C", Offset = "0x232EF5C", VA = "0x232EF5C")]
    public void Initialize(QuestInfo quest)
    {
    }

    [Token(Token = "0x6015FE3")]
    [Address(RVA = "0x232FE5C", Offset = "0x232FE5C", VA = "0x232FE5C")]
    private void SetDifficulty(QuestInfo questInfo)
    {
    }

    [Token(Token = "0x6015FE4")]
    [Address(RVA = "0x232FF30", Offset = "0x232FF30", VA = "0x232FF30")]
    public BattleResultQuestTitle()
    {
    }
  }
}
