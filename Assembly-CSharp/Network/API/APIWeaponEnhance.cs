// Decompiled with JetBrains decompiler
// Type: Network.API.APIWeaponEnhance
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001EF1")]
  public class APIWeaponEnhance
  {
    [Token(Token = "0x40084DB")]
    public const string DefaultAPIPath = "api/v1/weapon/enhance";
    [Token(Token = "0x40084DF")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x40084E0")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIWeaponEnhanceResponse> onSuccess;
    [Token(Token = "0x40084E1")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002622")]
    public APIWeaponEnhanceRequest Request
    {
      [Token(Token = "0x600B7CC"), Address(RVA = "0x2131F1C", Offset = "0x2131F1C", VA = "0x2131F1C")] private get
      {
        return (APIWeaponEnhanceRequest) null;
      }
      [Token(Token = "0x600B7CD"), Address(RVA = "0x2131F24", Offset = "0x2131F24", VA = "0x2131F24")] set
      {
      }
    }

    [Token(Token = "0x17002623")]
    public APIWeaponEnhanceResponse Response
    {
      [Token(Token = "0x600B7CE"), Address(RVA = "0x2131F2C", Offset = "0x2131F2C", VA = "0x2131F2C")] get
      {
        return (APIWeaponEnhanceResponse) null;
      }
      [Token(Token = "0x600B7CF"), Address(RVA = "0x2131F34", Offset = "0x2131F34", VA = "0x2131F34")] private set
      {
      }
    }

    [Token(Token = "0x17002624")]
    public int ResponseCode
    {
      [Token(Token = "0x600B7D0"), Address(RVA = "0x2131F3C", Offset = "0x2131F3C", VA = "0x2131F3C")] get
      {
        return new int();
      }
      [Token(Token = "0x600B7D1"), Address(RVA = "0x2131F44", Offset = "0x2131F44", VA = "0x2131F44")] private set
      {
      }
    }

    [Token(Token = "0x17002625")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B7D2"), Address(RVA = "0x2131F4C", Offset = "0x2131F4C", VA = "0x2131F4C")] set
      {
      }
      [Token(Token = "0x600B7D3"), Address(RVA = "0x2131F68", Offset = "0x2131F68", VA = "0x2131F68")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B7D4")]
    [Address(RVA = "0x2131F84", Offset = "0x2131F84", VA = "0x2131F84")]
    public APIWeaponEnhance(string apiPath = "api/v1/weapon/enhance")
    {
    }

    [Token(Token = "0x600B7D5")]
    [Address(RVA = "0x213201C", Offset = "0x213201C", VA = "0x213201C")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B7D6")]
    [Address(RVA = "0x21320AC", Offset = "0x21320AC", VA = "0x21320AC")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B7D7")]
    [Address(RVA = "0x21320B8", Offset = "0x21320B8", VA = "0x21320B8")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B7D8")]
    [Address(RVA = "0x213218C", Offset = "0x213218C", VA = "0x213218C")]
    private void OnSuccess(string json)
    {
    }
  }
}
