// Decompiled with JetBrains decompiler
// Type: Network.API.APIWeaponOption_change_request
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001F05")]
  public class APIWeaponOption_change_request
  {
    [Token(Token = "0x4008526")]
    public const string DefaultAPIPath = "api/v1/weapon/option_change_request";
    [Token(Token = "0x400852A")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x400852B")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIWeaponOption_change_requestResponse> onSuccess;
    [Token(Token = "0x400852C")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x1700264C")]
    public APIWeaponOption_change_requestRequest Request
    {
      [Token(Token = "0x600B846"), Address(RVA = "0x21339F8", Offset = "0x21339F8", VA = "0x21339F8")] private get
      {
        return (APIWeaponOption_change_requestRequest) null;
      }
      [Token(Token = "0x600B847"), Address(RVA = "0x2133A00", Offset = "0x2133A00", VA = "0x2133A00")] set
      {
      }
    }

    [Token(Token = "0x1700264D")]
    public APIWeaponOption_change_requestResponse Response
    {
      [Token(Token = "0x600B848"), Address(RVA = "0x2133A08", Offset = "0x2133A08", VA = "0x2133A08")] get
      {
        return (APIWeaponOption_change_requestResponse) null;
      }
      [Token(Token = "0x600B849"), Address(RVA = "0x2133A10", Offset = "0x2133A10", VA = "0x2133A10")] private set
      {
      }
    }

    [Token(Token = "0x1700264E")]
    public int ResponseCode
    {
      [Token(Token = "0x600B84A"), Address(RVA = "0x2133A18", Offset = "0x2133A18", VA = "0x2133A18")] get
      {
        return new int();
      }
      [Token(Token = "0x600B84B"), Address(RVA = "0x2133A20", Offset = "0x2133A20", VA = "0x2133A20")] private set
      {
      }
    }

    [Token(Token = "0x1700264F")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B84C"), Address(RVA = "0x2133A28", Offset = "0x2133A28", VA = "0x2133A28")] set
      {
      }
      [Token(Token = "0x600B84D"), Address(RVA = "0x2133A44", Offset = "0x2133A44", VA = "0x2133A44")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B84E")]
    [Address(RVA = "0x2133A60", Offset = "0x2133A60", VA = "0x2133A60")]
    public APIWeaponOption_change_request(string apiPath = "api/v1/weapon/option_change_request")
    {
    }

    [Token(Token = "0x600B84F")]
    [Address(RVA = "0x2133AF8", Offset = "0x2133AF8", VA = "0x2133AF8")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B850")]
    [Address(RVA = "0x2133B88", Offset = "0x2133B88", VA = "0x2133B88")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B851")]
    [Address(RVA = "0x2133B94", Offset = "0x2133B94", VA = "0x2133B94")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B852")]
    [Address(RVA = "0x2133C68", Offset = "0x2133C68", VA = "0x2133C68")]
    private void OnSuccess(string json)
    {
    }
  }
}
