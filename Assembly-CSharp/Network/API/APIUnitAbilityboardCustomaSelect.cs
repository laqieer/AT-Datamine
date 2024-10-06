// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitAbilityboardCustomaSelect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E95")]
  public class APIUnitAbilityboardCustomaSelect
  {
    [Token(Token = "0x4008369")]
    public const string DefaultAPIPath = "api/v1/unit/abilityboard/customa/select";
    [Token(Token = "0x400836D")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x400836E")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIUnitAbilityboardCustomaSelectResponse> onSuccess;
    [Token(Token = "0x400836F")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x1700254E")]
    public APIUnitAbilityboardCustomaSelectRequest Request
    {
      [Token(Token = "0x600B588"), Address(RVA = "0x22E97B4", Offset = "0x22E97B4", VA = "0x22E97B4")] private get
      {
        return (APIUnitAbilityboardCustomaSelectRequest) null;
      }
      [Token(Token = "0x600B589"), Address(RVA = "0x22E97BC", Offset = "0x22E97BC", VA = "0x22E97BC")] set
      {
      }
    }

    [Token(Token = "0x1700254F")]
    public APIUnitAbilityboardCustomaSelectResponse Response
    {
      [Token(Token = "0x600B58A"), Address(RVA = "0x22E97C4", Offset = "0x22E97C4", VA = "0x22E97C4")] get
      {
        return (APIUnitAbilityboardCustomaSelectResponse) null;
      }
      [Token(Token = "0x600B58B"), Address(RVA = "0x22E97CC", Offset = "0x22E97CC", VA = "0x22E97CC")] private set
      {
      }
    }

    [Token(Token = "0x17002550")]
    public int ResponseCode
    {
      [Token(Token = "0x600B58C"), Address(RVA = "0x22E97D4", Offset = "0x22E97D4", VA = "0x22E97D4")] get
      {
        return new int();
      }
      [Token(Token = "0x600B58D"), Address(RVA = "0x22E97DC", Offset = "0x22E97DC", VA = "0x22E97DC")] private set
      {
      }
    }

    [Token(Token = "0x17002551")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B58E"), Address(RVA = "0x22E97E4", Offset = "0x22E97E4", VA = "0x22E97E4")] set
      {
      }
      [Token(Token = "0x600B58F"), Address(RVA = "0x22E9800", Offset = "0x22E9800", VA = "0x22E9800")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B590")]
    [Address(RVA = "0x22E981C", Offset = "0x22E981C", VA = "0x22E981C")]
    public APIUnitAbilityboardCustomaSelect(string apiPath = "api/v1/unit/abilityboard/customa/select")
    {
    }

    [Token(Token = "0x600B591")]
    [Address(RVA = "0x22E98B4", Offset = "0x22E98B4", VA = "0x22E98B4")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B592")]
    [Address(RVA = "0x22E9944", Offset = "0x22E9944", VA = "0x22E9944")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B593")]
    [Address(RVA = "0x22E9950", Offset = "0x22E9950", VA = "0x22E9950")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B594")]
    [Address(RVA = "0x22E9A24", Offset = "0x22E9A24", VA = "0x22E9A24")]
    private void OnSuccess(string json)
    {
    }
  }
}
