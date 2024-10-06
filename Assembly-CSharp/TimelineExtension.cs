// Decompiled with JetBrains decompiler
// Type: TimelineExtension
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine.Timeline;

#nullable disable
[Token(Token = "0x200019F")]
public static class TimelineExtension
{
  [Token(Token = "0x4000A6F")]
  [FieldOffset(Offset = "0x0")]
  private static readonly string POST_EXTRAP_MODE_INTERNAL_FIELD;
  [Token(Token = "0x4000A70")]
  [FieldOffset(Offset = "0x8")]
  private static readonly string PRE_EXTRAP_MODE_INTERNAL_FIELD;
  [Token(Token = "0x4000A71")]
  [FieldOffset(Offset = "0x10")]
  private static readonly string POST_EXTRAP_TIME_INTERNAL_FIELD;
  [Token(Token = "0x4000A72")]
  [FieldOffset(Offset = "0x18")]
  private static readonly string PRE_EXTRAP_TIME_INTERNAL_FIELD;

  [Token(Token = "0x6000AF6")]
  [Address(RVA = "0x4BBCDFC", Offset = "0x4BBCDFC", VA = "0x4BBCDFC")]
  public static void SetPreExtrapolationMode(
    this TimelineClip clip,
    TimelineClip.ClipExtrapolation extrapolationMode)
  {
  }

  [Token(Token = "0x6000AF7")]
  [Address(RVA = "0x4BBCE84", Offset = "0x4BBCE84", VA = "0x4BBCE84")]
  public static void SetPreExtrapolationTime(this TimelineClip clip, double time)
  {
  }

  [Token(Token = "0x6000AF8")]
  [Address(RVA = "0x4BBCF0C", Offset = "0x4BBCF0C", VA = "0x4BBCF0C")]
  public static double GetPreExtrapolationTime(this TimelineClip clip) => new double();

  [Token(Token = "0x6000AF9")]
  [Address(RVA = "0x4BBCF84", Offset = "0x4BBCF84", VA = "0x4BBCF84")]
  public static void SetPostExtrapolationMode(
    this TimelineClip clip,
    TimelineClip.ClipExtrapolation extrapolationMode)
  {
  }

  [Token(Token = "0x6000AFA")]
  [Address(RVA = "0x4BBD00C", Offset = "0x4BBD00C", VA = "0x4BBD00C")]
  public static void SetPostExtrapolationTime(this TimelineClip clip, double time)
  {
  }

  [Token(Token = "0x6000AFB")]
  [Address(RVA = "0x4BBD094", Offset = "0x4BBD094", VA = "0x4BBD094")]
  public static double GetPostExtrapolationTime(this TimelineClip clip) => new double();

  [Token(Token = "0x6000AFC")]
  public static T GetPrivateFieldValue<T>(this object obj, string propName) => (T) null;

  [Token(Token = "0x6000AFD")]
  public static void SetPrivateFieldValue<T>(this object obj, string propName, T val)
  {
  }

  [Token(Token = "0x6000AFE")]
  [Address(RVA = "0x4BBD10C", Offset = "0x4BBD10C", VA = "0x4BBD10C")]
  static TimelineExtension()
  {
  }
}
