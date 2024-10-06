// Decompiled with JetBrains decompiler
// Type: Network.API.APIArenaDetail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B95")]
  public class APIArenaDetail
  {
    [Token(Token = "0x4007649")]
    public const string DefaultAPIPath = "api/v1/arena/detail";
    [Token(Token = "0x400764D")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x400764E")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIArenaDetailResponse> onSuccess;
    [Token(Token = "0x400764F")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001DD8")]
    public APIArenaDetailRequest Request
    {
      [Token(Token = "0x600A212"), Address(RVA = "0x46C9E3C", Offset = "0x46C9E3C", VA = "0x46C9E3C")] private get
      {
        return (APIArenaDetailRequest) null;
      }
      [Token(Token = "0x600A213"), Address(RVA = "0x46C9E44", Offset = "0x46C9E44", VA = "0x46C9E44")] set
      {
      }
    }

    [Token(Token = "0x17001DD9")]
    public APIArenaDetailResponse Response
    {
      [Token(Token = "0x600A214"), Address(RVA = "0x46C9E4C", Offset = "0x46C9E4C", VA = "0x46C9E4C")] get
      {
        return (APIArenaDetailResponse) null;
      }
      [Token(Token = "0x600A215"), Address(RVA = "0x46C9E54", Offset = "0x46C9E54", VA = "0x46C9E54")] private set
      {
      }
    }

    [Token(Token = "0x17001DDA")]
    public int ResponseCode
    {
      [Token(Token = "0x600A216"), Address(RVA = "0x46C9E5C", Offset = "0x46C9E5C", VA = "0x46C9E5C")] get
      {
        return new int();
      }
      [Token(Token = "0x600A217"), Address(RVA = "0x46C9E64", Offset = "0x46C9E64", VA = "0x46C9E64")] private set
      {
      }
    }

    [Token(Token = "0x17001DDB")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A218"), Address(RVA = "0x46C9E6C", Offset = "0x46C9E6C", VA = "0x46C9E6C")] set
      {
      }
      [Token(Token = "0x600A219"), Address(RVA = "0x46C9E88", Offset = "0x46C9E88", VA = "0x46C9E88")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A21A")]
    [Address(RVA = "0x46C9EA4", Offset = "0x46C9EA4", VA = "0x46C9EA4")]
    public APIArenaDetail(string apiPath = "api/v1/arena/detail")
    {
    }

    [Token(Token = "0x600A21B")]
    [Address(RVA = "0x46C9F3C", Offset = "0x46C9F3C", VA = "0x46C9F3C")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A21C")]
    [Address(RVA = "0x46C9FCC", Offset = "0x46C9FCC", VA = "0x46C9FCC")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A21D")]
    [Address(RVA = "0x46C9FD8", Offset = "0x46C9FD8", VA = "0x46C9FD8")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A21E")]
    [Address(RVA = "0x46CA0AC", Offset = "0x46CA0AC", VA = "0x46CA0AC")]
    private void OnSuccess(string json)
    {
    }
  }
}
