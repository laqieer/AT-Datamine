// Decompiled with JetBrains decompiler
// Type: GameCore.Fade.FadePanelManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using Il2CppDummyDll;
using System;
using Tween.Tweeners;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace GameCore.Fade
{
  [Token(Token = "0x2001466")]
  public class FadePanelManager : SingletonMonoBehaviour<FadePanelManager>
  {
    [Token(Token = "0x4005DF2")]
    [FieldOffset(Offset = "0x1C")]
    private FadePanelManager.FadeState fadeState;
    [Token(Token = "0x4005DF3")]
    [FieldOffset(Offset = "0x20")]
    private int defaultSortOrder;
    [Token(Token = "0x4005DF4")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Canvas canvas;
    [Token(Token = "0x4005DF5")]
    [FieldOffset(Offset = "0x30")]
    private RectTransform canvasRectTransform;
    [Token(Token = "0x4005DF6")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Image fadeImage;
    [Token(Token = "0x4005DF7")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private TweenAlpha tweenAlpha;
    [Token(Token = "0x4005DF8")]
    [FieldOffset(Offset = "0x48")]
    private Color lastFadeoutColor;

    [Token(Token = "0x60072F3")]
    [Address(RVA = "0x405414C", Offset = "0x405414C", VA = "0x405414C", Slot = "5")]
    public override void Initialize()
    {
    }

    [Token(Token = "0x60072F4")]
    [Address(RVA = "0x40541D8", Offset = "0x40541D8", VA = "0x40541D8")]
    public void Reset()
    {
    }

    [Token(Token = "0x60072F5")]
    [Address(RVA = "0x4054294", Offset = "0x4054294", VA = "0x4054294")]
    private Color StringToColor(string colorCode) => new Color();

    [Token(Token = "0x60072F6")]
    [Address(RVA = "0x40542E0", Offset = "0x40542E0", VA = "0x40542E0")]
    public void ChangeSortOrder(int sortOrder = 1000)
    {
    }

    [Token(Token = "0x60072F7")]
    [Address(RVA = "0x4054220", Offset = "0x4054220", VA = "0x4054220")]
    public void ResetSortOrder()
    {
    }

    [Token(Token = "0x60072F8")]
    [Address(RVA = "0x40542FC", Offset = "0x40542FC", VA = "0x40542FC")]
    public void ChangeParentObject(RectTransform targetRectTransform)
    {
    }

    [Token(Token = "0x60072F9")]
    [Address(RVA = "0x4054244", Offset = "0x4054244", VA = "0x4054244")]
    public void ResetParentObject()
    {
    }

    [Token(Token = "0x60072FA")]
    [Address(RVA = "0x405432C", Offset = "0x405432C", VA = "0x405432C")]
    private void ColorFadeOut(Color targetColor, float duration, Action finishCallback)
    {
    }

    [Token(Token = "0x60072FB")]
    [Address(RVA = "0x40544BC", Offset = "0x40544BC", VA = "0x40544BC")]
    private void ColorFadeIn(Color targetColor, float duration, Action finishCallback = null)
    {
    }

    [Token(Token = "0x60072FC")]
    [Address(RVA = "0x4054644", Offset = "0x4054644", VA = "0x4054644")]
    public void ManualUpdateFadeOutColor(Color targetColor)
    {
    }

    [Token(Token = "0x60072FD")]
    [Address(RVA = "0x4054698", Offset = "0x4054698", VA = "0x4054698")]
    public void FadeIn(float duration, Action finishCallback = null)
    {
    }

    [Token(Token = "0x60072FE")]
    [Address(RVA = "0x40546B0", Offset = "0x40546B0", VA = "0x40546B0")]
    public void BlackOut(float duration, Action finishCallback = null)
    {
    }

    [Token(Token = "0x60072FF")]
    [Address(RVA = "0x40546C8", Offset = "0x40546C8", VA = "0x40546C8")]
    public void BlackIn(float duration, Action finishCallback = null)
    {
    }

    [Token(Token = "0x6007300")]
    [Address(RVA = "0x40546E0", Offset = "0x40546E0", VA = "0x40546E0")]
    public void WhiteOut(float duration, Action finishCallback = null)
    {
    }

    [Token(Token = "0x6007301")]
    [Address(RVA = "0x40546F8", Offset = "0x40546F8", VA = "0x40546F8")]
    public void WhiteIn(float duration, Action finishCallback = null)
    {
    }

    [Token(Token = "0x6007302")]
    [Address(RVA = "0x4054710", Offset = "0x4054710", VA = "0x4054710")]
    public void ColorOut(Color targetColor, float duration, Action finishCallback = null)
    {
    }

    [Token(Token = "0x6007303")]
    [Address(RVA = "0x4054714", Offset = "0x4054714", VA = "0x4054714")]
    public void ColorIn(Color targetColor, float duration, Action finishCallback = null)
    {
    }

    [Token(Token = "0x6007304")]
    [Address(RVA = "0x4054718", Offset = "0x4054718", VA = "0x4054718")]
    public void ColorOut(string colorCode, float duration, Action finishCallback = null)
    {
    }

    [Token(Token = "0x6007305")]
    [Address(RVA = "0x4054750", Offset = "0x4054750", VA = "0x4054750")]
    public void ColorIn(string colorCode, float duration, Action finishCallback = null)
    {
    }

    [Token(Token = "0x6007306")]
    [Address(RVA = "0x4054788", Offset = "0x4054788", VA = "0x4054788")]
    public bool IsFadeOutNow() => new bool();

    [Token(Token = "0x6007307")]
    [Address(RVA = "0x405479C", Offset = "0x405479C", VA = "0x405479C")]
    public FadePanelManager()
    {
    }

    [Token(Token = "0x2001467")]
    private enum FadeState
    {
      [Token(Token = "0x4005DFA")] None,
      [Token(Token = "0x4005DFB")] FadeInNow,
      [Token(Token = "0x4005DFC")] FadedIn,
      [Token(Token = "0x4005DFD")] FadeOutNow,
      [Token(Token = "0x4005DFE")] FadedOut,
    }
  }
}
