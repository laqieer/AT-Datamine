// Decompiled with JetBrains decompiler
// Type: Network.APIDascIDPasswordAddDevice
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network
{
  [Token(Token = "0x20019D1")]
  public class APIDascIDPasswordAddDevice
  {
    [Token(Token = "0x4006EC1")]
    public const string DefaultAPIPath = "dasc/idpw/v1/add_device";
    [Token(Token = "0x4006EC5")]
    [FieldOffset(Offset = "0x28")]
    public Action<APIDascIDPasswordAddDeviceResponse> onSuccess;
    [Token(Token = "0x4006EC6")]
    [FieldOffset(Offset = "0x30")]
    public NetworkManager.OnError onError;

    [Token(Token = "0x170017DA")]
    public APIDascIDPasswordAddDeviceRequest Request
    {
      [Token(Token = "0x6009379"), Address(RVA = "0x4D11A40", Offset = "0x4D11A40", VA = "0x4D11A40")] private get
      {
        return (APIDascIDPasswordAddDeviceRequest) null;
      }
      [Token(Token = "0x600937A"), Address(RVA = "0x4D11A48", Offset = "0x4D11A48", VA = "0x4D11A48")] set
      {
      }
    }

    [Token(Token = "0x170017DB")]
    public APIDascIDPasswordAddDeviceResponse Response
    {
      [Token(Token = "0x600937B"), Address(RVA = "0x4D11A50", Offset = "0x4D11A50", VA = "0x4D11A50")] get
      {
        return (APIDascIDPasswordAddDeviceResponse) null;
      }
      [Token(Token = "0x600937C"), Address(RVA = "0x4D11A58", Offset = "0x4D11A58", VA = "0x4D11A58")] private set
      {
      }
    }

    [Token(Token = "0x170017DC")]
    public int ResponseCode
    {
      [Token(Token = "0x600937D"), Address(RVA = "0x4D11A60", Offset = "0x4D11A60", VA = "0x4D11A60")] get
      {
        return new int();
      }
      [Token(Token = "0x600937E"), Address(RVA = "0x4D11A68", Offset = "0x4D11A68", VA = "0x4D11A68")] private set
      {
      }
    }

    [Token(Token = "0x600937F")]
    [Address(RVA = "0x4D11A70", Offset = "0x4D11A70", VA = "0x4D11A70")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x6009380")]
    [Address(RVA = "0x4D11B00", Offset = "0x4D11B00", VA = "0x4D11B00")]
    private string Serialize() => (string) null;

    [Token(Token = "0x6009381")]
    [Address(RVA = "0x4D11B0C", Offset = "0x4D11B0C", VA = "0x4D11B0C")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x6009382")]
    [Address(RVA = "0x4D11BE0", Offset = "0x4D11BE0", VA = "0x4D11BE0")]
    private void OnSuccess(string json)
    {
    }

    [Token(Token = "0x6009383")]
    [Address(RVA = "0x4D11C14", Offset = "0x4D11C14", VA = "0x4D11C14")]
    public APIDascIDPasswordAddDevice()
    {
    }
  }
}
