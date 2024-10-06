// Decompiled with JetBrains decompiler
// Type: Network.API.APIStoryFacilityExecution
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E31")]
  public class APIStoryFacilityExecution
  {
    [Token(Token = "0x400815C")]
    public const string DefaultAPIPath = "api/v1/story/facility/execution";
    [Token(Token = "0x4008160")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4008161")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIStoryFacilityExecutionResponse> onSuccess;
    [Token(Token = "0x4008162")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002421")]
    public APIStoryFacilityExecutionRequest Request
    {
      [Token(Token = "0x600B2CB"), Address(RVA = "0x22E0E90", Offset = "0x22E0E90", VA = "0x22E0E90")] private get
      {
        return (APIStoryFacilityExecutionRequest) null;
      }
      [Token(Token = "0x600B2CC"), Address(RVA = "0x22E0E98", Offset = "0x22E0E98", VA = "0x22E0E98")] set
      {
      }
    }

    [Token(Token = "0x17002422")]
    public APIStoryFacilityExecutionResponse Response
    {
      [Token(Token = "0x600B2CD"), Address(RVA = "0x22E0EA0", Offset = "0x22E0EA0", VA = "0x22E0EA0")] get
      {
        return (APIStoryFacilityExecutionResponse) null;
      }
      [Token(Token = "0x600B2CE"), Address(RVA = "0x22E0EA8", Offset = "0x22E0EA8", VA = "0x22E0EA8")] private set
      {
      }
    }

    [Token(Token = "0x17002423")]
    public int ResponseCode
    {
      [Token(Token = "0x600B2CF"), Address(RVA = "0x22E0EB0", Offset = "0x22E0EB0", VA = "0x22E0EB0")] get
      {
        return new int();
      }
      [Token(Token = "0x600B2D0"), Address(RVA = "0x22E0EB8", Offset = "0x22E0EB8", VA = "0x22E0EB8")] private set
      {
      }
    }

    [Token(Token = "0x17002424")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B2D1"), Address(RVA = "0x22E0EC0", Offset = "0x22E0EC0", VA = "0x22E0EC0")] set
      {
      }
      [Token(Token = "0x600B2D2"), Address(RVA = "0x22E0EDC", Offset = "0x22E0EDC", VA = "0x22E0EDC")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B2D3")]
    [Address(RVA = "0x22E0EF8", Offset = "0x22E0EF8", VA = "0x22E0EF8")]
    public APIStoryFacilityExecution(string apiPath = "api/v1/story/facility/execution")
    {
    }

    [Token(Token = "0x600B2D4")]
    [Address(RVA = "0x22E0F90", Offset = "0x22E0F90", VA = "0x22E0F90")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B2D5")]
    [Address(RVA = "0x22E1020", Offset = "0x22E1020", VA = "0x22E1020")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B2D6")]
    [Address(RVA = "0x22E102C", Offset = "0x22E102C", VA = "0x22E102C")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B2D7")]
    [Address(RVA = "0x22E1100", Offset = "0x22E1100", VA = "0x22E1100")]
    private void OnSuccess(string json)
    {
    }
  }
}
