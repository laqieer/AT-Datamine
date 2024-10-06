// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.FileFormatType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013CE")]
  public enum FileFormatType
  {
    [Token(Token = "0x4005CA7")] Int8 = 16, // 0x00000010
    [Token(Token = "0x4005CA8")] UInt8 = 17, // 0x00000011
    [Token(Token = "0x4005CA9")] Int16 = 18, // 0x00000012
    [Token(Token = "0x4005CAA")] UInt16 = 19, // 0x00000013
    [Token(Token = "0x4005CAB")] Int32 = 20, // 0x00000014
    [Token(Token = "0x4005CAC")] UInt32 = 21, // 0x00000015
    [Token(Token = "0x4005CAD")] Int64 = 22, // 0x00000016
    [Token(Token = "0x4005CAE")] UInt64 = 23, // 0x00000017
    [Token(Token = "0x4005CAF")] Float = 32, // 0x00000020
    [Token(Token = "0x4005CB0")] Double = 33, // 0x00000021
    [Token(Token = "0x4005CB1")] Bool = 48, // 0x00000030
    [Token(Token = "0x4005CB2")] String = 64, // 0x00000040
    [Token(Token = "0x4005CB3")] ByteArray = 65, // 0x00000041
  }
}
