// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Armoury.GridChangeButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Armoury
{
  [Token(Token = "0x200381E")]
  public class GridChangeButton : MonoBehaviour
  {
    [Token(Token = "0x400F4DA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CommonButton button;
    [Token(Token = "0x400F4DB")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private UITweenGroup tween;
    [Token(Token = "0x400F4DC")]
    private const string TweenInName = "In";
    [Token(Token = "0x400F4DD")]
    private const string TweenOutName = "Out";
    [Token(Token = "0x400F4DE")]
    [FieldOffset(Offset = "0x28")]
    private Action _onClickAction;

    [Token(Token = "0x170048DF")]
    public bool IsActive
    {
      [Token(Token = "0x60160EF"), Address(RVA = "0x20EF2B8", Offset = "0x20EF2B8", VA = "0x20EF2B8")] get
      {
        return new bool();
      }
      [Token(Token = "0x60160F0"), Address(RVA = "0x20EF2C0", Offset = "0x20EF2C0", VA = "0x20EF2C0")] private set
      {
      }
    }

    [Token(Token = "0x60160F1")]
    [Address(RVA = "0x20ED33C", Offset = "0x20ED33C", VA = "0x20ED33C")]
    public void Initialize()
    {
    }

    [Token(Token = "0x60160F2")]
    [Address(RVA = "0x20ED4D4", Offset = "0x20ED4D4", VA = "0x20ED4D4")]
    public void Enable(Action action = null)
    {
    }

    [Token(Token = "0x60160F3")]
    [Address(RVA = "0x20EF2CC", Offset = "0x20EF2CC", VA = "0x20EF2CC")]
    public void SetAction(Action action)
    {
    }

    [Token(Token = "0x60160F4")]
    [Address(RVA = "0x20ED560", Offset = "0x20ED560", VA = "0x20ED560")]
    public void Disable()
    {
    }

    [Token(Token = "0x60160F5")]
    [Address(RVA = "0x20EF2D4", Offset = "0x20EF2D4", VA = "0x20EF2D4")]
    private void OnClick()
    {
    }

    [Token(Token = "0x60160F6")]
    [Address(RVA = "0x20EF2F0", Offset = "0x20EF2F0", VA = "0x20EF2F0")]
    public GridChangeButton()
    {
    }
  }
}
