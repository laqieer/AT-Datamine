// Decompiled with JetBrains decompiler
// Type: Network.API.APIFriendRemove
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C69")]
  public class APIFriendRemove
  {
    [Token(Token = "0x400799E")]
    public const string DefaultAPIPath = "api/v1/friend/remove";
    [Token(Token = "0x40079A2")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40079A3")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIFriendRemoveResponse> onSuccess;
    [Token(Token = "0x40079A4")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001FC0")]
    public APIFriendRemoveRequest Request
    {
      [Token(Token = "0x600A74A"), Address(RVA = "0x190DC5C", Offset = "0x190DC5C", VA = "0x190DC5C")] private get
      {
        return (APIFriendRemoveRequest) null;
      }
      [Token(Token = "0x600A74B"), Address(RVA = "0x190DC64", Offset = "0x190DC64", VA = "0x190DC64")] set
      {
      }
    }

    [Token(Token = "0x17001FC1")]
    public APIFriendRemoveResponse Response
    {
      [Token(Token = "0x600A74C"), Address(RVA = "0x190DC6C", Offset = "0x190DC6C", VA = "0x190DC6C")] get
      {
        return (APIFriendRemoveResponse) null;
      }
      [Token(Token = "0x600A74D"), Address(RVA = "0x190DC74", Offset = "0x190DC74", VA = "0x190DC74")] private set
      {
      }
    }

    [Token(Token = "0x17001FC2")]
    public int ResponseCode
    {
      [Token(Token = "0x600A74E"), Address(RVA = "0x190DC7C", Offset = "0x190DC7C", VA = "0x190DC7C")] get
      {
        return new int();
      }
      [Token(Token = "0x600A74F"), Address(RVA = "0x190DC84", Offset = "0x190DC84", VA = "0x190DC84")] private set
      {
      }
    }

    [Token(Token = "0x17001FC3")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A750"), Address(RVA = "0x190DC8C", Offset = "0x190DC8C", VA = "0x190DC8C")] set
      {
      }
      [Token(Token = "0x600A751"), Address(RVA = "0x190DCA8", Offset = "0x190DCA8", VA = "0x190DCA8")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A752")]
    [Address(RVA = "0x190DCC4", Offset = "0x190DCC4", VA = "0x190DCC4")]
    public APIFriendRemove(string apiPath = "api/v1/friend/remove")
    {
    }

    [Token(Token = "0x600A753")]
    [Address(RVA = "0x190DD5C", Offset = "0x190DD5C", VA = "0x190DD5C")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A754")]
    [Address(RVA = "0x190DDEC", Offset = "0x190DDEC", VA = "0x190DDEC")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A755")]
    [Address(RVA = "0x190DDF8", Offset = "0x190DDF8", VA = "0x190DDF8")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A756")]
    [Address(RVA = "0x190DECC", Offset = "0x190DECC", VA = "0x190DECC")]
    private void OnSuccess(string json)
    {
    }
  }
}
