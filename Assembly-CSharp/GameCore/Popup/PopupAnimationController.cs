// Decompiled with JetBrains decompiler
// Type: GameCore.Popup.PopupAnimationController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace GameCore.Popup
{
  [Token(Token = "0x2000CF6")]
  public class PopupAnimationController : MonoBehaviour
  {
    [Token(Token = "0x40039EF")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x40039F0")]
    [FieldOffset(Offset = "0x20")]
    private UIAnimationController controller;

    [Token(Token = "0x6004A7F")]
    [Address(RVA = "0x313F290", Offset = "0x313F290", VA = "0x313F290")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6004A80")]
    [Address(RVA = "0x313F300", Offset = "0x313F300", VA = "0x313F300")]
    public void PlayOpenAnimation(string groupID = "Open", UnityAction callback = null)
    {
    }

    [Token(Token = "0x6004A81")]
    [Address(RVA = "0x313F41C", Offset = "0x313F41C", VA = "0x313F41C")]
    public void PlayCloseAnimation(string groupID = "Close", UnityAction callback = null)
    {
    }

    [Token(Token = "0x6004A82")]
    [Address(RVA = "0x313F3E4", Offset = "0x313F3E4", VA = "0x313F3E4")]
    public void Show()
    {
    }

    [Token(Token = "0x6004A83")]
    [Address(RVA = "0x313F4F8", Offset = "0x313F4F8", VA = "0x313F4F8")]
    public void Hide()
    {
    }

    [Token(Token = "0x6004A84")]
    [Address(RVA = "0x313F530", Offset = "0x313F530", VA = "0x313F530")]
    private void Update()
    {
    }

    [Token(Token = "0x6004A85")]
    [Address(RVA = "0x313F54C", Offset = "0x313F54C", VA = "0x313F54C")]
    public void AddFinishedCallback(UnityAction callback)
    {
    }

    [Token(Token = "0x6004A86")]
    [Address(RVA = "0x313F568", Offset = "0x313F568", VA = "0x313F568")]
    public void RemoveFinishedCallback(UnityAction callback)
    {
    }

    [Token(Token = "0x6004A87")]
    [Address(RVA = "0x313F584", Offset = "0x313F584", VA = "0x313F584")]
    public PopupAnimationController()
    {
    }
  }
}
