// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.ChromaticAberrationModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace UnityEngine.PostProcessing
{
  [Token(Token = "0x2003F85")]
  [Serializable]
  public class ChromaticAberrationModel : PostProcessingModel
  {
    [Token(Token = "0x401164F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ChromaticAberrationModel.Settings m_Settings;

    [Token(Token = "0x1700526F")]
    public ChromaticAberrationModel.Settings settings
    {
      [Token(Token = "0x601997D"), Address(RVA = "0x343B5A4", Offset = "0x343B5A4", VA = "0x343B5A4")] get
      {
        return new ChromaticAberrationModel.Settings();
      }
      [Token(Token = "0x601997E"), Address(RVA = "0x343B5B0", Offset = "0x343B5B0", VA = "0x343B5B0")] set
      {
      }
    }

    [Token(Token = "0x601997F")]
    [Address(RVA = "0x343B5B8", Offset = "0x343B5B8", VA = "0x343B5B8", Slot = "4")]
    public override void Reset()
    {
    }

    [Token(Token = "0x6019980")]
    [Address(RVA = "0x343B5D8", Offset = "0x343B5D8", VA = "0x343B5D8")]
    public ChromaticAberrationModel()
    {
    }

    [Token(Token = "0x2003F86")]
    [Serializable]
    public struct Settings
    {
      [Token(Token = "0x4011650")]
      [FieldOffset(Offset = "0x0")]
      [Tooltip("Shift the hue of chromatic aberrations.")]
      public Texture2D spectralTexture;
      [Token(Token = "0x4011651")]
      [FieldOffset(Offset = "0x8")]
      [Range(0.0f, 1f)]
      [Tooltip("Amount of tangential distortion.")]
      public float intensity;

      [Token(Token = "0x17005270")]
      public static ChromaticAberrationModel.Settings defaultSettings
      {
        [Token(Token = "0x6019981"), Address(RVA = "0x343B5C8", Offset = "0x343B5C8", VA = "0x343B5C8")] get
        {
          return new ChromaticAberrationModel.Settings();
        }
      }
    }
  }
}
