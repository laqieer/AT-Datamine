// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.VignetteComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace UnityEngine.PostProcessing
{
  [Token(Token = "0x2003F6F")]
  public sealed class VignetteComponent : PostProcessingComponentRenderTexture<VignetteModel>
  {
    [Token(Token = "0x1700525E")]
    public override bool active
    {
      [Token(Token = "0x6019959"), Address(RVA = "0x343AC80", Offset = "0x343AC80", VA = "0x343AC80", Slot = "5")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x601995A")]
    [Address(RVA = "0x343ACE8", Offset = "0x343ACE8", VA = "0x343ACE8", Slot = "10")]
    public override void Prepare(Material uberMaterial)
    {
    }

    [Token(Token = "0x601995B")]
    [Address(RVA = "0x343AF7C", Offset = "0x343AF7C", VA = "0x343AF7C")]
    public VignetteComponent()
    {
    }

    [Token(Token = "0x2003F70")]
    private static class Uniforms
    {
      [Token(Token = "0x4011602")]
      [FieldOffset(Offset = "0x0")]
      internal static readonly int _Vignette_Color;
      [Token(Token = "0x4011603")]
      [FieldOffset(Offset = "0x4")]
      internal static readonly int _Vignette_Center;
      [Token(Token = "0x4011604")]
      [FieldOffset(Offset = "0x8")]
      internal static readonly int _Vignette_Settings;
      [Token(Token = "0x4011605")]
      [FieldOffset(Offset = "0xC")]
      internal static readonly int _Vignette_Mask;
      [Token(Token = "0x4011606")]
      [FieldOffset(Offset = "0x10")]
      internal static readonly int _Vignette_Opacity;

      [Token(Token = "0x601995C")]
      [Address(RVA = "0x343AFC4", Offset = "0x343AFC4", VA = "0x343AFC4")]
      static Uniforms()
      {
      }
    }
  }
}
