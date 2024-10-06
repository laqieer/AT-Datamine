// Decompiled with JetBrains decompiler
// Type: Network.API.APIPlayerApRecoveryCoinResponse
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
  [Token(Token = "0x2001D80")]
  [Serializable]
  public class APIPlayerApRecoveryCoinResponse : IPostApiResult, ICommonApiResult
  {
    [Token(Token = "0x4007DFB")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private NoticeData notice;
    [Token(Token = "0x4007DFC")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UpdatedPlayerDataSet updated_player_data_set;
    [Token(Token = "0x4007DFD")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerCoinType player_coin;
    [Token(Token = "0x4007DFE")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private PlayerApType player_ap;

    [Token(Token = "0x17002232")]
    public NoticeData Notice
    {
      [Token(Token = "0x600AE1B"), Address(RVA = "0x1A4BFFC", Offset = "0x1A4BFFC", VA = "0x1A4BFFC", Slot = "6")] get
      {
        return (NoticeData) null;
      }
    }

    [Token(Token = "0x17002233")]
    public UpdatedPlayerDataSet UpdatedPlayerDataSet
    {
      [Token(Token = "0x600AE1C"), Address(RVA = "0x1A4C004", Offset = "0x1A4C004", VA = "0x1A4C004", Slot = "4")] get
      {
        return (UpdatedPlayerDataSet) null;
      }
    }

    [Token(Token = "0x17002234")]
    public PlayerCoinType PlayerCoin
    {
      [Token(Token = "0x600AE1D"), Address(RVA = "0x1A4C00C", Offset = "0x1A4C00C", VA = "0x1A4C00C", Slot = "5")] get
      {
        return (PlayerCoinType) null;
      }
    }

    [Token(Token = "0x17002235")]
    public PlayerApType PlayerAp
    {
      [Token(Token = "0x600AE1E"), Address(RVA = "0x1A4C014", Offset = "0x1A4C014", VA = "0x1A4C014")] get
      {
        return (PlayerApType) null;
      }
    }

    [Token(Token = "0x600AE1F")]
    [Address(RVA = "0x1A4C01C", Offset = "0x1A4C01C", VA = "0x1A4C01C")]
    public APIPlayerApRecoveryCoinResponse()
    {
    }
  }
}
