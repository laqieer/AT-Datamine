// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ExpeditionBossRareRewardData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F98")]
  [Serializable]
  public sealed class ExpeditionBossRareRewardData : IMasterDataEntity
  {
    [Token(Token = "0x4004EB9")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004EBA")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int bossRareRewardSetDescriptionID;
    [Token(Token = "0x4004EBB")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public RewardTypeEnum rewardType;
    [Token(Token = "0x4004EBC")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int rewardID;
    [Token(Token = "0x4004EBD")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int amount;
    [Token(Token = "0x4004EBE")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int weight;

    [Token(Token = "0x17000D8A")]
    public int Key
    {
      [Token(Token = "0x6005BA5"), Address(RVA = "0x2785224", Offset = "0x2785224", VA = "0x2785224", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005BA6")]
    [Address(RVA = "0x278522C", Offset = "0x278522C", VA = "0x278522C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005BA7")]
    [Address(RVA = "0x27854B8", Offset = "0x27854B8", VA = "0x27854B8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005BA8")]
    [Address(RVA = "0x278557C", Offset = "0x278557C", VA = "0x278557C")]
    public ExpeditionBossRareRewardData()
    {
    }
  }
}
