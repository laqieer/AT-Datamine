// Decompiled with JetBrains decompiler
// Type: Battle.Grid.AdjoiningDirection
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Battle.Grid
{
  [Token(Token = "0x200252B")]
  [Flags]
  public enum AdjoiningDirection
  {
    [Token(Token = "0x4009FB1")] None = 0,
    [Token(Token = "0x4009FB2")] Up = 1,
    [Token(Token = "0x4009FB3")] Down = 2,
    [Token(Token = "0x4009FB4")] Left = 4,
    [Token(Token = "0x4009FB5")] Right = 8,
    [Token(Token = "0x4009FB6")] UpLeft = 16, // 0x00000010
    [Token(Token = "0x4009FB7")] UpRight = 32, // 0x00000020
    [Token(Token = "0x4009FB8")] DownLeft = 64, // 0x00000040
    [Token(Token = "0x4009FB9")] DownRight = 128, // 0x00000080
    [Token(Token = "0x4009FBA")] All = DownRight | DownLeft | UpRight | UpLeft | Right | Left | Down | Up, // 0x000000FF
  }
}
