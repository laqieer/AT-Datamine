// Decompiled with JetBrains decompiler
// Type: IntroChapter.MainAssetDownloadSceneProcess
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DLC;
using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace IntroChapter
{
  [Token(Token = "0x2000A8B")]
  public class MainAssetDownloadSceneProcess : SceneProcess
  {
    [Token(Token = "0x40030AA")]
    [FieldOffset(Offset = "0x20")]
    private bool isInited;
    [Token(Token = "0x40030AB")]
    [FieldOffset(Offset = "0x21")]
    private bool isInitializeAsyncEnded;
    [Token(Token = "0x40030AC")]
    [FieldOffset(Offset = "0x28")]
    private DLCProcess DlcProcess;

    [Token(Token = "0x6003BF2")]
    [Address(RVA = "0x331D178", Offset = "0x331D178", VA = "0x331D178")]
    public MainAssetDownloadSceneProcess(
      ISceneProcessCoroutineMethod coMethod,
      IntroChapterMain main)
    {
    }

    [Token(Token = "0x6003BF3")]
    [Address(RVA = "0x331FA04", Offset = "0x331FA04", VA = "0x331FA04", Slot = "4")]
    public override void Initialize()
    {
    }

    [Token(Token = "0x6003BF4")]
    [Address(RVA = "0x331FAF4", Offset = "0x331FAF4", VA = "0x331FAF4", Slot = "5")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6003BF5")]
    [Address(RVA = "0x331FB84", Offset = "0x331FB84", VA = "0x331FB84", Slot = "8")]
    public override void OnPause()
    {
    }

    [Token(Token = "0x6003BF6")]
    [Address(RVA = "0x331FB88", Offset = "0x331FB88", VA = "0x331FB88", Slot = "9")]
    public override void OnResume()
    {
    }

    [Token(Token = "0x6003BF7")]
    [Address(RVA = "0x331FB8C", Offset = "0x331FB8C", VA = "0x331FB8C", Slot = "10")]
    public override void BackKeyDownAction()
    {
    }

    [Token(Token = "0x6003BF8")]
    [Address(RVA = "0x331FB90", Offset = "0x331FB90", VA = "0x331FB90", Slot = "11")]
    public override void Disable()
    {
    }

    [Token(Token = "0x6003BF9")]
    [Address(RVA = "0x331FB94", Offset = "0x331FB94", VA = "0x331FB94", Slot = "7")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x6003BFA")]
    [Address(RVA = "0x331FB98", Offset = "0x331FB98", VA = "0x331FB98", Slot = "6")]
    public override void OnUpdate()
    {
    }

    [Token(Token = "0x6003BFB")]
    [Address(RVA = "0x331FB9C", Offset = "0x331FB9C", VA = "0x331FB9C")]
    private IEnumerator ProcessSequence() => (IEnumerator) null;

    [Token(Token = "0x6003BFC")]
    [Address(RVA = "0x331FC2C", Offset = "0x331FC2C", VA = "0x331FC2C")]
    private IEnumerator MainAssetDownLoadAssetCoroutine() => (IEnumerator) null;

    [Token(Token = "0x6003BFD")]
    [Address(RVA = "0x331FCBC", Offset = "0x331FCBC", VA = "0x331FCBC")]
    private IEnumerator StartDLCDownload() => (IEnumerator) null;

    [Token(Token = "0x6003BFE")]
    [Address(RVA = "0x331FD4C", Offset = "0x331FD4C", VA = "0x331FD4C")]
    private void DownloadAssetBundleSuccess(DLCProgress dlcProgress)
    {
    }

    [Token(Token = "0x6003BFF")]
    [Address(RVA = "0x331FD50", Offset = "0x331FD50", VA = "0x331FD50")]
    private IEnumerator SetupAssetAfterMainAssetDownload() => (IEnumerator) null;

    [Token(Token = "0x6003C00")]
    [Address(RVA = "0x331FDD8", Offset = "0x331FDD8", VA = "0x331FDD8")]
    private void DownloadAssetBundleProgress(DLCProgress progress)
    {
    }

    [Token(Token = "0x6003C01")]
    [Address(RVA = "0x331FE70", Offset = "0x331FE70", VA = "0x331FE70")]
    private void DownloadAssetBundleStart()
    {
    }
  }
}
