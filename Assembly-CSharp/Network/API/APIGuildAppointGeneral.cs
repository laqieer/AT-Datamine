// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildAppointGeneral
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C9D")]
  public class APIGuildAppointGeneral
  {
    [Token(Token = "0x4007A57")]
    public const string DefaultAPIPath = "api/v1/guild/appoint/general";
    [Token(Token = "0x4007A5B")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007A5C")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIGuildAppointGeneralResponse> onSuccess;
    [Token(Token = "0x4007A5D")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x1700202B")]
    public APIGuildAppointGeneralRequest Request
    {
      [Token(Token = "0x600A885"), Address(RVA = "0x1912220", Offset = "0x1912220", VA = "0x1912220")] private get
      {
        return (APIGuildAppointGeneralRequest) null;
      }
      [Token(Token = "0x600A886"), Address(RVA = "0x1912228", Offset = "0x1912228", VA = "0x1912228")] set
      {
      }
    }

    [Token(Token = "0x1700202C")]
    public APIGuildAppointGeneralResponse Response
    {
      [Token(Token = "0x600A887"), Address(RVA = "0x1912230", Offset = "0x1912230", VA = "0x1912230")] get
      {
        return (APIGuildAppointGeneralResponse) null;
      }
      [Token(Token = "0x600A888"), Address(RVA = "0x1912238", Offset = "0x1912238", VA = "0x1912238")] private set
      {
      }
    }

    [Token(Token = "0x1700202D")]
    public int ResponseCode
    {
      [Token(Token = "0x600A889"), Address(RVA = "0x1912240", Offset = "0x1912240", VA = "0x1912240")] get
      {
        return new int();
      }
      [Token(Token = "0x600A88A"), Address(RVA = "0x1912248", Offset = "0x1912248", VA = "0x1912248")] private set
      {
      }
    }

    [Token(Token = "0x1700202E")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600A88B"), Address(RVA = "0x1912250", Offset = "0x1912250", VA = "0x1912250")] set
      {
      }
      [Token(Token = "0x600A88C"), Address(RVA = "0x191226C", Offset = "0x191226C", VA = "0x191226C")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600A88D")]
    [Address(RVA = "0x1912288", Offset = "0x1912288", VA = "0x1912288")]
    public APIGuildAppointGeneral(string apiPath = "api/v1/guild/appoint/general")
    {
    }

    [Token(Token = "0x600A88E")]
    [Address(RVA = "0x1912320", Offset = "0x1912320", VA = "0x1912320")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600A88F")]
    [Address(RVA = "0x19123B0", Offset = "0x19123B0", VA = "0x19123B0")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600A890")]
    [Address(RVA = "0x19123BC", Offset = "0x19123BC", VA = "0x19123BC")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600A891")]
    [Address(RVA = "0x1912490", Offset = "0x1912490", VA = "0x1912490")]
    private void OnSuccess(string json)
    {
    }
  }
}
