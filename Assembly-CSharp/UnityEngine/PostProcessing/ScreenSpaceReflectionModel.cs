// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.ScreenSpaceReflectionModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace UnityEngine.PostProcessing
{
  [Token(Token = "0x2003FA0")]
  [Serializable]
  public class ScreenSpaceReflectionModel : PostProcessingModel
  {
    [Token(Token = "0x40116AE")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private ScreenSpaceReflectionModel.Settings m_Settings;

    [Token(Token = "0x17005288")]
    public ScreenSpaceReflectionModel.Settings settings
    {
      [Token(Token = "0x60199B1"), Address(RVA = "0x343C254", Offset = "0x343C254", VA = "0x343C254")] get
      {
        return new ScreenSpaceReflectionModel.Settings();
      }
      [Token(Token = "0x60199B2"), Address(RVA = "0x343C274", Offset = "0x343C274", VA = "0x343C274")] set
      {
      }
    }

    [Token(Token = "0x60199B3")]
    [Address(RVA = "0x343C294", Offset = "0x343C294", VA = "0x343C294", Slot = "4")]
    public override void Reset()
    {
    }

    [Token(Token = "0x60199B4")]
    [Address(RVA = "0x343C338", Offset = "0x343C338", VA = "0x343C338")]
    public ScreenSpaceReflectionModel()
    {
    }

    [Token(Token = "0x2003FA1")]
    public enum SSRResolution
    {
      [Token(Token = "0x40116B0")] High = 0,
      [Token(Token = "0x40116B1")] Low = 2,
    }

    [Token(Token = "0x2003FA2")]
    public enum SSRReflectionBlendType
    {
      [Token(Token = "0x40116B3")] PhysicallyBased,
      [Token(Token = "0x40116B4")] Additive,
    }

    [Token(Token = "0x2003FA3")]
    [Serializable]
    public struct IntensitySettings
    {
      [Token(Token = "0x40116B5")]
      [FieldOffset(Offset = "0x0")]
      [Tooltip("Nonphysical multiplier for the SSR reflections. 1.0 is physically based.")]
      [Range(0.0f, 2f)]
      public float reflectionMultiplier;
      [Token(Token = "0x40116B6")]
      [FieldOffset(Offset = "0x4")]
      [Range(0.0f, 1000f)]
      [Tooltip("How far away from the maxDistance to begin fading SSR.")]
      public float fadeDistance;
      [Token(Token = "0x40116B7")]
      [FieldOffset(Offset = "0x8")]
      [Tooltip("Amplify Fresnel fade out. Increase if floor reflections look good close to the surface and bad farther 'under' the floor.")]
      [Range(0.0f, 1f)]
      public float fresnelFade;
      [Token(Token = "0x40116B8")]
      [FieldOffset(Offset = "0xC")]
      [Tooltip("Higher values correspond to a faster Fresnel fade as the reflection changes from the grazing angle.")]
      [Range(0.1f, 10f)]
      public float fresnelFadePower;
    }

    [Token(Token = "0x2003FA4")]
    [Serializable]
    public struct ReflectionSettings
    {
      [Token(Token = "0x40116B9")]
      [FieldOffset(Offset = "0x0")]
      [Tooltip("How the reflections are blended into the render.")]
      public ScreenSpaceReflectionModel.SSRReflectionBlendType blendType;
      [Token(Token = "0x40116BA")]
      [FieldOffset(Offset = "0x4")]
      [Tooltip("Half resolution SSRR is much faster, but less accurate.")]
      public ScreenSpaceReflectionModel.SSRResolution reflectionQuality;
      [Token(Token = "0x40116BB")]
      [FieldOffset(Offset = "0x8")]
      [Tooltip("Maximum reflection distance in world units.")]
      [Range(0.1f, 300f)]
      public float maxDistance;
      [Token(Token = "0x40116BC")]
      [FieldOffset(Offset = "0xC")]
      [Range(16f, 1024f)]
      [Tooltip("Max raytracing length.")]
      public int iterationCount;
      [Token(Token = "0x40116BD")]
      [FieldOffset(Offset = "0x10")]
      [Range(1f, 16f)]
      [Tooltip("Log base 2 of ray tracing coarse step size. Higher traces farther, lower gives better quality silhouettes.")]
      public int stepSize;
      [Token(Token = "0x40116BE")]
      [FieldOffset(Offset = "0x14")]
      [Tooltip("Typical thickness of columns, walls, furniture, and other objects that reflection rays might pass behind.")]
      [Range(0.01f, 10f)]
      public float widthModifier;
      [Token(Token = "0x40116BF")]
      [FieldOffset(Offset = "0x18")]
      [Tooltip("Blurriness of reflections.")]
      [Range(0.1f, 8f)]
      public float reflectionBlur;
      [Token(Token = "0x40116C0")]
      [FieldOffset(Offset = "0x1C")]
      [Tooltip("Disable for a performance gain in scenes where most glossy objects are horizontal, like floors, water, and tables. Leave on for scenes with glossy vertical objects.")]
      public bool reflectBackfaces;
    }

    [Token(Token = "0x2003FA5")]
    [Serializable]
    public struct ScreenEdgeMask
    {
      [Token(Token = "0x40116C1")]
      [FieldOffset(Offset = "0x0")]
      [Range(0.0f, 1f)]
      [Tooltip("Higher = fade out SSRR near the edge of the screen so that reflections don't pop under camera motion.")]
      public float intensity;
    }

    [Token(Token = "0x2003FA6")]
    [Serializable]
    public struct Settings
    {
      [Token(Token = "0x40116C2")]
      [FieldOffset(Offset = "0x0")]
      public ScreenSpaceReflectionModel.ReflectionSettings reflection;
      [Token(Token = "0x40116C3")]
      [FieldOffset(Offset = "0x20")]
      public ScreenSpaceReflectionModel.IntensitySettings intensity;
      [Token(Token = "0x40116C4")]
      [FieldOffset(Offset = "0x30")]
      public ScreenSpaceReflectionModel.ScreenEdgeMask screenEdgeMask;

      [Token(Token = "0x17005289")]
      public static ScreenSpaceReflectionModel.Settings defaultSettings
      {
        [Token(Token = "0x60199B5"), Address(RVA = "0x343C2E4", Offset = "0x343C2E4", VA = "0x343C2E4")] get
        {
          return new ScreenSpaceReflectionModel.Settings();
        }
      }
    }
  }
}
