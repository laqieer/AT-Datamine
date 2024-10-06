// Decompiled with JetBrains decompiler
// Type: DMM.Games.Client.Sdk.Sample.NetGameApiSdkArgsModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace DMM.Games.Client.Sdk.Sample
{
  [Token(Token = "0x2003FCD")]
  public class NetGameApiSdkArgsModel
  {
    [Token(Token = "0x4011788")]
    [FieldOffset(Offset = "0x0")]
    protected static readonly string DEFAULT_PREFIX;
    [Token(Token = "0x4011789")]
    [FieldOffset(Offset = "0x8")]
    protected static readonly string KEY_VIEWER_ID;
    [Token(Token = "0x401178A")]
    [FieldOffset(Offset = "0x10")]
    protected static readonly string KEY_ONETIME_TOKEN;
    [Token(Token = "0x401178B")]
    [FieldOffset(Offset = "0x18")]
    protected static readonly string KEY_ACCESS_TOKEN;

    [Token(Token = "0x170052B2")]
    public string ViewerId
    {
      [Token(Token = "0x6019A83"), Address(RVA = "0x3788CD8", Offset = "0x3788CD8", VA = "0x3788CD8")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6019A84"), Address(RVA = "0x3788CE0", Offset = "0x3788CE0", VA = "0x3788CE0")] protected set
      {
      }
    }

    [Token(Token = "0x170052B3")]
    public string AccessToken
    {
      [Token(Token = "0x6019A85"), Address(RVA = "0x3788CE8", Offset = "0x3788CE8", VA = "0x3788CE8")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6019A86"), Address(RVA = "0x3788CF0", Offset = "0x3788CF0", VA = "0x3788CF0")] protected set
      {
      }
    }

    [Token(Token = "0x170052B4")]
    public string OnetimeToken
    {
      [Token(Token = "0x6019A87"), Address(RVA = "0x3788CF8", Offset = "0x3788CF8", VA = "0x3788CF8")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6019A88"), Address(RVA = "0x3788D00", Offset = "0x3788D00", VA = "0x3788D00")] protected set
      {
      }
    }

    [Token(Token = "0x6019A89")]
    [Address(RVA = "0x3788D08", Offset = "0x3788D08", VA = "0x3788D08")]
    public NetGameApiSdkArgsModel()
    {
    }

    [Token(Token = "0x6019A8A")]
    [Address(RVA = "0x3788D68", Offset = "0x3788D68", VA = "0x3788D68")]
    public static NetGameApiSdkArgsModel Load() => (NetGameApiSdkArgsModel) null;

    [Token(Token = "0x6019A8B")]
    [Address(RVA = "0x3788DC0", Offset = "0x3788DC0", VA = "0x3788DC0")]
    public static NetGameApiSdkArgsModel Load(string prefix) => (NetGameApiSdkArgsModel) null;

    [Token(Token = "0x6019A8C")]
    [Address(RVA = "0x3788E28", Offset = "0x3788E28", VA = "0x3788E28")]
    public static NetGameApiSdkArgsModel Parse(string[] args, string prefix)
    {
      return (NetGameApiSdkArgsModel) null;
    }

    [Token(Token = "0x6019A8D")]
    [Address(RVA = "0x3789028", Offset = "0x3789028", VA = "0x3789028")]
    static NetGameApiSdkArgsModel()
    {
    }
  }
}
