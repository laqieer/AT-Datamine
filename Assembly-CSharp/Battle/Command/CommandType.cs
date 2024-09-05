// Decompiled with JetBrains decompiler
// Type: Battle.Command.CommandType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Battle.Command
{
  [Token(Token = "0x20024A2")]
  [Flags]
  public enum CommandType
  {
    [Token(Token = "0x4009D17")] None = 0,
    [Token(Token = "0x4009D18")] AttackSkill = 2,
    [Token(Token = "0x4009D19")] SwitchWeapon = 4,
    [Token(Token = "0x4009D1A")] StratagemSkill = 8,
    [Token(Token = "0x4009D1B")] SupportSkill = 16, // 0x00000010
    [Token(Token = "0x4009D1C")] ChargeSkill = 128, // 0x00000080
    [Token(Token = "0x4009D1D")] Double = 256, // 0x00000100
    [Token(Token = "0x4009D1E")] SwitchDouble = 512, // 0x00000200
    [Token(Token = "0x4009D1F")] ReleaseDouble = 1024, // 0x00000400
    [Token(Token = "0x4009D20")] Item = 4096, // 0x00001000
    [Token(Token = "0x4009D21")] Interact = 8192, // 0x00002000
    [Token(Token = "0x4009D22")] InteractDoorSwitch = 16384, // 0x00004000
    [Token(Token = "0x4009D23")] InteractWarp = 32768, // 0x00008000
    [Token(Token = "0x4009D24")] InteractTreasureChest = 65536, // 0x00010000
    [Token(Token = "0x4009D25")] Stay = 1048576, // 0x00100000
    [Token(Token = "0x4009D26")] Cancel = 2097152, // 0x00200000
    [Token(Token = "0x4009D27")] Move = Cancel | Stay, // 0x00300000
  }
}
