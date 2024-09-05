// Decompiled with JetBrains decompiler
// Type: GameCore.DLC.IAssetLoadOperation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace GameCore.DLC
{
  [Token(Token = "0x20014A2")]
  public interface IAssetLoadOperation : IEnumerator
  {
    [Token(Token = "0x170011CD")]
    Object asset { [Token(Token = "0x600743E")] get; }

    [Token(Token = "0x170011CE")]
    bool IsDone { [Token(Token = "0x600743F")] get; }
  }
}
