// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitAbilityboardList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E9D")]
  public class APIUnitAbilityboardList
  {
    [Token(Token = "0x400838E")]
    public const string DefaultAPIPath = "api/v1/unit/abilityboard/list";
    [Token(Token = "0x4008392")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4008393")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIUnitAbilityboardListResponse> onSuccess;
    [Token(Token = "0x4008394")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002566")]
    public APIUnitAbilityboardListRequest Request
    {
      [Token(Token = "0x600B5C0"), Address(RVA = "0x22EA2AC", Offset = "0x22EA2AC", VA = "0x22EA2AC")] private get
      {
        return (APIUnitAbilityboardListRequest) null;
      }
      [Token(Token = "0x600B5C1"), Address(RVA = "0x22EA2B4", Offset = "0x22EA2B4", VA = "0x22EA2B4")] set
      {
      }
    }

    [Token(Token = "0x17002567")]
    public APIUnitAbilityboardListResponse Response
    {
      [Token(Token = "0x600B5C2"), Address(RVA = "0x22EA2BC", Offset = "0x22EA2BC", VA = "0x22EA2BC")] get
      {
        return (APIUnitAbilityboardListResponse) null;
      }
      [Token(Token = "0x600B5C3"), Address(RVA = "0x22EA2C4", Offset = "0x22EA2C4", VA = "0x22EA2C4")] private set
      {
      }
    }

    [Token(Token = "0x17002568")]
    public int ResponseCode
    {
      [Token(Token = "0x600B5C4"), Address(RVA = "0x22EA2CC", Offset = "0x22EA2CC", VA = "0x22EA2CC")] get
      {
        return new int();
      }
      [Token(Token = "0x600B5C5"), Address(RVA = "0x22EA2D4", Offset = "0x22EA2D4", VA = "0x22EA2D4")] private set
      {
      }
    }

    [Token(Token = "0x17002569")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B5C6"), Address(RVA = "0x22EA2DC", Offset = "0x22EA2DC", VA = "0x22EA2DC")] set
      {
      }
      [Token(Token = "0x600B5C7"), Address(RVA = "0x22EA2F8", Offset = "0x22EA2F8", VA = "0x22EA2F8")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B5C8")]
    [Address(RVA = "0x22EA314", Offset = "0x22EA314", VA = "0x22EA314")]
    public APIUnitAbilityboardList(string apiPath = "api/v1/unit/abilityboard/list")
    {
    }

    [Token(Token = "0x600B5C9")]
    [Address(RVA = "0x22EA3AC", Offset = "0x22EA3AC", VA = "0x22EA3AC")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B5CA")]
    [Address(RVA = "0x22EA43C", Offset = "0x22EA43C", VA = "0x22EA43C")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B5CB")]
    [Address(RVA = "0x22EA448", Offset = "0x22EA448", VA = "0x22EA448")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B5CC")]
    [Address(RVA = "0x22EA51C", Offset = "0x22EA51C", VA = "0x22EA51C")]
    private void OnSuccess(string json)
    {
    }
  }
}
