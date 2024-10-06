// Decompiled with JetBrains decompiler
// Type: Network.API.APIExpeditionRapid
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C2D")]
  public class APIExpeditionRapid
  {
    [Token(Token = "0x40078A5")]
    public const string DefaultAPIPath = "api/v1/expedition/rapid";
    [Token(Token = "0x40078A9")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40078AA")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIExpeditionRapidResponse> onSuccess;
    [Token(Token = "0x40078AB")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001F32")]
    public APIExpeditionRapidRequest Request
    {
      [Token(Token = "0x600A5CC"), Address(RVA = "0x1908B48", Offset = "0x1908B48", VA = "0x1908B48")] private get
      {
        return (APIExpeditionRapidRequest) null;
      }
      [Token(Token = "0x600A5CD"), Address(RVA = "0x1908B50", Offset = "0x1908B50", VA = "0x1908B50")] set
      {
      }
    }

    [Token(Token = "0x17001F33")]
    public APIExpeditionRapidResponse Response
    {
      [Token(Token = "0x600A5CE"), Address(RVA = "0x1908B58", Offset = "0x1908B58", VA = "0x1908B58")] get
      {
        return (APIExpeditionRapidResponse) null;
      }
      [Token(Token = "0x600A5CF"), Address(RVA = "0x1908B60", Offset = "0x1908B60", VA = "0x1908B60")] private set
      {
      }
    }

    [Token(Token = "0x17001F34")]
    public int ResponseCode
    {
      [Token(Token = "0x600A5D0"), Address(RVA = "0x1908B68", Offset = "0x1908B68", VA = "0x1908B68")] get
      {
        return new int();
      }
      [Token(Token = "0x600A5D1"), Address(RVA = "0x1908B70", Offset = "0x1908B70", VA = "0x1908B70")] private set
      {
      }
    }

    [Token(Token = "0x17001F35")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A5D2"), Address(RVA = "0x1908B78", Offset = "0x1908B78", VA = "0x1908B78")] set
      {
      }
      [Token(Token = "0x600A5D3"), Address(RVA = "0x1908B94", Offset = "0x1908B94", VA = "0x1908B94")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A5D4")]
    [Address(RVA = "0x1908BB0", Offset = "0x1908BB0", VA = "0x1908BB0")]
    public APIExpeditionRapid(string apiPath = "api/v1/expedition/rapid")
    {
    }

    [Token(Token = "0x600A5D5")]
    [Address(RVA = "0x1908C48", Offset = "0x1908C48", VA = "0x1908C48")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A5D6")]
    [Address(RVA = "0x1908CD8", Offset = "0x1908CD8", VA = "0x1908CD8")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A5D7")]
    [Address(RVA = "0x1908CE4", Offset = "0x1908CE4", VA = "0x1908CE4")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A5D8")]
    [Address(RVA = "0x1908DB8", Offset = "0x1908DB8", VA = "0x1908DB8")]
    private void OnSuccess(string json)
    {
    }
  }
}
