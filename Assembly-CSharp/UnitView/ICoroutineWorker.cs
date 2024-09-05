// Decompiled with JetBrains decompiler
// Type: UnitView.ICoroutineWorker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace UnitView
{
  [Token(Token = "0x20003BE")]
  public interface ICoroutineWorker
  {
    [Token(Token = "0x60015B8")]
    Coroutine StartCoroutine(IEnumerator routine);

    [Token(Token = "0x60015B9")]
    void StopCoroutine(Coroutine routine);
  }
}
