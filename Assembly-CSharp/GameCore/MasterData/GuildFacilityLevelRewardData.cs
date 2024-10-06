// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildFacilityLevelRewardData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FE0")]
  [Serializable]
  public sealed class GuildFacilityLevelRewardData : IMasterDataEntity
  {
    [Token(Token = "0x4004F7E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004F7F")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int facilityId;
    [Token(Token = "0x4004F80")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int level;
    [Token(Token = "0x4004F81")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int rewardId;

    [Token(Token = "0x17000DB0")]
    public int Key
    {
      [Token(Token = "0x6005CC7"), Address(RVA = "0x278E5C0", Offset = "0x278E5C0", VA = "0x278E5C0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005CC8")]
    [Address(RVA = "0x278E5C8", Offset = "0x278E5C8", VA = "0x278E5C8", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005CC9")]
    [Address(RVA = "0x278E794", Offset = "0x278E794", VA = "0x278E794", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005CCA")]
    [Address(RVA = "0x278E838", Offset = "0x278E838", VA = "0x278E838")]
    public GuildFacilityLevelRewardData()
    {
    }
  }
}
