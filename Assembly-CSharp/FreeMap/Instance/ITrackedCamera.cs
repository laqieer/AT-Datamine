// Decompiled with JetBrains decompiler
// Type: FreeMap.Instance.ITrackedCamera
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.Instance
{
  [Token(Token = "0x20018F8")]
  public interface ITrackedCamera
  {
    [Token(Token = "0x170016B4")]
    Transform CameraTransform { [Token(Token = "0x6008DCB")] get; }

    [Token(Token = "0x6008DCC")]
    void BindCameraTransform(Transform cameraTransform);
  }
}
