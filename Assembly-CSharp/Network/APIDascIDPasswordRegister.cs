// Decompiled with JetBrains decompiler
// Type: Network.APIDascIDPasswordRegister
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network
{
  [Token(Token = "0x20019E2")]
  public class APIDascIDPasswordRegister
  {
    [Token(Token = "0x4006EF5")]
    [FieldOffset(Offset = "0x28")]
    public Action<APIDascIDPasswordRegisterResponse> onSuccess;
    [Token(Token = "0x4006EF6")]
    [FieldOffset(Offset = "0x30")]
    public NetworkManager.OnError onError;

    [Token(Token = "0x170017EE")]
    public APIDascIDPasswordRegisterRequest Request
    {
      [Token(Token = "0x60093CA"), Address(RVA = "0x4D12B04", Offset = "0x4D12B04", VA = "0x4D12B04")] private get
      {
        return (APIDascIDPasswordRegisterRequest) null;
      }
      [Token(Token = "0x60093CB"), Address(RVA = "0x4D12B0C", Offset = "0x4D12B0C", VA = "0x4D12B0C")] set
      {
      }
    }

    [Token(Token = "0x170017EF")]
    public APIDascIDPasswordRegisterResponse Response
    {
      [Token(Token = "0x60093CC"), Address(RVA = "0x4D12B14", Offset = "0x4D12B14", VA = "0x4D12B14")] get
      {
        return (APIDascIDPasswordRegisterResponse) null;
      }
      [Token(Token = "0x60093CD"), Address(RVA = "0x4D12B1C", Offset = "0x4D12B1C", VA = "0x4D12B1C")] private set
      {
      }
    }

    [Token(Token = "0x170017F0")]
    public int ResponseCode
    {
      [Token(Token = "0x60093CE"), Address(RVA = "0x4D12B24", Offset = "0x4D12B24", VA = "0x4D12B24")] get
      {
        return new int();
      }
      [Token(Token = "0x60093CF"), Address(RVA = "0x4D12B2C", Offset = "0x4D12B2C", VA = "0x4D12B2C")] private set
      {
      }
    }

    [Token(Token = "0x60093D0")]
    [Address(RVA = "0x4D12B34", Offset = "0x4D12B34", VA = "0x4D12B34")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x60093D1")]
    [Address(RVA = "0x4D12BC4", Offset = "0x4D12BC4", VA = "0x4D12BC4")]
    private string Serialize() => (string) null;

    [Token(Token = "0x60093D2")]
    [Address(RVA = "0x4D12BD0", Offset = "0x4D12BD0", VA = "0x4D12BD0")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x60093D3")]
    [Address(RVA = "0x4D12CA4", Offset = "0x4D12CA4", VA = "0x4D12CA4")]
    private void OnSuccess(string json)
    {
    }

    [Token(Token = "0x60093D4")]
    [Address(RVA = "0x4D12CD8", Offset = "0x4D12CD8", VA = "0x4D12CD8")]
    public APIDascIDPasswordRegister()
    {
    }
  }
}
