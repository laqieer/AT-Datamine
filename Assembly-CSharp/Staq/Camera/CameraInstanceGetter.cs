// Decompiled with JetBrains decompiler
// Type: staq.Camera.CameraInstanceGetter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace staq.Camera
{
  [Token(Token = "0x2003D6C")]
  public class CameraInstanceGetter : ICameraIntanceGetter
  {
    [Token(Token = "0x4010DDF")]
    [FieldOffset(Offset = "0x10")]
    private Action<UnityEngine.Camera> onReceiveCameraInstance;

    [Token(Token = "0x6018B6B")]
    [Address(RVA = "0x2644020", Offset = "0x2644020", VA = "0x2644020")]
    public CameraInstanceGetter(Action<UnityEngine.Camera> onReceiveCameraInstance)
    {
    }

    [Token(Token = "0x6018B6C")]
    [Address(RVA = "0x2644048", Offset = "0x2644048", VA = "0x2644048", Slot = "4")]
    public void ReceiveCameraInstance(UnityEngine.Camera camera)
    {
    }
  }
}
