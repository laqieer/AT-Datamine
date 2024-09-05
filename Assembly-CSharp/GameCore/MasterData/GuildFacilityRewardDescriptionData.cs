// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildFacilityRewardDescriptionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FE9")]
  [Serializable]
  public sealed class GuildFacilityRewardDescriptionData : IMasterDataEntity
  {
    [Token(Token = "0x4004F8F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004F90")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int rewardSetId;
    [Token(Token = "0x4004F91")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public GuildFacilityRewardTypeEnum rewardType;
    [Token(Token = "0x4004F92")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int rewardValue;

    [Token(Token = "0x17000DB3")]
    public int Key
    {
      [Token(Token = "0x6005CE8"), Address(RVA = "0x278F510", Offset = "0x278F510", VA = "0x278F510", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005CE9")]
    [Address(RVA = "0x278F518", Offset = "0x278F518", VA = "0x278F518", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005CEA")]
    [Address(RVA = "0x278F6E4", Offset = "0x278F6E4", VA = "0x278F6E4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005CEB")]
    [Address(RVA = "0x278F788", Offset = "0x278F788", VA = "0x278F788")]
    public GuildFacilityRewardDescriptionData()
    {
    }
  }
}
