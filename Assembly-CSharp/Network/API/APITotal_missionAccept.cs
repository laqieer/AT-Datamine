// Decompiled with JetBrains decompiler
// Type: Network.API.APITotal_missionAccept
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E85")]
  public class APITotal_missionAccept
  {
    [Token(Token = "0x4008328")]
    public const string DefaultAPIPath = "api/v1/total_mission/accept";
    [Token(Token = "0x400832C")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x400832D")]
    [FieldOffset(Offset = "0x30")]
    public Action<APITotal_missionAcceptResponse> onSuccess;
    [Token(Token = "0x400832E")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002529")]
    public APITotal_missionAcceptRequest Request
    {
      [Token(Token = "0x600B523"), Address(RVA = "0x22E821C", Offset = "0x22E821C", VA = "0x22E821C")] private get
      {
        return (APITotal_missionAcceptRequest) null;
      }
      [Token(Token = "0x600B524"), Address(RVA = "0x22E8224", Offset = "0x22E8224", VA = "0x22E8224")] set
      {
      }
    }

    [Token(Token = "0x1700252A")]
    public APITotal_missionAcceptResponse Response
    {
      [Token(Token = "0x600B525"), Address(RVA = "0x22E822C", Offset = "0x22E822C", VA = "0x22E822C")] get
      {
        return (APITotal_missionAcceptResponse) null;
      }
      [Token(Token = "0x600B526"), Address(RVA = "0x22E8234", Offset = "0x22E8234", VA = "0x22E8234")] private set
      {
      }
    }

    [Token(Token = "0x1700252B")]
    public int ResponseCode
    {
      [Token(Token = "0x600B527"), Address(RVA = "0x22E823C", Offset = "0x22E823C", VA = "0x22E823C")] get
      {
        return new int();
      }
      [Token(Token = "0x600B528"), Address(RVA = "0x22E8244", Offset = "0x22E8244", VA = "0x22E8244")] private set
      {
      }
    }

    [Token(Token = "0x1700252C")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B529"), Address(RVA = "0x22E824C", Offset = "0x22E824C", VA = "0x22E824C")] set
      {
      }
      [Token(Token = "0x600B52A"), Address(RVA = "0x22E8268", Offset = "0x22E8268", VA = "0x22E8268")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B52B")]
    [Address(RVA = "0x22E8284", Offset = "0x22E8284", VA = "0x22E8284")]
    public APITotal_missionAccept(string apiPath = "api/v1/total_mission/accept")
    {
    }

    [Token(Token = "0x600B52C")]
    [Address(RVA = "0x22E831C", Offset = "0x22E831C", VA = "0x22E831C")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B52D")]
    [Address(RVA = "0x22E83AC", Offset = "0x22E83AC", VA = "0x22E83AC")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B52E")]
    [Address(RVA = "0x22E83B8", Offset = "0x22E83B8", VA = "0x22E83B8")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B52F")]
    [Address(RVA = "0x22E848C", Offset = "0x22E848C", VA = "0x22E848C")]
    private void OnSuccess(string json)
    {
    }
  }
}
