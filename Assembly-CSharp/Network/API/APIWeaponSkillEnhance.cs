// Decompiled with JetBrains decompiler
// Type: Network.API.APIWeaponSkillEnhance
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001F09")]
  public class APIWeaponSkillEnhance
  {
    [Token(Token = "0x4008536")]
    public const string DefaultAPIPath = "api/v1/weapon/skill_enhance";
    [Token(Token = "0x400853A")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x400853B")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIWeaponSkillEnhanceResponse> onSuccess;
    [Token(Token = "0x400853C")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002655")]
    public APIWeaponSkillEnhanceRequest Request
    {
      [Token(Token = "0x600B85F"), Address(RVA = "0x2133F5C", Offset = "0x2133F5C", VA = "0x2133F5C")] private get
      {
        return (APIWeaponSkillEnhanceRequest) null;
      }
      [Token(Token = "0x600B860"), Address(RVA = "0x2133F64", Offset = "0x2133F64", VA = "0x2133F64")] set
      {
      }
    }

    [Token(Token = "0x17002656")]
    public APIWeaponSkillEnhanceResponse Response
    {
      [Token(Token = "0x600B861"), Address(RVA = "0x2133F6C", Offset = "0x2133F6C", VA = "0x2133F6C")] get
      {
        return (APIWeaponSkillEnhanceResponse) null;
      }
      [Token(Token = "0x600B862"), Address(RVA = "0x2133F74", Offset = "0x2133F74", VA = "0x2133F74")] private set
      {
      }
    }

    [Token(Token = "0x17002657")]
    public int ResponseCode
    {
      [Token(Token = "0x600B863"), Address(RVA = "0x2133F7C", Offset = "0x2133F7C", VA = "0x2133F7C")] get
      {
        return new int();
      }
      [Token(Token = "0x600B864"), Address(RVA = "0x2133F84", Offset = "0x2133F84", VA = "0x2133F84")] private set
      {
      }
    }

    [Token(Token = "0x17002658")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B865"), Address(RVA = "0x2133F8C", Offset = "0x2133F8C", VA = "0x2133F8C")] set
      {
      }
      [Token(Token = "0x600B866"), Address(RVA = "0x2133FA8", Offset = "0x2133FA8", VA = "0x2133FA8")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B867")]
    [Address(RVA = "0x2133FC4", Offset = "0x2133FC4", VA = "0x2133FC4")]
    public APIWeaponSkillEnhance(string apiPath = "api/v1/weapon/skill_enhance")
    {
    }

    [Token(Token = "0x600B868")]
    [Address(RVA = "0x213405C", Offset = "0x213405C", VA = "0x213405C")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B869")]
    [Address(RVA = "0x21340EC", Offset = "0x21340EC", VA = "0x21340EC")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B86A")]
    [Address(RVA = "0x21340F8", Offset = "0x21340F8", VA = "0x21340F8")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B86B")]
    [Address(RVA = "0x21341CC", Offset = "0x21341CC", VA = "0x21341CC")]
    private void OnSuccess(string json)
    {
    }
  }
}
