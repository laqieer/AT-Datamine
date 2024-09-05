// Decompiled with JetBrains decompiler
// Type: GameCore.UIControls.AlertUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace GameCore.UIControls
{
  [Token(Token = "0x2000BE3")]
  public sealed class AlertUI : MonoBehaviour
  {
    [Token(Token = "0x40035F6")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x40035F7")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text message;
    [Token(Token = "0x40035F8")]
    [FieldOffset(Offset = "0x28")]
    private UIAnimationController controller;
    [Token(Token = "0x40035F9")]
    [FieldOffset(Offset = "0x30")]
    private AlertUI.IAlertEvent listener;

    [Token(Token = "0x60043E7")]
    [Address(RVA = "0x3644AFC", Offset = "0x3644AFC", VA = "0x3644AFC")]
    public void Initialize()
    {
    }

    [Token(Token = "0x60043E8")]
    [Address(RVA = "0x3644B64", Offset = "0x3644B64", VA = "0x3644B64")]
    public void Register(AlertUI.IAlertEvent listener)
    {
    }

    [Token(Token = "0x60043E9")]
    [Address(RVA = "0x3644B6C", Offset = "0x3644B6C", VA = "0x3644B6C")]
    public void Set(string text)
    {
    }

    [Token(Token = "0x60043EA")]
    [Address(RVA = "0x3644B90", Offset = "0x3644B90", VA = "0x3644B90")]
    public void Play()
    {
    }

    [Token(Token = "0x60043EB")]
    [Address(RVA = "0x3644BE8", Offset = "0x3644BE8", VA = "0x3644BE8")]
    public AlertUI()
    {
    }

    [Token(Token = "0x2000BE4")]
    public interface IAlertEvent
    {
      [Token(Token = "0x60043EC")]
      void OnFinish();
    }
  }
}
