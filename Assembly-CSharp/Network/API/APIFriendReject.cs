// Decompiled with JetBrains decompiler
// Type: Network.API.APIFriendReject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C65")]
  public class APIFriendReject
  {
    [Token(Token = "0x4007991")]
    public const string DefaultAPIPath = "api/v1/friend/reject";
    [Token(Token = "0x4007995")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007996")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIFriendRejectResponse> onSuccess;
    [Token(Token = "0x4007997")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001FB9")]
    public APIFriendRejectRequest Request
    {
      [Token(Token = "0x600A733"), Address(RVA = "0x190D708", Offset = "0x190D708", VA = "0x190D708")] private get
      {
        return (APIFriendRejectRequest) null;
      }
      [Token(Token = "0x600A734"), Address(RVA = "0x190D710", Offset = "0x190D710", VA = "0x190D710")] set
      {
      }
    }

    [Token(Token = "0x17001FBA")]
    public APIFriendRejectResponse Response
    {
      [Token(Token = "0x600A735"), Address(RVA = "0x190D718", Offset = "0x190D718", VA = "0x190D718")] get
      {
        return (APIFriendRejectResponse) null;
      }
      [Token(Token = "0x600A736"), Address(RVA = "0x190D720", Offset = "0x190D720", VA = "0x190D720")] private set
      {
      }
    }

    [Token(Token = "0x17001FBB")]
    public int ResponseCode
    {
      [Token(Token = "0x600A737"), Address(RVA = "0x190D728", Offset = "0x190D728", VA = "0x190D728")] get
      {
        return new int();
      }
      [Token(Token = "0x600A738"), Address(RVA = "0x190D730", Offset = "0x190D730", VA = "0x190D730")] private set
      {
      }
    }

    [Token(Token = "0x17001FBC")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A739"), Address(RVA = "0x190D738", Offset = "0x190D738", VA = "0x190D738")] set
      {
      }
      [Token(Token = "0x600A73A"), Address(RVA = "0x190D754", Offset = "0x190D754", VA = "0x190D754")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A73B")]
    [Address(RVA = "0x190D770", Offset = "0x190D770", VA = "0x190D770")]
    public APIFriendReject(string apiPath = "api/v1/friend/reject")
    {
    }

    [Token(Token = "0x600A73C")]
    [Address(RVA = "0x190D808", Offset = "0x190D808", VA = "0x190D808")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A73D")]
    [Address(RVA = "0x190D898", Offset = "0x190D898", VA = "0x190D898")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A73E")]
    [Address(RVA = "0x190D8A4", Offset = "0x190D8A4", VA = "0x190D8A4")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A73F")]
    [Address(RVA = "0x190D978", Offset = "0x190D978", VA = "0x190D978")]
    private void OnSuccess(string json)
    {
    }
  }
}
