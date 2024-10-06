// Decompiled with JetBrains decompiler
// Type: Network.APIDascFgGIDDisconnect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network
{
  [Token(Token = "0x20019C9")]
  public class APIDascFgGIDDisconnect
  {
    [Token(Token = "0x4006EAB")]
    [FieldOffset(Offset = "0x28")]
    public Action<APIDascFgGIDDisconnectResponse> onSuccess;
    [Token(Token = "0x4006EAC")]
    [FieldOffset(Offset = "0x30")]
    public NetworkManager.OnError onError;

    [Token(Token = "0x170017D0")]
    public APIDascFgGIDDisconnectRequest Request
    {
      [Token(Token = "0x6009351"), Address(RVA = "0x4D111E8", Offset = "0x4D111E8", VA = "0x4D111E8")] private get
      {
        return (APIDascFgGIDDisconnectRequest) null;
      }
      [Token(Token = "0x6009352"), Address(RVA = "0x4D111F0", Offset = "0x4D111F0", VA = "0x4D111F0")] set
      {
      }
    }

    [Token(Token = "0x170017D1")]
    public APIDascFgGIDDisconnectResponse Response
    {
      [Token(Token = "0x6009353"), Address(RVA = "0x4D111F8", Offset = "0x4D111F8", VA = "0x4D111F8")] get
      {
        return (APIDascFgGIDDisconnectResponse) null;
      }
      [Token(Token = "0x6009354"), Address(RVA = "0x4D11200", Offset = "0x4D11200", VA = "0x4D11200")] private set
      {
      }
    }

    [Token(Token = "0x170017D2")]
    public int ResponseCode
    {
      [Token(Token = "0x6009355"), Address(RVA = "0x4D11208", Offset = "0x4D11208", VA = "0x4D11208")] get
      {
        return new int();
      }
      [Token(Token = "0x6009356"), Address(RVA = "0x4D11210", Offset = "0x4D11210", VA = "0x4D11210")] private set
      {
      }
    }

    [Token(Token = "0x6009357")]
    [Address(RVA = "0x4D11218", Offset = "0x4D11218", VA = "0x4D11218")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x6009358")]
    [Address(RVA = "0x4D112A8", Offset = "0x4D112A8", VA = "0x4D112A8")]
    private string Serialize() => (string) null;

    [Token(Token = "0x6009359")]
    [Address(RVA = "0x4D112B4", Offset = "0x4D112B4", VA = "0x4D112B4")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600935A")]
    [Address(RVA = "0x4D11388", Offset = "0x4D11388", VA = "0x4D11388")]
    private void OnSuccess(string json)
    {
    }

    [Token(Token = "0x600935B")]
    [Address(RVA = "0x4D113BC", Offset = "0x4D113BC", VA = "0x4D113BC")]
    public APIDascFgGIDDisconnect()
    {
    }
  }
}
