// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.ITargettable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027EB")]
  public interface ITargettable
  {
    [Token(Token = "0x170035EC")]
    List<Vector2Int> Coordinates { [Token(Token = "0x600F954")] get; }
  }
}
