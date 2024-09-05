// Decompiled with JetBrains decompiler
// Type: Network.API.APIFriendAccept
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C51")]
  public class APIFriendAccept
  {
    [Token(Token = "0x4007950")]
    public const string DefaultAPIPath = "api/v1/friend/accept";
    [Token(Token = "0x4007954")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007955")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIFriendAcceptResponse> onSuccess;
    [Token(Token = "0x4007956")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001F94")]
    public APIFriendAcceptRequest Request
    {
      [Token(Token = "0x600A6BE"), Address(RVA = "0x190BC54", Offset = "0x190BC54", VA = "0x190BC54")] private get
      {
        return (APIFriendAcceptRequest) null;
      }
      [Token(Token = "0x600A6BF"), Address(RVA = "0x190BC5C", Offset = "0x190BC5C", VA = "0x190BC5C")] set
      {
      }
    }

    [Token(Token = "0x17001F95")]
    public APIFriendAcceptResponse Response
    {
      [Token(Token = "0x600A6C0"), Address(RVA = "0x190BC64", Offset = "0x190BC64", VA = "0x190BC64")] get
      {
        return (APIFriendAcceptResponse) null;
      }
      [Token(Token = "0x600A6C1"), Address(RVA = "0x190BC6C", Offset = "0x190BC6C", VA = "0x190BC6C")] private set
      {
      }
    }

    [Token(Token = "0x17001F96")]
    public int ResponseCode
    {
      [Token(Token = "0x600A6C2"), Address(RVA = "0x190BC74", Offset = "0x190BC74", VA = "0x190BC74")] get
      {
        return new int();
      }
      [Token(Token = "0x600A6C3"), Address(RVA = "0x190BC7C", Offset = "0x190BC7C", VA = "0x190BC7C")] private set
      {
      }
    }

    [Token(Token = "0x17001F97")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A6C4"), Address(RVA = "0x190BC84", Offset = "0x190BC84", VA = "0x190BC84")] set
      {
      }
      [Token(Token = "0x600A6C5"), Address(RVA = "0x190BCA0", Offset = "0x190BCA0", VA = "0x190BCA0")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A6C6")]
    [Address(RVA = "0x190BCBC", Offset = "0x190BCBC", VA = "0x190BCBC")]
    public APIFriendAccept(string apiPath = "api/v1/friend/accept")
    {
    }

    [Token(Token = "0x600A6C7")]
    [Address(RVA = "0x190BD54", Offset = "0x190BD54", VA = "0x190BD54")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A6C8")]
    [Address(RVA = "0x190BDE4", Offset = "0x190BDE4", VA = "0x190BDE4")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A6C9")]
    [Address(RVA = "0x190BDF0", Offset = "0x190BDF0", VA = "0x190BDF0")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A6CA")]
    [Address(RVA = "0x190BEC4", Offset = "0x190BEC4", VA = "0x190BEC4")]
    private void OnSuccess(string json)
    {
    }
  }
}
