// Decompiled with JetBrains decompiler
// Type: Battle.Unit.CharacterActorMaterialController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Battle.Unit
{
  [Token(Token = "0x20022E5")]
  public sealed class CharacterActorMaterialController
  {
    [Token(Token = "0x4009396")]
    [FieldOffset(Offset = "0x0")]
    private static readonly List<(string propertyName, CharacterActorMaterialController.ShaderProperty propertyEnum, int propertyId)> propertyInformations;
    [Token(Token = "0x4009397")]
    [FieldOffset(Offset = "0x10")]
    private bool initialized;
    [Token(Token = "0x4009398")]
    [FieldOffset(Offset = "0x18")]
    private Renderer[] targetRenderers;
    [Token(Token = "0x4009399")]
    [FieldOffset(Offset = "0x20")]
    private MaterialPropertyBlock materialProperty;
    [Token(Token = "0x400939A")]
    [FieldOffset(Offset = "0x28")]
    private CharacterActorMaterialController.ShaderParameter shaderParameter;
    [Token(Token = "0x400939B")]
    [FieldOffset(Offset = "0x30")]
    private CharacterActorMaterialController.ShaderParameter resetShaderParameter;

    [Token(Token = "0x600D553")]
    [Address(RVA = "0x1D143E0", Offset = "0x1D143E0", VA = "0x1D143E0")]
    public void Initialize(Renderer[] targetRenderers)
    {
    }

    [Token(Token = "0x600D554")]
    [Address(RVA = "0x1D14654", Offset = "0x1D14654", VA = "0x1D14654")]
    public void SetColor(Color color)
    {
    }

    [Token(Token = "0x600D555")]
    [Address(RVA = "0x1D14688", Offset = "0x1D14688", VA = "0x1D14688")]
    public void SetMonochrome(float enable)
    {
    }

    [Token(Token = "0x600D556")]
    [Address(RVA = "0x1D146B0", Offset = "0x1D146B0", VA = "0x1D146B0")]
    public void SetHardlightBlend(float blend)
    {
    }

    [Token(Token = "0x600D557")]
    [Address(RVA = "0x1D146D8", Offset = "0x1D146D8", VA = "0x1D146D8")]
    public void SetHardlightColor(Color color)
    {
    }

    [Token(Token = "0x600D558")]
    [Address(RVA = "0x1D1470C", Offset = "0x1D1470C", VA = "0x1D1470C")]
    public Color GetColor() => new Color();

    [Token(Token = "0x600D559")]
    [Address(RVA = "0x1D1472C", Offset = "0x1D1472C", VA = "0x1D1472C")]
    public void Reset(int parameterTypeDirty = -1)
    {
    }

    [Token(Token = "0x600D55A")]
    [Address(RVA = "0x1D147FC", Offset = "0x1D147FC", VA = "0x1D147FC")]
    public void ForceModified()
    {
    }

    [Token(Token = "0x600D55B")]
    [Address(RVA = "0x1D14968", Offset = "0x1D14968", VA = "0x1D14968")]
    public void Apply()
    {
    }

    [Token(Token = "0x600D55C")]
    [Address(RVA = "0x1D14C80", Offset = "0x1D14C80", VA = "0x1D14C80")]
    public CharacterActorMaterialController()
    {
    }

    [Token(Token = "0x600D55D")]
    [Address(RVA = "0x1D14D80", Offset = "0x1D14D80", VA = "0x1D14D80")]
    static CharacterActorMaterialController()
    {
    }

    [Token(Token = "0x20022E6")]
    public enum ShaderProperty
    {
      [Token(Token = "0x400939D")] Color = 1,
      [Token(Token = "0x400939E")] Monochrome = 2,
      [Token(Token = "0x400939F")] HardlightBlendDot = 4,
      [Token(Token = "0x40093A0")] HardlightBlendColorDot = 8,
    }

    [Token(Token = "0x20022E7")]
    private class ShaderParameter
    {
      [Token(Token = "0x40093A1")]
      [FieldOffset(Offset = "0x10")]
      public int Dirty;
      [Token(Token = "0x40093A2")]
      [FieldOffset(Offset = "0x14")]
      public Color Color;
      [Token(Token = "0x40093A3")]
      [FieldOffset(Offset = "0x24")]
      public float Monochrome;
      [Token(Token = "0x40093A4")]
      [FieldOffset(Offset = "0x28")]
      public float HardlightBlendDot;
      [Token(Token = "0x40093A5")]
      [FieldOffset(Offset = "0x2C")]
      public Color HardlightBlendColorDot;

      [Token(Token = "0x600D55E")]
      [Address(RVA = "0x1D14D4C", Offset = "0x1D14D4C", VA = "0x1D14D4C")]
      public ShaderParameter()
      {
      }
    }
  }
}
