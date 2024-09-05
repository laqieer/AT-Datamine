// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildInfoGet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001CDD")]
  public class APIGuildInfoGet
  {
    [Token(Token = "0x4007B5A")]
    public const string DefaultAPIPath = "api/v1/guild/info/get";
    [Token(Token = "0x4007B5E")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007B5F")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIGuildInfoGetResponse> onSuccess;
    [Token(Token = "0x4007B60")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170020BD")]
    public APIGuildInfoGetRequest Request
    {
      [Token(Token = "0x600AA17"), Address(RVA = "0x1917860", Offset = "0x1917860", VA = "0x1917860")] private get
      {
        return (APIGuildInfoGetRequest) null;
      }
      [Token(Token = "0x600AA18"), Address(RVA = "0x1917868", Offset = "0x1917868", VA = "0x1917868")] set
      {
      }
    }

    [Token(Token = "0x170020BE")]
    public APIGuildInfoGetResponse Response
    {
      [Token(Token = "0x600AA19"), Address(RVA = "0x1917870", Offset = "0x1917870", VA = "0x1917870")] get
      {
        return (APIGuildInfoGetResponse) null;
      }
      [Token(Token = "0x600AA1A"), Address(RVA = "0x1917878", Offset = "0x1917878", VA = "0x1917878")] private set
      {
      }
    }

    [Token(Token = "0x170020BF")]
    public int ResponseCode
    {
      [Token(Token = "0x600AA1B"), Address(RVA = "0x1917880", Offset = "0x1917880", VA = "0x1917880")] get
      {
        return new int();
      }
      [Token(Token = "0x600AA1C"), Address(RVA = "0x1917888", Offset = "0x1917888", VA = "0x1917888")] private set
      {
      }
    }

    [Token(Token = "0x170020C0")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600AA1D"), Address(RVA = "0x1917890", Offset = "0x1917890", VA = "0x1917890")] set
      {
      }
      [Token(Token = "0x600AA1E"), Address(RVA = "0x19178AC", Offset = "0x19178AC", VA = "0x19178AC")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600AA1F")]
    [Address(RVA = "0x19178C8", Offset = "0x19178C8", VA = "0x19178C8")]
    public APIGuildInfoGet(string apiPath = "api/v1/guild/info/get")
    {
    }

    [Token(Token = "0x600AA20")]
    [Address(RVA = "0x1917960", Offset = "0x1917960", VA = "0x1917960")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600AA21")]
    [Address(RVA = "0x19179F0", Offset = "0x19179F0", VA = "0x19179F0")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600AA22")]
    [Address(RVA = "0x19179FC", Offset = "0x19179FC", VA = "0x19179FC")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600AA23")]
    [Address(RVA = "0x1917AD0", Offset = "0x1917AD0", VA = "0x1917AD0")]
    private void OnSuccess(string json)
    {
    }
  }
}
