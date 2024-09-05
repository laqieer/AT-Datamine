// Decompiled with JetBrains decompiler
// Type: GameCore.InAppBrowser.InAppBrowserUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace GameCore.InAppBrowser
{
  [Token(Token = "0x200145A")]
  public static class InAppBrowserUtility
  {
    [Token(Token = "0x4005DD1")]
    [FieldOffset(Offset = "0x0")]
    private static Action<string> OnCompletionCallback;

    [Token(Token = "0x60072C3")]
    [Address(RVA = "0x4051C38", Offset = "0x4051C38", VA = "0x4051C38")]
    public static IInAppBrowser Create() => (IInAppBrowser) null;

    [Token(Token = "0x60072C4")]
    [Address(RVA = "0x4051C40", Offset = "0x4051C40", VA = "0x4051C40")]
    public static void AddCompletionCallback(Action<string> callback)
    {
    }

    [Token(Token = "0x60072C5")]
    [Address(RVA = "0x4051D04", Offset = "0x4051D04", VA = "0x4051D04")]
    public static void SubCompletionCallback(Action<string> callback)
    {
    }

    [Token(Token = "0x60072C6")]
    [Address(RVA = "0x4051DC8", Offset = "0x4051DC8", VA = "0x4051DC8")]
    public static void InvokeCompletionCallback(string url)
    {
    }

    [Token(Token = "0x60072C7")]
    [Address(RVA = "0x4051E2C", Offset = "0x4051E2C", VA = "0x4051E2C")]
    public static bool CanUseInAppBrowser() => new bool();
  }
}
