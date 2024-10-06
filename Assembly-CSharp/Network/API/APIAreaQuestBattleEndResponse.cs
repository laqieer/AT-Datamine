// Decompiled with JetBrains decompiler
// Type: Network.API.APIAreaQuestBattleEndResponse
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
  [Token(Token = "0x2001B70")]
  [Serializable]
  public class APIAreaQuestBattleEndResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x400759E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x400759F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x40075A0")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x40075A1")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private PlayerBattleResult results;
    [Token(Token = "0x40075A2")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private PlayerAreaNodeType player_area_node;

    [Token(Token = "0x17001D75")]
    public NoticeData Notice
    {
      [Token(Token = "0x600A11E"), Address(RVA = "0x46C6D20", Offset = "0x46C6D20", VA = "0x46C6D20", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17001D76")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600A11F"), Address(RVA = "0x46C6D28", Offset = "0x46C6D28", VA = "0x46C6D28", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x17001D77")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600A120"), Address(RVA = "0x46C6D30", Offset = "0x46C6D30", VA = "0x46C6D30", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x17001D78")]
    public PlayerBattleResult Results
    {
      [Token(Token = "0x600A121"), Address(RVA = "0x46C6D38", Offset = "0x46C6D38", VA = "0x46C6D38")] get
      {
        return (PlayerBattleResult) null;
      }
    }

    [Token(Token = "0x17001D79")]
    public PlayerAreaNodeType PlayerAreaNode
    {
      [Token(Token = "0x600A122"), Address(RVA = "0x46C6D40", Offset = "0x46C6D40", VA = "0x46C6D40")] get
      {
        return (PlayerAreaNodeType) null;
      }
    }

    [Token(Token = "0x600A123")]
    [Address(RVA = "0x46C6D48", Offset = "0x46C6D48", VA = "0x46C6D48")]
    public APIAreaQuestBattleEndResponse()
    {
    }
  }
}
