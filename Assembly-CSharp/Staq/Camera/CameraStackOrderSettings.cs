// Decompiled with JetBrains decompiler
// Type: staq.Camera.CameraStackOrderSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace staq.Camera
{
  [Token(Token = "0x2003D76")]
  [CreateAssetMenu(menuName = "Camera Stack/Create Camera Stack Order Settings")]
  public class CameraStackOrderSettings : ScriptableObject
  {
    [Token(Token = "0x4010DF5")]
    private const string AssetPath = "CameraStackOrderSettings";
    [Token(Token = "0x4010DF6")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CameraStackOrderSettingItem[] settings;
    [Token(Token = "0x4010DF7")]
    [FieldOffset(Offset = "0x0")]
    private static CameraStackOrderSettings instance;

    [Token(Token = "0x170050B5")]
    public static CameraStackOrderSettingItem[] Settings
    {
      [Token(Token = "0x6018B97"), Address(RVA = "0x2647160", Offset = "0x2647160", VA = "0x2647160")] get
      {
        return (CameraStackOrderSettingItem[]) null;
      }
    }

    [Token(Token = "0x170050B6")]
    private static CameraStackOrderSettings Instance
    {
      [Token(Token = "0x6018B98"), Address(RVA = "0x264717C", Offset = "0x264717C", VA = "0x264717C")] get
      {
        return (CameraStackOrderSettings) null;
      }
    }

    [Token(Token = "0x6018B99")]
    [Address(RVA = "0x2647044", Offset = "0x2647044", VA = "0x2647044")]
    public static int GetOrder(string name) => new int();

    [Token(Token = "0x6018B9A")]
    [Address(RVA = "0x2647250", Offset = "0x2647250", VA = "0x2647250")]
    public CameraStackOrderSettings()
    {
    }
  }
}
