// Decompiled with JetBrains decompiler
// Type: Network.API.APIWeaponOption_change_confirm
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001F01")]
  public class APIWeaponOption_change_confirm
  {
    [Token(Token = "0x4008514")]
    public const string DefaultAPIPath = "api/v1/weapon/option_change_confirm";
    [Token(Token = "0x4008518")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4008519")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIWeaponOption_change_confirmResponse> onSuccess;
    [Token(Token = "0x400851A")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002641")]
    public APIWeaponOption_change_confirmRequest Request
    {
      [Token(Token = "0x600B82B"), Address(RVA = "0x2133484", Offset = "0x2133484", VA = "0x2133484")] private get
      {
        return (APIWeaponOption_change_confirmRequest) null;
      }
      [Token(Token = "0x600B82C"), Address(RVA = "0x213348C", Offset = "0x213348C", VA = "0x213348C")] set
      {
      }
    }

    [Token(Token = "0x17002642")]
    public APIWeaponOption_change_confirmResponse Response
    {
      [Token(Token = "0x600B82D"), Address(RVA = "0x2133494", Offset = "0x2133494", VA = "0x2133494")] get
      {
        return (APIWeaponOption_change_confirmResponse) null;
      }
      [Token(Token = "0x600B82E"), Address(RVA = "0x213349C", Offset = "0x213349C", VA = "0x213349C")] private set
      {
      }
    }

    [Token(Token = "0x17002643")]
    public int ResponseCode
    {
      [Token(Token = "0x600B82F"), Address(RVA = "0x21334A4", Offset = "0x21334A4", VA = "0x21334A4")] get
      {
        return new int();
      }
      [Token(Token = "0x600B830"), Address(RVA = "0x21334AC", Offset = "0x21334AC", VA = "0x21334AC")] private set
      {
      }
    }

    [Token(Token = "0x17002644")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B831"), Address(RVA = "0x21334B4", Offset = "0x21334B4", VA = "0x21334B4")] set
      {
      }
      [Token(Token = "0x600B832"), Address(RVA = "0x21334D0", Offset = "0x21334D0", VA = "0x21334D0")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B833")]
    [Address(RVA = "0x21334EC", Offset = "0x21334EC", VA = "0x21334EC")]
    public APIWeaponOption_change_confirm(string apiPath = "api/v1/weapon/option_change_confirm")
    {
    }

    [Token(Token = "0x600B834")]
    [Address(RVA = "0x2133584", Offset = "0x2133584", VA = "0x2133584")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B835")]
    [Address(RVA = "0x2133614", Offset = "0x2133614", VA = "0x2133614")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B836")]
    [Address(RVA = "0x2133620", Offset = "0x2133620", VA = "0x2133620")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B837")]
    [Address(RVA = "0x21336F4", Offset = "0x21336F4", VA = "0x21336F4")]
    private void OnSuccess(string json)
    {
    }
  }
}
