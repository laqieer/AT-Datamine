// Decompiled with JetBrains decompiler
// Type: ISAdQualityUtils
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
[Token(Token = "0x2000093")]
public static class ISAdQualityUtils
{
  [Token(Token = "0x4000281")]
  [FieldOffset(Offset = "0x0")]
  private static bool isDebugBuild;
  [Token(Token = "0x4000282")]
  [FieldOffset(Offset = "0x1")]
  private static bool isDebugBuildSet;

  [Token(Token = "0x6000505")]
  [Address(RVA = "0x44B0650", Offset = "0x44B0650", VA = "0x44B0650")]
  public static void LogDebug(string tag, string message)
  {
  }

  [Token(Token = "0x6000506")]
  [Address(RVA = "0x44B0854", Offset = "0x44B0854", VA = "0x44B0854")]
  public static void LogError(string tag, string message)
  {
  }

  [Token(Token = "0x6000507")]
  [Address(RVA = "0x44B08E8", Offset = "0x44B08E8", VA = "0x44B08E8")]
  public static void LogWarning(string tag, string message)
  {
  }

  [Token(Token = "0x6000508")]
  [Address(RVA = "0x44B097C", Offset = "0x44B097C", VA = "0x44B097C")]
  public static string GetClassName(object target) => (string) null;
}
