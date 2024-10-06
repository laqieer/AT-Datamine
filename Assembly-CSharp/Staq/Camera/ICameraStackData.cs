// Decompiled with JetBrains decompiler
// Type: staq.Camera.ICameraStackData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace staq.Camera
{
  [Token(Token = "0x2003D6A")]
  public interface ICameraStackData
  {
    [Token(Token = "0x170050A8")]
    int Priority { [Token(Token = "0x6018B62")] get; }

    [Token(Token = "0x170050A9")]
    UnityEngine.Camera TargetCamera { [Token(Token = "0x6018B63")] get; }

    [Token(Token = "0x170050AA")]
    int Order { [Token(Token = "0x6018B64")] get; }

    [Token(Token = "0x170050AB")]
    string OrderName { [Token(Token = "0x6018B65")] get; }

    [Token(Token = "0x170050AC")]
    string CameraTag { [Token(Token = "0x6018B66")] get; }

    [Token(Token = "0x170050AD")]
    bool IsRenderPostProcessing { [Token(Token = "0x6018B67")] get; }

    [Token(Token = "0x170050AE")]
    int EnablePostProcessingRequestCount { [Token(Token = "0x6018B68")] get; [Token(Token = "0x6018B69")] set; }
  }
}
