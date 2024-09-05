// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildLevelRewardData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001018")]
  [Serializable]
  public sealed class GuildLevelRewardData : IMasterDataEntity
  {
    [Token(Token = "0x4005008")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005009")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int level;
    [Token(Token = "0x400500A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int memberMax;
    [Token(Token = "0x400500B")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int subMasterMax;
    [Token(Token = "0x400500C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int investRateID;
    [Token(Token = "0x400500D")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int unlockedElementsSetID;
    [Token(Token = "0x400500E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int attendRewardSetID;
    [Token(Token = "0x400500F")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int roleRewardSetID;
    [Token(Token = "0x4005010")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int repairWeaponSetID;
    [Token(Token = "0x4005011")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int gvgSetID;

    [Token(Token = "0x17000DD2")]
    public int Key
    {
      [Token(Token = "0x6005DBD"), Address(RVA = "0x2796560", Offset = "0x2796560", VA = "0x2796560", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005DBE")]
    [Address(RVA = "0x2796568", Offset = "0x2796568", VA = "0x2796568", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005DBF")]
    [Address(RVA = "0x2796974", Offset = "0x2796974", VA = "0x2796974", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005DC0")]
    [Address(RVA = "0x2796A78", Offset = "0x2796A78", VA = "0x2796A78")]
    public GuildLevelRewardData()
    {
    }
  }
}
