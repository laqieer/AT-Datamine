// Decompiled with JetBrains decompiler
// Type: Network.APIDascFgGIDConnect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network
{
  [Token(Token = "0x20019C4")]
  public class APIDascFgGIDConnect
  {
    [Token(Token = "0x4006E9E")]
    [FieldOffset(Offset = "0x28")]
    public Action<APIDascFgGIDConnectResponse> onSuccess;
    [Token(Token = "0x4006E9F")]
    [FieldOffset(Offset = "0x30")]
    public NetworkManager.OnError onError;

    [Token(Token = "0x170017CB")]
    public APIDascFgGIDConnectRequest Request
    {
      [Token(Token = "0x600933C"), Address(RVA = "0x4D10DB4", Offset = "0x4D10DB4", VA = "0x4D10DB4")] private get
      {
        return (APIDascFgGIDConnectRequest) null;
      }
      [Token(Token = "0x600933D"), Address(RVA = "0x4D10DBC", Offset = "0x4D10DBC", VA = "0x4D10DBC")] set
      {
      }
    }

    [Token(Token = "0x170017CC")]
    public APIDascFgGIDConnectResponse Response
    {
      [Token(Token = "0x600933E"), Address(RVA = "0x4D10DC4", Offset = "0x4D10DC4", VA = "0x4D10DC4")] get
      {
        return (APIDascFgGIDConnectResponse) null;
      }
      [Token(Token = "0x600933F"), Address(RVA = "0x4D10DCC", Offset = "0x4D10DCC", VA = "0x4D10DCC")] private set
      {
      }
    }

    [Token(Token = "0x170017CD")]
    public int ResponseCode
    {
      [Token(Token = "0x6009340"), Address(RVA = "0x4D10DD4", Offset = "0x4D10DD4", VA = "0x4D10DD4")] get
      {
        return new int();
      }
      [Token(Token = "0x6009341"), Address(RVA = "0x4D10DDC", Offset = "0x4D10DDC", VA = "0x4D10DDC")] private set
      {
      }
    }

    [Token(Token = "0x6009342")]
    [Address(RVA = "0x4D10DE4", Offset = "0x4D10DE4", VA = "0x4D10DE4")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x6009343")]
    [Address(RVA = "0x4D10E74", Offset = "0x4D10E74", VA = "0x4D10E74")]
    private string Serialize() => (string) null;

    [Token(Token = "0x6009344")]
    [Address(RVA = "0x4D10E80", Offset = "0x4D10E80", VA = "0x4D10E80")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x6009345")]
    [Address(RVA = "0x4D10F54", Offset = "0x4D10F54", VA = "0x4D10F54")]
    private void OnSuccess(string json)
    {
    }

    [Token(Token = "0x6009346")]
    [Address(RVA = "0x4D10F88", Offset = "0x4D10F88", VA = "0x4D10F88")]
    public APIDascFgGIDConnect()
    {
    }
  }
}
