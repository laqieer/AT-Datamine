// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ErrorCodeEnum
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000EE9")]
  public enum ErrorCodeEnum
  {
    [Token(Token = "0x400491C")] DEFAULT = 0,
    [Token(Token = "0x400491D")] NG_WORD = 100, // 0x00000064
    [Token(Token = "0x400491E")] BANNED = 101, // 0x00000065
    [Token(Token = "0x400491F")] IN_THROTTLE = 102, // 0x00000066
    [Token(Token = "0x4004920")] TOO_LONG = 103, // 0x00000067
    [Token(Token = "0x4004921")] INVALID_MESSAGE_TYPE = 104, // 0x00000068
    [Token(Token = "0x4004922")] INVALID_STAMP = 105, // 0x00000069
    [Token(Token = "0x4004923")] NEED_RETRY = 200, // 0x000000C8
    [Token(Token = "0x4004924")] ALREADY_REPORTED = 300, // 0x0000012C
    [Token(Token = "0x4004925")] CANNOT_REPORT = 301, // 0x0000012D
  }
}
