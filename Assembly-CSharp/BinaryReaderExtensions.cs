// Decompiled with JetBrains decompiler
// Type: BinaryReaderExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.IO;

#nullable disable
[Token(Token = "0x20001D4")]
internal static class BinaryReaderExtensions
{
  [Token(Token = "0x6000BD4")]
  [Address(RVA = "0x4C71420", Offset = "0x4C71420", VA = "0x4C71420")]
  public static string ReadStringEx(this BinaryReader reader) => (string) null;

  [Token(Token = "0x6000BD5")]
  [Address(RVA = "0x4C71490", Offset = "0x4C71490", VA = "0x4C71490")]
  public static string ReadStringExNoSeek(this BinaryReader reader) => (string) null;

  [Token(Token = "0x6000BD6")]
  [Address(RVA = "0x4C71508", Offset = "0x4C71508", VA = "0x4C71508")]
  public static void ReadIntArray(this BinaryReader reader, int size, ref int[] dst)
  {
  }

  [Token(Token = "0x6000BD7")]
  [Address(RVA = "0x4C71584", Offset = "0x4C71584", VA = "0x4C71584")]
  public static DateTime ReadDateTime(this BinaryReader reader) => new DateTime();
}
