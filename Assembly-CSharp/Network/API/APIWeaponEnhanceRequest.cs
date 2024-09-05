// Decompiled with JetBrains decompiler
// Type: Network.API.APIWeaponEnhanceRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001EEF")]
  [Serializable]
  public class APIWeaponEnhanceRequest
  {
    [Token(Token = "0x40084D3")]
    [FieldOffset(Offset = "0x10")]
    public string weapon_id;
    [Token(Token = "0x40084D4")]
    [FieldOffset(Offset = "0x18")]
    public int soul_num;

    [Token(Token = "0x600B7C3")]
    [Address(RVA = "0x2131E94", Offset = "0x2131E94", VA = "0x2131E94")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B7C4")]
    [Address(RVA = "0x2131EDC", Offset = "0x2131EDC", VA = "0x2131EDC")]
    public APIWeaponEnhanceRequest()
    {
    }
  }
}
