// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.FogComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine.Rendering;

#nullable disable
namespace UnityEngine.PostProcessing
{
  [Token(Token = "0x2003F5C")]
  public sealed class FogComponent : PostProcessingComponentCommandBuffer<FogModel>
  {
    [Token(Token = "0x4011584")]
    private const string k_ShaderString = "Hidden/Post FX/Fog";

    [Token(Token = "0x17005254")]
    public override bool active
    {
      [Token(Token = "0x6019913"), Address(RVA = "0x3434638", Offset = "0x3434638", VA = "0x3434638", Slot = "5")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6019914")]
    [Address(RVA = "0x34346BC", Offset = "0x34346BC", VA = "0x34346BC", Slot = "11")]
    public override string GetName() => (string) null;

    [Token(Token = "0x6019915")]
    [Address(RVA = "0x34346FC", Offset = "0x34346FC", VA = "0x34346FC", Slot = "4")]
    public override DepthTextureMode GetCameraFlags() => new DepthTextureMode();

    [Token(Token = "0x6019916")]
    [Address(RVA = "0x3434704", Offset = "0x3434704", VA = "0x3434704", Slot = "10")]
    public override CameraEvent GetCameraEvent() => new CameraEvent();

    [Token(Token = "0x6019917")]
    [Address(RVA = "0x343470C", Offset = "0x343470C", VA = "0x343470C", Slot = "12")]
    public override void PopulateCommandBuffer(CommandBuffer cb)
    {
    }

    [Token(Token = "0x6019918")]
    [Address(RVA = "0x3434BB4", Offset = "0x3434BB4", VA = "0x3434BB4")]
    public FogComponent()
    {
    }

    [Token(Token = "0x2003F5D")]
    private static class Uniforms
    {
      [Token(Token = "0x4011585")]
      [FieldOffset(Offset = "0x0")]
      internal static readonly int _FogColor;
      [Token(Token = "0x4011586")]
      [FieldOffset(Offset = "0x4")]
      internal static readonly int _Density;
      [Token(Token = "0x4011587")]
      [FieldOffset(Offset = "0x8")]
      internal static readonly int _Start;
      [Token(Token = "0x4011588")]
      [FieldOffset(Offset = "0xC")]
      internal static readonly int _End;
      [Token(Token = "0x4011589")]
      [FieldOffset(Offset = "0x10")]
      internal static readonly int _TempRT;

      [Token(Token = "0x6019919")]
      [Address(RVA = "0x3434BFC", Offset = "0x3434BFC", VA = "0x3434BFC")]
      static Uniforms()
      {
      }
    }
  }
}
