// Decompiled with JetBrains decompiler
// Type: GameCore.DLC.DLCProcess
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace GameCore.DLC
{
  [Token(Token = "0x20014C6")]
  public class DLCProcess
  {
    [Token(Token = "0x4005F8C")]
    [FieldOffset(Offset = "0x11")]
    private bool isDownloadCancel;

    [Token(Token = "0x17001201")]
    public bool Started
    {
      [Token(Token = "0x600751D"), Address(RVA = "0x43F6CB0", Offset = "0x43F6CB0", VA = "0x43F6CB0")] set
      {
      }
      [Token(Token = "0x600751E"), Address(RVA = "0x43F6CBC", Offset = "0x43F6CBC", VA = "0x43F6CBC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001202")]
    public bool IsDownloadCancel
    {
      [Token(Token = "0x600751F"), Address(RVA = "0x43F6CC4", Offset = "0x43F6CC4", VA = "0x43F6CC4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6007520")]
    [Address(RVA = "0x43F6CCC", Offset = "0x43F6CCC", VA = "0x43F6CCC")]
    public IEnumerator DownloadAssetBundleWithAssetBundleNameList(
      string[] downloadDlcAssetNames,
      Action<DLCProgress> completeAction,
      Action<DLCProgress> progressCallback,
      Action startCallback = null,
      bool showDownloadPopup = true,
      bool branchDownload = false,
      Action<DLCProgress> sendLog = null,
      Action cancelCallback = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6007521")]
    [Address(RVA = "0x43F6DB8", Offset = "0x43F6DB8", VA = "0x43F6DB8")]
    public IEnumerator DownloadAssetBundle(
      Action<DLCProgress> completeAction,
      Action<DLCProgress> progressCallback,
      Action startCallback = null,
      Action cancelCallback = null,
      bool showDownloadPopup = true,
      Action<DLCProgress> sendLog = null,
      bool isAllDownload = false,
      bool isIncludeBranch = false)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6007522")]
    [Address(RVA = "0x43F6EAC", Offset = "0x43F6EAC", VA = "0x43F6EAC")]
    private IEnumerator DownloadAddedAssetBundle(
      Action<DLCProgress> completeAction,
      Action<DLCProgress> progressCallback,
      Action startCallback,
      Action cancelCallback,
      bool showDownloadPopup,
      bool branchDownload = false,
      Action<DLCProgress> sendLog = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6007523")]
    [Address(RVA = "0x43F6F94", Offset = "0x43F6F94", VA = "0x43F6F94")]
    private void Restart(string[] errorFiles)
    {
    }

    [Token(Token = "0x6007524")]
    [Address(RVA = "0x43F7098", Offset = "0x43F7098", VA = "0x43F7098")]
    private void GoTitle()
    {
    }

    [Token(Token = "0x6007525")]
    [Address(RVA = "0x43F711C", Offset = "0x43F711C", VA = "0x43F711C")]
    private IEnumerator ShowDownloadPopup() => (IEnumerator) null;

    [Token(Token = "0x6007526")]
    [Address(RVA = "0x43F71AC", Offset = "0x43F71AC", VA = "0x43F71AC")]
    public IEnumerator OpenSelectDownloadModeConfirmDialogForDebugStart() => (IEnumerator) null;

    [Token(Token = "0x6007527")]
    [Address(RVA = "0x43F7234", Offset = "0x43F7234", VA = "0x43F7234")]
    public IEnumerator OpenDownloadModeConfirmDialogForFirstPlay(
      long totalLightSize,
      long totalNormalSize)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6007528")]
    [Address(RVA = "0x43F72D0", Offset = "0x43F72D0", VA = "0x43F72D0")]
    public DLCProcess()
    {
    }
  }
}
