// Decompiled with JetBrains decompiler
// Type: IntroChapter.HomeTutorialSceneProcess
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace IntroChapter
{
  [Token(Token = "0x2000A84")]
  public class HomeTutorialSceneProcess : SceneProcess
  {
    [Token(Token = "0x400309D")]
    [FieldOffset(Offset = "0x20")]
    private bool initialized;
    [Token(Token = "0x400309E")]
    [FieldOffset(Offset = "0x28")]
    private IntroChapterSequenceHomeTutorialSettingData param;
    [Token(Token = "0x400309F")]
    [FieldOffset(Offset = "0x30")]
    private TutorialAdv tutorialAdv;
    [Token(Token = "0x40030A0")]
    [FieldOffset(Offset = "0x38")]
    private bool sceneCalled;
    [Token(Token = "0x40030A1")]
    [FieldOffset(Offset = "0x39")]
    private bool isCalled;

    [Token(Token = "0x6003BCE")]
    [Address(RVA = "0x331D654", Offset = "0x331D654", VA = "0x331D654")]
    public HomeTutorialSceneProcess(
      ISceneProcessCoroutineMethod coMethod,
      IntroChapterMain main,
      IntroChapterSequenceHomeTutorialSettingData param)
    {
    }

    [Token(Token = "0x6003BCF")]
    [Address(RVA = "0x331F20C", Offset = "0x331F20C", VA = "0x331F20C", Slot = "4")]
    public override void Initialize()
    {
    }

    [Token(Token = "0x6003BD0")]
    [Address(RVA = "0x331F210", Offset = "0x331F210", VA = "0x331F210", Slot = "5")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6003BD1")]
    [Address(RVA = "0x331F2A0", Offset = "0x331F2A0", VA = "0x331F2A0", Slot = "8")]
    public override void OnPause()
    {
    }

    [Token(Token = "0x6003BD2")]
    [Address(RVA = "0x331F2A4", Offset = "0x331F2A4", VA = "0x331F2A4", Slot = "9")]
    public override void OnResume()
    {
    }

    [Token(Token = "0x6003BD3")]
    [Address(RVA = "0x331F2A8", Offset = "0x331F2A8", VA = "0x331F2A8", Slot = "10")]
    public override void BackKeyDownAction()
    {
    }

    [Token(Token = "0x6003BD4")]
    [Address(RVA = "0x331F2AC", Offset = "0x331F2AC", VA = "0x331F2AC", Slot = "11")]
    public override void Disable()
    {
    }

    [Token(Token = "0x6003BD5")]
    [Address(RVA = "0x331F2B0", Offset = "0x331F2B0", VA = "0x331F2B0", Slot = "7")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x6003BD6")]
    [Address(RVA = "0x331F2B4", Offset = "0x331F2B4", VA = "0x331F2B4", Slot = "6")]
    public override void OnUpdate()
    {
    }
  }
}
