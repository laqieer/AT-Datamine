// Decompiled with JetBrains decompiler
// Type: Network.API.APICustomSkillEnhanceRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001BE7")]
  [Serializable]
  public class APICustomSkillEnhanceRequest
  {
    [Token(Token = "0x400777C")]
    [FieldOffset(Offset = "0x10")]
    public string player_custom_skill_id;
    [Token(Token = "0x400777D")]
    [FieldOffset(Offset = "0x18")]
    public int try_count;

    [Token(Token = "0x600A403")]
    [Address(RVA = "0x46D0E50", Offset = "0x46D0E50", VA = "0x46D0E50")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A404")]
    [Address(RVA = "0x46D0E98", Offset = "0x46D0E98", VA = "0x46D0E98")]
    public APICustomSkillEnhanceRequest()
    {
    }
  }
}
