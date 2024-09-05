// Decompiled with JetBrains decompiler
// Type: Network.API.APIExpeditionStageBossPartyEditRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections.Generic;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C3B")]
  [Serializable]
  public class APIExpeditionStageBossPartyEditRequest
  {
    [Token(Token = "0x40078EC")]
    [FieldOffset(Offset = "0x10")]
    public List<RequestPlayerExpeditionStageBossPartyUnit> player_expedition_stage_boss_party_units;

    [Token(Token = "0x600A637")]
    [Address(RVA = "0x190A0D0", Offset = "0x190A0D0", VA = "0x190A0D0")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A638")]
    [Address(RVA = "0x190A118", Offset = "0x190A118", VA = "0x190A118")]
    public APIExpeditionStageBossPartyEditRequest()
    {
    }
  }
}
