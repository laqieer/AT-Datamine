// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitTrustSkillEnhanceRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001EDB")]
  [Serializable]
  public class APIUnitTrustSkillEnhanceRequest
  {
    [Token(Token = "0x4008485")]
    [FieldOffset(Offset = "0x10")]
    public string player_unit_trust_id;
    [Token(Token = "0x4008486")]
    [FieldOffset(Offset = "0x18")]
    public int try_count;

    [Token(Token = "0x600B746")]
    [Address(RVA = "0x21303A0", Offset = "0x21303A0", VA = "0x21303A0")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B747")]
    [Address(RVA = "0x21303E8", Offset = "0x21303E8", VA = "0x21303E8")]
    public APIUnitTrustSkillEnhanceRequest()
    {
    }
  }
}
