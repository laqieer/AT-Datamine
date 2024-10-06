// Decompiled with JetBrains decompiler
// Type: GameCore.Time.TimeConvertUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace GameCore.Time
{
  [Token(Token = "0x2000C3B")]
  public static class TimeConvertUtility
  {
    [Token(Token = "0x4003772")]
    [FieldOffset(Offset = "0x0")]
    private static readonly TimeSpan localTimeSpan;

    [Token(Token = "0x6004655")]
    [Address(RVA = "0x35161E0", Offset = "0x35161E0", VA = "0x35161E0")]
    public static long ToUnixTime(DateTime dateTime) => new long();

    [Token(Token = "0x6004656")]
    [Address(RVA = "0x35162C4", Offset = "0x35162C4", VA = "0x35162C4")]
    public static DateTimeOffset ToLocalDateTimeOffset(this string self) => new DateTimeOffset();

    [Token(Token = "0x6004657")]
    [Address(RVA = "0x3516370", Offset = "0x3516370", VA = "0x3516370")]
    public static DateTimeOffset ToLocal(this DateTime self) => new DateTimeOffset();

    [Token(Token = "0x6004658")]
    [Address(RVA = "0x35163EC", Offset = "0x35163EC", VA = "0x35163EC")]
    static TimeConvertUtility()
    {
    }
  }
}
