// Decompiled with JetBrains decompiler
// Type: Scenes.Title.TitleMenuCacheClearPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DLC;
using GameCore.Input;
using Il2CppDummyDll;
using System;
using System.Collections;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace Scenes.Title
{
  [Token(Token = "0x20028E8")]
  public class TitleMenuCacheClearPopup : MonoBehaviour
  {
    [Token(Token = "0x400AE6E")]
    [FieldOffset(Offset = "0x0")]
    private static readonly string AnimationIn;
    [Token(Token = "0x400AE6F")]
    [FieldOffset(Offset = "0x8")]
    private static readonly string AnimationOut;
    [Token(Token = "0x400AE70")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController timelineController;
    [Token(Token = "0x400AE71")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x400AE72")]
    [FieldOffset(Offset = "0x28")]
    private bool isProgress;
    [Token(Token = "0x400AE73")]
    [FieldOffset(Offset = "0x30")]
    private Action onDecide;

    [Token(Token = "0x601016E")]
    [Address(RVA = "0x416C844", Offset = "0x416C844", VA = "0x416C844")]
    public IEnumerator Open(Action onDecide = null) => (IEnumerator) null;

    [Token(Token = "0x601016F")]
    [Address(RVA = "0x416F9E8", Offset = "0x416F9E8", VA = "0x416F9E8")]
    public void OnClickClear()
    {
    }

    [Token(Token = "0x6010170")]
    [Address(RVA = "0x416FB18", Offset = "0x416FB18", VA = "0x416FB18")]
    private void DownloadProgress(DLCProgress dlcProgress)
    {
    }

    [Token(Token = "0x6010171")]
    [Address(RVA = "0x416FBB0", Offset = "0x416FBB0", VA = "0x416FBB0")]
    private void ChangeSceneCallback(string sceneName)
    {
    }

    [Token(Token = "0x6010172")]
    [Address(RVA = "0x416FAB0", Offset = "0x416FAB0", VA = "0x416FAB0")]
    private IEnumerator ClearDownloadAssetBundles() => (IEnumerator) null;

    [Token(Token = "0x6010173")]
    [Address(RVA = "0x416FD84", Offset = "0x416FD84", VA = "0x416FD84")]
    private IEnumerator DownloadAssetBundles() => (IEnumerator) null;

    [Token(Token = "0x6010174")]
    [Address(RVA = "0x416FE0C", Offset = "0x416FE0C", VA = "0x416FE0C")]
    public void OnClickClose()
    {
    }

    [Token(Token = "0x6010175")]
    [Address(RVA = "0x416FEF4", Offset = "0x416FEF4", VA = "0x416FEF4")]
    public TitleMenuCacheClearPopup()
    {
    }

    [Token(Token = "0x6010176")]
    [Address(RVA = "0x416FEFC", Offset = "0x416FEFC", VA = "0x416FEFC")]
    static TitleMenuCacheClearPopup()
    {
    }
  }
}
