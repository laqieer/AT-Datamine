// Decompiled with JetBrains decompiler
// Type: Network.API.APIPlayerSignup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001DB1")]
  public class APIPlayerSignup
  {
    [Token(Token = "0x4007EE3")]
    public const string DefaultAPIPath = "api/v1/player/signup";
    [Token(Token = "0x4007EE7")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007EE8")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIPlayerSignupResponse> onSuccess;
    [Token(Token = "0x4007EE9")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170022D0")]
    public APIPlayerSignupRequest Request
    {
      [Token(Token = "0x600AF7A"), Address(RVA = "0x1A50244", Offset = "0x1A50244", VA = "0x1A50244")] private get
      {
        return (APIPlayerSignupRequest) null;
      }
      [Token(Token = "0x600AF7B"), Address(RVA = "0x1A5024C", Offset = "0x1A5024C", VA = "0x1A5024C")] set
      {
      }
    }

    [Token(Token = "0x170022D1")]
    public APIPlayerSignupResponse Response
    {
      [Token(Token = "0x600AF7C"), Address(RVA = "0x1A50254", Offset = "0x1A50254", VA = "0x1A50254")] get
      {
        return (APIPlayerSignupResponse) null;
      }
      [Token(Token = "0x600AF7D"), Address(RVA = "0x1A5025C", Offset = "0x1A5025C", VA = "0x1A5025C")] private set
      {
      }
    }

    [Token(Token = "0x170022D2")]
    public int ResponseCode
    {
      [Token(Token = "0x600AF7E"), Address(RVA = "0x1A50264", Offset = "0x1A50264", VA = "0x1A50264")] get
      {
        return new int();
      }
      [Token(Token = "0x600AF7F"), Address(RVA = "0x1A5026C", Offset = "0x1A5026C", VA = "0x1A5026C")] private set
      {
      }
    }

    [Token(Token = "0x170022D3")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600AF80"), Address(RVA = "0x1A50274", Offset = "0x1A50274", VA = "0x1A50274")] set
      {
      }
      [Token(Token = "0x600AF81"), Address(RVA = "0x1A50290", Offset = "0x1A50290", VA = "0x1A50290")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600AF82")]
    [Address(RVA = "0x1A502AC", Offset = "0x1A502AC", VA = "0x1A502AC")]
    public APIPlayerSignup(string apiPath = "api/v1/player/signup")
    {
    }

    [Token(Token = "0x600AF83")]
    [Address(RVA = "0x1A50344", Offset = "0x1A50344", VA = "0x1A50344")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600AF84")]
    [Address(RVA = "0x1A503D4", Offset = "0x1A503D4", VA = "0x1A503D4")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600AF85")]
    [Address(RVA = "0x1A503E0", Offset = "0x1A503E0", VA = "0x1A503E0")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600AF86")]
    [Address(RVA = "0x1A504B4", Offset = "0x1A504B4", VA = "0x1A504B4")]
    private void OnSuccess(string json)
    {
    }
  }
}
