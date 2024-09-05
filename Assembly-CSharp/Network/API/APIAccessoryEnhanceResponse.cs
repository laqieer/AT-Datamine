// Decompiled with JetBrains decompiler
// Type: Network.API.APIAccessoryEnhanceResponse
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
  [Token(Token = "0x2001B34")]
  [Serializable]
  public class APIAccessoryEnhanceResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x40074B4")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x40074B5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x40074B6")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x40074B7")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private PlayerGearAccessoryType accessory;
    [Token(Token = "0x40074B8")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private List<PlayerSoulType> player_souls;

    [Token(Token = "0x17001CF8")]
    public NoticeData Notice
    {
      [Token(Token = "0x6009FB1"), Address(RVA = "0x46C1C94", Offset = "0x46C1C94", VA = "0x46C1C94", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17001CF9")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x6009FB2"), Address(RVA = "0x46C1C9C", Offset = "0x46C1C9C", VA = "0x46C1C9C", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x17001CFA")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x6009FB3"), Address(RVA = "0x46C1CA4", Offset = "0x46C1CA4", VA = "0x46C1CA4", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x17001CFB")]
    public PlayerGearAccessoryType Accessory
    {
      [Token(Token = "0x6009FB4"), Address(RVA = "0x46C1CAC", Offset = "0x46C1CAC", VA = "0x46C1CAC")] get
      {
        return (PlayerGearAccessoryType) null;
      }
    }

    [Token(Token = "0x17001CFC")]
    public List<PlayerSoulType> PlayerSouls
    {
      [Token(Token = "0x6009FB5"), Address(RVA = "0x46C1CB4", Offset = "0x46C1CB4", VA = "0x46C1CB4")] get
      {
        return (List<PlayerSoulType>) null;
      }
    }

    [Token(Token = "0x6009FB6")]
    [Address(RVA = "0x46C1CBC", Offset = "0x46C1CBC", VA = "0x46C1CBC")]
    public APIAccessoryEnhanceResponse()
    {
    }
  }
}
