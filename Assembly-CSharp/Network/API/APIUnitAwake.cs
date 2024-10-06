// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitAwake
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001EA9")]
  public class APIUnitAwake
  {
    [Token(Token = "0x40083BF")]
    public const string DefaultAPIPath = "api/v1/unit/awake";
    [Token(Token = "0x40083C3")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40083C4")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIUnitAwakeResponse> onSuccess;
    [Token(Token = "0x40083C5")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002583")]
    public APIUnitAwakeRequest Request
    {
      [Token(Token = "0x600B60D"), Address(RVA = "0x22EB2E8", Offset = "0x22EB2E8", VA = "0x22EB2E8")] private get
      {
        return (APIUnitAwakeRequest) null;
      }
      [Token(Token = "0x600B60E"), Address(RVA = "0x22EB2F0", Offset = "0x22EB2F0", VA = "0x22EB2F0")] set
      {
      }
    }

    [Token(Token = "0x17002584")]
    public APIUnitAwakeResponse Response
    {
      [Token(Token = "0x600B60F"), Address(RVA = "0x22EB2F8", Offset = "0x22EB2F8", VA = "0x22EB2F8")] get
      {
        return (APIUnitAwakeResponse) null;
      }
      [Token(Token = "0x600B610"), Address(RVA = "0x22EB300", Offset = "0x22EB300", VA = "0x22EB300")] private set
      {
      }
    }

    [Token(Token = "0x17002585")]
    public int ResponseCode
    {
      [Token(Token = "0x600B611"), Address(RVA = "0x22EB308", Offset = "0x22EB308", VA = "0x22EB308")] get
      {
        return new int();
      }
      [Token(Token = "0x600B612"), Address(RVA = "0x22EB310", Offset = "0x22EB310", VA = "0x22EB310")] private set
      {
      }
    }

    [Token(Token = "0x17002586")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B613"), Address(RVA = "0x22EB318", Offset = "0x22EB318", VA = "0x22EB318")] set
      {
      }
      [Token(Token = "0x600B614"), Address(RVA = "0x22EB334", Offset = "0x22EB334", VA = "0x22EB334")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B615")]
    [Address(RVA = "0x22EB350", Offset = "0x22EB350", VA = "0x22EB350")]
    public APIUnitAwake(string apiPath = "api/v1/unit/awake")
    {
    }

    [Token(Token = "0x600B616")]
    [Address(RVA = "0x22EB3E8", Offset = "0x22EB3E8", VA = "0x22EB3E8")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B617")]
    [Address(RVA = "0x22EB478", Offset = "0x22EB478", VA = "0x22EB478")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B618")]
    [Address(RVA = "0x22EB484", Offset = "0x22EB484", VA = "0x22EB484")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B619")]
    [Address(RVA = "0x22EB558", Offset = "0x22EB558", VA = "0x22EB558")]
    private void OnSuccess(string json)
    {
    }
  }
}
