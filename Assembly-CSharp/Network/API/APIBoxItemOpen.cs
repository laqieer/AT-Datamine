// Decompiled with JetBrains decompiler
// Type: Network.API.APIBoxItemOpen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001BBD")]
  public class APIBoxItemOpen
  {
    [Token(Token = "0x40076E3")]
    public const string DefaultAPIPath = "api/v1/item/box_item_open";
    [Token(Token = "0x40076E7")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40076E8")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIBoxItemOpenResponse> onSuccess;
    [Token(Token = "0x40076E9")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001E2A")]
    public APIBoxItemOpenRequest Request
    {
      [Token(Token = "0x600A304"), Address(RVA = "0x46CD3E4", Offset = "0x46CD3E4", VA = "0x46CD3E4")] private get
      {
        return (APIBoxItemOpenRequest) null;
      }
      [Token(Token = "0x600A305"), Address(RVA = "0x46CD3EC", Offset = "0x46CD3EC", VA = "0x46CD3EC")] set
      {
      }
    }

    [Token(Token = "0x17001E2B")]
    public APIBoxItemOpenResponse Response
    {
      [Token(Token = "0x600A306"), Address(RVA = "0x46CD3F4", Offset = "0x46CD3F4", VA = "0x46CD3F4")] get
      {
        return (APIBoxItemOpenResponse) null;
      }
      [Token(Token = "0x600A307"), Address(RVA = "0x46CD3FC", Offset = "0x46CD3FC", VA = "0x46CD3FC")] private set
      {
      }
    }

    [Token(Token = "0x17001E2C")]
    public int ResponseCode
    {
      [Token(Token = "0x600A308"), Address(RVA = "0x46CD404", Offset = "0x46CD404", VA = "0x46CD404")] get
      {
        return new int();
      }
      [Token(Token = "0x600A309"), Address(RVA = "0x46CD40C", Offset = "0x46CD40C", VA = "0x46CD40C")] private set
      {
      }
    }

    [Token(Token = "0x17001E2D")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A30A"), Address(RVA = "0x46CD414", Offset = "0x46CD414", VA = "0x46CD414")] set
      {
      }
      [Token(Token = "0x600A30B"), Address(RVA = "0x46CD430", Offset = "0x46CD430", VA = "0x46CD430")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A30C")]
    [Address(RVA = "0x46CD44C", Offset = "0x46CD44C", VA = "0x46CD44C")]
    public APIBoxItemOpen(string apiPath = "api/v1/item/box_item_open")
    {
    }

    [Token(Token = "0x600A30D")]
    [Address(RVA = "0x46CD4E4", Offset = "0x46CD4E4", VA = "0x46CD4E4")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A30E")]
    [Address(RVA = "0x46CD574", Offset = "0x46CD574", VA = "0x46CD574")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A30F")]
    [Address(RVA = "0x46CD580", Offset = "0x46CD580", VA = "0x46CD580")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A310")]
    [Address(RVA = "0x46CD654", Offset = "0x46CD654", VA = "0x46CD654")]
    private void OnSuccess(string json)
    {
    }
  }
}
