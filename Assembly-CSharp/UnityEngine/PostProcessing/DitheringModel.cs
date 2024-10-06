// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.DitheringModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace UnityEngine.PostProcessing
{
  [Token(Token = "0x2003F95")]
  [Serializable]
  public class DitheringModel : PostProcessingModel
  {
    [Token(Token = "0x4011693")]
    [FieldOffset(Offset = "0x11")]
    [SerializeField]
    private DitheringModel.Settings m_Settings;

    [Token(Token = "0x1700527E")]
    public DitheringModel.Settings settings
    {
      [Token(Token = "0x6019998"), Address(RVA = "0x343C044", Offset = "0x343C044", VA = "0x343C044")] get
      {
        return new DitheringModel.Settings();
      }
      [Token(Token = "0x6019999"), Address(RVA = "0x343C04C", Offset = "0x343C04C", VA = "0x343C04C")] set
      {
      }
    }

    [Token(Token = "0x601999A")]
    [Address(RVA = "0x343C054", Offset = "0x343C054", VA = "0x343C054", Slot = "4")]
    public override void Reset()
    {
    }

    [Token(Token = "0x601999B")]
    [Address(RVA = "0x343C064", Offset = "0x343C064", VA = "0x343C064")]
    public DitheringModel()
    {
    }

    [Token(Token = "0x2003F96")]
    [Serializable]
    public struct Settings
    {
      [Token(Token = "0x1700527F")]
      public static DitheringModel.Settings defaultSettings
      {
        [Token(Token = "0x601999C"), Address(RVA = "0x343C05C", Offset = "0x343C05C", VA = "0x343C05C")] get
        {
          return new DitheringModel.Settings();
        }
      }
    }
  }
}
