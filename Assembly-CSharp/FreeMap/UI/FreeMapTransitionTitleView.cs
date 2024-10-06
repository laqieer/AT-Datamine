// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.FreeMapTransitionTitleView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace FreeMap.UI
{
  [Token(Token = "0x200160A")]
  public class FreeMapTransitionTitleView : MonoBehaviour, IFreeMapTransitionView
  {
    [Token(Token = "0x4006465")]
    private const string TweenShow = "AreaMove_in";
    [Token(Token = "0x4006466")]
    private const string TweenClose = "AreaMove_out";
    [Token(Token = "0x4006467")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup uITween;
    [Token(Token = "0x4006468")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text titleText;

    [Token(Token = "0x6007CD5")]
    [Address(RVA = "0x21A490C", Offset = "0x21A490C", VA = "0x21A490C")]
    private void Awake()
    {
    }

    [Token(Token = "0x6007CD6")]
    [Address(RVA = "0x21A4930", Offset = "0x21A4930", VA = "0x21A4930", Slot = "4")]
    public void SetTitle(string title)
    {
    }

    [Token(Token = "0x6007CD7")]
    [Address(RVA = "0x21A4954", Offset = "0x21A4954", VA = "0x21A4954", Slot = "5")]
    public void PlayShow()
    {
    }

    [Token(Token = "0x6007CD8")]
    [Address(RVA = "0x21A49D8", Offset = "0x21A49D8", VA = "0x21A49D8", Slot = "6")]
    public void PlayHide(Action callback)
    {
    }

    [Token(Token = "0x6007CD9")]
    [Address(RVA = "0x21A4B20", Offset = "0x21A4B20", VA = "0x21A4B20")]
    private void PlayCloseCallback()
    {
    }

    [Token(Token = "0x6007CDA")]
    [Address(RVA = "0x21A4B5C", Offset = "0x21A4B5C", VA = "0x21A4B5C")]
    public FreeMapTransitionTitleView()
    {
    }
  }
}
