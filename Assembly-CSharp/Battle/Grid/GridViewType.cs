// Decompiled with JetBrains decompiler
// Type: Battle.Grid.GridViewType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Battle.Grid
{
  [Token(Token = "0x2002528")]
  [Flags]
  public enum GridViewType
  {
    [Token(Token = "0x4009F9D")] Grid = 0,
    [Token(Token = "0x4009F9E")] Movable = 1,
    [Token(Token = "0x4009F9F")] Healing = 2,
    [Token(Token = "0x4009FA0")] Attackable = 4,
    [Token(Token = "0x4009FA1")] Effective = 8,
    [Token(Token = "0x4009FA2")] PlayerStay = 256, // 0x00000100
    [Token(Token = "0x4009FA3")] GuestStay = 512, // 0x00000200
    [Token(Token = "0x4009FA4")] EnemyStay = 1024, // 0x00000400
    [Token(Token = "0x4009FA5")] AnotherForceStay = 2048, // 0x00000800
  }
}
