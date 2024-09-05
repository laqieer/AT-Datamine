// Decompiled with JetBrains decompiler
// Type: Network.API.APIAccessoryOption_change_request
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B49")]
  public class APIAccessoryOption_change_request
  {
    [Token(Token = "0x4007504")]
    public const string DefaultAPIPath = "api/v1/accessory/option_change_request";
    [Token(Token = "0x4007508")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007509")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIAccessoryOption_change_requestResponse> onSuccess;
    [Token(Token = "0x400750A")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001D27")]
    public APIAccessoryOption_change_requestRequest Request
    {
      [Token(Token = "0x600A031"), Address(RVA = "0x46C37A0", Offset = "0x46C37A0", VA = "0x46C37A0")] private get
      {
        return (APIAccessoryOption_change_requestRequest) null;
      }
      [Token(Token = "0x600A032"), Address(RVA = "0x46C37A8", Offset = "0x46C37A8", VA = "0x46C37A8")] set
      {
      }
    }

    [Token(Token = "0x17001D28")]
    public APIAccessoryOption_change_requestResponse Response
    {
      [Token(Token = "0x600A033"), Address(RVA = "0x46C37B0", Offset = "0x46C37B0", VA = "0x46C37B0")] get
      {
        return (APIAccessoryOption_change_requestResponse) null;
      }
      [Token(Token = "0x600A034"), Address(RVA = "0x46C37B8", Offset = "0x46C37B8", VA = "0x46C37B8")] private set
      {
      }
    }

    [Token(Token = "0x17001D29")]
    public int ResponseCode
    {
      [Token(Token = "0x600A035"), Address(RVA = "0x46C37C0", Offset = "0x46C37C0", VA = "0x46C37C0")] get
      {
        return new int();
      }
      [Token(Token = "0x600A036"), Address(RVA = "0x46C37C8", Offset = "0x46C37C8", VA = "0x46C37C8")] private set
      {
      }
    }

    [Token(Token = "0x17001D2A")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A037"), Address(RVA = "0x46C37D0", Offset = "0x46C37D0", VA = "0x46C37D0")] set
      {
      }
      [Token(Token = "0x600A038"), Address(RVA = "0x46C37EC", Offset = "0x46C37EC", VA = "0x46C37EC")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A039")]
    [Address(RVA = "0x46C3808", Offset = "0x46C3808", VA = "0x46C3808")]
    public APIAccessoryOption_change_request(string apiPath = "api/v1/accessory/option_change_request")
    {
    }

    [Token(Token = "0x600A03A")]
    [Address(RVA = "0x46C38A0", Offset = "0x46C38A0", VA = "0x46C38A0")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A03B")]
    [Address(RVA = "0x46C3930", Offset = "0x46C3930", VA = "0x46C3930")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A03C")]
    [Address(RVA = "0x46C393C", Offset = "0x46C393C", VA = "0x46C393C")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A03D")]
    [Address(RVA = "0x46C3A10", Offset = "0x46C3A10", VA = "0x46C3A10")]
    private void OnSuccess(string json)
    {
    }
  }
}
