// Decompiled with JetBrains decompiler
// Type: IntroChapter.ISceneProcessCoroutineMethod
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace IntroChapter
{
  [Token(Token = "0x2000A89")]
  public interface ISceneProcessCoroutineMethod
  {
    [Token(Token = "0x6003BE5")]
    Coroutine StartCoroutine(IEnumerator routine);

    [Token(Token = "0x6003BE6")]
    void StopCoroutine(Coroutine routine);
  }
}
