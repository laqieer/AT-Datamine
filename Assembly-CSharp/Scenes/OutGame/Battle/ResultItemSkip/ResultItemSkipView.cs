// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Battle.ResultItemSkip.ResultItemSkipView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.Battle.ResultCommon;
using StaqData;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Scenes.OutGame.Battle.ResultItemSkip
{
  [Token(Token = "0x20037DE")]
  public class ResultItemSkipView : MonoBehaviour
  {
    [Token(Token = "0x400F425")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private MissionClearMarks _missionClearMarks;
    [Token(Token = "0x400F426")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private BattleResultQuestTitle _questTitle;
    [Token(Token = "0x400F427")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private CommonButton _skipButton;
    [Token(Token = "0x400F428")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private CommonButton[] _nextButtons;

    [Token(Token = "0x6015FBB")]
    [Address(RVA = "0x232EB28", Offset = "0x232EB28", VA = "0x232EB28")]
    public void SetQuestTitle(QuestInfo quest)
    {
    }

    [Token(Token = "0x6015FBC")]
    [Address(RVA = "0x232EB40", Offset = "0x232EB40", VA = "0x232EB40")]
    public void SetMissionClear(bool[] missionClear)
    {
    }

    [Token(Token = "0x6015FBD")]
    [Address(RVA = "0x232EB5C", Offset = "0x232EB5C", VA = "0x232EB5C")]
    public void SetSkipEvent(UnityAction callback)
    {
    }

    [Token(Token = "0x6015FBE")]
    [Address(RVA = "0x232EC9C", Offset = "0x232EC9C", VA = "0x232EC9C")]
    public void SetSkipActive(bool active)
    {
    }

    [Token(Token = "0x6015FBF")]
    [Address(RVA = "0x232EBAC", Offset = "0x232EBAC", VA = "0x232EBAC")]
    public void SetNextEvent(UnityAction callback)
    {
    }

    [Token(Token = "0x6015FC0")]
    [Address(RVA = "0x232F13C", Offset = "0x232F13C", VA = "0x232F13C")]
    public ResultItemSkipView()
    {
    }
  }
}
