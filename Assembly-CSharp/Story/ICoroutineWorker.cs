// Decompiled with JetBrains decompiler
// Type: Story.ICoroutineWorker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Story
{
  [Token(Token = "0x2000591")]
  public interface ICoroutineWorker
  {
    [Token(Token = "0x600202F")]
    Coroutine StartCoroutine(IEnumerator routine);
  }
}
