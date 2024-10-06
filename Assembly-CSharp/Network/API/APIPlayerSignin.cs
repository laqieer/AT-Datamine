// Decompiled with JetBrains decompiler
// Type: Network.API.APIPlayerSignin
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001DAD")]
  public class APIPlayerSignin
  {
    [Token(Token = "0x4007ED2")]
    public const string DefaultAPIPath = "api/v1/player/signin";
    [Token(Token = "0x4007ED6")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007ED7")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIPlayerSigninResponse> onSuccess;
    [Token(Token = "0x4007ED8")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170022C9")]
    public APIPlayerSigninRequest Request
    {
      [Token(Token = "0x600AF63"), Address(RVA = "0x1A4FCF0", Offset = "0x1A4FCF0", VA = "0x1A4FCF0")] private get
      {
        return (APIPlayerSigninRequest) null;
      }
      [Token(Token = "0x600AF64"), Address(RVA = "0x1A4FCF8", Offset = "0x1A4FCF8", VA = "0x1A4FCF8")] set
      {
      }
    }

    [Token(Token = "0x170022CA")]
    public APIPlayerSigninResponse Response
    {
      [Token(Token = "0x600AF65"), Address(RVA = "0x1A4FD00", Offset = "0x1A4FD00", VA = "0x1A4FD00")] get
      {
        return (APIPlayerSigninResponse) null;
      }
      [Token(Token = "0x600AF66"), Address(RVA = "0x1A4FD08", Offset = "0x1A4FD08", VA = "0x1A4FD08")] private set
      {
      }
    }

    [Token(Token = "0x170022CB")]
    public int ResponseCode
    {
      [Token(Token = "0x600AF67"), Address(RVA = "0x1A4FD10", Offset = "0x1A4FD10", VA = "0x1A4FD10")] get
      {
        return new int();
      }
      [Token(Token = "0x600AF68"), Address(RVA = "0x1A4FD18", Offset = "0x1A4FD18", VA = "0x1A4FD18")] private set
      {
      }
    }

    [Token(Token = "0x170022CC")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600AF69"), Address(RVA = "0x1A4FD20", Offset = "0x1A4FD20", VA = "0x1A4FD20")] set
      {
      }
      [Token(Token = "0x600AF6A"), Address(RVA = "0x1A4FD3C", Offset = "0x1A4FD3C", VA = "0x1A4FD3C")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600AF6B")]
    [Address(RVA = "0x1A4FD58", Offset = "0x1A4FD58", VA = "0x1A4FD58")]
    public APIPlayerSignin(string apiPath = "api/v1/player/signin")
    {
    }

    [Token(Token = "0x600AF6C")]
    [Address(RVA = "0x1A4FDF0", Offset = "0x1A4FDF0", VA = "0x1A4FDF0")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600AF6D")]
    [Address(RVA = "0x1A4FE80", Offset = "0x1A4FE80", VA = "0x1A4FE80")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600AF6E")]
    [Address(RVA = "0x1A4FE8C", Offset = "0x1A4FE8C", VA = "0x1A4FE8C")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600AF6F")]
    [Address(RVA = "0x1A4FF60", Offset = "0x1A4FF60", VA = "0x1A4FF60")]
    private void OnSuccess(string json)
    {
    }
  }
}
