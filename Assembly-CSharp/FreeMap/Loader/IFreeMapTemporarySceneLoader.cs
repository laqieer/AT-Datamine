// Decompiled with JetBrains decompiler
// Type: FreeMap.Loader.IFreeMapTemporarySceneLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace FreeMap.Loader
{
  [Token(Token = "0x20018AC")]
  public interface IFreeMapTemporarySceneLoader
  {
    [Token(Token = "0x6008C16")]
    void UnLoadScene();

    [Token(Token = "0x6008C17")]
    IEnumerator LoadScene();
  }
}
