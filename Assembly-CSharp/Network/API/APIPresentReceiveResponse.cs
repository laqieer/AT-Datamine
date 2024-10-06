// Decompiled with JetBrains decompiler
// Type: Network.API.APIPresentReceiveResponse
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
  [Token(Token = "0x2001DC8")]
  [Serializable]
  public class APIPresentReceiveResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x4007F3A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4007F3B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x4007F3C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x4007F3D")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<Reward> received_items;
    [Token(Token = "0x4007F3E")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<Reward> expired_items;
    [Token(Token = "0x4007F3F")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private List<Reward> possession_limit_items;
    [Token(Token = "0x4007F40")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private List<PlayerPresentType> presents;
    [Token(Token = "0x4007F41")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private int total_presents_number;
    [Token(Token = "0x4007F42")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private UpdatedPlayerItems updated_player_items;

    [Token(Token = "0x170022FE")]
    public NoticeData Notice
    {
      [Token(Token = "0x600B007"), Address(RVA = "0x1A52244", Offset = "0x1A52244", VA = "0x1A52244", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x170022FF")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600B008"), Address(RVA = "0x1A5224C", Offset = "0x1A5224C", VA = "0x1A5224C", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x17002300")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600B009"), Address(RVA = "0x1A52254", Offset = "0x1A52254", VA = "0x1A52254", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x17002301")]
    public List<Reward> ReceivedItems
    {
      [Token(Token = "0x600B00A"), Address(RVA = "0x1A5225C", Offset = "0x1A5225C", VA = "0x1A5225C")] get
      {
        return (List<Reward>) null;
      }
    }

    [Token(Token = "0x17002302")]
    public List<Reward> ExpiredItems
    {
      [Token(Token = "0x600B00B"), Address(RVA = "0x1A52264", Offset = "0x1A52264", VA = "0x1A52264")] get
      {
        return (List<Reward>) null;
      }
    }

    [Token(Token = "0x17002303")]
    public List<Reward> PossessionLimitItems
    {
      [Token(Token = "0x600B00C"), Address(RVA = "0x1A5226C", Offset = "0x1A5226C", VA = "0x1A5226C")] get
      {
        return (List<Reward>) null;
      }
    }

    [Token(Token = "0x17002304")]
    public List<PlayerPresentType> Presents
    {
      [Token(Token = "0x600B00D"), Address(RVA = "0x1A52274", Offset = "0x1A52274", VA = "0x1A52274")] get
      {
        return (List<PlayerPresentType>) null;
      }
    }

    [Token(Token = "0x17002305")]
    public int TotalPresentsNumber
    {
      [Token(Token = "0x600B00E"), Address(RVA = "0x1A5227C", Offset = "0x1A5227C", VA = "0x1A5227C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002306")]
    public UpdatedPlayerItems UpdatedPlayerItems
    {
      [Token(Token = "0x600B00F"), Address(RVA = "0x1A52284", Offset = "0x1A52284", VA = "0x1A52284")] get
      {
        return (UpdatedPlayerItems) null;
      }
    }

    [Token(Token = "0x600B010")]
    [Address(RVA = "0x1A5228C", Offset = "0x1A5228C", VA = "0x1A5228C")]
    public APIPresentReceiveResponse()
    {
    }
  }
}
