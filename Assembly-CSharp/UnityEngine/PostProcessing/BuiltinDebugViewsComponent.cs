// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.BuiltinDebugViewsComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine.Rendering;

#nullable disable
namespace UnityEngine.PostProcessing
{
  [Token(Token = "0x2003F4E")]
  public sealed class BuiltinDebugViewsComponent : 
    PostProcessingComponentCommandBuffer<BuiltinDebugViewsModel>
  {
    [Token(Token = "0x4011532")]
    private const string k_ShaderString = "Hidden/Post FX/Builtin Debug Views";
    [Token(Token = "0x4011533")]
    [FieldOffset(Offset = "0x20")]
    private BuiltinDebugViewsComponent.ArrowArray m_Arrows;

    [Token(Token = "0x1700524B")]
    public override bool active
    {
      [Token(Token = "0x60198C8"), Address(RVA = "0x342F0F4", Offset = "0x342F0F4", VA = "0x342F0F4", Slot = "5")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60198C9")]
    [Address(RVA = "0x342F168", Offset = "0x342F168", VA = "0x342F168", Slot = "4")]
    public override DepthTextureMode GetCameraFlags() => new DepthTextureMode();

    [Token(Token = "0x60198CA")]
    [Address(RVA = "0x342F1D0", Offset = "0x342F1D0", VA = "0x342F1D0", Slot = "10")]
    public override CameraEvent GetCameraEvent() => new CameraEvent();

    [Token(Token = "0x60198CB")]
    [Address(RVA = "0x342F228", Offset = "0x342F228", VA = "0x342F228", Slot = "11")]
    public override string GetName() => (string) null;

    [Token(Token = "0x60198CC")]
    [Address(RVA = "0x342F268", Offset = "0x342F268", VA = "0x342F268", Slot = "12")]
    public override void PopulateCommandBuffer(CommandBuffer cb)
    {
    }

    [Token(Token = "0x60198CD")]
    [Address(RVA = "0x342F3B0", Offset = "0x342F3B0", VA = "0x342F3B0")]
    private void DepthPass(CommandBuffer cb)
    {
    }

    [Token(Token = "0x60198CE")]
    [Address(RVA = "0x342F4C8", Offset = "0x342F4C8", VA = "0x342F4C8")]
    private void DepthNormalsPass(CommandBuffer cb)
    {
    }

    [Token(Token = "0x60198CF")]
    [Address(RVA = "0x342F58C", Offset = "0x342F58C", VA = "0x342F58C")]
    private void MotionVectorsPass(CommandBuffer cb)
    {
    }

    [Token(Token = "0x60198D0")]
    [Address(RVA = "0x342FB44", Offset = "0x342FB44", VA = "0x342FB44")]
    private void PrepareArrows()
    {
    }

    [Token(Token = "0x60198D1")]
    [Address(RVA = "0x3430078", Offset = "0x3430078", VA = "0x3430078", Slot = "7")]
    public override void OnDisable()
    {
    }

    [Token(Token = "0x60198D2")]
    [Address(RVA = "0x34300A8", Offset = "0x34300A8", VA = "0x34300A8")]
    public BuiltinDebugViewsComponent()
    {
    }

    [Token(Token = "0x2003F4F")]
    private static class Uniforms
    {
      [Token(Token = "0x4011534")]
      [FieldOffset(Offset = "0x0")]
      internal static readonly int _DepthScale;
      [Token(Token = "0x4011535")]
      [FieldOffset(Offset = "0x4")]
      internal static readonly int _TempRT;
      [Token(Token = "0x4011536")]
      [FieldOffset(Offset = "0x8")]
      internal static readonly int _Opacity;
      [Token(Token = "0x4011537")]
      [FieldOffset(Offset = "0xC")]
      internal static readonly int _MainTex;
      [Token(Token = "0x4011538")]
      [FieldOffset(Offset = "0x10")]
      internal static readonly int _TempRT2;
      [Token(Token = "0x4011539")]
      [FieldOffset(Offset = "0x14")]
      internal static readonly int _Amplitude;
      [Token(Token = "0x401153A")]
      [FieldOffset(Offset = "0x18")]
      internal static readonly int _Scale;

      [Token(Token = "0x60198D3")]
      [Address(RVA = "0x34300F0", Offset = "0x34300F0", VA = "0x34300F0")]
      static Uniforms()
      {
      }
    }

    [Token(Token = "0x2003F50")]
    private enum Pass
    {
      [Token(Token = "0x401153C")] Depth,
      [Token(Token = "0x401153D")] Normals,
      [Token(Token = "0x401153E")] MovecOpacity,
      [Token(Token = "0x401153F")] MovecImaging,
      [Token(Token = "0x4011540")] MovecArrows,
    }

    [Token(Token = "0x2003F51")]
    private class ArrowArray
    {
      [Token(Token = "0x1700524C")]
      public Mesh mesh
      {
        [Token(Token = "0x60198D4"), Address(RVA = "0x3430278", Offset = "0x3430278", VA = "0x3430278")] get
        {
          return (Mesh) null;
        }
        [Token(Token = "0x60198D5"), Address(RVA = "0x3430280", Offset = "0x3430280", VA = "0x3430280")] private set
        {
        }
      }

      [Token(Token = "0x1700524D")]
      public int columnCount
      {
        [Token(Token = "0x60198D6"), Address(RVA = "0x3430288", Offset = "0x3430288", VA = "0x3430288")] get
        {
          return new int();
        }
        [Token(Token = "0x60198D7"), Address(RVA = "0x3430290", Offset = "0x3430290", VA = "0x3430290")] private set
        {
        }
      }

      [Token(Token = "0x1700524E")]
      public int rowCount
      {
        [Token(Token = "0x60198D8"), Address(RVA = "0x3430298", Offset = "0x3430298", VA = "0x3430298")] get
        {
          return new int();
        }
        [Token(Token = "0x60198D9"), Address(RVA = "0x34302A0", Offset = "0x34302A0", VA = "0x34302A0")] private set
        {
        }
      }

      [Token(Token = "0x60198DA")]
      [Address(RVA = "0x342FC54", Offset = "0x342FC54", VA = "0x342FC54")]
      public void BuildMesh(int columns, int rows)
      {
      }

      [Token(Token = "0x60198DB")]
      [Address(RVA = "0x342FC38", Offset = "0x342FC38", VA = "0x342FC38")]
      public void Release()
      {
      }

      [Token(Token = "0x60198DC")]
      [Address(RVA = "0x342FC30", Offset = "0x342FC30", VA = "0x342FC30")]
      public ArrowArray()
      {
      }
    }
  }
}
