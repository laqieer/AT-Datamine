// Decompiled with JetBrains decompiler
// Type: Network.API.APIWeaponOption_change_cancel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001EFD")]
  public class APIWeaponOption_change_cancel
  {
    [Token(Token = "0x4008506")]
    public const string DefaultAPIPath = "api/v1/weapon/option_change_cancel";
    [Token(Token = "0x400850A")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x400850B")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIWeaponOption_change_cancelResponse> onSuccess;
    [Token(Token = "0x400850C")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x1700263A")]
    public APIWeaponOption_change_cancelRequest Request
    {
      [Token(Token = "0x600B814"), Address(RVA = "0x2132F30", Offset = "0x2132F30", VA = "0x2132F30")] private get
      {
        return (APIWeaponOption_change_cancelRequest) null;
      }
      [Token(Token = "0x600B815"), Address(RVA = "0x2132F38", Offset = "0x2132F38", VA = "0x2132F38")] set
      {
      }
    }

    [Token(Token = "0x1700263B")]
    public APIWeaponOption_change_cancelResponse Response
    {
      [Token(Token = "0x600B816"), Address(RVA = "0x2132F40", Offset = "0x2132F40", VA = "0x2132F40")] get
      {
        return (APIWeaponOption_change_cancelResponse) null;
      }
      [Token(Token = "0x600B817"), Address(RVA = "0x2132F48", Offset = "0x2132F48", VA = "0x2132F48")] private set
      {
      }
    }

    [Token(Token = "0x1700263C")]
    public int ResponseCode
    {
      [Token(Token = "0x600B818"), Address(RVA = "0x2132F50", Offset = "0x2132F50", VA = "0x2132F50")] get
      {
        return new int();
      }
      [Token(Token = "0x600B819"), Address(RVA = "0x2132F58", Offset = "0x2132F58", VA = "0x2132F58")] private set
      {
      }
    }

    [Token(Token = "0x1700263D")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B81A"), Address(RVA = "0x2132F60", Offset = "0x2132F60", VA = "0x2132F60")] set
      {
      }
      [Token(Token = "0x600B81B"), Address(RVA = "0x2132F7C", Offset = "0x2132F7C", VA = "0x2132F7C")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B81C")]
    [Address(RVA = "0x2132F98", Offset = "0x2132F98", VA = "0x2132F98")]
    public APIWeaponOption_change_cancel(string apiPath = "api/v1/weapon/option_change_cancel")
    {
    }

    [Token(Token = "0x600B81D")]
    [Address(RVA = "0x2133030", Offset = "0x2133030", VA = "0x2133030")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B81E")]
    [Address(RVA = "0x21330C0", Offset = "0x21330C0", VA = "0x21330C0")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B81F")]
    [Address(RVA = "0x21330CC", Offset = "0x21330CC", VA = "0x21330CC")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B820")]
    [Address(RVA = "0x21331A0", Offset = "0x21331A0", VA = "0x21331A0")]
    private void OnSuccess(string json)
    {
    }
  }
}
