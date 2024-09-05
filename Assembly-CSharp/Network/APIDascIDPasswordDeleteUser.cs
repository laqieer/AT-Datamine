// Decompiled with JetBrains decompiler
// Type: Network.APIDascIDPasswordDeleteUser
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network
{
  [Token(Token = "0x20019DA")]
  public class APIDascIDPasswordDeleteUser
  {
    [Token(Token = "0x4006EDE")]
    [FieldOffset(Offset = "0x28")]
    public Action<APIDascIDPasswordDeleteUserResponse> onSuccess;
    [Token(Token = "0x4006EDF")]
    [FieldOffset(Offset = "0x30")]
    public NetworkManager.OnError onError;

    [Token(Token = "0x170017E4")]
    public APIDascIDPasswordDeleteUserRequest Request
    {
      [Token(Token = "0x60093A2"), Address(RVA = "0x4D122A0", Offset = "0x4D122A0", VA = "0x4D122A0")] private get
      {
        return (APIDascIDPasswordDeleteUserRequest) null;
      }
      [Token(Token = "0x60093A3"), Address(RVA = "0x4D122A8", Offset = "0x4D122A8", VA = "0x4D122A8")] set
      {
      }
    }

    [Token(Token = "0x170017E5")]
    public APIDascIDPasswordDeleteUserResponse Response
    {
      [Token(Token = "0x60093A4"), Address(RVA = "0x4D122B0", Offset = "0x4D122B0", VA = "0x4D122B0")] get
      {
        return (APIDascIDPasswordDeleteUserResponse) null;
      }
      [Token(Token = "0x60093A5"), Address(RVA = "0x4D122B8", Offset = "0x4D122B8", VA = "0x4D122B8")] private set
      {
      }
    }

    [Token(Token = "0x170017E6")]
    public int ResponseCode
    {
      [Token(Token = "0x60093A6"), Address(RVA = "0x4D122C0", Offset = "0x4D122C0", VA = "0x4D122C0")] get
      {
        return new int();
      }
      [Token(Token = "0x60093A7"), Address(RVA = "0x4D122C8", Offset = "0x4D122C8", VA = "0x4D122C8")] private set
      {
      }
    }

    [Token(Token = "0x60093A8")]
    [Address(RVA = "0x4D122D0", Offset = "0x4D122D0", VA = "0x4D122D0")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x60093A9")]
    [Address(RVA = "0x4D12360", Offset = "0x4D12360", VA = "0x4D12360")]
    private string Serialize() => (string) null;

    [Token(Token = "0x60093AA")]
    [Address(RVA = "0x4D1236C", Offset = "0x4D1236C", VA = "0x4D1236C")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x60093AB")]
    [Address(RVA = "0x4D12440", Offset = "0x4D12440", VA = "0x4D12440")]
    private void OnSuccess(string json)
    {
    }

    [Token(Token = "0x60093AC")]
    [Address(RVA = "0x4D12474", Offset = "0x4D12474", VA = "0x4D12474")]
    public APIDascIDPasswordDeleteUser()
    {
    }
  }
}
