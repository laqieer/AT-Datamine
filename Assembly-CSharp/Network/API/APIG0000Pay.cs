// Decompiled with JetBrains decompiler
// Type: Network.API.APIG0000Pay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C75")]
  public class APIG0000Pay
  {
    [Token(Token = "0x40079CD")]
    public const string DefaultAPIPath = "api/gacha/G0000/pay";
    [Token(Token = "0x40079D1")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40079D2")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIG0000PayResponse> onSuccess;
    [Token(Token = "0x40079D3")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001FDD")]
    public APIG0000PayRequest Request
    {
      [Token(Token = "0x600A797"), Address(RVA = "0x190EC98", Offset = "0x190EC98", VA = "0x190EC98")] private get
      {
        return (APIG0000PayRequest) null;
      }
      [Token(Token = "0x600A798"), Address(RVA = "0x190ECA0", Offset = "0x190ECA0", VA = "0x190ECA0")] set
      {
      }
    }

    [Token(Token = "0x17001FDE")]
    public APIG0000PayResponse Response
    {
      [Token(Token = "0x600A799"), Address(RVA = "0x190ECA8", Offset = "0x190ECA8", VA = "0x190ECA8")] get
      {
        return (APIG0000PayResponse) null;
      }
      [Token(Token = "0x600A79A"), Address(RVA = "0x190ECB0", Offset = "0x190ECB0", VA = "0x190ECB0")] private set
      {
      }
    }

    [Token(Token = "0x17001FDF")]
    public int ResponseCode
    {
      [Token(Token = "0x600A79B"), Address(RVA = "0x190ECB8", Offset = "0x190ECB8", VA = "0x190ECB8")] get
      {
        return new int();
      }
      [Token(Token = "0x600A79C"), Address(RVA = "0x190ECC0", Offset = "0x190ECC0", VA = "0x190ECC0")] private set
      {
      }
    }

    [Token(Token = "0x17001FE0")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A79D"), Address(RVA = "0x190ECC8", Offset = "0x190ECC8", VA = "0x190ECC8")] set
      {
      }
      [Token(Token = "0x600A79E"), Address(RVA = "0x190ECE4", Offset = "0x190ECE4", VA = "0x190ECE4")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A79F")]
    [Address(RVA = "0x190ED00", Offset = "0x190ED00", VA = "0x190ED00")]
    public APIG0000Pay(string apiPath = "api/gacha/G0000/pay")
    {
    }

    [Token(Token = "0x600A7A0")]
    [Address(RVA = "0x190ED98", Offset = "0x190ED98", VA = "0x190ED98")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A7A1")]
    [Address(RVA = "0x190EE28", Offset = "0x190EE28", VA = "0x190EE28")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A7A2")]
    [Address(RVA = "0x190EE34", Offset = "0x190EE34", VA = "0x190EE34")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A7A3")]
    [Address(RVA = "0x190EF08", Offset = "0x190EF08", VA = "0x190EF08")]
    private void OnSuccess(string json)
    {
    }
  }
}
