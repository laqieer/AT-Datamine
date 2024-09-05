// Decompiled with JetBrains decompiler
// Type: Network.API.APIStoryFacilityPrepare
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E35")]
  public class APIStoryFacilityPrepare
  {
    [Token(Token = "0x400816A")]
    public const string DefaultAPIPath = "api/v1/story/facility/prepare";
    [Token(Token = "0x400816E")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x400816F")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIStoryFacilityPrepareResponse> onSuccess;
    [Token(Token = "0x4008170")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002429")]
    public APIStoryFacilityPrepareRequest Request
    {
      [Token(Token = "0x600B2E3"), Address(RVA = "0x22E13EC", Offset = "0x22E13EC", VA = "0x22E13EC")] private get
      {
        return (APIStoryFacilityPrepareRequest) null;
      }
      [Token(Token = "0x600B2E4"), Address(RVA = "0x22E13F4", Offset = "0x22E13F4", VA = "0x22E13F4")] set
      {
      }
    }

    [Token(Token = "0x1700242A")]
    public APIStoryFacilityPrepareResponse Response
    {
      [Token(Token = "0x600B2E5"), Address(RVA = "0x22E13FC", Offset = "0x22E13FC", VA = "0x22E13FC")] get
      {
        return (APIStoryFacilityPrepareResponse) null;
      }
      [Token(Token = "0x600B2E6"), Address(RVA = "0x22E1404", Offset = "0x22E1404", VA = "0x22E1404")] private set
      {
      }
    }

    [Token(Token = "0x1700242B")]
    public int ResponseCode
    {
      [Token(Token = "0x600B2E7"), Address(RVA = "0x22E140C", Offset = "0x22E140C", VA = "0x22E140C")] get
      {
        return new int();
      }
      [Token(Token = "0x600B2E8"), Address(RVA = "0x22E1414", Offset = "0x22E1414", VA = "0x22E1414")] private set
      {
      }
    }

    [Token(Token = "0x1700242C")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B2E9"), Address(RVA = "0x22E141C", Offset = "0x22E141C", VA = "0x22E141C")] set
      {
      }
      [Token(Token = "0x600B2EA"), Address(RVA = "0x22E1438", Offset = "0x22E1438", VA = "0x22E1438")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B2EB")]
    [Address(RVA = "0x22E1454", Offset = "0x22E1454", VA = "0x22E1454")]
    public APIStoryFacilityPrepare(string apiPath = "api/v1/story/facility/prepare")
    {
    }

    [Token(Token = "0x600B2EC")]
    [Address(RVA = "0x22E14EC", Offset = "0x22E14EC", VA = "0x22E14EC")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B2ED")]
    [Address(RVA = "0x22E157C", Offset = "0x22E157C", VA = "0x22E157C")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B2EE")]
    [Address(RVA = "0x22E1588", Offset = "0x22E1588", VA = "0x22E1588")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B2EF")]
    [Address(RVA = "0x22E165C", Offset = "0x22E165C", VA = "0x22E165C")]
    private void OnSuccess(string json)
    {
    }
  }
}
