// Decompiled with JetBrains decompiler
// Type: staq.Camera.CameraStackDataExtension
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace staq.Camera
{
  [Token(Token = "0x2003D69")]
  public static class CameraStackDataExtension
  {
    [Token(Token = "0x6018B5D")]
    [Address(RVA = "0x2643CC0", Offset = "0x2643CC0", VA = "0x2643CC0")]
    public static bool IsUntagged(string tagName) => new bool();

    [Token(Token = "0x6018B5E")]
    [Address(RVA = "0x2643D2C", Offset = "0x2643D2C", VA = "0x2643D2C")]
    public static bool IsMainCamera(string tagName) => new bool();

    [Token(Token = "0x6018B5F")]
    [Address(RVA = "0x2643D78", Offset = "0x2643D78", VA = "0x2643D78")]
    public static bool IsUntagged(this ICameraStackData cameraStackData) => new bool();

    [Token(Token = "0x6018B60")]
    [Address(RVA = "0x2643E1C", Offset = "0x2643E1C", VA = "0x2643E1C")]
    public static bool IsMainCamera(this ICameraStackData cameraStackData) => new bool();

    [Token(Token = "0x6018B61")]
    [Address(RVA = "0x2643EC0", Offset = "0x2643EC0", VA = "0x2643EC0")]
    public static bool IsValid(this ICameraStackData cameraStackData) => new bool();
  }
}
