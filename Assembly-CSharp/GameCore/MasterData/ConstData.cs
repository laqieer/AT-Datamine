// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ConstData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E8A")]
  [Serializable]
  public sealed class ConstData : IMasterDataEntity
  {
    [Token(Token = "0x4004621")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004622")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int partySlotMax;
    [Token(Token = "0x4004623")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int mainWeaponSlotMax;
    [Token(Token = "0x4004624")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int subWeaponSlotMax;
    [Token(Token = "0x4004625")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int accessoriesSlotMax;
    [Token(Token = "0x4004626")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int mindEquipmentSlotMax;
    [Token(Token = "0x4004627")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int unitTrustSlotMax;
    [Token(Token = "0x4004628")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int itemsetMax;
    [Token(Token = "0x4004629")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int itemsetSlotMax;
    [Token(Token = "0x400462A")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int expeditionPartyMax;
    [Token(Token = "0x400462B")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int expeditionPartyInitial;
    [Token(Token = "0x400462C")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int expeditionPartySlotMax;
    [Token(Token = "0x400462D")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public int expeditionPartySlotInitial;
    [Token(Token = "0x400462E")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    public int expeditionBossPartySlot;
    [Token(Token = "0x400462F")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    public int expeditionStageInitialElement;
    [Token(Token = "0x4004630")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    public int expeditionPartyInitialStyle;
    [Token(Token = "0x4004631")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    public int expeditionSoulSpotInterval;
    [Token(Token = "0x4004632")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    public float expeditionBossFastModeSpeed;
    [Token(Token = "0x4004633")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    public int expeditionBossturnLimit;
    [Token(Token = "0x4004634")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    public int expeditionBossChallengeFreeCountMax;
    [Token(Token = "0x4004635")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    public int expeditionBossChallengeTicketCountMax;
    [Token(Token = "0x4004636")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    public int expeditionBossChallengeCoinCountMax;
    [Token(Token = "0x4004637")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    public int expeditionBossChallengeCoinRequiredAmount;
    [Token(Token = "0x4004638")]
    [FieldOffset(Offset = "0x6C")]
    [SerializeField]
    public int expeditionRapidTicketCountMax;
    [Token(Token = "0x4004639")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    public int expeditionRapidCoinCountMax;
    [Token(Token = "0x400463A")]
    [FieldOffset(Offset = "0x74")]
    [SerializeField]
    public int expeditionRapidCoinHour;
    [Token(Token = "0x400463B")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    public float expeditionPararaCalcParamA;
    [Token(Token = "0x400463C")]
    [FieldOffset(Offset = "0x7C")]
    [SerializeField]
    public float expeditionPararaCalcParamB;
    [Token(Token = "0x400463D")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    public float expeditionPararaCalcParamC;
    [Token(Token = "0x400463E")]
    [FieldOffset(Offset = "0x84")]
    [SerializeField]
    public float expeditionPararaCalcParamD;
    [Token(Token = "0x400463F")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    public float expeditionPararaCalcParamE;
    [Token(Token = "0x4004640")]
    [FieldOffset(Offset = "0x8C")]
    [SerializeField]
    public float expeditionPararaCalcParamF;
    [Token(Token = "0x4004641")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    public float expeditionPararaBoost1;
    [Token(Token = "0x4004642")]
    [FieldOffset(Offset = "0x94")]
    [SerializeField]
    public float expeditionPararaBoost2;
    [Token(Token = "0x4004643")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    public float expeditionPararaBoost3;
    [Token(Token = "0x4004644")]
    [FieldOffset(Offset = "0x9C")]
    [SerializeField]
    public float expeditionPararaBoost4;
    [Token(Token = "0x4004645")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    public float expeditionPararaBoost5;
    [Token(Token = "0x4004646")]
    [FieldOffset(Offset = "0xA4")]
    [SerializeField]
    public float expeditionPararaBoostIndividual1;
    [Token(Token = "0x4004647")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    public float expeditionPararaBoostIndividual2;
    [Token(Token = "0x4004648")]
    [FieldOffset(Offset = "0xAC")]
    [SerializeField]
    public float expeditionPararaBoostIndividual3;
    [Token(Token = "0x4004649")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    public float expeditionPararaBoostIndividual4;
    [Token(Token = "0x400464A")]
    [FieldOffset(Offset = "0xB4")]
    [SerializeField]
    public float expeditionPararaBoostIndividual5;
    [Token(Token = "0x400464B")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    public int expeditionAiType;
    [Token(Token = "0x400464C")]
    [FieldOffset(Offset = "0xBC")]
    [SerializeField]
    public int playerNameLengthLimit;
    [Token(Token = "0x400464D")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    public int playerCommentLengthLimit;
    [Token(Token = "0x400464E")]
    [FieldOffset(Offset = "0xC4")]
    [SerializeField]
    public int playerDeckNameLengthLimit;
    [Token(Token = "0x400464F")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    public int weaponStorageSlotInitial;
    [Token(Token = "0x4004650")]
    [FieldOffset(Offset = "0xCC")]
    [SerializeField]
    public int abilityBoardCustomAParameterNum;
    [Token(Token = "0x4004651")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    public int abilityBoardCustomAMaxLotteryCount;
    [Token(Token = "0x4004652")]
    [FieldOffset(Offset = "0xD4")]
    [SerializeField]
    public int maxFriendPoint;
    [Token(Token = "0x4004653")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    public float modelHeightStand;
    [Token(Token = "0x4004654")]
    [FieldOffset(Offset = "0xDC")]
    [SerializeField]
    public float modelHeightSit;
    [Token(Token = "0x4004655")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    public int trustMax;
    [Token(Token = "0x4004656")]
    [FieldOffset(Offset = "0xE4")]
    [SerializeField]
    public int maxStyleAwakeCount;
    [Token(Token = "0x4004657")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    public int unlockMainStoryPlayerRank;
    [Token(Token = "0x4004658")]
    [FieldOffset(Offset = "0xEC")]
    [SerializeField]
    public int unlockEventQuestPlayerRank;
    [Token(Token = "0x4004659")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    public int unlockGuildPlayerRank;
    [Token(Token = "0x400465A")]
    [FieldOffset(Offset = "0xF4")]
    [SerializeField]
    public int unlockArenaPlayerRank;
    [Token(Token = "0x400465B")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    public int moneyCurrencyId;
    [Token(Token = "0x400465C")]
    [FieldOffset(Offset = "0xFC")]
    [SerializeField]
    public float autoFomationElementNomalRate;
    [Token(Token = "0x400465D")]
    [FieldOffset(Offset = "0x100")]
    [SerializeField]
    public float autoFomationElementBuffRate;
    [Token(Token = "0x400465E")]
    [FieldOffset(Offset = "0x104")]
    [SerializeField]
    public float autoFomationElementDebuffRate;
    [Token(Token = "0x400465F")]
    [FieldOffset(Offset = "0x108")]
    [SerializeField]
    public int home3dBgId;
    [Token(Token = "0x4004660")]
    [FieldOffset(Offset = "0x10C")]
    [SerializeField]
    public float AdRewardLatencyRetrySecond;
    [Token(Token = "0x4004661")]
    [FieldOffset(Offset = "0x110")]
    [SerializeField]
    public int AdRewardLatencyRetryCount;

    [Token(Token = "0x17000D27")]
    public int Key
    {
      [Token(Token = "0x6005882"), Address(RVA = "0x3E49618", Offset = "0x3E49618", VA = "0x3E49618", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005883")]
    [Address(RVA = "0x3E49620", Offset = "0x3E49620", VA = "0x3E49620", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005884")]
    [Address(RVA = "0x3E4AECC", Offset = "0x3E4AECC", VA = "0x3E4AECC", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005885")]
    [Address(RVA = "0x3E4B340", Offset = "0x3E4B340", VA = "0x3E4B340")]
    public bool IsUnlockEventQuestPlayRankTrueNow() => new bool();

    [Token(Token = "0x6005886")]
    [Address(RVA = "0x3E4B414", Offset = "0x3E4B414", VA = "0x3E4B414")]
    public ConstData()
    {
    }
  }
}
