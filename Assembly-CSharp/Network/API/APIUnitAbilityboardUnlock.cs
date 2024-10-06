// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitAbilityboardUnlock
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001EA1")]
  public class APIUnitAbilityboardUnlock
  {
    [Token(Token = "0x40083A3")]
    public const string DefaultAPIPath = "api/v1/unit/abilityboard/unlock";
    [Token(Token = "0x40083A7")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40083A8")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIUnitAbilityboardUnlockResponse> onSuccess;
    [Token(Token = "0x40083A9")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002574")]
    public APIUnitAbilityboardUnlockRequest Request
    {
      [Token(Token = "0x600B5DE"), Address(RVA = "0x22EA838", Offset = "0x22EA838", VA = "0x22EA838")] private get
      {
        return (APIUnitAbilityboardUnlockRequest) null;
      }
      [Token(Token = "0x600B5DF"), Address(RVA = "0x22EA840", Offset = "0x22EA840", VA = "0x22EA840")] set
      {
      }
    }

    [Token(Token = "0x17002575")]
    public APIUnitAbilityboardUnlockResponse Response
    {
      [Token(Token = "0x600B5E0"), Address(RVA = "0x22EA848", Offset = "0x22EA848", VA = "0x22EA848")] get
      {
        return (APIUnitAbilityboardUnlockResponse) null;
      }
      [Token(Token = "0x600B5E1"), Address(RVA = "0x22EA850", Offset = "0x22EA850", VA = "0x22EA850")] private set
      {
      }
    }

    [Token(Token = "0x17002576")]
    public int ResponseCode
    {
      [Token(Token = "0x600B5E2"), Address(RVA = "0x22EA858", Offset = "0x22EA858", VA = "0x22EA858")] get
      {
        return new int();
      }
      [Token(Token = "0x600B5E3"), Address(RVA = "0x22EA860", Offset = "0x22EA860", VA = "0x22EA860")] private set
      {
      }
    }

    [Token(Token = "0x17002577")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B5E4"), Address(RVA = "0x22EA868", Offset = "0x22EA868", VA = "0x22EA868")] set
      {
      }
      [Token(Token = "0x600B5E5"), Address(RVA = "0x22EA884", Offset = "0x22EA884", VA = "0x22EA884")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B5E6")]
    [Address(RVA = "0x22EA8A0", Offset = "0x22EA8A0", VA = "0x22EA8A0")]
    public APIUnitAbilityboardUnlock(string apiPath = "api/v1/unit/abilityboard/unlock")
    {
    }

    [Token(Token = "0x600B5E7")]
    [Address(RVA = "0x22EA938", Offset = "0x22EA938", VA = "0x22EA938")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B5E8")]
    [Address(RVA = "0x22EA9C8", Offset = "0x22EA9C8", VA = "0x22EA9C8")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B5E9")]
    [Address(RVA = "0x22EA9D4", Offset = "0x22EA9D4", VA = "0x22EA9D4")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B5EA")]
    [Address(RVA = "0x22EAAA8", Offset = "0x22EAAA8", VA = "0x22EAAA8")]
    private void OnSuccess(string json)
    {
    }
  }
}
