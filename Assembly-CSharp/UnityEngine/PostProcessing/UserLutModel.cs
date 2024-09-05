// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.UserLutModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace UnityEngine.PostProcessing
{
  [Token(Token = "0x2003FA7")]
  [Serializable]
  public class UserLutModel : PostProcessingModel
  {
    [Token(Token = "0x40116C5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UserLutModel.Settings m_Settings;

    [Token(Token = "0x1700528A")]
    public UserLutModel.Settings settings
    {
      [Token(Token = "0x60199B6"), Address(RVA = "0x343C38C", Offset = "0x343C38C", VA = "0x343C38C")] get
      {
        return new UserLutModel.Settings();
      }
      [Token(Token = "0x60199B7"), Address(RVA = "0x343C398", Offset = "0x343C398", VA = "0x343C398")] set
      {
      }
    }

    [Token(Token = "0x60199B8")]
    [Address(RVA = "0x343C3A0", Offset = "0x343C3A0", VA = "0x343C3A0", Slot = "4")]
    public override void Reset()
    {
    }

    [Token(Token = "0x60199B9")]
    [Address(RVA = "0x343C3BC", Offset = "0x343C3BC", VA = "0x343C3BC")]
    public UserLutModel()
    {
    }

    [Token(Token = "0x2003FA8")]
    [Serializable]
    public struct Settings
    {
      [Token(Token = "0x40116C6")]
      [FieldOffset(Offset = "0x0")]
      [Tooltip("Custom lookup texture (strip format, e.g. 256x16).")]
      public Texture2D lut;
      [Token(Token = "0x40116C7")]
      [FieldOffset(Offset = "0x8")]
      [Tooltip("Blending factor.")]
      [Range(0.0f, 1f)]
      public float contribution;

      [Token(Token = "0x1700528B")]
      public static UserLutModel.Settings defaultSettings
      {
        [Token(Token = "0x60199BA"), Address(RVA = "0x343C3B0", Offset = "0x343C3B0", VA = "0x343C3B0")] get
        {
          return new UserLutModel.Settings();
        }
      }
    }
  }
}
