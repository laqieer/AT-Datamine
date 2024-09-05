// Decompiled with JetBrains decompiler
// Type: Network.API.APIG0000Detail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C71")]
  public class APIG0000Detail
  {
    [Token(Token = "0x40079BA")]
    public const string DefaultAPIPath = "api/gacha/G0000/detail";
    [Token(Token = "0x40079BE")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40079BF")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIG0000DetailResponse> onSuccess;
    [Token(Token = "0x40079C0")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001FD1")]
    public APIG0000DetailRequest Request
    {
      [Token(Token = "0x600A77B"), Address(RVA = "0x190E71C", Offset = "0x190E71C", VA = "0x190E71C")] private get
      {
        return (APIG0000DetailRequest) null;
      }
      [Token(Token = "0x600A77C"), Address(RVA = "0x190E724", Offset = "0x190E724", VA = "0x190E724")] set
      {
      }
    }

    [Token(Token = "0x17001FD2")]
    public APIG0000DetailResponse Response
    {
      [Token(Token = "0x600A77D"), Address(RVA = "0x190E72C", Offset = "0x190E72C", VA = "0x190E72C")] get
      {
        return (APIG0000DetailResponse) null;
      }
      [Token(Token = "0x600A77E"), Address(RVA = "0x190E734", Offset = "0x190E734", VA = "0x190E734")] private set
      {
      }
    }

    [Token(Token = "0x17001FD3")]
    public int ResponseCode
    {
      [Token(Token = "0x600A77F"), Address(RVA = "0x190E73C", Offset = "0x190E73C", VA = "0x190E73C")] get
      {
        return new int();
      }
      [Token(Token = "0x600A780"), Address(RVA = "0x190E744", Offset = "0x190E744", VA = "0x190E744")] private set
      {
      }
    }

    [Token(Token = "0x17001FD4")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A781"), Address(RVA = "0x190E74C", Offset = "0x190E74C", VA = "0x190E74C")] set
      {
      }
      [Token(Token = "0x600A782"), Address(RVA = "0x190E768", Offset = "0x190E768", VA = "0x190E768")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A783")]
    [Address(RVA = "0x190E784", Offset = "0x190E784", VA = "0x190E784")]
    public APIG0000Detail(string apiPath = "api/gacha/G0000/detail")
    {
    }

    [Token(Token = "0x600A784")]
    [Address(RVA = "0x190E81C", Offset = "0x190E81C", VA = "0x190E81C")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A785")]
    [Address(RVA = "0x190E8AC", Offset = "0x190E8AC", VA = "0x190E8AC")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A786")]
    [Address(RVA = "0x190E8B8", Offset = "0x190E8B8", VA = "0x190E8B8")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A787")]
    [Address(RVA = "0x190E98C", Offset = "0x190E98C", VA = "0x190E98C")]
    private void OnSuccess(string json)
    {
    }
  }
}
