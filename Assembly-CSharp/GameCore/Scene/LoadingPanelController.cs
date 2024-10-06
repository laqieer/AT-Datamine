// Decompiled with JetBrains decompiler
// Type: GameCore.Scene.LoadingPanelController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DLC;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace GameCore.Scene
{
  [Token(Token = "0x2000C93")]
  public class LoadingPanelController : MonoBehaviour
  {
    [Token(Token = "0x40038B6")]
    [FieldOffset(Offset = "0x18")]
    private LoadingPanelControllerStateType stateType;
    [Token(Token = "0x40038B7")]
    [FieldOffset(Offset = "0x20")]
    private Dictionary<string, bool> isLoadedAssetBundleMap;

    [Token(Token = "0x17000A93")]
    public bool IsShowing
    {
      [Token(Token = "0x600488D"), Address(RVA = "0x3132264", Offset = "0x3132264", VA = "0x3132264")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000A94")]
    public bool IsHiding
    {
      [Token(Token = "0x600488E"), Address(RVA = "0x312F7EC", Offset = "0x312F7EC", VA = "0x312F7EC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600488F")]
    [Address(RVA = "0x313183C", Offset = "0x313183C", VA = "0x313183C", Slot = "4")]
    public virtual void Initialize()
    {
    }

    [Token(Token = "0x6004890")]
    [Address(RVA = "0x3132274", Offset = "0x3132274", VA = "0x3132274", Slot = "5")]
    public virtual IEnumerator SetAssetData(AssetBundleManager manager) => (IEnumerator) null;

    [Token(Token = "0x6004891")]
    [Address(RVA = "0x31322FC", Offset = "0x31322FC", VA = "0x31322FC", Slot = "6")]
    public virtual void OnChangeOtherFade()
    {
    }

    [Token(Token = "0x6004892")]
    [Address(RVA = "0x312E2F4", Offset = "0x312E2F4", VA = "0x312E2F4")]
    public void SetActive(bool active)
    {
    }

    [Token(Token = "0x6004893")]
    [Address(RVA = "0x312F7FC", Offset = "0x312F7FC", VA = "0x312F7FC")]
    public IEnumerator StartShow() => (IEnumerator) null;

    [Token(Token = "0x6004894")]
    [Address(RVA = "0x31319EC", Offset = "0x31319EC", VA = "0x31319EC", Slot = "7")]
    protected virtual IEnumerator Show() => (IEnumerator) null;

    [Token(Token = "0x6004895")]
    [Address(RVA = "0x3132350", Offset = "0x3132350", VA = "0x3132350", Slot = "8")]
    protected virtual void ShowImpl()
    {
    }

    [Token(Token = "0x6004896")]
    [Address(RVA = "0x312E31C", Offset = "0x312E31C", VA = "0x312E31C")]
    public IEnumerator StartHide() => (IEnumerator) null;

    [Token(Token = "0x6004897")]
    [Address(RVA = "0x3131A58", Offset = "0x3131A58", VA = "0x3131A58", Slot = "9")]
    protected virtual IEnumerator Hide() => (IEnumerator) null;

    [Token(Token = "0x6004898")]
    [Address(RVA = "0x31323A4", Offset = "0x31323A4", VA = "0x31323A4", Slot = "10")]
    protected virtual void HideImpl()
    {
    }

    [Token(Token = "0x6004899")]
    [Address(RVA = "0x31323A8", Offset = "0x31323A8", VA = "0x31323A8", Slot = "11")]
    public virtual void UpdateDownloadProgress(DLCProgress dlcProgress)
    {
    }

    [Token(Token = "0x600489A")]
    [Address(RVA = "0x31323AC", Offset = "0x31323AC", VA = "0x31323AC", Slot = "12")]
    public virtual void UpdateLoadProgress(int successCount, int requestCount)
    {
    }

    [Token(Token = "0x600489B")]
    [Address(RVA = "0x31323B0", Offset = "0x31323B0", VA = "0x31323B0")]
    private bool CheckLoadedAssetBundle(string label) => new bool();

    [Token(Token = "0x600489C")]
    [Address(RVA = "0x3132444", Offset = "0x3132444", VA = "0x3132444")]
    protected void UnloadAssetBundle(string label, bool canUnloadAssetBundle)
    {
    }

    [Token(Token = "0x600489D")]
    [Address(RVA = "0x313252C", Offset = "0x313252C", VA = "0x313252C")]
    protected IEnumerator LoadWaitByAssetBundle(string label, Action<string, bool> successAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600489E")]
    [Address(RVA = "0x313196C", Offset = "0x313196C", VA = "0x313196C")]
    public LoadingPanelController()
    {
    }
  }
}
