// Decompiled with JetBrains decompiler
// Type: Network.API.APIUnitCharacterLp_recoveryResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001EB4")]
  [Serializable]
  public class APIUnitCharacterLp_recoveryResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x40083E8")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x40083E9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x40083EA")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x40083EB")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private PlayerUnitCharacterType updated_player_unit_character;
    [Token(Token = "0x40083EC")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private UpdatedPlayerItems updated_player_items;

    [Token(Token = "0x17002598")]
    public NoticeData Notice
    {
      [Token(Token = "0x600B651"), Address(RVA = "0x22EC2DC", Offset = "0x22EC2DC", VA = "0x22EC2DC", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17002599")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600B652"), Address(RVA = "0x22EC2E4", Offset = "0x22EC2E4", VA = "0x22EC2E4", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x1700259A")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600B653"), Address(RVA = "0x22EC2EC", Offset = "0x22EC2EC", VA = "0x22EC2EC", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x1700259B")]
    public PlayerUnitCharacterType UpdatedPlayerUnitCharacter
    {
      [Token(Token = "0x600B654"), Address(RVA = "0x22EC2F4", Offset = "0x22EC2F4", VA = "0x22EC2F4")] get
      {
        return (PlayerUnitCharacterType) null;
      }
    }

    [Token(Token = "0x1700259C")]
    public UpdatedPlayerItems UpdatedPlayerItems
    {
      [Token(Token = "0x600B655"), Address(RVA = "0x22EC2FC", Offset = "0x22EC2FC", VA = "0x22EC2FC")] get
      {
        return (UpdatedPlayerItems) null;
      }
    }

    [Token(Token = "0x600B656")]
    [Address(RVA = "0x22EC304", Offset = "0x22EC304", VA = "0x22EC304")]
    public APIUnitCharacterLp_recoveryResponse()
    {
    }
  }
}
