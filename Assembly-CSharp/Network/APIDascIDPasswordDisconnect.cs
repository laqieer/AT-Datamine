// Decompiled with JetBrains decompiler
// Type: Network.APIDascIDPasswordDisconnect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network
{
  [Token(Token = "0x20019DE")]
  public class APIDascIDPasswordDisconnect
  {
    [Token(Token = "0x4006EEA")]
    [FieldOffset(Offset = "0x28")]
    public Action<APIDascIDPasswordDisconnectResponse> onSuccess;
    [Token(Token = "0x4006EEB")]
    [FieldOffset(Offset = "0x30")]
    public NetworkManager.OnError onError;

    [Token(Token = "0x170017E9")]
    public APIDascIDPasswordDisconnectRequest Request
    {
      [Token(Token = "0x60093B6"), Address(RVA = "0x4D126CC", Offset = "0x4D126CC", VA = "0x4D126CC")] private get
      {
        return (APIDascIDPasswordDisconnectRequest) null;
      }
      [Token(Token = "0x60093B7"), Address(RVA = "0x4D126D4", Offset = "0x4D126D4", VA = "0x4D126D4")] set
      {
      }
    }

    [Token(Token = "0x170017EA")]
    public APIDascIDPasswordDisconnectResponse Response
    {
      [Token(Token = "0x60093B8"), Address(RVA = "0x4D126DC", Offset = "0x4D126DC", VA = "0x4D126DC")] get
      {
        return (APIDascIDPasswordDisconnectResponse) null;
      }
      [Token(Token = "0x60093B9"), Address(RVA = "0x4D126E4", Offset = "0x4D126E4", VA = "0x4D126E4")] private set
      {
      }
    }

    [Token(Token = "0x170017EB")]
    public int ResponseCode
    {
      [Token(Token = "0x60093BA"), Address(RVA = "0x4D126EC", Offset = "0x4D126EC", VA = "0x4D126EC")] get
      {
        return new int();
      }
      [Token(Token = "0x60093BB"), Address(RVA = "0x4D126F4", Offset = "0x4D126F4", VA = "0x4D126F4")] private set
      {
      }
    }

    [Token(Token = "0x60093BC")]
    [Address(RVA = "0x4D126FC", Offset = "0x4D126FC", VA = "0x4D126FC")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x60093BD")]
    [Address(RVA = "0x4D1278C", Offset = "0x4D1278C", VA = "0x4D1278C")]
    private string Serialize() => (string) null;

    [Token(Token = "0x60093BE")]
    [Address(RVA = "0x4D12798", Offset = "0x4D12798", VA = "0x4D12798")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x60093BF")]
    [Address(RVA = "0x4D1286C", Offset = "0x4D1286C", VA = "0x4D1286C")]
    private void OnSuccess(string json)
    {
    }

    [Token(Token = "0x60093C0")]
    [Address(RVA = "0x4D128A0", Offset = "0x4D128A0", VA = "0x4D128A0")]
    public APIDascIDPasswordDisconnect()
    {
    }
  }
}
