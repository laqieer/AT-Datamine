// Decompiled with JetBrains decompiler
// Type: GameCore.DLC.IAssetLoadOperation`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace GameCore.DLC
{
  [Token(Token = "0x20014A3")]
  public interface IAssetLoadOperation<T> : IAssetLoadOperation, IEnumerator where T : UnityEngine.Object
  {
    [Token(Token = "0x140000F8")]
    event Action<T> onComplete;
  }
}
