// Decompiled with JetBrains decompiler
// Type: Network.APIDasConnectList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network
{
  [Token(Token = "0x20019E7")]
  public class APIDasConnectList
  {
    [Token(Token = "0x4006F02")]
    public const string DefaultAPIPath = "das/connect/list";
    [Token(Token = "0x4006F06")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4006F07")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIDasConnectListResponse> onSuccess;
    [Token(Token = "0x4006F08")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170017F3")]
    public APIDasConnectListRequest Request
    {
      [Token(Token = "0x60093DF"), Address(RVA = "0x4D12F44", Offset = "0x4D12F44", VA = "0x4D12F44")] private get
      {
        return (APIDasConnectListRequest) null;
      }
      [Token(Token = "0x60093E0"), Address(RVA = "0x4D12F4C", Offset = "0x4D12F4C", VA = "0x4D12F4C")] set
      {
      }
    }

    [Token(Token = "0x170017F4")]
    public APIDasConnectListResponse Response
    {
      [Token(Token = "0x60093E1"), Address(RVA = "0x4D12F54", Offset = "0x4D12F54", VA = "0x4D12F54")] get
      {
        return (APIDasConnectListResponse) null;
      }
      [Token(Token = "0x60093E2"), Address(RVA = "0x4D12F5C", Offset = "0x4D12F5C", VA = "0x4D12F5C")] private set
      {
      }
    }

    [Token(Token = "0x170017F5")]
    public int ResponseCode
    {
      [Token(Token = "0x60093E3"), Address(RVA = "0x4D12F64", Offset = "0x4D12F64", VA = "0x4D12F64")] get
      {
        return new int();
      }
      [Token(Token = "0x60093E4"), Address(RVA = "0x4D12F6C", Offset = "0x4D12F6C", VA = "0x4D12F6C")] private set
      {
      }
    }

    [Token(Token = "0x170017F6")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x60093E5"), Address(RVA = "0x4D12F74", Offset = "0x4D12F74", VA = "0x4D12F74")] set
      {
      }
      [Token(Token = "0x60093E6"), Address(RVA = "0x4D12F90", Offset = "0x4D12F90", VA = "0x4D12F90")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x60093E7")]
    [Address(RVA = "0x4D12FAC", Offset = "0x4D12FAC", VA = "0x4D12FAC")]
    public APIDasConnectList(string apiPath = "das/connect/list")
    {
    }

    [Token(Token = "0x60093E8")]
    [Address(RVA = "0x4D132F0", Offset = "0x4D132F0", VA = "0x4D132F0")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x60093E9")]
    [Address(RVA = "0x4D13380", Offset = "0x4D13380", VA = "0x4D13380")]
    private string Serialize() => (string) null;

    [Token(Token = "0x60093EA")]
    [Address(RVA = "0x4D1338C", Offset = "0x4D1338C", VA = "0x4D1338C")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x60093EB")]
    [Address(RVA = "0x4D13460", Offset = "0x4D13460", VA = "0x4D13460")]
    private void OnSuccess(string json)
    {
    }
  }
}
