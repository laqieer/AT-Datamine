// Decompiled with JetBrains decompiler
// Type: Network.API.APIExpeditionStageBossPartyEditResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C3C")]
  [Serializable]
  public class APIExpeditionStageBossPartyEditResponse
  {
    [Token(Token = "0x40078ED")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<PlayerExpeditionStageBossPartyUnitType> player_expedition_stage_boss_party_units;

    [Token(Token = "0x17001F60")]
    public List<PlayerExpeditionStageBossPartyUnitType> PlayerExpeditionStageBossPartyUnits
    {
      [Token(Token = "0x600A639"), Address(RVA = "0x190A120", Offset = "0x190A120", VA = "0x190A120")] get
      {
        return (List<PlayerExpeditionStageBossPartyUnitType>) null;
      }
    }

    [Token(Token = "0x600A63A")]
    [Address(RVA = "0x190A128", Offset = "0x190A128", VA = "0x190A128")]
    public APIExpeditionStageBossPartyEditResponse()
    {
    }
  }
}
