// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitUnit_levelUp
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001EE1")]
  public class APIUnitUnit_levelUp
  {
    [Token(Token = "0x400849C")]
    public const string DefaultAPIPath = "api/v1/unit/unit_level/up";
    [Token(Token = "0x40084A0")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40084A1")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIUnitUnit_levelUpResponse> onSuccess;
    [Token(Token = "0x40084A2")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x170025FD")]
    public APIUnitUnit_levelUpRequest Request
    {
      [Token(Token = "0x600B767"), Address(RVA = "0x2130984", Offset = "0x2130984", VA = "0x2130984")] private get
      {
        return (APIUnitUnit_levelUpRequest) null;
      }
      [Token(Token = "0x600B768"), Address(RVA = "0x213098C", Offset = "0x213098C", VA = "0x213098C")] set
      {
      }
    }

    [Token(Token = "0x170025FE")]
    public APIUnitUnit_levelUpResponse Response
    {
      [Token(Token = "0x600B769"), Address(RVA = "0x2130994", Offset = "0x2130994", VA = "0x2130994")] get
      {
        return (APIUnitUnit_levelUpResponse) null;
      }
      [Token(Token = "0x600B76A"), Address(RVA = "0x213099C", Offset = "0x213099C", VA = "0x213099C")] private set
      {
      }
    }

    [Token(Token = "0x170025FF")]
    public int ResponseCode
    {
      [Token(Token = "0x600B76B"), Address(RVA = "0x21309A4", Offset = "0x21309A4", VA = "0x21309A4")] get
      {
        return new int();
      }
      [Token(Token = "0x600B76C"), Address(RVA = "0x21309AC", Offset = "0x21309AC", VA = "0x21309AC")] private set
      {
      }
    }

    [Token(Token = "0x17002600")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B76D"), Address(RVA = "0x21309B4", Offset = "0x21309B4", VA = "0x21309B4")] set
      {
      }
      [Token(Token = "0x600B76E"), Address(RVA = "0x21309D0", Offset = "0x21309D0", VA = "0x21309D0")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B76F")]
    [Address(RVA = "0x21309EC", Offset = "0x21309EC", VA = "0x21309EC")]
    public APIUnitUnit_levelUp(string apiPath = "api/v1/unit/unit_level/up")
    {
    }

    [Token(Token = "0x600B770")]
    [Address(RVA = "0x2130A84", Offset = "0x2130A84", VA = "0x2130A84")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B771")]
    [Address(RVA = "0x2130B14", Offset = "0x2130B14", VA = "0x2130B14")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B772")]
    [Address(RVA = "0x2130B20", Offset = "0x2130B20", VA = "0x2130B20")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B773")]
    [Address(RVA = "0x2130BF4", Offset = "0x2130BF4", VA = "0x2130BF4")]
    private void OnSuccess(string json)
    {
    }
  }
}
