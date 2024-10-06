// Decompiled with JetBrains decompiler
// Type: GameCore.URLScheme.URLSchemeUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.URLScheme
{
  [Token(Token = "0x2000BDD")]
  public static class URLSchemeUtility
  {
    [Token(Token = "0x40035EC")]
    [FieldOffset(Offset = "0x0")]
    public static string SerialCodeHost;
    [Token(Token = "0x40035ED")]
    [FieldOffset(Offset = "0x8")]
    public static string iOSUniversalLinkHost;
    [Token(Token = "0x40035EE")]
    [FieldOffset(Offset = "0x10")]
    public static string CustomURLScheme;

    [Token(Token = "0x60043D0")]
    [Address(RVA = "0x364329C", Offset = "0x364329C", VA = "0x364329C")]
    public static List<Uri> CreateUris(string[] urls) => (List<Uri>) null;

    [Token(Token = "0x60043D1")]
    [Address(RVA = "0x3643C8C", Offset = "0x3643C8C", VA = "0x3643C8C")]
    public static Uri ConvertUniversalLinkToCustomURLSchemeUri(Uri uri) => (Uri) null;

    [Token(Token = "0x60043D2")]
    [Address(RVA = "0x3643E68", Offset = "0x3643E68", VA = "0x3643E68")]
    static URLSchemeUtility()
    {
    }
  }
}
