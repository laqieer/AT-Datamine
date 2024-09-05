// Decompiled with JetBrains decompiler
// Type: IntroChapter.AdvSceneProcess
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Story.Adv;
using System.Collections;
using UnityEngine;

#nullable disable
namespace IntroChapter
{
  [Token(Token = "0x2000A78")]
  public class AdvSceneProcess : SceneProcess
  {
    [Token(Token = "0x400307E")]
    [FieldOffset(Offset = "0x20")]
    private Coroutine seq;
    [Token(Token = "0x400307F")]
    [FieldOffset(Offset = "0x28")]
    private AdvStage advStage;
    [Token(Token = "0x4003080")]
    [FieldOffset(Offset = "0x30")]
    private int advId;
    [Token(Token = "0x4003081")]
    [FieldOffset(Offset = "0x34")]
    private bool initialized;

    [Token(Token = "0x6003B7A")]
    [Address(RVA = "0x331D514", Offset = "0x331D514", VA = "0x331D514")]
    public AdvSceneProcess(
      ISceneProcessCoroutineMethod coMethod,
      IntroChapterMain main,
      IntroChapterSequenceAdvSettingData pram)
    {
    }

    [Token(Token = "0x6003B7B")]
    [Address(RVA = "0x331DE40", Offset = "0x331DE40", VA = "0x331DE40", Slot = "4")]
    public override void Initialize()
    {
    }

    [Token(Token = "0x6003B7C")]
    [Address(RVA = "0x331DE44", Offset = "0x331DE44", VA = "0x331DE44", Slot = "5")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6003B7D")]
    [Address(RVA = "0x331DED4", Offset = "0x331DED4", VA = "0x331DED4", Slot = "8")]
    public override void OnPause()
    {
    }

    [Token(Token = "0x6003B7E")]
    [Address(RVA = "0x331DED8", Offset = "0x331DED8", VA = "0x331DED8", Slot = "9")]
    public override void OnResume()
    {
    }

    [Token(Token = "0x6003B7F")]
    [Address(RVA = "0x331DEDC", Offset = "0x331DEDC", VA = "0x331DEDC", Slot = "10")]
    public override void BackKeyDownAction()
    {
    }

    [Token(Token = "0x6003B80")]
    [Address(RVA = "0x331DEE0", Offset = "0x331DEE0", VA = "0x331DEE0", Slot = "11")]
    public override void Disable()
    {
    }

    [Token(Token = "0x6003B81")]
    [Address(RVA = "0x331DEE4", Offset = "0x331DEE4", VA = "0x331DEE4", Slot = "7")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x6003B82")]
    [Address(RVA = "0x331DEE8", Offset = "0x331DEE8", VA = "0x331DEE8", Slot = "6")]
    public override void OnUpdate()
    {
    }

    [Token(Token = "0x6003B83")]
    [Address(RVA = "0x331DEEC", Offset = "0x331DEEC", VA = "0x331DEEC")]
    private IEnumerator SequenceProcess() => (IEnumerator) null;

    [Token(Token = "0x6003B84")]
    [Address(RVA = "0x331DF7C", Offset = "0x331DF7C", VA = "0x331DF7C")]
    private IEnumerator ProgressEndedSequence() => (IEnumerator) null;

    [Token(Token = "0x6003B85")]
    [Address(RVA = "0x331E004", Offset = "0x331E004", VA = "0x331E004")]
    private IEnumerator AdvStageSequence() => (IEnumerator) null;
  }
}
