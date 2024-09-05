// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitCharacterConfirmed_comeback
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001EB1")]
  public class APIUnitCharacterConfirmed_comeback
  {
    [Token(Token = "0x40083DB")]
    public const string DefaultAPIPath = "api/v1/unit/character/confirmed_comeback";
    [Token(Token = "0x40083DF")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40083E0")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIUnitCharacterConfirmed_comebackResponse> onSuccess;
    [Token(Token = "0x40083E1")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002592")]
    public APIUnitCharacterConfirmed_comebackRequest Request
    {
      [Token(Token = "0x600B63C"), Address(RVA = "0x22EBD98", Offset = "0x22EBD98", VA = "0x22EBD98")] private get
      {
        return (APIUnitCharacterConfirmed_comebackRequest) null;
      }
      [Token(Token = "0x600B63D"), Address(RVA = "0x22EBDA0", Offset = "0x22EBDA0", VA = "0x22EBDA0")] set
      {
      }
    }

    [Token(Token = "0x17002593")]
    public APIUnitCharacterConfirmed_comebackResponse Response
    {
      [Token(Token = "0x600B63E"), Address(RVA = "0x22EBDA8", Offset = "0x22EBDA8", VA = "0x22EBDA8")] get
      {
        return (APIUnitCharacterConfirmed_comebackResponse) null;
      }
      [Token(Token = "0x600B63F"), Address(RVA = "0x22EBDB0", Offset = "0x22EBDB0", VA = "0x22EBDB0")] private set
      {
      }
    }

    [Token(Token = "0x17002594")]
    public int ResponseCode
    {
      [Token(Token = "0x600B640"), Address(RVA = "0x22EBDB8", Offset = "0x22EBDB8", VA = "0x22EBDB8")] get
      {
        return new int();
      }
      [Token(Token = "0x600B641"), Address(RVA = "0x22EBDC0", Offset = "0x22EBDC0", VA = "0x22EBDC0")] private set
      {
      }
    }

    [Token(Token = "0x17002595")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B642"), Address(RVA = "0x22EBDC8", Offset = "0x22EBDC8", VA = "0x22EBDC8")] set
      {
      }
      [Token(Token = "0x600B643"), Address(RVA = "0x22EBDE4", Offset = "0x22EBDE4", VA = "0x22EBDE4")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B644")]
    [Address(RVA = "0x22EBE00", Offset = "0x22EBE00", VA = "0x22EBE00")]
    public APIUnitCharacterConfirmed_comeback(string apiPath = "api/v1/unit/character/confirmed_comeback")
    {
    }

    [Token(Token = "0x600B645")]
    [Address(RVA = "0x22EBE98", Offset = "0x22EBE98", VA = "0x22EBE98")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B646")]
    [Address(RVA = "0x22EBF28", Offset = "0x22EBF28", VA = "0x22EBF28")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B647")]
    [Address(RVA = "0x22EBF34", Offset = "0x22EBF34", VA = "0x22EBF34")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B648")]
    [Address(RVA = "0x22EC008", Offset = "0x22EC008", VA = "0x22EC008")]
    private void OnSuccess(string json)
    {
    }
  }
}
