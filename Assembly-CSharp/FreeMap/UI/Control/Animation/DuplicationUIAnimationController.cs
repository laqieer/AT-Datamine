// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Control.Animation.DuplicationUIAnimationController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.UI.Control.Animation
{
  [Token(Token = "0x20016C4")]
  public class DuplicationUIAnimationController : UIShowAnimationController
  {
    [Token(Token = "0x40065E1")]
    [FieldOffset(Offset = "0x38")]
    private DuplicationUIAnimationController.DuplicationDirection duplicationDirection;
    [Token(Token = "0x40065E2")]
    [FieldOffset(Offset = "0x40")]
    private DuplicationUIRotationTweenNameList duplicationTweenNameList;
    [Token(Token = "0x40065E3")]
    [FieldOffset(Offset = "0x48")]
    private UIAnimationController prefabDuplicationAnimationController;

    [Token(Token = "0x60080BC")]
    [Address(RVA = "0x41F6740", Offset = "0x41F6740", VA = "0x41F6740")]
    public DuplicationUIAnimationController(
      GameObject showUIPrefab,
      UIShowTweenNameList tweenNameList,
      DuplicationUIRotationTweenNameList duplicationTweenNameList,
      DuplicationUIAnimationController.DuplicationDirection direction,
      bool isShown = false)
    {
    }

    [Token(Token = "0x60080BD")]
    [Address(RVA = "0x41F6868", Offset = "0x41F6868", VA = "0x41F6868", Slot = "5")]
    public override void PlayShowAnimation()
    {
    }

    [Token(Token = "0x60080BE")]
    [Address(RVA = "0x41F6914", Offset = "0x41F6914", VA = "0x41F6914", Slot = "6")]
    public override void PlayHideAnimation()
    {
    }

    [Token(Token = "0x20016C5")]
    public enum DuplicationDirection
    {
      [Token(Token = "0x40065E5")] Left,
      [Token(Token = "0x40065E6")] Right,
    }
  }
}
