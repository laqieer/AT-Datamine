// Decompiled with JetBrains decompiler
// Type: Network.API.APIPlayerHomeSetting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D99")]
  public class APIPlayerHomeSetting
  {
    [Token(Token = "0x4007E54")]
    public const string DefaultAPIPath = "api/v1/player/home/setting";
    [Token(Token = "0x4007E58")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007E59")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIPlayerHomeSettingResponse> onSuccess;
    [Token(Token = "0x4007E5A")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002266")]
    public APIPlayerHomeSettingRequest Request
    {
      [Token(Token = "0x600AEB0"), Address(RVA = "0x1A4E04C", Offset = "0x1A4E04C", VA = "0x1A4E04C")] private get
      {
        return (APIPlayerHomeSettingRequest) null;
      }
      [Token(Token = "0x600AEB1"), Address(RVA = "0x1A4E054", Offset = "0x1A4E054", VA = "0x1A4E054")] set
      {
      }
    }

    [Token(Token = "0x17002267")]
    public APIPlayerHomeSettingResponse Response
    {
      [Token(Token = "0x600AEB2"), Address(RVA = "0x1A4E05C", Offset = "0x1A4E05C", VA = "0x1A4E05C")] get
      {
        return (APIPlayerHomeSettingResponse) null;
      }
      [Token(Token = "0x600AEB3"), Address(RVA = "0x1A4E064", Offset = "0x1A4E064", VA = "0x1A4E064")] private set
      {
      }
    }

    [Token(Token = "0x17002268")]
    public int ResponseCode
    {
      [Token(Token = "0x600AEB4"), Address(RVA = "0x1A4E06C", Offset = "0x1A4E06C", VA = "0x1A4E06C")] get
      {
        return new int();
      }
      [Token(Token = "0x600AEB5"), Address(RVA = "0x1A4E074", Offset = "0x1A4E074", VA = "0x1A4E074")] private set
      {
      }
    }

    [Token(Token = "0x17002269")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600AEB6"), Address(RVA = "0x1A4E07C", Offset = "0x1A4E07C", VA = "0x1A4E07C")] set
      {
      }
      [Token(Token = "0x600AEB7"), Address(RVA = "0x1A4E098", Offset = "0x1A4E098", VA = "0x1A4E098")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600AEB8")]
    [Address(RVA = "0x1A4E0B4", Offset = "0x1A4E0B4", VA = "0x1A4E0B4")]
    public APIPlayerHomeSetting(string apiPath = "api/v1/player/home/setting")
    {
    }

    [Token(Token = "0x600AEB9")]
    [Address(RVA = "0x1A4E14C", Offset = "0x1A4E14C", VA = "0x1A4E14C")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600AEBA")]
    [Address(RVA = "0x1A4E1DC", Offset = "0x1A4E1DC", VA = "0x1A4E1DC")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600AEBB")]
    [Address(RVA = "0x1A4E1E8", Offset = "0x1A4E1E8", VA = "0x1A4E1E8")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600AEBC")]
    [Address(RVA = "0x1A4E2BC", Offset = "0x1A4E2BC", VA = "0x1A4E2BC")]
    private void OnSuccess(string json)
    {
    }
  }
}
