// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.VignetteModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace UnityEngine.PostProcessing
{
  [Token(Token = "0x2003FA9")]
  [Serializable]
  public class VignetteModel : PostProcessingModel
  {
    [Token(Token = "0x40116C8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private VignetteModel.Settings m_Settings;

    [Token(Token = "0x1700528C")]
    public VignetteModel.Settings settings
    {
      [Token(Token = "0x60199BB"), Address(RVA = "0x343C3D0", Offset = "0x343C3D0", VA = "0x343C3D0")] get
      {
        return new VignetteModel.Settings();
      }
      [Token(Token = "0x60199BC"), Address(RVA = "0x343C3F0", Offset = "0x343C3F0", VA = "0x343C3F0")] set
      {
      }
    }

    [Token(Token = "0x60199BD")]
    [Address(RVA = "0x343C410", Offset = "0x343C410", VA = "0x343C410", Slot = "4")]
    public override void Reset()
    {
    }

    [Token(Token = "0x60199BE")]
    [Address(RVA = "0x343C488", Offset = "0x343C488", VA = "0x343C488")]
    public VignetteModel()
    {
    }

    [Token(Token = "0x2003FAA")]
    public enum Mode
    {
      [Token(Token = "0x40116CA")] Classic,
      [Token(Token = "0x40116CB")] Masked,
    }

    [Token(Token = "0x2003FAB")]
    [Serializable]
    public struct Settings
    {
      [Token(Token = "0x40116CC")]
      [FieldOffset(Offset = "0x0")]
      [Tooltip("Use the \"Classic\" mode for parametric controls. Use the \"Masked\" mode to use your own texture mask.")]
      public VignetteModel.Mode mode;
      [Token(Token = "0x40116CD")]
      [FieldOffset(Offset = "0x4")]
      [Tooltip("Vignette color. Use the alpha channel for transparency.")]
      [ColorUsage(false)]
      public Color color;
      [Token(Token = "0x40116CE")]
      [FieldOffset(Offset = "0x14")]
      [Tooltip("Sets the vignette center point (screen center is [0.5,0.5]).")]
      public Vector2 center;
      [Token(Token = "0x40116CF")]
      [FieldOffset(Offset = "0x1C")]
      [Range(0.0f, 1f)]
      [Tooltip("Amount of vignetting on screen.")]
      public float intensity;
      [Token(Token = "0x40116D0")]
      [FieldOffset(Offset = "0x20")]
      [Range(0.01f, 1f)]
      [Tooltip("Smoothness of the vignette borders.")]
      public float smoothness;
      [Token(Token = "0x40116D1")]
      [FieldOffset(Offset = "0x24")]
      [Tooltip("Lower values will make a square-ish vignette.")]
      [Range(0.0f, 1f)]
      public float roundness;
      [Token(Token = "0x40116D2")]
      [FieldOffset(Offset = "0x28")]
      [Tooltip("A black and white mask to use as a vignette.")]
      public Texture mask;
      [Token(Token = "0x40116D3")]
      [FieldOffset(Offset = "0x30")]
      [Range(0.0f, 1f)]
      [Tooltip("Mask opacity.")]
      public float opacity;
      [Token(Token = "0x40116D4")]
      [FieldOffset(Offset = "0x34")]
      [Tooltip("Should the vignette be perfectly round or be dependent on the current aspect ratio?")]
      public bool rounded;

      [Token(Token = "0x1700528D")]
      public static VignetteModel.Settings defaultSettings
      {
        [Token(Token = "0x60199BF"), Address(RVA = "0x343C44C", Offset = "0x343C44C", VA = "0x343C44C")] get
        {
          return new VignetteModel.Settings();
        }
      }
    }
  }
}
