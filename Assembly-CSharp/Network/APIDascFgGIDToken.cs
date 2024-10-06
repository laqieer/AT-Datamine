// Decompiled with JetBrains decompiler
// Type: Network.APIDascFgGIDToken
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network
{
  [Token(Token = "0x20019CD")]
  public class APIDascFgGIDToken
  {
    [Token(Token = "0x4006EB7")]
    [FieldOffset(Offset = "0x28")]
    public Action<APIDascFgGIDTokenResponse> onSuccess;
    [Token(Token = "0x4006EB8")]
    [FieldOffset(Offset = "0x30")]
    public NetworkManager.OnError onError;

    [Token(Token = "0x170017D5")]
    public APIDascFgGIDTokenRequest Request
    {
      [Token(Token = "0x6009365"), Address(RVA = "0x4D11614", Offset = "0x4D11614", VA = "0x4D11614")] private get
      {
        return (APIDascFgGIDTokenRequest) null;
      }
      [Token(Token = "0x6009366"), Address(RVA = "0x4D1161C", Offset = "0x4D1161C", VA = "0x4D1161C")] set
      {
      }
    }

    [Token(Token = "0x170017D6")]
    public APIDascFgGIDTokenResponse Response
    {
      [Token(Token = "0x6009367"), Address(RVA = "0x4D11624", Offset = "0x4D11624", VA = "0x4D11624")] get
      {
        return (APIDascFgGIDTokenResponse) null;
      }
      [Token(Token = "0x6009368"), Address(RVA = "0x4D1162C", Offset = "0x4D1162C", VA = "0x4D1162C")] private set
      {
      }
    }

    [Token(Token = "0x170017D7")]
    public int ResponseCode
    {
      [Token(Token = "0x6009369"), Address(RVA = "0x4D11634", Offset = "0x4D11634", VA = "0x4D11634")] get
      {
        return new int();
      }
      [Token(Token = "0x600936A"), Address(RVA = "0x4D1163C", Offset = "0x4D1163C", VA = "0x4D1163C")] private set
      {
      }
    }

    [Token(Token = "0x600936B")]
    [Address(RVA = "0x4D11644", Offset = "0x4D11644", VA = "0x4D11644")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600936C")]
    [Address(RVA = "0x4D116D4", Offset = "0x4D116D4", VA = "0x4D116D4")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600936D")]
    [Address(RVA = "0x4D116E0", Offset = "0x4D116E0", VA = "0x4D116E0")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600936E")]
    [Address(RVA = "0x4D117B4", Offset = "0x4D117B4", VA = "0x4D117B4")]
    private void OnSuccess(string json)
    {
    }

    [Token(Token = "0x600936F")]
    [Address(RVA = "0x4D117E8", Offset = "0x4D117E8", VA = "0x4D117E8")]
    public APIDascFgGIDToken()
    {
    }
  }
}
