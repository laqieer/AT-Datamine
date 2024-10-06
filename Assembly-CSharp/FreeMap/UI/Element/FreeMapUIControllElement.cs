// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Element.FreeMapUIControllElement
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
  [Token(Token = "0x20016A7")]
  public class FreeMapUIControllElement
  {
    [Token(Token = "0x170013D3")]
    public GameObject UIObject
    {
      [Token(Token = "0x6008022"), Address(RVA = "0x41F1B58", Offset = "0x41F1B58", VA = "0x41F1B58")] get
      {
        return (GameObject) null;
      }
      [Token(Token = "0x6008023"), Address(RVA = "0x41F1B60", Offset = "0x41F1B60", VA = "0x41F1B60")] protected set
      {
      }
    }

    [Token(Token = "0x170013D4")]
    protected IFreeMapUIPositionController transformController
    {
      [Token(Token = "0x6008024"), Address(RVA = "0x41F1B68", Offset = "0x41F1B68", VA = "0x41F1B68")] get
      {
        return (IFreeMapUIPositionController) null;
      }
      [Token(Token = "0x6008025"), Address(RVA = "0x41F1B70", Offset = "0x41F1B70", VA = "0x41F1B70")] set
      {
      }
    }

    [Token(Token = "0x170013D5")]
    protected UIShowAnimationController animationController
    {
      [Token(Token = "0x6008026"), Address(RVA = "0x41F1B78", Offset = "0x41F1B78", VA = "0x41F1B78")] get
      {
        return (UIShowAnimationController) null;
      }
      [Token(Token = "0x6008027"), Address(RVA = "0x41F1B80", Offset = "0x41F1B80", VA = "0x41F1B80")] set
      {
      }
    }

    [Token(Token = "0x170013D6")]
    public FreeMapUIDirection CurrentDirection
    {
      [Token(Token = "0x6008028"), Address(RVA = "0x41EF504", Offset = "0x41EF504", VA = "0x41EF504")] get
      {
        return new FreeMapUIDirection();
      }
    }

    [Token(Token = "0x170013D7")]
    public RectTransform ControlRectTransform
    {
      [Token(Token = "0x6008029"), Address(RVA = "0x41F1B88", Offset = "0x41F1B88", VA = "0x41F1B88")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x170013D8")]
    public RectTransform OverlapRectTransform
    {
      [Token(Token = "0x600802A"), Address(RVA = "0x41F1C2C", Offset = "0x41F1C2C", VA = "0x41F1C2C")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x170013D9")]
    public bool IsShown
    {
      [Token(Token = "0x600802B"), Address(RVA = "0x41F1CD0", Offset = "0x41F1CD0", VA = "0x41F1CD0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600802C"), Address(RVA = "0x41F1CD8", Offset = "0x41F1CD8", VA = "0x41F1CD8")] protected set
      {
      }
    }

    [Token(Token = "0x600802D")]
    [Address(RVA = "0x41F14B8", Offset = "0x41F14B8", VA = "0x41F14B8")]
    public FreeMapUIControllElement(
      GameObject prefab,
      IFreeMapUIPositionController transformController,
      UIShowAnimationController animationController,
      bool isShown)
    {
    }

    [Token(Token = "0x600802E")]
    [Address(RVA = "0x41F1500", Offset = "0x41F1500", VA = "0x41F1500")]
    public FreeMapUIControllElement(FreeMapUIControllElement element)
    {
    }

    [Token(Token = "0x600802F")]
    [Address(RVA = "0x41EF81C", Offset = "0x41EF81C", VA = "0x41EF81C")]
    public void DestroyElement()
    {
    }

    [Token(Token = "0x6008030")]
    [Address(RVA = "0x41F1CE4", Offset = "0x41F1CE4", VA = "0x41F1CE4")]
    public void SetAnimation(UIShowAnimationController animation)
    {
    }

    [Token(Token = "0x6008031")]
    [Address(RVA = "0x41EFBF8", Offset = "0x41EFBF8", VA = "0x41EFBF8")]
    public void UpdateAnimation()
    {
    }

    [Token(Token = "0x6008032")]
    [Address(RVA = "0x41F0BE4", Offset = "0x41F0BE4", VA = "0x41F0BE4")]
    public void HideUI()
    {
    }

    [Token(Token = "0x6008033")]
    [Address(RVA = "0x41F1CEC", Offset = "0x41F1CEC", VA = "0x41F1CEC", Slot = "4")]
    public virtual void ShowUI()
    {
    }

    [Token(Token = "0x6008034")]
    [Address(RVA = "0x41EFC4C", Offset = "0x41EFC4C", VA = "0x41EFC4C")]
    public void TransparentAlpha(float toAlpha)
    {
    }

    [Token(Token = "0x6008035")]
    [Address(RVA = "0x41EF9E0", Offset = "0x41EF9E0", VA = "0x41EF9E0")]
    public void UpdateRectTransform(
      Camera usingCamera,
      FreeMapUICanvas uiCanvas,
      UITransformAvoidHandler avoidHandler)
    {
    }

    [Token(Token = "0x6008036")]
    [Address(RVA = "0x41EFDFC", Offset = "0x41EFDFC", VA = "0x41EFDFC")]
    public void ChangeSprite(string targetObjectName, Sprite sprite)
    {
    }

    [Token(Token = "0x6008037")]
    [Address(RVA = "0x41F0140", Offset = "0x41F0140", VA = "0x41F0140")]
    public void SetPurposeMarkIconDisplay(bool visible)
    {
    }
  }
}
