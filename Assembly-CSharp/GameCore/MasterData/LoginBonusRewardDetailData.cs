// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.LoginBonusRewardDetailData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001092")]
  [Serializable]
  public sealed class LoginBonusRewardDetailData : IMasterDataEntity
  {
    [Token(Token = "0x40051D1")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40051D2")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int loginbonusRewardId;
    [Token(Token = "0x40051D3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public RewardTypeEnum rewardType;
    [Token(Token = "0x40051D4")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int rewardId;
    [Token(Token = "0x40051D5")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int rewardQuantity;

    [Token(Token = "0x17000E50")]
    public int Key
    {
      [Token(Token = "0x6006002"), Address(RVA = "0x28D3ADC", Offset = "0x28D3ADC", VA = "0x28D3ADC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006003")]
    [Address(RVA = "0x28D3AE4", Offset = "0x28D3AE4", VA = "0x28D3AE4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006004")]
    [Address(RVA = "0x28D3D10", Offset = "0x28D3D10", VA = "0x28D3D10", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000E51")]
    public string Detail
    {
      [Token(Token = "0x6006005"), Address(RVA = "0x28D3DC4", Offset = "0x28D3DC4", VA = "0x28D3DC4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6006006")]
    [Address(RVA = "0x28D3EA0", Offset = "0x28D3EA0", VA = "0x28D3EA0")]
    public LoginBonusRewardDetailData()
    {
    }
  }
}
