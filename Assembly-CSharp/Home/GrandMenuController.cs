// Decompiled with JetBrains decompiler
// Type: Home.GrandMenuController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GlandMenu;
using Il2CppDummyDll;
using System;
using System.Collections;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace Home
{
  [Token(Token = "0x2000B5A")]
  public class GrandMenuController : MonoBehaviour
  {
    [Token(Token = "0x40033E4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GlobalMenuButtonGroup buttonGroup;
    [Token(Token = "0x40033E5")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ContentLockController contentLockController;
    [Token(Token = "0x40033E6")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private UITimelineController timelineController;
    [Token(Token = "0x40033E7")]
    [FieldOffset(Offset = "0x30")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x40033E8")]
    [FieldOffset(Offset = "0x38")]
    private bool isOpen;

    [Token(Token = "0x1700096C")]
    public GlobalMenuButtonGroup ButtonGroup
    {
      [Token(Token = "0x60040AC"), Address(RVA = "0x2A29500", Offset = "0x2A29500", VA = "0x2A29500")] get
      {
        return (GlobalMenuButtonGroup) null;
      }
    }

    [Token(Token = "0x60040AD")]
    [Address(RVA = "0x2A29508", Offset = "0x2A29508", VA = "0x2A29508")]
    private void Awake()
    {
    }

    [Token(Token = "0x60040AE")]
    [Address(RVA = "0x2A2958C", Offset = "0x2A2958C", VA = "0x2A2958C")]
    public IEnumerator LoadAsync() => (IEnumerator) null;

    [Token(Token = "0x60040AF")]
    [Address(RVA = "0x2A2961C", Offset = "0x2A2961C", VA = "0x2A2961C")]
    public void UpdateData()
    {
    }

    [Token(Token = "0x60040B0")]
    [Address(RVA = "0x2A29640", Offset = "0x2A29640", VA = "0x2A29640")]
    public void UpdateExtraButtonActive()
    {
    }

    [Token(Token = "0x60040B1")]
    [Address(RVA = "0x2A2965C", Offset = "0x2A2965C", VA = "0x2A2965C")]
    public void ViewContentLock()
    {
    }

    [Token(Token = "0x60040B2")]
    [Address(RVA = "0x2A29678", Offset = "0x2A29678", VA = "0x2A29678")]
    public IEnumerator PlayToUnlockEffect() => (IEnumerator) null;

    [Token(Token = "0x60040B3")]
    [Address(RVA = "0x2A29708", Offset = "0x2A29708", VA = "0x2A29708")]
    public void Restart()
    {
    }

    [Token(Token = "0x60040B4")]
    [Address(RVA = "0x2A29730", Offset = "0x2A29730", VA = "0x2A29730")]
    public void Open(Action onComplete = null)
    {
    }

    [Token(Token = "0x60040B5")]
    [Address(RVA = "0x2A29838", Offset = "0x2A29838", VA = "0x2A29838")]
    public void Close(Action onComplete = null)
    {
    }

    [Token(Token = "0x60040B6")]
    [Address(RVA = "0x2A2976C", Offset = "0x2A2976C", VA = "0x2A2976C")]
    private void PlayInAnimation(Action onComplete = null)
    {
    }

    [Token(Token = "0x60040B7")]
    [Address(RVA = "0x2A29870", Offset = "0x2A29870", VA = "0x2A29870")]
    private void PlayOutAnimation(Action onComplete = null)
    {
    }

    [Token(Token = "0x60040B8")]
    [Address(RVA = "0x2A2989C", Offset = "0x2A2989C", VA = "0x2A2989C")]
    public void SetTapBlock(bool isOn)
    {
    }

    [Token(Token = "0x60040B9")]
    [Address(RVA = "0x2A298BC", Offset = "0x2A298BC", VA = "0x2A298BC")]
    public GrandMenuController()
    {
    }
  }
}
