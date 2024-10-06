// Decompiled with JetBrains decompiler
// Type: Network.API.APIAccessoryOption_change_confirm
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B45")]
  public class APIAccessoryOption_change_confirm
  {
    [Token(Token = "0x40074F2")]
    public const string DefaultAPIPath = "api/v1/accessory/option_change_confirm";
    [Token(Token = "0x40074F6")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40074F7")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIAccessoryOption_change_confirmResponse> onSuccess;
    [Token(Token = "0x40074F8")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17001D1C")]
    public APIAccessoryOption_change_confirmRequest Request
    {
      [Token(Token = "0x600A016"), Address(RVA = "0x46C322C", Offset = "0x46C322C", VA = "0x46C322C")] private get
      {
        return (APIAccessoryOption_change_confirmRequest) null;
      }
      [Token(Token = "0x600A017"), Address(RVA = "0x46C3234", Offset = "0x46C3234", VA = "0x46C3234")] set
      {
      }
    }

    [Token(Token = "0x17001D1D")]
    public APIAccessoryOption_change_confirmResponse Response
    {
      [Token(Token = "0x600A018"), Address(RVA = "0x46C323C", Offset = "0x46C323C", VA = "0x46C323C")] get
      {
        return (APIAccessoryOption_change_confirmResponse) null;
      }
      [Token(Token = "0x600A019"), Address(RVA = "0x46C3244", Offset = "0x46C3244", VA = "0x46C3244")] private set
      {
      }
    }

    [Token(Token = "0x17001D1E")]
    public int ResponseCode
    {
      [Token(Token = "0x600A01A"), Address(RVA = "0x46C324C", Offset = "0x46C324C", VA = "0x46C324C")] get
      {
        return new int();
      }
      [Token(Token = "0x600A01B"), Address(RVA = "0x46C3254", Offset = "0x46C3254", VA = "0x46C3254")] private set
      {
      }
    }

    [Token(Token = "0x17001D1F")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A01C"), Address(RVA = "0x46C325C", Offset = "0x46C325C", VA = "0x46C325C")] set
      {
      }
      [Token(Token = "0x600A01D"), Address(RVA = "0x46C3278", Offset = "0x46C3278", VA = "0x46C3278")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A01E")]
    [Address(RVA = "0x46C3294", Offset = "0x46C3294", VA = "0x46C3294")]
    public APIAccessoryOption_change_confirm(string apiPath = "api/v1/accessory/option_change_confirm")
    {
    }

    [Token(Token = "0x600A01F")]
    [Address(RVA = "0x46C332C", Offset = "0x46C332C", VA = "0x46C332C")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A020")]
    [Address(RVA = "0x46C33BC", Offset = "0x46C33BC", VA = "0x46C33BC")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A021")]
    [Address(RVA = "0x46C33C8", Offset = "0x46C33C8", VA = "0x46C33C8")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A022")]
    [Address(RVA = "0x46C349C", Offset = "0x46C349C", VA = "0x46C349C")]
    private void OnSuccess(string json)
    {
    }
  }
}
