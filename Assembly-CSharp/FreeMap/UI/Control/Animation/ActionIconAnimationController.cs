// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Control.Animation.ActionIconAnimationController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.UI.Control.Animation
{
  [Token(Token = "0x20016C2")]
  public class ActionIconAnimationController : UIShowAnimationController
  {
    [Token(Token = "0x40065DB")]
    [FieldOffset(Offset = "0x38")]
    protected UIRotationTweenNameList rotationTweenNameList;
    [Token(Token = "0x40065DC")]
    [FieldOffset(Offset = "0x40")]
    private UIAnimationController prefabRotateAnimationController;
    [Token(Token = "0x40065DD")]
    [FieldOffset(Offset = "0x48")]
    private FreeMapUIDirection currentUIDirection;

    [Token(Token = "0x60080AD")]
    [Address(RVA = "0x41F5FD8", Offset = "0x41F5FD8", VA = "0x41F5FD8")]
    public ActionIconAnimationController(
      GameObject actionIconPrefab,
      UIShowTweenNameList showTweenNames,
      UIRotationTweenNameList rotationTweenNames,
      bool isShown)
    {
    }

    [Token(Token = "0x60080AE")]
    [Address(RVA = "0x41F6518", Offset = "0x41F6518", VA = "0x41F6518", Slot = "4")]
    public override void Update()
    {
    }

    [Token(Token = "0x60080AF")]
    [Address(RVA = "0x41F1208", Offset = "0x41F1208", VA = "0x41F1208")]
    public void PlayShowAnimation(FreeMapUIDirection direction)
    {
    }

    [Token(Token = "0x60080B0")]
    [Address(RVA = "0x41F1360", Offset = "0x41F1360", VA = "0x41F1360")]
    public void ChangeDirection(FreeMapUIDirection changeDirection)
    {
    }

    [Token(Token = "0x60080B1")]
    [Address(RVA = "0x41F6564", Offset = "0x41F6564", VA = "0x41F6564")]
    private void ChangeAnimationFromNone(FreeMapUIDirection changeDirection)
    {
    }

    [Token(Token = "0x60080B2")]
    [Address(RVA = "0x41F65C4", Offset = "0x41F65C4", VA = "0x41F65C4")]
    private void ChangeAnimationFromLeftSide()
    {
    }

    [Token(Token = "0x60080B3")]
    [Address(RVA = "0x41F65F0", Offset = "0x41F65F0", VA = "0x41F65F0")]
    private void ChangeAnimationFromRightSide()
    {
    }
  }
}
