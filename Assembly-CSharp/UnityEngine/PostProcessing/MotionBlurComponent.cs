// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.MotionBlurComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine.Rendering;

#nullable disable
namespace UnityEngine.PostProcessing
{
  [Token(Token = "0x2003F62")]
  public sealed class MotionBlurComponent : PostProcessingComponentCommandBuffer<MotionBlurModel>
  {
    [Token(Token = "0x4011591")]
    [FieldOffset(Offset = "0x20")]
    private MotionBlurComponent.ReconstructionFilter m_ReconstructionFilter;
    [Token(Token = "0x4011592")]
    [FieldOffset(Offset = "0x28")]
    private MotionBlurComponent.FrameBlendingFilter m_FrameBlendingFilter;
    [Token(Token = "0x4011593")]
    [FieldOffset(Offset = "0x30")]
    private bool m_FirstFrame;

    [Token(Token = "0x17005257")]
    public MotionBlurComponent.ReconstructionFilter reconstructionFilter
    {
      [Token(Token = "0x6019923"), Address(RVA = "0x34355E8", Offset = "0x34355E8", VA = "0x34355E8")] get
      {
        return (MotionBlurComponent.ReconstructionFilter) null;
      }
    }

    [Token(Token = "0x17005258")]
    public MotionBlurComponent.FrameBlendingFilter frameBlendingFilter
    {
      [Token(Token = "0x6019924"), Address(RVA = "0x3435688", Offset = "0x3435688", VA = "0x3435688")] get
      {
        return (MotionBlurComponent.FrameBlendingFilter) null;
      }
    }

    [Token(Token = "0x17005259")]
    public override bool active
    {
      [Token(Token = "0x6019925"), Address(RVA = "0x3435760", Offset = "0x3435760", VA = "0x3435760", Slot = "5")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6019926")]
    [Address(RVA = "0x3435824", Offset = "0x3435824", VA = "0x3435824", Slot = "11")]
    public override string GetName() => (string) null;

    [Token(Token = "0x6019927")]
    [Address(RVA = "0x3435864", Offset = "0x3435864", VA = "0x3435864")]
    public void ResetHistory()
    {
    }

    [Token(Token = "0x6019928")]
    [Address(RVA = "0x34358F8", Offset = "0x34358F8", VA = "0x34358F8", Slot = "4")]
    public override DepthTextureMode GetCameraFlags() => new DepthTextureMode();

    [Token(Token = "0x6019929")]
    [Address(RVA = "0x3435900", Offset = "0x3435900", VA = "0x3435900", Slot = "10")]
    public override CameraEvent GetCameraEvent() => new CameraEvent();

    [Token(Token = "0x601992A")]
    [Address(RVA = "0x3435908", Offset = "0x3435908", VA = "0x3435908", Slot = "6")]
    public override void OnEnable()
    {
    }

    [Token(Token = "0x601992B")]
    [Address(RVA = "0x3435914", Offset = "0x3435914", VA = "0x3435914", Slot = "12")]
    public override void PopulateCommandBuffer(CommandBuffer cb)
    {
    }

    [Token(Token = "0x601992C")]
    [Address(RVA = "0x3436F40", Offset = "0x3436F40", VA = "0x3436F40", Slot = "7")]
    public override void OnDisable()
    {
    }

    [Token(Token = "0x601992D")]
    [Address(RVA = "0x3436F50", Offset = "0x3436F50", VA = "0x3436F50")]
    public MotionBlurComponent()
    {
    }

    [Token(Token = "0x2003F63")]
    private static class Uniforms
    {
      [Token(Token = "0x4011594")]
      [FieldOffset(Offset = "0x0")]
      internal static readonly int _VelocityScale;
      [Token(Token = "0x4011595")]
      [FieldOffset(Offset = "0x4")]
      internal static readonly int _MaxBlurRadius;
      [Token(Token = "0x4011596")]
      [FieldOffset(Offset = "0x8")]
      internal static readonly int _RcpMaxBlurRadius;
      [Token(Token = "0x4011597")]
      [FieldOffset(Offset = "0xC")]
      internal static readonly int _VelocityTex;
      [Token(Token = "0x4011598")]
      [FieldOffset(Offset = "0x10")]
      internal static readonly int _MainTex;
      [Token(Token = "0x4011599")]
      [FieldOffset(Offset = "0x14")]
      internal static readonly int _Tile2RT;
      [Token(Token = "0x401159A")]
      [FieldOffset(Offset = "0x18")]
      internal static readonly int _Tile4RT;
      [Token(Token = "0x401159B")]
      [FieldOffset(Offset = "0x1C")]
      internal static readonly int _Tile8RT;
      [Token(Token = "0x401159C")]
      [FieldOffset(Offset = "0x20")]
      internal static readonly int _TileMaxOffs;
      [Token(Token = "0x401159D")]
      [FieldOffset(Offset = "0x24")]
      internal static readonly int _TileMaxLoop;
      [Token(Token = "0x401159E")]
      [FieldOffset(Offset = "0x28")]
      internal static readonly int _TileVRT;
      [Token(Token = "0x401159F")]
      [FieldOffset(Offset = "0x2C")]
      internal static readonly int _NeighborMaxTex;
      [Token(Token = "0x40115A0")]
      [FieldOffset(Offset = "0x30")]
      internal static readonly int _LoopCount;
      [Token(Token = "0x40115A1")]
      [FieldOffset(Offset = "0x34")]
      internal static readonly int _TempRT;
      [Token(Token = "0x40115A2")]
      [FieldOffset(Offset = "0x38")]
      internal static readonly int _History1LumaTex;
      [Token(Token = "0x40115A3")]
      [FieldOffset(Offset = "0x3C")]
      internal static readonly int _History2LumaTex;
      [Token(Token = "0x40115A4")]
      [FieldOffset(Offset = "0x40")]
      internal static readonly int _History3LumaTex;
      [Token(Token = "0x40115A5")]
      [FieldOffset(Offset = "0x44")]
      internal static readonly int _History4LumaTex;
      [Token(Token = "0x40115A6")]
      [FieldOffset(Offset = "0x48")]
      internal static readonly int _History1ChromaTex;
      [Token(Token = "0x40115A7")]
      [FieldOffset(Offset = "0x4C")]
      internal static readonly int _History2ChromaTex;
      [Token(Token = "0x40115A8")]
      [FieldOffset(Offset = "0x50")]
      internal static readonly int _History3ChromaTex;
      [Token(Token = "0x40115A9")]
      [FieldOffset(Offset = "0x54")]
      internal static readonly int _History4ChromaTex;
      [Token(Token = "0x40115AA")]
      [FieldOffset(Offset = "0x58")]
      internal static readonly int _History1Weight;
      [Token(Token = "0x40115AB")]
      [FieldOffset(Offset = "0x5C")]
      internal static readonly int _History2Weight;
      [Token(Token = "0x40115AC")]
      [FieldOffset(Offset = "0x60")]
      internal static readonly int _History3Weight;
      [Token(Token = "0x40115AD")]
      [FieldOffset(Offset = "0x64")]
      internal static readonly int _History4Weight;

      [Token(Token = "0x601992E")]
      [Address(RVA = "0x3436FA0", Offset = "0x3436FA0", VA = "0x3436FA0")]
      static Uniforms()
      {
      }
    }

    [Token(Token = "0x2003F64")]
    private enum Pass
    {
      [Token(Token = "0x40115AF")] VelocitySetup,
      [Token(Token = "0x40115B0")] TileMax1,
      [Token(Token = "0x40115B1")] TileMax2,
      [Token(Token = "0x40115B2")] TileMaxV,
      [Token(Token = "0x40115B3")] NeighborMax,
      [Token(Token = "0x40115B4")] Reconstruction,
      [Token(Token = "0x40115B5")] FrameCompression,
      [Token(Token = "0x40115B6")] FrameBlendingChroma,
      [Token(Token = "0x40115B7")] FrameBlendingRaw,
    }

    [Token(Token = "0x2003F65")]
    public class ReconstructionFilter
    {
      [Token(Token = "0x40115B8")]
      [FieldOffset(Offset = "0x10")]
      private RenderTextureFormat m_VectorRTFormat;
      [Token(Token = "0x40115B9")]
      [FieldOffset(Offset = "0x14")]
      private RenderTextureFormat m_PackedRTFormat;

      [Token(Token = "0x601992F")]
      [Address(RVA = "0x3435650", Offset = "0x3435650", VA = "0x3435650")]
      public ReconstructionFilter()
      {
      }

      [Token(Token = "0x6019930")]
      [Address(RVA = "0x3437474", Offset = "0x3437474", VA = "0x3437474")]
      private void CheckTextureFormatSupport()
      {
      }

      [Token(Token = "0x6019931")]
      [Address(RVA = "0x343581C", Offset = "0x343581C", VA = "0x343581C")]
      public bool IsSupported() => new bool();

      [Token(Token = "0x6019932")]
      [Address(RVA = "0x3435FE0", Offset = "0x3435FE0", VA = "0x3435FE0")]
      public void ProcessImage(
        PostProcessingContext context,
        CommandBuffer cb,
        ref MotionBlurModel.Settings settings,
        RenderTargetIdentifier source,
        RenderTargetIdentifier destination,
        Material material)
      {
      }
    }

    [Token(Token = "0x2003F66")]
    public class FrameBlendingFilter
    {
      [Token(Token = "0x40115BA")]
      [FieldOffset(Offset = "0x10")]
      private bool m_UseCompression;
      [Token(Token = "0x40115BB")]
      [FieldOffset(Offset = "0x14")]
      private RenderTextureFormat m_RawTextureFormat;
      [Token(Token = "0x40115BC")]
      [FieldOffset(Offset = "0x18")]
      private MotionBlurComponent.FrameBlendingFilter.Frame[] m_FrameList;
      [Token(Token = "0x40115BD")]
      [FieldOffset(Offset = "0x20")]
      private int m_LastFrameCount;

      [Token(Token = "0x6019933")]
      [Address(RVA = "0x34356F0", Offset = "0x34356F0", VA = "0x34356F0")]
      public FrameBlendingFilter()
      {
      }

      [Token(Token = "0x6019934")]
      [Address(RVA = "0x3435884", Offset = "0x3435884", VA = "0x3435884")]
      public void Dispose()
      {
      }

      [Token(Token = "0x6019935")]
      [Address(RVA = "0x3436E20", Offset = "0x3436E20", VA = "0x3436E20")]
      public void PushFrame(
        CommandBuffer cb,
        RenderTargetIdentifier source,
        int width,
        int height,
        Material material)
      {
      }

      [Token(Token = "0x6019936")]
      [Address(RVA = "0x343693C", Offset = "0x343693C", VA = "0x343693C")]
      public void BlendFrames(
        CommandBuffer cb,
        float strength,
        RenderTargetIdentifier source,
        RenderTargetIdentifier destination,
        Material material)
      {
      }

      [Token(Token = "0x6019937")]
      [Address(RVA = "0x3437498", Offset = "0x3437498", VA = "0x3437498")]
      private static bool CheckSupportCompression() => new bool();

      [Token(Token = "0x6019938")]
      [Address(RVA = "0x34374CC", Offset = "0x34374CC", VA = "0x34374CC")]
      private static RenderTextureFormat GetPreferredRenderTextureFormat()
      {
        return new RenderTextureFormat();
      }

      [Token(Token = "0x6019939")]
      [Address(RVA = "0x3437A68", Offset = "0x3437A68", VA = "0x3437A68")]
      private MotionBlurComponent.FrameBlendingFilter.Frame GetFrameRelative(int offset)
      {
        return new MotionBlurComponent.FrameBlendingFilter.Frame();
      }

      [Token(Token = "0x2003F67")]
      private struct Frame
      {
        [Token(Token = "0x40115BE")]
        [FieldOffset(Offset = "0x0")]
        public RenderTexture lumaTexture;
        [Token(Token = "0x40115BF")]
        [FieldOffset(Offset = "0x8")]
        public RenderTexture chromaTexture;
        [Token(Token = "0x40115C0")]
        [FieldOffset(Offset = "0x10")]
        private float m_Time;
        [Token(Token = "0x40115C1")]
        [FieldOffset(Offset = "0x18")]
        private RenderTargetIdentifier[] m_MRT;

        [Token(Token = "0x601993A")]
        [Address(RVA = "0x3437ACC", Offset = "0x3437ACC", VA = "0x3437ACC")]
        public float CalculateWeight(float strength, float currentTime) => new float();

        [Token(Token = "0x601993B")]
        [Address(RVA = "0x3437598", Offset = "0x3437598", VA = "0x3437598")]
        public void Release()
        {
        }

        [Token(Token = "0x601993C")]
        [Address(RVA = "0x3437644", Offset = "0x3437644", VA = "0x3437644")]
        public void MakeRecord(
          CommandBuffer cb,
          RenderTargetIdentifier source,
          int width,
          int height,
          Material material)
        {
        }

        [Token(Token = "0x601993D")]
        [Address(RVA = "0x3437908", Offset = "0x3437908", VA = "0x3437908")]
        public void MakeRecordRaw(
          CommandBuffer cb,
          RenderTargetIdentifier source,
          int width,
          int height,
          RenderTextureFormat format)
        {
        }
      }
    }
  }
}
