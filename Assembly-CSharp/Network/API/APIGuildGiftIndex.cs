// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildGiftIndex
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001CC9")]
  public class APIGuildGiftIndex
  {
    [Token(Token = "0x4007B0E")]
    public const string DefaultAPIPath = "api/v1/guild/gift/index";
    [Token(Token = "0x4007B12")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007B13")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIGuildGiftIndexResponse> onSuccess;
    [Token(Token = "0x4007B14")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002091")]
    public APIGuildGiftIndexRequest Request
    {
      [Token(Token = "0x600A99B"), Address(RVA = "0x1915D74", Offset = "0x1915D74", VA = "0x1915D74")] private get
      {
        return (APIGuildGiftIndexRequest) null;
      }
      [Token(Token = "0x600A99C"), Address(RVA = "0x1915D7C", Offset = "0x1915D7C", VA = "0x1915D7C")] set
      {
      }
    }

    [Token(Token = "0x17002092")]
    public APIGuildGiftIndexResponse Response
    {
      [Token(Token = "0x600A99D"), Address(RVA = "0x1915D84", Offset = "0x1915D84", VA = "0x1915D84")] get
      {
        return (APIGuildGiftIndexResponse) null;
      }
      [Token(Token = "0x600A99E"), Address(RVA = "0x1915D8C", Offset = "0x1915D8C", VA = "0x1915D8C")] private set
      {
      }
    }

    [Token(Token = "0x17002093")]
    public int ResponseCode
    {
      [Token(Token = "0x600A99F"), Address(RVA = "0x1915D94", Offset = "0x1915D94", VA = "0x1915D94")] get
      {
        return new int();
      }
      [Token(Token = "0x600A9A0"), Address(RVA = "0x1915D9C", Offset = "0x1915D9C", VA = "0x1915D9C")] private set
      {
      }
    }

    [Token(Token = "0x17002094")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A9A1"), Address(RVA = "0x1915DA4", Offset = "0x1915DA4", VA = "0x1915DA4")] set
      {
      }
      [Token(Token = "0x600A9A2"), Address(RVA = "0x1915DC0", Offset = "0x1915DC0", VA = "0x1915DC0")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A9A3")]
    [Address(RVA = "0x1915DDC", Offset = "0x1915DDC", VA = "0x1915DDC")]
    public APIGuildGiftIndex(string apiPath = "api/v1/guild/gift/index")
    {
    }

    [Token(Token = "0x600A9A4")]
    [Address(RVA = "0x1915E74", Offset = "0x1915E74", VA = "0x1915E74")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A9A5")]
    [Address(RVA = "0x1915F04", Offset = "0x1915F04", VA = "0x1915F04")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A9A6")]
    [Address(RVA = "0x1915F10", Offset = "0x1915F10", VA = "0x1915F10")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A9A7")]
    [Address(RVA = "0x1915FE4", Offset = "0x1915FE4", VA = "0x1915FE4")]
    private void OnSuccess(string json)
    {
    }
  }
}
