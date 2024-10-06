// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildRoleRewardRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D1B")]
  [Serializable]
  public class APIGuildRoleRewardRequest
  {
    [Token(Token = "0x4007C58")]
    [FieldOffset(Offset = "0x10")]
    public string guild_id;

    [Token(Token = "0x600AB98")]
    [Address(RVA = "0x1A43898", Offset = "0x1A43898", VA = "0x1A43898")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600AB99")]
    [Address(RVA = "0x1A438E0", Offset = "0x1A438E0", VA = "0x1A438E0")]
    public APIGuildRoleRewardRequest()
    {
    }
  }
}
