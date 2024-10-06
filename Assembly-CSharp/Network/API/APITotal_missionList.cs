// Decompiled with JetBrains decompiler
// Type: Network.API.APITotal_missionList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E89")]
  public class APITotal_missionList
  {
    [Token(Token = "0x4008334")]
    public const string DefaultAPIPath = "api/v1/total_mission/list";
    [Token(Token = "0x4008338")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4008339")]
    [FieldOffset(Offset = "0x30")]
    public Action<APITotal_missionListResponse> onSuccess;
    [Token(Token = "0x400833A")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002530")]
    public APITotal_missionListRequest Request
    {
      [Token(Token = "0x600B53A"), Address(RVA = "0x22E8770", Offset = "0x22E8770", VA = "0x22E8770")] private get
      {
        return (APITotal_missionListRequest) null;
      }
      [Token(Token = "0x600B53B"), Address(RVA = "0x22E8778", Offset = "0x22E8778", VA = "0x22E8778")] set
      {
      }
    }

    [Token(Token = "0x17002531")]
    public APITotal_missionListResponse Response
    {
      [Token(Token = "0x600B53C"), Address(RVA = "0x22E8780", Offset = "0x22E8780", VA = "0x22E8780")] get
      {
        return (APITotal_missionListResponse) null;
      }
      [Token(Token = "0x600B53D"), Address(RVA = "0x22E8788", Offset = "0x22E8788", VA = "0x22E8788")] private set
      {
      }
    }

    [Token(Token = "0x17002532")]
    public int ResponseCode
    {
      [Token(Token = "0x600B53E"), Address(RVA = "0x22E8790", Offset = "0x22E8790", VA = "0x22E8790")] get
      {
        return new int();
      }
      [Token(Token = "0x600B53F"), Address(RVA = "0x22E8798", Offset = "0x22E8798", VA = "0x22E8798")] private set
      {
      }
    }

    [Token(Token = "0x17002533")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B540"), Address(RVA = "0x22E87A0", Offset = "0x22E87A0", VA = "0x22E87A0")] set
      {
      }
      [Token(Token = "0x600B541"), Address(RVA = "0x22E87BC", Offset = "0x22E87BC", VA = "0x22E87BC")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B542")]
    [Address(RVA = "0x22E87D8", Offset = "0x22E87D8", VA = "0x22E87D8")]
    public APITotal_missionList(string apiPath = "api/v1/total_mission/list")
    {
    }

    [Token(Token = "0x600B543")]
    [Address(RVA = "0x22E8870", Offset = "0x22E8870", VA = "0x22E8870")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B544")]
    [Address(RVA = "0x22E8900", Offset = "0x22E8900", VA = "0x22E8900")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B545")]
    [Address(RVA = "0x22E890C", Offset = "0x22E890C", VA = "0x22E890C")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B546")]
    [Address(RVA = "0x22E89E0", Offset = "0x22E89E0", VA = "0x22E89E0")]
    private void OnSuccess(string json)
    {
    }
  }
}
