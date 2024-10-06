// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.SupportThumbColum
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x200327D")]
  public class SupportThumbColum : MonoBehaviour
  {
    [Token(Token = "0x400D830")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private SupportThumbColum.stSupportThumb[] supportThumbList;

    [Token(Token = "0x1700416E")]
    public SupportThumbColum.stSupportThumb[] supportThumb
    {
      [Token(Token = "0x6013B26"), Address(RVA = "0x1856680", Offset = "0x1856680", VA = "0x1856680")] get
      {
        return (SupportThumbColum.stSupportThumb[]) null;
      }
    }

    [Token(Token = "0x6013B27")]
    [Address(RVA = "0x1856688", Offset = "0x1856688", VA = "0x1856688")]
    public SupportThumbColum()
    {
    }

    [Token(Token = "0x200327E")]
    [Serializable]
    public struct stSupportThumb
    {
      [Token(Token = "0x400D831")]
      [FieldOffset(Offset = "0x0")]
      public UITweenGroup tween;
      [Token(Token = "0x400D832")]
      [FieldOffset(Offset = "0x8")]
      public Text rankText;
      [Token(Token = "0x400D833")]
      [FieldOffset(Offset = "0x10")]
      public GameObject rankMark;
      [Token(Token = "0x400D834")]
      [FieldOffset(Offset = "0x18")]
      public StyleThumb styleThumb;
    }
  }
}
