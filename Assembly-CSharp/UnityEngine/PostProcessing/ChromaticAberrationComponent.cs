// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.ChromaticAberrationComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace UnityEngine.PostProcessing
{
  [Token(Token = "0x2003F52")]
  public sealed class ChromaticAberrationComponent : 
    PostProcessingComponentRenderTexture<ChromaticAberrationModel>
  {
    [Token(Token = "0x4011544")]
    [FieldOffset(Offset = "0x20")]
    private Texture2D m_SpectrumLut;

    [Token(Token = "0x1700524F")]
    public override bool active
    {
      [Token(Token = "0x60198DD"), Address(RVA = "0x3430330", Offset = "0x3430330", VA = "0x3430330", Slot = "5")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60198DE")]
    [Address(RVA = "0x34303A4", Offset = "0x34303A4", VA = "0x34303A4", Slot = "7")]
    public override void OnDisable()
    {
    }

    [Token(Token = "0x60198DF")]
    [Address(RVA = "0x34303C0", Offset = "0x34303C0", VA = "0x34303C0", Slot = "10")]
    public override void Prepare(Material uberMaterial)
    {
    }

    [Token(Token = "0x60198E0")]
    [Address(RVA = "0x343063C", Offset = "0x343063C", VA = "0x343063C")]
    public ChromaticAberrationComponent()
    {
    }

    [Token(Token = "0x2003F53")]
    private static class Uniforms
    {
      [Token(Token = "0x4011545")]
      [FieldOffset(Offset = "0x0")]
      internal static readonly int _ChromaticAberration_Amount;
      [Token(Token = "0x4011546")]
      [FieldOffset(Offset = "0x4")]
      internal static readonly int _ChromaticAberration_Spectrum;

      [Token(Token = "0x60198E1")]
      [Address(RVA = "0x3430684", Offset = "0x3430684", VA = "0x3430684")]
      static Uniforms()
      {
      }
    }
  }
}
