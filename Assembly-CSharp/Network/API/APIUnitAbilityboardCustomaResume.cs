// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitAbilityboardCustomaResume
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E91")]
  public class APIUnitAbilityboardCustomaResume
  {
    [Token(Token = "0x4008355")]
    public const string DefaultAPIPath = "api/v1/unit/abilityboard/customa/resume";
    [Token(Token = "0x4008359")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x400835A")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIUnitAbilityboardCustomaResumeResponse> onSuccess;
    [Token(Token = "0x400835B")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002543")]
    public APIUnitAbilityboardCustomaResumeRequest Request
    {
      [Token(Token = "0x600B56D"), Address(RVA = "0x22E9240", Offset = "0x22E9240", VA = "0x22E9240")] private get
      {
        return (APIUnitAbilityboardCustomaResumeRequest) null;
      }
      [Token(Token = "0x600B56E"), Address(RVA = "0x22E9248", Offset = "0x22E9248", VA = "0x22E9248")] set
      {
      }
    }

    [Token(Token = "0x17002544")]
    public APIUnitAbilityboardCustomaResumeResponse Response
    {
      [Token(Token = "0x600B56F"), Address(RVA = "0x22E9250", Offset = "0x22E9250", VA = "0x22E9250")] get
      {
        return (APIUnitAbilityboardCustomaResumeResponse) null;
      }
      [Token(Token = "0x600B570"), Address(RVA = "0x22E9258", Offset = "0x22E9258", VA = "0x22E9258")] private set
      {
      }
    }

    [Token(Token = "0x17002545")]
    public int ResponseCode
    {
      [Token(Token = "0x600B571"), Address(RVA = "0x22E9260", Offset = "0x22E9260", VA = "0x22E9260")] get
      {
        return new int();
      }
      [Token(Token = "0x600B572"), Address(RVA = "0x22E9268", Offset = "0x22E9268", VA = "0x22E9268")] private set
      {
      }
    }

    [Token(Token = "0x17002546")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B573"), Address(RVA = "0x22E9270", Offset = "0x22E9270", VA = "0x22E9270")] set
      {
      }
      [Token(Token = "0x600B574"), Address(RVA = "0x22E928C", Offset = "0x22E928C", VA = "0x22E928C")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B575")]
    [Address(RVA = "0x22E92A8", Offset = "0x22E92A8", VA = "0x22E92A8")]
    public APIUnitAbilityboardCustomaResume(string apiPath = "api/v1/unit/abilityboard/customa/resume")
    {
    }

    [Token(Token = "0x600B576")]
    [Address(RVA = "0x22E9340", Offset = "0x22E9340", VA = "0x22E9340")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B577")]
    [Address(RVA = "0x22E93D0", Offset = "0x22E93D0", VA = "0x22E93D0")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B578")]
    [Address(RVA = "0x22E93DC", Offset = "0x22E93DC", VA = "0x22E93DC")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B579")]
    [Address(RVA = "0x22E94B0", Offset = "0x22E94B0", VA = "0x22E94B0")]
    private void OnSuccess(string json)
    {
    }
  }
}
