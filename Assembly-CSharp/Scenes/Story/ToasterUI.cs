// Decompiled with JetBrains decompiler
// Type: Scenes.Story.ToasterUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Story
{
  [Token(Token = "0x2002D78")]
  public class ToasterUI : MonoBehaviour
  {
    [Token(Token = "0x400C324")]
    private const string TWEEN_IN_KEY = "Toaster";
    [Token(Token = "0x400C325")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform rectTransform;
    [Token(Token = "0x400C326")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400C327")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text title;
    [Token(Token = "0x400C328")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text message;
    [Token(Token = "0x400C329")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private PlayableDirector playableDirector;
    [Token(Token = "0x400C32A")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private PlayableAsset inOutTimeline;
    [Token(Token = "0x400C32B")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private PlayableAsset outTimeline;
    [Token(Token = "0x400C32C")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Button buttonBG;
    [Token(Token = "0x400C32D")]
    [FieldOffset(Offset = "0x58")]
    private Action<ToasterUI> onComplete;
    [Token(Token = "0x400C32E")]
    [FieldOffset(Offset = "0x60")]
    public Action<ToasterUI> OnClickBG;

    [Token(Token = "0x17003CB4")]
    public RectTransform RectTransform
    {
      [Token(Token = "0x6011C5B"), Address(RVA = "0x42BF0C8", Offset = "0x42BF0C8", VA = "0x42BF0C8")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x17003CB5")]
    public bool IsClosing
    {
      [Token(Token = "0x6011C5C"), Address(RVA = "0x42BF0D0", Offset = "0x42BF0D0", VA = "0x42BF0D0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17003CB6")]
    public bool IsOpening
    {
      [Token(Token = "0x6011C5D"), Address(RVA = "0x42BF174", Offset = "0x42BF174", VA = "0x42BF174")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6011C5E")]
    [Address(RVA = "0x42BF218", Offset = "0x42BF218", VA = "0x42BF218")]
    public void Awake()
    {
    }

    [Token(Token = "0x6011C5F")]
    [Address(RVA = "0x42BF354", Offset = "0x42BF354", VA = "0x42BF354")]
    public void PlayToTween()
    {
    }

    [Token(Token = "0x6011C60")]
    [Address(RVA = "0x42BF3F4", Offset = "0x42BF3F4", VA = "0x42BF3F4")]
    public void SetText(string text)
    {
    }

    [Token(Token = "0x6011C61")]
    [Address(RVA = "0x42BF418", Offset = "0x42BF418", VA = "0x42BF418")]
    public void SetTitle(string text)
    {
    }

    [Token(Token = "0x6011C62")]
    [Address(RVA = "0x42BF43C", Offset = "0x42BF43C", VA = "0x42BF43C")]
    public void SetMessage(string text)
    {
    }

    [Token(Token = "0x6011C63")]
    [Address(RVA = "0x42BF460", Offset = "0x42BF460", VA = "0x42BF460")]
    public void Play(Action<ToasterUI> onComplete)
    {
    }

    [Token(Token = "0x6011C64")]
    [Address(RVA = "0x42BF510", Offset = "0x42BF510", VA = "0x42BF510")]
    public void PlayCloseAnimation(Action<ToasterUI> onComplete)
    {
    }

    [Token(Token = "0x6011C65")]
    [Address(RVA = "0x42BF5C0", Offset = "0x42BF5C0", VA = "0x42BF5C0")]
    private void OnPlayableDirectorStopped(PlayableDirector obj)
    {
    }

    [Token(Token = "0x6011C66")]
    [Address(RVA = "0x42BF5F0", Offset = "0x42BF5F0", VA = "0x42BF5F0")]
    public ToasterUI()
    {
    }
  }
}
