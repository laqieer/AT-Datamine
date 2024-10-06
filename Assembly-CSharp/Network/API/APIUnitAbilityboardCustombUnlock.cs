// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitAbilityboardCustombUnlock
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E99")]
  public class APIUnitAbilityboardCustombUnlock
  {
    [Token(Token = "0x400837F")]
    public const string DefaultAPIPath = "api/v1/unit/abilityboard/customb/unlock";
    [Token(Token = "0x4008383")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4008384")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIUnitAbilityboardCustombUnlockResponse> onSuccess;
    [Token(Token = "0x4008385")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x1700255D")]
    public APIUnitAbilityboardCustombUnlockRequest Request
    {
      [Token(Token = "0x600B5A7"), Address(RVA = "0x22E9D48", Offset = "0x22E9D48", VA = "0x22E9D48")] private get
      {
        return (APIUnitAbilityboardCustombUnlockRequest) null;
      }
      [Token(Token = "0x600B5A8"), Address(RVA = "0x22E9D50", Offset = "0x22E9D50", VA = "0x22E9D50")] set
      {
      }
    }

    [Token(Token = "0x1700255E")]
    public APIUnitAbilityboardCustombUnlockResponse Response
    {
      [Token(Token = "0x600B5A9"), Address(RVA = "0x22E9D58", Offset = "0x22E9D58", VA = "0x22E9D58")] get
      {
        return (APIUnitAbilityboardCustombUnlockResponse) null;
      }
      [Token(Token = "0x600B5AA"), Address(RVA = "0x22E9D60", Offset = "0x22E9D60", VA = "0x22E9D60")] private set
      {
      }
    }

    [Token(Token = "0x1700255F")]
    public int ResponseCode
    {
      [Token(Token = "0x600B5AB"), Address(RVA = "0x22E9D68", Offset = "0x22E9D68", VA = "0x22E9D68")] get
      {
        return new int();
      }
      [Token(Token = "0x600B5AC"), Address(RVA = "0x22E9D70", Offset = "0x22E9D70", VA = "0x22E9D70")] private set
      {
      }
    }

    [Token(Token = "0x17002560")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B5AD"), Address(RVA = "0x22E9D78", Offset = "0x22E9D78", VA = "0x22E9D78")] set
      {
      }
      [Token(Token = "0x600B5AE"), Address(RVA = "0x22E9D94", Offset = "0x22E9D94", VA = "0x22E9D94")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B5AF")]
    [Address(RVA = "0x22E9DB0", Offset = "0x22E9DB0", VA = "0x22E9DB0")]
    public APIUnitAbilityboardCustombUnlock(string apiPath = "api/v1/unit/abilityboard/customb/unlock")
    {
    }

    [Token(Token = "0x600B5B0")]
    [Address(RVA = "0x22E9E48", Offset = "0x22E9E48", VA = "0x22E9E48")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B5B1")]
    [Address(RVA = "0x22E9ED8", Offset = "0x22E9ED8", VA = "0x22E9ED8")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B5B2")]
    [Address(RVA = "0x22E9EE4", Offset = "0x22E9EE4", VA = "0x22E9EE4")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B5B3")]
    [Address(RVA = "0x22E9FB8", Offset = "0x22E9FB8", VA = "0x22E9FB8")]
    private void OnSuccess(string json)
    {
    }
  }
}
