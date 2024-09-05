// Decompiled with JetBrains decompiler
// Type: Network.Auth.APIAuthAccessToken
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.Auth
{
  [Token(Token = "0x2001B1E")]
  public class APIAuthAccessToken
  {
    [Token(Token = "0x400748C")]
    public const string DefaultAPIPath = "das/access_token";
    [Token(Token = "0x4007490")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4007491")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIAuthAccessTokenResponse> onSuccess;

    [Token(Token = "0x17001CE9")]
    public APIAuthAccessTokenRequest Request
    {
      [Token(Token = "0x6009F5D"), Address(RVA = "0x46BF920", Offset = "0x46BF920", VA = "0x46BF920")] private get
      {
        return (APIAuthAccessTokenRequest) null;
      }
      [Token(Token = "0x6009F5E"), Address(RVA = "0x46BF928", Offset = "0x46BF928", VA = "0x46BF928")] set
      {
      }
    }

    [Token(Token = "0x17001CEA")]
    public APIAuthAccessTokenResponse Response
    {
      [Token(Token = "0x6009F5F"), Address(RVA = "0x46BF930", Offset = "0x46BF930", VA = "0x46BF930")] get
      {
        return (APIAuthAccessTokenResponse) null;
      }
      [Token(Token = "0x6009F60"), Address(RVA = "0x46BF938", Offset = "0x46BF938", VA = "0x46BF938")] private set
      {
      }
    }

    [Token(Token = "0x17001CEB")]
    public int ResponseCode
    {
      [Token(Token = "0x6009F61"), Address(RVA = "0x46BF940", Offset = "0x46BF940", VA = "0x46BF940")] get
      {
        return new int();
      }
      [Token(Token = "0x6009F62"), Address(RVA = "0x46BF948", Offset = "0x46BF948", VA = "0x46BF948")] private set
      {
      }
    }

    [Token(Token = "0x17001CEC")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x6009F63"), Address(RVA = "0x46BF950", Offset = "0x46BF950", VA = "0x46BF950")] set
      {
      }
      [Token(Token = "0x6009F64"), Address(RVA = "0x46BF96C", Offset = "0x46BF96C", VA = "0x46BF96C")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x6009F65")]
    [Address(RVA = "0x46BF988", Offset = "0x46BF988", VA = "0x46BF988")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x6009F66")]
    [Address(RVA = "0x46BFA18", Offset = "0x46BFA18", VA = "0x46BFA18")]
    private string Serialize() => (string) null;

    [Token(Token = "0x6009F67")]
    [Address(RVA = "0x46BFA24", Offset = "0x46BFA24", VA = "0x46BFA24")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x6009F68")]
    [Address(RVA = "0x46BFAF8", Offset = "0x46BFAF8", VA = "0x46BFAF8")]
    private void OnSuccess(string json)
    {
    }

    [Token(Token = "0x6009F69")]
    [Address(RVA = "0x46BFB2C", Offset = "0x46BFB2C", VA = "0x46BFB2C")]
    public APIAuthAccessToken()
    {
    }
  }
}
