// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.GridSource
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027E9")]
  public struct GridSource
  {
    [Token(Token = "0x400A9DE")]
    [FieldOffset(Offset = "0x0")]
    public Vector2Int coordinate;
    [Token(Token = "0x400A9DF")]
    [FieldOffset(Offset = "0x8")]
    public int landform;
    [Token(Token = "0x400A9E0")]
    [FieldOffset(Offset = "0x10")]
    public float[] heights;
  }
}
