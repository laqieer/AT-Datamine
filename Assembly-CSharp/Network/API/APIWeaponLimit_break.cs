// Decompiled with JetBrains decompiler
// Type: Network.API.APIWeaponLimit_break
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001EF9")]
  public class APIWeaponLimit_break
  {
    [Token(Token = "0x40084FB")]
    public const string DefaultAPIPath = "api/v1/weapon/limit_break";
    [Token(Token = "0x40084FF")]
    [FieldOffset(Offset = "0x28")]
    public NetworkErrorEventListener NetworkErrorEventListener;
    [Token(Token = "0x4008500")]
    [FieldOffset(Offset = "0x30")]
    public Action<APIWeaponLimit_breakResponse> onSuccess;
    [Token(Token = "0x4008501")]
    [FieldOffset(Offset = "0x38")]
    private string APIPath;

    [Token(Token = "0x17002634")]
    public APIWeaponLimit_breakRequest Request
    {
      [Token(Token = "0x600B7FE"), Address(RVA = "0x21329E4", Offset = "0x21329E4", VA = "0x21329E4")] private get
      {
        return (APIWeaponLimit_breakRequest) null;
      }
      [Token(Token = "0x600B7FF"), Address(RVA = "0x21329EC", Offset = "0x21329EC", VA = "0x21329EC")] set
      {
      }
    }

    [Token(Token = "0x17002635")]
    public APIWeaponLimit_breakResponse Response
    {
      [Token(Token = "0x600B800"), Address(RVA = "0x21329F4", Offset = "0x21329F4", VA = "0x21329F4")] get
      {
        return (APIWeaponLimit_breakResponse) null;
      }
      [Token(Token = "0x600B801"), Address(RVA = "0x21329FC", Offset = "0x21329FC", VA = "0x21329FC")] private set
      {
      }
    }

    [Token(Token = "0x17002636")]
    public int ResponseCode
    {
      [Token(Token = "0x600B802"), Address(RVA = "0x2132A04", Offset = "0x2132A04", VA = "0x2132A04")] get
      {
        return new int();
      }
      [Token(Token = "0x600B803"), Address(RVA = "0x2132A0C", Offset = "0x2132A0C", VA = "0x2132A0C")] private set
      {
      }
    }

    [Token(Token = "0x17002637")]
    public NetworkManager.OnError onError
    {
      [Token(Token = "0x600B804"), Address(RVA = "0x2132A14", Offset = "0x2132A14", VA = "0x2132A14")] set
      {
      }
      [Token(Token = "0x600B805"), Address(RVA = "0x2132A30", Offset = "0x2132A30", VA = "0x2132A30")] get
      {
        return (NetworkManager.OnError) null;
      }
    }

    [Token(Token = "0x600B806")]
    [Address(RVA = "0x2132A4C", Offset = "0x2132A4C", VA = "0x2132A4C")]
    public APIWeaponLimit_break(string apiPath = "api/v1/weapon/limit_break")
    {
    }

    [Token(Token = "0x600B807")]
    [Address(RVA = "0x2132AE4", Offset = "0x2132AE4", VA = "0x2132AE4")]
    public IEnumerator Connect() => (IEnumerator) null;

    [Token(Token = "0x600B808")]
    [Address(RVA = "0x2132B74", Offset = "0x2132B74", VA = "0x2132B74")]
    private string Serialize() => (string) null;

    [Token(Token = "0x600B809")]
    [Address(RVA = "0x2132B80", Offset = "0x2132B80", VA = "0x2132B80")]
    private void Deserialize(string json)
    {
    }

    [Token(Token = "0x600B80A")]
    [Address(RVA = "0x2132C54", Offset = "0x2132C54", VA = "0x2132C54")]
    private void OnSuccess(string json)
    {
    }
  }
}
