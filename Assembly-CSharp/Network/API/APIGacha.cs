// Decompiled with JetBrains decompiler
// Type: Network.API.APIGacha
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C95")]
  public class APIGacha
  {
    [Token(Token = "0x4007A3B")]
    public const string DefaultAPIPath = "api/v1/gacha";
    [Token(Token = "0x4007A3F")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007A40")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIGachaResponse> onSuccess;
    [Token(Token = "0x4007A41")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x1700201B")]
    public APIGachaRequest Request
    {
      [Token(Token = "0x600A855"), Address(RVA = "0x1911768", Offset = "0x1911768", VA = "0x1911768")] private get
      {
        return (APIGachaRequest) null;
      }
      [Token(Token = "0x600A856"), Address(RVA = "0x1911770", Offset = "0x1911770", VA = "0x1911770")] set
      {
      }
    }

    [Token(Token = "0x1700201C")]
    public APIGachaResponse Response
    {
      [Token(Token = "0x600A857"), Address(RVA = "0x1911778", Offset = "0x1911778", VA = "0x1911778")] get
      {
        return (APIGachaResponse) null;
      }
      [Token(Token = "0x600A858"), Address(RVA = "0x1911780", Offset = "0x1911780", VA = "0x1911780")] private set
      {
      }
    }

    [Token(Token = "0x1700201D")]
    public int ResponseCode
    {
      [Token(Token = "0x600A859"), Address(RVA = "0x1911788", Offset = "0x1911788", VA = "0x1911788")] get
      {
        return new int();
      }
      [Token(Token = "0x600A85A"), Address(RVA = "0x1911790", Offset = "0x1911790", VA = "0x1911790")] private set
      {
      }
    }

    [Token(Token = "0x1700201E")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A85B"), Address(RVA = "0x1911798", Offset = "0x1911798", VA = "0x1911798")] set
      {
      }
      [Token(Token = "0x600A85C"), Address(RVA = "0x19117B4", Offset = "0x19117B4", VA = "0x19117B4")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A85D")]
    [Address(RVA = "0x19117D0", Offset = "0x19117D0", VA = "0x19117D0")]
    public APIGacha(string apiPath = "api/v1/gacha")
    {
    }

    [Token(Token = "0x600A85E")]
    [Address(RVA = "0x1911868", Offset = "0x1911868", VA = "0x1911868")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A85F")]
    [Address(RVA = "0x19118F8", Offset = "0x19118F8", VA = "0x19118F8")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A860")]
    [Address(RVA = "0x1911904", Offset = "0x1911904", VA = "0x1911904")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A861")]
    [Address(RVA = "0x19119D8", Offset = "0x19119D8", VA = "0x19119D8")]
    private void OnSuccess(string json)
    {
    }
  }
}
