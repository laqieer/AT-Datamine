// Decompiled with JetBrains decompiler
// Type: Network.API.APIShopUpdate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E19")]
  public class APIShopUpdate
  {
    [Token(Token = "0x40080D0")]
    public const string DefaultAPIPath = "api/v1/shop/update";
    [Token(Token = "0x40080D4")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40080D5")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIShopUpdateResponse> onSuccess;
    [Token(Token = "0x40080D6")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170023D2")]
    public APIShopUpdateRequest Request
    {
      [Token(Token = "0x600B21C"), Address(RVA = "0x22DED70", Offset = "0x22DED70", VA = "0x22DED70")] private get
      {
        return (APIShopUpdateRequest) null;
      }
      [Token(Token = "0x600B21D"), Address(RVA = "0x22DED78", Offset = "0x22DED78", VA = "0x22DED78")] set
      {
      }
    }

    [Token(Token = "0x170023D3")]
    public APIShopUpdateResponse Response
    {
      [Token(Token = "0x600B21E"), Address(RVA = "0x22DED80", Offset = "0x22DED80", VA = "0x22DED80")] get
      {
        return (APIShopUpdateResponse) null;
      }
      [Token(Token = "0x600B21F"), Address(RVA = "0x22DED88", Offset = "0x22DED88", VA = "0x22DED88")] private set
      {
      }
    }

    [Token(Token = "0x170023D4")]
    public int ResponseCode
    {
      [Token(Token = "0x600B220"), Address(RVA = "0x22DED90", Offset = "0x22DED90", VA = "0x22DED90")] get
      {
        return new int();
      }
      [Token(Token = "0x600B221"), Address(RVA = "0x22DED98", Offset = "0x22DED98", VA = "0x22DED98")] private set
      {
      }
    }

    [Token(Token = "0x170023D5")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B222"), Address(RVA = "0x22DEDA0", Offset = "0x22DEDA0", VA = "0x22DEDA0")] set
      {
      }
      [Token(Token = "0x600B223"), Address(RVA = "0x22DEDBC", Offset = "0x22DEDBC", VA = "0x22DEDBC")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B224")]
    [Address(RVA = "0x22DEDD8", Offset = "0x22DEDD8", VA = "0x22DEDD8")]
    public APIShopUpdate(string apiPath = "api/v1/shop/update")
    {
    }

    [Token(Token = "0x600B225")]
    [Address(RVA = "0x22DEE70", Offset = "0x22DEE70", VA = "0x22DEE70")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B226")]
    [Address(RVA = "0x22DEF00", Offset = "0x22DEF00", VA = "0x22DEF00")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B227")]
    [Address(RVA = "0x22DEF0C", Offset = "0x22DEF0C", VA = "0x22DEF0C")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B228")]
    [Address(RVA = "0x22DEFE0", Offset = "0x22DEFE0", VA = "0x22DEFE0")]
    private void OnSuccess(string json)
    {
    }
  }
}
