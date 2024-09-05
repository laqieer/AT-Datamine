// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ExpeditionBossDescriptionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F90")]
  [Serializable]
  public sealed class ExpeditionBossDescriptionData : IMasterDataEntity
  {
    [Token(Token = "0x4004E90")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004E91")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4004E92")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int boss;
    [Token(Token = "0x4004E93")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int level;
    [Token(Token = "0x4004E94")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int placement;
    [Token(Token = "0x4004E95")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int enemy;
    [Token(Token = "0x4004E96")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public DateTime releaseTime;
    [Token(Token = "0x4004E97")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int mapOffsetX;
    [Token(Token = "0x4004E98")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int mapOffsetY;
    [Token(Token = "0x4004E99")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public int mapWidth;
    [Token(Token = "0x4004E9A")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    public int mapHeight;
    [Token(Token = "0x4004E9B")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public int recommendCombatPower;
    [Token(Token = "0x4004E9C")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    public int pararaStageLimitLife;
    [Token(Token = "0x4004E9D")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    public int pararaStageLimitStrength;
    [Token(Token = "0x4004E9E")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    public int pararaStageLimitIntelligence;
    [Token(Token = "0x4004E9F")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    public int pararaStageLimitVitality;
    [Token(Token = "0x4004EA0")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    public int pararaStageLimitMind;
    [Token(Token = "0x4004EA1")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    public int pararaStageLimitAgility;
    [Token(Token = "0x4004EA2")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    public int pararaStageLimitDexterity;
    [Token(Token = "0x4004EA3")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    public int pararaStageLimitLucky;

    [Token(Token = "0x17000D86")]
    public int Key
    {
      [Token(Token = "0x6005B73"), Address(RVA = "0x27823B0", Offset = "0x27823B0", VA = "0x27823B0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005B74")]
    [Address(RVA = "0x27823B8", Offset = "0x27823B8", VA = "0x27823B8", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005B75")]
    [Address(RVA = "0x2782B84", Offset = "0x2782B84", VA = "0x2782B84", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005B76")]
    [Address(RVA = "0x2782D64", Offset = "0x2782D64", VA = "0x2782D64")]
    public IReadOnlyCollection<ExpeditionBossOwnPlacementDescriptionData> GetPlacement()
    {
      return (IReadOnlyCollection<ExpeditionBossOwnPlacementDescriptionData>) null;
    }

    [Token(Token = "0x6005B77")]
    [Address(RVA = "0x2782E60", Offset = "0x2782E60", VA = "0x2782E60")]
    public IReadOnlyCollection<ExpeditionBossEnemyDescriptionData> GetEnemy()
    {
      return (IReadOnlyCollection<ExpeditionBossEnemyDescriptionData>) null;
    }

    [Token(Token = "0x6005B78")]
    [Address(RVA = "0x2782F5C", Offset = "0x2782F5C", VA = "0x2782F5C")]
    public IReadOnlyCollection<ExpeditionBossRareRewardSetData> GetRareRewardSet()
    {
      return (IReadOnlyCollection<ExpeditionBossRareRewardSetData>) null;
    }

    [Token(Token = "0x6005B79")]
    [Address(RVA = "0x2783454", Offset = "0x2783454", VA = "0x2783454")]
    public IReadOnlyCollection<ExpeditionBossRareRewardData> GetRareReward()
    {
      return (IReadOnlyCollection<ExpeditionBossRareRewardData>) null;
    }

    [Token(Token = "0x6005B7A")]
    [Address(RVA = "0x2783C48", Offset = "0x2783C48", VA = "0x2783C48")]
    public ExpeditionBossDescriptionData()
    {
    }
  }
}
