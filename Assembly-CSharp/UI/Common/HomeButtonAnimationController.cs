// Decompiled with JetBrains decompiler
// Type: UI.Common.HomeButtonAnimationController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace UI.Common
{
  [Token(Token = "0x2000916")]
  public class HomeButtonAnimationController : MonoBehaviour
  {
    [Token(Token = "0x4002A68")]
    [FieldOffset(Offset = "0x18")]
    [Header("アニメーション制御")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x4002A69")]
    [FieldOffset(Offset = "0x20")]
    [Header("In アニメーションのキー")]
    [SerializeField]
    private string InAnimationKey;
    [Token(Token = "0x4002A6A")]
    [FieldOffset(Offset = "0x28")]
    [Header("Out アニメーションのキー")]
    [SerializeField]
    private string OutAnimationKey;
    [Token(Token = "0x4002A6B")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    [Header("デフォルトの表示状態")]
    private bool DefaultVisible;

    [Token(Token = "0x17000765")]
    public bool IsVisible
    {
      [Token(Token = "0x600333B"), Address(RVA = "0x3625DE8", Offset = "0x3625DE8", VA = "0x3625DE8")] get
      {
        return new bool();
      }
      [Token(Token = "0x600333C"), Address(RVA = "0x3625DF0", Offset = "0x3625DF0", VA = "0x3625DF0")] private set
      {
      }
    }

    [Token(Token = "0x600333D")]
    [Address(RVA = "0x3625DFC", Offset = "0x3625DFC", VA = "0x3625DFC")]
    private void Awake()
    {
    }

    [Token(Token = "0x600333E")]
    [Address(RVA = "0x3625E08", Offset = "0x3625E08", VA = "0x3625E08")]
    public void PlayInAnimation(Action onFinished = null)
    {
    }

    [Token(Token = "0x600333F")]
    [Address(RVA = "0x3625EE0", Offset = "0x3625EE0", VA = "0x3625EE0")]
    public void PlayOutAnimation(Action onFinished = null)
    {
    }

    [Token(Token = "0x6003340")]
    [Address(RVA = "0x3625FBC", Offset = "0x3625FBC", VA = "0x3625FBC")]
    public HomeButtonAnimationController()
    {
    }
  }
}
