// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Control.Animation.UIShowAnimationController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using Tween.Tweeners;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace FreeMap.UI.Control.Animation
{
  [Token(Token = "0x20016C7")]
  public class UIShowAnimationController
  {
    [Token(Token = "0x40065EA")]
    [FieldOffset(Offset = "0x10")]
    protected UIShowTweenNameList showTweenNameList;
    [Token(Token = "0x40065EB")]
    [FieldOffset(Offset = "0x18")]
    protected GameObject uiPrefab;
    [Token(Token = "0x40065EC")]
    [FieldOffset(Offset = "0x20")]
    protected UIAnimationController prefabShowAnimationController;
    [Token(Token = "0x40065ED")]
    [FieldOffset(Offset = "0x28")]
    protected UnityAction hideAnimationCallback;
    [Token(Token = "0x40065EE")]
    [FieldOffset(Offset = "0x30")]
    private TweenAlpha tweenAlpha;

    [Token(Token = "0x60080C8")]
    [Address(RVA = "0x41F60C4", Offset = "0x41F60C4", VA = "0x41F60C4")]
    public UIShowAnimationController(
      GameObject showUIPrefab,
      UIShowTweenNameList tweenNameList,
      bool isShown)
    {
    }

    [Token(Token = "0x60080C9")]
    [Address(RVA = "0x41F6548", Offset = "0x41F6548", VA = "0x41F6548", Slot = "4")]
    public virtual void Update()
    {
    }

    [Token(Token = "0x60080CA")]
    [Address(RVA = "0x41F68D0", Offset = "0x41F68D0", VA = "0x41F68D0", Slot = "5")]
    public virtual void PlayShowAnimation()
    {
    }

    [Token(Token = "0x60080CB")]
    [Address(RVA = "0x41F6B2C", Offset = "0x41F6B2C", VA = "0x41F6B2C", Slot = "6")]
    public virtual void PlayHideAnimation()
    {
    }

    [Token(Token = "0x60080CC")]
    [Address(RVA = "0x41F1D1C", Offset = "0x41F1D1C", VA = "0x41F1D1C")]
    public void PlayAlphaAnimation(float toAlpha)
    {
    }

    [Token(Token = "0x60080CD")]
    [Address(RVA = "0x41F62D4", Offset = "0x41F62D4", VA = "0x41F62D4")]
    protected UITweener[] GetTweenerGroup(UITweenGroup group, string[] targetGroupIDArray)
    {
      return (UITweener[]) null;
    }
  }
}
