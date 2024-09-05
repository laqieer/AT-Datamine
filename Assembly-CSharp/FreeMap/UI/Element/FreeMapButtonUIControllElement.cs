// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Element.FreeMapButtonUIControllElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.UI.Control.Animation;
using FreeMap.UI.Control.Position;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace FreeMap.UI.Element
{
  [Token(Token = "0x20016A4")]
  public class FreeMapButtonUIControllElement : FreeMapUIControllElement
  {
    [Token(Token = "0x170013C8")]
    protected Button uiButton
    {
      [Token(Token = "0x6007FFD"), Address(RVA = "0x41F14A8", Offset = "0x41F14A8", VA = "0x41F14A8")] get
      {
        return (Button) null;
      }
      [Token(Token = "0x6007FFE"), Address(RVA = "0x41F14B0", Offset = "0x41F14B0", VA = "0x41F14B0")] set
      {
      }
    }

    [Token(Token = "0x6007FFF")]
    [Address(RVA = "0x41F1128", Offset = "0x41F1128", VA = "0x41F1128")]
    public FreeMapButtonUIControllElement(
      GameObject prefab,
      IFreeMapUIPositionController transformController,
      UIShowAnimationController animationController,
      string buttonObjectName,
      bool isShown)
    {
    }

    [Token(Token = "0x6008000")]
    [Address(RVA = "0x41F1194", Offset = "0x41F1194", VA = "0x41F1194")]
    public FreeMapButtonUIControllElement(FreeMapButtonUIControllElement element)
    {
    }

    [Token(Token = "0x6008001")]
    [Address(RVA = "0x41F1544", Offset = "0x41F1544", VA = "0x41F1544")]
    public void AddButtonListener(UnityAction action)
    {
    }

    [Token(Token = "0x6008002")]
    [Address(RVA = "0x41EFF80", Offset = "0x41EFF80", VA = "0x41EFF80")]
    public void InvokeButtonClickEvent()
    {
    }
  }
}
