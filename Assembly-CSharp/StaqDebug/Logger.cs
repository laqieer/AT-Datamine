// Decompiled with JetBrains decompiler
// Type: StaqDebug.Logger
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Diagnostics;

#nullable disable
namespace StaqDebug
{
  [Token(Token = "0x2001F66")]
  public static class Logger
  {
    [Token(Token = "0x400867B")]
    [FieldOffset(Offset = "0x0")]
    public static bool IsLogEnable;

    [Token(Token = "0x600BA64")]
    [Address(RVA = "0x1E45168", Offset = "0x1E45168", VA = "0x1E45168")]
    [Conditional("UNITY_EDITOR")]
    public static void Log(object o)
    {
    }

    [Token(Token = "0x600BA65")]
    [Address(RVA = "0x1E45200", Offset = "0x1E45200", VA = "0x1E45200")]
    [Conditional("UNITY_EDITOR")]
    public static void LogWarning(object o)
    {
    }

    [Token(Token = "0x600BA66")]
    [Address(RVA = "0x1E45298", Offset = "0x1E45298", VA = "0x1E45298")]
    [Conditional("UNITY_EDITOR")]
    public static void LogError(object o)
    {
    }

    [Token(Token = "0x600BA67")]
    [Address(RVA = "0x1E452F0", Offset = "0x1E452F0", VA = "0x1E452F0")]
    [Conditional("UNITY_EDITOR")]
    public static void LogException(Exception e)
    {
    }

    [Token(Token = "0x600BA68")]
    [Address(RVA = "0x1E45348", Offset = "0x1E45348", VA = "0x1E45348")]
    static Logger()
    {
    }
  }
}
