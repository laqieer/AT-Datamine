// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerExpeditionStageType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AAE")]
  [Serializable]
  public class PlayerExpeditionStageType
  {
    [Token(Token = "0x4007253")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string id;
    [Token(Token = "0x4007254")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int stage_id;
    [Token(Token = "0x4007255")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private int boss_level;
    [Token(Token = "0x4007256")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<PlayerExpeditionStageBossPartyUnitType> player_expedition_stage_boss_party_units;

    [Token(Token = "0x17001AA0")]
    public string Id
    {
      [Token(Token = "0x6009A6E"), Address(RVA = "0x48F126C", Offset = "0x48F126C", VA = "0x48F126C")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009A6F"), Address(RVA = "0x48F1274", Offset = "0x48F1274", VA = "0x48F1274")] set
      {
      }
    }

    [Token(Token = "0x17001AA1")]
    public int StageId
    {
      [Token(Token = "0x6009A70"), Address(RVA = "0x48F127C", Offset = "0x48F127C", VA = "0x48F127C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009A71"), Address(RVA = "0x48F1284", Offset = "0x48F1284", VA = "0x48F1284")] set
      {
      }
    }

    [Token(Token = "0x17001AA2")]
    public int BossLevel
    {
      [Token(Token = "0x6009A72"), Address(RVA = "0x48F128C", Offset = "0x48F128C", VA = "0x48F128C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009A73"), Address(RVA = "0x48F1294", Offset = "0x48F1294", VA = "0x48F1294")] set
      {
      }
    }

    [Token(Token = "0x17001AA3")]
    public List<PlayerExpeditionStageBossPartyUnitType> PlayerExpeditionStageBossPartyUnits
    {
      [Token(Token = "0x6009A74"), Address(RVA = "0x48F129C", Offset = "0x48F129C", VA = "0x48F129C")] get
      {
        return (List<PlayerExpeditionStageBossPartyUnitType>) null;
      }
      [Token(Token = "0x6009A75"), Address(RVA = "0x48F12A4", Offset = "0x48F12A4", VA = "0x48F12A4")] set
      {
      }
    }

    [Token(Token = "0x6009A76")]
    [Address(RVA = "0x48F12AC", Offset = "0x48F12AC", VA = "0x48F12AC")]
    public PlayerExpeditionStageType()
    {
    }
  }
}
