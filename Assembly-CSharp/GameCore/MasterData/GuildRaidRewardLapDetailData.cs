// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildRaidRewardLapDetailData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FF8")]
  [Serializable]
  public sealed class GuildRaidRewardLapDetailData : IMasterDataEntity
  {
    [Token(Token = "0x4004FBD")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004FBE")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int lapRewardID;
    [Token(Token = "0x4004FBF")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int rewardType;
    [Token(Token = "0x4004FC0")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int rewardID;
    [Token(Token = "0x4004FC1")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int amount;

    [Token(Token = "0x17000DBD")]
    public int Key
    {
      [Token(Token = "0x6005D2F"), Address(RVA = "0x27917BC", Offset = "0x27917BC", VA = "0x27917BC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005D30")]
    [Address(RVA = "0x27917C4", Offset = "0x27917C4", VA = "0x27917C4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005D31")]
    [Address(RVA = "0x27919F0", Offset = "0x27919F0", VA = "0x27919F0", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005D32")]
    [Address(RVA = "0x2791AA4", Offset = "0x2791AA4", VA = "0x2791AA4")]
    public GuildRaidRewardLapDetailData()
    {
    }
  }
}
