// Decompiled with JetBrains decompiler
// Type: DMM.Games.Client.Sdk.Connection.Endpoint
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace DMM.Games.Client.Sdk.Connection
{
  [Token(Token = "0x2003FCA")]
  public class Endpoint
  {
    [Token(Token = "0x401177C")]
    [FieldOffset(Offset = "0x0")]
    private static readonly string PRODUCTION;
    [Token(Token = "0x401177D")]
    [FieldOffset(Offset = "0x8")]
    private static readonly string SANDBOX;

    [Token(Token = "0x6019A71")]
    [Address(RVA = "0x378871C", Offset = "0x378871C", VA = "0x378871C")]
    protected static string GetHost(bool isSandbox) => (string) null;

    [Token(Token = "0x6019A72")]
    [Address(RVA = "0x3788784", Offset = "0x3788784", VA = "0x3788784")]
    public static string GetUpdateToken(bool isSandbox) => (string) null;

    [Token(Token = "0x6019A73")]
    [Address(RVA = "0x37887F8", Offset = "0x37887F8", VA = "0x37887F8")]
    public static string GetRequest(bool isSandbox) => (string) null;

    [Token(Token = "0x6019A74")]
    [Address(RVA = "0x378886C", Offset = "0x378886C", VA = "0x378886C")]
    public Endpoint()
    {
    }

    [Token(Token = "0x6019A75")]
    [Address(RVA = "0x3788874", Offset = "0x3788874", VA = "0x3788874")]
    static Endpoint()
    {
    }
  }
}
