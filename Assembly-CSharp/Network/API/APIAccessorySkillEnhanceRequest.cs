// Decompiled with JetBrains decompiler
// Type: Network.API.APIAccessorySkillEnhanceRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B4B")]
  [Serializable]
  public class APIAccessorySkillEnhanceRequest
  {
    [Token(Token = "0x400750F")]
    [FieldOffset(Offset = "0x10")]
    public string player_accessory_id;
    [Token(Token = "0x4007510")]
    [FieldOffset(Offset = "0x18")]
    public int try_count;

    [Token(Token = "0x600A044")]
    [Address(RVA = "0x46C3C94", Offset = "0x46C3C94", VA = "0x46C3C94")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A045")]
    [Address(RVA = "0x46C3CDC", Offset = "0x46C3CDC", VA = "0x46C3CDC")]
    public APIAccessorySkillEnhanceRequest()
    {
    }
  }
}
