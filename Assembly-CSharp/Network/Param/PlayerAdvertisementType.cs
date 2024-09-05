// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerAdvertisementType
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
  [Token(Token = "0x2001A7F")]
  [Serializable]
  public class PlayerAdvertisementType
  {
    [Token(Token = "0x4007199")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int master_id;
    [Token(Token = "0x400719A")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int target_id;
    [Token(Token = "0x400719B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int limit;
    [Token(Token = "0x400719C")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private int rotation_type_id;
    [Token(Token = "0x400719D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string campaign_start_at;
    [Token(Token = "0x400719E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private string campaign_end_at;
    [Token(Token = "0x400719F")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private int total_reward_received_count;
    [Token(Token = "0x40071A0")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private List<PlayerAdvertisementHistoryType> reward_possible_advertisements;

    [Token(Token = "0x170019DD")]
    public int MasterId
    {
      [Token(Token = "0x60098C2"), Address(RVA = "0x48F0404", Offset = "0x48F0404", VA = "0x48F0404")] get
      {
        return new int();
      }
      [Token(Token = "0x60098C3"), Address(RVA = "0x48F040C", Offset = "0x48F040C", VA = "0x48F040C")] set
      {
      }
    }

    [Token(Token = "0x170019DE")]
    public int TargetId
    {
      [Token(Token = "0x60098C4"), Address(RVA = "0x48F0414", Offset = "0x48F0414", VA = "0x48F0414")] get
      {
        return new int();
      }
      [Token(Token = "0x60098C5"), Address(RVA = "0x48F041C", Offset = "0x48F041C", VA = "0x48F041C")] set
      {
      }
    }

    [Token(Token = "0x170019DF")]
    public int Limit
    {
      [Token(Token = "0x60098C6"), Address(RVA = "0x48F0424", Offset = "0x48F0424", VA = "0x48F0424")] get
      {
        return new int();
      }
      [Token(Token = "0x60098C7"), Address(RVA = "0x48F042C", Offset = "0x48F042C", VA = "0x48F042C")] set
      {
      }
    }

    [Token(Token = "0x170019E0")]
    public int RotationTypeId
    {
      [Token(Token = "0x60098C8"), Address(RVA = "0x48F0434", Offset = "0x48F0434", VA = "0x48F0434")] get
      {
        return new int();
      }
      [Token(Token = "0x60098C9"), Address(RVA = "0x48F043C", Offset = "0x48F043C", VA = "0x48F043C")] set
      {
      }
    }

    [Token(Token = "0x170019E1")]
    public string CampaignStartAt
    {
      [Token(Token = "0x60098CA"), Address(RVA = "0x48F0444", Offset = "0x48F0444", VA = "0x48F0444")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60098CB"), Address(RVA = "0x48F044C", Offset = "0x48F044C", VA = "0x48F044C")] set
      {
      }
    }

    [Token(Token = "0x170019E2")]
    public string CampaignEndAt
    {
      [Token(Token = "0x60098CC"), Address(RVA = "0x48F0454", Offset = "0x48F0454", VA = "0x48F0454")] get
      {
        return (string) null;
      }
      [Token(Token = "0x60098CD"), Address(RVA = "0x48F045C", Offset = "0x48F045C", VA = "0x48F045C")] set
      {
      }
    }

    [Token(Token = "0x170019E3")]
    public int TotalRewardReceivedCount
    {
      [Token(Token = "0x60098CE"), Address(RVA = "0x48F0464", Offset = "0x48F0464", VA = "0x48F0464")] get
      {
        return new int();
      }
      [Token(Token = "0x60098CF"), Address(RVA = "0x48F046C", Offset = "0x48F046C", VA = "0x48F046C")] set
      {
      }
    }

    [Token(Token = "0x170019E4")]
    public List<PlayerAdvertisementHistoryType> RewardPossibleAdvertisements
    {
      [Token(Token = "0x60098D0"), Address(RVA = "0x48F0474", Offset = "0x48F0474", VA = "0x48F0474")] get
      {
        return (List<PlayerAdvertisementHistoryType>) null;
      }
      [Token(Token = "0x60098D1"), Address(RVA = "0x48F047C", Offset = "0x48F047C", VA = "0x48F047C")] set
      {
      }
    }

    [Token(Token = "0x60098D2")]
    [Address(RVA = "0x48F0484", Offset = "0x48F0484", VA = "0x48F0484")]
    public PlayerAdvertisementType()
    {
    }
  }
}
