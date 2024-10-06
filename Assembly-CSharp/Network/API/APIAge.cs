// Decompiled with JetBrains decompiler
// Type: Network.API.APIAge
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B65")]
  public class APIAge
  {
    [Token(Token = "0x4007567")]
    public const string DefaultAPIPath = "api/charge/age";
    [Token(Token = "0x400756B")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x400756C")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIAgeResponse> onSuccess;
    [Token(Token = "0x400756D")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001D5B")]
    public APIAgeRequest Request
    {
      [Token(Token = "0x600A0D5"), Address(RVA = "0x46C5D04", Offset = "0x46C5D04", VA = "0x46C5D04")] private get
      {
        return (APIAgeRequest) null;
      }
      [Token(Token = "0x600A0D6"), Address(RVA = "0x46C5D0C", Offset = "0x46C5D0C", VA = "0x46C5D0C")] set
      {
      }
    }

    [Token(Token = "0x17001D5C")]
    public APIAgeResponse Response
    {
      [Token(Token = "0x600A0D7"), Address(RVA = "0x46C5D14", Offset = "0x46C5D14", VA = "0x46C5D14")] get
      {
        return (APIAgeResponse) null;
      }
      [Token(Token = "0x600A0D8"), Address(RVA = "0x46C5D1C", Offset = "0x46C5D1C", VA = "0x46C5D1C")] private set
      {
      }
    }

    [Token(Token = "0x17001D5D")]
    public int ResponseCode
    {
      [Token(Token = "0x600A0D9"), Address(RVA = "0x46C5D24", Offset = "0x46C5D24", VA = "0x46C5D24")] get
      {
        return new int();
      }
      [Token(Token = "0x600A0DA"), Address(RVA = "0x46C5D2C", Offset = "0x46C5D2C", VA = "0x46C5D2C")] private set
      {
      }
    }

    [Token(Token = "0x17001D5E")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A0DB"), Address(RVA = "0x46C5D34", Offset = "0x46C5D34", VA = "0x46C5D34")] set
      {
      }
      [Token(Token = "0x600A0DC"), Address(RVA = "0x46C5D50", Offset = "0x46C5D50", VA = "0x46C5D50")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A0DD")]
    [Address(RVA = "0x46C5D6C", Offset = "0x46C5D6C", VA = "0x46C5D6C")]
    public APIAge(string apiPath = "api/charge/age")
    {
    }

    [Token(Token = "0x600A0DE")]
    [Address(RVA = "0x46C5E04", Offset = "0x46C5E04", VA = "0x46C5E04")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A0DF")]
    [Address(RVA = "0x46C5E94", Offset = "0x46C5E94", VA = "0x46C5E94")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A0E0")]
    [Address(RVA = "0x46C5EA0", Offset = "0x46C5EA0", VA = "0x46C5EA0")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A0E1")]
    [Address(RVA = "0x46C5F74", Offset = "0x46C5F74", VA = "0x46C5F74")]
    private void OnSuccess(string json)
    {
    }
  }
}
