// Decompiled with JetBrains decompiler
// Type: DateTimeExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Globalization;

#nullable disable
[Token(Token = "0x20001D5")]
public static class DateTimeExtensions
{
  [Token(Token = "0x6000BD8")]
  [Address(RVA = "0x4C715EC", Offset = "0x4C715EC", VA = "0x4C715EC")]
  public static string ToYYYYMMDDHHMM(this DateTime dateTime, CultureInfo cultureInfo = null)
  {
    return (string) null;
  }

  [Token(Token = "0x6000BD9")]
  [Address(RVA = "0x4C717F8", Offset = "0x4C717F8", VA = "0x4C717F8")]
  public static string ToYYYYMMDDHHMMSS(this DateTime dateTime, CultureInfo cultureInfo = null)
  {
    return (string) null;
  }

  [Token(Token = "0x6000BDA")]
  [Address(RVA = "0x4C71698", Offset = "0x4C71698", VA = "0x4C71698")]
  public static string ToYYYYMMDD(this DateTime dateTime, CultureInfo cultureInfo = null)
  {
    return (string) null;
  }

  [Token(Token = "0x6000BDB")]
  [Address(RVA = "0x4C71954", Offset = "0x4C71954", VA = "0x4C71954")]
  public static string ToYYYYMM(this DateTime dateTime) => (string) null;

  [Token(Token = "0x6000BDC")]
  [Address(RVA = "0x4C719C8", Offset = "0x4C719C8", VA = "0x4C719C8")]
  public static string ToMMDD(this DateTime dateTime, CultureInfo cultureInfo = null)
  {
    return (string) null;
  }

  [Token(Token = "0x6000BDD")]
  [Address(RVA = "0x4C71748", Offset = "0x4C71748", VA = "0x4C71748")]
  public static string ToHHMM(this DateTime dateTime, CultureInfo cultureInfo = null)
  {
    return (string) null;
  }

  [Token(Token = "0x6000BDE")]
  [Address(RVA = "0x4C718A4", Offset = "0x4C718A4", VA = "0x4C718A4")]
  public static string ToHHMMSS(this DateTime dateTime, CultureInfo cultureInfo = null)
  {
    return (string) null;
  }

  [Token(Token = "0x6000BDF")]
  [Address(RVA = "0x4C71A78", Offset = "0x4C71A78", VA = "0x4C71A78")]
  public static string ToDDHH(this TimeSpan timeSpan, int zeroDigit = 1) => (string) null;

  [Token(Token = "0x6000BE0")]
  [Address(RVA = "0x4C71CCC", Offset = "0x4C71CCC", VA = "0x4C71CCC")]
  public static string ToHHMM(this TimeSpan timeSpan, int zeroDigit = 1) => (string) null;

  [Token(Token = "0x6000BE1")]
  [Address(RVA = "0x4C71D24", Offset = "0x4C71D24", VA = "0x4C71D24")]
  public static string ToHHMMSS(this TimeSpan timeSpan, int zeroDigit = 1) => (string) null;

  [Token(Token = "0x6000BE2")]
  [Address(RVA = "0x4C71D7C", Offset = "0x4C71D7C", VA = "0x4C71D7C")]
  public static string ToMM(this TimeSpan timeSpan, int zeroDigit = 1) => (string) null;

  [Token(Token = "0x6000BE3")]
  [Address(RVA = "0x4C71DD4", Offset = "0x4C71DD4", VA = "0x4C71DD4")]
  public static int ToUnixTimestamp(this DateTime dateTime) => new int();
}
