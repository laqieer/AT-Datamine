// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.GrainComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace UnityEngine.PostProcessing
{
  [Token(Token = "0x2003F60")]
  public sealed class GrainComponent : PostProcessingComponentRenderTexture<GrainModel>
  {
    [Token(Token = "0x401158C")]
    [FieldOffset(Offset = "0x20")]
    private RenderTexture m_GrainLookupRT;

    [Token(Token = "0x17005256")]
    public override bool active
    {
      [Token(Token = "0x601991E"), Address(RVA = "0x3435078", Offset = "0x3435078", VA = "0x3435078", Slot = "5")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x601991F")]
    [Address(RVA = "0x34350FC", Offset = "0x34350FC", VA = "0x34350FC", Slot = "7")]
    public override void OnDisable()
    {
    }

    [Token(Token = "0x6019920")]
    [Address(RVA = "0x3435118", Offset = "0x3435118", VA = "0x3435118", Slot = "10")]
    public override void Prepare(Material uberMaterial)
    {
    }

    [Token(Token = "0x6019921")]
    [Address(RVA = "0x34354A4", Offset = "0x34354A4", VA = "0x34354A4")]
    public GrainComponent()
    {
    }

    [Token(Token = "0x2003F61")]
    private static class Uniforms
    {
      [Token(Token = "0x401158D")]
      [FieldOffset(Offset = "0x0")]
      internal static readonly int _Grain_Params1;
      [Token(Token = "0x401158E")]
      [FieldOffset(Offset = "0x4")]
      internal static readonly int _Grain_Params2;
      [Token(Token = "0x401158F")]
      [FieldOffset(Offset = "0x8")]
      internal static readonly int _GrainTex;
      [Token(Token = "0x4011590")]
      [FieldOffset(Offset = "0xC")]
      internal static readonly int _Phase;

      [Token(Token = "0x6019922")]
      [Address(RVA = "0x34354EC", Offset = "0x34354EC", VA = "0x34354EC")]
      static Uniforms()
      {
      }
    }
  }
}
