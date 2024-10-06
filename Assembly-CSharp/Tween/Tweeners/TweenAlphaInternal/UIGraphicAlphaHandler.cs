// Decompiled with JetBrains decompiler
// Type: Tween.Tweeners.TweenAlphaInternal.UIGraphicAlphaHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine.UI;

#nullable disable
namespace Tween.Tweeners.TweenAlphaInternal
{
  [Token(Token = "0x2000527")]
  public class UIGraphicAlphaHandler : IAlphaHandler
  {
    [Token(Token = "0x4001B4B")]
    [FieldOffset(Offset = "0x10")]
    private Graphic graphic;
    [Token(Token = "0x4001B4C")]
    [FieldOffset(Offset = "0x18")]
    private TweenAlphaOptionRaycast optionRaycast;

    [Token(Token = "0x6001DDA")]
    [Address(RVA = "0x29F7C90", Offset = "0x29F7C90", VA = "0x29F7C90")]
    public UIGraphicAlphaHandler(Graphic graphic, TweenAlphaOptionRaycast optionRaycast)
    {
    }

    [Token(Token = "0x170003F7")]
    public float Alpha
    {
      [Token(Token = "0x6001DDB"), Address(RVA = "0x29FB764", Offset = "0x29FB764", VA = "0x29FB764", Slot = "4")] get
      {
        return new float();
      }
      [Token(Token = "0x6001DDC"), Address(RVA = "0x29FB790", Offset = "0x29FB790", VA = "0x29FB790", Slot = "5")] set
      {
      }
    }

    [Token(Token = "0x6001DDD")]
    [Address(RVA = "0x29FB7EC", Offset = "0x29FB7EC", VA = "0x29FB7EC")]
    private void ModifyRaycast(float alpha)
    {
    }
  }
}
