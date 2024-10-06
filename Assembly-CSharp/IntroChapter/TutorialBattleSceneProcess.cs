// Decompiled with JetBrains decompiler
// Type: IntroChapter.TutorialBattleSceneProcess
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace IntroChapter
{
  [Token(Token = "0x2000A9E")]
  public class TutorialBattleSceneProcess : SceneProcess
  {
    [Token(Token = "0x40030E2")]
    [FieldOffset(Offset = "0x20")]
    private Coroutine seq;
    [Token(Token = "0x40030E3")]
    [FieldOffset(Offset = "0x28")]
    private IntroChapterSequenceBattleSettingData param;

    [Token(Token = "0x6003C73")]
    [Address(RVA = "0x331D55C", Offset = "0x331D55C", VA = "0x331D55C")]
    public TutorialBattleSceneProcess(
      ISceneProcessCoroutineMethod coMethod,
      IntroChapterMain main,
      IntroChapterSequenceBattleSettingData param)
    {
    }

    [Token(Token = "0x6003C74")]
    [Address(RVA = "0x3322484", Offset = "0x3322484", VA = "0x3322484", Slot = "4")]
    public override void Initialize()
    {
    }

    [Token(Token = "0x6003C75")]
    [Address(RVA = "0x3322488", Offset = "0x3322488", VA = "0x3322488", Slot = "5")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6003C76")]
    [Address(RVA = "0x3322518", Offset = "0x3322518", VA = "0x3322518")]
    private IEnumerator SetupperSceneChangeSequencece() => (IEnumerator) null;

    [Token(Token = "0x6003C77")]
    [Address(RVA = "0x33225A8", Offset = "0x33225A8", VA = "0x33225A8", Slot = "8")]
    public override void OnPause()
    {
    }

    [Token(Token = "0x6003C78")]
    [Address(RVA = "0x33225AC", Offset = "0x33225AC", VA = "0x33225AC", Slot = "9")]
    public override void OnResume()
    {
    }

    [Token(Token = "0x6003C79")]
    [Address(RVA = "0x33225B0", Offset = "0x33225B0", VA = "0x33225B0", Slot = "10")]
    public override void BackKeyDownAction()
    {
    }

    [Token(Token = "0x6003C7A")]
    [Address(RVA = "0x33225B4", Offset = "0x33225B4", VA = "0x33225B4", Slot = "11")]
    public override void Disable()
    {
    }

    [Token(Token = "0x6003C7B")]
    [Address(RVA = "0x33225B8", Offset = "0x33225B8", VA = "0x33225B8", Slot = "7")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x6003C7C")]
    [Address(RVA = "0x33225BC", Offset = "0x33225BC", VA = "0x33225BC", Slot = "6")]
    public override void OnUpdate()
    {
    }

    [Token(Token = "0x6003C7D")]
    [Address(RVA = "0x33225C0", Offset = "0x33225C0", VA = "0x33225C0")]
    public static PvEBattle.QuestBattleSceneParameter CreateTutorialBattleSceneParam(
      QuestTypeEnum questType,
      int questId)
    {
      return (PvEBattle.QuestBattleSceneParameter) null;
    }

    [Token(Token = "0x6003C7E")]
    [Address(RVA = "0x3322714", Offset = "0x3322714", VA = "0x3322714")]
    public static void ChangeSceneOnBattleEnd()
    {
    }
  }
}
