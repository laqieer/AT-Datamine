// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.FogModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace UnityEngine.PostProcessing
{
  [Token(Token = "0x2003F9A")]
  [Serializable]
  public class FogModel : PostProcessingModel
  {
    [Token(Token = "0x40116A3")]
    [FieldOffset(Offset = "0x11")]
    [SerializeField]
    private FogModel.Settings m_Settings;

    [Token(Token = "0x17005282")]
    public FogModel.Settings settings
    {
      [Token(Token = "0x60199A2"), Address(RVA = "0x343C170", Offset = "0x343C170", VA = "0x343C170")] get
      {
        return new FogModel.Settings();
      }
      [Token(Token = "0x60199A3"), Address(RVA = "0x343C178", Offset = "0x343C178", VA = "0x343C178")] set
      {
      }
    }

    [Token(Token = "0x60199A4")]
    [Address(RVA = "0x343C180", Offset = "0x343C180", VA = "0x343C180", Slot = "4")]
    public override void Reset()
    {
    }

    [Token(Token = "0x60199A5")]
    [Address(RVA = "0x343C194", Offset = "0x343C194", VA = "0x343C194")]
    public FogModel()
    {
    }

    [Token(Token = "0x2003F9B")]
    [Serializable]
    public struct Settings
    {
      [Token(Token = "0x40116A4")]
      [FieldOffset(Offset = "0x0")]
      [Tooltip("Should the fog affect the skybox?")]
      public bool excludeSkybox;

      [Token(Token = "0x17005283")]
      public static FogModel.Settings defaultSettings
      {
        [Token(Token = "0x60199A6"), Address(RVA = "0x343C18C", Offset = "0x343C18C", VA = "0x343C18C")] get
        {
          return new FogModel.Settings();
        }
      }
    }
  }
}
