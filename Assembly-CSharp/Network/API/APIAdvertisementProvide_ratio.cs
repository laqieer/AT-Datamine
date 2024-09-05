// Decompiled with JetBrains decompiler
// Type: Network.API.APIAdvertisementProvide_ratio
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B61")]
  public class APIAdvertisementProvide_ratio
  {
    [Token(Token = "0x4007558")]
    public const string DefaultAPIPath = "api/v1/advertisement/provide_ratio";
    [Token(Token = "0x400755C")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x400755D")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIAdvertisementProvide_ratioResponse> onSuccess;
    [Token(Token = "0x400755E")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001D54")]
    public APIAdvertisementProvide_ratioRequest Request
    {
      [Token(Token = "0x600A0BE"), Address(RVA = "0x46C57B0", Offset = "0x46C57B0", VA = "0x46C57B0")] private get
      {
        return (APIAdvertisementProvide_ratioRequest) null;
      }
      [Token(Token = "0x600A0BF"), Address(RVA = "0x46C57B8", Offset = "0x46C57B8", VA = "0x46C57B8")] set
      {
      }
    }

    [Token(Token = "0x17001D55")]
    public APIAdvertisementProvide_ratioResponse Response
    {
      [Token(Token = "0x600A0C0"), Address(RVA = "0x46C57C0", Offset = "0x46C57C0", VA = "0x46C57C0")] get
      {
        return (APIAdvertisementProvide_ratioResponse) null;
      }
      [Token(Token = "0x600A0C1"), Address(RVA = "0x46C57C8", Offset = "0x46C57C8", VA = "0x46C57C8")] private set
      {
      }
    }

    [Token(Token = "0x17001D56")]
    public int ResponseCode
    {
      [Token(Token = "0x600A0C2"), Address(RVA = "0x46C57D0", Offset = "0x46C57D0", VA = "0x46C57D0")] get
      {
        return new int();
      }
      [Token(Token = "0x600A0C3"), Address(RVA = "0x46C57D8", Offset = "0x46C57D8", VA = "0x46C57D8")] private set
      {
      }
    }

    [Token(Token = "0x17001D57")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A0C4"), Address(RVA = "0x46C57E0", Offset = "0x46C57E0", VA = "0x46C57E0")] set
      {
      }
      [Token(Token = "0x600A0C5"), Address(RVA = "0x46C57FC", Offset = "0x46C57FC", VA = "0x46C57FC")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A0C6")]
    [Address(RVA = "0x46C5818", Offset = "0x46C5818", VA = "0x46C5818")]
    public APIAdvertisementProvide_ratio(string apiPath = "api/v1/advertisement/provide_ratio")
    {
    }

    [Token(Token = "0x600A0C7")]
    [Address(RVA = "0x46C58B0", Offset = "0x46C58B0", VA = "0x46C58B0")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A0C8")]
    [Address(RVA = "0x46C5940", Offset = "0x46C5940", VA = "0x46C5940")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A0C9")]
    [Address(RVA = "0x46C594C", Offset = "0x46C594C", VA = "0x46C594C")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A0CA")]
    [Address(RVA = "0x46C5A20", Offset = "0x46C5A20", VA = "0x46C5A20")]
    private void OnSuccess(string json)
    {
    }
  }
}
