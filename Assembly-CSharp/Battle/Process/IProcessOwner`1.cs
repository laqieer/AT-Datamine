// Decompiled with JetBrains decompiler
// Type: Battle.Process.IProcessOwner`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Battle.Process
{
  [Token(Token = "0x2002655")]
  public interface IProcessOwner<TFinishCode>
  {
    [Token(Token = "0x600ED62")]
    void OnFinishProcess(TFinishCode code);

    [Token(Token = "0x600ED63")]
    Coroutine StartCoroutine(IEnumerator routine);

    [Token(Token = "0x600ED64")]
    void StopCoroutine(IEnumerator routine);
  }
}
