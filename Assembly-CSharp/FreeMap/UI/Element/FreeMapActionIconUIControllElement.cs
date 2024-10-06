// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Element.FreeMapActionIconUIControllElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.UI.Control.Animation;
using FreeMap.UI.Control.Position;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.UI.Element
{
  [Token(Token = "0x20016A3")]
  public class FreeMapActionIconUIControllElement : FreeMapButtonUIControllElement
  {
    [Token(Token = "0x6007FF7")]
    [Address(RVA = "0x41F1048", Offset = "0x41F1048", VA = "0x41F1048")]
    private ActionIconAnimationController GetAnimeController()
    {
      return (ActionIconAnimationController) null;
    }

    [Token(Token = "0x6007FF8")]
    [Address(RVA = "0x41F10C0", Offset = "0x41F10C0", VA = "0x41F10C0")]
    public FreeMapActionIconUIControllElement(
      GameObject prefab,
      IFreeMapUIPositionController transformController,
      ActionIconAnimationController animationController,
      string buttonObjectName,
      bool isShown)
    {
    }

    [Token(Token = "0x6007FF9")]
    [Address(RVA = "0x41F1190", Offset = "0x41F1190", VA = "0x41F1190")]
    public FreeMapActionIconUIControllElement(FreeMapButtonUIControllElement element)
    {
    }

    [Token(Token = "0x6007FFA")]
    [Address(RVA = "0x41F11C4", Offset = "0x41F11C4", VA = "0x41F11C4", Slot = "4")]
    public override void ShowUI()
    {
    }

    [Token(Token = "0x6007FFB")]
    [Address(RVA = "0x41EFBD8", Offset = "0x41EFBD8", VA = "0x41EFBD8")]
    public void ChangeDirection(FreeMapUIDirection changeDirection)
    {
    }

    [Token(Token = "0x6007FFC")]
    [Address(RVA = "0x41F13D8", Offset = "0x41F13D8", VA = "0x41F13D8")]
    public void SetDirection(FreeMapUIDirection direction)
    {
    }
  }
}
