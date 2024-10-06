// Decompiled with JetBrains decompiler
// Type: Network.APIDascIDPasswordConnect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network
{
  [Token(Token = "0x20019D5")]
  public class APIDascIDPasswordConnect
  {
    [Token(Token = "0x4006ED1")]
    [FieldOffset(Offset = "0x28")]
    public Action<APIDascIDPasswordConnectResponse> onSuccess;
    [Token(Token = "0x4006ED2")]
    [FieldOffset(Offset = "0x30")]
    public NetworkManager.OnError onError;

    [Token(Token = "0x170017DF")]
    public APIDascIDPasswordConnectRequest Request
    {
      [Token(Token = "0x600938D"), Address(RVA = "0x4D11E6C", Offset = "0x4D11E6C", VA = "0x4D11E6C")] private get
      {
        return (APIDascIDPasswordConnectRequest) null;
      }
      [Token(Token = "0x600938E"), Address(RVA = "0x4D11E74", Offset = "0x4D11E74", VA = "0x4D11E74")] set
      {
      }
    }

    [Token(Token = "0x170017E0")]
    public APIDascIDPasswordConnectResponse Response
    {
      [Token(Token = "0x600938F"), Address(RVA = "0x4D11E7C", Offset = "0x4D11E7C", VA = "0x4D11E7C")] get
      {
        return (APIDascIDPasswordConnectResponse) null;
      }
      [Token(Token = "0x6009390"), Address(RVA = "0x4D11E84", Offset = "0x4D11E84", VA = "0x4D11E84")] private set
      {
      }
    }

    [Token(Token = "0x170017E1")]
    public int ResponseCode
    {
      [Token(Token = "0x6009391"), Address(RVA = "0x4D11E8C", Offset = "0x4D11E8C", VA = "0x4D11E8C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009392"), Address(RVA = "0x4D11E94", Offset = "0x4D11E94", VA = "0x4D11E94")] private set
      {
      }
    }

    [Token(Token = "0x6009393")]
    [Address(RVA = "0x4D11E9C", Offset = "0x4D11E9C", VA = "0x4D11E9C")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x6009394")]
    [Address(RVA = "0x4D11F2C", Offset = "0x4D11F2C", VA = "0x4D11F2C")]
    private string Serialize() => (string) null;

    [Token(Token = "0x6009395")]
    [Address(RVA = "0x4D11F38", Offset = "0x4D11F38", VA = "0x4D11F38")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x6009396")]
    [Address(RVA = "0x4D1200C", Offset = "0x4D1200C", VA = "0x4D1200C")]
    private void OnSuccess(string json)
    {
    }

    [Token(Token = "0x6009397")]
    [Address(RVA = "0x4D12040", Offset = "0x4D12040", VA = "0x4D12040")]
    public APIDascIDPasswordConnect()
    {
    }
  }
}
