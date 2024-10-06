// Decompiled with JetBrains decompiler
// Type: Network.APIDascFgGIDAddDevice
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network
{
  [Token(Token = "0x20019C0")]
  public class APIDascFgGIDAddDevice
  {
    [Token(Token = "0x4006E8E")]
    public const string DefaultAPIPath = "dasc/fggid/v1/add_device";
    [Token(Token = "0x4006E92")]
    [FieldOffset(Offset = "0x28")]
    public Action<APIDascFgGIDAddDeviceResponse> onSuccess;
    [Token(Token = "0x4006E93")]
    [FieldOffset(Offset = "0x30")]
    public NetworkManager.OnError onError;

    [Token(Token = "0x170017C6")]
    public APIDascFgGIDAddDeviceRequest Request
    {
      [Token(Token = "0x6009328"), Address(RVA = "0x4D107EC", Offset = "0x4D107EC", VA = "0x4D107EC")] private get
      {
        return (APIDascFgGIDAddDeviceRequest) null;
      }
      [Token(Token = "0x6009329"), Address(RVA = "0x4D107F4", Offset = "0x4D107F4", VA = "0x4D107F4")] set
      {
      }
    }

    [Token(Token = "0x170017C7")]
    public APIDascFgGIDAddDeviceResponse Response
    {
      [Token(Token = "0x600932A"), Address(RVA = "0x4D107FC", Offset = "0x4D107FC", VA = "0x4D107FC")] get
      {
        return (APIDascFgGIDAddDeviceResponse) null;
      }
      [Token(Token = "0x600932B"), Address(RVA = "0x4D10804", Offset = "0x4D10804", VA = "0x4D10804")] private set
      {
      }
    }

    [Token(Token = "0x170017C8")]
    public int ResponseCode
    {
      [Token(Token = "0x600932C"), Address(RVA = "0x4D1080C", Offset = "0x4D1080C", VA = "0x4D1080C")] get
      {
        return new int();
      }
      [Token(Token = "0x600932D"), Address(RVA = "0x4D10814", Offset = "0x4D10814", VA = "0x4D10814")] private set
      {
      }
    }

    [Token(Token = "0x600932E")]
    [Address(RVA = "0x4D1081C", Offset = "0x4D1081C", VA = "0x4D1081C")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600932F")]
    [Address(RVA = "0x4D108AC", Offset = "0x4D108AC", VA = "0x4D108AC")]
    private string Serialize() => (string) null;

    [Token(Token = "0x6009330")]
    [Address(RVA = "0x4D108B8", Offset = "0x4D108B8", VA = "0x4D108B8")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x6009331")]
    [Address(RVA = "0x4D1098C", Offset = "0x4D1098C", VA = "0x4D1098C")]
    private void OnSuccess(string json)
    {
    }

    [Token(Token = "0x6009332")]
    [Address(RVA = "0x4D109C0", Offset = "0x4D109C0", VA = "0x4D109C0")]
    public APIDascFgGIDAddDevice()
    {
    }
  }
}
