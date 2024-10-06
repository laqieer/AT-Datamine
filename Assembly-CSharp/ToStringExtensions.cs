// Decompiled with JetBrains decompiler
// Type: ToStringExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
[Token(Token = "0x20001DF")]
public static class ToStringExtensions
{
  [Token(Token = "0x6000BFD")]
  [Address(RVA = "0x4C723F8", Offset = "0x4C723F8", VA = "0x4C723F8")]
  public static string ToNumericString(this int value) => (string) null;

  [Token(Token = "0x6000BFE")]
  [Address(RVA = "0x4C72400", Offset = "0x4C72400", VA = "0x4C72400")]
  public static string ToNumericString(this uint value) => (string) null;

  [Token(Token = "0x6000BFF")]
  [Address(RVA = "0x4C72408", Offset = "0x4C72408", VA = "0x4C72408")]
  public static string ToNumericString(this float value, int digit = 2) => (string) null;

  [Token(Token = "0x6000C00")]
  [Address(RVA = "0x4C72410", Offset = "0x4C72410", VA = "0x4C72410")]
  public static string ToNumericString(this long value) => (string) null;

  [Token(Token = "0x6000C01")]
  [Address(RVA = "0x4C72418", Offset = "0x4C72418", VA = "0x4C72418")]
  public static string ToWithSignNumericString(this int value) => (string) null;

  [Token(Token = "0x6000C02")]
  [Address(RVA = "0x4C72420", Offset = "0x4C72420", VA = "0x4C72420")]
  public static string ToWithMinusNumericString(this int value) => (string) null;

  [Token(Token = "0x6000C03")]
  [Address(RVA = "0x4C71AD0", Offset = "0x4C71AD0", VA = "0x4C71AD0")]
  public static string ToStringEx(this TimeSpan self, string format, int zeroDigit = 1)
  {
    return (string) null;
  }

  [Token(Token = "0x6000C04")]
  [Address(RVA = "0x4C72428", Offset = "0x4C72428", VA = "0x4C72428")]
  public static string ToStringPercent(this float value) => (string) null;
}
