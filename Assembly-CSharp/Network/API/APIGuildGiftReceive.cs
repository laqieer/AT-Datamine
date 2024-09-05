// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildGiftReceive
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001CCD")]
  public class APIGuildGiftReceive
  {
    [Token(Token = "0x4007B1D")]
    public const string DefaultAPIPath = "api/v1/guild/gift/receive";
    [Token(Token = "0x4007B21")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007B22")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIGuildGiftReceiveResponse> onSuccess;
    [Token(Token = "0x4007B23")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002099")]
    public APIGuildGiftReceiveRequest Request
    {
      [Token(Token = "0x600A9B3"), Address(RVA = "0x19162D0", Offset = "0x19162D0", VA = "0x19162D0")] private get
      {
        return (APIGuildGiftReceiveRequest) null;
      }
      [Token(Token = "0x600A9B4"), Address(RVA = "0x19162D8", Offset = "0x19162D8", VA = "0x19162D8")] set
      {
      }
    }

    [Token(Token = "0x1700209A")]
    public APIGuildGiftReceiveResponse Response
    {
      [Token(Token = "0x600A9B5"), Address(RVA = "0x19162E0", Offset = "0x19162E0", VA = "0x19162E0")] get
      {
        return (APIGuildGiftReceiveResponse) null;
      }
      [Token(Token = "0x600A9B6"), Address(RVA = "0x19162E8", Offset = "0x19162E8", VA = "0x19162E8")] private set
      {
      }
    }

    [Token(Token = "0x1700209B")]
    public int ResponseCode
    {
      [Token(Token = "0x600A9B7"), Address(RVA = "0x19162F0", Offset = "0x19162F0", VA = "0x19162F0")] get
      {
        return new int();
      }
      [Token(Token = "0x600A9B8"), Address(RVA = "0x19162F8", Offset = "0x19162F8", VA = "0x19162F8")] private set
      {
      }
    }

    [Token(Token = "0x1700209C")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A9B9"), Address(RVA = "0x1916300", Offset = "0x1916300", VA = "0x1916300")] set
      {
      }
      [Token(Token = "0x600A9BA"), Address(RVA = "0x191631C", Offset = "0x191631C", VA = "0x191631C")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A9BB")]
    [Address(RVA = "0x1916338", Offset = "0x1916338", VA = "0x1916338")]
    public APIGuildGiftReceive(string apiPath = "api/v1/guild/gift/receive")
    {
    }

    [Token(Token = "0x600A9BC")]
    [Address(RVA = "0x19163D0", Offset = "0x19163D0", VA = "0x19163D0")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A9BD")]
    [Address(RVA = "0x1916460", Offset = "0x1916460", VA = "0x1916460")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A9BE")]
    [Address(RVA = "0x191646C", Offset = "0x191646C", VA = "0x191646C")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A9BF")]
    [Address(RVA = "0x1916540", Offset = "0x1916540", VA = "0x1916540")]
    private void OnSuccess(string json)
    {
    }
  }
}
