// Decompiled with JetBrains decompiler
// Type: DataLinkage.DeepLinkData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace DataLinkage
{
  [Token(Token = "0x2001F88")]
  public class DeepLinkData
  {
    [Token(Token = "0x40086E8")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<string, string> Querys;

    [Token(Token = "0x170026CB")]
    public string OriginalURL
    {
      [Token(Token = "0x600BB3A"), Address(RVA = "0x1E4BDA8", Offset = "0x1E4BDA8", VA = "0x1E4BDA8")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600BB3B"), Address(RVA = "0x1E4BDB0", Offset = "0x1E4BDB0", VA = "0x1E4BDB0")] private set
      {
      }
    }

    [Token(Token = "0x170026CC")]
    public Uri ConvertedUri
    {
      [Token(Token = "0x600BB3C"), Address(RVA = "0x1E4BDB8", Offset = "0x1E4BDB8", VA = "0x1E4BDB8")] get
      {
        return (Uri) null;
      }
      [Token(Token = "0x600BB3D"), Address(RVA = "0x1E4BDC0", Offset = "0x1E4BDC0", VA = "0x1E4BDC0")] private set
      {
      }
    }

    [Token(Token = "0x170026CD")]
    public bool HasError
    {
      [Token(Token = "0x600BB3E"), Address(RVA = "0x1E4BDC8", Offset = "0x1E4BDC8", VA = "0x1E4BDC8")] get
      {
        return new bool();
      }
      [Token(Token = "0x600BB3F"), Address(RVA = "0x1E4BDD0", Offset = "0x1E4BDD0", VA = "0x1E4BDD0")] private set
      {
      }
    }

    [Token(Token = "0x600BB40")]
    [Address(RVA = "0x1E4BDDC", Offset = "0x1E4BDDC", VA = "0x1E4BDDC")]
    public static DeepLinkData CreateFromURL(Uri uri) => (DeepLinkData) null;

    [Token(Token = "0x600BB41")]
    [Address(RVA = "0x1E4C398", Offset = "0x1E4C398", VA = "0x1E4C398")]
    public bool TryGetQueryValue(string name, out string value) => new bool();

    [Token(Token = "0x600BB42")]
    [Address(RVA = "0x1E4BFC0", Offset = "0x1E4BFC0", VA = "0x1E4BFC0")]
    public static Dictionary<string, string> ParseQueryString(string query)
    {
      return (Dictionary<string, string>) null;
    }

    [Token(Token = "0x600BB43")]
    [Address(RVA = "0x1E4BF44", Offset = "0x1E4BF44", VA = "0x1E4BF44")]
    public DeepLinkData()
    {
    }
  }
}
