// Decompiled with JetBrains decompiler
// Type: Network.API.APIFriendGiftSend
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C5D")]
  public class APIFriendGiftSend
  {
    [Token(Token = "0x4007976")]
    public const string DefaultAPIPath = "api/v1/friend/gift/send";
    [Token(Token = "0x400797A")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x400797B")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIFriendGiftSendResponse> onSuccess;
    [Token(Token = "0x400797C")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001FA9")]
    public APIFriendGiftSendRequest Request
    {
      [Token(Token = "0x600A703"), Address(RVA = "0x190CC50", Offset = "0x190CC50", VA = "0x190CC50")] private get
      {
        return (APIFriendGiftSendRequest) null;
      }
      [Token(Token = "0x600A704"), Address(RVA = "0x190CC58", Offset = "0x190CC58", VA = "0x190CC58")] set
      {
      }
    }

    [Token(Token = "0x17001FAA")]
    public APIFriendGiftSendResponse Response
    {
      [Token(Token = "0x600A705"), Address(RVA = "0x190CC60", Offset = "0x190CC60", VA = "0x190CC60")] get
      {
        return (APIFriendGiftSendResponse) null;
      }
      [Token(Token = "0x600A706"), Address(RVA = "0x190CC68", Offset = "0x190CC68", VA = "0x190CC68")] private set
      {
      }
    }

    [Token(Token = "0x17001FAB")]
    public int ResponseCode
    {
      [Token(Token = "0x600A707"), Address(RVA = "0x190CC70", Offset = "0x190CC70", VA = "0x190CC70")] get
      {
        return new int();
      }
      [Token(Token = "0x600A708"), Address(RVA = "0x190CC78", Offset = "0x190CC78", VA = "0x190CC78")] private set
      {
      }
    }

    [Token(Token = "0x17001FAC")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A709"), Address(RVA = "0x190CC80", Offset = "0x190CC80", VA = "0x190CC80")] set
      {
      }
      [Token(Token = "0x600A70A"), Address(RVA = "0x190CC9C", Offset = "0x190CC9C", VA = "0x190CC9C")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A70B")]
    [Address(RVA = "0x190CCB8", Offset = "0x190CCB8", VA = "0x190CCB8")]
    public APIFriendGiftSend(string apiPath = "api/v1/friend/gift/send")
    {
    }

    [Token(Token = "0x600A70C")]
    [Address(RVA = "0x190CD50", Offset = "0x190CD50", VA = "0x190CD50")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A70D")]
    [Address(RVA = "0x190CDE0", Offset = "0x190CDE0", VA = "0x190CDE0")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A70E")]
    [Address(RVA = "0x190CDEC", Offset = "0x190CDEC", VA = "0x190CDEC")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A70F")]
    [Address(RVA = "0x190CEC0", Offset = "0x190CEC0", VA = "0x190CEC0")]
    private void OnSuccess(string json)
    {
    }
  }
}
