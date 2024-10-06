// Decompiled with JetBrains decompiler
// Type: Network.API.APIFriendSearch
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C6D")]
  public class APIFriendSearch
  {
    [Token(Token = "0x40079AE")]
    public const string DefaultAPIPath = "api/v1/friend/search";
    [Token(Token = "0x40079B2")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40079B3")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIFriendSearchResponse> onSuccess;
    [Token(Token = "0x40079B4")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001FCA")]
    public APIFriendSearchRequest Request
    {
      [Token(Token = "0x600A764"), Address(RVA = "0x190E1C8", Offset = "0x190E1C8", VA = "0x190E1C8")] private get
      {
        return (APIFriendSearchRequest) null;
      }
      [Token(Token = "0x600A765"), Address(RVA = "0x190E1D0", Offset = "0x190E1D0", VA = "0x190E1D0")] set
      {
      }
    }

    [Token(Token = "0x17001FCB")]
    public APIFriendSearchResponse Response
    {
      [Token(Token = "0x600A766"), Address(RVA = "0x190E1D8", Offset = "0x190E1D8", VA = "0x190E1D8")] get
      {
        return (APIFriendSearchResponse) null;
      }
      [Token(Token = "0x600A767"), Address(RVA = "0x190E1E0", Offset = "0x190E1E0", VA = "0x190E1E0")] private set
      {
      }
    }

    [Token(Token = "0x17001FCC")]
    public int ResponseCode
    {
      [Token(Token = "0x600A768"), Address(RVA = "0x190E1E8", Offset = "0x190E1E8", VA = "0x190E1E8")] get
      {
        return new int();
      }
      [Token(Token = "0x600A769"), Address(RVA = "0x190E1F0", Offset = "0x190E1F0", VA = "0x190E1F0")] private set
      {
      }
    }

    [Token(Token = "0x17001FCD")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A76A"), Address(RVA = "0x190E1F8", Offset = "0x190E1F8", VA = "0x190E1F8")] set
      {
      }
      [Token(Token = "0x600A76B"), Address(RVA = "0x190E214", Offset = "0x190E214", VA = "0x190E214")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A76C")]
    [Address(RVA = "0x190E230", Offset = "0x190E230", VA = "0x190E230")]
    public APIFriendSearch(string apiPath = "api/v1/friend/search")
    {
    }

    [Token(Token = "0x600A76D")]
    [Address(RVA = "0x190E2C8", Offset = "0x190E2C8", VA = "0x190E2C8")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A76E")]
    [Address(RVA = "0x190E358", Offset = "0x190E358", VA = "0x190E358")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A76F")]
    [Address(RVA = "0x190E364", Offset = "0x190E364", VA = "0x190E364")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A770")]
    [Address(RVA = "0x190E438", Offset = "0x190E438", VA = "0x190E438")]
    private void OnSuccess(string json)
    {
    }
  }
}
