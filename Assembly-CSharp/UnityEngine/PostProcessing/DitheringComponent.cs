// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.DitheringComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace UnityEngine.PostProcessing
{
  [Token(Token = "0x2003F58")]
  public sealed class DitheringComponent : PostProcessingComponentRenderTexture<DitheringModel>
  {
    [Token(Token = "0x401156E")]
    [FieldOffset(Offset = "0x20")]
    private Texture2D[] noiseTextures;
    [Token(Token = "0x401156F")]
    [FieldOffset(Offset = "0x28")]
    private int textureIndex;
    [Token(Token = "0x4011570")]
    private const int k_TextureCount = 64;

    [Token(Token = "0x17005252")]
    public override bool active
    {
      [Token(Token = "0x6019904"), Address(RVA = "0x3433258", Offset = "0x3433258", VA = "0x3433258", Slot = "5")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6019905")]
    [Address(RVA = "0x34332C0", Offset = "0x34332C0", VA = "0x34332C0", Slot = "7")]
    public override void OnDisable()
    {
    }

    [Token(Token = "0x6019906")]
    [Address(RVA = "0x34332C8", Offset = "0x34332C8", VA = "0x34332C8")]
    private void LoadNoiseTextures()
    {
    }

    [Token(Token = "0x6019907")]
    [Address(RVA = "0x3433414", Offset = "0x3433414", VA = "0x3433414", Slot = "10")]
    public override void Prepare(Material uberMaterial)
    {
    }

    [Token(Token = "0x6019908")]
    [Address(RVA = "0x34335C0", Offset = "0x34335C0", VA = "0x34335C0")]
    public DitheringComponent()
    {
    }

    [Token(Token = "0x2003F59")]
    private static class Uniforms
    {
      [Token(Token = "0x4011571")]
      [FieldOffset(Offset = "0x0")]
      internal static readonly int _DitheringTex;
      [Token(Token = "0x4011572")]
      [FieldOffset(Offset = "0x4")]
      internal static readonly int _DitheringCoords;

      [Token(Token = "0x6019909")]
      [Address(RVA = "0x3433608", Offset = "0x3433608", VA = "0x3433608")]
      static Uniforms()
      {
      }
    }
  }
}
