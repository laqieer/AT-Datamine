// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitTrustSkillEnhance
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001EDD")]
  public class APIUnitTrustSkillEnhance
  {
    [Token(Token = "0x400848A")]
    public const string DefaultAPIPath = "api/v1/unit_trust/skill_enhance";
    [Token(Token = "0x400848E")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x400848F")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIUnitTrustSkillEnhanceResponse> onSuccess;
    [Token(Token = "0x4008490")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170025F2")]
    public APIUnitTrustSkillEnhanceRequest Request
    {
      [Token(Token = "0x600B74C"), Address(RVA = "0x2130410", Offset = "0x2130410", VA = "0x2130410")] private get
      {
        return (APIUnitTrustSkillEnhanceRequest) null;
      }
      [Token(Token = "0x600B74D"), Address(RVA = "0x2130418", Offset = "0x2130418", VA = "0x2130418")] set
      {
      }
    }

    [Token(Token = "0x170025F3")]
    public APIUnitTrustSkillEnhanceResponse Response
    {
      [Token(Token = "0x600B74E"), Address(RVA = "0x2130420", Offset = "0x2130420", VA = "0x2130420")] get
      {
        return (APIUnitTrustSkillEnhanceResponse) null;
      }
      [Token(Token = "0x600B74F"), Address(RVA = "0x2130428", Offset = "0x2130428", VA = "0x2130428")] private set
      {
      }
    }

    [Token(Token = "0x170025F4")]
    public int ResponseCode
    {
      [Token(Token = "0x600B750"), Address(RVA = "0x2130430", Offset = "0x2130430", VA = "0x2130430")] get
      {
        return new int();
      }
      [Token(Token = "0x600B751"), Address(RVA = "0x2130438", Offset = "0x2130438", VA = "0x2130438")] private set
      {
      }
    }

    [Token(Token = "0x170025F5")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B752"), Address(RVA = "0x2130440", Offset = "0x2130440", VA = "0x2130440")] set
      {
      }
      [Token(Token = "0x600B753"), Address(RVA = "0x213045C", Offset = "0x213045C", VA = "0x213045C")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B754")]
    [Address(RVA = "0x2130478", Offset = "0x2130478", VA = "0x2130478")]
    public APIUnitTrustSkillEnhance(string apiPath = "api/v1/unit_trust/skill_enhance")
    {
    }

    [Token(Token = "0x600B755")]
    [Address(RVA = "0x2130510", Offset = "0x2130510", VA = "0x2130510")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B756")]
    [Address(RVA = "0x21305A0", Offset = "0x21305A0", VA = "0x21305A0")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B757")]
    [Address(RVA = "0x21305AC", Offset = "0x21305AC", VA = "0x21305AC")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B758")]
    [Address(RVA = "0x2130680", Offset = "0x2130680", VA = "0x2130680")]
    private void OnSuccess(string json)
    {
    }
  }
}
