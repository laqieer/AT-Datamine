// Decompiled with JetBrains decompiler
// Type: Area.FadeContent.AreaFadeElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Area.FadeContent
{
  [Token(Token = "0x2002851")]
  public class AreaFadeElement : IAreaFadeElement
  {
    [Token(Token = "0x400ABDC")]
    [FieldOffset(Offset = "0x10")]
    private List<AreaFadeElement.FadeMaterial> fadeMaterialList;
    [Token(Token = "0x400ABDD")]
    [FieldOffset(Offset = "0x18")]
    protected Renderer fadeRenderer;
    [Token(Token = "0x400ABDE")]
    protected const string FadeAlphaStateName = "_FadeAlpha";
    [Token(Token = "0x400ABDF")]
    protected const float FadeInAlpha = 1f;
    [Token(Token = "0x400ABE0")]
    protected const float FadeOutAlpha = 0.0f;
    [Token(Token = "0x400ABE1")]
    protected const int UndefinedFadeAlphaIndex = -1;

    [Token(Token = "0x600FDF1")]
    [Address(RVA = "0x4430E04", Offset = "0x4430E04", VA = "0x4430E04")]
    public AreaFadeElement(Renderer renderer)
    {
    }

    [Token(Token = "0x600FDF2")]
    [Address(RVA = "0x443323C", Offset = "0x443323C", VA = "0x443323C")]
    protected void SetFadeAlphaInternal(float ratio)
    {
    }

    [Token(Token = "0x600FDF3")]
    [Address(RVA = "0x44333C8", Offset = "0x44333C8", VA = "0x44333C8", Slot = "4")]
    public void SetFade(float ratio)
    {
    }

    [Token(Token = "0x600FDF4")]
    [Address(RVA = "0x44333CC", Offset = "0x44333CC", VA = "0x44333CC", Slot = "5")]
    public void SetInvisible()
    {
    }

    [Token(Token = "0x600FDF5")]
    [Address(RVA = "0x44333D4", Offset = "0x44333D4", VA = "0x44333D4", Slot = "6")]
    public void SetShown()
    {
    }

    [Token(Token = "0x600FDF6")]
    [Address(RVA = "0x44333DC", Offset = "0x44333DC", VA = "0x44333DC", Slot = "7")]
    public void SetEnableRenderer(bool enable)
    {
    }

    [Token(Token = "0x600FDF7")]
    [Address(RVA = "0x44333FC", Offset = "0x44333FC", VA = "0x44333FC", Slot = "8")]
    public void Destroy()
    {
    }

    [Token(Token = "0x2002852")]
    protected class FadeMaterial
    {
      [Token(Token = "0x170037EC")]
      public bool IsConfiguable
      {
        [Token(Token = "0x600FDF8"), Address(RVA = "0x44335D8", Offset = "0x44335D8", VA = "0x44335D8")] get
        {
          return new bool();
        }
        [Token(Token = "0x600FDF9"), Address(RVA = "0x44335E0", Offset = "0x44335E0", VA = "0x44335E0")] set
        {
        }
      }

      [Token(Token = "0x170037ED")]
      public Material InstanceMaterial
      {
        [Token(Token = "0x600FDFA"), Address(RVA = "0x44335EC", Offset = "0x44335EC", VA = "0x44335EC")] get
        {
          return (Material) null;
        }
        [Token(Token = "0x600FDFB"), Address(RVA = "0x44335F4", Offset = "0x44335F4", VA = "0x44335F4")] set
        {
        }
      }

      [Token(Token = "0x600FDFC")]
      [Address(RVA = "0x44331B8", Offset = "0x44331B8", VA = "0x44331B8")]
      public FadeMaterial(Material material)
      {
      }

      [Token(Token = "0x600FDFD")]
      [Address(RVA = "0x443357C", Offset = "0x443357C", VA = "0x443357C")]
      public void Destroy()
      {
      }
    }
  }
}
