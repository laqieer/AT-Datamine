// Decompiled with JetBrains decompiler
// Type: Network.API.APIFriendCancel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C59")]
  public class APIFriendCancel
  {
    [Token(Token = "0x400796A")]
    public const string DefaultAPIPath = "api/v1/friend/cancel";
    [Token(Token = "0x400796E")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x400796F")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIFriendCancelResponse> onSuccess;
    [Token(Token = "0x4007970")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001FA2")]
    public APIFriendCancelRequest Request
    {
      [Token(Token = "0x600A6EC"), Address(RVA = "0x190C6FC", Offset = "0x190C6FC", VA = "0x190C6FC")] private get
      {
        return (APIFriendCancelRequest) null;
      }
      [Token(Token = "0x600A6ED"), Address(RVA = "0x190C704", Offset = "0x190C704", VA = "0x190C704")] set
      {
      }
    }

    [Token(Token = "0x17001FA3")]
    public APIFriendCancelResponse Response
    {
      [Token(Token = "0x600A6EE"), Address(RVA = "0x190C70C", Offset = "0x190C70C", VA = "0x190C70C")] get
      {
        return (APIFriendCancelResponse) null;
      }
      [Token(Token = "0x600A6EF"), Address(RVA = "0x190C714", Offset = "0x190C714", VA = "0x190C714")] private set
      {
      }
    }

    [Token(Token = "0x17001FA4")]
    public int ResponseCode
    {
      [Token(Token = "0x600A6F0"), Address(RVA = "0x190C71C", Offset = "0x190C71C", VA = "0x190C71C")] get
      {
        return new int();
      }
      [Token(Token = "0x600A6F1"), Address(RVA = "0x190C724", Offset = "0x190C724", VA = "0x190C724")] private set
      {
      }
    }

    [Token(Token = "0x17001FA5")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A6F2"), Address(RVA = "0x190C72C", Offset = "0x190C72C", VA = "0x190C72C")] set
      {
      }
      [Token(Token = "0x600A6F3"), Address(RVA = "0x190C748", Offset = "0x190C748", VA = "0x190C748")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A6F4")]
    [Address(RVA = "0x190C764", Offset = "0x190C764", VA = "0x190C764")]
    public APIFriendCancel(string apiPath = "api/v1/friend/cancel")
    {
    }

    [Token(Token = "0x600A6F5")]
    [Address(RVA = "0x190C7FC", Offset = "0x190C7FC", VA = "0x190C7FC")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A6F6")]
    [Address(RVA = "0x190C88C", Offset = "0x190C88C", VA = "0x190C88C")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A6F7")]
    [Address(RVA = "0x190C898", Offset = "0x190C898", VA = "0x190C898")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A6F8")]
    [Address(RVA = "0x190C96C", Offset = "0x190C96C", VA = "0x190C96C")]
    private void OnSuccess(string json)
    {
    }
  }
}
