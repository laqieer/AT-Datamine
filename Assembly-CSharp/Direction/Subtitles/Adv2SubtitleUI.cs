// Decompiled with JetBrains decompiler
// Type: Direction.Subtitles.Adv2SubtitleUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using ADV2;
using GameCore.Tween;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Direction.Subtitles
{
  [Token(Token = "0x2001F22")]
  public class Adv2SubtitleUI : MonoBehaviour, ISubtitleUI
  {
    [Token(Token = "0x4008584")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string linkUIPath;
    [Token(Token = "0x4008585")]
    [FieldOffset(Offset = "0x20")]
    private Adv2UiLinker linker;
    [Token(Token = "0x4008586")]
    [FieldOffset(Offset = "0x28")]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x4008587")]
    [FieldOffset(Offset = "0x30")]
    private bool nowActive;
    [Token(Token = "0x4008588")]
    [FieldOffset(Offset = "0x38")]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x4008589")]
    [FieldOffset(Offset = "0x40")]
    private float saveAlpha;
    [Token(Token = "0x400858A")]
    [FieldOffset(Offset = "0x44")]
    public bool firstPlayFlag;

    [Token(Token = "0x600B8DE")]
    [Address(RVA = "0x2137A18", Offset = "0x2137A18", VA = "0x2137A18", Slot = "4")]
    public void Init()
    {
    }

    [Token(Token = "0x600B8DF")]
    [Address(RVA = "0x2137D68", Offset = "0x2137D68", VA = "0x2137D68", Slot = "5")]
    public void SetActive(bool isActive)
    {
    }

    [Token(Token = "0x600B8E0")]
    [Address(RVA = "0x2138108", Offset = "0x2138108", VA = "0x2138108", Slot = "6")]
    public void SetSubtitle(string subtitle)
    {
    }

    [Token(Token = "0x600B8E1")]
    [Address(RVA = "0x2138170", Offset = "0x2138170", VA = "0x2138170", Slot = "7")]
    public void SetTalkerAndSubtitle(string talker, string subtitle)
    {
    }

    [Token(Token = "0x600B8E2")]
    [Address(RVA = "0x21382A8", Offset = "0x21382A8", VA = "0x21382A8")]
    public void SetWindowAlpha(float alpha)
    {
    }

    [Token(Token = "0x600B8E3")]
    [Address(RVA = "0x2138340", Offset = "0x2138340", VA = "0x2138340")]
    public void SaveWindowAlpha()
    {
    }

    [Token(Token = "0x600B8E4")]
    [Address(RVA = "0x21383C0", Offset = "0x21383C0", VA = "0x21383C0")]
    public void ResetWindowAlpha()
    {
    }

    [Token(Token = "0x600B8E5")]
    [Address(RVA = "0x2138444", Offset = "0x2138444", VA = "0x2138444")]
    public Adv2SubtitleUI()
    {
    }
  }
}
