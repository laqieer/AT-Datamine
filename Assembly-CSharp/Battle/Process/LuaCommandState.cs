// Decompiled with JetBrains decompiler
// Type: Battle.Process.LuaCommandState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Process
{
  [Token(Token = "0x200262C")]
  public enum LuaCommandState
  {
    [Token(Token = "0x400A3FC")] None,
    [Token(Token = "0x400A3FD")] SelectUnit,
    [Token(Token = "0x400A3FE")] SelectPosition,
    [Token(Token = "0x400A3FF")] SelectCommand,
    [Token(Token = "0x400A400")] SelectTarget,
    [Token(Token = "0x400A401")] SelectConfirm,
    [Token(Token = "0x400A402")] SwapWeapon,
  }
}
