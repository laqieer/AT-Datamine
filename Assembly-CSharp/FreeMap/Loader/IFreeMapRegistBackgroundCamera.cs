// Decompiled with JetBrains decompiler
// Type: FreeMap.Loader.IFreeMapRegistBackgroundCamera
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.Loader
{
  [Token(Token = "0x20018AB")]
  public interface IFreeMapRegistBackgroundCamera
  {
    [Token(Token = "0x6008C14")]
    void RegistCamera(Camera camera);

    [Token(Token = "0x6008C15")]
    void ExcludeCamera();
  }
}
