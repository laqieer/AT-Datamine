// Decompiled with JetBrains decompiler
// Type: IntroChapter.FreeMoveSceneProcess
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.State;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace IntroChapter
{
  [Token(Token = "0x2000A80")]
  public class FreeMoveSceneProcess : SceneProcess
  {
    [Token(Token = "0x4003092")]
    [FieldOffset(Offset = "0x20")]
    private bool initialized;
    [Token(Token = "0x4003093")]
    [FieldOffset(Offset = "0x28")]
    private Coroutine seq;
    [Token(Token = "0x4003094")]
    [FieldOffset(Offset = "0x30")]
    private IntroChapterSequenceFreeActionSettingData param;
    [Token(Token = "0x4003095")]
    [FieldOffset(Offset = "0x38")]
    private FreeMapStateManager freeMapStateManager;

    [Token(Token = "0x6003BB5")]
    [Address(RVA = "0x331D618", Offset = "0x331D618", VA = "0x331D618")]
    public FreeMoveSceneProcess(
      ISceneProcessCoroutineMethod coMethod,
      IntroChapterMain main,
      IntroChapterSequenceFreeActionSettingData param)
    {
    }

    [Token(Token = "0x6003BB6")]
    [Address(RVA = "0x331EB9C", Offset = "0x331EB9C", VA = "0x331EB9C", Slot = "4")]
    public override void Initialize()
    {
    }

    [Token(Token = "0x6003BB7")]
    [Address(RVA = "0x331EBA0", Offset = "0x331EBA0", VA = "0x331EBA0", Slot = "5")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6003BB8")]
    [Address(RVA = "0x331EC30", Offset = "0x331EC30", VA = "0x331EC30", Slot = "8")]
    public override void OnPause()
    {
    }

    [Token(Token = "0x6003BB9")]
    [Address(RVA = "0x331EC34", Offset = "0x331EC34", VA = "0x331EC34", Slot = "9")]
    public override void OnResume()
    {
    }

    [Token(Token = "0x6003BBA")]
    [Address(RVA = "0x331EC38", Offset = "0x331EC38", VA = "0x331EC38", Slot = "10")]
    public override void BackKeyDownAction()
    {
    }

    [Token(Token = "0x6003BBB")]
    [Address(RVA = "0x331EC3C", Offset = "0x331EC3C", VA = "0x331EC3C", Slot = "11")]
    public override void Disable()
    {
    }

    [Token(Token = "0x6003BBC")]
    [Address(RVA = "0x331EC40", Offset = "0x331EC40", VA = "0x331EC40", Slot = "7")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x6003BBD")]
    [Address(RVA = "0x331ECD0", Offset = "0x331ECD0", VA = "0x331ECD0", Slot = "6")]
    public override void OnUpdate()
    {
    }

    [Token(Token = "0x6003BBE")]
    [Address(RVA = "0x331ECE4", Offset = "0x331ECE4", VA = "0x331ECE4")]
    private IEnumerator SequenceProcess() => (IEnumerator) null;

    [Token(Token = "0x6003BBF")]
    [Address(RVA = "0x331ED74", Offset = "0x331ED74", VA = "0x331ED74")]
    private void ChangeNextSequence(int seqId)
    {
    }
  }
}
