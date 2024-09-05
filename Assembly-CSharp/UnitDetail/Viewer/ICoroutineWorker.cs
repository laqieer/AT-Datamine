// Decompiled with JetBrains decompiler
// Type: UnitDetail.Viewer.ICoroutineWorker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace UnitDetail.Viewer
{
  [Token(Token = "0x20004BB")]
  public interface ICoroutineWorker
  {
    [Token(Token = "0x6001ACE")]
    Coroutine StartCoroutine(IEnumerator routine);

    [Token(Token = "0x6001ACF")]
    void StopCoroutine(Coroutine routine);
  }
}
