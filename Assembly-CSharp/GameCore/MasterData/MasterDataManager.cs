// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.MasterDataManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.DesignPattern;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000D3B")]
  internal class MasterDataManager : SingletonMonoBehaviour<MasterDataManager>
  {
    [Token(Token = "0x4003B3C")]
    [FieldOffset(Offset = "0x0")]
    public static string AdvArithmeticTypePath;
    [Token(Token = "0x4003B3D")]
    [FieldOffset(Offset = "0x20")]
    public AdvArithmeticTypeMaster AdvArithmeticTypeData;
    [Token(Token = "0x4003B3E")]
    [FieldOffset(Offset = "0x8")]
    public static string AdvChoicesDefinePath;
    [Token(Token = "0x4003B3F")]
    [FieldOffset(Offset = "0x28")]
    public AdvChoicesDefineMaster AdvChoicesDefineData;
    [Token(Token = "0x4003B40")]
    [FieldOffset(Offset = "0x10")]
    public static string AdvComparisonTypePath;
    [Token(Token = "0x4003B41")]
    [FieldOffset(Offset = "0x30")]
    public AdvComparisonTypeMaster AdvComparisonTypeData;
    [Token(Token = "0x4003B42")]
    [FieldOffset(Offset = "0x18")]
    public static string AdvDemoInfoPath;
    [Token(Token = "0x4003B43")]
    [FieldOffset(Offset = "0x38")]
    public AdvDemoInfoMaster AdvDemoInfoData;
    [Token(Token = "0x4003B44")]
    [FieldOffset(Offset = "0x20")]
    public static string AdvExpandedLockComparisonTermPath;
    [Token(Token = "0x4003B45")]
    [FieldOffset(Offset = "0x40")]
    public AdvExpandedLockComparisonTermMaster AdvExpandedLockComparisonTermData;
    [Token(Token = "0x4003B46")]
    [FieldOffset(Offset = "0x28")]
    public static string AdvExpandedLockPath;
    [Token(Token = "0x4003B47")]
    [FieldOffset(Offset = "0x48")]
    public AdvExpandedLockMaster AdvExpandedLockData;
    [Token(Token = "0x4003B48")]
    [FieldOffset(Offset = "0x30")]
    public static string AdvExpandedLockVariablePath;
    [Token(Token = "0x4003B49")]
    [FieldOffset(Offset = "0x50")]
    public AdvExpandedLockVariableMaster AdvExpandedLockVariableData;
    [Token(Token = "0x4003B4A")]
    [FieldOffset(Offset = "0x38")]
    public static string AdvLockOnePath;
    [Token(Token = "0x4003B4B")]
    [FieldOffset(Offset = "0x58")]
    public AdvLockOneMaster AdvLockOneData;
    [Token(Token = "0x4003B4C")]
    [FieldOffset(Offset = "0x40")]
    public static string AdvLockPath;
    [Token(Token = "0x4003B4D")]
    [FieldOffset(Offset = "0x60")]
    public AdvLockMaster AdvLockData;
    [Token(Token = "0x4003B4E")]
    [FieldOffset(Offset = "0x48")]
    public static string AdvOptionOnePath;
    [Token(Token = "0x4003B4F")]
    [FieldOffset(Offset = "0x68")]
    public AdvOptionOneMaster AdvOptionOneData;
    [Token(Token = "0x4003B50")]
    [FieldOffset(Offset = "0x50")]
    public static string AdvOptionPath;
    [Token(Token = "0x4003B51")]
    [FieldOffset(Offset = "0x70")]
    public AdvOptionMaster AdvOptionData;
    [Token(Token = "0x4003B52")]
    [FieldOffset(Offset = "0x58")]
    public static string AdvProcessOnePath;
    [Token(Token = "0x4003B53")]
    [FieldOffset(Offset = "0x78")]
    public AdvProcessOneMaster AdvProcessOneData;
    [Token(Token = "0x4003B54")]
    [FieldOffset(Offset = "0x60")]
    public static string AdvVariablesPath;
    [Token(Token = "0x4003B55")]
    [FieldOffset(Offset = "0x80")]
    public AdvVariablesMaster AdvVariablesData;
    [Token(Token = "0x4003B56")]
    [FieldOffset(Offset = "0x68")]
    public static string AdvVariableTypePath;
    [Token(Token = "0x4003B57")]
    [FieldOffset(Offset = "0x88")]
    public AdvVariableTypeMaster AdvVariableTypeData;
    [Token(Token = "0x4003B58")]
    [FieldOffset(Offset = "0x70")]
    public static string StoryAdvChoicesPath;
    [Token(Token = "0x4003B59")]
    [FieldOffset(Offset = "0x90")]
    public StoryAdvChoicesMaster StoryAdvChoicesData;
    [Token(Token = "0x4003B5A")]
    [FieldOffset(Offset = "0x78")]
    public static string StoryAdvInfoPath;
    [Token(Token = "0x4003B5B")]
    [FieldOffset(Offset = "0x98")]
    public StoryAdvInfoMaster StoryAdvInfoData;
    [Token(Token = "0x4003B5C")]
    [FieldOffset(Offset = "0x80")]
    public static string StoryAdvTypePath;
    [Token(Token = "0x4003B5D")]
    [FieldOffset(Offset = "0xA0")]
    public StoryAdvTypeMaster StoryAdvTypeData;
    [Token(Token = "0x4003B5E")]
    [FieldOffset(Offset = "0x88")]
    public static string AIRolePath;
    [Token(Token = "0x4003B5F")]
    [FieldOffset(Offset = "0xA8")]
    public AIRoleMaster AIRoleData;
    [Token(Token = "0x4003B60")]
    [FieldOffset(Offset = "0x90")]
    public static string AITypePath;
    [Token(Token = "0x4003B61")]
    [FieldOffset(Offset = "0xB0")]
    public AITypeMaster AITypeData;
    [Token(Token = "0x4003B62")]
    [FieldOffset(Offset = "0x98")]
    public static string MoveTypeLandScorePath;
    [Token(Token = "0x4003B63")]
    [FieldOffset(Offset = "0xB8")]
    public MoveTypeLandScoreMaster MoveTypeLandScoreData;
    [Token(Token = "0x4003B64")]
    [FieldOffset(Offset = "0xA0")]
    public static string ArenaBattlePlacementPath;
    [Token(Token = "0x4003B65")]
    [FieldOffset(Offset = "0xC0")]
    public ArenaBattlePlacementMaster ArenaBattlePlacementData;
    [Token(Token = "0x4003B66")]
    [FieldOffset(Offset = "0xA8")]
    public static string ArenaBattlePath;
    [Token(Token = "0x4003B67")]
    [FieldOffset(Offset = "0xC8")]
    public ArenaBattleMaster ArenaBattleData;
    [Token(Token = "0x4003B68")]
    [FieldOffset(Offset = "0xB0")]
    public static string ArenaFacilityPlacementPath;
    [Token(Token = "0x4003B69")]
    [FieldOffset(Offset = "0xD0")]
    public ArenaFacilityPlacementMaster ArenaFacilityPlacementData;
    [Token(Token = "0x4003B6A")]
    [FieldOffset(Offset = "0xB8")]
    public static string ArenaNpcDeckGroupPath;
    [Token(Token = "0x4003B6B")]
    [FieldOffset(Offset = "0xD8")]
    public ArenaNpcDeckGroupMaster ArenaNpcDeckGroupData;
    [Token(Token = "0x4003B6C")]
    [FieldOffset(Offset = "0xC0")]
    public static string ArenaNpcNameGroupPath;
    [Token(Token = "0x4003B6D")]
    [FieldOffset(Offset = "0xE0")]
    public ArenaNpcNameGroupMaster ArenaNpcNameGroupData;
    [Token(Token = "0x4003B6E")]
    [FieldOffset(Offset = "0xC8")]
    public static string ArenaNpcPath;
    [Token(Token = "0x4003B6F")]
    [FieldOffset(Offset = "0xE8")]
    public ArenaNpcMaster ArenaNpcData;
    [Token(Token = "0x4003B70")]
    [FieldOffset(Offset = "0xD0")]
    public static string ArenaConstPath;
    [Token(Token = "0x4003B71")]
    [FieldOffset(Offset = "0xF0")]
    public ArenaConstMaster ArenaConstData;
    [Token(Token = "0x4003B72")]
    [FieldOffset(Offset = "0xD8")]
    public static string ArenaGroupPath;
    [Token(Token = "0x4003B73")]
    [FieldOffset(Offset = "0xF8")]
    public ArenaGroupMaster ArenaGroupData;
    [Token(Token = "0x4003B74")]
    [FieldOffset(Offset = "0xE0")]
    public static string ArenaDailyRewardGroupPath;
    [Token(Token = "0x4003B75")]
    [FieldOffset(Offset = "0x100")]
    public ArenaDailyRewardGroupMaster ArenaDailyRewardGroupData;
    [Token(Token = "0x4003B76")]
    [FieldOffset(Offset = "0xE8")]
    public static string ArenaDailyRewardSetPath;
    [Token(Token = "0x4003B77")]
    [FieldOffset(Offset = "0x108")]
    public ArenaDailyRewardSetMaster ArenaDailyRewardSetData;
    [Token(Token = "0x4003B78")]
    [FieldOffset(Offset = "0xF0")]
    public static string ArenaDailyRewardPath;
    [Token(Token = "0x4003B79")]
    [FieldOffset(Offset = "0x110")]
    public ArenaDailyRewardMaster ArenaDailyRewardData;
    [Token(Token = "0x4003B7A")]
    [FieldOffset(Offset = "0xF8")]
    public static string ArenaDailyRewardTermPath;
    [Token(Token = "0x4003B7B")]
    [FieldOffset(Offset = "0x118")]
    public ArenaDailyRewardTermMaster ArenaDailyRewardTermData;
    [Token(Token = "0x4003B7C")]
    [FieldOffset(Offset = "0x100")]
    public static string ArenaWeeklyRewardGroupPath;
    [Token(Token = "0x4003B7D")]
    [FieldOffset(Offset = "0x120")]
    public ArenaWeeklyRewardGroupMaster ArenaWeeklyRewardGroupData;
    [Token(Token = "0x4003B7E")]
    [FieldOffset(Offset = "0x108")]
    public static string ArenaWeeklyRewardSetPath;
    [Token(Token = "0x4003B7F")]
    [FieldOffset(Offset = "0x128")]
    public ArenaWeeklyRewardSetMaster ArenaWeeklyRewardSetData;
    [Token(Token = "0x4003B80")]
    [FieldOffset(Offset = "0x110")]
    public static string ArenaWeeklyRewardPath;
    [Token(Token = "0x4003B81")]
    [FieldOffset(Offset = "0x130")]
    public ArenaWeeklyRewardMaster ArenaWeeklyRewardData;
    [Token(Token = "0x4003B82")]
    [FieldOffset(Offset = "0x118")]
    public static string ArenaWeeklyRewardTermPath;
    [Token(Token = "0x4003B83")]
    [FieldOffset(Offset = "0x138")]
    public ArenaWeeklyRewardTermMaster ArenaWeeklyRewardTermData;
    [Token(Token = "0x4003B84")]
    [FieldOffset(Offset = "0x120")]
    public static string BattleAdvPath;
    [Token(Token = "0x4003B85")]
    [FieldOffset(Offset = "0x140")]
    public BattleAdvMaster BattleAdvData;
    [Token(Token = "0x4003B86")]
    [FieldOffset(Offset = "0x128")]
    public static string BattleAdvTriggerPath;
    [Token(Token = "0x4003B87")]
    [FieldOffset(Offset = "0x148")]
    public BattleAdvTriggerMaster BattleAdvTriggerData;
    [Token(Token = "0x4003B88")]
    [FieldOffset(Offset = "0x130")]
    public static string BarrierPath;
    [Token(Token = "0x4003B89")]
    [FieldOffset(Offset = "0x150")]
    public BarrierMaster BarrierData;
    [Token(Token = "0x4003B8A")]
    [FieldOffset(Offset = "0x138")]
    public static string BattleBadStatusDetailPath;
    [Token(Token = "0x4003B8B")]
    [FieldOffset(Offset = "0x158")]
    public BattleBadStatusDetailMaster BattleBadStatusDetailData;
    [Token(Token = "0x4003B8C")]
    [FieldOffset(Offset = "0x140")]
    public static string BattleBadStatusGroupPath;
    [Token(Token = "0x4003B8D")]
    [FieldOffset(Offset = "0x160")]
    public BattleBadStatusGroupMaster BattleBadStatusGroupData;
    [Token(Token = "0x4003B8E")]
    [FieldOffset(Offset = "0x148")]
    public static string BattleBadStatusPath;
    [Token(Token = "0x4003B8F")]
    [FieldOffset(Offset = "0x168")]
    public BattleBadStatusMaster BattleBadStatusData;
    [Token(Token = "0x4003B90")]
    [FieldOffset(Offset = "0x150")]
    public static string BattleClearConditionNamePath;
    [Token(Token = "0x4003B91")]
    [FieldOffset(Offset = "0x170")]
    public BattleClearConditionNameMaster BattleClearConditionNameData;
    [Token(Token = "0x4003B92")]
    [FieldOffset(Offset = "0x158")]
    public static string BattleClearConditionPath;
    [Token(Token = "0x4003B93")]
    [FieldOffset(Offset = "0x178")]
    public BattleClearConditionMaster BattleClearConditionData;
    [Token(Token = "0x4003B94")]
    [FieldOffset(Offset = "0x160")]
    public static string BattleDistanceEffectRatioPath;
    [Token(Token = "0x4003B95")]
    [FieldOffset(Offset = "0x180")]
    public BattleDistanceEffectRatioMaster BattleDistanceEffectRatioData;
    [Token(Token = "0x4003B96")]
    [FieldOffset(Offset = "0x168")]
    public static string BattleDistanceInvEffectRatioPath;
    [Token(Token = "0x4003B97")]
    [FieldOffset(Offset = "0x188")]
    public BattleDistanceInvEffectRatioMaster BattleDistanceInvEffectRatioData;
    [Token(Token = "0x4003B98")]
    [FieldOffset(Offset = "0x170")]
    public static string BattleEffectTypeDetailPath;
    [Token(Token = "0x4003B99")]
    [FieldOffset(Offset = "0x190")]
    public BattleEffectTypeDetailMaster BattleEffectTypeDetailData;
    [Token(Token = "0x4003B9A")]
    [FieldOffset(Offset = "0x178")]
    public static string BattleElementChainPath;
    [Token(Token = "0x4003B9B")]
    [FieldOffset(Offset = "0x198")]
    public BattleElementChainMaster BattleElementChainData;
    [Token(Token = "0x4003B9C")]
    [FieldOffset(Offset = "0x180")]
    public static string BattleFailedConditionNamePath;
    [Token(Token = "0x4003B9D")]
    [FieldOffset(Offset = "0x1A0")]
    public BattleFailedConditionNameMaster BattleFailedConditionNameData;
    [Token(Token = "0x4003B9E")]
    [FieldOffset(Offset = "0x188")]
    public static string BattleFailedConditionPath;
    [Token(Token = "0x4003B9F")]
    [FieldOffset(Offset = "0x1A8")]
    public BattleFailedConditionMaster BattleFailedConditionData;
    [Token(Token = "0x4003BA0")]
    [FieldOffset(Offset = "0x190")]
    public static string BattleHpInvRatioEffectRatioPath;
    [Token(Token = "0x4003BA1")]
    [FieldOffset(Offset = "0x1B0")]
    public BattleHpInvRatioEffectRatioMaster BattleHpInvRatioEffectRatioData;
    [Token(Token = "0x4003BA2")]
    [FieldOffset(Offset = "0x198")]
    public static string BattleHpRatioEffectRatioPath;
    [Token(Token = "0x4003BA3")]
    [FieldOffset(Offset = "0x1B8")]
    public BattleHpRatioEffectRatioMaster BattleHpRatioEffectRatioData;
    [Token(Token = "0x4003BA4")]
    [FieldOffset(Offset = "0x1A0")]
    public static string BattleLandCorrectPath;
    [Token(Token = "0x4003BA5")]
    [FieldOffset(Offset = "0x1C0")]
    public BattleLandCorrectMaster BattleLandCorrectData;
    [Token(Token = "0x4003BA6")]
    [FieldOffset(Offset = "0x1A8")]
    public static string BattleLogTextFormatPath;
    [Token(Token = "0x4003BA7")]
    [FieldOffset(Offset = "0x1C8")]
    public BattleLogTextFormatMaster BattleLogTextFormatData;
    [Token(Token = "0x4003BA8")]
    [FieldOffset(Offset = "0x1B0")]
    public static string BattleMoveCountEffectRatioPath;
    [Token(Token = "0x4003BA9")]
    [FieldOffset(Offset = "0x1D0")]
    public BattleMoveCountEffectRatioMaster BattleMoveCountEffectRatioData;
    [Token(Token = "0x4003BAA")]
    [FieldOffset(Offset = "0x1B8")]
    public static string BattleMoveCountInvEffectRatioPath;
    [Token(Token = "0x4003BAB")]
    [FieldOffset(Offset = "0x1D8")]
    public BattleMoveCountInvEffectRatioMaster BattleMoveCountInvEffectRatioData;
    [Token(Token = "0x4003BAC")]
    [FieldOffset(Offset = "0x1C0")]
    public static string BattlePowerConstantPath;
    [Token(Token = "0x4003BAD")]
    [FieldOffset(Offset = "0x1E0")]
    public BattlePowerConstantMaster BattlePowerConstantData;
    [Token(Token = "0x4003BAE")]
    [FieldOffset(Offset = "0x1C8")]
    public static string BattleSlayEffectRatioPath;
    [Token(Token = "0x4003BAF")]
    [FieldOffset(Offset = "0x1E8")]
    public BattleSlayEffectRatioMaster BattleSlayEffectRatioData;
    [Token(Token = "0x4003BB0")]
    [FieldOffset(Offset = "0x1D0")]
    public static string BattleSortieConditionPath;
    [Token(Token = "0x4003BB1")]
    [FieldOffset(Offset = "0x1F0")]
    public BattleSortieConditionMaster BattleSortieConditionData;
    [Token(Token = "0x4003BB2")]
    [FieldOffset(Offset = "0x1D8")]
    public static string BattlePath;
    [Token(Token = "0x4003BB3")]
    [FieldOffset(Offset = "0x1F8")]
    public BattleMaster BattleData;
    [Token(Token = "0x4003BB4")]
    [FieldOffset(Offset = "0x1E0")]
    public static string BattleVoiceCombiPath;
    [Token(Token = "0x4003BB5")]
    [FieldOffset(Offset = "0x200")]
    public BattleVoiceCombiMaster BattleVoiceCombiData;
    [Token(Token = "0x4003BB6")]
    [FieldOffset(Offset = "0x1E8")]
    public static string BattleVoicePath;
    [Token(Token = "0x4003BB7")]
    [FieldOffset(Offset = "0x208")]
    public BattleVoiceMaster BattleVoiceData;
    [Token(Token = "0x4003BB8")]
    [FieldOffset(Offset = "0x1F0")]
    public static string BattleConstPath;
    [Token(Token = "0x4003BB9")]
    [FieldOffset(Offset = "0x210")]
    public BattleConstMaster BattleConstData;
    [Token(Token = "0x4003BBA")]
    [FieldOffset(Offset = "0x1F8")]
    public static string BattleLogicConstPath;
    [Token(Token = "0x4003BBB")]
    [FieldOffset(Offset = "0x218")]
    public BattleLogicConstMaster BattleLogicConstData;
    [Token(Token = "0x4003BBC")]
    [FieldOffset(Offset = "0x200")]
    public static string BattleDropDescriptionPath;
    [Token(Token = "0x4003BBD")]
    [FieldOffset(Offset = "0x220")]
    public BattleDropDescriptionMaster BattleDropDescriptionData;
    [Token(Token = "0x4003BBE")]
    [FieldOffset(Offset = "0x208")]
    public static string BattleDropSetDescriptionPath;
    [Token(Token = "0x4003BBF")]
    [FieldOffset(Offset = "0x228")]
    public BattleDropSetDescriptionMaster BattleDropSetDescriptionData;
    [Token(Token = "0x4003BC0")]
    [FieldOffset(Offset = "0x210")]
    public static string BattleDropSetPath;
    [Token(Token = "0x4003BC1")]
    [FieldOffset(Offset = "0x230")]
    public BattleDropSetMaster BattleDropSetData;
    [Token(Token = "0x4003BC2")]
    [FieldOffset(Offset = "0x218")]
    public static string BattleEnemyPlacementDescriptionPath;
    [Token(Token = "0x4003BC3")]
    [FieldOffset(Offset = "0x238")]
    public BattleEnemyPlacementDescriptionMaster BattleEnemyPlacementDescriptionData;
    [Token(Token = "0x4003BC4")]
    [FieldOffset(Offset = "0x220")]
    public static string BattleEnemyPlacementPath;
    [Token(Token = "0x4003BC5")]
    [FieldOffset(Offset = "0x240")]
    public BattleEnemyPlacementMaster BattleEnemyPlacementData;
    [Token(Token = "0x4003BC6")]
    [FieldOffset(Offset = "0x228")]
    public static string BattleEnemyTroopsPath;
    [Token(Token = "0x4003BC7")]
    [FieldOffset(Offset = "0x248")]
    public BattleEnemyTroopsMaster BattleEnemyTroopsData;
    [Token(Token = "0x4003BC8")]
    [FieldOffset(Offset = "0x230")]
    public static string BattleRaidEnemyPlacementDescriptionPath;
    [Token(Token = "0x4003BC9")]
    [FieldOffset(Offset = "0x250")]
    public BattleRaidEnemyPlacementDescriptionMaster BattleRaidEnemyPlacementDescriptionData;
    [Token(Token = "0x4003BCA")]
    [FieldOffset(Offset = "0x238")]
    public static string LandTagPath;
    [Token(Token = "0x4003BCB")]
    [FieldOffset(Offset = "0x258")]
    public LandTagMaster LandTagData;
    [Token(Token = "0x4003BCC")]
    [FieldOffset(Offset = "0x240")]
    public static string BattleForcedSortiePath;
    [Token(Token = "0x4003BCD")]
    [FieldOffset(Offset = "0x260")]
    public BattleForcedSortieMaster BattleForcedSortieData;
    [Token(Token = "0x4003BCE")]
    [FieldOffset(Offset = "0x248")]
    public static string BattleGuestPlacementDescriptionPath;
    [Token(Token = "0x4003BCF")]
    [FieldOffset(Offset = "0x268")]
    public BattleGuestPlacementDescriptionMaster BattleGuestPlacementDescriptionData;
    [Token(Token = "0x4003BD0")]
    [FieldOffset(Offset = "0x250")]
    public static string BattleGuestTroopsPath;
    [Token(Token = "0x4003BD1")]
    [FieldOffset(Offset = "0x270")]
    public BattleGuestTroopsMaster BattleGuestTroopsData;
    [Token(Token = "0x4003BD2")]
    [FieldOffset(Offset = "0x258")]
    public static string BattleInitialPlacementDescriptionPath;
    [Token(Token = "0x4003BD3")]
    [FieldOffset(Offset = "0x278")]
    public BattleInitialPlacementDescriptionMaster BattleInitialPlacementDescriptionData;
    [Token(Token = "0x4003BD4")]
    [FieldOffset(Offset = "0x260")]
    public static string BattleInitialPlacementPath;
    [Token(Token = "0x4003BD5")]
    [FieldOffset(Offset = "0x280")]
    public BattleInitialPlacementMaster BattleInitialPlacementData;
    [Token(Token = "0x4003BD6")]
    [FieldOffset(Offset = "0x268")]
    public static string BattleMissionSetPath;
    [Token(Token = "0x4003BD7")]
    [FieldOffset(Offset = "0x288")]
    public BattleMissionSetMaster BattleMissionSetData;
    [Token(Token = "0x4003BD8")]
    [FieldOffset(Offset = "0x270")]
    public static string BattleMissionPath;
    [Token(Token = "0x4003BD9")]
    [FieldOffset(Offset = "0x290")]
    public BattleMissionMaster BattleMissionData;
    [Token(Token = "0x4003BDA")]
    [FieldOffset(Offset = "0x278")]
    public static string NpcUnitDataPath;
    [Token(Token = "0x4003BDB")]
    [FieldOffset(Offset = "0x298")]
    public NpcUnitDataMaster NpcUnitDataData;
    [Token(Token = "0x4003BDC")]
    [FieldOffset(Offset = "0x280")]
    public static string BattleFacilityPlacementDescriptionPath;
    [Token(Token = "0x4003BDD")]
    [FieldOffset(Offset = "0x2A0")]
    public BattleFacilityPlacementDescriptionMaster BattleFacilityPlacementDescriptionData;
    [Token(Token = "0x4003BDE")]
    [FieldOffset(Offset = "0x288")]
    public static string BattleFacilityPlacementPath;
    [Token(Token = "0x4003BDF")]
    [FieldOffset(Offset = "0x2A8")]
    public BattleFacilityPlacementMaster BattleFacilityPlacementData;
    [Token(Token = "0x4003BE0")]
    [FieldOffset(Offset = "0x290")]
    public static string BattleFacilityPath;
    [Token(Token = "0x4003BE1")]
    [FieldOffset(Offset = "0x2B0")]
    public BattleFacilityMaster BattleFacilityData;
    [Token(Token = "0x4003BE2")]
    [FieldOffset(Offset = "0x298")]
    public static string BattleRewardDescriptionPath;
    [Token(Token = "0x4003BE3")]
    [FieldOffset(Offset = "0x2B8")]
    public BattleRewardDescriptionMaster BattleRewardDescriptionData;
    [Token(Token = "0x4003BE4")]
    [FieldOffset(Offset = "0x2A0")]
    public static string BattleSortieRestrictionsPath;
    [Token(Token = "0x4003BE5")]
    [FieldOffset(Offset = "0x2C0")]
    public BattleSortieRestrictionsMaster BattleSortieRestrictionsData;
    [Token(Token = "0x4003BE6")]
    [FieldOffset(Offset = "0x2A8")]
    public static string StoryBattleMissionRewardDescriptionPath;
    [Token(Token = "0x4003BE7")]
    [FieldOffset(Offset = "0x2C8")]
    public StoryBattleMissionRewardDescriptionMaster StoryBattleMissionRewardDescriptionData;
    [Token(Token = "0x4003BE8")]
    [FieldOffset(Offset = "0x2B0")]
    public static string StoryBattleMissionRewardPath;
    [Token(Token = "0x4003BE9")]
    [FieldOffset(Offset = "0x2D0")]
    public StoryBattleMissionRewardMaster StoryBattleMissionRewardData;
    [Token(Token = "0x4003BEA")]
    [FieldOffset(Offset = "0x2B8")]
    public static string StoryBattleMissionPath;
    [Token(Token = "0x4003BEB")]
    [FieldOffset(Offset = "0x2D8")]
    public StoryBattleMissionMaster StoryBattleMissionData;
    [Token(Token = "0x4003BEC")]
    [FieldOffset(Offset = "0x2C0")]
    public static string BattleThirdarmyPlacementDescriptionPath;
    [Token(Token = "0x4003BED")]
    [FieldOffset(Offset = "0x2E0")]
    public BattleThirdarmyPlacementDescriptionMaster BattleThirdarmyPlacementDescriptionData;
    [Token(Token = "0x4003BEE")]
    [FieldOffset(Offset = "0x2C8")]
    public static string BattleThirdarmyPlacementPath;
    [Token(Token = "0x4003BEF")]
    [FieldOffset(Offset = "0x2E8")]
    public BattleThirdarmyPlacementMaster BattleThirdarmyPlacementData;
    [Token(Token = "0x4003BF0")]
    [FieldOffset(Offset = "0x2D0")]
    public static string BattleThirdarmyTroopsPath;
    [Token(Token = "0x4003BF1")]
    [FieldOffset(Offset = "0x2F0")]
    public BattleThirdarmyTroopsMaster BattleThirdarmyTroopsData;
    [Token(Token = "0x4003BF2")]
    [FieldOffset(Offset = "0x2D8")]
    public static string ChatConstPath;
    [Token(Token = "0x4003BF3")]
    [FieldOffset(Offset = "0x2F8")]
    public ChatConstMaster ChatConstData;
    [Token(Token = "0x4003BF4")]
    [FieldOffset(Offset = "0x2E0")]
    public static string ChatPhraseDefaultPath;
    [Token(Token = "0x4003BF5")]
    [FieldOffset(Offset = "0x300")]
    public ChatPhraseDefaultMaster ChatPhraseDefaultData;
    [Token(Token = "0x4003BF6")]
    [FieldOffset(Offset = "0x2E8")]
    public static string ChatRoomPath;
    [Token(Token = "0x4003BF7")]
    [FieldOffset(Offset = "0x308")]
    public ChatRoomMaster ChatRoomData;
    [Token(Token = "0x4003BF8")]
    [FieldOffset(Offset = "0x2F0")]
    public static string ChatStampPath;
    [Token(Token = "0x4003BF9")]
    [FieldOffset(Offset = "0x310")]
    public ChatStampMaster ChatStampData;
    [Token(Token = "0x4003BFA")]
    [FieldOffset(Offset = "0x2F8")]
    public static string ButtonClickSEPath;
    [Token(Token = "0x4003BFB")]
    [FieldOffset(Offset = "0x318")]
    public ButtonClickSEMaster ButtonClickSEData;
    [Token(Token = "0x4003BFC")]
    [FieldOffset(Offset = "0x300")]
    public static string ButtonLongPressSEPath;
    [Token(Token = "0x4003BFD")]
    [FieldOffset(Offset = "0x320")]
    public ButtonLongPressSEMaster ButtonLongPressSEData;
    [Token(Token = "0x4003BFE")]
    [FieldOffset(Offset = "0x308")]
    public static string CommonEffectListPath;
    [Token(Token = "0x4003BFF")]
    [FieldOffset(Offset = "0x328")]
    public CommonEffectListMaster CommonEffectListData;
    [Token(Token = "0x4003C00")]
    [FieldOffset(Offset = "0x310")]
    public static string ConstPath;
    [Token(Token = "0x4003C01")]
    [FieldOffset(Offset = "0x330")]
    public ConstMaster ConstData;
    [Token(Token = "0x4003C02")]
    [FieldOffset(Offset = "0x318")]
    public static string EquipmentClassificationPath;
    [Token(Token = "0x4003C03")]
    [FieldOffset(Offset = "0x338")]
    public EquipmentClassificationMaster EquipmentClassificationData;
    [Token(Token = "0x4003C04")]
    [FieldOffset(Offset = "0x320")]
    public static string SubEquipmentClassificationDescriptionPath;
    [Token(Token = "0x4003C05")]
    [FieldOffset(Offset = "0x340")]
    public SubEquipmentClassificationDescriptionMaster SubEquipmentClassificationDescriptionData;
    [Token(Token = "0x4003C06")]
    [FieldOffset(Offset = "0x328")]
    public static string SubEquipmentClassificationPath;
    [Token(Token = "0x4003C07")]
    [FieldOffset(Offset = "0x348")]
    public SubEquipmentClassificationMaster SubEquipmentClassificationData;
    [Token(Token = "0x4003C08")]
    [FieldOffset(Offset = "0x330")]
    public static string FootstepsPath;
    [Token(Token = "0x4003C09")]
    [FieldOffset(Offset = "0x350")]
    public FootstepsMaster FootstepsData;
    [Token(Token = "0x4003C0A")]
    [FieldOffset(Offset = "0x338")]
    public static string GuidelinePath;
    [Token(Token = "0x4003C0B")]
    [FieldOffset(Offset = "0x358")]
    public GuidelineMaster GuidelineData;
    [Token(Token = "0x4003C0C")]
    [FieldOffset(Offset = "0x340")]
    public static string NetworkErrorPath;
    [Token(Token = "0x4003C0D")]
    [FieldOffset(Offset = "0x360")]
    public NetworkErrorMaster NetworkErrorData;
    [Token(Token = "0x4003C0E")]
    [FieldOffset(Offset = "0x348")]
    public static string PenaltyPath;
    [Token(Token = "0x4003C0F")]
    [FieldOffset(Offset = "0x368")]
    public PenaltyMaster PenaltyData;
    [Token(Token = "0x4003C10")]
    [FieldOffset(Offset = "0x350")]
    public static string SalePath;
    [Token(Token = "0x4003C11")]
    [FieldOffset(Offset = "0x370")]
    public SaleMaster SaleData;
    [Token(Token = "0x4003C12")]
    [FieldOffset(Offset = "0x358")]
    public static string SoulEnhanceValuePath;
    [Token(Token = "0x4003C13")]
    [FieldOffset(Offset = "0x378")]
    public SoulEnhanceValueMaster SoulEnhanceValueData;
    [Token(Token = "0x4003C14")]
    [FieldOffset(Offset = "0x360")]
    public static string SpeciesDescriptionPath;
    [Token(Token = "0x4003C15")]
    [FieldOffset(Offset = "0x380")]
    public SpeciesDescriptionMaster SpeciesDescriptionData;
    [Token(Token = "0x4003C16")]
    [FieldOffset(Offset = "0x368")]
    public static string SpeciesPath;
    [Token(Token = "0x4003C17")]
    [FieldOffset(Offset = "0x388")]
    public SpeciesMaster SpeciesData;
    [Token(Token = "0x4003C18")]
    [FieldOffset(Offset = "0x370")]
    public static string TipsLoadingPath;
    [Token(Token = "0x4003C19")]
    [FieldOffset(Offset = "0x390")]
    public TipsLoadingMaster TipsLoadingData;
    [Token(Token = "0x4003C1A")]
    [FieldOffset(Offset = "0x378")]
    public static string DeckTypePath;
    [Token(Token = "0x4003C1B")]
    [FieldOffset(Offset = "0x398")]
    public DeckTypeMaster DeckTypeData;
    [Token(Token = "0x4003C1C")]
    [FieldOffset(Offset = "0x380")]
    public static string ArmorTypePath;
    [Token(Token = "0x4003C1D")]
    [FieldOffset(Offset = "0x3A0")]
    public ArmorTypeMaster ArmorTypeData;
    [Token(Token = "0x4003C1E")]
    [FieldOffset(Offset = "0x388")]
    public static string AttackTypePath;
    [Token(Token = "0x4003C1F")]
    [FieldOffset(Offset = "0x3A8")]
    public AttackTypeMaster AttackTypeData;
    [Token(Token = "0x4003C20")]
    [FieldOffset(Offset = "0x390")]
    public static string BattleBadStatusTypePath;
    [Token(Token = "0x4003C21")]
    [FieldOffset(Offset = "0x3B0")]
    public BattleBadStatusTypeMaster BattleBadStatusTypeData;
    [Token(Token = "0x4003C22")]
    [FieldOffset(Offset = "0x398")]
    public static string BattleDropRewardTypePath;
    [Token(Token = "0x4003C23")]
    [FieldOffset(Offset = "0x3B8")]
    public BattleDropRewardTypeMaster BattleDropRewardTypeData;
    [Token(Token = "0x4003C24")]
    [FieldOffset(Offset = "0x3A0")]
    public static string BloodTypePath;
    [Token(Token = "0x4003C25")]
    [FieldOffset(Offset = "0x3C0")]
    public BloodTypeMaster BloodTypeData;
    [Token(Token = "0x4003C26")]
    [FieldOffset(Offset = "0x3A8")]
    public static string ChatErrorCodePath;
    [Token(Token = "0x4003C27")]
    [FieldOffset(Offset = "0x3C8")]
    public ChatErrorCodeMaster ChatErrorCodeData;
    [Token(Token = "0x4003C28")]
    [FieldOffset(Offset = "0x3B0")]
    public static string CustomSkillTypePath;
    [Token(Token = "0x4003C29")]
    [FieldOffset(Offset = "0x3D0")]
    public CustomSkillTypeMaster CustomSkillTypeData;
    [Token(Token = "0x4003C2A")]
    [FieldOffset(Offset = "0x3B8")]
    public static string DuelMotionTypePath;
    [Token(Token = "0x4003C2B")]
    [FieldOffset(Offset = "0x3D8")]
    public DuelMotionTypeMaster DuelMotionTypeData;
    [Token(Token = "0x4003C2C")]
    [FieldOffset(Offset = "0x3C0")]
    public static string ElementTypePath;
    [Token(Token = "0x4003C2D")]
    [FieldOffset(Offset = "0x3E0")]
    public ElementTypeMaster ElementTypeData;
    [Token(Token = "0x4003C2E")]
    [FieldOffset(Offset = "0x3C8")]
    public static string LandformTypePath;
    [Token(Token = "0x4003C2F")]
    [FieldOffset(Offset = "0x3E8")]
    public LandformTypeMaster LandformTypeData;
    [Token(Token = "0x4003C30")]
    [FieldOffset(Offset = "0x3D0")]
    public static string MoveTypePath;
    [Token(Token = "0x4003C31")]
    [FieldOffset(Offset = "0x3F0")]
    public MoveTypeMaster MoveTypeData;
    [Token(Token = "0x4003C32")]
    [FieldOffset(Offset = "0x3D8")]
    public static string ReincarnationBonusTypePath;
    [Token(Token = "0x4003C33")]
    [FieldOffset(Offset = "0x3F8")]
    public ReincarnationBonusTypeMaster ReincarnationBonusTypeData;
    [Token(Token = "0x4003C34")]
    [FieldOffset(Offset = "0x3E0")]
    public static string RideTypePath;
    [Token(Token = "0x4003C35")]
    [FieldOffset(Offset = "0x400")]
    public RideTypeMaster RideTypeData;
    [Token(Token = "0x4003C36")]
    [FieldOffset(Offset = "0x3E8")]
    public static string SexTypePath;
    [Token(Token = "0x4003C37")]
    [FieldOffset(Offset = "0x408")]
    public SexTypeMaster SexTypeData;
    [Token(Token = "0x4003C38")]
    [FieldOffset(Offset = "0x3F0")]
    public static string SkillCategoryTypePath;
    [Token(Token = "0x4003C39")]
    [FieldOffset(Offset = "0x410")]
    public SkillCategoryTypeMaster SkillCategoryTypeData;
    [Token(Token = "0x4003C3A")]
    [FieldOffset(Offset = "0x3F8")]
    public static string SkillTagTypePath;
    [Token(Token = "0x4003C3B")]
    [FieldOffset(Offset = "0x418")]
    public SkillTagTypeMaster SkillTagTypeData;
    [Token(Token = "0x4003C3C")]
    [FieldOffset(Offset = "0x400")]
    public static string SpeciesTypePath;
    [Token(Token = "0x4003C3D")]
    [FieldOffset(Offset = "0x420")]
    public SpeciesTypeMaster SpeciesTypeData;
    [Token(Token = "0x4003C3E")]
    [FieldOffset(Offset = "0x408")]
    public static string StyleGroupTypePath;
    [Token(Token = "0x4003C3F")]
    [FieldOffset(Offset = "0x428")]
    public StyleGroupTypeMaster StyleGroupTypeData;
    [Token(Token = "0x4003C40")]
    [FieldOffset(Offset = "0x410")]
    public static string WeaponTypeEnumPath;
    [Token(Token = "0x4003C41")]
    [FieldOffset(Offset = "0x430")]
    public WeaponTypeEnumMaster WeaponTypeEnumData;
    [Token(Token = "0x4003C42")]
    [FieldOffset(Offset = "0x418")]
    public static string AccessoriesExpPath;
    [Token(Token = "0x4003C43")]
    [FieldOffset(Offset = "0x438")]
    public AccessoriesExpMaster AccessoriesExpData;
    [Token(Token = "0x4003C44")]
    [FieldOffset(Offset = "0x420")]
    public static string AccessoriesPath;
    [Token(Token = "0x4003C45")]
    [FieldOffset(Offset = "0x440")]
    public AccessoriesMaster AccessoriesData;
    [Token(Token = "0x4003C46")]
    [FieldOffset(Offset = "0x428")]
    public static string AccessoryOptionEffectSpritePath;
    [Token(Token = "0x4003C47")]
    [FieldOffset(Offset = "0x448")]
    public AccessoryOptionEffectSpriteMaster AccessoryOptionEffectSpriteData;
    [Token(Token = "0x4003C48")]
    [FieldOffset(Offset = "0x430")]
    public static string AccessoryOptionSlotPath;
    [Token(Token = "0x4003C49")]
    [FieldOffset(Offset = "0x450")]
    public AccessoryOptionSlotMaster AccessoryOptionSlotData;
    [Token(Token = "0x4003C4A")]
    [FieldOffset(Offset = "0x438")]
    public static string AccessoryOptionPath;
    [Token(Token = "0x4003C4B")]
    [FieldOffset(Offset = "0x458")]
    public AccessoryOptionMaster AccessoryOptionData;
    [Token(Token = "0x4003C4C")]
    [FieldOffset(Offset = "0x440")]
    public static string AccessoryOptionChangeItemRecipePath;
    [Token(Token = "0x4003C4D")]
    [FieldOffset(Offset = "0x460")]
    public AccessoryOptionChangeItemRecipeMaster AccessoryOptionChangeItemRecipeData;
    [Token(Token = "0x4003C4E")]
    [FieldOffset(Offset = "0x448")]
    public static string AccessoryOptionGradeGroupPath;
    [Token(Token = "0x4003C4F")]
    [FieldOffset(Offset = "0x468")]
    public AccessoryOptionGradeGroupMaster AccessoryOptionGradeGroupData;
    [Token(Token = "0x4003C50")]
    [FieldOffset(Offset = "0x450")]
    public static string AccessoryOptionLotteryPath;
    [Token(Token = "0x4003C51")]
    [FieldOffset(Offset = "0x470")]
    public AccessoryOptionLotteryMaster AccessoryOptionLotteryData;
    [Token(Token = "0x4003C52")]
    [FieldOffset(Offset = "0x458")]
    public static string AccessoriesLimitBreakDescriptionPath;
    [Token(Token = "0x4003C53")]
    [FieldOffset(Offset = "0x478")]
    public AccessoriesLimitBreakDescriptionMaster AccessoriesLimitBreakDescriptionData;
    [Token(Token = "0x4003C54")]
    [FieldOffset(Offset = "0x460")]
    public static string AccessoriesLimitBreakPath;
    [Token(Token = "0x4003C55")]
    [FieldOffset(Offset = "0x480")]
    public AccessoriesLimitBreakMaster AccessoriesLimitBreakData;
    [Token(Token = "0x4003C56")]
    [FieldOffset(Offset = "0x468")]
    public static string InscriptionAcquiredPath;
    [Token(Token = "0x4003C57")]
    [FieldOffset(Offset = "0x488")]
    public InscriptionAcquiredMaster InscriptionAcquiredData;
    [Token(Token = "0x4003C58")]
    [FieldOffset(Offset = "0x470")]
    public static string InscriptionCategoryPath;
    [Token(Token = "0x4003C59")]
    [FieldOffset(Offset = "0x490")]
    public InscriptionCategoryMaster InscriptionCategoryData;
    [Token(Token = "0x4003C5A")]
    [FieldOffset(Offset = "0x478")]
    public static string InscriptionDescriptionPath;
    [Token(Token = "0x4003C5B")]
    [FieldOffset(Offset = "0x498")]
    public InscriptionDescriptionMaster InscriptionDescriptionData;
    [Token(Token = "0x4003C5C")]
    [FieldOffset(Offset = "0x480")]
    public static string InscriptionPath;
    [Token(Token = "0x4003C5D")]
    [FieldOffset(Offset = "0x4A0")]
    public InscriptionMaster InscriptionData;
    [Token(Token = "0x4003C5E")]
    [FieldOffset(Offset = "0x488")]
    public static string LimitBreakLevelCapPath;
    [Token(Token = "0x4003C5F")]
    [FieldOffset(Offset = "0x4A8")]
    public LimitBreakLevelCapMaster LimitBreakLevelCapData;
    [Token(Token = "0x4003C60")]
    [FieldOffset(Offset = "0x490")]
    public static string MindEquipmentExpPath;
    [Token(Token = "0x4003C61")]
    [FieldOffset(Offset = "0x4B0")]
    public MindEquipmentExpMaster MindEquipmentExpData;
    [Token(Token = "0x4003C62")]
    [FieldOffset(Offset = "0x498")]
    public static string MindEquipmentLimitBreakDescriptionPath;
    [Token(Token = "0x4003C63")]
    [FieldOffset(Offset = "0x4B8")]
    public MindEquipmentLimitBreakDescriptionMaster MindEquipmentLimitBreakDescriptionData;
    [Token(Token = "0x4003C64")]
    [FieldOffset(Offset = "0x4A0")]
    public static string MindEquipmentMedalExchangePath;
    [Token(Token = "0x4003C65")]
    [FieldOffset(Offset = "0x4C0")]
    public MindEquipmentMedalExchangeMaster MindEquipmentMedalExchangeData;
    [Token(Token = "0x4003C66")]
    [FieldOffset(Offset = "0x4A8")]
    public static string MindEquipmentPath;
    [Token(Token = "0x4003C67")]
    [FieldOffset(Offset = "0x4C8")]
    public MindEquipmentMaster MindEquipmentData;
    [Token(Token = "0x4003C68")]
    [FieldOffset(Offset = "0x4B0")]
    public static string SkillEnhanceConstPath;
    [Token(Token = "0x4003C69")]
    [FieldOffset(Offset = "0x4D0")]
    public SkillEnhanceConstMaster SkillEnhanceConstData;
    [Token(Token = "0x4003C6A")]
    [FieldOffset(Offset = "0x4B8")]
    public static string SkillEnhanceLevelPath;
    [Token(Token = "0x4003C6B")]
    [FieldOffset(Offset = "0x4D8")]
    public SkillEnhanceLevelMaster SkillEnhanceLevelData;
    [Token(Token = "0x4003C6C")]
    [FieldOffset(Offset = "0x4C0")]
    public static string SkillEnhanceRarityPath;
    [Token(Token = "0x4003C6D")]
    [FieldOffset(Offset = "0x4E0")]
    public SkillEnhanceRarityMaster SkillEnhanceRarityData;
    [Token(Token = "0x4003C6E")]
    [FieldOffset(Offset = "0x4C8")]
    public static string TrustPath;
    [Token(Token = "0x4003C6F")]
    [FieldOffset(Offset = "0x4E8")]
    public TrustMaster TrustData;
    [Token(Token = "0x4003C70")]
    [FieldOffset(Offset = "0x4D0")]
    public static string MaxLimitBreakPath;
    [Token(Token = "0x4003C71")]
    [FieldOffset(Offset = "0x4F0")]
    public MaxLimitBreakMaster MaxLimitBreakData;
    [Token(Token = "0x4003C72")]
    [FieldOffset(Offset = "0x4D8")]
    public static string WeaponExpPath;
    [Token(Token = "0x4003C73")]
    [FieldOffset(Offset = "0x4F8")]
    public WeaponExpMaster WeaponExpData;
    [Token(Token = "0x4003C74")]
    [FieldOffset(Offset = "0x4E0")]
    public static string WeaponLimitBreakDescriptionPath;
    [Token(Token = "0x4003C75")]
    [FieldOffset(Offset = "0x500")]
    public WeaponLimitBreakDescriptionMaster WeaponLimitBreakDescriptionData;
    [Token(Token = "0x4003C76")]
    [FieldOffset(Offset = "0x4E8")]
    public static string WeaponLimitBreakPath;
    [Token(Token = "0x4003C77")]
    [FieldOffset(Offset = "0x508")]
    public WeaponLimitBreakMaster WeaponLimitBreakData;
    [Token(Token = "0x4003C78")]
    [FieldOffset(Offset = "0x4F0")]
    public static string WeaponProficiencyPlusPath;
    [Token(Token = "0x4003C79")]
    [FieldOffset(Offset = "0x510")]
    public WeaponProficiencyPlusMaster WeaponProficiencyPlusData;
    [Token(Token = "0x4003C7A")]
    [FieldOffset(Offset = "0x4F8")]
    public static string WeaponRarityAptitudeDescriptionPath;
    [Token(Token = "0x4003C7B")]
    [FieldOffset(Offset = "0x518")]
    public WeaponRarityAptitudeDescriptionMaster WeaponRarityAptitudeDescriptionData;
    [Token(Token = "0x4003C7C")]
    [FieldOffset(Offset = "0x500")]
    public static string WeaponRarityAptitudePath;
    [Token(Token = "0x4003C7D")]
    [FieldOffset(Offset = "0x520")]
    public WeaponRarityAptitudeMaster WeaponRarityAptitudeData;
    [Token(Token = "0x4003C7E")]
    [FieldOffset(Offset = "0x508")]
    public static string WeaponPath;
    [Token(Token = "0x4003C7F")]
    [FieldOffset(Offset = "0x528")]
    public WeaponMaster WeaponData;
    [Token(Token = "0x4003C80")]
    [FieldOffset(Offset = "0x510")]
    public static string WeaponOptionEffectSpritePath;
    [Token(Token = "0x4003C81")]
    [FieldOffset(Offset = "0x530")]
    public WeaponOptionEffectSpriteMaster WeaponOptionEffectSpriteData;
    [Token(Token = "0x4003C82")]
    [FieldOffset(Offset = "0x518")]
    public static string WeaponOptionSlotPath;
    [Token(Token = "0x4003C83")]
    [FieldOffset(Offset = "0x538")]
    public WeaponOptionSlotMaster WeaponOptionSlotData;
    [Token(Token = "0x4003C84")]
    [FieldOffset(Offset = "0x520")]
    public static string WeaponOptionPath;
    [Token(Token = "0x4003C85")]
    [FieldOffset(Offset = "0x540")]
    public WeaponOptionMaster WeaponOptionData;
    [Token(Token = "0x4003C86")]
    [FieldOffset(Offset = "0x528")]
    public static string WeaponOptionChangeItemRecipePath;
    [Token(Token = "0x4003C87")]
    [FieldOffset(Offset = "0x548")]
    public WeaponOptionChangeItemRecipeMaster WeaponOptionChangeItemRecipeData;
    [Token(Token = "0x4003C88")]
    [FieldOffset(Offset = "0x530")]
    public static string WeaponOptionGradeGroupPath;
    [Token(Token = "0x4003C89")]
    [FieldOffset(Offset = "0x550")]
    public WeaponOptionGradeGroupMaster WeaponOptionGradeGroupData;
    [Token(Token = "0x4003C8A")]
    [FieldOffset(Offset = "0x538")]
    public static string WeaponOptionLotteryPath;
    [Token(Token = "0x4003C8B")]
    [FieldOffset(Offset = "0x558")]
    public WeaponOptionLotteryMaster WeaponOptionLotteryData;
    [Token(Token = "0x4003C8C")]
    [FieldOffset(Offset = "0x540")]
    public static string ExpeditionBossDescriptionPath;
    [Token(Token = "0x4003C8D")]
    [FieldOffset(Offset = "0x560")]
    public ExpeditionBossDescriptionMaster ExpeditionBossDescriptionData;
    [Token(Token = "0x4003C8E")]
    [FieldOffset(Offset = "0x548")]
    public static string ExpeditionBossEnemyDescriptionPath;
    [Token(Token = "0x4003C8F")]
    [FieldOffset(Offset = "0x568")]
    public ExpeditionBossEnemyDescriptionMaster ExpeditionBossEnemyDescriptionData;
    [Token(Token = "0x4003C90")]
    [FieldOffset(Offset = "0x550")]
    public static string ExpeditionBossOwnPlacementDescriptionPath;
    [Token(Token = "0x4003C91")]
    [FieldOffset(Offset = "0x570")]
    public ExpeditionBossOwnPlacementDescriptionMaster ExpeditionBossOwnPlacementDescriptionData;
    [Token(Token = "0x4003C92")]
    [FieldOffset(Offset = "0x558")]
    public static string ExpeditionBossRareRewardSetPath;
    [Token(Token = "0x4003C93")]
    [FieldOffset(Offset = "0x578")]
    public ExpeditionBossRareRewardSetMaster ExpeditionBossRareRewardSetData;
    [Token(Token = "0x4003C94")]
    [FieldOffset(Offset = "0x560")]
    public static string ExpeditionBossRareRewardPath;
    [Token(Token = "0x4003C95")]
    [FieldOffset(Offset = "0x580")]
    public ExpeditionBossRareRewardMaster ExpeditionBossRareRewardData;
    [Token(Token = "0x4003C96")]
    [FieldOffset(Offset = "0x568")]
    public static string ExpeditionBossRewardGroupPath;
    [Token(Token = "0x4003C97")]
    [FieldOffset(Offset = "0x588")]
    public ExpeditionBossRewardGroupMaster ExpeditionBossRewardGroupData;
    [Token(Token = "0x4003C98")]
    [FieldOffset(Offset = "0x570")]
    public static string ExpeditionBoxPath;
    [Token(Token = "0x4003C99")]
    [FieldOffset(Offset = "0x590")]
    public ExpeditionBoxMaster ExpeditionBoxData;
    [Token(Token = "0x4003C9A")]
    [FieldOffset(Offset = "0x578")]
    public static string ExpeditionWeaponBasePath;
    [Token(Token = "0x4003C9B")]
    [FieldOffset(Offset = "0x598")]
    public ExpeditionWeaponBaseMaster ExpeditionWeaponBaseData;
    [Token(Token = "0x4003C9C")]
    [FieldOffset(Offset = "0x580")]
    public static string ExpeditionWeaponCoeffcicentPath;
    [Token(Token = "0x4003C9D")]
    [FieldOffset(Offset = "0x5A0")]
    public ExpeditionWeaponCoeffcicentMaster ExpeditionWeaponCoeffcicentData;
    [Token(Token = "0x4003C9E")]
    [FieldOffset(Offset = "0x588")]
    public static string ExpeditionPartyReleasePath;
    [Token(Token = "0x4003C9F")]
    [FieldOffset(Offset = "0x5A8")]
    public ExpeditionPartyReleaseMaster ExpeditionPartyReleaseData;
    [Token(Token = "0x4003CA0")]
    [FieldOffset(Offset = "0x590")]
    public static string ExpeditionPartySlotReleasePath;
    [Token(Token = "0x4003CA1")]
    [FieldOffset(Offset = "0x5B0")]
    public ExpeditionPartySlotReleaseMaster ExpeditionPartySlotReleaseData;
    [Token(Token = "0x4003CA2")]
    [FieldOffset(Offset = "0x598")]
    public static string ExpeditionRapidCoinRequiredAmountPath;
    [Token(Token = "0x4003CA3")]
    [FieldOffset(Offset = "0x5B8")]
    public ExpeditionRapidCoinRequiredAmountMaster ExpeditionRapidCoinRequiredAmountData;
    [Token(Token = "0x4003CA4")]
    [FieldOffset(Offset = "0x5A0")]
    public static string ExpeditionSoulSpotExpPath;
    [Token(Token = "0x4003CA5")]
    [FieldOffset(Offset = "0x5C0")]
    public ExpeditionSoulSpotExpMaster ExpeditionSoulSpotExpData;
    [Token(Token = "0x4003CA6")]
    [FieldOffset(Offset = "0x5A8")]
    public static string ExpeditionSoulSpotPath;
    [Token(Token = "0x4003CA7")]
    [FieldOffset(Offset = "0x5C8")]
    public ExpeditionSoulSpotMaster ExpeditionSoulSpotData;
    [Token(Token = "0x4003CA8")]
    [FieldOffset(Offset = "0x5B0")]
    public static string ExpeditionSoulTankPath;
    [Token(Token = "0x4003CA9")]
    [FieldOffset(Offset = "0x5D0")]
    public ExpeditionSoulTankMaster ExpeditionSoulTankData;
    [Token(Token = "0x4003CAA")]
    [FieldOffset(Offset = "0x5B8")]
    public static string ExpeditionStageDescriptionPath;
    [Token(Token = "0x4003CAB")]
    [FieldOffset(Offset = "0x5D8")]
    public ExpeditionStageDescriptionMaster ExpeditionStageDescriptionData;
    [Token(Token = "0x4003CAC")]
    [FieldOffset(Offset = "0x5C0")]
    public static string ExpeditionStageEnemyDescriptionPath;
    [Token(Token = "0x4003CAD")]
    [FieldOffset(Offset = "0x5E0")]
    public ExpeditionStageEnemyDescriptionMaster ExpeditionStageEnemyDescriptionData;
    [Token(Token = "0x4003CAE")]
    [FieldOffset(Offset = "0x5C8")]
    public static string ExpeditionStageItemDropDescriptionPath;
    [Token(Token = "0x4003CAF")]
    [FieldOffset(Offset = "0x5E8")]
    public ExpeditionStageItemDropDescriptionMaster ExpeditionStageItemDropDescriptionData;
    [Token(Token = "0x4003CB0")]
    [FieldOffset(Offset = "0x5D0")]
    public static string ExpeditionStageOwnPlacementDescriptionPath;
    [Token(Token = "0x4003CB1")]
    [FieldOffset(Offset = "0x5F0")]
    public ExpeditionStageOwnPlacementDescriptionMaster ExpeditionStageOwnPlacementDescriptionData;
    [Token(Token = "0x4003CB2")]
    [FieldOffset(Offset = "0x5D8")]
    public static string ExpeditionStagePath;
    [Token(Token = "0x4003CB3")]
    [FieldOffset(Offset = "0x5F8")]
    public ExpeditionStageMaster ExpeditionStageData;
    [Token(Token = "0x4003CB4")]
    [FieldOffset(Offset = "0x5E0")]
    public static string FriendConstPath;
    [Token(Token = "0x4003CB5")]
    [FieldOffset(Offset = "0x600")]
    public FriendConstMaster FriendConstData;
    [Token(Token = "0x4003CB6")]
    [FieldOffset(Offset = "0x5E8")]
    public static string GuildArmourySettingsPath;
    [Token(Token = "0x4003CB7")]
    [FieldOffset(Offset = "0x608")]
    public GuildArmourySettingsMaster GuildArmourySettingsData;
    [Token(Token = "0x4003CB8")]
    [FieldOffset(Offset = "0x5F0")]
    public static string GuildConstPath;
    [Token(Token = "0x4003CB9")]
    [FieldOffset(Offset = "0x610")]
    public GuildConstMaster GuildConstData;
    [Token(Token = "0x4003CBA")]
    [FieldOffset(Offset = "0x5F8")]
    public static string GuildRoleTypePath;
    [Token(Token = "0x4003CBB")]
    [FieldOffset(Offset = "0x618")]
    public GuildRoleTypeMaster GuildRoleTypeData;
    [Token(Token = "0x4003CBC")]
    [FieldOffset(Offset = "0x600")]
    public static string GuildSettingsAutoApproveTypePath;
    [Token(Token = "0x4003CBD")]
    [FieldOffset(Offset = "0x620")]
    public GuildSettingsAutoApproveTypeMaster GuildSettingsAutoApproveTypeData;
    [Token(Token = "0x4003CBE")]
    [FieldOffset(Offset = "0x608")]
    public static string GuildSettingsAutoKickTypePath;
    [Token(Token = "0x4003CBF")]
    [FieldOffset(Offset = "0x628")]
    public GuildSettingsAutoKickTypeMaster GuildSettingsAutoKickTypeData;
    [Token(Token = "0x4003CC0")]
    [FieldOffset(Offset = "0x610")]
    public static string GuildSettingsConditionsTypePath;
    [Token(Token = "0x4003CC1")]
    [FieldOffset(Offset = "0x630")]
    public GuildSettingsConditionsTypeMaster GuildSettingsConditionsTypeData;
    [Token(Token = "0x4003CC2")]
    [FieldOffset(Offset = "0x618")]
    public static string GuildSettingsPolicyTypePath;
    [Token(Token = "0x4003CC3")]
    [FieldOffset(Offset = "0x638")]
    public GuildSettingsPolicyTypeMaster GuildSettingsPolicyTypeData;
    [Token(Token = "0x4003CC4")]
    [FieldOffset(Offset = "0x620")]
    public static string GuildSettingsRecruitStatusTypePath;
    [Token(Token = "0x4003CC5")]
    [FieldOffset(Offset = "0x640")]
    public GuildSettingsRecruitStatusTypeMaster GuildSettingsRecruitStatusTypeData;
    [Token(Token = "0x4003CC6")]
    [FieldOffset(Offset = "0x628")]
    public static string GuildUnlockElementTypePath;
    [Token(Token = "0x4003CC7")]
    [FieldOffset(Offset = "0x648")]
    public GuildUnlockElementTypeMaster GuildUnlockElementTypeData;
    [Token(Token = "0x4003CC8")]
    [FieldOffset(Offset = "0x630")]
    public static string GuildFacilityEffectPath;
    [Token(Token = "0x4003CC9")]
    [FieldOffset(Offset = "0x650")]
    public GuildFacilityEffectMaster GuildFacilityEffectData;
    [Token(Token = "0x4003CCA")]
    [FieldOffset(Offset = "0x638")]
    public static string GuildFacilityExpPath;
    [Token(Token = "0x4003CCB")]
    [FieldOffset(Offset = "0x658")]
    public GuildFacilityExpMaster GuildFacilityExpData;
    [Token(Token = "0x4003CCC")]
    [FieldOffset(Offset = "0x640")]
    public static string GuildFacilityInvestRewardDescriptionPath;
    [Token(Token = "0x4003CCD")]
    [FieldOffset(Offset = "0x660")]
    public GuildFacilityInvestRewardDescriptionMaster GuildFacilityInvestRewardDescriptionData;
    [Token(Token = "0x4003CCE")]
    [FieldOffset(Offset = "0x648")]
    public static string GuildFacilityLevelRewardPath;
    [Token(Token = "0x4003CCF")]
    [FieldOffset(Offset = "0x668")]
    public GuildFacilityLevelRewardMaster GuildFacilityLevelRewardData;
    [Token(Token = "0x4003CD0")]
    [FieldOffset(Offset = "0x650")]
    public static string GuildFacilityResourceDescriptionPath;
    [Token(Token = "0x4003CD1")]
    [FieldOffset(Offset = "0x670")]
    public GuildFacilityResourceDescriptionMaster GuildFacilityResourceDescriptionData;
    [Token(Token = "0x4003CD2")]
    [FieldOffset(Offset = "0x658")]
    public static string GuildFacilityResourceTableDescriptionPath;
    [Token(Token = "0x4003CD3")]
    [FieldOffset(Offset = "0x678")]
    public GuildFacilityResourceTableDescriptionMaster GuildFacilityResourceTableDescriptionData;
    [Token(Token = "0x4003CD4")]
    [FieldOffset(Offset = "0x660")]
    public static string GuildFacilityRewardDescriptionPath;
    [Token(Token = "0x4003CD5")]
    [FieldOffset(Offset = "0x680")]
    public GuildFacilityRewardDescriptionMaster GuildFacilityRewardDescriptionData;
    [Token(Token = "0x4003CD6")]
    [FieldOffset(Offset = "0x668")]
    public static string GuildFacilityPath;
    [Token(Token = "0x4003CD7")]
    [FieldOffset(Offset = "0x688")]
    public GuildFacilityMaster GuildFacilityData;
    [Token(Token = "0x4003CD8")]
    [FieldOffset(Offset = "0x670")]
    public static string GuildFaclityInvestRatePath;
    [Token(Token = "0x4003CD9")]
    [FieldOffset(Offset = "0x690")]
    public GuildFaclityInvestRateMaster GuildFaclityInvestRateData;
    [Token(Token = "0x4003CDA")]
    [FieldOffset(Offset = "0x678")]
    public static string GuildEmblemPath;
    [Token(Token = "0x4003CDB")]
    [FieldOffset(Offset = "0x698")]
    public GuildEmblemMaster GuildEmblemData;
    [Token(Token = "0x4003CDC")]
    [FieldOffset(Offset = "0x680")]
    public static string GuildExpPath;
    [Token(Token = "0x4003CDD")]
    [FieldOffset(Offset = "0x6A0")]
    public GuildExpMaster GuildExpData;
    [Token(Token = "0x4003CDE")]
    [FieldOffset(Offset = "0x688")]
    public static string GuildGiftPath;
    [Token(Token = "0x4003CDF")]
    [FieldOffset(Offset = "0x6A8")]
    public GuildGiftMaster GuildGiftData;
    [Token(Token = "0x4003CE0")]
    [FieldOffset(Offset = "0x690")]
    public static string GuildRaidRewardLapDetailPath;
    [Token(Token = "0x4003CE1")]
    [FieldOffset(Offset = "0x6B0")]
    public GuildRaidRewardLapDetailMaster GuildRaidRewardLapDetailData;
    [Token(Token = "0x4003CE2")]
    [FieldOffset(Offset = "0x698")]
    public static string GuildRaidRewardLapPath;
    [Token(Token = "0x4003CE3")]
    [FieldOffset(Offset = "0x6B8")]
    public GuildRaidRewardLapMaster GuildRaidRewardLapData;
    [Token(Token = "0x4003CE4")]
    [FieldOffset(Offset = "0x6A0")]
    public static string GuildRaidRewardSpecialLapDetailPath;
    [Token(Token = "0x4003CE5")]
    [FieldOffset(Offset = "0x6C0")]
    public GuildRaidRewardSpecialLapDetailMaster GuildRaidRewardSpecialLapDetailData;
    [Token(Token = "0x4003CE6")]
    [FieldOffset(Offset = "0x6A8")]
    public static string GuildRaidRewardSpecialLapPath;
    [Token(Token = "0x4003CE7")]
    [FieldOffset(Offset = "0x6C8")]
    public GuildRaidRewardSpecialLapMaster GuildRaidRewardSpecialLapData;
    [Token(Token = "0x4003CE8")]
    [FieldOffset(Offset = "0x6B0")]
    public static string GuildRaidRewardSuppressDetailPath;
    [Token(Token = "0x4003CE9")]
    [FieldOffset(Offset = "0x6D0")]
    public GuildRaidRewardSuppressDetailMaster GuildRaidRewardSuppressDetailData;
    [Token(Token = "0x4003CEA")]
    [FieldOffset(Offset = "0x6B8")]
    public static string GuildRaidRewardSuppressPath;
    [Token(Token = "0x4003CEB")]
    [FieldOffset(Offset = "0x6D8")]
    public GuildRaidRewardSuppressMaster GuildRaidRewardSuppressData;
    [Token(Token = "0x4003CEC")]
    [FieldOffset(Offset = "0x6C0")]
    public static string GuildRaidPath;
    [Token(Token = "0x4003CED")]
    [FieldOffset(Offset = "0x6E0")]
    public GuildRaidMaster GuildRaidData;
    [Token(Token = "0x4003CEE")]
    [FieldOffset(Offset = "0x6C8")]
    public static string GuildStampPath;
    [Token(Token = "0x4003CEF")]
    [FieldOffset(Offset = "0x6E8")]
    public GuildStampMaster GuildStampData;
    [Token(Token = "0x4003CF0")]
    [FieldOffset(Offset = "0x6D0")]
    public static string GuildTitlePath;
    [Token(Token = "0x4003CF1")]
    [FieldOffset(Offset = "0x6F0")]
    public GuildTitleMaster GuildTitleData;
    [Token(Token = "0x4003CF2")]
    [FieldOffset(Offset = "0x6D8")]
    public static string GuildBattleSettingsPath;
    [Token(Token = "0x4003CF3")]
    [FieldOffset(Offset = "0x6F8")]
    public GuildBattleSettingsMaster GuildBattleSettingsData;
    [Token(Token = "0x4003CF4")]
    [FieldOffset(Offset = "0x6E0")]
    public static string GuildAttendRewardDescriptionPath;
    [Token(Token = "0x4003CF5")]
    [FieldOffset(Offset = "0x700")]
    public GuildAttendRewardDescriptionMaster GuildAttendRewardDescriptionData;
    [Token(Token = "0x4003CF6")]
    [FieldOffset(Offset = "0x6E8")]
    public static string GuildLevelRewardPath;
    [Token(Token = "0x4003CF7")]
    [FieldOffset(Offset = "0x708")]
    public GuildLevelRewardMaster GuildLevelRewardData;
    [Token(Token = "0x4003CF8")]
    [FieldOffset(Offset = "0x6F0")]
    public static string GuildRoleRewardDescriptionPath;
    [Token(Token = "0x4003CF9")]
    [FieldOffset(Offset = "0x710")]
    public GuildRoleRewardDescriptionMaster GuildRoleRewardDescriptionData;
    [Token(Token = "0x4003CFA")]
    [FieldOffset(Offset = "0x6F8")]
    public static string GuildUnlockedElementDescriptionPath;
    [Token(Token = "0x4003CFB")]
    [FieldOffset(Offset = "0x718")]
    public GuildUnlockedElementDescriptionMaster GuildUnlockedElementDescriptionData;
    [Token(Token = "0x4003CFC")]
    [FieldOffset(Offset = "0x700")]
    public static string EventButtonPath;
    [Token(Token = "0x4003CFD")]
    [FieldOffset(Offset = "0x720")]
    public EventButtonMaster EventButtonData;
    [Token(Token = "0x4003CFE")]
    [FieldOffset(Offset = "0x708")]
    public static string HomeEventBalloonPath;
    [Token(Token = "0x4003CFF")]
    [FieldOffset(Offset = "0x728")]
    public HomeEventBalloonMaster HomeEventBalloonData;
    [Token(Token = "0x4003D00")]
    [FieldOffset(Offset = "0x710")]
    public static string HomeEventPath;
    [Token(Token = "0x4003D01")]
    [FieldOffset(Offset = "0x730")]
    public HomeEventMaster HomeEventData;
    [Token(Token = "0x4003D02")]
    [FieldOffset(Offset = "0x718")]
    public static string HomeSeasonSchedulePath;
    [Token(Token = "0x4003D03")]
    [FieldOffset(Offset = "0x738")]
    public HomeSeasonScheduleMaster HomeSeasonScheduleData;
    [Token(Token = "0x4003D04")]
    [FieldOffset(Offset = "0x720")]
    public static string HomeSerifDescriptionPath;
    [Token(Token = "0x4003D05")]
    [FieldOffset(Offset = "0x740")]
    public HomeSerifDescriptionMaster HomeSerifDescriptionData;
    [Token(Token = "0x4003D06")]
    [FieldOffset(Offset = "0x728")]
    public static string HomeTimeAnnouncementSchedulePath;
    [Token(Token = "0x4003D07")]
    [FieldOffset(Offset = "0x748")]
    public HomeTimeAnnouncementScheduleMaster HomeTimeAnnouncementScheduleData;
    [Token(Token = "0x4003D08")]
    [FieldOffset(Offset = "0x730")]
    public static string IntroChapterConstPath;
    [Token(Token = "0x4003D09")]
    [FieldOffset(Offset = "0x750")]
    public IntroChapterConstMaster IntroChapterConstData;
    [Token(Token = "0x4003D0A")]
    [FieldOffset(Offset = "0x738")]
    public static string IntroChapterSequenceAdvSettingPath;
    [Token(Token = "0x4003D0B")]
    [FieldOffset(Offset = "0x758")]
    public IntroChapterSequenceAdvSettingMaster IntroChapterSequenceAdvSettingData;
    [Token(Token = "0x4003D0C")]
    [FieldOffset(Offset = "0x740")]
    public static string IntroChapterSequenceBattleSettingPath;
    [Token(Token = "0x4003D0D")]
    [FieldOffset(Offset = "0x760")]
    public IntroChapterSequenceBattleSettingMaster IntroChapterSequenceBattleSettingData;
    [Token(Token = "0x4003D0E")]
    [FieldOffset(Offset = "0x748")]
    public static string IntroChapterSequenceFreeActionSettingPath;
    [Token(Token = "0x4003D0F")]
    [FieldOffset(Offset = "0x768")]
    public IntroChapterSequenceFreeActionSettingMaster IntroChapterSequenceFreeActionSettingData;
    [Token(Token = "0x4003D10")]
    [FieldOffset(Offset = "0x750")]
    public static string IntroChapterSequenceHomeTutorialSettingPath;
    [Token(Token = "0x4003D11")]
    [FieldOffset(Offset = "0x770")]
    public IntroChapterSequenceHomeTutorialSettingMaster IntroChapterSequenceHomeTutorialSettingData;
    [Token(Token = "0x4003D12")]
    [FieldOffset(Offset = "0x758")]
    public static string IntroChapterSequencePath;
    [Token(Token = "0x4003D13")]
    [FieldOffset(Offset = "0x778")]
    public IntroChapterSequenceMaster IntroChapterSequenceData;
    [Token(Token = "0x4003D14")]
    [FieldOffset(Offset = "0x760")]
    public static string AbilityBoardItemPath;
    [Token(Token = "0x4003D15")]
    [FieldOffset(Offset = "0x780")]
    public AbilityBoardItemMaster AbilityBoardItemData;
    [Token(Token = "0x4003D16")]
    [FieldOffset(Offset = "0x768")]
    public static string AccessoryPiecePath;
    [Token(Token = "0x4003D17")]
    [FieldOffset(Offset = "0x788")]
    public AccessoryPieceMaster AccessoryPieceData;
    [Token(Token = "0x4003D18")]
    [FieldOffset(Offset = "0x770")]
    public static string ArenaBattleTicketPath;
    [Token(Token = "0x4003D19")]
    [FieldOffset(Offset = "0x790")]
    public ArenaBattleTicketMaster ArenaBattleTicketData;
    [Token(Token = "0x4003D1A")]
    [FieldOffset(Offset = "0x778")]
    public static string BossChallengeTicketPath;
    [Token(Token = "0x4003D1B")]
    [FieldOffset(Offset = "0x798")]
    public BossChallengeTicketMaster BossChallengeTicketData;
    [Token(Token = "0x4003D1C")]
    [FieldOffset(Offset = "0x780")]
    public static string BoxItemConstPath;
    [Token(Token = "0x4003D1D")]
    [FieldOffset(Offset = "0x7A0")]
    public BoxItemConstMaster BoxItemConstData;
    [Token(Token = "0x4003D1E")]
    [FieldOffset(Offset = "0x788")]
    public static string BoxItemContentsPath;
    [Token(Token = "0x4003D1F")]
    [FieldOffset(Offset = "0x7A8")]
    public BoxItemContentsMaster BoxItemContentsData;
    [Token(Token = "0x4003D20")]
    [FieldOffset(Offset = "0x790")]
    public static string BoxItemPath;
    [Token(Token = "0x4003D21")]
    [FieldOffset(Offset = "0x7B0")]
    public BoxItemMaster BoxItemData;
    [Token(Token = "0x4003D22")]
    [FieldOffset(Offset = "0x798")]
    public static string ChapterItemPath;
    [Token(Token = "0x4003D23")]
    [FieldOffset(Offset = "0x7B8")]
    public ChapterItemMaster ChapterItemData;
    [Token(Token = "0x4003D24")]
    [FieldOffset(Offset = "0x7A0")]
    public static string CurrencyPath;
    [Token(Token = "0x4003D25")]
    [FieldOffset(Offset = "0x7C0")]
    public CurrencyMaster CurrencyData;
    [Token(Token = "0x4003D26")]
    [FieldOffset(Offset = "0x7A8")]
    public static string EnergyRecoveryPath;
    [Token(Token = "0x4003D27")]
    [FieldOffset(Offset = "0x7C8")]
    public EnergyRecoveryMaster EnergyRecoveryData;
    [Token(Token = "0x4003D28")]
    [FieldOffset(Offset = "0x7B0")]
    public static string EpItemPath;
    [Token(Token = "0x4003D29")]
    [FieldOffset(Offset = "0x7D0")]
    public EpItemMaster EpItemData;
    [Token(Token = "0x4003D2A")]
    [FieldOffset(Offset = "0x7B8")]
    public static string EquipmentSkillEnhancePath;
    [Token(Token = "0x4003D2B")]
    [FieldOffset(Offset = "0x7D8")]
    public EquipmentSkillEnhanceMaster EquipmentSkillEnhanceData;
    [Token(Token = "0x4003D2C")]
    [FieldOffset(Offset = "0x7C0")]
    public static string ExchangePath;
    [Token(Token = "0x4003D2D")]
    [FieldOffset(Offset = "0x7E0")]
    public ExchangeMaster ExchangeData;
    [Token(Token = "0x4003D2E")]
    [FieldOffset(Offset = "0x7C8")]
    public static string ExpeditionRapidTicketPath;
    [Token(Token = "0x4003D2F")]
    [FieldOffset(Offset = "0x7E8")]
    public ExpeditionRapidTicketMaster ExpeditionRapidTicketData;
    [Token(Token = "0x4003D30")]
    [FieldOffset(Offset = "0x7D0")]
    public static string ExpendablesPath;
    [Token(Token = "0x4003D31")]
    [FieldOffset(Offset = "0x7F0")]
    public ExpendablesMaster ExpendablesData;
    [Token(Token = "0x4003D32")]
    [FieldOffset(Offset = "0x7D8")]
    public static string GachaTicketPath;
    [Token(Token = "0x4003D33")]
    [FieldOffset(Offset = "0x7F8")]
    public GachaTicketMaster GachaTicketData;
    [Token(Token = "0x4003D34")]
    [FieldOffset(Offset = "0x7E0")]
    public static string GeneralItemPath;
    [Token(Token = "0x4003D35")]
    [FieldOffset(Offset = "0x800")]
    public GeneralItemMaster GeneralItemData;
    [Token(Token = "0x4003D36")]
    [FieldOffset(Offset = "0x7E8")]
    public static string ItemPossessionLimitPath;
    [Token(Token = "0x4003D37")]
    [FieldOffset(Offset = "0x808")]
    public ItemPossessionLimitMaster ItemPossessionLimitData;
    [Token(Token = "0x4003D38")]
    [FieldOffset(Offset = "0x7F0")]
    public static string MedalPath;
    [Token(Token = "0x4003D39")]
    [FieldOffset(Offset = "0x810")]
    public MedalMaster MedalData;
    [Token(Token = "0x4003D3A")]
    [FieldOffset(Offset = "0x7F8")]
    public static string PersonalEmblemCategoryPath;
    [Token(Token = "0x4003D3B")]
    [FieldOffset(Offset = "0x818")]
    public PersonalEmblemCategoryMaster PersonalEmblemCategoryData;
    [Token(Token = "0x4003D3C")]
    [FieldOffset(Offset = "0x800")]
    public static string PersonalEmblemPath;
    [Token(Token = "0x4003D3D")]
    [FieldOffset(Offset = "0x820")]
    public PersonalEmblemMaster PersonalEmblemData;
    [Token(Token = "0x4003D3E")]
    [FieldOffset(Offset = "0x808")]
    public static string ResourceItemPath;
    [Token(Token = "0x4003D3F")]
    [FieldOffset(Offset = "0x828")]
    public ResourceItemMaster ResourceItemData;
    [Token(Token = "0x4003D40")]
    [FieldOffset(Offset = "0x810")]
    public static string UnitEnhancePath;
    [Token(Token = "0x4003D41")]
    [FieldOffset(Offset = "0x830")]
    public UnitEnhanceMaster UnitEnhanceData;
    [Token(Token = "0x4003D42")]
    [FieldOffset(Offset = "0x818")]
    public static string UnitPiecePath;
    [Token(Token = "0x4003D43")]
    [FieldOffset(Offset = "0x838")]
    public UnitPieceMaster UnitPieceData;
    [Token(Token = "0x4003D44")]
    [FieldOffset(Offset = "0x820")]
    public static string UsageItemPath;
    [Token(Token = "0x4003D45")]
    [FieldOffset(Offset = "0x840")]
    public UsageItemMaster UsageItemData;
    [Token(Token = "0x4003D46")]
    [FieldOffset(Offset = "0x828")]
    public static string UsageNamePath;
    [Token(Token = "0x4003D47")]
    [FieldOffset(Offset = "0x848")]
    public UsageNameMaster UsageNameData;
    [Token(Token = "0x4003D48")]
    [FieldOffset(Offset = "0x830")]
    public static string WeaponPiecePath;
    [Token(Token = "0x4003D49")]
    [FieldOffset(Offset = "0x850")]
    public WeaponPieceMaster WeaponPieceData;
    [Token(Token = "0x4003D4A")]
    [FieldOffset(Offset = "0x838")]
    public static string LobbyFreeActionAreaSettingPath;
    [Token(Token = "0x4003D4B")]
    [FieldOffset(Offset = "0x858")]
    public LobbyFreeActionAreaSettingMaster LobbyFreeActionAreaSettingData;
    [Token(Token = "0x4003D4C")]
    [FieldOffset(Offset = "0x840")]
    public static string LobbyFreeActionConditionsPath;
    [Token(Token = "0x4003D4D")]
    [FieldOffset(Offset = "0x860")]
    public LobbyFreeActionConditionsMaster LobbyFreeActionConditionsData;
    [Token(Token = "0x4003D4E")]
    [FieldOffset(Offset = "0x848")]
    public static string LobbyFreeActionEventPath;
    [Token(Token = "0x4003D4F")]
    [FieldOffset(Offset = "0x868")]
    public LobbyFreeActionEventMaster LobbyFreeActionEventData;
    [Token(Token = "0x4003D50")]
    [FieldOffset(Offset = "0x850")]
    public static string LobbyFreeActionLayoutPath;
    [Token(Token = "0x4003D51")]
    [FieldOffset(Offset = "0x870")]
    public LobbyFreeActionLayoutMaster LobbyFreeActionLayoutData;
    [Token(Token = "0x4003D52")]
    [FieldOffset(Offset = "0x858")]
    public static string LobbyFreeActionLeaderUnitEventPath;
    [Token(Token = "0x4003D53")]
    [FieldOffset(Offset = "0x878")]
    public LobbyFreeActionLeaderUnitEventMaster LobbyFreeActionLeaderUnitEventData;
    [Token(Token = "0x4003D54")]
    [FieldOffset(Offset = "0x860")]
    public static string LobbyFreeActionLeaderUnitLayoutPath;
    [Token(Token = "0x4003D55")]
    [FieldOffset(Offset = "0x880")]
    public LobbyFreeActionLeaderUnitLayoutMaster LobbyFreeActionLeaderUnitLayoutData;
    [Token(Token = "0x4003D56")]
    [FieldOffset(Offset = "0x868")]
    public static string LobbyFreeActionObjectPath;
    [Token(Token = "0x4003D57")]
    [FieldOffset(Offset = "0x888")]
    public LobbyFreeActionObjectMaster LobbyFreeActionObjectData;
    [Token(Token = "0x4003D58")]
    [FieldOffset(Offset = "0x870")]
    public static string LobbySeasonPath;
    [Token(Token = "0x4003D59")]
    [FieldOffset(Offset = "0x890")]
    public LobbySeasonMaster LobbySeasonData;
    [Token(Token = "0x4003D5A")]
    [FieldOffset(Offset = "0x878")]
    public static string LobbySettingPath;
    [Token(Token = "0x4003D5B")]
    [FieldOffset(Offset = "0x898")]
    public LobbySettingMaster LobbySettingData;
    [Token(Token = "0x4003D5C")]
    [FieldOffset(Offset = "0x880")]
    public static string LobbyTimeslotPath;
    [Token(Token = "0x4003D5D")]
    [FieldOffset(Offset = "0x8A0")]
    public LobbyTimeslotMaster LobbyTimeslotData;
    [Token(Token = "0x4003D5E")]
    [FieldOffset(Offset = "0x888")]
    public static string LoginBonusDetailAlwaysPath;
    [Token(Token = "0x4003D5F")]
    [FieldOffset(Offset = "0x8A8")]
    public LoginBonusDetailAlwaysMaster LoginBonusDetailAlwaysData;
    [Token(Token = "0x4003D60")]
    [FieldOffset(Offset = "0x890")]
    public static string LoginBonusRewardDetailPath;
    [Token(Token = "0x4003D61")]
    [FieldOffset(Offset = "0x8B0")]
    public LoginBonusRewardDetailMaster LoginBonusRewardDetailData;
    [Token(Token = "0x4003D62")]
    [FieldOffset(Offset = "0x898")]
    public static string LoginBonusRewardPath;
    [Token(Token = "0x4003D63")]
    [FieldOffset(Offset = "0x8B8")]
    public LoginBonusRewardMaster LoginBonusRewardData;
    [Token(Token = "0x4003D64")]
    [FieldOffset(Offset = "0x8A0")]
    public static string LoginBonusPath;
    [Token(Token = "0x4003D65")]
    [FieldOffset(Offset = "0x8C0")]
    public LoginBonusMaster LoginBonusData;
    [Token(Token = "0x4003D67")]
    [FieldOffset(Offset = "0x8D0")]
    private AdvFriendshipUpTypeMaster advFriendshipUpTypeData;
    [Token(Token = "0x4003D68")]
    [FieldOffset(Offset = "0x8D8")]
    private AdvPersonalUpTypeMaster advPersonalUpTypeData;
    [Token(Token = "0x4003D69")]
    [FieldOffset(Offset = "0x8E0")]
    private ChatPollingIntervalMaster chatPollingIntervalData;
    [Token(Token = "0x4003D6A")]
    [FieldOffset(Offset = "0x8E8")]
    private RangeShapeDetailMaster rangeShapeDetailData;
    [Token(Token = "0x4003D6B")]
    [FieldOffset(Offset = "0x8F0")]
    private TutorialMaster tutorialData;
    [Token(Token = "0x4003D6C")]
    [FieldOffset(Offset = "0x8A8")]
    public static string MissionAchievementConditionPath;
    [Token(Token = "0x4003D6D")]
    [FieldOffset(Offset = "0x8F8")]
    public MissionAchievementConditionMaster MissionAchievementConditionData;
    [Token(Token = "0x4003D6E")]
    [FieldOffset(Offset = "0x8B0")]
    public static string MissionConstPath;
    [Token(Token = "0x4003D6F")]
    [FieldOffset(Offset = "0x900")]
    public MissionConstMaster MissionConstData;
    [Token(Token = "0x4003D70")]
    [FieldOffset(Offset = "0x8B8")]
    public static string MissionGroupPath;
    [Token(Token = "0x4003D71")]
    [FieldOffset(Offset = "0x908")]
    public MissionGroupMaster MissionGroupData;
    [Token(Token = "0x4003D72")]
    [FieldOffset(Offset = "0x8C0")]
    public static string MissionProgressRewardDescriptionPath;
    [Token(Token = "0x4003D73")]
    [FieldOffset(Offset = "0x910")]
    public MissionProgressRewardDescriptionMaster MissionProgressRewardDescriptionData;
    [Token(Token = "0x4003D74")]
    [FieldOffset(Offset = "0x8C8")]
    public static string MissionProgressRewardPath;
    [Token(Token = "0x4003D75")]
    [FieldOffset(Offset = "0x918")]
    public MissionProgressRewardMaster MissionProgressRewardData;
    [Token(Token = "0x4003D76")]
    [FieldOffset(Offset = "0x8D0")]
    public static string MissionRewardPath;
    [Token(Token = "0x4003D77")]
    [FieldOffset(Offset = "0x920")]
    public MissionRewardMaster MissionRewardData;
    [Token(Token = "0x4003D78")]
    [FieldOffset(Offset = "0x8D8")]
    public static string MissionSchedulePath;
    [Token(Token = "0x4003D79")]
    [FieldOffset(Offset = "0x928")]
    public MissionScheduleMaster MissionScheduleData;
    [Token(Token = "0x4003D7A")]
    [FieldOffset(Offset = "0x8E0")]
    public static string MissionPath;
    [Token(Token = "0x4003D7B")]
    [FieldOffset(Offset = "0x930")]
    public MissionMaster MissionData;
    [Token(Token = "0x4003D7C")]
    [FieldOffset(Offset = "0x8E8")]
    public static string MissionUnlockDescriptionPath;
    [Token(Token = "0x4003D7D")]
    [FieldOffset(Offset = "0x938")]
    public MissionUnlockDescriptionMaster MissionUnlockDescriptionData;
    [Token(Token = "0x4003D7E")]
    [FieldOffset(Offset = "0x8F0")]
    public static string MissionUnlockPath;
    [Token(Token = "0x4003D7F")]
    [FieldOffset(Offset = "0x940")]
    public MissionUnlockMaster MissionUnlockData;
    [Token(Token = "0x4003D80")]
    [FieldOffset(Offset = "0x8F8")]
    public static string PanelMissionPath;
    [Token(Token = "0x4003D81")]
    [FieldOffset(Offset = "0x948")]
    public PanelMissionMaster PanelMissionData;
    [Token(Token = "0x4003D82")]
    [FieldOffset(Offset = "0x900")]
    public static string TotalMissionDetailPath;
    [Token(Token = "0x4003D83")]
    [FieldOffset(Offset = "0x950")]
    public TotalMissionDetailMaster TotalMissionDetailData;
    [Token(Token = "0x4003D84")]
    [FieldOffset(Offset = "0x908")]
    public static string TotalMissionEventPath;
    [Token(Token = "0x4003D85")]
    [FieldOffset(Offset = "0x958")]
    public TotalMissionEventMaster TotalMissionEventData;
    [Token(Token = "0x4003D86")]
    [FieldOffset(Offset = "0x910")]
    public static string TotalMissionRewardDetailPath;
    [Token(Token = "0x4003D87")]
    [FieldOffset(Offset = "0x960")]
    public TotalMissionRewardDetailMaster TotalMissionRewardDetailData;
    [Token(Token = "0x4003D88")]
    [FieldOffset(Offset = "0x918")]
    public static string TotalMissionRewardPath;
    [Token(Token = "0x4003D89")]
    [FieldOffset(Offset = "0x968")]
    public TotalMissionRewardMaster TotalMissionRewardData;
    [Token(Token = "0x4003D8A")]
    [FieldOffset(Offset = "0x920")]
    public static string TotalMissionTabPath;
    [Token(Token = "0x4003D8B")]
    [FieldOffset(Offset = "0x970")]
    public TotalMissionTabMaster TotalMissionTabData;
    [Token(Token = "0x4003D8C")]
    [FieldOffset(Offset = "0x928")]
    public static string ApPaymentPath;
    [Token(Token = "0x4003D8D")]
    [FieldOffset(Offset = "0x978")]
    public ApPaymentMaster ApPaymentData;
    [Token(Token = "0x4003D8E")]
    [FieldOffset(Offset = "0x930")]
    public static string PlayerApPath;
    [Token(Token = "0x4003D8F")]
    [FieldOffset(Offset = "0x980")]
    public PlayerApMaster PlayerApData;
    [Token(Token = "0x4003D90")]
    [FieldOffset(Offset = "0x938")]
    public static string PlayerAvatarPath;
    [Token(Token = "0x4003D91")]
    [FieldOffset(Offset = "0x988")]
    public PlayerAvatarMaster PlayerAvatarData;
    [Token(Token = "0x4003D92")]
    [FieldOffset(Offset = "0x940")]
    public static string PlayerConstPath;
    [Token(Token = "0x4003D93")]
    [FieldOffset(Offset = "0x990")]
    public PlayerConstMaster PlayerConstData;
    [Token(Token = "0x4003D94")]
    [FieldOffset(Offset = "0x948")]
    public static string PlayerExpPath;
    [Token(Token = "0x4003D95")]
    [FieldOffset(Offset = "0x998")]
    public PlayerExpMaster PlayerExpData;
    [Token(Token = "0x4003D96")]
    [FieldOffset(Offset = "0x950")]
    public static string PlayerTitlePath;
    [Token(Token = "0x4003D97")]
    [FieldOffset(Offset = "0x9A0")]
    public PlayerTitleMaster PlayerTitleData;
    [Token(Token = "0x4003D98")]
    [FieldOffset(Offset = "0x958")]
    public static string RewardPassPath;
    [Token(Token = "0x4003D99")]
    [FieldOffset(Offset = "0x9A8")]
    public RewardPassMaster RewardPassData;
    [Token(Token = "0x4003D9A")]
    [FieldOffset(Offset = "0x960")]
    public static string StyleMasterBonusConditionPath;
    [Token(Token = "0x4003D9B")]
    [FieldOffset(Offset = "0x9B0")]
    public StyleMasterBonusConditionMaster StyleMasterBonusConditionData;
    [Token(Token = "0x4003D9C")]
    [FieldOffset(Offset = "0x968")]
    public static string StyleMasterBonusDescriptionPath;
    [Token(Token = "0x4003D9D")]
    [FieldOffset(Offset = "0x9B8")]
    public StyleMasterBonusDescriptionMaster StyleMasterBonusDescriptionData;
    [Token(Token = "0x4003D9E")]
    [FieldOffset(Offset = "0x970")]
    public static string StyleMasterBonusExpDescriptionPath;
    [Token(Token = "0x4003D9F")]
    [FieldOffset(Offset = "0x9C0")]
    public StyleMasterBonusExpDescriptionMaster StyleMasterBonusExpDescriptionData;
    [Token(Token = "0x4003DA0")]
    [FieldOffset(Offset = "0x978")]
    public static string StyleMasterBonusPath;
    [Token(Token = "0x4003DA1")]
    [FieldOffset(Offset = "0x9C8")]
    public StyleMasterBonusMaster StyleMasterBonusData;
    [Token(Token = "0x4003DA2")]
    [FieldOffset(Offset = "0x980")]
    public static string WeaponMasterBonusDescriptionPath;
    [Token(Token = "0x4003DA3")]
    [FieldOffset(Offset = "0x9D0")]
    public WeaponMasterBonusDescriptionMaster WeaponMasterBonusDescriptionData;
    [Token(Token = "0x4003DA4")]
    [FieldOffset(Offset = "0x988")]
    public static string WeaponMasterBonusExpPath;
    [Token(Token = "0x4003DA5")]
    [FieldOffset(Offset = "0x9D8")]
    public WeaponMasterBonusExpMaster WeaponMasterBonusExpData;
    [Token(Token = "0x4003DA6")]
    [FieldOffset(Offset = "0x990")]
    public static string WeaponMasterBonusGainExpPath;
    [Token(Token = "0x4003DA7")]
    [FieldOffset(Offset = "0x9E0")]
    public WeaponMasterBonusGainExpMaster WeaponMasterBonusGainExpData;
    [Token(Token = "0x4003DA8")]
    [FieldOffset(Offset = "0x998")]
    public static string WeaponMasterBonusPath;
    [Token(Token = "0x4003DA9")]
    [FieldOffset(Offset = "0x9E8")]
    public WeaponMasterBonusMaster WeaponMasterBonusData;
    [Token(Token = "0x4003DAA")]
    [FieldOffset(Offset = "0x9A0")]
    public static string PreHomeEventAdvContentPath;
    [Token(Token = "0x4003DAB")]
    [FieldOffset(Offset = "0x9F0")]
    public PreHomeEventAdvContentMaster PreHomeEventAdvContentData;
    [Token(Token = "0x4003DAC")]
    [FieldOffset(Offset = "0x9A8")]
    public static string PreHomeEventPath;
    [Token(Token = "0x4003DAD")]
    [FieldOffset(Offset = "0x9F8")]
    public PreHomeEventMaster PreHomeEventData;
    [Token(Token = "0x4003DAE")]
    [FieldOffset(Offset = "0x9B0")]
    public static string AreaQuestAreaGroupReleaseConditionDescriptionPath;
    [Token(Token = "0x4003DAF")]
    [FieldOffset(Offset = "0xA00")]
    public AreaQuestAreaGroupReleaseConditionDescriptionMaster AreaQuestAreaGroupReleaseConditionDescriptionData;
    [Token(Token = "0x4003DB0")]
    [FieldOffset(Offset = "0x9B8")]
    public static string AreaQuestAreaGroupPath;
    [Token(Token = "0x4003DB1")]
    [FieldOffset(Offset = "0xA08")]
    public AreaQuestAreaGroupMaster AreaQuestAreaGroupData;
    [Token(Token = "0x4003DB2")]
    [FieldOffset(Offset = "0x9C0")]
    public static string AreaQuestAreaNodeNormalDescriptionPath;
    [Token(Token = "0x4003DB3")]
    [FieldOffset(Offset = "0xA10")]
    public AreaQuestAreaNodeNormalDescriptionMaster AreaQuestAreaNodeNormalDescriptionData;
    [Token(Token = "0x4003DB4")]
    [FieldOffset(Offset = "0x9C8")]
    public static string AreaQuestAreaNodeQuestPath;
    [Token(Token = "0x4003DB5")]
    [FieldOffset(Offset = "0xA18")]
    public AreaQuestAreaNodeQuestMaster AreaQuestAreaNodeQuestData;
    [Token(Token = "0x4003DB6")]
    [FieldOffset(Offset = "0x9D0")]
    public static string AreaQuestAreaNodeReleaseConditionDescriptionPath;
    [Token(Token = "0x4003DB7")]
    [FieldOffset(Offset = "0xA20")]
    public AreaQuestAreaNodeReleaseConditionDescriptionMaster AreaQuestAreaNodeReleaseConditionDescriptionData;
    [Token(Token = "0x4003DB8")]
    [FieldOffset(Offset = "0x9D8")]
    public static string AreaQuestAreaNodeShortcutPath;
    [Token(Token = "0x4003DB9")]
    [FieldOffset(Offset = "0xA28")]
    public AreaQuestAreaNodeShortcutMaster AreaQuestAreaNodeShortcutData;
    [Token(Token = "0x4003DBA")]
    [FieldOffset(Offset = "0x9E0")]
    public static string AreaQuestAreaNodePath;
    [Token(Token = "0x4003DBB")]
    [FieldOffset(Offset = "0xA30")]
    public AreaQuestAreaNodeMaster AreaQuestAreaNodeData;
    [Token(Token = "0x4003DBC")]
    [FieldOffset(Offset = "0x9E8")]
    public static string AreaQuestAreaReleaseConditionDescriptionPath;
    [Token(Token = "0x4003DBD")]
    [FieldOffset(Offset = "0xA38")]
    public AreaQuestAreaReleaseConditionDescriptionMaster AreaQuestAreaReleaseConditionDescriptionData;
    [Token(Token = "0x4003DBE")]
    [FieldOffset(Offset = "0x9F0")]
    public static string AreaQuestAreaReleaseConditionPath;
    [Token(Token = "0x4003DBF")]
    [FieldOffset(Offset = "0xA40")]
    public AreaQuestAreaReleaseConditionMaster AreaQuestAreaReleaseConditionData;
    [Token(Token = "0x4003DC0")]
    [FieldOffset(Offset = "0x9F8")]
    public static string AreaQuestAreaPath;
    [Token(Token = "0x4003DC1")]
    [FieldOffset(Offset = "0xA48")]
    public AreaQuestAreaMaster AreaQuestAreaData;
    [Token(Token = "0x4003DC2")]
    [FieldOffset(Offset = "0xA00")]
    public static string AreaQuestEventPagePath;
    [Token(Token = "0x4003DC3")]
    [FieldOffset(Offset = "0xA50")]
    public AreaQuestEventPageMaster AreaQuestEventPageData;
    [Token(Token = "0x4003DC4")]
    [FieldOffset(Offset = "0xA08")]
    public static string ClearTurnScorePath;
    [Token(Token = "0x4003DC5")]
    [FieldOffset(Offset = "0xA58")]
    public ClearTurnScoreMaster ClearTurnScoreData;
    [Token(Token = "0x4003DC6")]
    [FieldOffset(Offset = "0xA10")]
    public static string ScoreAttackRewardGroupPath;
    [Token(Token = "0x4003DC7")]
    [FieldOffset(Offset = "0xA60")]
    public ScoreAttackRewardGroupMaster ScoreAttackRewardGroupData;
    [Token(Token = "0x4003DC8")]
    [FieldOffset(Offset = "0xA18")]
    public static string DifficultyScorePath;
    [Token(Token = "0x4003DC9")]
    [FieldOffset(Offset = "0xA68")]
    public DifficultyScoreMaster DifficultyScoreData;
    [Token(Token = "0x4003DCA")]
    [FieldOffset(Offset = "0xA20")]
    public static string DifficultyPath;
    [Token(Token = "0x4003DCB")]
    [FieldOffset(Offset = "0xA70")]
    public DifficultyMaster DifficultyData;
    [Token(Token = "0x4003DCC")]
    [FieldOffset(Offset = "0xA28")]
    public static string EventMissionCharacterPath;
    [Token(Token = "0x4003DCD")]
    [FieldOffset(Offset = "0xA78")]
    public EventMissionCharacterMaster EventMissionCharacterData;
    [Token(Token = "0x4003DCE")]
    [FieldOffset(Offset = "0xA30")]
    public static string EventQuestSchedulePath;
    [Token(Token = "0x4003DCF")]
    [FieldOffset(Offset = "0xA80")]
    public EventQuestScheduleMaster EventQuestScheduleData;
    [Token(Token = "0x4003DD0")]
    [FieldOffset(Offset = "0xA38")]
    public static string FreeQuestSchedulePath;
    [Token(Token = "0x4003DD1")]
    [FieldOffset(Offset = "0xA88")]
    public FreeQuestScheduleMaster FreeQuestScheduleData;
    [Token(Token = "0x4003DD2")]
    [FieldOffset(Offset = "0xA40")]
    public static string GuildRaidStagePath;
    [Token(Token = "0x4003DD3")]
    [FieldOffset(Offset = "0xA90")]
    public GuildRaidStageMaster GuildRaidStageData;
    [Token(Token = "0x4003DD4")]
    [FieldOffset(Offset = "0xA48")]
    public static string KilledSpecifiedUnitScorePath;
    [Token(Token = "0x4003DD5")]
    [FieldOffset(Offset = "0xA98")]
    public KilledSpecifiedUnitScoreMaster KilledSpecifiedUnitScoreData;
    [Token(Token = "0x4003DD6")]
    [FieldOffset(Offset = "0xA50")]
    public static string LimitedEventQuestStagePath;
    [Token(Token = "0x4003DD7")]
    [FieldOffset(Offset = "0xAA0")]
    public LimitedEventQuestStageMaster LimitedEventQuestStageData;
    [Token(Token = "0x4003DD8")]
    [FieldOffset(Offset = "0xA58")]
    public static string LimitedEventPath;
    [Token(Token = "0x4003DD9")]
    [FieldOffset(Offset = "0xAA8")]
    public LimitedEventMaster LimitedEventData;
    [Token(Token = "0x4003DDA")]
    [FieldOffset(Offset = "0xA60")]
    public static string QuestCorrectionPath;
    [Token(Token = "0x4003DDB")]
    [FieldOffset(Offset = "0xAB0")]
    public QuestCorrectionMaster QuestCorrectionData;
    [Token(Token = "0x4003DDC")]
    [FieldOffset(Offset = "0xA68")]
    public static string QuestMapPositionPath;
    [Token(Token = "0x4003DDD")]
    [FieldOffset(Offset = "0xAB8")]
    public QuestMapPositionMaster QuestMapPositionData;
    [Token(Token = "0x4003DDE")]
    [FieldOffset(Offset = "0xA70")]
    public static string QuestStagePath;
    [Token(Token = "0x4003DDF")]
    [FieldOffset(Offset = "0xAC0")]
    public QuestStageMaster QuestStageData;
    [Token(Token = "0x4003DE0")]
    [FieldOffset(Offset = "0xA78")]
    public static string RaidQuestPath;
    [Token(Token = "0x4003DE1")]
    [FieldOffset(Offset = "0xAC8")]
    public RaidQuestMaster RaidQuestData;
    [Token(Token = "0x4003DE2")]
    [FieldOffset(Offset = "0xA80")]
    public static string ScenarioQuestSchedulePath;
    [Token(Token = "0x4003DE3")]
    [FieldOffset(Offset = "0xAD0")]
    public ScenarioQuestScheduleMaster ScenarioQuestScheduleData;
    [Token(Token = "0x4003DE4")]
    [FieldOffset(Offset = "0xA88")]
    public static string ScoreAttackDetailPath;
    [Token(Token = "0x4003DE5")]
    [FieldOffset(Offset = "0xAD8")]
    public ScoreAttackDetailMaster ScoreAttackDetailData;
    [Token(Token = "0x4003DE6")]
    [FieldOffset(Offset = "0xA90")]
    public static string ScoreAttackEventPath;
    [Token(Token = "0x4003DE7")]
    [FieldOffset(Offset = "0xAE0")]
    public ScoreAttackEventMaster ScoreAttackEventData;
    [Token(Token = "0x4003DE8")]
    [FieldOffset(Offset = "0xA98")]
    public static string ScoreAttackQuestPath;
    [Token(Token = "0x4003DE9")]
    [FieldOffset(Offset = "0xAE8")]
    public ScoreAttackQuestMaster ScoreAttackQuestData;
    [Token(Token = "0x4003DEA")]
    [FieldOffset(Offset = "0xAA0")]
    public static string ScoreAttackRankingRewardSetPath;
    [Token(Token = "0x4003DEB")]
    [FieldOffset(Offset = "0xAF0")]
    public ScoreAttackRankingRewardSetMaster ScoreAttackRankingRewardSetData;
    [Token(Token = "0x4003DEC")]
    [FieldOffset(Offset = "0xAA8")]
    public static string ScoreAttackRankingRewardPath;
    [Token(Token = "0x4003DED")]
    [FieldOffset(Offset = "0xAF8")]
    public ScoreAttackRankingRewardMaster ScoreAttackRankingRewardData;
    [Token(Token = "0x4003DEE")]
    [FieldOffset(Offset = "0xAB0")]
    public static string ScoreAttackScoreRewardSetPath;
    [Token(Token = "0x4003DEF")]
    [FieldOffset(Offset = "0xB00")]
    public ScoreAttackScoreRewardSetMaster ScoreAttackScoreRewardSetData;
    [Token(Token = "0x4003DF0")]
    [FieldOffset(Offset = "0xAB8")]
    public static string ScoreAttackScoreRewardPath;
    [Token(Token = "0x4003DF1")]
    [FieldOffset(Offset = "0xB08")]
    public ScoreAttackScoreRewardMaster ScoreAttackScoreRewardData;
    [Token(Token = "0x4003DF2")]
    [FieldOffset(Offset = "0xAC0")]
    public static string SpecialPeriodPath;
    [Token(Token = "0x4003DF3")]
    [FieldOffset(Offset = "0xB10")]
    public SpecialPeriodMaster SpecialPeriodData;
    [Token(Token = "0x4003DF4")]
    [FieldOffset(Offset = "0xAC8")]
    public static string SpecialQuestStagePath;
    [Token(Token = "0x4003DF5")]
    [FieldOffset(Offset = "0xB18")]
    public SpecialQuestStageMaster SpecialQuestStageData;
    [Token(Token = "0x4003DF6")]
    [FieldOffset(Offset = "0xAD0")]
    public static string SpecialQuestPath;
    [Token(Token = "0x4003DF7")]
    [FieldOffset(Offset = "0xB20")]
    public SpecialQuestMaster SpecialQuestData;
    [Token(Token = "0x4003DF8")]
    [FieldOffset(Offset = "0xAD8")]
    public static string StageLevelPath;
    [Token(Token = "0x4003DF9")]
    [FieldOffset(Offset = "0xB28")]
    public StageLevelMaster StageLevelData;
    [Token(Token = "0x4003DFA")]
    [FieldOffset(Offset = "0xAE0")]
    public static string StoryFreeQuestPath;
    [Token(Token = "0x4003DFB")]
    [FieldOffset(Offset = "0xB30")]
    public StoryFreeQuestMaster StoryFreeQuestData;
    [Token(Token = "0x4003DFC")]
    [FieldOffset(Offset = "0xAE8")]
    public static string StoryMainHardSelectConditionDescriptionPath;
    [Token(Token = "0x4003DFD")]
    [FieldOffset(Offset = "0xB38")]
    public StoryMainHardSelectConditionDescriptionMaster StoryMainHardSelectConditionDescriptionData;
    [Token(Token = "0x4003DFE")]
    [FieldOffset(Offset = "0xAF0")]
    public static string StoryMainQuestPath;
    [Token(Token = "0x4003DFF")]
    [FieldOffset(Offset = "0xB40")]
    public StoryMainQuestMaster StoryMainQuestData;
    [Token(Token = "0x4003E00")]
    [FieldOffset(Offset = "0xAF8")]
    public static string StoryObliviaeQuestPath;
    [Token(Token = "0x4003E01")]
    [FieldOffset(Offset = "0xB48")]
    public StoryObliviaeQuestMaster StoryObliviaeQuestData;
    [Token(Token = "0x4003E02")]
    [FieldOffset(Offset = "0xB00")]
    public static string StoryScenarioQuestFreePath;
    [Token(Token = "0x4003E03")]
    [FieldOffset(Offset = "0xB50")]
    public StoryScenarioQuestFreeMaster StoryScenarioQuestFreeData;
    [Token(Token = "0x4003E04")]
    [FieldOffset(Offset = "0xB08")]
    public static string StoryScenarioQuestMainPath;
    [Token(Token = "0x4003E05")]
    [FieldOffset(Offset = "0xB58")]
    public StoryScenarioQuestMainMaster StoryScenarioQuestMainData;
    [Token(Token = "0x4003E06")]
    [FieldOffset(Offset = "0xB10")]
    public static string StoryScenarioQuestSubPath;
    [Token(Token = "0x4003E07")]
    [FieldOffset(Offset = "0xB60")]
    public StoryScenarioQuestSubMaster StoryScenarioQuestSubData;
    [Token(Token = "0x4003E08")]
    [FieldOffset(Offset = "0xB18")]
    public static string StorySubQuestPath;
    [Token(Token = "0x4003E09")]
    [FieldOffset(Offset = "0xB68")]
    public StorySubQuestMaster StorySubQuestData;
    [Token(Token = "0x4003E0A")]
    [FieldOffset(Offset = "0xB20")]
    public static string UseItemScorePath;
    [Token(Token = "0x4003E0B")]
    [FieldOffset(Offset = "0xB70")]
    public UseItemScoreMaster UseItemScoreData;
    [Token(Token = "0x4003E0C")]
    [FieldOffset(Offset = "0xB28")]
    public static string MedalTradeItemPath;
    [Token(Token = "0x4003E0D")]
    [FieldOffset(Offset = "0xB78")]
    public MedalTradeItemMaster MedalTradeItemData;
    [Token(Token = "0x4003E0E")]
    [FieldOffset(Offset = "0xB30")]
    public static string MedalTradePrizeResetPath;
    [Token(Token = "0x4003E0F")]
    [FieldOffset(Offset = "0xB80")]
    public MedalTradePrizeResetMaster MedalTradePrizeResetData;
    [Token(Token = "0x4003E10")]
    [FieldOffset(Offset = "0xB38")]
    public static string MedalTradePrizePath;
    [Token(Token = "0x4003E11")]
    [FieldOffset(Offset = "0xB88")]
    public MedalTradePrizeMaster MedalTradePrizeData;
    [Token(Token = "0x4003E12")]
    [FieldOffset(Offset = "0xB40")]
    public static string MedalTradeShopPath;
    [Token(Token = "0x4003E13")]
    [FieldOffset(Offset = "0xB90")]
    public MedalTradeShopMaster MedalTradeShopData;
    [Token(Token = "0x4003E14")]
    [FieldOffset(Offset = "0xB48")]
    public static string MedalTradeUsableMedalListPath;
    [Token(Token = "0x4003E15")]
    [FieldOffset(Offset = "0xB98")]
    public MedalTradeUsableMedalListMaster MedalTradeUsableMedalListData;
    [Token(Token = "0x4003E16")]
    [FieldOffset(Offset = "0xB50")]
    public static string ShopConstPath;
    [Token(Token = "0x4003E17")]
    [FieldOffset(Offset = "0xBA0")]
    public ShopConstMaster ShopConstData;
    [Token(Token = "0x4003E18")]
    [FieldOffset(Offset = "0xB58")]
    public static string ShopLayoutPath;
    [Token(Token = "0x4003E19")]
    [FieldOffset(Offset = "0xBA8")]
    public ShopLayoutMaster ShopLayoutData;
    [Token(Token = "0x4003E1A")]
    [FieldOffset(Offset = "0xB60")]
    public static string ShopRelatedChapterPath;
    [Token(Token = "0x4003E1B")]
    [FieldOffset(Offset = "0xBB0")]
    public ShopRelatedChapterMaster ShopRelatedChapterData;
    [Token(Token = "0x4003E1C")]
    [FieldOffset(Offset = "0xB68")]
    public static string StoryShopArticlePath;
    [Token(Token = "0x4003E1D")]
    [FieldOffset(Offset = "0xBB8")]
    public StoryShopArticleMaster StoryShopArticleData;
    [Token(Token = "0x4003E1E")]
    [FieldOffset(Offset = "0xB70")]
    public static string StoryShopGrowthPath;
    [Token(Token = "0x4003E1F")]
    [FieldOffset(Offset = "0xBC0")]
    public StoryShopGrowthMaster StoryShopGrowthData;
    [Token(Token = "0x4003E20")]
    [FieldOffset(Offset = "0xB78")]
    public static string StoryShopGrowthTypePath;
    [Token(Token = "0x4003E21")]
    [FieldOffset(Offset = "0xBC8")]
    public StoryShopGrowthTypeMaster StoryShopGrowthTypeData;
    [Token(Token = "0x4003E22")]
    [FieldOffset(Offset = "0xB80")]
    public static string StoryShopLevelPath;
    [Token(Token = "0x4003E23")]
    [FieldOffset(Offset = "0xBD0")]
    public StoryShopLevelMaster StoryShopLevelData;
    [Token(Token = "0x4003E24")]
    [FieldOffset(Offset = "0xB88")]
    public static string StoryShopPurchaseLimitTypePath;
    [Token(Token = "0x4003E25")]
    [FieldOffset(Offset = "0xBD8")]
    public StoryShopPurchaseLimitTypeMaster StoryShopPurchaseLimitTypeData;
    [Token(Token = "0x4003E26")]
    [FieldOffset(Offset = "0xB90")]
    public static string AlignmentStratagemSettingsPath;
    [Token(Token = "0x4003E27")]
    [FieldOffset(Offset = "0xBE0")]
    public AlignmentStratagemSettingsMaster AlignmentStratagemSettingsData;
    [Token(Token = "0x4003E28")]
    [FieldOffset(Offset = "0xB98")]
    public static string CustomSkillCategoryPath;
    [Token(Token = "0x4003E29")]
    [FieldOffset(Offset = "0xBE8")]
    public CustomSkillCategoryMaster CustomSkillCategoryData;
    [Token(Token = "0x4003E2A")]
    [FieldOffset(Offset = "0xBA0")]
    public static string CustomSkillCostPath;
    [Token(Token = "0x4003E2B")]
    [FieldOffset(Offset = "0xBF0")]
    public CustomSkillCostMaster CustomSkillCostData;
    [Token(Token = "0x4003E2C")]
    [FieldOffset(Offset = "0xBA8")]
    public static string CustomSkillPath;
    [Token(Token = "0x4003E2D")]
    [FieldOffset(Offset = "0xBF8")]
    public CustomSkillMaster CustomSkillData;
    [Token(Token = "0x4003E2E")]
    [FieldOffset(Offset = "0xBB0")]
    public static string CustomSkillTypeEquipmentLimitPath;
    [Token(Token = "0x4003E2F")]
    [FieldOffset(Offset = "0xC00")]
    public CustomSkillTypeEquipmentLimitMaster CustomSkillTypeEquipmentLimitData;
    [Token(Token = "0x4003E30")]
    [FieldOffset(Offset = "0xBB8")]
    public static string EffectDetailPath;
    [Token(Token = "0x4003E31")]
    [FieldOffset(Offset = "0xC08")]
    public EffectDetailMaster EffectDetailData;
    [Token(Token = "0x4003E32")]
    [FieldOffset(Offset = "0xBC0")]
    public static string RangeShapePath;
    [Token(Token = "0x4003E33")]
    [FieldOffset(Offset = "0xC10")]
    public RangeShapeMaster RangeShapeData;
    [Token(Token = "0x4003E34")]
    [FieldOffset(Offset = "0xBC8")]
    public static string SkillDetailPath;
    [Token(Token = "0x4003E35")]
    [FieldOffset(Offset = "0xC18")]
    public SkillDetailMaster SkillDetailData;
    [Token(Token = "0x4003E36")]
    [FieldOffset(Offset = "0xBD0")]
    public static string SkillExpDescriptionPath;
    [Token(Token = "0x4003E37")]
    [FieldOffset(Offset = "0xC20")]
    public SkillExpDescriptionMaster SkillExpDescriptionData;
    [Token(Token = "0x4003E38")]
    [FieldOffset(Offset = "0xBD8")]
    public static string SkillPath;
    [Token(Token = "0x4003E39")]
    [FieldOffset(Offset = "0xC28")]
    public SkillMaster SkillData;
    [Token(Token = "0x4003E3A")]
    [FieldOffset(Offset = "0xBE0")]
    public static string SkillTagsDetailPath;
    [Token(Token = "0x4003E3B")]
    [FieldOffset(Offset = "0xC30")]
    public SkillTagsDetailMaster SkillTagsDetailData;
    [Token(Token = "0x4003E3C")]
    [FieldOffset(Offset = "0xBE8")]
    public static string SkillTriggerConditionDetailPath;
    [Token(Token = "0x4003E3D")]
    [FieldOffset(Offset = "0xC38")]
    public SkillTriggerConditionDetailMaster SkillTriggerConditionDetailData;
    [Token(Token = "0x4003E3E")]
    [FieldOffset(Offset = "0xBF0")]
    public static string SupportSkillActivateRatePath;
    [Token(Token = "0x4003E3F")]
    [FieldOffset(Offset = "0xC40")]
    public SupportSkillActivateRateMaster SupportSkillActivateRateData;
    [Token(Token = "0x4003E40")]
    [FieldOffset(Offset = "0xBF8")]
    public static string SupportSkillDetailPath;
    [Token(Token = "0x4003E41")]
    [FieldOffset(Offset = "0xC48")]
    public SupportSkillDetailMaster SupportSkillDetailData;
    [Token(Token = "0x4003E42")]
    [FieldOffset(Offset = "0xC00")]
    public static string StoryAbilityPath;
    [Token(Token = "0x4003E43")]
    [FieldOffset(Offset = "0xC50")]
    public StoryAbilityMaster StoryAbilityData;
    [Token(Token = "0x4003E44")]
    [FieldOffset(Offset = "0xC08")]
    public static string StoryAreaMovableBuildSettingPath;
    [Token(Token = "0x4003E45")]
    [FieldOffset(Offset = "0xC58")]
    public StoryAreaMovableBuildSettingMaster StoryAreaMovableBuildSettingData;
    [Token(Token = "0x4003E46")]
    [FieldOffset(Offset = "0xC10")]
    public static string StoryAreaMovableGroupPatternPath;
    [Token(Token = "0x4003E47")]
    [FieldOffset(Offset = "0xC60")]
    public StoryAreaMovableGroupPatternMaster StoryAreaMovableGroupPatternData;
    [Token(Token = "0x4003E48")]
    [FieldOffset(Offset = "0xC18")]
    public static string StoryAreaMovableSettingPath;
    [Token(Token = "0x4003E49")]
    [FieldOffset(Offset = "0xC68")]
    public StoryAreaMovableSettingMaster StoryAreaMovableSettingData;
    [Token(Token = "0x4003E4A")]
    [FieldOffset(Offset = "0xC20")]
    public static string StoryAreaMovableSoundEffectPath;
    [Token(Token = "0x4003E4B")]
    [FieldOffset(Offset = "0xC70")]
    public StoryAreaMovableSoundEffectMaster StoryAreaMovableSoundEffectData;
    [Token(Token = "0x4003E4C")]
    [FieldOffset(Offset = "0xC28")]
    public static string StoryAreaMovableSpawnPatternPath;
    [Token(Token = "0x4003E4D")]
    [FieldOffset(Offset = "0xC78")]
    public StoryAreaMovableSpawnPatternMaster StoryAreaMovableSpawnPatternData;
    [Token(Token = "0x4003E4E")]
    [FieldOffset(Offset = "0xC30")]
    public static string StoryAreaMovableSwitchingPatternPath;
    [Token(Token = "0x4003E4F")]
    [FieldOffset(Offset = "0xC80")]
    public StoryAreaMovableSwitchingPatternMaster StoryAreaMovableSwitchingPatternData;
    [Token(Token = "0x4003E50")]
    [FieldOffset(Offset = "0xC38")]
    public static string StoryAreaEventQuestRewardPaymentPath;
    [Token(Token = "0x4003E51")]
    [FieldOffset(Offset = "0xC88")]
    public StoryAreaEventQuestRewardPaymentMaster StoryAreaEventQuestRewardPaymentData;
    [Token(Token = "0x4003E52")]
    [FieldOffset(Offset = "0xC40")]
    public static string StoryAreaEventQuestPath;
    [Token(Token = "0x4003E53")]
    [FieldOffset(Offset = "0xC90")]
    public StoryAreaEventQuestMaster StoryAreaEventQuestData;
    [Token(Token = "0x4003E54")]
    [FieldOffset(Offset = "0xC48")]
    public static string StoryAreaEventQuestTaskFlagPath;
    [Token(Token = "0x4003E55")]
    [FieldOffset(Offset = "0xC98")]
    public StoryAreaEventQuestTaskFlagMaster StoryAreaEventQuestTaskFlagData;
    [Token(Token = "0x4003E56")]
    [FieldOffset(Offset = "0xC50")]
    public static string StoryAreaEventQuestTaskPath;
    [Token(Token = "0x4003E57")]
    [FieldOffset(Offset = "0xCA0")]
    public StoryAreaEventQuestTaskMaster StoryAreaEventQuestTaskData;
    [Token(Token = "0x4003E58")]
    [FieldOffset(Offset = "0xC58")]
    public static string StoryAreaEventQuestTaskTextPath;
    [Token(Token = "0x4003E59")]
    [FieldOffset(Offset = "0xCA8")]
    public StoryAreaEventQuestTaskTextMaster StoryAreaEventQuestTaskTextData;
    [Token(Token = "0x4003E5A")]
    [FieldOffset(Offset = "0xC60")]
    public static string StoryCharacterBuildDataPath;
    [Token(Token = "0x4003E5B")]
    [FieldOffset(Offset = "0xCB0")]
    public StoryCharacterBuildDataMaster StoryCharacterBuildDataData;
    [Token(Token = "0x4003E5C")]
    [FieldOffset(Offset = "0xC68")]
    public static string StoryCharacterSwitchingPatternPath;
    [Token(Token = "0x4003E5D")]
    [FieldOffset(Offset = "0xCB8")]
    public StoryCharacterSwitchingPatternMaster StoryCharacterSwitchingPatternData;
    [Token(Token = "0x4003E5E")]
    [FieldOffset(Offset = "0xC70")]
    public static string StoryCommunicationAttachPath;
    [Token(Token = "0x4003E5F")]
    [FieldOffset(Offset = "0xCC0")]
    public StoryCommunicationAttachMaster StoryCommunicationAttachData;
    [Token(Token = "0x4003E60")]
    [FieldOffset(Offset = "0xC78")]
    public static string StoryCommunicationGroupLabelPath;
    [Token(Token = "0x4003E61")]
    [FieldOffset(Offset = "0xCC8")]
    public StoryCommunicationGroupLabelMaster StoryCommunicationGroupLabelData;
    [Token(Token = "0x4003E62")]
    [FieldOffset(Offset = "0xC80")]
    public static string StoryCommunicationIdentifierPath;
    [Token(Token = "0x4003E63")]
    [FieldOffset(Offset = "0xCD0")]
    public StoryCommunicationIdentifierMaster StoryCommunicationIdentifierData;
    [Token(Token = "0x4003E64")]
    [FieldOffset(Offset = "0xC88")]
    public static string StoryCommunicationLocationCharacterPath;
    [Token(Token = "0x4003E65")]
    [FieldOffset(Offset = "0xCD8")]
    public StoryCommunicationLocationCharacterMaster StoryCommunicationLocationCharacterData;
    [Token(Token = "0x4003E66")]
    [FieldOffset(Offset = "0xC90")]
    public static string StoryCommunicationLocationPath;
    [Token(Token = "0x4003E67")]
    [FieldOffset(Offset = "0xCE0")]
    public StoryCommunicationLocationMaster StoryCommunicationLocationData;
    [Token(Token = "0x4003E68")]
    [FieldOffset(Offset = "0xC98")]
    public static string StoryCommunicationLocationTermPath;
    [Token(Token = "0x4003E69")]
    [FieldOffset(Offset = "0xCE8")]
    public StoryCommunicationLocationTermMaster StoryCommunicationLocationTermData;
    [Token(Token = "0x4003E6A")]
    [FieldOffset(Offset = "0xCA0")]
    public static string StoryCommunicationParamPath;
    [Token(Token = "0x4003E6B")]
    [FieldOffset(Offset = "0xCF0")]
    public StoryCommunicationParamMaster StoryCommunicationParamData;
    [Token(Token = "0x4003E6C")]
    [FieldOffset(Offset = "0xCA8")]
    public static string StoryCommunicationRankupConditionPath;
    [Token(Token = "0x4003E6D")]
    [FieldOffset(Offset = "0xCF8")]
    public StoryCommunicationRankupConditionMaster StoryCommunicationRankupConditionData;
    [Token(Token = "0x4003E6E")]
    [FieldOffset(Offset = "0xCB0")]
    public static string StoryCommunicationRankupHintsPath;
    [Token(Token = "0x4003E6F")]
    [FieldOffset(Offset = "0xD00")]
    public StoryCommunicationRankupHintsMaster StoryCommunicationRankupHintsData;
    [Token(Token = "0x4003E70")]
    [FieldOffset(Offset = "0xCB8")]
    public static string StoryCommunicationRankupTermPath;
    [Token(Token = "0x4003E71")]
    [FieldOffset(Offset = "0xD08")]
    public StoryCommunicationRankupTermMaster StoryCommunicationRankupTermData;
    [Token(Token = "0x4003E72")]
    [FieldOffset(Offset = "0xCC0")]
    public static string StoryCommunicationReactionTypePath;
    [Token(Token = "0x4003E73")]
    [FieldOffset(Offset = "0xD10")]
    public StoryCommunicationReactionTypeMaster StoryCommunicationReactionTypeData;
    [Token(Token = "0x4003E74")]
    [FieldOffset(Offset = "0xCC8")]
    public static string StoryCommunicationRewardPriorityPath;
    [Token(Token = "0x4003E75")]
    [FieldOffset(Offset = "0xD18")]
    public StoryCommunicationRewardPriorityMaster StoryCommunicationRewardPriorityData;
    [Token(Token = "0x4003E76")]
    [FieldOffset(Offset = "0xCD0")]
    public static string StoryCommunicationRewardSetPath;
    [Token(Token = "0x4003E77")]
    [FieldOffset(Offset = "0xD20")]
    public StoryCommunicationRewardSetMaster StoryCommunicationRewardSetData;
    [Token(Token = "0x4003E78")]
    [FieldOffset(Offset = "0xCD8")]
    public static string StoryConditionEventPath;
    [Token(Token = "0x4003E79")]
    [FieldOffset(Offset = "0xD28")]
    public StoryConditionEventMaster StoryConditionEventData;
    [Token(Token = "0x4003E7A")]
    [FieldOffset(Offset = "0xCE0")]
    public static string StoryFacilityAttachPath;
    [Token(Token = "0x4003E7B")]
    [FieldOffset(Offset = "0xD30")]
    public StoryFacilityAttachMaster StoryFacilityAttachData;
    [Token(Token = "0x4003E7C")]
    [FieldOffset(Offset = "0xCE8")]
    public static string StoryFacilityBonusPath;
    [Token(Token = "0x4003E7D")]
    [FieldOffset(Offset = "0xD38")]
    public StoryFacilityBonusMaster StoryFacilityBonusData;
    [Token(Token = "0x4003E7E")]
    [FieldOffset(Offset = "0xCF0")]
    public static string StoryFacilityConditionsPath;
    [Token(Token = "0x4003E7F")]
    [FieldOffset(Offset = "0xD40")]
    public StoryFacilityConditionsMaster StoryFacilityConditionsData;
    [Token(Token = "0x4003E80")]
    [FieldOffset(Offset = "0xCF8")]
    public static string StoryFacilityCostsPath;
    [Token(Token = "0x4003E81")]
    [FieldOffset(Offset = "0xD48")]
    public StoryFacilityCostsMaster StoryFacilityCostsData;
    [Token(Token = "0x4003E82")]
    [FieldOffset(Offset = "0xD00")]
    public static string StoryFacilityDifficultyPath;
    [Token(Token = "0x4003E83")]
    [FieldOffset(Offset = "0xD50")]
    public StoryFacilityDifficultyMaster StoryFacilityDifficultyData;
    [Token(Token = "0x4003E84")]
    [FieldOffset(Offset = "0xD08")]
    public static string StoryFacilityEncountBonusDetailPath;
    [Token(Token = "0x4003E85")]
    [FieldOffset(Offset = "0xD58")]
    public StoryFacilityEncountBonusDetailMaster StoryFacilityEncountBonusDetailData;
    [Token(Token = "0x4003E86")]
    [FieldOffset(Offset = "0xD10")]
    public static string StoryFacilityItemBuffEffectParamPath;
    [Token(Token = "0x4003E87")]
    [FieldOffset(Offset = "0xD60")]
    public StoryFacilityItemBuffEffectParamMaster StoryFacilityItemBuffEffectParamData;
    [Token(Token = "0x4003E88")]
    [FieldOffset(Offset = "0xD18")]
    public static string StoryFacilityMenuPath;
    [Token(Token = "0x4003E89")]
    [FieldOffset(Offset = "0xD68")]
    public StoryFacilityMenuMaster StoryFacilityMenuData;
    [Token(Token = "0x4003E8A")]
    [FieldOffset(Offset = "0xD20")]
    public static string StoryFacilityReleaseSequencePath;
    [Token(Token = "0x4003E8B")]
    [FieldOffset(Offset = "0xD70")]
    public StoryFacilityReleaseSequenceMaster StoryFacilityReleaseSequenceData;
    [Token(Token = "0x4003E8C")]
    [FieldOffset(Offset = "0xD28")]
    public static string StoryFacilityRewardsPath;
    [Token(Token = "0x4003E8D")]
    [FieldOffset(Offset = "0xD78")]
    public StoryFacilityRewardsMaster StoryFacilityRewardsData;
    [Token(Token = "0x4003E8E")]
    [FieldOffset(Offset = "0xD30")]
    public static string StoryFacilityWorkAbilityEffectPath;
    [Token(Token = "0x4003E8F")]
    [FieldOffset(Offset = "0xD80")]
    public StoryFacilityWorkAbilityEffectMaster StoryFacilityWorkAbilityEffectData;
    [Token(Token = "0x4003E90")]
    [FieldOffset(Offset = "0xD38")]
    public static string StoryFacilityWorkPath;
    [Token(Token = "0x4003E91")]
    [FieldOffset(Offset = "0xD88")]
    public StoryFacilityWorkMaster StoryFacilityWorkData;
    [Token(Token = "0x4003E92")]
    [FieldOffset(Offset = "0xD40")]
    public static string StoryFreeActionAreaFastTravelPath;
    [Token(Token = "0x4003E93")]
    [FieldOffset(Offset = "0xD90")]
    public StoryFreeActionAreaFastTravelMaster StoryFreeActionAreaFastTravelData;
    [Token(Token = "0x4003E94")]
    [FieldOffset(Offset = "0xD48")]
    public static string StoryFreeActionAreaGroupPath;
    [Token(Token = "0x4003E95")]
    [FieldOffset(Offset = "0xD98")]
    public StoryFreeActionAreaGroupMaster StoryFreeActionAreaGroupData;
    [Token(Token = "0x4003E96")]
    [FieldOffset(Offset = "0xD50")]
    public static string StoryFreeActionAreaIntroductionPath;
    [Token(Token = "0x4003E97")]
    [FieldOffset(Offset = "0xDA0")]
    public StoryFreeActionAreaIntroductionMaster StoryFreeActionAreaIntroductionData;
    [Token(Token = "0x4003E98")]
    [FieldOffset(Offset = "0xD58")]
    public static string StoryFreeActionAreaRegionPath;
    [Token(Token = "0x4003E99")]
    [FieldOffset(Offset = "0xDA8")]
    public StoryFreeActionAreaRegionMaster StoryFreeActionAreaRegionData;
    [Token(Token = "0x4003E9A")]
    [FieldOffset(Offset = "0xD60")]
    public static string StoryFreeActionAreaSettingPath;
    [Token(Token = "0x4003E9B")]
    [FieldOffset(Offset = "0xDB0")]
    public StoryFreeActionAreaSettingMaster StoryFreeActionAreaSettingData;
    [Token(Token = "0x4003E9C")]
    [FieldOffset(Offset = "0xD68")]
    public static string StoryFreeActionAreaPath;
    [Token(Token = "0x4003E9D")]
    [FieldOffset(Offset = "0xDB8")]
    public StoryFreeActionAreaMaster StoryFreeActionAreaData;
    [Token(Token = "0x4003E9E")]
    [FieldOffset(Offset = "0xD70")]
    public static string StoryFreeActionBackgroundPath;
    [Token(Token = "0x4003E9F")]
    [FieldOffset(Offset = "0xDC0")]
    public StoryFreeActionBackgroundMaster StoryFreeActionBackgroundData;
    [Token(Token = "0x4003EA0")]
    [FieldOffset(Offset = "0xD78")]
    public static string StoryFreeActionBattleEnterLayoutPath;
    [Token(Token = "0x4003EA1")]
    [FieldOffset(Offset = "0xDC8")]
    public StoryFreeActionBattleEnterLayoutMaster StoryFreeActionBattleEnterLayoutData;
    [Token(Token = "0x4003EA2")]
    [FieldOffset(Offset = "0xD80")]
    public static string StoryFreeActionCameraViewPositionPath;
    [Token(Token = "0x4003EA3")]
    [FieldOffset(Offset = "0xDD0")]
    public StoryFreeActionCameraViewPositionMaster StoryFreeActionCameraViewPositionData;
    [Token(Token = "0x4003EA4")]
    [FieldOffset(Offset = "0xD88")]
    public static string StoryFreeActionCharacterPatternAssignDataPath;
    [Token(Token = "0x4003EA5")]
    [FieldOffset(Offset = "0xDD8")]
    public StoryFreeActionCharacterPatternAssignDataMaster StoryFreeActionCharacterPatternAssignDataData;
    [Token(Token = "0x4003EA6")]
    [FieldOffset(Offset = "0xD90")]
    public static string StoryFreeActionChestPath;
    [Token(Token = "0x4003EA7")]
    [FieldOffset(Offset = "0xDE0")]
    public StoryFreeActionChestMaster StoryFreeActionChestData;
    [Token(Token = "0x4003EA8")]
    [FieldOffset(Offset = "0xD98")]
    public static string StoryFreeActionChestTypePath;
    [Token(Token = "0x4003EA9")]
    [FieldOffset(Offset = "0xDE8")]
    public StoryFreeActionChestTypeMaster StoryFreeActionChestTypeData;
    [Token(Token = "0x4003EAA")]
    [FieldOffset(Offset = "0xDA0")]
    public static string StoryFreeActionConstPath;
    [Token(Token = "0x4003EAB")]
    [FieldOffset(Offset = "0xDF0")]
    public StoryFreeActionConstMaster StoryFreeActionConstData;
    [Token(Token = "0x4003EAC")]
    [FieldOffset(Offset = "0xDA8")]
    public static string StoryFreeActionEventCirclePath;
    [Token(Token = "0x4003EAD")]
    [FieldOffset(Offset = "0xDF8")]
    public StoryFreeActionEventCircleMaster StoryFreeActionEventCircleData;
    [Token(Token = "0x4003EAE")]
    [FieldOffset(Offset = "0xDB0")]
    public static string StoryFreeActionFlavorObjectPath;
    [Token(Token = "0x4003EAF")]
    [FieldOffset(Offset = "0xE00")]
    public StoryFreeActionFlavorObjectMaster StoryFreeActionFlavorObjectData;
    [Token(Token = "0x4003EB0")]
    [FieldOffset(Offset = "0xDB8")]
    public static string StoryFreeActionFlavorObjectTextPath;
    [Token(Token = "0x4003EB1")]
    [FieldOffset(Offset = "0xE08")]
    public StoryFreeActionFlavorObjectTextMaster StoryFreeActionFlavorObjectTextData;
    [Token(Token = "0x4003EB2")]
    [FieldOffset(Offset = "0xDC0")]
    public static string StoryFreeActionIconTypePath;
    [Token(Token = "0x4003EB3")]
    [FieldOffset(Offset = "0xE10")]
    public StoryFreeActionIconTypeMaster StoryFreeActionIconTypeData;
    [Token(Token = "0x4003EB4")]
    [FieldOffset(Offset = "0xDC8")]
    public static string StoryFreeActionLayoutPath;
    [Token(Token = "0x4003EB5")]
    [FieldOffset(Offset = "0xE18")]
    public StoryFreeActionLayoutMaster StoryFreeActionLayoutData;
    [Token(Token = "0x4003EB6")]
    [FieldOffset(Offset = "0xDD0")]
    public static string StoryFreeActionMinimapPath;
    [Token(Token = "0x4003EB7")]
    [FieldOffset(Offset = "0xE20")]
    public StoryFreeActionMinimapMaster StoryFreeActionMinimapData;
    [Token(Token = "0x4003EB8")]
    [FieldOffset(Offset = "0xDD8")]
    public static string StoryFreeActionObjectPath;
    [Token(Token = "0x4003EB9")]
    [FieldOffset(Offset = "0xE28")]
    public StoryFreeActionObjectMaster StoryFreeActionObjectData;
    [Token(Token = "0x4003EBA")]
    [FieldOffset(Offset = "0xDE0")]
    public static string StoryFreeActionObliviaeLayoutPath;
    [Token(Token = "0x4003EBB")]
    [FieldOffset(Offset = "0xE30")]
    public StoryFreeActionObliviaeLayoutMaster StoryFreeActionObliviaeLayoutData;
    [Token(Token = "0x4003EBC")]
    [FieldOffset(Offset = "0xDE8")]
    public static string StoryFreeActionOverrideSequecePath;
    [Token(Token = "0x4003EBD")]
    [FieldOffset(Offset = "0xE38")]
    public StoryFreeActionOverrideSequeceMaster StoryFreeActionOverrideSequeceData;
    [Token(Token = "0x4003EBE")]
    [FieldOffset(Offset = "0xDF0")]
    public static string StoryFreeActionPassiveTalkMessagePath;
    [Token(Token = "0x4003EBF")]
    [FieldOffset(Offset = "0xE40")]
    public StoryFreeActionPassiveTalkMessageMaster StoryFreeActionPassiveTalkMessageData;
    [Token(Token = "0x4003EC0")]
    [FieldOffset(Offset = "0xDF8")]
    public static string StoryFreeActionPlayerMovePositionPath;
    [Token(Token = "0x4003EC1")]
    [FieldOffset(Offset = "0xE48")]
    public StoryFreeActionPlayerMovePositionMaster StoryFreeActionPlayerMovePositionData;
    [Token(Token = "0x4003EC2")]
    [FieldOffset(Offset = "0xE00")]
    public static string StoryFreeActionPlayerPath;
    [Token(Token = "0x4003EC3")]
    [FieldOffset(Offset = "0xE50")]
    public StoryFreeActionPlayerMaster StoryFreeActionPlayerData;
    [Token(Token = "0x4003EC4")]
    [FieldOffset(Offset = "0xE08")]
    public static string StoryFreeActionPropPath;
    [Token(Token = "0x4003EC5")]
    [FieldOffset(Offset = "0xE58")]
    public StoryFreeActionPropMaster StoryFreeActionPropData;
    [Token(Token = "0x4003EC6")]
    [FieldOffset(Offset = "0xE10")]
    public static string StoryFreeActionRewardObjectBreakableObjectPropSettingPath;
    [Token(Token = "0x4003EC7")]
    [FieldOffset(Offset = "0xE60")]
    public StoryFreeActionRewardObjectBreakableObjectPropSettingMaster StoryFreeActionRewardObjectBreakableObjectPropSettingData;
    [Token(Token = "0x4003EC8")]
    [FieldOffset(Offset = "0xE18")]
    public static string StoryFreeActionRewardObjectBreakableObjectPath;
    [Token(Token = "0x4003EC9")]
    [FieldOffset(Offset = "0xE68")]
    public StoryFreeActionRewardObjectBreakableObjectMaster StoryFreeActionRewardObjectBreakableObjectData;
    [Token(Token = "0x4003ECA")]
    [FieldOffset(Offset = "0xE20")]
    public static string StoryFreeActionRewardObjectLayoutPath;
    [Token(Token = "0x4003ECB")]
    [FieldOffset(Offset = "0xE70")]
    public StoryFreeActionRewardObjectLayoutMaster StoryFreeActionRewardObjectLayoutData;
    [Token(Token = "0x4003ECC")]
    [FieldOffset(Offset = "0xE28")]
    public static string StoryFreeActionRewardObjectRewardsPath;
    [Token(Token = "0x4003ECD")]
    [FieldOffset(Offset = "0xE78")]
    public StoryFreeActionRewardObjectRewardsMaster StoryFreeActionRewardObjectRewardsData;
    [Token(Token = "0x4003ECE")]
    [FieldOffset(Offset = "0xE30")]
    public static string StoryFreeActionSettingPath;
    [Token(Token = "0x4003ECF")]
    [FieldOffset(Offset = "0xE80")]
    public StoryFreeActionSettingMaster StoryFreeActionSettingData;
    [Token(Token = "0x4003ED0")]
    [FieldOffset(Offset = "0xE38")]
    public static string StoryFreeActionSoundEffectPath;
    [Token(Token = "0x4003ED1")]
    [FieldOffset(Offset = "0xE88")]
    public StoryFreeActionSoundEffectMaster StoryFreeActionSoundEffectData;
    [Token(Token = "0x4003ED2")]
    [FieldOffset(Offset = "0xE40")]
    public static string StoryFreeActionSoundObjectPath;
    [Token(Token = "0x4003ED3")]
    [FieldOffset(Offset = "0xE90")]
    public StoryFreeActionSoundObjectMaster StoryFreeActionSoundObjectData;
    [Token(Token = "0x4003ED4")]
    [FieldOffset(Offset = "0xE48")]
    public static string StoryFreeActionSystemMenuEventPath;
    [Token(Token = "0x4003ED5")]
    [FieldOffset(Offset = "0xE98")]
    public StoryFreeActionSystemMenuEventMaster StoryFreeActionSystemMenuEventData;
    [Token(Token = "0x4003ED6")]
    [FieldOffset(Offset = "0xE50")]
    public static string StoryFreeActionTalkADVEventPath;
    [Token(Token = "0x4003ED7")]
    [FieldOffset(Offset = "0xEA0")]
    public StoryFreeActionTalkADVEventMaster StoryFreeActionTalkADVEventData;
    [Token(Token = "0x4003ED8")]
    [FieldOffset(Offset = "0xE58")]
    public static string StoryFreeActionTalkADVEventTextPath;
    [Token(Token = "0x4003ED9")]
    [FieldOffset(Offset = "0xEA8")]
    public StoryFreeActionTalkADVEventTextMaster StoryFreeActionTalkADVEventTextData;
    [Token(Token = "0x4003EDA")]
    [FieldOffset(Offset = "0xE60")]
    public static string StoryFreeActionTalkBalloonEventPath;
    [Token(Token = "0x4003EDB")]
    [FieldOffset(Offset = "0xEB0")]
    public StoryFreeActionTalkBalloonEventMaster StoryFreeActionTalkBalloonEventData;
    [Token(Token = "0x4003EDC")]
    [FieldOffset(Offset = "0xE68")]
    public static string StoryFreeActionTelopPath;
    [Token(Token = "0x4003EDD")]
    [FieldOffset(Offset = "0xEB8")]
    public StoryFreeActionTelopMaster StoryFreeActionTelopData;
    [Token(Token = "0x4003EDE")]
    [FieldOffset(Offset = "0xE70")]
    public static string StoryFreeActionTimeElapseLayoutPath;
    [Token(Token = "0x4003EDF")]
    [FieldOffset(Offset = "0xEC0")]
    public StoryFreeActionTimeElapseLayoutMaster StoryFreeActionTimeElapseLayoutData;
    [Token(Token = "0x4003EE0")]
    [FieldOffset(Offset = "0xE78")]
    public static string StoryFreeActionUniqueObjectSettingPath;
    [Token(Token = "0x4003EE1")]
    [FieldOffset(Offset = "0xEC8")]
    public StoryFreeActionUniqueObjectSettingMaster StoryFreeActionUniqueObjectSettingData;
    [Token(Token = "0x4003EE2")]
    [FieldOffset(Offset = "0xE80")]
    public static string StoryMainQuestCalendarElapsedGroupPath;
    [Token(Token = "0x4003EE3")]
    [FieldOffset(Offset = "0xED0")]
    public StoryMainQuestCalendarElapsedGroupMaster StoryMainQuestCalendarElapsedGroupData;
    [Token(Token = "0x4003EE4")]
    [FieldOffset(Offset = "0xE88")]
    public static string StoryMainQuestCalendarElapsedParamPath;
    [Token(Token = "0x4003EE5")]
    [FieldOffset(Offset = "0xED8")]
    public StoryMainQuestCalendarElapsedParamMaster StoryMainQuestCalendarElapsedParamData;
    [Token(Token = "0x4003EE6")]
    [FieldOffset(Offset = "0xE90")]
    public static string StoryMainQuestCalendarElapsedPath;
    [Token(Token = "0x4003EE7")]
    [FieldOffset(Offset = "0xEE0")]
    public StoryMainQuestCalendarElapsedMaster StoryMainQuestCalendarElapsedData;
    [Token(Token = "0x4003EE8")]
    [FieldOffset(Offset = "0xE98")]
    public static string StoryMainQuestCalendarHoridayPath;
    [Token(Token = "0x4003EE9")]
    [FieldOffset(Offset = "0xEE8")]
    public StoryMainQuestCalendarHoridayMaster StoryMainQuestCalendarHoridayData;
    [Token(Token = "0x4003EEA")]
    [FieldOffset(Offset = "0xEA0")]
    public static string StoryMainQuestCalendarPath;
    [Token(Token = "0x4003EEB")]
    [FieldOffset(Offset = "0xEF0")]
    public StoryMainQuestCalendarMaster StoryMainQuestCalendarData;
    [Token(Token = "0x4003EEC")]
    [FieldOffset(Offset = "0xEA8")]
    public static string StoryMainQuestSequenceConditionPath;
    [Token(Token = "0x4003EED")]
    [FieldOffset(Offset = "0xEF8")]
    public StoryMainQuestSequenceConditionMaster StoryMainQuestSequenceConditionData;
    [Token(Token = "0x4003EEE")]
    [FieldOffset(Offset = "0xEB0")]
    public static string StoryMainQuestSequenceConditionTypePath;
    [Token(Token = "0x4003EEF")]
    [FieldOffset(Offset = "0xF00")]
    public StoryMainQuestSequenceConditionTypeMaster StoryMainQuestSequenceConditionTypeData;
    [Token(Token = "0x4003EF0")]
    [FieldOffset(Offset = "0xEB8")]
    public static string StoryMainQuestSequenceRewardsPaymentsPath;
    [Token(Token = "0x4003EF1")]
    [FieldOffset(Offset = "0xF08")]
    public StoryMainQuestSequenceRewardsPaymentsMaster StoryMainQuestSequenceRewardsPaymentsData;
    [Token(Token = "0x4003EF2")]
    [FieldOffset(Offset = "0xEC0")]
    public static string StoryMainQuestSequenceSummaryPath;
    [Token(Token = "0x4003EF3")]
    [FieldOffset(Offset = "0xF10")]
    public StoryMainQuestSequenceSummaryMaster StoryMainQuestSequenceSummaryData;
    [Token(Token = "0x4003EF4")]
    [FieldOffset(Offset = "0xEC8")]
    public static string StoryMainQuestSequencePath;
    [Token(Token = "0x4003EF5")]
    [FieldOffset(Offset = "0xF18")]
    public StoryMainQuestSequenceMaster StoryMainQuestSequenceData;
    [Token(Token = "0x4003EF6")]
    [FieldOffset(Offset = "0xED0")]
    public static string StoryMainquestSequenceTutorialPath;
    [Token(Token = "0x4003EF7")]
    [FieldOffset(Offset = "0xF20")]
    public StoryMainquestSequenceTutorialMaster StoryMainquestSequenceTutorialData;
    [Token(Token = "0x4003EF8")]
    [FieldOffset(Offset = "0xED8")]
    public static string StoryMainQuestTimeZoneElapsedGroupPath;
    [Token(Token = "0x4003EF9")]
    [FieldOffset(Offset = "0xF28")]
    public StoryMainQuestTimeZoneElapsedGroupMaster StoryMainQuestTimeZoneElapsedGroupData;
    [Token(Token = "0x4003EFA")]
    [FieldOffset(Offset = "0xEE0")]
    public static string StoryMainQuestTimeZoneElapsedParamPath;
    [Token(Token = "0x4003EFB")]
    [FieldOffset(Offset = "0xF30")]
    public StoryMainQuestTimeZoneElapsedParamMaster StoryMainQuestTimeZoneElapsedParamData;
    [Token(Token = "0x4003EFC")]
    [FieldOffset(Offset = "0xEE8")]
    public static string StoryMainQuestTimeZoneElapsedPath;
    [Token(Token = "0x4003EFD")]
    [FieldOffset(Offset = "0xF38")]
    public StoryMainQuestTimeZoneElapsedMaster StoryMainQuestTimeZoneElapsedData;
    [Token(Token = "0x4003EFE")]
    [FieldOffset(Offset = "0xEF0")]
    public static string StoryMainQuestYearPath;
    [Token(Token = "0x4003EFF")]
    [FieldOffset(Offset = "0xF40")]
    public StoryMainQuestYearMaster StoryMainQuestYearData;
    [Token(Token = "0x4003F00")]
    [FieldOffset(Offset = "0xEF8")]
    public static string StoryMainQuestYearTextPath;
    [Token(Token = "0x4003F01")]
    [FieldOffset(Offset = "0xF48")]
    public StoryMainQuestYearTextMaster StoryMainQuestYearTextData;
    [Token(Token = "0x4003F02")]
    [FieldOffset(Offset = "0xF00")]
    public static string StoryReplayEntryDescriptionPath;
    [Token(Token = "0x4003F03")]
    [FieldOffset(Offset = "0xF50")]
    public StoryReplayEntryDescriptionMaster StoryReplayEntryDescriptionData;
    [Token(Token = "0x4003F04")]
    [FieldOffset(Offset = "0xF08")]
    public static string StoryReplayEntryPath;
    [Token(Token = "0x4003F05")]
    [FieldOffset(Offset = "0xF58")]
    public StoryReplayEntryMaster StoryReplayEntryData;
    [Token(Token = "0x4003F06")]
    [FieldOffset(Offset = "0xF10")]
    public static string StoryReplayEntryUnlockPath;
    [Token(Token = "0x4003F07")]
    [FieldOffset(Offset = "0xF60")]
    public StoryReplayEntryUnlockMaster StoryReplayEntryUnlockData;
    [Token(Token = "0x4003F08")]
    [FieldOffset(Offset = "0xF18")]
    public static string StoryReplayPath;
    [Token(Token = "0x4003F09")]
    [FieldOffset(Offset = "0xF68")]
    public StoryReplayMaster StoryReplayData;
    [Token(Token = "0x4003F0A")]
    [FieldOffset(Offset = "0xF20")]
    public static string StorySceneTypePath;
    [Token(Token = "0x4003F0B")]
    [FieldOffset(Offset = "0xF70")]
    public StorySceneTypeMaster StorySceneTypeData;
    [Token(Token = "0x4003F0C")]
    [FieldOffset(Offset = "0xF28")]
    public static string StoryObliviaeDetailPath;
    [Token(Token = "0x4003F0D")]
    [FieldOffset(Offset = "0xF78")]
    public StoryObliviaeDetailMaster StoryObliviaeDetailData;
    [Token(Token = "0x4003F0E")]
    [FieldOffset(Offset = "0xF30")]
    public static string StoryObliviaePath;
    [Token(Token = "0x4003F0F")]
    [FieldOffset(Offset = "0xF80")]
    public StoryObliviaeMaster StoryObliviaeData;
    [Token(Token = "0x4003F10")]
    [FieldOffset(Offset = "0xF38")]
    public static string StoryBgTemplatePath;
    [Token(Token = "0x4003F11")]
    [FieldOffset(Offset = "0xF88")]
    public StoryBgTemplateMaster StoryBgTemplateData;
    [Token(Token = "0x4003F12")]
    [FieldOffset(Offset = "0xF40")]
    public static string StoryBookCompleteFirstImpressionsPath;
    [Token(Token = "0x4003F13")]
    [FieldOffset(Offset = "0xF90")]
    public StoryBookCompleteFirstImpressionsMaster StoryBookCompleteFirstImpressionsData;
    [Token(Token = "0x4003F14")]
    [FieldOffset(Offset = "0xF48")]
    public static string StoryBookCompleteImpressionsPath;
    [Token(Token = "0x4003F15")]
    [FieldOffset(Offset = "0xF98")]
    public StoryBookCompleteImpressionsMaster StoryBookCompleteImpressionsData;
    [Token(Token = "0x4003F16")]
    [FieldOffset(Offset = "0xF50")]
    public static string StoryBookEffectPath;
    [Token(Token = "0x4003F17")]
    [FieldOffset(Offset = "0xFA0")]
    public StoryBookEffectMaster StoryBookEffectData;
    [Token(Token = "0x4003F18")]
    [FieldOffset(Offset = "0xF58")]
    public static string StoryBookProgressImpressionsPath;
    [Token(Token = "0x4003F19")]
    [FieldOffset(Offset = "0xFA8")]
    public StoryBookProgressImpressionsMaster StoryBookProgressImpressionsData;
    [Token(Token = "0x4003F1A")]
    [FieldOffset(Offset = "0xF60")]
    public static string StoryChapterPath;
    [Token(Token = "0x4003F1B")]
    [FieldOffset(Offset = "0xFB0")]
    public StoryChapterMaster StoryChapterData;
    [Token(Token = "0x4003F1C")]
    [FieldOffset(Offset = "0xF68")]
    public static string StoryDayOfWeekPath;
    [Token(Token = "0x4003F1D")]
    [FieldOffset(Offset = "0xFB8")]
    public StoryDayOfWeekMaster StoryDayOfWeekData;
    [Token(Token = "0x4003F1E")]
    [FieldOffset(Offset = "0xF70")]
    public static string StoryEndingPath;
    [Token(Token = "0x4003F1F")]
    [FieldOffset(Offset = "0xFC0")]
    public StoryEndingMaster StoryEndingData;
    [Token(Token = "0x4003F20")]
    [FieldOffset(Offset = "0xF78")]
    public static string StoryHumanParameterLevelPath;
    [Token(Token = "0x4003F21")]
    [FieldOffset(Offset = "0xFC8")]
    public StoryHumanParameterLevelMaster StoryHumanParameterLevelData;
    [Token(Token = "0x4003F22")]
    [FieldOffset(Offset = "0xF80")]
    public static string StoryHumanParameterPath;
    [Token(Token = "0x4003F23")]
    [FieldOffset(Offset = "0xFD0")]
    public StoryHumanParameterMaster StoryHumanParameterData;
    [Token(Token = "0x4003F24")]
    [FieldOffset(Offset = "0xF88")]
    public static string StoryMainQuestSequenceRoutePath;
    [Token(Token = "0x4003F25")]
    [FieldOffset(Offset = "0xFD8")]
    public StoryMainQuestSequenceRouteMaster StoryMainQuestSequenceRouteData;
    [Token(Token = "0x4003F26")]
    [FieldOffset(Offset = "0xF90")]
    public static string StoryNotifyPath;
    [Token(Token = "0x4003F27")]
    [FieldOffset(Offset = "0xFE0")]
    public StoryNotifyMaster StoryNotifyData;
    [Token(Token = "0x4003F28")]
    [FieldOffset(Offset = "0xF98")]
    public static string StoryPointIdentifierPath;
    [Token(Token = "0x4003F29")]
    [FieldOffset(Offset = "0xFE8")]
    public StoryPointIdentifierMaster StoryPointIdentifierData;
    [Token(Token = "0x4003F2A")]
    [FieldOffset(Offset = "0xFA0")]
    public static string StoryRoutePath;
    [Token(Token = "0x4003F2B")]
    [FieldOffset(Offset = "0xFF0")]
    public StoryRouteMaster StoryRouteData;
    [Token(Token = "0x4003F2C")]
    [FieldOffset(Offset = "0xFA8")]
    public static string StoryScenarioQuestPath;
    [Token(Token = "0x4003F2D")]
    [FieldOffset(Offset = "0xFF8")]
    public StoryScenarioQuestMaster StoryScenarioQuestData;
    [Token(Token = "0x4003F2E")]
    [FieldOffset(Offset = "0xFB0")]
    public static string StoryTaskFlagPath;
    [Token(Token = "0x4003F2F")]
    [FieldOffset(Offset = "0x1000")]
    public StoryTaskFlagMaster StoryTaskFlagData;
    [Token(Token = "0x4003F30")]
    [FieldOffset(Offset = "0xFB8")]
    public static string StoryTimeSlotGroupPath;
    [Token(Token = "0x4003F31")]
    [FieldOffset(Offset = "0x1008")]
    public StoryTimeSlotGroupMaster StoryTimeSlotGroupData;
    [Token(Token = "0x4003F32")]
    [FieldOffset(Offset = "0xFC0")]
    public static string StoryTimeSlotPath;
    [Token(Token = "0x4003F33")]
    [FieldOffset(Offset = "0x1010")]
    public StoryTimeSlotMaster StoryTimeSlotData;
    [Token(Token = "0x4003F34")]
    [FieldOffset(Offset = "0xFC8")]
    public static string StoryWeatherPath;
    [Token(Token = "0x4003F35")]
    [FieldOffset(Offset = "0x1018")]
    public StoryWeatherMaster StoryWeatherData;
    [Token(Token = "0x4003F36")]
    [FieldOffset(Offset = "0xFD0")]
    public static string StoryWeeklyPath;
    [Token(Token = "0x4003F37")]
    [FieldOffset(Offset = "0x1020")]
    public StoryWeeklyMaster StoryWeeklyData;
    [Token(Token = "0x4003F38")]
    [FieldOffset(Offset = "0xFD8")]
    public static string StorySubquestCycleTypePath;
    [Token(Token = "0x4003F39")]
    [FieldOffset(Offset = "0x1028")]
    public StorySubquestCycleTypeMaster StorySubquestCycleTypeData;
    [Token(Token = "0x4003F3A")]
    [FieldOffset(Offset = "0xFE0")]
    public static string StorySubquestFirstPositionPath;
    [Token(Token = "0x4003F3B")]
    [FieldOffset(Offset = "0x1030")]
    public StorySubquestFirstPositionMaster StorySubquestFirstPositionData;
    [Token(Token = "0x4003F3C")]
    [FieldOffset(Offset = "0xFE8")]
    public static string StorySubquestResetItemSetPath;
    [Token(Token = "0x4003F3D")]
    [FieldOffset(Offset = "0x1038")]
    public StorySubquestResetItemSetMaster StorySubquestResetItemSetData;
    [Token(Token = "0x4003F3E")]
    [FieldOffset(Offset = "0xFF0")]
    public static string StorySubquestRewardPaymentPath;
    [Token(Token = "0x4003F3F")]
    [FieldOffset(Offset = "0x1040")]
    public StorySubquestRewardPaymentMaster StorySubquestRewardPaymentData;
    [Token(Token = "0x4003F40")]
    [FieldOffset(Offset = "0xFF8")]
    public static string StorySubquestRewardSetPath;
    [Token(Token = "0x4003F41")]
    [FieldOffset(Offset = "0x1048")]
    public StorySubquestRewardSetMaster StorySubquestRewardSetData;
    [Token(Token = "0x4003F42")]
    [FieldOffset(Offset = "0x1000")]
    public static string StorySubquestRewardsPath;
    [Token(Token = "0x4003F43")]
    [FieldOffset(Offset = "0x1050")]
    public StorySubquestRewardsMaster StorySubquestRewardsData;
    [Token(Token = "0x4003F44")]
    [FieldOffset(Offset = "0x1008")]
    public static string StorySubquestPath;
    [Token(Token = "0x4003F45")]
    [FieldOffset(Offset = "0x1058")]
    public StorySubquestMaster StorySubquestData;
    [Token(Token = "0x4003F46")]
    [FieldOffset(Offset = "0x1010")]
    public static string StorySubquestTaskFlagPath;
    [Token(Token = "0x4003F47")]
    [FieldOffset(Offset = "0x1060")]
    public StorySubquestTaskFlagMaster StorySubquestTaskFlagData;
    [Token(Token = "0x4003F48")]
    [FieldOffset(Offset = "0x1018")]
    public static string StorySubquestTaskPath;
    [Token(Token = "0x4003F49")]
    [FieldOffset(Offset = "0x1068")]
    public StorySubquestTaskMaster StorySubquestTaskData;
    [Token(Token = "0x4003F4A")]
    [FieldOffset(Offset = "0x1020")]
    public static string StorySubquestTaskTextPath;
    [Token(Token = "0x4003F4B")]
    [FieldOffset(Offset = "0x1070")]
    public StorySubquestTaskTextMaster StorySubquestTaskTextData;
    [Token(Token = "0x4003F4C")]
    [FieldOffset(Offset = "0x1028")]
    public static string StorySubquestTaskTypePath;
    [Token(Token = "0x4003F4D")]
    [FieldOffset(Offset = "0x1078")]
    public StorySubquestTaskTypeMaster StorySubquestTaskTypeData;
    [Token(Token = "0x4003F4E")]
    [FieldOffset(Offset = "0x1030")]
    public static string TutorialPagePath;
    [Token(Token = "0x4003F4F")]
    [FieldOffset(Offset = "0x1080")]
    public TutorialPageMaster TutorialPageData;
    [Token(Token = "0x4003F50")]
    [FieldOffset(Offset = "0x1038")]
    public static string AbilityBoardBoardListFormPath;
    [Token(Token = "0x4003F51")]
    [FieldOffset(Offset = "0x1088")]
    public AbilityBoardBoardListFormMaster AbilityBoardBoardListFormData;
    [Token(Token = "0x4003F52")]
    [FieldOffset(Offset = "0x1040")]
    public static string AbilityBoardBoardListSettingPath;
    [Token(Token = "0x4003F53")]
    [FieldOffset(Offset = "0x1090")]
    public AbilityBoardBoardListSettingMaster AbilityBoardBoardListSettingData;
    [Token(Token = "0x4003F54")]
    [FieldOffset(Offset = "0x1048")]
    public static string AbilityBoardBoardListPath;
    [Token(Token = "0x4003F55")]
    [FieldOffset(Offset = "0x1098")]
    public AbilityBoardBoardListMaster AbilityBoardBoardListData;
    [Token(Token = "0x4003F56")]
    [FieldOffset(Offset = "0x1050")]
    public static string AbilityBoardBoardSettingPath;
    [Token(Token = "0x4003F57")]
    [FieldOffset(Offset = "0x10A0")]
    public AbilityBoardBoardSettingMaster AbilityBoardBoardSettingData;
    [Token(Token = "0x4003F58")]
    [FieldOffset(Offset = "0x1058")]
    public static string AbilityBoardCompleteBonusPath;
    [Token(Token = "0x4003F59")]
    [FieldOffset(Offset = "0x10A8")]
    public AbilityBoardCompleteBonusMaster AbilityBoardCompleteBonusData;
    [Token(Token = "0x4003F5A")]
    [FieldOffset(Offset = "0x1060")]
    public static string AbilityBoardConsumeAllocationPath;
    [Token(Token = "0x4003F5B")]
    [FieldOffset(Offset = "0x10B0")]
    public AbilityBoardConsumeAllocationMaster AbilityBoardConsumeAllocationData;
    [Token(Token = "0x4003F5C")]
    [FieldOffset(Offset = "0x1068")]
    public static string AbilityBoardConsumeGroupPath;
    [Token(Token = "0x4003F5D")]
    [FieldOffset(Offset = "0x10B8")]
    public AbilityBoardConsumeGroupMaster AbilityBoardConsumeGroupData;
    [Token(Token = "0x4003F5E")]
    [FieldOffset(Offset = "0x1070")]
    public static string AbilityBoardConsumeItemPath;
    [Token(Token = "0x4003F5F")]
    [FieldOffset(Offset = "0x10C0")]
    public AbilityBoardConsumeItemMaster AbilityBoardConsumeItemData;
    [Token(Token = "0x4003F60")]
    [FieldOffset(Offset = "0x1078")]
    public static string AbilityboardCustomACostSettingPath;
    [Token(Token = "0x4003F61")]
    [FieldOffset(Offset = "0x10C8")]
    public AbilityboardCustomACostSettingMaster AbilityboardCustomACostSettingData;
    [Token(Token = "0x4003F62")]
    [FieldOffset(Offset = "0x1080")]
    public static string AbilityboardCustomAFramePath;
    [Token(Token = "0x4003F63")]
    [FieldOffset(Offset = "0x10D0")]
    public AbilityboardCustomAFrameMaster AbilityboardCustomAFrameData;
    [Token(Token = "0x4003F64")]
    [FieldOffset(Offset = "0x1088")]
    public static string AbilityboardCustomANodePath;
    [Token(Token = "0x4003F65")]
    [FieldOffset(Offset = "0x10D8")]
    public AbilityboardCustomANodeMaster AbilityboardCustomANodeData;
    [Token(Token = "0x4003F66")]
    [FieldOffset(Offset = "0x1090")]
    public static string AbilityboardCustomASettingPath;
    [Token(Token = "0x4003F67")]
    [FieldOffset(Offset = "0x10E0")]
    public AbilityboardCustomASettingMaster AbilityboardCustomASettingData;
    [Token(Token = "0x4003F68")]
    [FieldOffset(Offset = "0x1098")]
    public static string AbilityboardCustomBNodePath;
    [Token(Token = "0x4003F69")]
    [FieldOffset(Offset = "0x10E8")]
    public AbilityboardCustomBNodeMaster AbilityboardCustomBNodeData;
    [Token(Token = "0x4003F6A")]
    [FieldOffset(Offset = "0x10A0")]
    public static string AbilityBoardCustomPatternSettingPath;
    [Token(Token = "0x4003F6B")]
    [FieldOffset(Offset = "0x10F0")]
    public AbilityBoardCustomPatternSettingMaster AbilityBoardCustomPatternSettingData;
    [Token(Token = "0x4003F6C")]
    [FieldOffset(Offset = "0x10A8")]
    public static string AbilityBoardCustomPatternPath;
    [Token(Token = "0x4003F6D")]
    [FieldOffset(Offset = "0x10F8")]
    public AbilityBoardCustomPatternMaster AbilityBoardCustomPatternData;
    [Token(Token = "0x4003F6E")]
    [FieldOffset(Offset = "0x10B0")]
    public static string AbilityBoardFormPath;
    [Token(Token = "0x4003F6F")]
    [FieldOffset(Offset = "0x1100")]
    public AbilityBoardFormMaster AbilityBoardFormData;
    [Token(Token = "0x4003F70")]
    [FieldOffset(Offset = "0x10B8")]
    public static string AbilityBoardLotteryResultTypeAllocationPath;
    [Token(Token = "0x4003F71")]
    [FieldOffset(Offset = "0x1108")]
    public AbilityBoardLotteryResultTypeAllocationMaster AbilityBoardLotteryResultTypeAllocationData;
    [Token(Token = "0x4003F72")]
    [FieldOffset(Offset = "0x10C0")]
    public static string AbilityBoardLotteryResultTypePath;
    [Token(Token = "0x4003F73")]
    [FieldOffset(Offset = "0x1110")]
    public AbilityBoardLotteryResultTypeMaster AbilityBoardLotteryResultTypeData;
    [Token(Token = "0x4003F74")]
    [FieldOffset(Offset = "0x10C8")]
    public static string AbilityBoardNodeIconPath;
    [Token(Token = "0x4003F75")]
    [FieldOffset(Offset = "0x1118")]
    public AbilityBoardNodeIconMaster AbilityBoardNodeIconData;
    [Token(Token = "0x4003F76")]
    [FieldOffset(Offset = "0x10D0")]
    public static string AbilityBoardNodePath;
    [Token(Token = "0x4003F77")]
    [FieldOffset(Offset = "0x1120")]
    public AbilityBoardNodeMaster AbilityBoardNodeData;
    [Token(Token = "0x4003F78")]
    [FieldOffset(Offset = "0x10D8")]
    public static string AbilityBoardRewardAllocationPath;
    [Token(Token = "0x4003F79")]
    [FieldOffset(Offset = "0x1128")]
    public AbilityBoardRewardAllocationMaster AbilityBoardRewardAllocationData;
    [Token(Token = "0x4003F7A")]
    [FieldOffset(Offset = "0x10E0")]
    public static string AbilityBoardRewardGroupPath;
    [Token(Token = "0x4003F7B")]
    [FieldOffset(Offset = "0x1130")]
    public AbilityBoardRewardGroupMaster AbilityBoardRewardGroupData;
    [Token(Token = "0x4003F7C")]
    [FieldOffset(Offset = "0x10E8")]
    public static string AbilityBoardRewardPatternPath;
    [Token(Token = "0x4003F7D")]
    [FieldOffset(Offset = "0x1138")]
    public AbilityBoardRewardPatternMaster AbilityBoardRewardPatternData;
    [Token(Token = "0x4003F7E")]
    [FieldOffset(Offset = "0x10F0")]
    public static string AbilityBoardStyleSettingPath;
    [Token(Token = "0x4003F7F")]
    [FieldOffset(Offset = "0x1140")]
    public AbilityBoardStyleSettingMaster AbilityBoardStyleSettingData;
    [Token(Token = "0x4003F80")]
    [FieldOffset(Offset = "0x10F8")]
    public static string AbilityBoardPath;
    [Token(Token = "0x4003F81")]
    [FieldOffset(Offset = "0x1148")]
    public AbilityBoardMaster AbilityBoardData;
    [Token(Token = "0x4003F82")]
    [FieldOffset(Offset = "0x1100")]
    public static string CharacterConstPath;
    [Token(Token = "0x4003F83")]
    [FieldOffset(Offset = "0x1150")]
    public CharacterConstMaster CharacterConstData;
    [Token(Token = "0x4003F84")]
    [FieldOffset(Offset = "0x1108")]
    public static string CharacterInfluenceRatePath;
    [Token(Token = "0x4003F85")]
    [FieldOffset(Offset = "0x1158")]
    public CharacterInfluenceRateMaster CharacterInfluenceRateData;
    [Token(Token = "0x4003F86")]
    [FieldOffset(Offset = "0x1110")]
    public static string CharacterLimitReleaseDetailPath;
    [Token(Token = "0x4003F87")]
    [FieldOffset(Offset = "0x1160")]
    public CharacterLimitReleaseDetailMaster CharacterLimitReleaseDetailData;
    [Token(Token = "0x4003F88")]
    [FieldOffset(Offset = "0x1118")]
    public static string CharacterPath;
    [Token(Token = "0x4003F89")]
    [FieldOffset(Offset = "0x1168")]
    public CharacterMaster CharacterData;
    [Token(Token = "0x4003F8A")]
    [FieldOffset(Offset = "0x1120")]
    public static string CommunicationSkillPath;
    [Token(Token = "0x4003F8B")]
    [FieldOffset(Offset = "0x1170")]
    public CommunicationSkillMaster CommunicationSkillData;
    [Token(Token = "0x4003F8C")]
    [FieldOffset(Offset = "0x1128")]
    public static string LpRecoveryPaymentPath;
    [Token(Token = "0x4003F8D")]
    [FieldOffset(Offset = "0x1178")]
    public LpRecoveryPaymentMaster LpRecoveryPaymentData;
    [Token(Token = "0x4003F8E")]
    [FieldOffset(Offset = "0x1130")]
    public static string SupportRankPath;
    [Token(Token = "0x4003F8F")]
    [FieldOffset(Offset = "0x1180")]
    public SupportRankMaster SupportRankData;
    [Token(Token = "0x4003F90")]
    [FieldOffset(Offset = "0x1138")]
    public static string AccessoryClassificationGroupDescriptionPath;
    [Token(Token = "0x4003F91")]
    [FieldOffset(Offset = "0x1188")]
    public AccessoryClassificationGroupDescriptionMaster AccessoryClassificationGroupDescriptionData;
    [Token(Token = "0x4003F92")]
    [FieldOffset(Offset = "0x1140")]
    public static string AccessoryClassificationGroupPath;
    [Token(Token = "0x4003F93")]
    [FieldOffset(Offset = "0x1190")]
    public AccessoryClassificationGroupMaster AccessoryClassificationGroupData;
    [Token(Token = "0x4003F94")]
    [FieldOffset(Offset = "0x1148")]
    public static string ArmorPath;
    [Token(Token = "0x4003F95")]
    [FieldOffset(Offset = "0x1198")]
    public ArmorMaster ArmorData;
    [Token(Token = "0x4003F96")]
    [FieldOffset(Offset = "0x1150")]
    public static string ArmyPath;
    [Token(Token = "0x4003F97")]
    [FieldOffset(Offset = "0x11A0")]
    public ArmyMaster ArmyData;
    [Token(Token = "0x4003F98")]
    [FieldOffset(Offset = "0x1158")]
    public static string ClassPath;
    [Token(Token = "0x4003F99")]
    [FieldOffset(Offset = "0x11A8")]
    public ClassMaster ClassData;
    [Token(Token = "0x4003F9A")]
    [FieldOffset(Offset = "0x1160")]
    public static string MovePath;
    [Token(Token = "0x4003F9B")]
    [FieldOffset(Offset = "0x11B0")]
    public MoveMaster MoveData;
    [Token(Token = "0x4003F9C")]
    [FieldOffset(Offset = "0x1168")]
    public static string SubEquipmentClassificationGroupDescriptionPath;
    [Token(Token = "0x4003F9D")]
    [FieldOffset(Offset = "0x11B8")]
    public SubEquipmentClassificationGroupDescriptionMaster SubEquipmentClassificationGroupDescriptionData;
    [Token(Token = "0x4003F9E")]
    [FieldOffset(Offset = "0x1170")]
    public static string SubEquipmentClassificationGroupPath;
    [Token(Token = "0x4003F9F")]
    [FieldOffset(Offset = "0x11C0")]
    public SubEquipmentClassificationGroupMaster SubEquipmentClassificationGroupData;
    [Token(Token = "0x4003FA0")]
    [FieldOffset(Offset = "0x1178")]
    public static string WeaponProficiencyDescriptionPath;
    [Token(Token = "0x4003FA1")]
    [FieldOffset(Offset = "0x11C8")]
    public WeaponProficiencyDescriptionMaster WeaponProficiencyDescriptionData;
    [Token(Token = "0x4003FA2")]
    [FieldOffset(Offset = "0x1180")]
    public static string WeaponProficiencyLevelPath;
    [Token(Token = "0x4003FA3")]
    [FieldOffset(Offset = "0x11D0")]
    public WeaponProficiencyLevelMaster WeaponProficiencyLevelData;
    [Token(Token = "0x4003FA4")]
    [FieldOffset(Offset = "0x1188")]
    public static string WeaponProficiencyPath;
    [Token(Token = "0x4003FA5")]
    [FieldOffset(Offset = "0x11D8")]
    public WeaponProficiencyMaster WeaponProficiencyData;
    [Token(Token = "0x4003FA6")]
    [FieldOffset(Offset = "0x1190")]
    public static string EmblemPath;
    [Token(Token = "0x4003FA7")]
    [FieldOffset(Offset = "0x11E0")]
    public EmblemMaster EmblemData;
    [Token(Token = "0x4003FA8")]
    [FieldOffset(Offset = "0x1198")]
    public static string LevelUpParameterPath;
    [Token(Token = "0x4003FA9")]
    [FieldOffset(Offset = "0x11E8")]
    public LevelUpParameterMaster LevelUpParameterData;
    [Token(Token = "0x4003FAA")]
    [FieldOffset(Offset = "0x11A0")]
    public static string StockCounterPath;
    [Token(Token = "0x4003FAB")]
    [FieldOffset(Offset = "0x11F0")]
    public StockCounterMaster StockCounterData;
    [Token(Token = "0x4003FAC")]
    [FieldOffset(Offset = "0x11A8")]
    public static string CharacterVoicePath;
    [Token(Token = "0x4003FAD")]
    [FieldOffset(Offset = "0x11F8")]
    public CharacterVoiceMaster CharacterVoiceData;
    [Token(Token = "0x4003FAE")]
    [FieldOffset(Offset = "0x11B0")]
    public static string IllustratorPath;
    [Token(Token = "0x4003FAF")]
    [FieldOffset(Offset = "0x1200")]
    public IllustratorMaster IllustratorData;
    [Token(Token = "0x4003FB0")]
    [FieldOffset(Offset = "0x11B8")]
    public static string OverrideResourcePath;
    [Token(Token = "0x4003FB1")]
    [FieldOffset(Offset = "0x1208")]
    public OverrideResourceMaster OverrideResourceData;
    [Token(Token = "0x4003FB2")]
    [FieldOffset(Offset = "0x11C0")]
    public static string RarityStylePath;
    [Token(Token = "0x4003FB3")]
    [FieldOffset(Offset = "0x1210")]
    public RarityStyleMaster RarityStyleData;
    [Token(Token = "0x4003FB4")]
    [FieldOffset(Offset = "0x11C8")]
    public static string RarityUpPath;
    [Token(Token = "0x4003FB5")]
    [FieldOffset(Offset = "0x1218")]
    public RarityUpMaster RarityUpData;
    [Token(Token = "0x4003FB6")]
    [FieldOffset(Offset = "0x11D0")]
    public static string ReincarnationBonusGroupPath;
    [Token(Token = "0x4003FB7")]
    [FieldOffset(Offset = "0x1220")]
    public ReincarnationBonusGroupMaster ReincarnationBonusGroupData;
    [Token(Token = "0x4003FB8")]
    [FieldOffset(Offset = "0x11D8")]
    public static string ReincarnationPath;
    [Token(Token = "0x4003FB9")]
    [FieldOffset(Offset = "0x1228")]
    public ReincarnationMaster ReincarnationData;
    [Token(Token = "0x4003FBA")]
    [FieldOffset(Offset = "0x11E0")]
    public static string StyleAwakeMaterialPath;
    [Token(Token = "0x4003FBB")]
    [FieldOffset(Offset = "0x1230")]
    public StyleAwakeMaterialMaster StyleAwakeMaterialData;
    [Token(Token = "0x4003FBC")]
    [FieldOffset(Offset = "0x11E8")]
    public static string StyleExpDescriptionPath;
    [Token(Token = "0x4003FBD")]
    [FieldOffset(Offset = "0x1238")]
    public StyleExpDescriptionMaster StyleExpDescriptionData;
    [Token(Token = "0x4003FBE")]
    [FieldOffset(Offset = "0x11F0")]
    public static string StyleExpPath;
    [Token(Token = "0x4003FBF")]
    [FieldOffset(Offset = "0x1240")]
    public StyleExpMaster StyleExpData;
    [Token(Token = "0x4003FC0")]
    [FieldOffset(Offset = "0x11F8")]
    public static string StyleGroupDescriptionPath;
    [Token(Token = "0x4003FC1")]
    [FieldOffset(Offset = "0x1248")]
    public StyleGroupDescriptionMaster StyleGroupDescriptionData;
    [Token(Token = "0x4003FC2")]
    [FieldOffset(Offset = "0x1200")]
    public static string StyleGroupPath;
    [Token(Token = "0x4003FC3")]
    [FieldOffset(Offset = "0x1250")]
    public StyleGroupMaster StyleGroupData;
    [Token(Token = "0x4003FC4")]
    [FieldOffset(Offset = "0x1208")]
    public static string StyleLevelUpValuePath;
    [Token(Token = "0x4003FC5")]
    [FieldOffset(Offset = "0x1258")]
    public StyleLevelUpValueMaster StyleLevelUpValueData;
    [Token(Token = "0x4003FC6")]
    [FieldOffset(Offset = "0x1210")]
    public static string StyleSkillSettingPath;
    [Token(Token = "0x4003FC7")]
    [FieldOffset(Offset = "0x1260")]
    public StyleSkillSettingMaster StyleSkillSettingData;
    [Token(Token = "0x4003FC8")]
    [FieldOffset(Offset = "0x1218")]
    public static string StylePath;
    [Token(Token = "0x4003FC9")]
    [FieldOffset(Offset = "0x1268")]
    public StyleMaster StyleData;
    [Token(Token = "0x4003FCA")]
    [FieldOffset(Offset = "0x1220")]
    public static string StyleTrainingRankConstPath;
    [Token(Token = "0x4003FCB")]
    [FieldOffset(Offset = "0x1270")]
    public StyleTrainingRankConstMaster StyleTrainingRankConstData;
    [Token(Token = "0x4003FCC")]
    [FieldOffset(Offset = "0x1228")]
    public static string StyleTrainingRankPath;
    [Token(Token = "0x4003FCD")]
    [FieldOffset(Offset = "0x1278")]
    public StyleTrainingRankMaster StyleTrainingRankData;
    [Token(Token = "0x4003FCE")]
    [FieldOffset(Offset = "0x1230")]
    public static string StyleLimitBreakStatusPath;
    [Token(Token = "0x4003FCF")]
    [FieldOffset(Offset = "0x1280")]
    public StyleLimitBreakStatusMaster StyleLimitBreakStatusData;
    [Token(Token = "0x4003FD0")]
    [FieldOffset(Offset = "0x1238")]
    public static string StylePararaLimitPath;
    [Token(Token = "0x4003FD1")]
    [FieldOffset(Offset = "0x1288")]
    public StylePararaLimitMaster StylePararaLimitData;

    [Token(Token = "0x6004C1A")]
    [Address(RVA = "0x32EBE64", Offset = "0x32EBE64", VA = "0x32EBE64")]
    public AdvArithmeticTypeMaster LoadAdvArithmeticType(string path)
    {
      return (AdvArithmeticTypeMaster) null;
    }

    [Token(Token = "0x6004C1B")]
    [Address(RVA = "0x32EBEBC", Offset = "0x32EBEBC", VA = "0x32EBEBC")]
    private void LoadAdvArithmeticTypeDefault()
    {
    }

    [Token(Token = "0x6004C1C")]
    [Address(RVA = "0x32EBF24", Offset = "0x32EBF24", VA = "0x32EBF24")]
    public AdvChoicesDefineMaster LoadAdvChoicesDefine(string path)
    {
      return (AdvChoicesDefineMaster) null;
    }

    [Token(Token = "0x6004C1D")]
    [Address(RVA = "0x32EBF7C", Offset = "0x32EBF7C", VA = "0x32EBF7C")]
    private void LoadAdvChoicesDefineDefault()
    {
    }

    [Token(Token = "0x6004C1E")]
    [Address(RVA = "0x32EBFE4", Offset = "0x32EBFE4", VA = "0x32EBFE4")]
    public AdvComparisonTypeMaster LoadAdvComparisonType(string path)
    {
      return (AdvComparisonTypeMaster) null;
    }

    [Token(Token = "0x6004C1F")]
    [Address(RVA = "0x32EC03C", Offset = "0x32EC03C", VA = "0x32EC03C")]
    private void LoadAdvComparisonTypeDefault()
    {
    }

    [Token(Token = "0x6004C20")]
    [Address(RVA = "0x32EC0A4", Offset = "0x32EC0A4", VA = "0x32EC0A4")]
    public AdvDemoInfoMaster LoadAdvDemoInfo(string path) => (AdvDemoInfoMaster) null;

    [Token(Token = "0x6004C21")]
    [Address(RVA = "0x32EC0FC", Offset = "0x32EC0FC", VA = "0x32EC0FC")]
    private void LoadAdvDemoInfoDefault()
    {
    }

    [Token(Token = "0x6004C22")]
    [Address(RVA = "0x32EC164", Offset = "0x32EC164", VA = "0x32EC164")]
    public AdvExpandedLockComparisonTermMaster LoadAdvExpandedLockComparisonTerm(string path)
    {
      return (AdvExpandedLockComparisonTermMaster) null;
    }

    [Token(Token = "0x6004C23")]
    [Address(RVA = "0x32EC1BC", Offset = "0x32EC1BC", VA = "0x32EC1BC")]
    private void LoadAdvExpandedLockComparisonTermDefault()
    {
    }

    [Token(Token = "0x6004C24")]
    [Address(RVA = "0x32EC224", Offset = "0x32EC224", VA = "0x32EC224")]
    public AdvExpandedLockMaster LoadAdvExpandedLock(string path) => (AdvExpandedLockMaster) null;

    [Token(Token = "0x6004C25")]
    [Address(RVA = "0x32EC27C", Offset = "0x32EC27C", VA = "0x32EC27C")]
    private void LoadAdvExpandedLockDefault()
    {
    }

    [Token(Token = "0x6004C26")]
    [Address(RVA = "0x32EC2E4", Offset = "0x32EC2E4", VA = "0x32EC2E4")]
    public AdvExpandedLockVariableMaster LoadAdvExpandedLockVariable(string path)
    {
      return (AdvExpandedLockVariableMaster) null;
    }

    [Token(Token = "0x6004C27")]
    [Address(RVA = "0x32EC33C", Offset = "0x32EC33C", VA = "0x32EC33C")]
    private void LoadAdvExpandedLockVariableDefault()
    {
    }

    [Token(Token = "0x6004C28")]
    [Address(RVA = "0x32EC3A4", Offset = "0x32EC3A4", VA = "0x32EC3A4")]
    public AdvLockOneMaster LoadAdvLockOne(string path) => (AdvLockOneMaster) null;

    [Token(Token = "0x6004C29")]
    [Address(RVA = "0x32EC3FC", Offset = "0x32EC3FC", VA = "0x32EC3FC")]
    private void LoadAdvLockOneDefault()
    {
    }

    [Token(Token = "0x6004C2A")]
    [Address(RVA = "0x32EC464", Offset = "0x32EC464", VA = "0x32EC464")]
    public AdvLockMaster LoadAdvLock(string path) => (AdvLockMaster) null;

    [Token(Token = "0x6004C2B")]
    [Address(RVA = "0x32EC4BC", Offset = "0x32EC4BC", VA = "0x32EC4BC")]
    private void LoadAdvLockDefault()
    {
    }

    [Token(Token = "0x6004C2C")]
    [Address(RVA = "0x32EC524", Offset = "0x32EC524", VA = "0x32EC524")]
    public AdvOptionOneMaster LoadAdvOptionOne(string path) => (AdvOptionOneMaster) null;

    [Token(Token = "0x6004C2D")]
    [Address(RVA = "0x32EC57C", Offset = "0x32EC57C", VA = "0x32EC57C")]
    private void LoadAdvOptionOneDefault()
    {
    }

    [Token(Token = "0x6004C2E")]
    [Address(RVA = "0x32EC5E4", Offset = "0x32EC5E4", VA = "0x32EC5E4")]
    public AdvOptionMaster LoadAdvOption(string path) => (AdvOptionMaster) null;

    [Token(Token = "0x6004C2F")]
    [Address(RVA = "0x32EC63C", Offset = "0x32EC63C", VA = "0x32EC63C")]
    private void LoadAdvOptionDefault()
    {
    }

    [Token(Token = "0x6004C30")]
    [Address(RVA = "0x32EC6A4", Offset = "0x32EC6A4", VA = "0x32EC6A4")]
    public AdvProcessOneMaster LoadAdvProcessOne(string path) => (AdvProcessOneMaster) null;

    [Token(Token = "0x6004C31")]
    [Address(RVA = "0x32EC6FC", Offset = "0x32EC6FC", VA = "0x32EC6FC")]
    private void LoadAdvProcessOneDefault()
    {
    }

    [Token(Token = "0x6004C32")]
    [Address(RVA = "0x32EC764", Offset = "0x32EC764", VA = "0x32EC764")]
    public AdvVariablesMaster LoadAdvVariables(string path) => (AdvVariablesMaster) null;

    [Token(Token = "0x6004C33")]
    [Address(RVA = "0x32EC7BC", Offset = "0x32EC7BC", VA = "0x32EC7BC")]
    private void LoadAdvVariablesDefault()
    {
    }

    [Token(Token = "0x6004C34")]
    [Address(RVA = "0x32EC824", Offset = "0x32EC824", VA = "0x32EC824")]
    public AdvVariableTypeMaster LoadAdvVariableType(string path) => (AdvVariableTypeMaster) null;

    [Token(Token = "0x6004C35")]
    [Address(RVA = "0x32EC87C", Offset = "0x32EC87C", VA = "0x32EC87C")]
    private void LoadAdvVariableTypeDefault()
    {
    }

    [Token(Token = "0x6004C36")]
    [Address(RVA = "0x32EC8E4", Offset = "0x32EC8E4", VA = "0x32EC8E4")]
    public StoryAdvChoicesMaster LoadStoryAdvChoices(string path) => (StoryAdvChoicesMaster) null;

    [Token(Token = "0x6004C37")]
    [Address(RVA = "0x32EC93C", Offset = "0x32EC93C", VA = "0x32EC93C")]
    private void LoadStoryAdvChoicesDefault()
    {
    }

    [Token(Token = "0x6004C38")]
    [Address(RVA = "0x32EC9A4", Offset = "0x32EC9A4", VA = "0x32EC9A4")]
    public StoryAdvInfoMaster LoadStoryAdvInfo(string path) => (StoryAdvInfoMaster) null;

    [Token(Token = "0x6004C39")]
    [Address(RVA = "0x32EC9FC", Offset = "0x32EC9FC", VA = "0x32EC9FC")]
    private void LoadStoryAdvInfoDefault()
    {
    }

    [Token(Token = "0x6004C3A")]
    [Address(RVA = "0x32ECA64", Offset = "0x32ECA64", VA = "0x32ECA64")]
    public StoryAdvTypeMaster LoadStoryAdvType(string path) => (StoryAdvTypeMaster) null;

    [Token(Token = "0x6004C3B")]
    [Address(RVA = "0x32ECABC", Offset = "0x32ECABC", VA = "0x32ECABC")]
    private void LoadStoryAdvTypeDefault()
    {
    }

    [Token(Token = "0x6004C3C")]
    [Address(RVA = "0x32ECB24", Offset = "0x32ECB24", VA = "0x32ECB24")]
    public AIRoleMaster LoadAIRole(string path) => (AIRoleMaster) null;

    [Token(Token = "0x6004C3D")]
    [Address(RVA = "0x32ECB7C", Offset = "0x32ECB7C", VA = "0x32ECB7C")]
    private void LoadAIRoleDefault()
    {
    }

    [Token(Token = "0x6004C3E")]
    [Address(RVA = "0x32ECBE4", Offset = "0x32ECBE4", VA = "0x32ECBE4")]
    public AITypeMaster LoadAIType(string path) => (AITypeMaster) null;

    [Token(Token = "0x6004C3F")]
    [Address(RVA = "0x32ECC3C", Offset = "0x32ECC3C", VA = "0x32ECC3C")]
    private void LoadAITypeDefault()
    {
    }

    [Token(Token = "0x6004C40")]
    [Address(RVA = "0x32ECCA4", Offset = "0x32ECCA4", VA = "0x32ECCA4")]
    public MoveTypeLandScoreMaster LoadMoveTypeLandScore(string path)
    {
      return (MoveTypeLandScoreMaster) null;
    }

    [Token(Token = "0x6004C41")]
    [Address(RVA = "0x32ECCFC", Offset = "0x32ECCFC", VA = "0x32ECCFC")]
    private void LoadMoveTypeLandScoreDefault()
    {
    }

    [Token(Token = "0x6004C42")]
    [Address(RVA = "0x32ECD64", Offset = "0x32ECD64", VA = "0x32ECD64")]
    public ArenaBattlePlacementMaster LoadArenaBattlePlacement(string path)
    {
      return (ArenaBattlePlacementMaster) null;
    }

    [Token(Token = "0x6004C43")]
    [Address(RVA = "0x32ECDBC", Offset = "0x32ECDBC", VA = "0x32ECDBC")]
    private void LoadArenaBattlePlacementDefault()
    {
    }

    [Token(Token = "0x6004C44")]
    [Address(RVA = "0x32ECE24", Offset = "0x32ECE24", VA = "0x32ECE24")]
    public ArenaBattleMaster LoadArenaBattle(string path) => (ArenaBattleMaster) null;

    [Token(Token = "0x6004C45")]
    [Address(RVA = "0x32ECE7C", Offset = "0x32ECE7C", VA = "0x32ECE7C")]
    private void LoadArenaBattleDefault()
    {
    }

    [Token(Token = "0x6004C46")]
    [Address(RVA = "0x32ECEE4", Offset = "0x32ECEE4", VA = "0x32ECEE4")]
    public ArenaFacilityPlacementMaster LoadArenaFacilityPlacement(string path)
    {
      return (ArenaFacilityPlacementMaster) null;
    }

    [Token(Token = "0x6004C47")]
    [Address(RVA = "0x32ECF3C", Offset = "0x32ECF3C", VA = "0x32ECF3C")]
    private void LoadArenaFacilityPlacementDefault()
    {
    }

    [Token(Token = "0x6004C48")]
    [Address(RVA = "0x32ECFA4", Offset = "0x32ECFA4", VA = "0x32ECFA4")]
    public ArenaNpcDeckGroupMaster LoadArenaNpcDeckGroup(string path)
    {
      return (ArenaNpcDeckGroupMaster) null;
    }

    [Token(Token = "0x6004C49")]
    [Address(RVA = "0x32ECFFC", Offset = "0x32ECFFC", VA = "0x32ECFFC")]
    private void LoadArenaNpcDeckGroupDefault()
    {
    }

    [Token(Token = "0x6004C4A")]
    [Address(RVA = "0x32ED064", Offset = "0x32ED064", VA = "0x32ED064")]
    public ArenaNpcNameGroupMaster LoadArenaNpcNameGroup(string path)
    {
      return (ArenaNpcNameGroupMaster) null;
    }

    [Token(Token = "0x6004C4B")]
    [Address(RVA = "0x32ED0BC", Offset = "0x32ED0BC", VA = "0x32ED0BC")]
    private void LoadArenaNpcNameGroupDefault()
    {
    }

    [Token(Token = "0x6004C4C")]
    [Address(RVA = "0x32ED124", Offset = "0x32ED124", VA = "0x32ED124")]
    public ArenaNpcMaster LoadArenaNpc(string path) => (ArenaNpcMaster) null;

    [Token(Token = "0x6004C4D")]
    [Address(RVA = "0x32ED17C", Offset = "0x32ED17C", VA = "0x32ED17C")]
    private void LoadArenaNpcDefault()
    {
    }

    [Token(Token = "0x6004C4E")]
    [Address(RVA = "0x32ED1E4", Offset = "0x32ED1E4", VA = "0x32ED1E4")]
    public ArenaConstMaster LoadArenaConst(string path) => (ArenaConstMaster) null;

    [Token(Token = "0x6004C4F")]
    [Address(RVA = "0x32ED23C", Offset = "0x32ED23C", VA = "0x32ED23C")]
    private void LoadArenaConstDefault()
    {
    }

    [Token(Token = "0x6004C50")]
    [Address(RVA = "0x32ED2A4", Offset = "0x32ED2A4", VA = "0x32ED2A4")]
    public ArenaGroupMaster LoadArenaGroup(string path) => (ArenaGroupMaster) null;

    [Token(Token = "0x6004C51")]
    [Address(RVA = "0x32ED2FC", Offset = "0x32ED2FC", VA = "0x32ED2FC")]
    private void LoadArenaGroupDefault()
    {
    }

    [Token(Token = "0x6004C52")]
    [Address(RVA = "0x32ED364", Offset = "0x32ED364", VA = "0x32ED364")]
    public ArenaDailyRewardGroupMaster LoadArenaDailyRewardGroup(string path)
    {
      return (ArenaDailyRewardGroupMaster) null;
    }

    [Token(Token = "0x6004C53")]
    [Address(RVA = "0x32ED3BC", Offset = "0x32ED3BC", VA = "0x32ED3BC")]
    private void LoadArenaDailyRewardGroupDefault()
    {
    }

    [Token(Token = "0x6004C54")]
    [Address(RVA = "0x32ED424", Offset = "0x32ED424", VA = "0x32ED424")]
    public ArenaDailyRewardSetMaster LoadArenaDailyRewardSet(string path)
    {
      return (ArenaDailyRewardSetMaster) null;
    }

    [Token(Token = "0x6004C55")]
    [Address(RVA = "0x32ED47C", Offset = "0x32ED47C", VA = "0x32ED47C")]
    private void LoadArenaDailyRewardSetDefault()
    {
    }

    [Token(Token = "0x6004C56")]
    [Address(RVA = "0x32ED4E4", Offset = "0x32ED4E4", VA = "0x32ED4E4")]
    public ArenaDailyRewardMaster LoadArenaDailyReward(string path)
    {
      return (ArenaDailyRewardMaster) null;
    }

    [Token(Token = "0x6004C57")]
    [Address(RVA = "0x32ED53C", Offset = "0x32ED53C", VA = "0x32ED53C")]
    private void LoadArenaDailyRewardDefault()
    {
    }

    [Token(Token = "0x6004C58")]
    [Address(RVA = "0x32ED5A4", Offset = "0x32ED5A4", VA = "0x32ED5A4")]
    public ArenaDailyRewardTermMaster LoadArenaDailyRewardTerm(string path)
    {
      return (ArenaDailyRewardTermMaster) null;
    }

    [Token(Token = "0x6004C59")]
    [Address(RVA = "0x32ED5FC", Offset = "0x32ED5FC", VA = "0x32ED5FC")]
    private void LoadArenaDailyRewardTermDefault()
    {
    }

    [Token(Token = "0x6004C5A")]
    [Address(RVA = "0x32ED664", Offset = "0x32ED664", VA = "0x32ED664")]
    public ArenaWeeklyRewardGroupMaster LoadArenaWeeklyRewardGroup(string path)
    {
      return (ArenaWeeklyRewardGroupMaster) null;
    }

    [Token(Token = "0x6004C5B")]
    [Address(RVA = "0x32ED6BC", Offset = "0x32ED6BC", VA = "0x32ED6BC")]
    private void LoadArenaWeeklyRewardGroupDefault()
    {
    }

    [Token(Token = "0x6004C5C")]
    [Address(RVA = "0x32ED724", Offset = "0x32ED724", VA = "0x32ED724")]
    public ArenaWeeklyRewardSetMaster LoadArenaWeeklyRewardSet(string path)
    {
      return (ArenaWeeklyRewardSetMaster) null;
    }

    [Token(Token = "0x6004C5D")]
    [Address(RVA = "0x32ED77C", Offset = "0x32ED77C", VA = "0x32ED77C")]
    private void LoadArenaWeeklyRewardSetDefault()
    {
    }

    [Token(Token = "0x6004C5E")]
    [Address(RVA = "0x32ED7E4", Offset = "0x32ED7E4", VA = "0x32ED7E4")]
    public ArenaWeeklyRewardMaster LoadArenaWeeklyReward(string path)
    {
      return (ArenaWeeklyRewardMaster) null;
    }

    [Token(Token = "0x6004C5F")]
    [Address(RVA = "0x32ED83C", Offset = "0x32ED83C", VA = "0x32ED83C")]
    private void LoadArenaWeeklyRewardDefault()
    {
    }

    [Token(Token = "0x6004C60")]
    [Address(RVA = "0x32ED8A4", Offset = "0x32ED8A4", VA = "0x32ED8A4")]
    public ArenaWeeklyRewardTermMaster LoadArenaWeeklyRewardTerm(string path)
    {
      return (ArenaWeeklyRewardTermMaster) null;
    }

    [Token(Token = "0x6004C61")]
    [Address(RVA = "0x32ED8FC", Offset = "0x32ED8FC", VA = "0x32ED8FC")]
    private void LoadArenaWeeklyRewardTermDefault()
    {
    }

    [Token(Token = "0x6004C62")]
    [Address(RVA = "0x32ED964", Offset = "0x32ED964", VA = "0x32ED964")]
    public BattleAdvMaster LoadBattleAdv(string path) => (BattleAdvMaster) null;

    [Token(Token = "0x6004C63")]
    [Address(RVA = "0x32ED9BC", Offset = "0x32ED9BC", VA = "0x32ED9BC")]
    private void LoadBattleAdvDefault()
    {
    }

    [Token(Token = "0x6004C64")]
    [Address(RVA = "0x32EDA24", Offset = "0x32EDA24", VA = "0x32EDA24")]
    public BattleAdvTriggerMaster LoadBattleAdvTrigger(string path)
    {
      return (BattleAdvTriggerMaster) null;
    }

    [Token(Token = "0x6004C65")]
    [Address(RVA = "0x32EDA7C", Offset = "0x32EDA7C", VA = "0x32EDA7C")]
    private void LoadBattleAdvTriggerDefault()
    {
    }

    [Token(Token = "0x6004C66")]
    [Address(RVA = "0x32EDAE4", Offset = "0x32EDAE4", VA = "0x32EDAE4")]
    public BarrierMaster LoadBarrier(string path) => (BarrierMaster) null;

    [Token(Token = "0x6004C67")]
    [Address(RVA = "0x32EDB3C", Offset = "0x32EDB3C", VA = "0x32EDB3C")]
    private void LoadBarrierDefault()
    {
    }

    [Token(Token = "0x6004C68")]
    [Address(RVA = "0x32EDBA4", Offset = "0x32EDBA4", VA = "0x32EDBA4")]
    public BattleBadStatusDetailMaster LoadBattleBadStatusDetail(string path)
    {
      return (BattleBadStatusDetailMaster) null;
    }

    [Token(Token = "0x6004C69")]
    [Address(RVA = "0x32EDBFC", Offset = "0x32EDBFC", VA = "0x32EDBFC")]
    private void LoadBattleBadStatusDetailDefault()
    {
    }

    [Token(Token = "0x6004C6A")]
    [Address(RVA = "0x32EDC64", Offset = "0x32EDC64", VA = "0x32EDC64")]
    public BattleBadStatusGroupMaster LoadBattleBadStatusGroup(string path)
    {
      return (BattleBadStatusGroupMaster) null;
    }

    [Token(Token = "0x6004C6B")]
    [Address(RVA = "0x32EDCBC", Offset = "0x32EDCBC", VA = "0x32EDCBC")]
    private void LoadBattleBadStatusGroupDefault()
    {
    }

    [Token(Token = "0x6004C6C")]
    [Address(RVA = "0x32EDD24", Offset = "0x32EDD24", VA = "0x32EDD24")]
    public BattleBadStatusMaster LoadBattleBadStatus(string path) => (BattleBadStatusMaster) null;

    [Token(Token = "0x6004C6D")]
    [Address(RVA = "0x32EDD7C", Offset = "0x32EDD7C", VA = "0x32EDD7C")]
    private void LoadBattleBadStatusDefault()
    {
    }

    [Token(Token = "0x6004C6E")]
    [Address(RVA = "0x32EDDE4", Offset = "0x32EDDE4", VA = "0x32EDDE4")]
    public BattleClearConditionNameMaster LoadBattleClearConditionName(string path)
    {
      return (BattleClearConditionNameMaster) null;
    }

    [Token(Token = "0x6004C6F")]
    [Address(RVA = "0x32EDE3C", Offset = "0x32EDE3C", VA = "0x32EDE3C")]
    private void LoadBattleClearConditionNameDefault()
    {
    }

    [Token(Token = "0x6004C70")]
    [Address(RVA = "0x32EDEA4", Offset = "0x32EDEA4", VA = "0x32EDEA4")]
    public BattleClearConditionMaster LoadBattleClearCondition(string path)
    {
      return (BattleClearConditionMaster) null;
    }

    [Token(Token = "0x6004C71")]
    [Address(RVA = "0x32EDEFC", Offset = "0x32EDEFC", VA = "0x32EDEFC")]
    private void LoadBattleClearConditionDefault()
    {
    }

    [Token(Token = "0x6004C72")]
    [Address(RVA = "0x32EDF64", Offset = "0x32EDF64", VA = "0x32EDF64")]
    public BattleDistanceEffectRatioMaster LoadBattleDistanceEffectRatio(string path)
    {
      return (BattleDistanceEffectRatioMaster) null;
    }

    [Token(Token = "0x6004C73")]
    [Address(RVA = "0x32EDFBC", Offset = "0x32EDFBC", VA = "0x32EDFBC")]
    private void LoadBattleDistanceEffectRatioDefault()
    {
    }

    [Token(Token = "0x6004C74")]
    [Address(RVA = "0x32EE024", Offset = "0x32EE024", VA = "0x32EE024")]
    public BattleDistanceInvEffectRatioMaster LoadBattleDistanceInvEffectRatio(string path)
    {
      return (BattleDistanceInvEffectRatioMaster) null;
    }

    [Token(Token = "0x6004C75")]
    [Address(RVA = "0x32EE07C", Offset = "0x32EE07C", VA = "0x32EE07C")]
    private void LoadBattleDistanceInvEffectRatioDefault()
    {
    }

    [Token(Token = "0x6004C76")]
    [Address(RVA = "0x32EE0E4", Offset = "0x32EE0E4", VA = "0x32EE0E4")]
    public BattleEffectTypeDetailMaster LoadBattleEffectTypeDetail(string path)
    {
      return (BattleEffectTypeDetailMaster) null;
    }

    [Token(Token = "0x6004C77")]
    [Address(RVA = "0x32EE13C", Offset = "0x32EE13C", VA = "0x32EE13C")]
    private void LoadBattleEffectTypeDetailDefault()
    {
    }

    [Token(Token = "0x6004C78")]
    [Address(RVA = "0x32EE1A4", Offset = "0x32EE1A4", VA = "0x32EE1A4")]
    public BattleElementChainMaster LoadBattleElementChain(string path)
    {
      return (BattleElementChainMaster) null;
    }

    [Token(Token = "0x6004C79")]
    [Address(RVA = "0x32EE1FC", Offset = "0x32EE1FC", VA = "0x32EE1FC")]
    private void LoadBattleElementChainDefault()
    {
    }

    [Token(Token = "0x6004C7A")]
    [Address(RVA = "0x32EE264", Offset = "0x32EE264", VA = "0x32EE264")]
    public BattleFailedConditionNameMaster LoadBattleFailedConditionName(string path)
    {
      return (BattleFailedConditionNameMaster) null;
    }

    [Token(Token = "0x6004C7B")]
    [Address(RVA = "0x32EE2BC", Offset = "0x32EE2BC", VA = "0x32EE2BC")]
    private void LoadBattleFailedConditionNameDefault()
    {
    }

    [Token(Token = "0x6004C7C")]
    [Address(RVA = "0x32EE324", Offset = "0x32EE324", VA = "0x32EE324")]
    public BattleFailedConditionMaster LoadBattleFailedCondition(string path)
    {
      return (BattleFailedConditionMaster) null;
    }

    [Token(Token = "0x6004C7D")]
    [Address(RVA = "0x32EE37C", Offset = "0x32EE37C", VA = "0x32EE37C")]
    private void LoadBattleFailedConditionDefault()
    {
    }

    [Token(Token = "0x6004C7E")]
    [Address(RVA = "0x32EE3E4", Offset = "0x32EE3E4", VA = "0x32EE3E4")]
    public BattleHpInvRatioEffectRatioMaster LoadBattleHpInvRatioEffectRatio(string path)
    {
      return (BattleHpInvRatioEffectRatioMaster) null;
    }

    [Token(Token = "0x6004C7F")]
    [Address(RVA = "0x32EE43C", Offset = "0x32EE43C", VA = "0x32EE43C")]
    private void LoadBattleHpInvRatioEffectRatioDefault()
    {
    }

    [Token(Token = "0x6004C80")]
    [Address(RVA = "0x32EE4A4", Offset = "0x32EE4A4", VA = "0x32EE4A4")]
    public BattleHpRatioEffectRatioMaster LoadBattleHpRatioEffectRatio(string path)
    {
      return (BattleHpRatioEffectRatioMaster) null;
    }

    [Token(Token = "0x6004C81")]
    [Address(RVA = "0x32EE4FC", Offset = "0x32EE4FC", VA = "0x32EE4FC")]
    private void LoadBattleHpRatioEffectRatioDefault()
    {
    }

    [Token(Token = "0x6004C82")]
    [Address(RVA = "0x32EE564", Offset = "0x32EE564", VA = "0x32EE564")]
    public BattleLandCorrectMaster LoadBattleLandCorrect(string path)
    {
      return (BattleLandCorrectMaster) null;
    }

    [Token(Token = "0x6004C83")]
    [Address(RVA = "0x32EE5BC", Offset = "0x32EE5BC", VA = "0x32EE5BC")]
    private void LoadBattleLandCorrectDefault()
    {
    }

    [Token(Token = "0x6004C84")]
    [Address(RVA = "0x32EE624", Offset = "0x32EE624", VA = "0x32EE624")]
    public BattleLogTextFormatMaster LoadBattleLogTextFormat(string path)
    {
      return (BattleLogTextFormatMaster) null;
    }

    [Token(Token = "0x6004C85")]
    [Address(RVA = "0x32EE67C", Offset = "0x32EE67C", VA = "0x32EE67C")]
    private void LoadBattleLogTextFormatDefault()
    {
    }

    [Token(Token = "0x6004C86")]
    [Address(RVA = "0x32EE6E4", Offset = "0x32EE6E4", VA = "0x32EE6E4")]
    public BattleMoveCountEffectRatioMaster LoadBattleMoveCountEffectRatio(string path)
    {
      return (BattleMoveCountEffectRatioMaster) null;
    }

    [Token(Token = "0x6004C87")]
    [Address(RVA = "0x32EE73C", Offset = "0x32EE73C", VA = "0x32EE73C")]
    private void LoadBattleMoveCountEffectRatioDefault()
    {
    }

    [Token(Token = "0x6004C88")]
    [Address(RVA = "0x32EE7A4", Offset = "0x32EE7A4", VA = "0x32EE7A4")]
    public BattleMoveCountInvEffectRatioMaster LoadBattleMoveCountInvEffectRatio(string path)
    {
      return (BattleMoveCountInvEffectRatioMaster) null;
    }

    [Token(Token = "0x6004C89")]
    [Address(RVA = "0x32EE7FC", Offset = "0x32EE7FC", VA = "0x32EE7FC")]
    private void LoadBattleMoveCountInvEffectRatioDefault()
    {
    }

    [Token(Token = "0x6004C8A")]
    [Address(RVA = "0x32EE864", Offset = "0x32EE864", VA = "0x32EE864")]
    public BattlePowerConstantMaster LoadBattlePowerConstant(string path)
    {
      return (BattlePowerConstantMaster) null;
    }

    [Token(Token = "0x6004C8B")]
    [Address(RVA = "0x32EE8BC", Offset = "0x32EE8BC", VA = "0x32EE8BC")]
    private void LoadBattlePowerConstantDefault()
    {
    }

    [Token(Token = "0x6004C8C")]
    [Address(RVA = "0x32EE924", Offset = "0x32EE924", VA = "0x32EE924")]
    public BattleSlayEffectRatioMaster LoadBattleSlayEffectRatio(string path)
    {
      return (BattleSlayEffectRatioMaster) null;
    }

    [Token(Token = "0x6004C8D")]
    [Address(RVA = "0x32EE97C", Offset = "0x32EE97C", VA = "0x32EE97C")]
    private void LoadBattleSlayEffectRatioDefault()
    {
    }

    [Token(Token = "0x6004C8E")]
    [Address(RVA = "0x32EE9E4", Offset = "0x32EE9E4", VA = "0x32EE9E4")]
    public BattleSortieConditionMaster LoadBattleSortieCondition(string path)
    {
      return (BattleSortieConditionMaster) null;
    }

    [Token(Token = "0x6004C8F")]
    [Address(RVA = "0x32EEA3C", Offset = "0x32EEA3C", VA = "0x32EEA3C")]
    private void LoadBattleSortieConditionDefault()
    {
    }

    [Token(Token = "0x6004C90")]
    [Address(RVA = "0x32EEAA4", Offset = "0x32EEAA4", VA = "0x32EEAA4")]
    public BattleMaster LoadBattle(string path) => (BattleMaster) null;

    [Token(Token = "0x6004C91")]
    [Address(RVA = "0x32EEAFC", Offset = "0x32EEAFC", VA = "0x32EEAFC")]
    private void LoadBattleDefault()
    {
    }

    [Token(Token = "0x6004C92")]
    [Address(RVA = "0x32EEB64", Offset = "0x32EEB64", VA = "0x32EEB64")]
    public BattleVoiceCombiMaster LoadBattleVoiceCombi(string path)
    {
      return (BattleVoiceCombiMaster) null;
    }

    [Token(Token = "0x6004C93")]
    [Address(RVA = "0x32EEBBC", Offset = "0x32EEBBC", VA = "0x32EEBBC")]
    private void LoadBattleVoiceCombiDefault()
    {
    }

    [Token(Token = "0x6004C94")]
    [Address(RVA = "0x32EEC24", Offset = "0x32EEC24", VA = "0x32EEC24")]
    public BattleVoiceMaster LoadBattleVoice(string path) => (BattleVoiceMaster) null;

    [Token(Token = "0x6004C95")]
    [Address(RVA = "0x32EEC7C", Offset = "0x32EEC7C", VA = "0x32EEC7C")]
    private void LoadBattleVoiceDefault()
    {
    }

    [Token(Token = "0x6004C96")]
    [Address(RVA = "0x32EECE4", Offset = "0x32EECE4", VA = "0x32EECE4")]
    public BattleConstMaster LoadBattleConst(string path) => (BattleConstMaster) null;

    [Token(Token = "0x6004C97")]
    [Address(RVA = "0x32EED3C", Offset = "0x32EED3C", VA = "0x32EED3C")]
    private void LoadBattleConstDefault()
    {
    }

    [Token(Token = "0x6004C98")]
    [Address(RVA = "0x32EEDA4", Offset = "0x32EEDA4", VA = "0x32EEDA4")]
    public BattleLogicConstMaster LoadBattleLogicConst(string path)
    {
      return (BattleLogicConstMaster) null;
    }

    [Token(Token = "0x6004C99")]
    [Address(RVA = "0x32EEDFC", Offset = "0x32EEDFC", VA = "0x32EEDFC")]
    private void LoadBattleLogicConstDefault()
    {
    }

    [Token(Token = "0x6004C9A")]
    [Address(RVA = "0x32EEE64", Offset = "0x32EEE64", VA = "0x32EEE64")]
    public BattleDropDescriptionMaster LoadBattleDropDescription(string path)
    {
      return (BattleDropDescriptionMaster) null;
    }

    [Token(Token = "0x6004C9B")]
    [Address(RVA = "0x32EEEBC", Offset = "0x32EEEBC", VA = "0x32EEEBC")]
    private void LoadBattleDropDescriptionDefault()
    {
    }

    [Token(Token = "0x6004C9C")]
    [Address(RVA = "0x32EEF24", Offset = "0x32EEF24", VA = "0x32EEF24")]
    public BattleDropSetDescriptionMaster LoadBattleDropSetDescription(string path)
    {
      return (BattleDropSetDescriptionMaster) null;
    }

    [Token(Token = "0x6004C9D")]
    [Address(RVA = "0x32EEF7C", Offset = "0x32EEF7C", VA = "0x32EEF7C")]
    private void LoadBattleDropSetDescriptionDefault()
    {
    }

    [Token(Token = "0x6004C9E")]
    [Address(RVA = "0x32EEFE4", Offset = "0x32EEFE4", VA = "0x32EEFE4")]
    public BattleDropSetMaster LoadBattleDropSet(string path) => (BattleDropSetMaster) null;

    [Token(Token = "0x6004C9F")]
    [Address(RVA = "0x32EF03C", Offset = "0x32EF03C", VA = "0x32EF03C")]
    private void LoadBattleDropSetDefault()
    {
    }

    [Token(Token = "0x6004CA0")]
    [Address(RVA = "0x32EF0A4", Offset = "0x32EF0A4", VA = "0x32EF0A4")]
    public BattleEnemyPlacementDescriptionMaster LoadBattleEnemyPlacementDescription(string path)
    {
      return (BattleEnemyPlacementDescriptionMaster) null;
    }

    [Token(Token = "0x6004CA1")]
    [Address(RVA = "0x32EF0FC", Offset = "0x32EF0FC", VA = "0x32EF0FC")]
    private void LoadBattleEnemyPlacementDescriptionDefault()
    {
    }

    [Token(Token = "0x6004CA2")]
    [Address(RVA = "0x32EF164", Offset = "0x32EF164", VA = "0x32EF164")]
    public BattleEnemyPlacementMaster LoadBattleEnemyPlacement(string path)
    {
      return (BattleEnemyPlacementMaster) null;
    }

    [Token(Token = "0x6004CA3")]
    [Address(RVA = "0x32EF1BC", Offset = "0x32EF1BC", VA = "0x32EF1BC")]
    private void LoadBattleEnemyPlacementDefault()
    {
    }

    [Token(Token = "0x6004CA4")]
    [Address(RVA = "0x32EF224", Offset = "0x32EF224", VA = "0x32EF224")]
    public BattleEnemyTroopsMaster LoadBattleEnemyTroops(string path)
    {
      return (BattleEnemyTroopsMaster) null;
    }

    [Token(Token = "0x6004CA5")]
    [Address(RVA = "0x32EF27C", Offset = "0x32EF27C", VA = "0x32EF27C")]
    private void LoadBattleEnemyTroopsDefault()
    {
    }

    [Token(Token = "0x6004CA6")]
    [Address(RVA = "0x32EF2E4", Offset = "0x32EF2E4", VA = "0x32EF2E4")]
    public BattleRaidEnemyPlacementDescriptionMaster LoadBattleRaidEnemyPlacementDescription(
      string path)
    {
      return (BattleRaidEnemyPlacementDescriptionMaster) null;
    }

    [Token(Token = "0x6004CA7")]
    [Address(RVA = "0x32EF33C", Offset = "0x32EF33C", VA = "0x32EF33C")]
    private void LoadBattleRaidEnemyPlacementDescriptionDefault()
    {
    }

    [Token(Token = "0x6004CA8")]
    [Address(RVA = "0x32EF3A4", Offset = "0x32EF3A4", VA = "0x32EF3A4")]
    public LandTagMaster LoadLandTag(string path) => (LandTagMaster) null;

    [Token(Token = "0x6004CA9")]
    [Address(RVA = "0x32EF3FC", Offset = "0x32EF3FC", VA = "0x32EF3FC")]
    private void LoadLandTagDefault()
    {
    }

    [Token(Token = "0x6004CAA")]
    [Address(RVA = "0x32EF464", Offset = "0x32EF464", VA = "0x32EF464")]
    public BattleForcedSortieMaster LoadBattleForcedSortie(string path)
    {
      return (BattleForcedSortieMaster) null;
    }

    [Token(Token = "0x6004CAB")]
    [Address(RVA = "0x32EF4BC", Offset = "0x32EF4BC", VA = "0x32EF4BC")]
    private void LoadBattleForcedSortieDefault()
    {
    }

    [Token(Token = "0x6004CAC")]
    [Address(RVA = "0x32EF524", Offset = "0x32EF524", VA = "0x32EF524")]
    public BattleGuestPlacementDescriptionMaster LoadBattleGuestPlacementDescription(string path)
    {
      return (BattleGuestPlacementDescriptionMaster) null;
    }

    [Token(Token = "0x6004CAD")]
    [Address(RVA = "0x32EF57C", Offset = "0x32EF57C", VA = "0x32EF57C")]
    private void LoadBattleGuestPlacementDescriptionDefault()
    {
    }

    [Token(Token = "0x6004CAE")]
    [Address(RVA = "0x32EF5E4", Offset = "0x32EF5E4", VA = "0x32EF5E4")]
    public BattleGuestTroopsMaster LoadBattleGuestTroops(string path)
    {
      return (BattleGuestTroopsMaster) null;
    }

    [Token(Token = "0x6004CAF")]
    [Address(RVA = "0x32EF63C", Offset = "0x32EF63C", VA = "0x32EF63C")]
    private void LoadBattleGuestTroopsDefault()
    {
    }

    [Token(Token = "0x6004CB0")]
    [Address(RVA = "0x32EF6A4", Offset = "0x32EF6A4", VA = "0x32EF6A4")]
    public BattleInitialPlacementDescriptionMaster LoadBattleInitialPlacementDescription(string path)
    {
      return (BattleInitialPlacementDescriptionMaster) null;
    }

    [Token(Token = "0x6004CB1")]
    [Address(RVA = "0x32EF6FC", Offset = "0x32EF6FC", VA = "0x32EF6FC")]
    private void LoadBattleInitialPlacementDescriptionDefault()
    {
    }

    [Token(Token = "0x6004CB2")]
    [Address(RVA = "0x32EF764", Offset = "0x32EF764", VA = "0x32EF764")]
    public BattleInitialPlacementMaster LoadBattleInitialPlacement(string path)
    {
      return (BattleInitialPlacementMaster) null;
    }

    [Token(Token = "0x6004CB3")]
    [Address(RVA = "0x32EF7BC", Offset = "0x32EF7BC", VA = "0x32EF7BC")]
    private void LoadBattleInitialPlacementDefault()
    {
    }

    [Token(Token = "0x6004CB4")]
    [Address(RVA = "0x32EF824", Offset = "0x32EF824", VA = "0x32EF824")]
    public BattleMissionSetMaster LoadBattleMissionSet(string path)
    {
      return (BattleMissionSetMaster) null;
    }

    [Token(Token = "0x6004CB5")]
    [Address(RVA = "0x32EF87C", Offset = "0x32EF87C", VA = "0x32EF87C")]
    private void LoadBattleMissionSetDefault()
    {
    }

    [Token(Token = "0x6004CB6")]
    [Address(RVA = "0x32EF8E4", Offset = "0x32EF8E4", VA = "0x32EF8E4")]
    public BattleMissionMaster LoadBattleMission(string path) => (BattleMissionMaster) null;

    [Token(Token = "0x6004CB7")]
    [Address(RVA = "0x32EF93C", Offset = "0x32EF93C", VA = "0x32EF93C")]
    private void LoadBattleMissionDefault()
    {
    }

    [Token(Token = "0x6004CB8")]
    [Address(RVA = "0x32EF9A4", Offset = "0x32EF9A4", VA = "0x32EF9A4")]
    public NpcUnitDataMaster LoadNpcUnitData(string path) => (NpcUnitDataMaster) null;

    [Token(Token = "0x6004CB9")]
    [Address(RVA = "0x32EF9FC", Offset = "0x32EF9FC", VA = "0x32EF9FC")]
    private void LoadNpcUnitDataDefault()
    {
    }

    [Token(Token = "0x6004CBA")]
    [Address(RVA = "0x32EFA64", Offset = "0x32EFA64", VA = "0x32EFA64")]
    public BattleFacilityPlacementDescriptionMaster LoadBattleFacilityPlacementDescription(
      string path)
    {
      return (BattleFacilityPlacementDescriptionMaster) null;
    }

    [Token(Token = "0x6004CBB")]
    [Address(RVA = "0x32EFABC", Offset = "0x32EFABC", VA = "0x32EFABC")]
    private void LoadBattleFacilityPlacementDescriptionDefault()
    {
    }

    [Token(Token = "0x6004CBC")]
    [Address(RVA = "0x32EFB24", Offset = "0x32EFB24", VA = "0x32EFB24")]
    public BattleFacilityPlacementMaster LoadBattleFacilityPlacement(string path)
    {
      return (BattleFacilityPlacementMaster) null;
    }

    [Token(Token = "0x6004CBD")]
    [Address(RVA = "0x32EFB7C", Offset = "0x32EFB7C", VA = "0x32EFB7C")]
    private void LoadBattleFacilityPlacementDefault()
    {
    }

    [Token(Token = "0x6004CBE")]
    [Address(RVA = "0x32EFBE4", Offset = "0x32EFBE4", VA = "0x32EFBE4")]
    public BattleFacilityMaster LoadBattleFacility(string path) => (BattleFacilityMaster) null;

    [Token(Token = "0x6004CBF")]
    [Address(RVA = "0x32EFC3C", Offset = "0x32EFC3C", VA = "0x32EFC3C")]
    private void LoadBattleFacilityDefault()
    {
    }

    [Token(Token = "0x6004CC0")]
    [Address(RVA = "0x32EFCA4", Offset = "0x32EFCA4", VA = "0x32EFCA4")]
    public BattleRewardDescriptionMaster LoadBattleRewardDescription(string path)
    {
      return (BattleRewardDescriptionMaster) null;
    }

    [Token(Token = "0x6004CC1")]
    [Address(RVA = "0x32EFCFC", Offset = "0x32EFCFC", VA = "0x32EFCFC")]
    private void LoadBattleRewardDescriptionDefault()
    {
    }

    [Token(Token = "0x6004CC2")]
    [Address(RVA = "0x32EFD64", Offset = "0x32EFD64", VA = "0x32EFD64")]
    public BattleSortieRestrictionsMaster LoadBattleSortieRestrictions(string path)
    {
      return (BattleSortieRestrictionsMaster) null;
    }

    [Token(Token = "0x6004CC3")]
    [Address(RVA = "0x32EFDBC", Offset = "0x32EFDBC", VA = "0x32EFDBC")]
    private void LoadBattleSortieRestrictionsDefault()
    {
    }

    [Token(Token = "0x6004CC4")]
    [Address(RVA = "0x32EFE24", Offset = "0x32EFE24", VA = "0x32EFE24")]
    public StoryBattleMissionRewardDescriptionMaster LoadStoryBattleMissionRewardDescription(
      string path)
    {
      return (StoryBattleMissionRewardDescriptionMaster) null;
    }

    [Token(Token = "0x6004CC5")]
    [Address(RVA = "0x32EFE7C", Offset = "0x32EFE7C", VA = "0x32EFE7C")]
    private void LoadStoryBattleMissionRewardDescriptionDefault()
    {
    }

    [Token(Token = "0x6004CC6")]
    [Address(RVA = "0x32EFEE4", Offset = "0x32EFEE4", VA = "0x32EFEE4")]
    public StoryBattleMissionRewardMaster LoadStoryBattleMissionReward(string path)
    {
      return (StoryBattleMissionRewardMaster) null;
    }

    [Token(Token = "0x6004CC7")]
    [Address(RVA = "0x32EFF3C", Offset = "0x32EFF3C", VA = "0x32EFF3C")]
    private void LoadStoryBattleMissionRewardDefault()
    {
    }

    [Token(Token = "0x6004CC8")]
    [Address(RVA = "0x32EFFA4", Offset = "0x32EFFA4", VA = "0x32EFFA4")]
    public StoryBattleMissionMaster LoadStoryBattleMission(string path)
    {
      return (StoryBattleMissionMaster) null;
    }

    [Token(Token = "0x6004CC9")]
    [Address(RVA = "0x32EFFFC", Offset = "0x32EFFFC", VA = "0x32EFFFC")]
    private void LoadStoryBattleMissionDefault()
    {
    }

    [Token(Token = "0x6004CCA")]
    [Address(RVA = "0x32F0064", Offset = "0x32F0064", VA = "0x32F0064")]
    public BattleThirdarmyPlacementDescriptionMaster LoadBattleThirdarmyPlacementDescription(
      string path)
    {
      return (BattleThirdarmyPlacementDescriptionMaster) null;
    }

    [Token(Token = "0x6004CCB")]
    [Address(RVA = "0x32F00BC", Offset = "0x32F00BC", VA = "0x32F00BC")]
    private void LoadBattleThirdarmyPlacementDescriptionDefault()
    {
    }

    [Token(Token = "0x6004CCC")]
    [Address(RVA = "0x32F0124", Offset = "0x32F0124", VA = "0x32F0124")]
    public BattleThirdarmyPlacementMaster LoadBattleThirdarmyPlacement(string path)
    {
      return (BattleThirdarmyPlacementMaster) null;
    }

    [Token(Token = "0x6004CCD")]
    [Address(RVA = "0x32F017C", Offset = "0x32F017C", VA = "0x32F017C")]
    private void LoadBattleThirdarmyPlacementDefault()
    {
    }

    [Token(Token = "0x6004CCE")]
    [Address(RVA = "0x32F01E4", Offset = "0x32F01E4", VA = "0x32F01E4")]
    public BattleThirdarmyTroopsMaster LoadBattleThirdarmyTroops(string path)
    {
      return (BattleThirdarmyTroopsMaster) null;
    }

    [Token(Token = "0x6004CCF")]
    [Address(RVA = "0x32F023C", Offset = "0x32F023C", VA = "0x32F023C")]
    private void LoadBattleThirdarmyTroopsDefault()
    {
    }

    [Token(Token = "0x6004CD0")]
    [Address(RVA = "0x32F02A4", Offset = "0x32F02A4", VA = "0x32F02A4")]
    public ChatConstMaster LoadChatConst(string path) => (ChatConstMaster) null;

    [Token(Token = "0x6004CD1")]
    [Address(RVA = "0x32F02FC", Offset = "0x32F02FC", VA = "0x32F02FC")]
    private void LoadChatConstDefault()
    {
    }

    [Token(Token = "0x6004CD2")]
    [Address(RVA = "0x32F0364", Offset = "0x32F0364", VA = "0x32F0364")]
    public ChatPhraseDefaultMaster LoadChatPhraseDefault(string path)
    {
      return (ChatPhraseDefaultMaster) null;
    }

    [Token(Token = "0x6004CD3")]
    [Address(RVA = "0x32F03BC", Offset = "0x32F03BC", VA = "0x32F03BC")]
    private void LoadChatPhraseDefaultDefault()
    {
    }

    [Token(Token = "0x6004CD4")]
    [Address(RVA = "0x32F0424", Offset = "0x32F0424", VA = "0x32F0424")]
    public ChatRoomMaster LoadChatRoom(string path) => (ChatRoomMaster) null;

    [Token(Token = "0x6004CD5")]
    [Address(RVA = "0x32F047C", Offset = "0x32F047C", VA = "0x32F047C")]
    private void LoadChatRoomDefault()
    {
    }

    [Token(Token = "0x6004CD6")]
    [Address(RVA = "0x32F04E4", Offset = "0x32F04E4", VA = "0x32F04E4")]
    public ChatStampMaster LoadChatStamp(string path) => (ChatStampMaster) null;

    [Token(Token = "0x6004CD7")]
    [Address(RVA = "0x32F053C", Offset = "0x32F053C", VA = "0x32F053C")]
    private void LoadChatStampDefault()
    {
    }

    [Token(Token = "0x6004CD8")]
    [Address(RVA = "0x32F05A4", Offset = "0x32F05A4", VA = "0x32F05A4")]
    public ButtonClickSEMaster LoadButtonClickSE(string path) => (ButtonClickSEMaster) null;

    [Token(Token = "0x6004CD9")]
    [Address(RVA = "0x32F05FC", Offset = "0x32F05FC", VA = "0x32F05FC")]
    private void LoadButtonClickSEDefault()
    {
    }

    [Token(Token = "0x6004CDA")]
    [Address(RVA = "0x32F0664", Offset = "0x32F0664", VA = "0x32F0664")]
    public ButtonLongPressSEMaster LoadButtonLongPressSE(string path)
    {
      return (ButtonLongPressSEMaster) null;
    }

    [Token(Token = "0x6004CDB")]
    [Address(RVA = "0x32F06BC", Offset = "0x32F06BC", VA = "0x32F06BC")]
    private void LoadButtonLongPressSEDefault()
    {
    }

    [Token(Token = "0x6004CDC")]
    [Address(RVA = "0x32F0724", Offset = "0x32F0724", VA = "0x32F0724")]
    public CommonEffectListMaster LoadCommonEffectList(string path)
    {
      return (CommonEffectListMaster) null;
    }

    [Token(Token = "0x6004CDD")]
    [Address(RVA = "0x32F077C", Offset = "0x32F077C", VA = "0x32F077C")]
    private void LoadCommonEffectListDefault()
    {
    }

    [Token(Token = "0x6004CDE")]
    [Address(RVA = "0x32F07E4", Offset = "0x32F07E4", VA = "0x32F07E4")]
    public ConstMaster LoadConst(string path) => (ConstMaster) null;

    [Token(Token = "0x6004CDF")]
    [Address(RVA = "0x32F083C", Offset = "0x32F083C", VA = "0x32F083C")]
    private void LoadConstDefault()
    {
    }

    [Token(Token = "0x6004CE0")]
    [Address(RVA = "0x32F08A4", Offset = "0x32F08A4", VA = "0x32F08A4")]
    public EquipmentClassificationMaster LoadEquipmentClassification(string path)
    {
      return (EquipmentClassificationMaster) null;
    }

    [Token(Token = "0x6004CE1")]
    [Address(RVA = "0x32F08FC", Offset = "0x32F08FC", VA = "0x32F08FC")]
    private void LoadEquipmentClassificationDefault()
    {
    }

    [Token(Token = "0x6004CE2")]
    [Address(RVA = "0x32F0964", Offset = "0x32F0964", VA = "0x32F0964")]
    public SubEquipmentClassificationDescriptionMaster LoadSubEquipmentClassificationDescription(
      string path)
    {
      return (SubEquipmentClassificationDescriptionMaster) null;
    }

    [Token(Token = "0x6004CE3")]
    [Address(RVA = "0x32F09BC", Offset = "0x32F09BC", VA = "0x32F09BC")]
    private void LoadSubEquipmentClassificationDescriptionDefault()
    {
    }

    [Token(Token = "0x6004CE4")]
    [Address(RVA = "0x32F0A24", Offset = "0x32F0A24", VA = "0x32F0A24")]
    public SubEquipmentClassificationMaster LoadSubEquipmentClassification(string path)
    {
      return (SubEquipmentClassificationMaster) null;
    }

    [Token(Token = "0x6004CE5")]
    [Address(RVA = "0x32F0A7C", Offset = "0x32F0A7C", VA = "0x32F0A7C")]
    private void LoadSubEquipmentClassificationDefault()
    {
    }

    [Token(Token = "0x6004CE6")]
    [Address(RVA = "0x32F0AE4", Offset = "0x32F0AE4", VA = "0x32F0AE4")]
    public FootstepsMaster LoadFootsteps(string path) => (FootstepsMaster) null;

    [Token(Token = "0x6004CE7")]
    [Address(RVA = "0x32F0B3C", Offset = "0x32F0B3C", VA = "0x32F0B3C")]
    private void LoadFootstepsDefault()
    {
    }

    [Token(Token = "0x6004CE8")]
    [Address(RVA = "0x32F0BA4", Offset = "0x32F0BA4", VA = "0x32F0BA4")]
    public GuidelineMaster LoadGuideline(string path) => (GuidelineMaster) null;

    [Token(Token = "0x6004CE9")]
    [Address(RVA = "0x32F0BFC", Offset = "0x32F0BFC", VA = "0x32F0BFC")]
    private void LoadGuidelineDefault()
    {
    }

    [Token(Token = "0x6004CEA")]
    [Address(RVA = "0x32F0C64", Offset = "0x32F0C64", VA = "0x32F0C64")]
    public NetworkErrorMaster LoadNetworkError(string path) => (NetworkErrorMaster) null;

    [Token(Token = "0x6004CEB")]
    [Address(RVA = "0x32F0CBC", Offset = "0x32F0CBC", VA = "0x32F0CBC")]
    private void LoadNetworkErrorDefault()
    {
    }

    [Token(Token = "0x6004CEC")]
    [Address(RVA = "0x32F0D24", Offset = "0x32F0D24", VA = "0x32F0D24")]
    public PenaltyMaster LoadPenalty(string path) => (PenaltyMaster) null;

    [Token(Token = "0x6004CED")]
    [Address(RVA = "0x32F0D7C", Offset = "0x32F0D7C", VA = "0x32F0D7C")]
    private void LoadPenaltyDefault()
    {
    }

    [Token(Token = "0x6004CEE")]
    [Address(RVA = "0x32F0DE4", Offset = "0x32F0DE4", VA = "0x32F0DE4")]
    public SaleMaster LoadSale(string path) => (SaleMaster) null;

    [Token(Token = "0x6004CEF")]
    [Address(RVA = "0x32F0E3C", Offset = "0x32F0E3C", VA = "0x32F0E3C")]
    private void LoadSaleDefault()
    {
    }

    [Token(Token = "0x6004CF0")]
    [Address(RVA = "0x32F0EA4", Offset = "0x32F0EA4", VA = "0x32F0EA4")]
    public SoulEnhanceValueMaster LoadSoulEnhanceValue(string path)
    {
      return (SoulEnhanceValueMaster) null;
    }

    [Token(Token = "0x6004CF1")]
    [Address(RVA = "0x32F0EFC", Offset = "0x32F0EFC", VA = "0x32F0EFC")]
    private void LoadSoulEnhanceValueDefault()
    {
    }

    [Token(Token = "0x6004CF2")]
    [Address(RVA = "0x32F0F64", Offset = "0x32F0F64", VA = "0x32F0F64")]
    public SpeciesDescriptionMaster LoadSpeciesDescription(string path)
    {
      return (SpeciesDescriptionMaster) null;
    }

    [Token(Token = "0x6004CF3")]
    [Address(RVA = "0x32F0FBC", Offset = "0x32F0FBC", VA = "0x32F0FBC")]
    private void LoadSpeciesDescriptionDefault()
    {
    }

    [Token(Token = "0x6004CF4")]
    [Address(RVA = "0x32F1024", Offset = "0x32F1024", VA = "0x32F1024")]
    public SpeciesMaster LoadSpecies(string path) => (SpeciesMaster) null;

    [Token(Token = "0x6004CF5")]
    [Address(RVA = "0x32F107C", Offset = "0x32F107C", VA = "0x32F107C")]
    private void LoadSpeciesDefault()
    {
    }

    [Token(Token = "0x6004CF6")]
    [Address(RVA = "0x32F10E4", Offset = "0x32F10E4", VA = "0x32F10E4")]
    public TipsLoadingMaster LoadTipsLoading(string path) => (TipsLoadingMaster) null;

    [Token(Token = "0x6004CF7")]
    [Address(RVA = "0x32F113C", Offset = "0x32F113C", VA = "0x32F113C")]
    private void LoadTipsLoadingDefault()
    {
    }

    [Token(Token = "0x6004CF8")]
    [Address(RVA = "0x32F11A4", Offset = "0x32F11A4", VA = "0x32F11A4")]
    public DeckTypeMaster LoadDeckType(string path) => (DeckTypeMaster) null;

    [Token(Token = "0x6004CF9")]
    [Address(RVA = "0x32F11FC", Offset = "0x32F11FC", VA = "0x32F11FC")]
    private void LoadDeckTypeDefault()
    {
    }

    [Token(Token = "0x6004CFA")]
    [Address(RVA = "0x32F1264", Offset = "0x32F1264", VA = "0x32F1264")]
    public ArmorTypeMaster LoadArmorType(string path) => (ArmorTypeMaster) null;

    [Token(Token = "0x6004CFB")]
    [Address(RVA = "0x32F12BC", Offset = "0x32F12BC", VA = "0x32F12BC")]
    private void LoadArmorTypeDefault()
    {
    }

    [Token(Token = "0x6004CFC")]
    [Address(RVA = "0x32F1324", Offset = "0x32F1324", VA = "0x32F1324")]
    public AttackTypeMaster LoadAttackType(string path) => (AttackTypeMaster) null;

    [Token(Token = "0x6004CFD")]
    [Address(RVA = "0x32F137C", Offset = "0x32F137C", VA = "0x32F137C")]
    private void LoadAttackTypeDefault()
    {
    }

    [Token(Token = "0x6004CFE")]
    [Address(RVA = "0x32F13E4", Offset = "0x32F13E4", VA = "0x32F13E4")]
    public BattleBadStatusTypeMaster LoadBattleBadStatusType(string path)
    {
      return (BattleBadStatusTypeMaster) null;
    }

    [Token(Token = "0x6004CFF")]
    [Address(RVA = "0x32F143C", Offset = "0x32F143C", VA = "0x32F143C")]
    private void LoadBattleBadStatusTypeDefault()
    {
    }

    [Token(Token = "0x6004D00")]
    [Address(RVA = "0x32F14A4", Offset = "0x32F14A4", VA = "0x32F14A4")]
    public BattleDropRewardTypeMaster LoadBattleDropRewardType(string path)
    {
      return (BattleDropRewardTypeMaster) null;
    }

    [Token(Token = "0x6004D01")]
    [Address(RVA = "0x32F14FC", Offset = "0x32F14FC", VA = "0x32F14FC")]
    private void LoadBattleDropRewardTypeDefault()
    {
    }

    [Token(Token = "0x6004D02")]
    [Address(RVA = "0x32F1564", Offset = "0x32F1564", VA = "0x32F1564")]
    public BloodTypeMaster LoadBloodType(string path) => (BloodTypeMaster) null;

    [Token(Token = "0x6004D03")]
    [Address(RVA = "0x32F15BC", Offset = "0x32F15BC", VA = "0x32F15BC")]
    private void LoadBloodTypeDefault()
    {
    }

    [Token(Token = "0x6004D04")]
    [Address(RVA = "0x32F1624", Offset = "0x32F1624", VA = "0x32F1624")]
    public ChatErrorCodeMaster LoadChatErrorCode(string path) => (ChatErrorCodeMaster) null;

    [Token(Token = "0x6004D05")]
    [Address(RVA = "0x32F167C", Offset = "0x32F167C", VA = "0x32F167C")]
    private void LoadChatErrorCodeDefault()
    {
    }

    [Token(Token = "0x6004D06")]
    [Address(RVA = "0x32F16E4", Offset = "0x32F16E4", VA = "0x32F16E4")]
    public CustomSkillTypeMaster LoadCustomSkillType(string path) => (CustomSkillTypeMaster) null;

    [Token(Token = "0x6004D07")]
    [Address(RVA = "0x32F173C", Offset = "0x32F173C", VA = "0x32F173C")]
    private void LoadCustomSkillTypeDefault()
    {
    }

    [Token(Token = "0x6004D08")]
    [Address(RVA = "0x32F17A4", Offset = "0x32F17A4", VA = "0x32F17A4")]
    public DuelMotionTypeMaster LoadDuelMotionType(string path) => (DuelMotionTypeMaster) null;

    [Token(Token = "0x6004D09")]
    [Address(RVA = "0x32F17FC", Offset = "0x32F17FC", VA = "0x32F17FC")]
    private void LoadDuelMotionTypeDefault()
    {
    }

    [Token(Token = "0x6004D0A")]
    [Address(RVA = "0x32F1864", Offset = "0x32F1864", VA = "0x32F1864")]
    public ElementTypeMaster LoadElementType(string path) => (ElementTypeMaster) null;

    [Token(Token = "0x6004D0B")]
    [Address(RVA = "0x32F18BC", Offset = "0x32F18BC", VA = "0x32F18BC")]
    private void LoadElementTypeDefault()
    {
    }

    [Token(Token = "0x6004D0C")]
    [Address(RVA = "0x32F1924", Offset = "0x32F1924", VA = "0x32F1924")]
    public LandformTypeMaster LoadLandformType(string path) => (LandformTypeMaster) null;

    [Token(Token = "0x6004D0D")]
    [Address(RVA = "0x32F197C", Offset = "0x32F197C", VA = "0x32F197C")]
    private void LoadLandformTypeDefault()
    {
    }

    [Token(Token = "0x6004D0E")]
    [Address(RVA = "0x32F19E4", Offset = "0x32F19E4", VA = "0x32F19E4")]
    public MoveTypeMaster LoadMoveType(string path) => (MoveTypeMaster) null;

    [Token(Token = "0x6004D0F")]
    [Address(RVA = "0x32F1A3C", Offset = "0x32F1A3C", VA = "0x32F1A3C")]
    private void LoadMoveTypeDefault()
    {
    }

    [Token(Token = "0x6004D10")]
    [Address(RVA = "0x32F1AA4", Offset = "0x32F1AA4", VA = "0x32F1AA4")]
    public ReincarnationBonusTypeMaster LoadReincarnationBonusType(string path)
    {
      return (ReincarnationBonusTypeMaster) null;
    }

    [Token(Token = "0x6004D11")]
    [Address(RVA = "0x32F1AFC", Offset = "0x32F1AFC", VA = "0x32F1AFC")]
    private void LoadReincarnationBonusTypeDefault()
    {
    }

    [Token(Token = "0x6004D12")]
    [Address(RVA = "0x32F1B64", Offset = "0x32F1B64", VA = "0x32F1B64")]
    public RideTypeMaster LoadRideType(string path) => (RideTypeMaster) null;

    [Token(Token = "0x6004D13")]
    [Address(RVA = "0x32F1BBC", Offset = "0x32F1BBC", VA = "0x32F1BBC")]
    private void LoadRideTypeDefault()
    {
    }

    [Token(Token = "0x6004D14")]
    [Address(RVA = "0x32F1C24", Offset = "0x32F1C24", VA = "0x32F1C24")]
    public SexTypeMaster LoadSexType(string path) => (SexTypeMaster) null;

    [Token(Token = "0x6004D15")]
    [Address(RVA = "0x32F1C7C", Offset = "0x32F1C7C", VA = "0x32F1C7C")]
    private void LoadSexTypeDefault()
    {
    }

    [Token(Token = "0x6004D16")]
    [Address(RVA = "0x32F1CE4", Offset = "0x32F1CE4", VA = "0x32F1CE4")]
    public SkillCategoryTypeMaster LoadSkillCategoryType(string path)
    {
      return (SkillCategoryTypeMaster) null;
    }

    [Token(Token = "0x6004D17")]
    [Address(RVA = "0x32F1D3C", Offset = "0x32F1D3C", VA = "0x32F1D3C")]
    private void LoadSkillCategoryTypeDefault()
    {
    }

    [Token(Token = "0x6004D18")]
    [Address(RVA = "0x32F1DA4", Offset = "0x32F1DA4", VA = "0x32F1DA4")]
    public SkillTagTypeMaster LoadSkillTagType(string path) => (SkillTagTypeMaster) null;

    [Token(Token = "0x6004D19")]
    [Address(RVA = "0x32F1DFC", Offset = "0x32F1DFC", VA = "0x32F1DFC")]
    private void LoadSkillTagTypeDefault()
    {
    }

    [Token(Token = "0x6004D1A")]
    [Address(RVA = "0x32F1E64", Offset = "0x32F1E64", VA = "0x32F1E64")]
    public SpeciesTypeMaster LoadSpeciesType(string path) => (SpeciesTypeMaster) null;

    [Token(Token = "0x6004D1B")]
    [Address(RVA = "0x32F1EBC", Offset = "0x32F1EBC", VA = "0x32F1EBC")]
    private void LoadSpeciesTypeDefault()
    {
    }

    [Token(Token = "0x6004D1C")]
    [Address(RVA = "0x32F1F24", Offset = "0x32F1F24", VA = "0x32F1F24")]
    public StyleGroupTypeMaster LoadStyleGroupType(string path) => (StyleGroupTypeMaster) null;

    [Token(Token = "0x6004D1D")]
    [Address(RVA = "0x32F1F7C", Offset = "0x32F1F7C", VA = "0x32F1F7C")]
    private void LoadStyleGroupTypeDefault()
    {
    }

    [Token(Token = "0x6004D1E")]
    [Address(RVA = "0x32F1FE4", Offset = "0x32F1FE4", VA = "0x32F1FE4")]
    public WeaponTypeEnumMaster LoadWeaponTypeEnum(string path) => (WeaponTypeEnumMaster) null;

    [Token(Token = "0x6004D1F")]
    [Address(RVA = "0x32F203C", Offset = "0x32F203C", VA = "0x32F203C")]
    private void LoadWeaponTypeEnumDefault()
    {
    }

    [Token(Token = "0x6004D20")]
    [Address(RVA = "0x32F20A4", Offset = "0x32F20A4", VA = "0x32F20A4")]
    public AccessoriesExpMaster LoadAccessoriesExp(string path) => (AccessoriesExpMaster) null;

    [Token(Token = "0x6004D21")]
    [Address(RVA = "0x32F20FC", Offset = "0x32F20FC", VA = "0x32F20FC")]
    private void LoadAccessoriesExpDefault()
    {
    }

    [Token(Token = "0x6004D22")]
    [Address(RVA = "0x32F2164", Offset = "0x32F2164", VA = "0x32F2164")]
    public AccessoriesMaster LoadAccessories(string path) => (AccessoriesMaster) null;

    [Token(Token = "0x6004D23")]
    [Address(RVA = "0x32F21BC", Offset = "0x32F21BC", VA = "0x32F21BC")]
    private void LoadAccessoriesDefault()
    {
    }

    [Token(Token = "0x6004D24")]
    [Address(RVA = "0x32F2224", Offset = "0x32F2224", VA = "0x32F2224")]
    public AccessoryOptionEffectSpriteMaster LoadAccessoryOptionEffectSprite(string path)
    {
      return (AccessoryOptionEffectSpriteMaster) null;
    }

    [Token(Token = "0x6004D25")]
    [Address(RVA = "0x32F227C", Offset = "0x32F227C", VA = "0x32F227C")]
    private void LoadAccessoryOptionEffectSpriteDefault()
    {
    }

    [Token(Token = "0x6004D26")]
    [Address(RVA = "0x32F22E4", Offset = "0x32F22E4", VA = "0x32F22E4")]
    public AccessoryOptionSlotMaster LoadAccessoryOptionSlot(string path)
    {
      return (AccessoryOptionSlotMaster) null;
    }

    [Token(Token = "0x6004D27")]
    [Address(RVA = "0x32F233C", Offset = "0x32F233C", VA = "0x32F233C")]
    private void LoadAccessoryOptionSlotDefault()
    {
    }

    [Token(Token = "0x6004D28")]
    [Address(RVA = "0x32F23A4", Offset = "0x32F23A4", VA = "0x32F23A4")]
    public AccessoryOptionMaster LoadAccessoryOption(string path) => (AccessoryOptionMaster) null;

    [Token(Token = "0x6004D29")]
    [Address(RVA = "0x32F23FC", Offset = "0x32F23FC", VA = "0x32F23FC")]
    private void LoadAccessoryOptionDefault()
    {
    }

    [Token(Token = "0x6004D2A")]
    [Address(RVA = "0x32F2464", Offset = "0x32F2464", VA = "0x32F2464")]
    public AccessoryOptionChangeItemRecipeMaster LoadAccessoryOptionChangeItemRecipe(string path)
    {
      return (AccessoryOptionChangeItemRecipeMaster) null;
    }

    [Token(Token = "0x6004D2B")]
    [Address(RVA = "0x32F24BC", Offset = "0x32F24BC", VA = "0x32F24BC")]
    private void LoadAccessoryOptionChangeItemRecipeDefault()
    {
    }

    [Token(Token = "0x6004D2C")]
    [Address(RVA = "0x32F2524", Offset = "0x32F2524", VA = "0x32F2524")]
    public AccessoryOptionGradeGroupMaster LoadAccessoryOptionGradeGroup(string path)
    {
      return (AccessoryOptionGradeGroupMaster) null;
    }

    [Token(Token = "0x6004D2D")]
    [Address(RVA = "0x32F257C", Offset = "0x32F257C", VA = "0x32F257C")]
    private void LoadAccessoryOptionGradeGroupDefault()
    {
    }

    [Token(Token = "0x6004D2E")]
    [Address(RVA = "0x32F25E4", Offset = "0x32F25E4", VA = "0x32F25E4")]
    public AccessoryOptionLotteryMaster LoadAccessoryOptionLottery(string path)
    {
      return (AccessoryOptionLotteryMaster) null;
    }

    [Token(Token = "0x6004D2F")]
    [Address(RVA = "0x32F263C", Offset = "0x32F263C", VA = "0x32F263C")]
    private void LoadAccessoryOptionLotteryDefault()
    {
    }

    [Token(Token = "0x6004D30")]
    [Address(RVA = "0x32F26A4", Offset = "0x32F26A4", VA = "0x32F26A4")]
    public AccessoriesLimitBreakDescriptionMaster LoadAccessoriesLimitBreakDescription(string path)
    {
      return (AccessoriesLimitBreakDescriptionMaster) null;
    }

    [Token(Token = "0x6004D31")]
    [Address(RVA = "0x32F26FC", Offset = "0x32F26FC", VA = "0x32F26FC")]
    private void LoadAccessoriesLimitBreakDescriptionDefault()
    {
    }

    [Token(Token = "0x6004D32")]
    [Address(RVA = "0x32F2764", Offset = "0x32F2764", VA = "0x32F2764")]
    public AccessoriesLimitBreakMaster LoadAccessoriesLimitBreak(string path)
    {
      return (AccessoriesLimitBreakMaster) null;
    }

    [Token(Token = "0x6004D33")]
    [Address(RVA = "0x32F27BC", Offset = "0x32F27BC", VA = "0x32F27BC")]
    private void LoadAccessoriesLimitBreakDefault()
    {
    }

    [Token(Token = "0x6004D34")]
    [Address(RVA = "0x32F2824", Offset = "0x32F2824", VA = "0x32F2824")]
    public InscriptionAcquiredMaster LoadInscriptionAcquired(string path)
    {
      return (InscriptionAcquiredMaster) null;
    }

    [Token(Token = "0x6004D35")]
    [Address(RVA = "0x32F287C", Offset = "0x32F287C", VA = "0x32F287C")]
    private void LoadInscriptionAcquiredDefault()
    {
    }

    [Token(Token = "0x6004D36")]
    [Address(RVA = "0x32F28E4", Offset = "0x32F28E4", VA = "0x32F28E4")]
    public InscriptionCategoryMaster LoadInscriptionCategory(string path)
    {
      return (InscriptionCategoryMaster) null;
    }

    [Token(Token = "0x6004D37")]
    [Address(RVA = "0x32F293C", Offset = "0x32F293C", VA = "0x32F293C")]
    private void LoadInscriptionCategoryDefault()
    {
    }

    [Token(Token = "0x6004D38")]
    [Address(RVA = "0x32F29A4", Offset = "0x32F29A4", VA = "0x32F29A4")]
    public InscriptionDescriptionMaster LoadInscriptionDescription(string path)
    {
      return (InscriptionDescriptionMaster) null;
    }

    [Token(Token = "0x6004D39")]
    [Address(RVA = "0x32F29FC", Offset = "0x32F29FC", VA = "0x32F29FC")]
    private void LoadInscriptionDescriptionDefault()
    {
    }

    [Token(Token = "0x6004D3A")]
    [Address(RVA = "0x32F2A64", Offset = "0x32F2A64", VA = "0x32F2A64")]
    public InscriptionMaster LoadInscription(string path) => (InscriptionMaster) null;

    [Token(Token = "0x6004D3B")]
    [Address(RVA = "0x32F2ABC", Offset = "0x32F2ABC", VA = "0x32F2ABC")]
    private void LoadInscriptionDefault()
    {
    }

    [Token(Token = "0x6004D3C")]
    [Address(RVA = "0x32F2B24", Offset = "0x32F2B24", VA = "0x32F2B24")]
    public LimitBreakLevelCapMaster LoadLimitBreakLevelCap(string path)
    {
      return (LimitBreakLevelCapMaster) null;
    }

    [Token(Token = "0x6004D3D")]
    [Address(RVA = "0x32F2B7C", Offset = "0x32F2B7C", VA = "0x32F2B7C")]
    private void LoadLimitBreakLevelCapDefault()
    {
    }

    [Token(Token = "0x6004D3E")]
    [Address(RVA = "0x32F2BE4", Offset = "0x32F2BE4", VA = "0x32F2BE4")]
    public MindEquipmentExpMaster LoadMindEquipmentExp(string path)
    {
      return (MindEquipmentExpMaster) null;
    }

    [Token(Token = "0x6004D3F")]
    [Address(RVA = "0x32F2C3C", Offset = "0x32F2C3C", VA = "0x32F2C3C")]
    private void LoadMindEquipmentExpDefault()
    {
    }

    [Token(Token = "0x6004D40")]
    [Address(RVA = "0x32F2CA4", Offset = "0x32F2CA4", VA = "0x32F2CA4")]
    public MindEquipmentLimitBreakDescriptionMaster LoadMindEquipmentLimitBreakDescription(
      string path)
    {
      return (MindEquipmentLimitBreakDescriptionMaster) null;
    }

    [Token(Token = "0x6004D41")]
    [Address(RVA = "0x32F2CFC", Offset = "0x32F2CFC", VA = "0x32F2CFC")]
    private void LoadMindEquipmentLimitBreakDescriptionDefault()
    {
    }

    [Token(Token = "0x6004D42")]
    [Address(RVA = "0x32F2D64", Offset = "0x32F2D64", VA = "0x32F2D64")]
    public MindEquipmentMedalExchangeMaster LoadMindEquipmentMedalExchange(string path)
    {
      return (MindEquipmentMedalExchangeMaster) null;
    }

    [Token(Token = "0x6004D43")]
    [Address(RVA = "0x32F2DBC", Offset = "0x32F2DBC", VA = "0x32F2DBC")]
    private void LoadMindEquipmentMedalExchangeDefault()
    {
    }

    [Token(Token = "0x6004D44")]
    [Address(RVA = "0x32F2E24", Offset = "0x32F2E24", VA = "0x32F2E24")]
    public MindEquipmentMaster LoadMindEquipment(string path) => (MindEquipmentMaster) null;

    [Token(Token = "0x6004D45")]
    [Address(RVA = "0x32F2E7C", Offset = "0x32F2E7C", VA = "0x32F2E7C")]
    private void LoadMindEquipmentDefault()
    {
    }

    [Token(Token = "0x6004D46")]
    [Address(RVA = "0x32F2EE4", Offset = "0x32F2EE4", VA = "0x32F2EE4")]
    public SkillEnhanceConstMaster LoadSkillEnhanceConst(string path)
    {
      return (SkillEnhanceConstMaster) null;
    }

    [Token(Token = "0x6004D47")]
    [Address(RVA = "0x32F2F3C", Offset = "0x32F2F3C", VA = "0x32F2F3C")]
    private void LoadSkillEnhanceConstDefault()
    {
    }

    [Token(Token = "0x6004D48")]
    [Address(RVA = "0x32F2FA4", Offset = "0x32F2FA4", VA = "0x32F2FA4")]
    public SkillEnhanceLevelMaster LoadSkillEnhanceLevel(string path)
    {
      return (SkillEnhanceLevelMaster) null;
    }

    [Token(Token = "0x6004D49")]
    [Address(RVA = "0x32F2FFC", Offset = "0x32F2FFC", VA = "0x32F2FFC")]
    private void LoadSkillEnhanceLevelDefault()
    {
    }

    [Token(Token = "0x6004D4A")]
    [Address(RVA = "0x32F3064", Offset = "0x32F3064", VA = "0x32F3064")]
    public SkillEnhanceRarityMaster LoadSkillEnhanceRarity(string path)
    {
      return (SkillEnhanceRarityMaster) null;
    }

    [Token(Token = "0x6004D4B")]
    [Address(RVA = "0x32F30BC", Offset = "0x32F30BC", VA = "0x32F30BC")]
    private void LoadSkillEnhanceRarityDefault()
    {
    }

    [Token(Token = "0x6004D4C")]
    [Address(RVA = "0x32F3124", Offset = "0x32F3124", VA = "0x32F3124")]
    public TrustMaster LoadTrust(string path) => (TrustMaster) null;

    [Token(Token = "0x6004D4D")]
    [Address(RVA = "0x32F317C", Offset = "0x32F317C", VA = "0x32F317C")]
    private void LoadTrustDefault()
    {
    }

    [Token(Token = "0x6004D4E")]
    [Address(RVA = "0x32F31E4", Offset = "0x32F31E4", VA = "0x32F31E4")]
    public MaxLimitBreakMaster LoadMaxLimitBreak(string path) => (MaxLimitBreakMaster) null;

    [Token(Token = "0x6004D4F")]
    [Address(RVA = "0x32F323C", Offset = "0x32F323C", VA = "0x32F323C")]
    private void LoadMaxLimitBreakDefault()
    {
    }

    [Token(Token = "0x6004D50")]
    [Address(RVA = "0x32F32A4", Offset = "0x32F32A4", VA = "0x32F32A4")]
    public WeaponExpMaster LoadWeaponExp(string path) => (WeaponExpMaster) null;

    [Token(Token = "0x6004D51")]
    [Address(RVA = "0x32F32FC", Offset = "0x32F32FC", VA = "0x32F32FC")]
    private void LoadWeaponExpDefault()
    {
    }

    [Token(Token = "0x6004D52")]
    [Address(RVA = "0x32F3364", Offset = "0x32F3364", VA = "0x32F3364")]
    public WeaponLimitBreakDescriptionMaster LoadWeaponLimitBreakDescription(string path)
    {
      return (WeaponLimitBreakDescriptionMaster) null;
    }

    [Token(Token = "0x6004D53")]
    [Address(RVA = "0x32F33BC", Offset = "0x32F33BC", VA = "0x32F33BC")]
    private void LoadWeaponLimitBreakDescriptionDefault()
    {
    }

    [Token(Token = "0x6004D54")]
    [Address(RVA = "0x32F3424", Offset = "0x32F3424", VA = "0x32F3424")]
    public WeaponLimitBreakMaster LoadWeaponLimitBreak(string path)
    {
      return (WeaponLimitBreakMaster) null;
    }

    [Token(Token = "0x6004D55")]
    [Address(RVA = "0x32F347C", Offset = "0x32F347C", VA = "0x32F347C")]
    private void LoadWeaponLimitBreakDefault()
    {
    }

    [Token(Token = "0x6004D56")]
    [Address(RVA = "0x32F34E4", Offset = "0x32F34E4", VA = "0x32F34E4")]
    public WeaponProficiencyPlusMaster LoadWeaponProficiencyPlus(string path)
    {
      return (WeaponProficiencyPlusMaster) null;
    }

    [Token(Token = "0x6004D57")]
    [Address(RVA = "0x32F353C", Offset = "0x32F353C", VA = "0x32F353C")]
    private void LoadWeaponProficiencyPlusDefault()
    {
    }

    [Token(Token = "0x6004D58")]
    [Address(RVA = "0x32F35A4", Offset = "0x32F35A4", VA = "0x32F35A4")]
    public WeaponRarityAptitudeDescriptionMaster LoadWeaponRarityAptitudeDescription(string path)
    {
      return (WeaponRarityAptitudeDescriptionMaster) null;
    }

    [Token(Token = "0x6004D59")]
    [Address(RVA = "0x32F35FC", Offset = "0x32F35FC", VA = "0x32F35FC")]
    private void LoadWeaponRarityAptitudeDescriptionDefault()
    {
    }

    [Token(Token = "0x6004D5A")]
    [Address(RVA = "0x32F3664", Offset = "0x32F3664", VA = "0x32F3664")]
    public WeaponRarityAptitudeMaster LoadWeaponRarityAptitude(string path)
    {
      return (WeaponRarityAptitudeMaster) null;
    }

    [Token(Token = "0x6004D5B")]
    [Address(RVA = "0x32F36BC", Offset = "0x32F36BC", VA = "0x32F36BC")]
    private void LoadWeaponRarityAptitudeDefault()
    {
    }

    [Token(Token = "0x6004D5C")]
    [Address(RVA = "0x32F3724", Offset = "0x32F3724", VA = "0x32F3724")]
    public WeaponMaster LoadWeapon(string path) => (WeaponMaster) null;

    [Token(Token = "0x6004D5D")]
    [Address(RVA = "0x32F377C", Offset = "0x32F377C", VA = "0x32F377C")]
    private void LoadWeaponDefault()
    {
    }

    [Token(Token = "0x6004D5E")]
    [Address(RVA = "0x32F37E4", Offset = "0x32F37E4", VA = "0x32F37E4")]
    public WeaponOptionEffectSpriteMaster LoadWeaponOptionEffectSprite(string path)
    {
      return (WeaponOptionEffectSpriteMaster) null;
    }

    [Token(Token = "0x6004D5F")]
    [Address(RVA = "0x32F383C", Offset = "0x32F383C", VA = "0x32F383C")]
    private void LoadWeaponOptionEffectSpriteDefault()
    {
    }

    [Token(Token = "0x6004D60")]
    [Address(RVA = "0x32F38A4", Offset = "0x32F38A4", VA = "0x32F38A4")]
    public WeaponOptionSlotMaster LoadWeaponOptionSlot(string path)
    {
      return (WeaponOptionSlotMaster) null;
    }

    [Token(Token = "0x6004D61")]
    [Address(RVA = "0x32F38FC", Offset = "0x32F38FC", VA = "0x32F38FC")]
    private void LoadWeaponOptionSlotDefault()
    {
    }

    [Token(Token = "0x6004D62")]
    [Address(RVA = "0x32F3964", Offset = "0x32F3964", VA = "0x32F3964")]
    public WeaponOptionMaster LoadWeaponOption(string path) => (WeaponOptionMaster) null;

    [Token(Token = "0x6004D63")]
    [Address(RVA = "0x32F39BC", Offset = "0x32F39BC", VA = "0x32F39BC")]
    private void LoadWeaponOptionDefault()
    {
    }

    [Token(Token = "0x6004D64")]
    [Address(RVA = "0x32F3A24", Offset = "0x32F3A24", VA = "0x32F3A24")]
    public WeaponOptionChangeItemRecipeMaster LoadWeaponOptionChangeItemRecipe(string path)
    {
      return (WeaponOptionChangeItemRecipeMaster) null;
    }

    [Token(Token = "0x6004D65")]
    [Address(RVA = "0x32F3A7C", Offset = "0x32F3A7C", VA = "0x32F3A7C")]
    private void LoadWeaponOptionChangeItemRecipeDefault()
    {
    }

    [Token(Token = "0x6004D66")]
    [Address(RVA = "0x32F3AE4", Offset = "0x32F3AE4", VA = "0x32F3AE4")]
    public WeaponOptionGradeGroupMaster LoadWeaponOptionGradeGroup(string path)
    {
      return (WeaponOptionGradeGroupMaster) null;
    }

    [Token(Token = "0x6004D67")]
    [Address(RVA = "0x32F3B3C", Offset = "0x32F3B3C", VA = "0x32F3B3C")]
    private void LoadWeaponOptionGradeGroupDefault()
    {
    }

    [Token(Token = "0x6004D68")]
    [Address(RVA = "0x32F3BA4", Offset = "0x32F3BA4", VA = "0x32F3BA4")]
    public WeaponOptionLotteryMaster LoadWeaponOptionLottery(string path)
    {
      return (WeaponOptionLotteryMaster) null;
    }

    [Token(Token = "0x6004D69")]
    [Address(RVA = "0x32F3BFC", Offset = "0x32F3BFC", VA = "0x32F3BFC")]
    private void LoadWeaponOptionLotteryDefault()
    {
    }

    [Token(Token = "0x6004D6A")]
    [Address(RVA = "0x32F3C64", Offset = "0x32F3C64", VA = "0x32F3C64")]
    public ExpeditionBossDescriptionMaster LoadExpeditionBossDescription(string path)
    {
      return (ExpeditionBossDescriptionMaster) null;
    }

    [Token(Token = "0x6004D6B")]
    [Address(RVA = "0x32F3CBC", Offset = "0x32F3CBC", VA = "0x32F3CBC")]
    private void LoadExpeditionBossDescriptionDefault()
    {
    }

    [Token(Token = "0x6004D6C")]
    [Address(RVA = "0x32F3D24", Offset = "0x32F3D24", VA = "0x32F3D24")]
    public ExpeditionBossEnemyDescriptionMaster LoadExpeditionBossEnemyDescription(string path)
    {
      return (ExpeditionBossEnemyDescriptionMaster) null;
    }

    [Token(Token = "0x6004D6D")]
    [Address(RVA = "0x32F3D7C", Offset = "0x32F3D7C", VA = "0x32F3D7C")]
    private void LoadExpeditionBossEnemyDescriptionDefault()
    {
    }

    [Token(Token = "0x6004D6E")]
    [Address(RVA = "0x32F3DE4", Offset = "0x32F3DE4", VA = "0x32F3DE4")]
    public ExpeditionBossOwnPlacementDescriptionMaster LoadExpeditionBossOwnPlacementDescription(
      string path)
    {
      return (ExpeditionBossOwnPlacementDescriptionMaster) null;
    }

    [Token(Token = "0x6004D6F")]
    [Address(RVA = "0x32F3E3C", Offset = "0x32F3E3C", VA = "0x32F3E3C")]
    private void LoadExpeditionBossOwnPlacementDescriptionDefault()
    {
    }

    [Token(Token = "0x6004D70")]
    [Address(RVA = "0x32F3EA4", Offset = "0x32F3EA4", VA = "0x32F3EA4")]
    public ExpeditionBossRareRewardSetMaster LoadExpeditionBossRareRewardSet(string path)
    {
      return (ExpeditionBossRareRewardSetMaster) null;
    }

    [Token(Token = "0x6004D71")]
    [Address(RVA = "0x32F3EFC", Offset = "0x32F3EFC", VA = "0x32F3EFC")]
    private void LoadExpeditionBossRareRewardSetDefault()
    {
    }

    [Token(Token = "0x6004D72")]
    [Address(RVA = "0x32F3F64", Offset = "0x32F3F64", VA = "0x32F3F64")]
    public ExpeditionBossRareRewardMaster LoadExpeditionBossRareReward(string path)
    {
      return (ExpeditionBossRareRewardMaster) null;
    }

    [Token(Token = "0x6004D73")]
    [Address(RVA = "0x32F3FBC", Offset = "0x32F3FBC", VA = "0x32F3FBC")]
    private void LoadExpeditionBossRareRewardDefault()
    {
    }

    [Token(Token = "0x6004D74")]
    [Address(RVA = "0x32F4024", Offset = "0x32F4024", VA = "0x32F4024")]
    public ExpeditionBossRewardGroupMaster LoadExpeditionBossRewardGroup(string path)
    {
      return (ExpeditionBossRewardGroupMaster) null;
    }

    [Token(Token = "0x6004D75")]
    [Address(RVA = "0x32F407C", Offset = "0x32F407C", VA = "0x32F407C")]
    private void LoadExpeditionBossRewardGroupDefault()
    {
    }

    [Token(Token = "0x6004D76")]
    [Address(RVA = "0x32F40E4", Offset = "0x32F40E4", VA = "0x32F40E4")]
    public ExpeditionBoxMaster LoadExpeditionBox(string path) => (ExpeditionBoxMaster) null;

    [Token(Token = "0x6004D77")]
    [Address(RVA = "0x32F413C", Offset = "0x32F413C", VA = "0x32F413C")]
    private void LoadExpeditionBoxDefault()
    {
    }

    [Token(Token = "0x6004D78")]
    [Address(RVA = "0x32F41A4", Offset = "0x32F41A4", VA = "0x32F41A4")]
    public ExpeditionWeaponBaseMaster LoadExpeditionWeaponBase(string path)
    {
      return (ExpeditionWeaponBaseMaster) null;
    }

    [Token(Token = "0x6004D79")]
    [Address(RVA = "0x32F41FC", Offset = "0x32F41FC", VA = "0x32F41FC")]
    private void LoadExpeditionWeaponBaseDefault()
    {
    }

    [Token(Token = "0x6004D7A")]
    [Address(RVA = "0x32F4264", Offset = "0x32F4264", VA = "0x32F4264")]
    public ExpeditionWeaponCoeffcicentMaster LoadExpeditionWeaponCoeffcicent(string path)
    {
      return (ExpeditionWeaponCoeffcicentMaster) null;
    }

    [Token(Token = "0x6004D7B")]
    [Address(RVA = "0x32F42BC", Offset = "0x32F42BC", VA = "0x32F42BC")]
    private void LoadExpeditionWeaponCoeffcicentDefault()
    {
    }

    [Token(Token = "0x6004D7C")]
    [Address(RVA = "0x32F4324", Offset = "0x32F4324", VA = "0x32F4324")]
    public ExpeditionPartyReleaseMaster LoadExpeditionPartyRelease(string path)
    {
      return (ExpeditionPartyReleaseMaster) null;
    }

    [Token(Token = "0x6004D7D")]
    [Address(RVA = "0x32F437C", Offset = "0x32F437C", VA = "0x32F437C")]
    private void LoadExpeditionPartyReleaseDefault()
    {
    }

    [Token(Token = "0x6004D7E")]
    [Address(RVA = "0x32F43E4", Offset = "0x32F43E4", VA = "0x32F43E4")]
    public ExpeditionPartySlotReleaseMaster LoadExpeditionPartySlotRelease(string path)
    {
      return (ExpeditionPartySlotReleaseMaster) null;
    }

    [Token(Token = "0x6004D7F")]
    [Address(RVA = "0x32F443C", Offset = "0x32F443C", VA = "0x32F443C")]
    private void LoadExpeditionPartySlotReleaseDefault()
    {
    }

    [Token(Token = "0x6004D80")]
    [Address(RVA = "0x32F44A4", Offset = "0x32F44A4", VA = "0x32F44A4")]
    public ExpeditionRapidCoinRequiredAmountMaster LoadExpeditionRapidCoinRequiredAmount(string path)
    {
      return (ExpeditionRapidCoinRequiredAmountMaster) null;
    }

    [Token(Token = "0x6004D81")]
    [Address(RVA = "0x32F44FC", Offset = "0x32F44FC", VA = "0x32F44FC")]
    private void LoadExpeditionRapidCoinRequiredAmountDefault()
    {
    }

    [Token(Token = "0x6004D82")]
    [Address(RVA = "0x32F4564", Offset = "0x32F4564", VA = "0x32F4564")]
    public ExpeditionSoulSpotExpMaster LoadExpeditionSoulSpotExp(string path)
    {
      return (ExpeditionSoulSpotExpMaster) null;
    }

    [Token(Token = "0x6004D83")]
    [Address(RVA = "0x32F45BC", Offset = "0x32F45BC", VA = "0x32F45BC")]
    private void LoadExpeditionSoulSpotExpDefault()
    {
    }

    [Token(Token = "0x6004D84")]
    [Address(RVA = "0x32F4624", Offset = "0x32F4624", VA = "0x32F4624")]
    public ExpeditionSoulSpotMaster LoadExpeditionSoulSpot(string path)
    {
      return (ExpeditionSoulSpotMaster) null;
    }

    [Token(Token = "0x6004D85")]
    [Address(RVA = "0x32F467C", Offset = "0x32F467C", VA = "0x32F467C")]
    private void LoadExpeditionSoulSpotDefault()
    {
    }

    [Token(Token = "0x6004D86")]
    [Address(RVA = "0x32F46E4", Offset = "0x32F46E4", VA = "0x32F46E4")]
    public ExpeditionSoulTankMaster LoadExpeditionSoulTank(string path)
    {
      return (ExpeditionSoulTankMaster) null;
    }

    [Token(Token = "0x6004D87")]
    [Address(RVA = "0x32F473C", Offset = "0x32F473C", VA = "0x32F473C")]
    private void LoadExpeditionSoulTankDefault()
    {
    }

    [Token(Token = "0x6004D88")]
    [Address(RVA = "0x32F47A4", Offset = "0x32F47A4", VA = "0x32F47A4")]
    public ExpeditionStageDescriptionMaster LoadExpeditionStageDescription(string path)
    {
      return (ExpeditionStageDescriptionMaster) null;
    }

    [Token(Token = "0x6004D89")]
    [Address(RVA = "0x32F47FC", Offset = "0x32F47FC", VA = "0x32F47FC")]
    private void LoadExpeditionStageDescriptionDefault()
    {
    }

    [Token(Token = "0x6004D8A")]
    [Address(RVA = "0x32F4864", Offset = "0x32F4864", VA = "0x32F4864")]
    public ExpeditionStageEnemyDescriptionMaster LoadExpeditionStageEnemyDescription(string path)
    {
      return (ExpeditionStageEnemyDescriptionMaster) null;
    }

    [Token(Token = "0x6004D8B")]
    [Address(RVA = "0x32F48BC", Offset = "0x32F48BC", VA = "0x32F48BC")]
    private void LoadExpeditionStageEnemyDescriptionDefault()
    {
    }

    [Token(Token = "0x6004D8C")]
    [Address(RVA = "0x32F4924", Offset = "0x32F4924", VA = "0x32F4924")]
    public ExpeditionStageItemDropDescriptionMaster LoadExpeditionStageItemDropDescription(
      string path)
    {
      return (ExpeditionStageItemDropDescriptionMaster) null;
    }

    [Token(Token = "0x6004D8D")]
    [Address(RVA = "0x32F497C", Offset = "0x32F497C", VA = "0x32F497C")]
    private void LoadExpeditionStageItemDropDescriptionDefault()
    {
    }

    [Token(Token = "0x6004D8E")]
    [Address(RVA = "0x32F49E4", Offset = "0x32F49E4", VA = "0x32F49E4")]
    public ExpeditionStageOwnPlacementDescriptionMaster LoadExpeditionStageOwnPlacementDescription(
      string path)
    {
      return (ExpeditionStageOwnPlacementDescriptionMaster) null;
    }

    [Token(Token = "0x6004D8F")]
    [Address(RVA = "0x32F4A3C", Offset = "0x32F4A3C", VA = "0x32F4A3C")]
    private void LoadExpeditionStageOwnPlacementDescriptionDefault()
    {
    }

    [Token(Token = "0x6004D90")]
    [Address(RVA = "0x32F4AA4", Offset = "0x32F4AA4", VA = "0x32F4AA4")]
    public ExpeditionStageMaster LoadExpeditionStage(string path) => (ExpeditionStageMaster) null;

    [Token(Token = "0x6004D91")]
    [Address(RVA = "0x32F4AFC", Offset = "0x32F4AFC", VA = "0x32F4AFC")]
    private void LoadExpeditionStageDefault()
    {
    }

    [Token(Token = "0x6004D92")]
    [Address(RVA = "0x32F4B64", Offset = "0x32F4B64", VA = "0x32F4B64")]
    public FriendConstMaster LoadFriendConst(string path) => (FriendConstMaster) null;

    [Token(Token = "0x6004D93")]
    [Address(RVA = "0x32F4BBC", Offset = "0x32F4BBC", VA = "0x32F4BBC")]
    private void LoadFriendConstDefault()
    {
    }

    [Token(Token = "0x6004D94")]
    [Address(RVA = "0x32F4C24", Offset = "0x32F4C24", VA = "0x32F4C24")]
    public GuildArmourySettingsMaster LoadGuildArmourySettings(string path)
    {
      return (GuildArmourySettingsMaster) null;
    }

    [Token(Token = "0x6004D95")]
    [Address(RVA = "0x32F4C7C", Offset = "0x32F4C7C", VA = "0x32F4C7C")]
    private void LoadGuildArmourySettingsDefault()
    {
    }

    [Token(Token = "0x6004D96")]
    [Address(RVA = "0x32F4CE4", Offset = "0x32F4CE4", VA = "0x32F4CE4")]
    public GuildConstMaster LoadGuildConst(string path) => (GuildConstMaster) null;

    [Token(Token = "0x6004D97")]
    [Address(RVA = "0x32F4D3C", Offset = "0x32F4D3C", VA = "0x32F4D3C")]
    private void LoadGuildConstDefault()
    {
    }

    [Token(Token = "0x6004D98")]
    [Address(RVA = "0x32F4DA4", Offset = "0x32F4DA4", VA = "0x32F4DA4")]
    public GuildRoleTypeMaster LoadGuildRoleType(string path) => (GuildRoleTypeMaster) null;

    [Token(Token = "0x6004D99")]
    [Address(RVA = "0x32F4DFC", Offset = "0x32F4DFC", VA = "0x32F4DFC")]
    private void LoadGuildRoleTypeDefault()
    {
    }

    [Token(Token = "0x6004D9A")]
    [Address(RVA = "0x32F4E64", Offset = "0x32F4E64", VA = "0x32F4E64")]
    public GuildSettingsAutoApproveTypeMaster LoadGuildSettingsAutoApproveType(string path)
    {
      return (GuildSettingsAutoApproveTypeMaster) null;
    }

    [Token(Token = "0x6004D9B")]
    [Address(RVA = "0x32F4EBC", Offset = "0x32F4EBC", VA = "0x32F4EBC")]
    private void LoadGuildSettingsAutoApproveTypeDefault()
    {
    }

    [Token(Token = "0x6004D9C")]
    [Address(RVA = "0x32F4F24", Offset = "0x32F4F24", VA = "0x32F4F24")]
    public GuildSettingsAutoKickTypeMaster LoadGuildSettingsAutoKickType(string path)
    {
      return (GuildSettingsAutoKickTypeMaster) null;
    }

    [Token(Token = "0x6004D9D")]
    [Address(RVA = "0x32F4F7C", Offset = "0x32F4F7C", VA = "0x32F4F7C")]
    private void LoadGuildSettingsAutoKickTypeDefault()
    {
    }

    [Token(Token = "0x6004D9E")]
    [Address(RVA = "0x32F4FE4", Offset = "0x32F4FE4", VA = "0x32F4FE4")]
    public GuildSettingsConditionsTypeMaster LoadGuildSettingsConditionsType(string path)
    {
      return (GuildSettingsConditionsTypeMaster) null;
    }

    [Token(Token = "0x6004D9F")]
    [Address(RVA = "0x32F503C", Offset = "0x32F503C", VA = "0x32F503C")]
    private void LoadGuildSettingsConditionsTypeDefault()
    {
    }

    [Token(Token = "0x6004DA0")]
    [Address(RVA = "0x32F50A4", Offset = "0x32F50A4", VA = "0x32F50A4")]
    public GuildSettingsPolicyTypeMaster LoadGuildSettingsPolicyType(string path)
    {
      return (GuildSettingsPolicyTypeMaster) null;
    }

    [Token(Token = "0x6004DA1")]
    [Address(RVA = "0x32F50FC", Offset = "0x32F50FC", VA = "0x32F50FC")]
    private void LoadGuildSettingsPolicyTypeDefault()
    {
    }

    [Token(Token = "0x6004DA2")]
    [Address(RVA = "0x32F5164", Offset = "0x32F5164", VA = "0x32F5164")]
    public GuildSettingsRecruitStatusTypeMaster LoadGuildSettingsRecruitStatusType(string path)
    {
      return (GuildSettingsRecruitStatusTypeMaster) null;
    }

    [Token(Token = "0x6004DA3")]
    [Address(RVA = "0x32F51BC", Offset = "0x32F51BC", VA = "0x32F51BC")]
    private void LoadGuildSettingsRecruitStatusTypeDefault()
    {
    }

    [Token(Token = "0x6004DA4")]
    [Address(RVA = "0x32F5224", Offset = "0x32F5224", VA = "0x32F5224")]
    public GuildUnlockElementTypeMaster LoadGuildUnlockElementType(string path)
    {
      return (GuildUnlockElementTypeMaster) null;
    }

    [Token(Token = "0x6004DA5")]
    [Address(RVA = "0x32F527C", Offset = "0x32F527C", VA = "0x32F527C")]
    private void LoadGuildUnlockElementTypeDefault()
    {
    }

    [Token(Token = "0x6004DA6")]
    [Address(RVA = "0x32F52E4", Offset = "0x32F52E4", VA = "0x32F52E4")]
    public GuildFacilityEffectMaster LoadGuildFacilityEffect(string path)
    {
      return (GuildFacilityEffectMaster) null;
    }

    [Token(Token = "0x6004DA7")]
    [Address(RVA = "0x32F533C", Offset = "0x32F533C", VA = "0x32F533C")]
    private void LoadGuildFacilityEffectDefault()
    {
    }

    [Token(Token = "0x6004DA8")]
    [Address(RVA = "0x32F53A4", Offset = "0x32F53A4", VA = "0x32F53A4")]
    public GuildFacilityExpMaster LoadGuildFacilityExp(string path)
    {
      return (GuildFacilityExpMaster) null;
    }

    [Token(Token = "0x6004DA9")]
    [Address(RVA = "0x32F53FC", Offset = "0x32F53FC", VA = "0x32F53FC")]
    private void LoadGuildFacilityExpDefault()
    {
    }

    [Token(Token = "0x6004DAA")]
    [Address(RVA = "0x32F5464", Offset = "0x32F5464", VA = "0x32F5464")]
    public GuildFacilityInvestRewardDescriptionMaster LoadGuildFacilityInvestRewardDescription(
      string path)
    {
      return (GuildFacilityInvestRewardDescriptionMaster) null;
    }

    [Token(Token = "0x6004DAB")]
    [Address(RVA = "0x32F54BC", Offset = "0x32F54BC", VA = "0x32F54BC")]
    private void LoadGuildFacilityInvestRewardDescriptionDefault()
    {
    }

    [Token(Token = "0x6004DAC")]
    [Address(RVA = "0x32F5524", Offset = "0x32F5524", VA = "0x32F5524")]
    public GuildFacilityLevelRewardMaster LoadGuildFacilityLevelReward(string path)
    {
      return (GuildFacilityLevelRewardMaster) null;
    }

    [Token(Token = "0x6004DAD")]
    [Address(RVA = "0x32F557C", Offset = "0x32F557C", VA = "0x32F557C")]
    private void LoadGuildFacilityLevelRewardDefault()
    {
    }

    [Token(Token = "0x6004DAE")]
    [Address(RVA = "0x32F55E4", Offset = "0x32F55E4", VA = "0x32F55E4")]
    public GuildFacilityResourceDescriptionMaster LoadGuildFacilityResourceDescription(string path)
    {
      return (GuildFacilityResourceDescriptionMaster) null;
    }

    [Token(Token = "0x6004DAF")]
    [Address(RVA = "0x32F563C", Offset = "0x32F563C", VA = "0x32F563C")]
    private void LoadGuildFacilityResourceDescriptionDefault()
    {
    }

    [Token(Token = "0x6004DB0")]
    [Address(RVA = "0x32F56A4", Offset = "0x32F56A4", VA = "0x32F56A4")]
    public GuildFacilityResourceTableDescriptionMaster LoadGuildFacilityResourceTableDescription(
      string path)
    {
      return (GuildFacilityResourceTableDescriptionMaster) null;
    }

    [Token(Token = "0x6004DB1")]
    [Address(RVA = "0x32F56FC", Offset = "0x32F56FC", VA = "0x32F56FC")]
    private void LoadGuildFacilityResourceTableDescriptionDefault()
    {
    }

    [Token(Token = "0x6004DB2")]
    [Address(RVA = "0x32F5764", Offset = "0x32F5764", VA = "0x32F5764")]
    public GuildFacilityRewardDescriptionMaster LoadGuildFacilityRewardDescription(string path)
    {
      return (GuildFacilityRewardDescriptionMaster) null;
    }

    [Token(Token = "0x6004DB3")]
    [Address(RVA = "0x32F57BC", Offset = "0x32F57BC", VA = "0x32F57BC")]
    private void LoadGuildFacilityRewardDescriptionDefault()
    {
    }

    [Token(Token = "0x6004DB4")]
    [Address(RVA = "0x32F5824", Offset = "0x32F5824", VA = "0x32F5824")]
    public GuildFacilityMaster LoadGuildFacility(string path) => (GuildFacilityMaster) null;

    [Token(Token = "0x6004DB5")]
    [Address(RVA = "0x32F587C", Offset = "0x32F587C", VA = "0x32F587C")]
    private void LoadGuildFacilityDefault()
    {
    }

    [Token(Token = "0x6004DB6")]
    [Address(RVA = "0x32F58E4", Offset = "0x32F58E4", VA = "0x32F58E4")]
    public GuildFaclityInvestRateMaster LoadGuildFaclityInvestRate(string path)
    {
      return (GuildFaclityInvestRateMaster) null;
    }

    [Token(Token = "0x6004DB7")]
    [Address(RVA = "0x32F593C", Offset = "0x32F593C", VA = "0x32F593C")]
    private void LoadGuildFaclityInvestRateDefault()
    {
    }

    [Token(Token = "0x6004DB8")]
    [Address(RVA = "0x32F59A4", Offset = "0x32F59A4", VA = "0x32F59A4")]
    public GuildEmblemMaster LoadGuildEmblem(string path) => (GuildEmblemMaster) null;

    [Token(Token = "0x6004DB9")]
    [Address(RVA = "0x32F59FC", Offset = "0x32F59FC", VA = "0x32F59FC")]
    private void LoadGuildEmblemDefault()
    {
    }

    [Token(Token = "0x6004DBA")]
    [Address(RVA = "0x32F5A64", Offset = "0x32F5A64", VA = "0x32F5A64")]
    public GuildExpMaster LoadGuildExp(string path) => (GuildExpMaster) null;

    [Token(Token = "0x6004DBB")]
    [Address(RVA = "0x32F5ABC", Offset = "0x32F5ABC", VA = "0x32F5ABC")]
    private void LoadGuildExpDefault()
    {
    }

    [Token(Token = "0x6004DBC")]
    [Address(RVA = "0x32F5B24", Offset = "0x32F5B24", VA = "0x32F5B24")]
    public GuildGiftMaster LoadGuildGift(string path) => (GuildGiftMaster) null;

    [Token(Token = "0x6004DBD")]
    [Address(RVA = "0x32F5B7C", Offset = "0x32F5B7C", VA = "0x32F5B7C")]
    private void LoadGuildGiftDefault()
    {
    }

    [Token(Token = "0x6004DBE")]
    [Address(RVA = "0x32F5BE4", Offset = "0x32F5BE4", VA = "0x32F5BE4")]
    public GuildRaidRewardLapDetailMaster LoadGuildRaidRewardLapDetail(string path)
    {
      return (GuildRaidRewardLapDetailMaster) null;
    }

    [Token(Token = "0x6004DBF")]
    [Address(RVA = "0x32F5C3C", Offset = "0x32F5C3C", VA = "0x32F5C3C")]
    private void LoadGuildRaidRewardLapDetailDefault()
    {
    }

    [Token(Token = "0x6004DC0")]
    [Address(RVA = "0x32F5CA4", Offset = "0x32F5CA4", VA = "0x32F5CA4")]
    public GuildRaidRewardLapMaster LoadGuildRaidRewardLap(string path)
    {
      return (GuildRaidRewardLapMaster) null;
    }

    [Token(Token = "0x6004DC1")]
    [Address(RVA = "0x32F5CFC", Offset = "0x32F5CFC", VA = "0x32F5CFC")]
    private void LoadGuildRaidRewardLapDefault()
    {
    }

    [Token(Token = "0x6004DC2")]
    [Address(RVA = "0x32F5D64", Offset = "0x32F5D64", VA = "0x32F5D64")]
    public GuildRaidRewardSpecialLapDetailMaster LoadGuildRaidRewardSpecialLapDetail(string path)
    {
      return (GuildRaidRewardSpecialLapDetailMaster) null;
    }

    [Token(Token = "0x6004DC3")]
    [Address(RVA = "0x32F5DBC", Offset = "0x32F5DBC", VA = "0x32F5DBC")]
    private void LoadGuildRaidRewardSpecialLapDetailDefault()
    {
    }

    [Token(Token = "0x6004DC4")]
    [Address(RVA = "0x32F5E24", Offset = "0x32F5E24", VA = "0x32F5E24")]
    public GuildRaidRewardSpecialLapMaster LoadGuildRaidRewardSpecialLap(string path)
    {
      return (GuildRaidRewardSpecialLapMaster) null;
    }

    [Token(Token = "0x6004DC5")]
    [Address(RVA = "0x32F5E7C", Offset = "0x32F5E7C", VA = "0x32F5E7C")]
    private void LoadGuildRaidRewardSpecialLapDefault()
    {
    }

    [Token(Token = "0x6004DC6")]
    [Address(RVA = "0x32F5EE4", Offset = "0x32F5EE4", VA = "0x32F5EE4")]
    public GuildRaidRewardSuppressDetailMaster LoadGuildRaidRewardSuppressDetail(string path)
    {
      return (GuildRaidRewardSuppressDetailMaster) null;
    }

    [Token(Token = "0x6004DC7")]
    [Address(RVA = "0x32F5F3C", Offset = "0x32F5F3C", VA = "0x32F5F3C")]
    private void LoadGuildRaidRewardSuppressDetailDefault()
    {
    }

    [Token(Token = "0x6004DC8")]
    [Address(RVA = "0x32F5FA4", Offset = "0x32F5FA4", VA = "0x32F5FA4")]
    public GuildRaidRewardSuppressMaster LoadGuildRaidRewardSuppress(string path)
    {
      return (GuildRaidRewardSuppressMaster) null;
    }

    [Token(Token = "0x6004DC9")]
    [Address(RVA = "0x32F5FFC", Offset = "0x32F5FFC", VA = "0x32F5FFC")]
    private void LoadGuildRaidRewardSuppressDefault()
    {
    }

    [Token(Token = "0x6004DCA")]
    [Address(RVA = "0x32F6064", Offset = "0x32F6064", VA = "0x32F6064")]
    public GuildRaidMaster LoadGuildRaid(string path) => (GuildRaidMaster) null;

    [Token(Token = "0x6004DCB")]
    [Address(RVA = "0x32F60BC", Offset = "0x32F60BC", VA = "0x32F60BC")]
    private void LoadGuildRaidDefault()
    {
    }

    [Token(Token = "0x6004DCC")]
    [Address(RVA = "0x32F6124", Offset = "0x32F6124", VA = "0x32F6124")]
    public GuildStampMaster LoadGuildStamp(string path) => (GuildStampMaster) null;

    [Token(Token = "0x6004DCD")]
    [Address(RVA = "0x32F617C", Offset = "0x32F617C", VA = "0x32F617C")]
    private void LoadGuildStampDefault()
    {
    }

    [Token(Token = "0x6004DCE")]
    [Address(RVA = "0x32F61E4", Offset = "0x32F61E4", VA = "0x32F61E4")]
    public GuildTitleMaster LoadGuildTitle(string path) => (GuildTitleMaster) null;

    [Token(Token = "0x6004DCF")]
    [Address(RVA = "0x32F623C", Offset = "0x32F623C", VA = "0x32F623C")]
    private void LoadGuildTitleDefault()
    {
    }

    [Token(Token = "0x6004DD0")]
    [Address(RVA = "0x32F62A4", Offset = "0x32F62A4", VA = "0x32F62A4")]
    public GuildBattleSettingsMaster LoadGuildBattleSettings(string path)
    {
      return (GuildBattleSettingsMaster) null;
    }

    [Token(Token = "0x6004DD1")]
    [Address(RVA = "0x32F62FC", Offset = "0x32F62FC", VA = "0x32F62FC")]
    private void LoadGuildBattleSettingsDefault()
    {
    }

    [Token(Token = "0x6004DD2")]
    [Address(RVA = "0x32F6364", Offset = "0x32F6364", VA = "0x32F6364")]
    public GuildAttendRewardDescriptionMaster LoadGuildAttendRewardDescription(string path)
    {
      return (GuildAttendRewardDescriptionMaster) null;
    }

    [Token(Token = "0x6004DD3")]
    [Address(RVA = "0x32F63BC", Offset = "0x32F63BC", VA = "0x32F63BC")]
    private void LoadGuildAttendRewardDescriptionDefault()
    {
    }

    [Token(Token = "0x6004DD4")]
    [Address(RVA = "0x32F6424", Offset = "0x32F6424", VA = "0x32F6424")]
    public GuildLevelRewardMaster LoadGuildLevelReward(string path)
    {
      return (GuildLevelRewardMaster) null;
    }

    [Token(Token = "0x6004DD5")]
    [Address(RVA = "0x32F647C", Offset = "0x32F647C", VA = "0x32F647C")]
    private void LoadGuildLevelRewardDefault()
    {
    }

    [Token(Token = "0x6004DD6")]
    [Address(RVA = "0x32F64E4", Offset = "0x32F64E4", VA = "0x32F64E4")]
    public GuildRoleRewardDescriptionMaster LoadGuildRoleRewardDescription(string path)
    {
      return (GuildRoleRewardDescriptionMaster) null;
    }

    [Token(Token = "0x6004DD7")]
    [Address(RVA = "0x32F653C", Offset = "0x32F653C", VA = "0x32F653C")]
    private void LoadGuildRoleRewardDescriptionDefault()
    {
    }

    [Token(Token = "0x6004DD8")]
    [Address(RVA = "0x32F65A4", Offset = "0x32F65A4", VA = "0x32F65A4")]
    public GuildUnlockedElementDescriptionMaster LoadGuildUnlockedElementDescription(string path)
    {
      return (GuildUnlockedElementDescriptionMaster) null;
    }

    [Token(Token = "0x6004DD9")]
    [Address(RVA = "0x32F65FC", Offset = "0x32F65FC", VA = "0x32F65FC")]
    private void LoadGuildUnlockedElementDescriptionDefault()
    {
    }

    [Token(Token = "0x6004DDA")]
    [Address(RVA = "0x32F6664", Offset = "0x32F6664", VA = "0x32F6664")]
    public EventButtonMaster LoadEventButton(string path) => (EventButtonMaster) null;

    [Token(Token = "0x6004DDB")]
    [Address(RVA = "0x32F66BC", Offset = "0x32F66BC", VA = "0x32F66BC")]
    private void LoadEventButtonDefault()
    {
    }

    [Token(Token = "0x6004DDC")]
    [Address(RVA = "0x32F6724", Offset = "0x32F6724", VA = "0x32F6724")]
    public HomeEventBalloonMaster LoadHomeEventBalloon(string path)
    {
      return (HomeEventBalloonMaster) null;
    }

    [Token(Token = "0x6004DDD")]
    [Address(RVA = "0x32F677C", Offset = "0x32F677C", VA = "0x32F677C")]
    private void LoadHomeEventBalloonDefault()
    {
    }

    [Token(Token = "0x6004DDE")]
    [Address(RVA = "0x32F67E4", Offset = "0x32F67E4", VA = "0x32F67E4")]
    public HomeEventMaster LoadHomeEvent(string path) => (HomeEventMaster) null;

    [Token(Token = "0x6004DDF")]
    [Address(RVA = "0x32F683C", Offset = "0x32F683C", VA = "0x32F683C")]
    private void LoadHomeEventDefault()
    {
    }

    [Token(Token = "0x6004DE0")]
    [Address(RVA = "0x32F68A4", Offset = "0x32F68A4", VA = "0x32F68A4")]
    public HomeSeasonScheduleMaster LoadHomeSeasonSchedule(string path)
    {
      return (HomeSeasonScheduleMaster) null;
    }

    [Token(Token = "0x6004DE1")]
    [Address(RVA = "0x32F68FC", Offset = "0x32F68FC", VA = "0x32F68FC")]
    private void LoadHomeSeasonScheduleDefault()
    {
    }

    [Token(Token = "0x6004DE2")]
    [Address(RVA = "0x32F6964", Offset = "0x32F6964", VA = "0x32F6964")]
    public HomeSerifDescriptionMaster LoadHomeSerifDescription(string path)
    {
      return (HomeSerifDescriptionMaster) null;
    }

    [Token(Token = "0x6004DE3")]
    [Address(RVA = "0x32F69BC", Offset = "0x32F69BC", VA = "0x32F69BC")]
    private void LoadHomeSerifDescriptionDefault()
    {
    }

    [Token(Token = "0x6004DE4")]
    [Address(RVA = "0x32F6A24", Offset = "0x32F6A24", VA = "0x32F6A24")]
    public HomeTimeAnnouncementScheduleMaster LoadHomeTimeAnnouncementSchedule(string path)
    {
      return (HomeTimeAnnouncementScheduleMaster) null;
    }

    [Token(Token = "0x6004DE5")]
    [Address(RVA = "0x32F6A7C", Offset = "0x32F6A7C", VA = "0x32F6A7C")]
    private void LoadHomeTimeAnnouncementScheduleDefault()
    {
    }

    [Token(Token = "0x6004DE6")]
    [Address(RVA = "0x32F6AE4", Offset = "0x32F6AE4", VA = "0x32F6AE4")]
    public IntroChapterConstMaster LoadIntroChapterConst(string path)
    {
      return (IntroChapterConstMaster) null;
    }

    [Token(Token = "0x6004DE7")]
    [Address(RVA = "0x32F6B3C", Offset = "0x32F6B3C", VA = "0x32F6B3C")]
    private void LoadIntroChapterConstDefault()
    {
    }

    [Token(Token = "0x6004DE8")]
    [Address(RVA = "0x32F6BA4", Offset = "0x32F6BA4", VA = "0x32F6BA4")]
    public IntroChapterSequenceAdvSettingMaster LoadIntroChapterSequenceAdvSetting(string path)
    {
      return (IntroChapterSequenceAdvSettingMaster) null;
    }

    [Token(Token = "0x6004DE9")]
    [Address(RVA = "0x32F6BFC", Offset = "0x32F6BFC", VA = "0x32F6BFC")]
    private void LoadIntroChapterSequenceAdvSettingDefault()
    {
    }

    [Token(Token = "0x6004DEA")]
    [Address(RVA = "0x32F6C64", Offset = "0x32F6C64", VA = "0x32F6C64")]
    public IntroChapterSequenceBattleSettingMaster LoadIntroChapterSequenceBattleSetting(string path)
    {
      return (IntroChapterSequenceBattleSettingMaster) null;
    }

    [Token(Token = "0x6004DEB")]
    [Address(RVA = "0x32F6CBC", Offset = "0x32F6CBC", VA = "0x32F6CBC")]
    private void LoadIntroChapterSequenceBattleSettingDefault()
    {
    }

    [Token(Token = "0x6004DEC")]
    [Address(RVA = "0x32F6D24", Offset = "0x32F6D24", VA = "0x32F6D24")]
    public IntroChapterSequenceFreeActionSettingMaster LoadIntroChapterSequenceFreeActionSetting(
      string path)
    {
      return (IntroChapterSequenceFreeActionSettingMaster) null;
    }

    [Token(Token = "0x6004DED")]
    [Address(RVA = "0x32F6D7C", Offset = "0x32F6D7C", VA = "0x32F6D7C")]
    private void LoadIntroChapterSequenceFreeActionSettingDefault()
    {
    }

    [Token(Token = "0x6004DEE")]
    [Address(RVA = "0x32F6DE4", Offset = "0x32F6DE4", VA = "0x32F6DE4")]
    public IntroChapterSequenceHomeTutorialSettingMaster LoadIntroChapterSequenceHomeTutorialSetting(
      string path)
    {
      return (IntroChapterSequenceHomeTutorialSettingMaster) null;
    }

    [Token(Token = "0x6004DEF")]
    [Address(RVA = "0x32F6E3C", Offset = "0x32F6E3C", VA = "0x32F6E3C")]
    private void LoadIntroChapterSequenceHomeTutorialSettingDefault()
    {
    }

    [Token(Token = "0x6004DF0")]
    [Address(RVA = "0x32F6EA4", Offset = "0x32F6EA4", VA = "0x32F6EA4")]
    public IntroChapterSequenceMaster LoadIntroChapterSequence(string path)
    {
      return (IntroChapterSequenceMaster) null;
    }

    [Token(Token = "0x6004DF1")]
    [Address(RVA = "0x32F6EFC", Offset = "0x32F6EFC", VA = "0x32F6EFC")]
    private void LoadIntroChapterSequenceDefault()
    {
    }

    [Token(Token = "0x6004DF2")]
    [Address(RVA = "0x32F6F64", Offset = "0x32F6F64", VA = "0x32F6F64")]
    public AbilityBoardItemMaster LoadAbilityBoardItem(string path)
    {
      return (AbilityBoardItemMaster) null;
    }

    [Token(Token = "0x6004DF3")]
    [Address(RVA = "0x32F6FBC", Offset = "0x32F6FBC", VA = "0x32F6FBC")]
    private void LoadAbilityBoardItemDefault()
    {
    }

    [Token(Token = "0x6004DF4")]
    [Address(RVA = "0x32F7024", Offset = "0x32F7024", VA = "0x32F7024")]
    public AccessoryPieceMaster LoadAccessoryPiece(string path) => (AccessoryPieceMaster) null;

    [Token(Token = "0x6004DF5")]
    [Address(RVA = "0x32F707C", Offset = "0x32F707C", VA = "0x32F707C")]
    private void LoadAccessoryPieceDefault()
    {
    }

    [Token(Token = "0x6004DF6")]
    [Address(RVA = "0x32F70E4", Offset = "0x32F70E4", VA = "0x32F70E4")]
    public ArenaBattleTicketMaster LoadArenaBattleTicket(string path)
    {
      return (ArenaBattleTicketMaster) null;
    }

    [Token(Token = "0x6004DF7")]
    [Address(RVA = "0x32F713C", Offset = "0x32F713C", VA = "0x32F713C")]
    private void LoadArenaBattleTicketDefault()
    {
    }

    [Token(Token = "0x6004DF8")]
    [Address(RVA = "0x32F71A4", Offset = "0x32F71A4", VA = "0x32F71A4")]
    public BossChallengeTicketMaster LoadBossChallengeTicket(string path)
    {
      return (BossChallengeTicketMaster) null;
    }

    [Token(Token = "0x6004DF9")]
    [Address(RVA = "0x32F71FC", Offset = "0x32F71FC", VA = "0x32F71FC")]
    private void LoadBossChallengeTicketDefault()
    {
    }

    [Token(Token = "0x6004DFA")]
    [Address(RVA = "0x32F7264", Offset = "0x32F7264", VA = "0x32F7264")]
    public BoxItemConstMaster LoadBoxItemConst(string path) => (BoxItemConstMaster) null;

    [Token(Token = "0x6004DFB")]
    [Address(RVA = "0x32F72BC", Offset = "0x32F72BC", VA = "0x32F72BC")]
    private void LoadBoxItemConstDefault()
    {
    }

    [Token(Token = "0x6004DFC")]
    [Address(RVA = "0x32F7324", Offset = "0x32F7324", VA = "0x32F7324")]
    public BoxItemContentsMaster LoadBoxItemContents(string path) => (BoxItemContentsMaster) null;

    [Token(Token = "0x6004DFD")]
    [Address(RVA = "0x32F737C", Offset = "0x32F737C", VA = "0x32F737C")]
    private void LoadBoxItemContentsDefault()
    {
    }

    [Token(Token = "0x6004DFE")]
    [Address(RVA = "0x32F73E4", Offset = "0x32F73E4", VA = "0x32F73E4")]
    public BoxItemMaster LoadBoxItem(string path) => (BoxItemMaster) null;

    [Token(Token = "0x6004DFF")]
    [Address(RVA = "0x32F743C", Offset = "0x32F743C", VA = "0x32F743C")]
    private void LoadBoxItemDefault()
    {
    }

    [Token(Token = "0x6004E00")]
    [Address(RVA = "0x32F74A4", Offset = "0x32F74A4", VA = "0x32F74A4")]
    public ChapterItemMaster LoadChapterItem(string path) => (ChapterItemMaster) null;

    [Token(Token = "0x6004E01")]
    [Address(RVA = "0x32F74FC", Offset = "0x32F74FC", VA = "0x32F74FC")]
    private void LoadChapterItemDefault()
    {
    }

    [Token(Token = "0x6004E02")]
    [Address(RVA = "0x32F7564", Offset = "0x32F7564", VA = "0x32F7564")]
    public CurrencyMaster LoadCurrency(string path) => (CurrencyMaster) null;

    [Token(Token = "0x6004E03")]
    [Address(RVA = "0x32F75BC", Offset = "0x32F75BC", VA = "0x32F75BC")]
    private void LoadCurrencyDefault()
    {
    }

    [Token(Token = "0x6004E04")]
    [Address(RVA = "0x32F7624", Offset = "0x32F7624", VA = "0x32F7624")]
    public EnergyRecoveryMaster LoadEnergyRecovery(string path) => (EnergyRecoveryMaster) null;

    [Token(Token = "0x6004E05")]
    [Address(RVA = "0x32F767C", Offset = "0x32F767C", VA = "0x32F767C")]
    private void LoadEnergyRecoveryDefault()
    {
    }

    [Token(Token = "0x6004E06")]
    [Address(RVA = "0x32F76E4", Offset = "0x32F76E4", VA = "0x32F76E4")]
    public EpItemMaster LoadEpItem(string path) => (EpItemMaster) null;

    [Token(Token = "0x6004E07")]
    [Address(RVA = "0x32F773C", Offset = "0x32F773C", VA = "0x32F773C")]
    private void LoadEpItemDefault()
    {
    }

    [Token(Token = "0x6004E08")]
    [Address(RVA = "0x32F77A4", Offset = "0x32F77A4", VA = "0x32F77A4")]
    public EquipmentSkillEnhanceMaster LoadEquipmentSkillEnhance(string path)
    {
      return (EquipmentSkillEnhanceMaster) null;
    }

    [Token(Token = "0x6004E09")]
    [Address(RVA = "0x32F77FC", Offset = "0x32F77FC", VA = "0x32F77FC")]
    private void LoadEquipmentSkillEnhanceDefault()
    {
    }

    [Token(Token = "0x6004E0A")]
    [Address(RVA = "0x32F7864", Offset = "0x32F7864", VA = "0x32F7864")]
    public ExchangeMaster LoadExchange(string path) => (ExchangeMaster) null;

    [Token(Token = "0x6004E0B")]
    [Address(RVA = "0x32F78BC", Offset = "0x32F78BC", VA = "0x32F78BC")]
    private void LoadExchangeDefault()
    {
    }

    [Token(Token = "0x6004E0C")]
    [Address(RVA = "0x32F7924", Offset = "0x32F7924", VA = "0x32F7924")]
    public ExpeditionRapidTicketMaster LoadExpeditionRapidTicket(string path)
    {
      return (ExpeditionRapidTicketMaster) null;
    }

    [Token(Token = "0x6004E0D")]
    [Address(RVA = "0x32F797C", Offset = "0x32F797C", VA = "0x32F797C")]
    private void LoadExpeditionRapidTicketDefault()
    {
    }

    [Token(Token = "0x6004E0E")]
    [Address(RVA = "0x32F79E4", Offset = "0x32F79E4", VA = "0x32F79E4")]
    public ExpendablesMaster LoadExpendables(string path) => (ExpendablesMaster) null;

    [Token(Token = "0x6004E0F")]
    [Address(RVA = "0x32F7A3C", Offset = "0x32F7A3C", VA = "0x32F7A3C")]
    private void LoadExpendablesDefault()
    {
    }

    [Token(Token = "0x6004E10")]
    [Address(RVA = "0x32F7AA4", Offset = "0x32F7AA4", VA = "0x32F7AA4")]
    public GachaTicketMaster LoadGachaTicket(string path) => (GachaTicketMaster) null;

    [Token(Token = "0x6004E11")]
    [Address(RVA = "0x32F7AFC", Offset = "0x32F7AFC", VA = "0x32F7AFC")]
    private void LoadGachaTicketDefault()
    {
    }

    [Token(Token = "0x6004E12")]
    [Address(RVA = "0x32F7B64", Offset = "0x32F7B64", VA = "0x32F7B64")]
    public GeneralItemMaster LoadGeneralItem(string path) => (GeneralItemMaster) null;

    [Token(Token = "0x6004E13")]
    [Address(RVA = "0x32F7BBC", Offset = "0x32F7BBC", VA = "0x32F7BBC")]
    private void LoadGeneralItemDefault()
    {
    }

    [Token(Token = "0x6004E14")]
    [Address(RVA = "0x32F7C24", Offset = "0x32F7C24", VA = "0x32F7C24")]
    public ItemPossessionLimitMaster LoadItemPossessionLimit(string path)
    {
      return (ItemPossessionLimitMaster) null;
    }

    [Token(Token = "0x6004E15")]
    [Address(RVA = "0x32F7C7C", Offset = "0x32F7C7C", VA = "0x32F7C7C")]
    private void LoadItemPossessionLimitDefault()
    {
    }

    [Token(Token = "0x6004E16")]
    [Address(RVA = "0x32F7CE4", Offset = "0x32F7CE4", VA = "0x32F7CE4")]
    public MedalMaster LoadMedal(string path) => (MedalMaster) null;

    [Token(Token = "0x6004E17")]
    [Address(RVA = "0x32F7D3C", Offset = "0x32F7D3C", VA = "0x32F7D3C")]
    private void LoadMedalDefault()
    {
    }

    [Token(Token = "0x6004E18")]
    [Address(RVA = "0x32F7DA4", Offset = "0x32F7DA4", VA = "0x32F7DA4")]
    public PersonalEmblemCategoryMaster LoadPersonalEmblemCategory(string path)
    {
      return (PersonalEmblemCategoryMaster) null;
    }

    [Token(Token = "0x6004E19")]
    [Address(RVA = "0x32F7DFC", Offset = "0x32F7DFC", VA = "0x32F7DFC")]
    private void LoadPersonalEmblemCategoryDefault()
    {
    }

    [Token(Token = "0x6004E1A")]
    [Address(RVA = "0x32F7E64", Offset = "0x32F7E64", VA = "0x32F7E64")]
    public PersonalEmblemMaster LoadPersonalEmblem(string path) => (PersonalEmblemMaster) null;

    [Token(Token = "0x6004E1B")]
    [Address(RVA = "0x32F7EBC", Offset = "0x32F7EBC", VA = "0x32F7EBC")]
    private void LoadPersonalEmblemDefault()
    {
    }

    [Token(Token = "0x6004E1C")]
    [Address(RVA = "0x32F7F24", Offset = "0x32F7F24", VA = "0x32F7F24")]
    public ResourceItemMaster LoadResourceItem(string path) => (ResourceItemMaster) null;

    [Token(Token = "0x6004E1D")]
    [Address(RVA = "0x32F7F7C", Offset = "0x32F7F7C", VA = "0x32F7F7C")]
    private void LoadResourceItemDefault()
    {
    }

    [Token(Token = "0x6004E1E")]
    [Address(RVA = "0x32F7FE4", Offset = "0x32F7FE4", VA = "0x32F7FE4")]
    public UnitEnhanceMaster LoadUnitEnhance(string path) => (UnitEnhanceMaster) null;

    [Token(Token = "0x6004E1F")]
    [Address(RVA = "0x32F803C", Offset = "0x32F803C", VA = "0x32F803C")]
    private void LoadUnitEnhanceDefault()
    {
    }

    [Token(Token = "0x6004E20")]
    [Address(RVA = "0x32F80A4", Offset = "0x32F80A4", VA = "0x32F80A4")]
    public UnitPieceMaster LoadUnitPiece(string path) => (UnitPieceMaster) null;

    [Token(Token = "0x6004E21")]
    [Address(RVA = "0x32F80FC", Offset = "0x32F80FC", VA = "0x32F80FC")]
    private void LoadUnitPieceDefault()
    {
    }

    [Token(Token = "0x6004E22")]
    [Address(RVA = "0x32F8164", Offset = "0x32F8164", VA = "0x32F8164")]
    public UsageItemMaster LoadUsageItem(string path) => (UsageItemMaster) null;

    [Token(Token = "0x6004E23")]
    [Address(RVA = "0x32F81BC", Offset = "0x32F81BC", VA = "0x32F81BC")]
    private void LoadUsageItemDefault()
    {
    }

    [Token(Token = "0x6004E24")]
    [Address(RVA = "0x32F8224", Offset = "0x32F8224", VA = "0x32F8224")]
    public UsageNameMaster LoadUsageName(string path) => (UsageNameMaster) null;

    [Token(Token = "0x6004E25")]
    [Address(RVA = "0x32F827C", Offset = "0x32F827C", VA = "0x32F827C")]
    private void LoadUsageNameDefault()
    {
    }

    [Token(Token = "0x6004E26")]
    [Address(RVA = "0x32F82E4", Offset = "0x32F82E4", VA = "0x32F82E4")]
    public WeaponPieceMaster LoadWeaponPiece(string path) => (WeaponPieceMaster) null;

    [Token(Token = "0x6004E27")]
    [Address(RVA = "0x32F833C", Offset = "0x32F833C", VA = "0x32F833C")]
    private void LoadWeaponPieceDefault()
    {
    }

    [Token(Token = "0x6004E28")]
    [Address(RVA = "0x32F83A4", Offset = "0x32F83A4", VA = "0x32F83A4")]
    public LobbyFreeActionAreaSettingMaster LoadLobbyFreeActionAreaSetting(string path)
    {
      return (LobbyFreeActionAreaSettingMaster) null;
    }

    [Token(Token = "0x6004E29")]
    [Address(RVA = "0x32F83FC", Offset = "0x32F83FC", VA = "0x32F83FC")]
    private void LoadLobbyFreeActionAreaSettingDefault()
    {
    }

    [Token(Token = "0x6004E2A")]
    [Address(RVA = "0x32F8464", Offset = "0x32F8464", VA = "0x32F8464")]
    public LobbyFreeActionConditionsMaster LoadLobbyFreeActionConditions(string path)
    {
      return (LobbyFreeActionConditionsMaster) null;
    }

    [Token(Token = "0x6004E2B")]
    [Address(RVA = "0x32F84BC", Offset = "0x32F84BC", VA = "0x32F84BC")]
    private void LoadLobbyFreeActionConditionsDefault()
    {
    }

    [Token(Token = "0x6004E2C")]
    [Address(RVA = "0x32F8524", Offset = "0x32F8524", VA = "0x32F8524")]
    public LobbyFreeActionEventMaster LoadLobbyFreeActionEvent(string path)
    {
      return (LobbyFreeActionEventMaster) null;
    }

    [Token(Token = "0x6004E2D")]
    [Address(RVA = "0x32F857C", Offset = "0x32F857C", VA = "0x32F857C")]
    private void LoadLobbyFreeActionEventDefault()
    {
    }

    [Token(Token = "0x6004E2E")]
    [Address(RVA = "0x32F85E4", Offset = "0x32F85E4", VA = "0x32F85E4")]
    public LobbyFreeActionLayoutMaster LoadLobbyFreeActionLayout(string path)
    {
      return (LobbyFreeActionLayoutMaster) null;
    }

    [Token(Token = "0x6004E2F")]
    [Address(RVA = "0x32F863C", Offset = "0x32F863C", VA = "0x32F863C")]
    private void LoadLobbyFreeActionLayoutDefault()
    {
    }

    [Token(Token = "0x6004E30")]
    [Address(RVA = "0x32F86A4", Offset = "0x32F86A4", VA = "0x32F86A4")]
    public LobbyFreeActionLeaderUnitEventMaster LoadLobbyFreeActionLeaderUnitEvent(string path)
    {
      return (LobbyFreeActionLeaderUnitEventMaster) null;
    }

    [Token(Token = "0x6004E31")]
    [Address(RVA = "0x32F86FC", Offset = "0x32F86FC", VA = "0x32F86FC")]
    private void LoadLobbyFreeActionLeaderUnitEventDefault()
    {
    }

    [Token(Token = "0x6004E32")]
    [Address(RVA = "0x32F8764", Offset = "0x32F8764", VA = "0x32F8764")]
    public LobbyFreeActionLeaderUnitLayoutMaster LoadLobbyFreeActionLeaderUnitLayout(string path)
    {
      return (LobbyFreeActionLeaderUnitLayoutMaster) null;
    }

    [Token(Token = "0x6004E33")]
    [Address(RVA = "0x32F87BC", Offset = "0x32F87BC", VA = "0x32F87BC")]
    private void LoadLobbyFreeActionLeaderUnitLayoutDefault()
    {
    }

    [Token(Token = "0x6004E34")]
    [Address(RVA = "0x32F8824", Offset = "0x32F8824", VA = "0x32F8824")]
    public LobbyFreeActionObjectMaster LoadLobbyFreeActionObject(string path)
    {
      return (LobbyFreeActionObjectMaster) null;
    }

    [Token(Token = "0x6004E35")]
    [Address(RVA = "0x32F887C", Offset = "0x32F887C", VA = "0x32F887C")]
    private void LoadLobbyFreeActionObjectDefault()
    {
    }

    [Token(Token = "0x6004E36")]
    [Address(RVA = "0x32F88E4", Offset = "0x32F88E4", VA = "0x32F88E4")]
    public LobbySeasonMaster LoadLobbySeason(string path) => (LobbySeasonMaster) null;

    [Token(Token = "0x6004E37")]
    [Address(RVA = "0x32F893C", Offset = "0x32F893C", VA = "0x32F893C")]
    private void LoadLobbySeasonDefault()
    {
    }

    [Token(Token = "0x6004E38")]
    [Address(RVA = "0x32F89A4", Offset = "0x32F89A4", VA = "0x32F89A4")]
    public LobbySettingMaster LoadLobbySetting(string path) => (LobbySettingMaster) null;

    [Token(Token = "0x6004E39")]
    [Address(RVA = "0x32F89FC", Offset = "0x32F89FC", VA = "0x32F89FC")]
    private void LoadLobbySettingDefault()
    {
    }

    [Token(Token = "0x6004E3A")]
    [Address(RVA = "0x32F8A64", Offset = "0x32F8A64", VA = "0x32F8A64")]
    public LobbyTimeslotMaster LoadLobbyTimeslot(string path) => (LobbyTimeslotMaster) null;

    [Token(Token = "0x6004E3B")]
    [Address(RVA = "0x32F8ABC", Offset = "0x32F8ABC", VA = "0x32F8ABC")]
    private void LoadLobbyTimeslotDefault()
    {
    }

    [Token(Token = "0x6004E3C")]
    [Address(RVA = "0x32F8B24", Offset = "0x32F8B24", VA = "0x32F8B24")]
    public LoginBonusDetailAlwaysMaster LoadLoginBonusDetailAlways(string path)
    {
      return (LoginBonusDetailAlwaysMaster) null;
    }

    [Token(Token = "0x6004E3D")]
    [Address(RVA = "0x32F8B7C", Offset = "0x32F8B7C", VA = "0x32F8B7C")]
    private void LoadLoginBonusDetailAlwaysDefault()
    {
    }

    [Token(Token = "0x6004E3E")]
    [Address(RVA = "0x32F8BE4", Offset = "0x32F8BE4", VA = "0x32F8BE4")]
    public LoginBonusRewardDetailMaster LoadLoginBonusRewardDetail(string path)
    {
      return (LoginBonusRewardDetailMaster) null;
    }

    [Token(Token = "0x6004E3F")]
    [Address(RVA = "0x32F8C3C", Offset = "0x32F8C3C", VA = "0x32F8C3C")]
    private void LoadLoginBonusRewardDetailDefault()
    {
    }

    [Token(Token = "0x6004E40")]
    [Address(RVA = "0x32F8CA4", Offset = "0x32F8CA4", VA = "0x32F8CA4")]
    public LoginBonusRewardMaster LoadLoginBonusReward(string path)
    {
      return (LoginBonusRewardMaster) null;
    }

    [Token(Token = "0x6004E41")]
    [Address(RVA = "0x32F8CFC", Offset = "0x32F8CFC", VA = "0x32F8CFC")]
    private void LoadLoginBonusRewardDefault()
    {
    }

    [Token(Token = "0x6004E42")]
    [Address(RVA = "0x32F8D64", Offset = "0x32F8D64", VA = "0x32F8D64")]
    public LoginBonusMaster LoadLoginBonus(string path) => (LoginBonusMaster) null;

    [Token(Token = "0x6004E43")]
    [Address(RVA = "0x32F8DBC", Offset = "0x32F8DBC", VA = "0x32F8DBC")]
    private void LoadLoginBonusDefault()
    {
    }

    [Token(Token = "0x17000B1E")]
    public bool IsLoadedDatas
    {
      [Token(Token = "0x6004E44"), Address(RVA = "0x32F8E24", Offset = "0x32F8E24", VA = "0x32F8E24")] get
      {
        return new bool();
      }
      [Token(Token = "0x6004E45"), Address(RVA = "0x32F8E2C", Offset = "0x32F8E2C", VA = "0x32F8E2C")] private set
      {
      }
    }

    [Token(Token = "0x17000B1F")]
    public AdvFriendshipUpTypeMaster AdvFriendshipUpTypeData
    {
      [Token(Token = "0x6004E46"), Address(RVA = "0x32F8E38", Offset = "0x32F8E38", VA = "0x32F8E38")] get
      {
        return (AdvFriendshipUpTypeMaster) null;
      }
    }

    [Token(Token = "0x17000B20")]
    public AdvPersonalUpTypeMaster AdvPersonalUpTypeData
    {
      [Token(Token = "0x6004E47"), Address(RVA = "0x32F8E40", Offset = "0x32F8E40", VA = "0x32F8E40")] get
      {
        return (AdvPersonalUpTypeMaster) null;
      }
    }

    [Token(Token = "0x17000B21")]
    public ChatPollingIntervalMaster ChatPollingIntervalData
    {
      [Token(Token = "0x6004E48"), Address(RVA = "0x32F8E48", Offset = "0x32F8E48", VA = "0x32F8E48")] get
      {
        return (ChatPollingIntervalMaster) null;
      }
    }

    [Token(Token = "0x17000B22")]
    public RangeShapeDetailMaster RangeShapeDetailData
    {
      [Token(Token = "0x6004E49"), Address(RVA = "0x32F8E50", Offset = "0x32F8E50", VA = "0x32F8E50")] get
      {
        return (RangeShapeDetailMaster) null;
      }
    }

    [Token(Token = "0x17000B23")]
    public TutorialMaster TutorialData
    {
      [Token(Token = "0x6004E4A"), Address(RVA = "0x32F8E58", Offset = "0x32F8E58", VA = "0x32F8E58")] get
      {
        return (TutorialMaster) null;
      }
    }

    [Token(Token = "0x6004E4B")]
    [Address(RVA = "0x32F8E60", Offset = "0x32F8E60", VA = "0x32F8E60")]
    private void LoadAssetSuccess(List<string> successList, Dictionary<string, string> errorDic)
    {
    }

    [Token(Token = "0x6004E4C")]
    [Address(RVA = "0x32F8E6C", Offset = "0x32F8E6C", VA = "0x32F8E6C")]
    public IEnumerator ReloadBasic(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E4D")]
    [Address(RVA = "0x32F8EE0", Offset = "0x32F8EE0", VA = "0x32F8EE0")]
    public IEnumerator Reloadadv(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E4E")]
    [Address(RVA = "0x32F8F54", Offset = "0x32F8F54", VA = "0x32F8F54")]
    public IEnumerator Reloadadv_storyadvchoices(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E4F")]
    [Address(RVA = "0x32F8FC8", Offset = "0x32F8FC8", VA = "0x32F8FC8")]
    public IEnumerator Reloadadv_storyadvinfo(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E50")]
    [Address(RVA = "0x32F903C", Offset = "0x32F903C", VA = "0x32F903C")]
    public IEnumerator Reloadadv_storyadvtype(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E51")]
    [Address(RVA = "0x32F90B0", Offset = "0x32F90B0", VA = "0x32F90B0")]
    public IEnumerator Reloadai(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E52")]
    [Address(RVA = "0x32F9124", Offset = "0x32F9124", VA = "0x32F9124")]
    public IEnumerator Reloadarena(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E53")]
    [Address(RVA = "0x32F9198", Offset = "0x32F9198", VA = "0x32F9198")]
    public IEnumerator Reloadarena_const(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E54")]
    [Address(RVA = "0x32F920C", Offset = "0x32F920C", VA = "0x32F920C")]
    public IEnumerator Reloadarena_reward(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E55")]
    [Address(RVA = "0x32F9280", Offset = "0x32F9280", VA = "0x32F9280")]
    public IEnumerator Reloadarena_ranking(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E56")]
    [Address(RVA = "0x32F92F4", Offset = "0x32F92F4", VA = "0x32F92F4")]
    public IEnumerator Reloadbattle(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E57")]
    [Address(RVA = "0x32F9368", Offset = "0x32F9368", VA = "0x32F9368")]
    public IEnumerator Reloadbattle_adv(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E58")]
    [Address(RVA = "0x32F93DC", Offset = "0x32F93DC", VA = "0x32F93DC")]
    public IEnumerator Reloadbattle_const(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E59")]
    [Address(RVA = "0x32F9450", Offset = "0x32F9450", VA = "0x32F9450")]
    public IEnumerator Reloadbattle_drop(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E5A")]
    [Address(RVA = "0x32F94C4", Offset = "0x32F94C4", VA = "0x32F94C4")]
    public IEnumerator Reloadbattle_enemy(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E5B")]
    [Address(RVA = "0x32F9538", Offset = "0x32F9538", VA = "0x32F9538")]
    public IEnumerator Reloadbattle_object(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E5C")]
    [Address(RVA = "0x32F95AC", Offset = "0x32F95AC", VA = "0x32F95AC")]
    public IEnumerator Reloadbattle_forced_sortie(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E5D")]
    [Address(RVA = "0x32F9620", Offset = "0x32F9620", VA = "0x32F9620")]
    public IEnumerator Reloadbattle_guest(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E5E")]
    [Address(RVA = "0x32F9694", Offset = "0x32F9694", VA = "0x32F9694")]
    public IEnumerator Reloadbattle_initial_placement(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E5F")]
    [Address(RVA = "0x32F9708", Offset = "0x32F9708", VA = "0x32F9708")]
    public IEnumerator Reloadbattle_mission(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E60")]
    [Address(RVA = "0x32F977C", Offset = "0x32F977C", VA = "0x32F977C")]
    public IEnumerator Reloadbattle_reward(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E61")]
    [Address(RVA = "0x32F97F0", Offset = "0x32F97F0", VA = "0x32F97F0")]
    public IEnumerator Reloadbattle_sortie_restrictions(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E62")]
    [Address(RVA = "0x32F9864", Offset = "0x32F9864", VA = "0x32F9864")]
    public IEnumerator Reloadbattle_thirdarmy(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E63")]
    [Address(RVA = "0x32F98D8", Offset = "0x32F98D8", VA = "0x32F98D8")]
    public IEnumerator Reloadbattle_enum(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E64")]
    [Address(RVA = "0x32F994C", Offset = "0x32F994C", VA = "0x32F994C")]
    public IEnumerator Reloadbattle_npc(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E65")]
    [Address(RVA = "0x32F99C0", Offset = "0x32F99C0", VA = "0x32F99C0")]
    public IEnumerator Reloadchat(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E66")]
    [Address(RVA = "0x32F9A34", Offset = "0x32F9A34", VA = "0x32F9A34")]
    public IEnumerator Reloadcommon(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E67")]
    [Address(RVA = "0x32F9AA8", Offset = "0x32F9AA8", VA = "0x32F9AA8")]
    public IEnumerator Reloadcommon_const(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E68")]
    [Address(RVA = "0x32F9B1C", Offset = "0x32F9B1C", VA = "0x32F9B1C")]
    public IEnumerator Reloadenum(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E69")]
    [Address(RVA = "0x32F9B90", Offset = "0x32F9B90", VA = "0x32F9B90")]
    public IEnumerator Reloadcommon_footsteps(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E6A")]
    [Address(RVA = "0x32F9C04", Offset = "0x32F9C04", VA = "0x32F9C04")]
    public IEnumerator Reloadcommon_guideline(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E6B")]
    [Address(RVA = "0x32F9C78", Offset = "0x32F9C78", VA = "0x32F9C78")]
    public IEnumerator Reloadcommon_network_error(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E6C")]
    [Address(RVA = "0x32F9CEC", Offset = "0x32F9CEC", VA = "0x32F9CEC")]
    public IEnumerator Reloadcommon_penalty(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E6D")]
    [Address(RVA = "0x32F9D60", Offset = "0x32F9D60", VA = "0x32F9D60")]
    public IEnumerator Reloadcommon_sale(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E6E")]
    [Address(RVA = "0x32F9DD4", Offset = "0x32F9DD4", VA = "0x32F9DD4")]
    public IEnumerator Reloadcommon_species(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E6F")]
    [Address(RVA = "0x32F9E48", Offset = "0x32F9E48", VA = "0x32F9E48")]
    public IEnumerator Reloadcommon_equipment_classification(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E70")]
    [Address(RVA = "0x32F9EBC", Offset = "0x32F9EBC", VA = "0x32F9EBC")]
    public IEnumerator Reloadcommon_tips_loading(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E71")]
    [Address(RVA = "0x32F9F30", Offset = "0x32F9F30", VA = "0x32F9F30")]
    public IEnumerator Reloaddeck_deck_type(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E72")]
    [Address(RVA = "0x32F9FA4", Offset = "0x32F9FA4", VA = "0x32F9FA4")]
    public IEnumerator Reloadequipment_accessories(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E73")]
    [Address(RVA = "0x32FA018", Offset = "0x32FA018", VA = "0x32FA018")]
    public IEnumerator Reloadequipment_awake(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E74")]
    [Address(RVA = "0x32FA08C", Offset = "0x32FA08C", VA = "0x32FA08C")]
    public IEnumerator Reloadequipment_accessory_option(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E75")]
    [Address(RVA = "0x32FA100", Offset = "0x32FA100", VA = "0x32FA100")]
    public IEnumerator Reloadequipment_accessory_option_change_item_recipe(Action cAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6004E76")]
    [Address(RVA = "0x32FA174", Offset = "0x32FA174", VA = "0x32FA174")]
    public IEnumerator Reloadequipment(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E77")]
    [Address(RVA = "0x32FA1E8", Offset = "0x32FA1E8", VA = "0x32FA1E8")]
    public IEnumerator Reloadequipment_accessory_option_grade_group(Action cAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6004E78")]
    [Address(RVA = "0x32FA25C", Offset = "0x32FA25C", VA = "0x32FA25C")]
    public IEnumerator Reloadequipment_accessory_option_lottery(Action cAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6004E79")]
    [Address(RVA = "0x32FA2D0", Offset = "0x32FA2D0", VA = "0x32FA2D0")]
    public IEnumerator Reloadequipment_inscription(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E7A")]
    [Address(RVA = "0x32FA344", Offset = "0x32FA344", VA = "0x32FA344")]
    public IEnumerator Reloadequipment_weapon(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E7B")]
    [Address(RVA = "0x32FA3B8", Offset = "0x32FA3B8", VA = "0x32FA3B8")]
    public IEnumerator Reloadequipment_mind_equipment(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E7C")]
    [Address(RVA = "0x32FA42C", Offset = "0x32FA42C", VA = "0x32FA42C")]
    public IEnumerator Reloadequipment_trust(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E7D")]
    [Address(RVA = "0x32FA4A0", Offset = "0x32FA4A0", VA = "0x32FA4A0")]
    public IEnumerator Reloadequipment_weapon_option(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E7E")]
    [Address(RVA = "0x32FA514", Offset = "0x32FA514", VA = "0x32FA514")]
    public IEnumerator Reloadequipment_weapon_option_change_item_recipe(Action cAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6004E7F")]
    [Address(RVA = "0x32FA588", Offset = "0x32FA588", VA = "0x32FA588")]
    public IEnumerator Reloadequipment_weapon_option_grade_group(Action cAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6004E80")]
    [Address(RVA = "0x32FA5FC", Offset = "0x32FA5FC", VA = "0x32FA5FC")]
    public IEnumerator Reloadequipment_weapon_option_lottery(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E81")]
    [Address(RVA = "0x32FA670", Offset = "0x32FA670", VA = "0x32FA670")]
    public IEnumerator Reloadexpedition_boss(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E82")]
    [Address(RVA = "0x32FA6E4", Offset = "0x32FA6E4", VA = "0x32FA6E4")]
    public IEnumerator Reloadexpedition_box(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E83")]
    [Address(RVA = "0x32FA758", Offset = "0x32FA758", VA = "0x32FA758")]
    public IEnumerator Reloadexpedition_party(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E84")]
    [Address(RVA = "0x32FA7CC", Offset = "0x32FA7CC", VA = "0x32FA7CC")]
    public IEnumerator Reloadexpedition_rapid(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E85")]
    [Address(RVA = "0x32FA840", Offset = "0x32FA840", VA = "0x32FA840")]
    public IEnumerator Reloadexpedition_soul(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E86")]
    [Address(RVA = "0x32FA8B4", Offset = "0x32FA8B4", VA = "0x32FA8B4")]
    public IEnumerator Reloadexpedition_stage(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E87")]
    [Address(RVA = "0x32FA928", Offset = "0x32FA928", VA = "0x32FA928")]
    public IEnumerator Reloadexpedition(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E88")]
    [Address(RVA = "0x32FA99C", Offset = "0x32FA99C", VA = "0x32FA99C")]
    public IEnumerator Reloadfriend_const(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E89")]
    [Address(RVA = "0x32FAA10", Offset = "0x32FAA10", VA = "0x32FAA10")]
    public IEnumerator Reloadguild_reward(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E8A")]
    [Address(RVA = "0x32FAA84", Offset = "0x32FAA84", VA = "0x32FAA84")]
    public IEnumerator Reloadguild_enum(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E8B")]
    [Address(RVA = "0x32FAAF8", Offset = "0x32FAAF8", VA = "0x32FAAF8")]
    public IEnumerator Reloadguild_facility(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E8C")]
    [Address(RVA = "0x32FAB6C", Offset = "0x32FAB6C", VA = "0x32FAB6C")]
    public IEnumerator Reloadguild_armoury(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E8D")]
    [Address(RVA = "0x32FABE0", Offset = "0x32FABE0", VA = "0x32FABE0")]
    public IEnumerator Reloadguild_guild_battle(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E8E")]
    [Address(RVA = "0x32FAC54", Offset = "0x32FAC54", VA = "0x32FAC54")]
    public IEnumerator Reloadguild_const(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E8F")]
    [Address(RVA = "0x32FACC8", Offset = "0x32FACC8", VA = "0x32FACC8")]
    public IEnumerator Reloadguild(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E90")]
    [Address(RVA = "0x32FAD3C", Offset = "0x32FAD3C", VA = "0x32FAD3C")]
    public IEnumerator Reloadguild_unlocked(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E91")]
    [Address(RVA = "0x32FADB0", Offset = "0x32FADB0", VA = "0x32FADB0")]
    public IEnumerator Reloadhome(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E92")]
    [Address(RVA = "0x32FAE24", Offset = "0x32FAE24", VA = "0x32FAE24")]
    public IEnumerator Reloadintrochapter(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E93")]
    [Address(RVA = "0x32FAE98", Offset = "0x32FAE98", VA = "0x32FAE98")]
    public IEnumerator Reloaditem(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E94")]
    [Address(RVA = "0x32FAF0C", Offset = "0x32FAF0C", VA = "0x32FAF0C")]
    public IEnumerator Reloadlobby_freeaction(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E95")]
    [Address(RVA = "0x32FAF80", Offset = "0x32FAF80", VA = "0x32FAF80")]
    public IEnumerator Reloadlobby(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E96")]
    [Address(RVA = "0x32FAFF4", Offset = "0x32FAFF4", VA = "0x32FAFF4")]
    public IEnumerator Reloadloginbonus(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E97")]
    [Address(RVA = "0x32FB068", Offset = "0x32FB068", VA = "0x32FB068")]
    public IEnumerator Reloadmission(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E98")]
    [Address(RVA = "0x32FB0DC", Offset = "0x32FB0DC", VA = "0x32FB0DC")]
    public IEnumerator Reloadplayer(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E99")]
    [Address(RVA = "0x32FB150", Offset = "0x32FB150", VA = "0x32FB150")]
    public IEnumerator Reloadplayer_style_master_bonus(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E9A")]
    [Address(RVA = "0x32FB1C4", Offset = "0x32FB1C4", VA = "0x32FB1C4")]
    public IEnumerator Reloadplayer_weapon_master_bonus(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E9B")]
    [Address(RVA = "0x32FB238", Offset = "0x32FB238", VA = "0x32FB238")]
    public IEnumerator Reloadprehome(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E9C")]
    [Address(RVA = "0x32FB2AC", Offset = "0x32FB2AC", VA = "0x32FB2AC")]
    public IEnumerator Reloadquest(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E9D")]
    [Address(RVA = "0x32FB320", Offset = "0x32FB320", VA = "0x32FB320")]
    public IEnumerator Reloadquest_const(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E9E")]
    [Address(RVA = "0x32FB394", Offset = "0x32FB394", VA = "0x32FB394")]
    public IEnumerator Reloadshop(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004E9F")]
    [Address(RVA = "0x32FB408", Offset = "0x32FB408", VA = "0x32FB408")]
    public IEnumerator Reloadskill(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004EA0")]
    [Address(RVA = "0x32FB47C", Offset = "0x32FB47C", VA = "0x32FB47C")]
    public IEnumerator Reloadstory_ability(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004EA1")]
    [Address(RVA = "0x32FB4F0", Offset = "0x32FB4F0", VA = "0x32FB4F0")]
    public IEnumerator Reloadstory_area(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004EA2")]
    [Address(RVA = "0x32FB564", Offset = "0x32FB564", VA = "0x32FB564")]
    public IEnumerator Reloadstory_areaeventquest(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004EA3")]
    [Address(RVA = "0x32FB5D8", Offset = "0x32FB5D8", VA = "0x32FB5D8")]
    public IEnumerator Reloadstory_character(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004EA4")]
    [Address(RVA = "0x32FB64C", Offset = "0x32FB64C", VA = "0x32FB64C")]
    public IEnumerator Reloadstory_communication(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004EA5")]
    [Address(RVA = "0x32FB6C0", Offset = "0x32FB6C0", VA = "0x32FB6C0")]
    public IEnumerator Reloadstory_condition(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004EA6")]
    [Address(RVA = "0x32FB734", Offset = "0x32FB734", VA = "0x32FB734")]
    public IEnumerator Reloadstory_facility(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004EA7")]
    [Address(RVA = "0x32FB7A8", Offset = "0x32FB7A8", VA = "0x32FB7A8")]
    public IEnumerator Reloadstory_freeaction(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004EA8")]
    [Address(RVA = "0x32FB81C", Offset = "0x32FB81C", VA = "0x32FB81C")]
    public IEnumerator Reloadstory_mainquest(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004EA9")]
    [Address(RVA = "0x32FB890", Offset = "0x32FB890", VA = "0x32FB890")]
    public IEnumerator Reloadstory(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004EAA")]
    [Address(RVA = "0x32FB904", Offset = "0x32FB904", VA = "0x32FB904")]
    public IEnumerator Reloadstory_obliviae(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004EAB")]
    [Address(RVA = "0x32FB978", Offset = "0x32FB978", VA = "0x32FB978")]
    public IEnumerator Reloadstory_subquest(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004EAC")]
    [Address(RVA = "0x32FB9EC", Offset = "0x32FB9EC", VA = "0x32FB9EC")]
    public IEnumerator Reloadtutorial(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004EAD")]
    [Address(RVA = "0x32FBA60", Offset = "0x32FBA60", VA = "0x32FBA60")]
    public IEnumerator Reloadunit_abilityboard(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004EAE")]
    [Address(RVA = "0x32FBAD4", Offset = "0x32FBAD4", VA = "0x32FBAD4")]
    public IEnumerator Reloadunit_class(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004EAF")]
    [Address(RVA = "0x32FBB48", Offset = "0x32FBB48", VA = "0x32FBB48")]
    public IEnumerator Reloadunit_character(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004EB0")]
    [Address(RVA = "0x32FBBBC", Offset = "0x32FBBBC", VA = "0x32FBBBC")]
    public IEnumerator Reloadunit_style(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004EB1")]
    [Address(RVA = "0x32FBC30", Offset = "0x32FBC30", VA = "0x32FBC30")]
    public IEnumerator Reloadunit_emblem(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004EB2")]
    [Address(RVA = "0x32FBCA4", Offset = "0x32FBCA4", VA = "0x32FBCA4")]
    public IEnumerator Reloadunit(Action cAction) => (IEnumerator) null;

    [Token(Token = "0x6004EB3")]
    [Address(RVA = "0x32FBD18", Offset = "0x32FBD18", VA = "0x32FBD18")]
    private void OnCompletedReload()
    {
    }

    [Token(Token = "0x6004EB4")]
    [Address(RVA = "0x32FBD1C", Offset = "0x32FBD1C", VA = "0x32FBD1C")]
    public MissionAchievementConditionMaster LoadMissionAchievementCondition(string path)
    {
      return (MissionAchievementConditionMaster) null;
    }

    [Token(Token = "0x6004EB5")]
    [Address(RVA = "0x32FBD74", Offset = "0x32FBD74", VA = "0x32FBD74")]
    private void LoadMissionAchievementConditionDefault()
    {
    }

    [Token(Token = "0x6004EB6")]
    [Address(RVA = "0x32FBDDC", Offset = "0x32FBDDC", VA = "0x32FBDDC")]
    public MissionConstMaster LoadMissionConst(string path) => (MissionConstMaster) null;

    [Token(Token = "0x6004EB7")]
    [Address(RVA = "0x32FBE34", Offset = "0x32FBE34", VA = "0x32FBE34")]
    private void LoadMissionConstDefault()
    {
    }

    [Token(Token = "0x6004EB8")]
    [Address(RVA = "0x32FBE9C", Offset = "0x32FBE9C", VA = "0x32FBE9C")]
    public MissionGroupMaster LoadMissionGroup(string path) => (MissionGroupMaster) null;

    [Token(Token = "0x6004EB9")]
    [Address(RVA = "0x32FBEF4", Offset = "0x32FBEF4", VA = "0x32FBEF4")]
    private void LoadMissionGroupDefault()
    {
    }

    [Token(Token = "0x6004EBA")]
    [Address(RVA = "0x32FBF5C", Offset = "0x32FBF5C", VA = "0x32FBF5C")]
    public MissionProgressRewardDescriptionMaster LoadMissionProgressRewardDescription(string path)
    {
      return (MissionProgressRewardDescriptionMaster) null;
    }

    [Token(Token = "0x6004EBB")]
    [Address(RVA = "0x32FBFB4", Offset = "0x32FBFB4", VA = "0x32FBFB4")]
    private void LoadMissionProgressRewardDescriptionDefault()
    {
    }

    [Token(Token = "0x6004EBC")]
    [Address(RVA = "0x32FC01C", Offset = "0x32FC01C", VA = "0x32FC01C")]
    public MissionProgressRewardMaster LoadMissionProgressReward(string path)
    {
      return (MissionProgressRewardMaster) null;
    }

    [Token(Token = "0x6004EBD")]
    [Address(RVA = "0x32FC074", Offset = "0x32FC074", VA = "0x32FC074")]
    private void LoadMissionProgressRewardDefault()
    {
    }

    [Token(Token = "0x6004EBE")]
    [Address(RVA = "0x32FC0DC", Offset = "0x32FC0DC", VA = "0x32FC0DC")]
    public MissionRewardMaster LoadMissionReward(string path) => (MissionRewardMaster) null;

    [Token(Token = "0x6004EBF")]
    [Address(RVA = "0x32FC134", Offset = "0x32FC134", VA = "0x32FC134")]
    private void LoadMissionRewardDefault()
    {
    }

    [Token(Token = "0x6004EC0")]
    [Address(RVA = "0x32FC19C", Offset = "0x32FC19C", VA = "0x32FC19C")]
    public MissionScheduleMaster LoadMissionSchedule(string path) => (MissionScheduleMaster) null;

    [Token(Token = "0x6004EC1")]
    [Address(RVA = "0x32FC1F4", Offset = "0x32FC1F4", VA = "0x32FC1F4")]
    private void LoadMissionScheduleDefault()
    {
    }

    [Token(Token = "0x6004EC2")]
    [Address(RVA = "0x32FC25C", Offset = "0x32FC25C", VA = "0x32FC25C")]
    public MissionMaster LoadMission(string path) => (MissionMaster) null;

    [Token(Token = "0x6004EC3")]
    [Address(RVA = "0x32FC2B4", Offset = "0x32FC2B4", VA = "0x32FC2B4")]
    private void LoadMissionDefault()
    {
    }

    [Token(Token = "0x6004EC4")]
    [Address(RVA = "0x32FC31C", Offset = "0x32FC31C", VA = "0x32FC31C")]
    public MissionUnlockDescriptionMaster LoadMissionUnlockDescription(string path)
    {
      return (MissionUnlockDescriptionMaster) null;
    }

    [Token(Token = "0x6004EC5")]
    [Address(RVA = "0x32FC374", Offset = "0x32FC374", VA = "0x32FC374")]
    private void LoadMissionUnlockDescriptionDefault()
    {
    }

    [Token(Token = "0x6004EC6")]
    [Address(RVA = "0x32FC3DC", Offset = "0x32FC3DC", VA = "0x32FC3DC")]
    public MissionUnlockMaster LoadMissionUnlock(string path) => (MissionUnlockMaster) null;

    [Token(Token = "0x6004EC7")]
    [Address(RVA = "0x32FC434", Offset = "0x32FC434", VA = "0x32FC434")]
    private void LoadMissionUnlockDefault()
    {
    }

    [Token(Token = "0x6004EC8")]
    [Address(RVA = "0x32FC49C", Offset = "0x32FC49C", VA = "0x32FC49C")]
    public PanelMissionMaster LoadPanelMission(string path) => (PanelMissionMaster) null;

    [Token(Token = "0x6004EC9")]
    [Address(RVA = "0x32FC4F4", Offset = "0x32FC4F4", VA = "0x32FC4F4")]
    private void LoadPanelMissionDefault()
    {
    }

    [Token(Token = "0x6004ECA")]
    [Address(RVA = "0x32FC55C", Offset = "0x32FC55C", VA = "0x32FC55C")]
    public TotalMissionDetailMaster LoadTotalMissionDetail(string path)
    {
      return (TotalMissionDetailMaster) null;
    }

    [Token(Token = "0x6004ECB")]
    [Address(RVA = "0x32FC5B4", Offset = "0x32FC5B4", VA = "0x32FC5B4")]
    private void LoadTotalMissionDetailDefault()
    {
    }

    [Token(Token = "0x6004ECC")]
    [Address(RVA = "0x32FC61C", Offset = "0x32FC61C", VA = "0x32FC61C")]
    public TotalMissionEventMaster LoadTotalMissionEvent(string path)
    {
      return (TotalMissionEventMaster) null;
    }

    [Token(Token = "0x6004ECD")]
    [Address(RVA = "0x32FC674", Offset = "0x32FC674", VA = "0x32FC674")]
    private void LoadTotalMissionEventDefault()
    {
    }

    [Token(Token = "0x6004ECE")]
    [Address(RVA = "0x32FC6DC", Offset = "0x32FC6DC", VA = "0x32FC6DC")]
    public TotalMissionRewardDetailMaster LoadTotalMissionRewardDetail(string path)
    {
      return (TotalMissionRewardDetailMaster) null;
    }

    [Token(Token = "0x6004ECF")]
    [Address(RVA = "0x32FC734", Offset = "0x32FC734", VA = "0x32FC734")]
    private void LoadTotalMissionRewardDetailDefault()
    {
    }

    [Token(Token = "0x6004ED0")]
    [Address(RVA = "0x32FC79C", Offset = "0x32FC79C", VA = "0x32FC79C")]
    public TotalMissionRewardMaster LoadTotalMissionReward(string path)
    {
      return (TotalMissionRewardMaster) null;
    }

    [Token(Token = "0x6004ED1")]
    [Address(RVA = "0x32FC7F4", Offset = "0x32FC7F4", VA = "0x32FC7F4")]
    private void LoadTotalMissionRewardDefault()
    {
    }

    [Token(Token = "0x6004ED2")]
    [Address(RVA = "0x32FC85C", Offset = "0x32FC85C", VA = "0x32FC85C")]
    public TotalMissionTabMaster LoadTotalMissionTab(string path) => (TotalMissionTabMaster) null;

    [Token(Token = "0x6004ED3")]
    [Address(RVA = "0x32FC8B4", Offset = "0x32FC8B4", VA = "0x32FC8B4")]
    private void LoadTotalMissionTabDefault()
    {
    }

    [Token(Token = "0x6004ED4")]
    [Address(RVA = "0x32FC91C", Offset = "0x32FC91C", VA = "0x32FC91C")]
    public ApPaymentMaster LoadApPayment(string path) => (ApPaymentMaster) null;

    [Token(Token = "0x6004ED5")]
    [Address(RVA = "0x32FC974", Offset = "0x32FC974", VA = "0x32FC974")]
    private void LoadApPaymentDefault()
    {
    }

    [Token(Token = "0x6004ED6")]
    [Address(RVA = "0x32FC9DC", Offset = "0x32FC9DC", VA = "0x32FC9DC")]
    public PlayerApMaster LoadPlayerAp(string path) => (PlayerApMaster) null;

    [Token(Token = "0x6004ED7")]
    [Address(RVA = "0x32FCA34", Offset = "0x32FCA34", VA = "0x32FCA34")]
    private void LoadPlayerApDefault()
    {
    }

    [Token(Token = "0x6004ED8")]
    [Address(RVA = "0x32FCA9C", Offset = "0x32FCA9C", VA = "0x32FCA9C")]
    public PlayerAvatarMaster LoadPlayerAvatar(string path) => (PlayerAvatarMaster) null;

    [Token(Token = "0x6004ED9")]
    [Address(RVA = "0x32FCAF4", Offset = "0x32FCAF4", VA = "0x32FCAF4")]
    private void LoadPlayerAvatarDefault()
    {
    }

    [Token(Token = "0x6004EDA")]
    [Address(RVA = "0x32FCB5C", Offset = "0x32FCB5C", VA = "0x32FCB5C")]
    public PlayerConstMaster LoadPlayerConst(string path) => (PlayerConstMaster) null;

    [Token(Token = "0x6004EDB")]
    [Address(RVA = "0x32FCBB4", Offset = "0x32FCBB4", VA = "0x32FCBB4")]
    private void LoadPlayerConstDefault()
    {
    }

    [Token(Token = "0x6004EDC")]
    [Address(RVA = "0x32FCC1C", Offset = "0x32FCC1C", VA = "0x32FCC1C")]
    public PlayerExpMaster LoadPlayerExp(string path) => (PlayerExpMaster) null;

    [Token(Token = "0x6004EDD")]
    [Address(RVA = "0x32FCC74", Offset = "0x32FCC74", VA = "0x32FCC74")]
    private void LoadPlayerExpDefault()
    {
    }

    [Token(Token = "0x6004EDE")]
    [Address(RVA = "0x32FCCDC", Offset = "0x32FCCDC", VA = "0x32FCCDC")]
    public PlayerTitleMaster LoadPlayerTitle(string path) => (PlayerTitleMaster) null;

    [Token(Token = "0x6004EDF")]
    [Address(RVA = "0x32FCD34", Offset = "0x32FCD34", VA = "0x32FCD34")]
    private void LoadPlayerTitleDefault()
    {
    }

    [Token(Token = "0x6004EE0")]
    [Address(RVA = "0x32FCD9C", Offset = "0x32FCD9C", VA = "0x32FCD9C")]
    public RewardPassMaster LoadRewardPass(string path) => (RewardPassMaster) null;

    [Token(Token = "0x6004EE1")]
    [Address(RVA = "0x32FCDF4", Offset = "0x32FCDF4", VA = "0x32FCDF4")]
    private void LoadRewardPassDefault()
    {
    }

    [Token(Token = "0x6004EE2")]
    [Address(RVA = "0x32FCE5C", Offset = "0x32FCE5C", VA = "0x32FCE5C")]
    public StyleMasterBonusConditionMaster LoadStyleMasterBonusCondition(string path)
    {
      return (StyleMasterBonusConditionMaster) null;
    }

    [Token(Token = "0x6004EE3")]
    [Address(RVA = "0x32FCEB4", Offset = "0x32FCEB4", VA = "0x32FCEB4")]
    private void LoadStyleMasterBonusConditionDefault()
    {
    }

    [Token(Token = "0x6004EE4")]
    [Address(RVA = "0x32FCF1C", Offset = "0x32FCF1C", VA = "0x32FCF1C")]
    public StyleMasterBonusDescriptionMaster LoadStyleMasterBonusDescription(string path)
    {
      return (StyleMasterBonusDescriptionMaster) null;
    }

    [Token(Token = "0x6004EE5")]
    [Address(RVA = "0x32FCF74", Offset = "0x32FCF74", VA = "0x32FCF74")]
    private void LoadStyleMasterBonusDescriptionDefault()
    {
    }

    [Token(Token = "0x6004EE6")]
    [Address(RVA = "0x32FCFDC", Offset = "0x32FCFDC", VA = "0x32FCFDC")]
    public StyleMasterBonusExpDescriptionMaster LoadStyleMasterBonusExpDescription(string path)
    {
      return (StyleMasterBonusExpDescriptionMaster) null;
    }

    [Token(Token = "0x6004EE7")]
    [Address(RVA = "0x32FD034", Offset = "0x32FD034", VA = "0x32FD034")]
    private void LoadStyleMasterBonusExpDescriptionDefault()
    {
    }

    [Token(Token = "0x6004EE8")]
    [Address(RVA = "0x32FD09C", Offset = "0x32FD09C", VA = "0x32FD09C")]
    public StyleMasterBonusMaster LoadStyleMasterBonus(string path)
    {
      return (StyleMasterBonusMaster) null;
    }

    [Token(Token = "0x6004EE9")]
    [Address(RVA = "0x32FD0F4", Offset = "0x32FD0F4", VA = "0x32FD0F4")]
    private void LoadStyleMasterBonusDefault()
    {
    }

    [Token(Token = "0x6004EEA")]
    [Address(RVA = "0x32FD15C", Offset = "0x32FD15C", VA = "0x32FD15C")]
    public WeaponMasterBonusDescriptionMaster LoadWeaponMasterBonusDescription(string path)
    {
      return (WeaponMasterBonusDescriptionMaster) null;
    }

    [Token(Token = "0x6004EEB")]
    [Address(RVA = "0x32FD1B4", Offset = "0x32FD1B4", VA = "0x32FD1B4")]
    private void LoadWeaponMasterBonusDescriptionDefault()
    {
    }

    [Token(Token = "0x6004EEC")]
    [Address(RVA = "0x32FD21C", Offset = "0x32FD21C", VA = "0x32FD21C")]
    public WeaponMasterBonusExpMaster LoadWeaponMasterBonusExp(string path)
    {
      return (WeaponMasterBonusExpMaster) null;
    }

    [Token(Token = "0x6004EED")]
    [Address(RVA = "0x32FD274", Offset = "0x32FD274", VA = "0x32FD274")]
    private void LoadWeaponMasterBonusExpDefault()
    {
    }

    [Token(Token = "0x6004EEE")]
    [Address(RVA = "0x32FD2DC", Offset = "0x32FD2DC", VA = "0x32FD2DC")]
    public WeaponMasterBonusGainExpMaster LoadWeaponMasterBonusGainExp(string path)
    {
      return (WeaponMasterBonusGainExpMaster) null;
    }

    [Token(Token = "0x6004EEF")]
    [Address(RVA = "0x32FD334", Offset = "0x32FD334", VA = "0x32FD334")]
    private void LoadWeaponMasterBonusGainExpDefault()
    {
    }

    [Token(Token = "0x6004EF0")]
    [Address(RVA = "0x32FD39C", Offset = "0x32FD39C", VA = "0x32FD39C")]
    public WeaponMasterBonusMaster LoadWeaponMasterBonus(string path)
    {
      return (WeaponMasterBonusMaster) null;
    }

    [Token(Token = "0x6004EF1")]
    [Address(RVA = "0x32FD3F4", Offset = "0x32FD3F4", VA = "0x32FD3F4")]
    private void LoadWeaponMasterBonusDefault()
    {
    }

    [Token(Token = "0x6004EF2")]
    [Address(RVA = "0x32FD45C", Offset = "0x32FD45C", VA = "0x32FD45C")]
    public PreHomeEventAdvContentMaster LoadPreHomeEventAdvContent(string path)
    {
      return (PreHomeEventAdvContentMaster) null;
    }

    [Token(Token = "0x6004EF3")]
    [Address(RVA = "0x32FD4B4", Offset = "0x32FD4B4", VA = "0x32FD4B4")]
    private void LoadPreHomeEventAdvContentDefault()
    {
    }

    [Token(Token = "0x6004EF4")]
    [Address(RVA = "0x32FD51C", Offset = "0x32FD51C", VA = "0x32FD51C")]
    public PreHomeEventMaster LoadPreHomeEvent(string path) => (PreHomeEventMaster) null;

    [Token(Token = "0x6004EF5")]
    [Address(RVA = "0x32FD574", Offset = "0x32FD574", VA = "0x32FD574")]
    private void LoadPreHomeEventDefault()
    {
    }

    [Token(Token = "0x6004EF6")]
    [Address(RVA = "0x32FD5DC", Offset = "0x32FD5DC", VA = "0x32FD5DC")]
    public AreaQuestAreaGroupReleaseConditionDescriptionMaster LoadAreaQuestAreaGroupReleaseConditionDescription(
      string path)
    {
      return (AreaQuestAreaGroupReleaseConditionDescriptionMaster) null;
    }

    [Token(Token = "0x6004EF7")]
    [Address(RVA = "0x32FD634", Offset = "0x32FD634", VA = "0x32FD634")]
    private void LoadAreaQuestAreaGroupReleaseConditionDescriptionDefault()
    {
    }

    [Token(Token = "0x6004EF8")]
    [Address(RVA = "0x32FD69C", Offset = "0x32FD69C", VA = "0x32FD69C")]
    public AreaQuestAreaGroupMaster LoadAreaQuestAreaGroup(string path)
    {
      return (AreaQuestAreaGroupMaster) null;
    }

    [Token(Token = "0x6004EF9")]
    [Address(RVA = "0x32FD6F4", Offset = "0x32FD6F4", VA = "0x32FD6F4")]
    private void LoadAreaQuestAreaGroupDefault()
    {
    }

    [Token(Token = "0x6004EFA")]
    [Address(RVA = "0x32FD75C", Offset = "0x32FD75C", VA = "0x32FD75C")]
    public AreaQuestAreaNodeNormalDescriptionMaster LoadAreaQuestAreaNodeNormalDescription(
      string path)
    {
      return (AreaQuestAreaNodeNormalDescriptionMaster) null;
    }

    [Token(Token = "0x6004EFB")]
    [Address(RVA = "0x32FD7B4", Offset = "0x32FD7B4", VA = "0x32FD7B4")]
    private void LoadAreaQuestAreaNodeNormalDescriptionDefault()
    {
    }

    [Token(Token = "0x6004EFC")]
    [Address(RVA = "0x32FD81C", Offset = "0x32FD81C", VA = "0x32FD81C")]
    public AreaQuestAreaNodeQuestMaster LoadAreaQuestAreaNodeQuest(string path)
    {
      return (AreaQuestAreaNodeQuestMaster) null;
    }

    [Token(Token = "0x6004EFD")]
    [Address(RVA = "0x32FD874", Offset = "0x32FD874", VA = "0x32FD874")]
    private void LoadAreaQuestAreaNodeQuestDefault()
    {
    }

    [Token(Token = "0x6004EFE")]
    [Address(RVA = "0x32FD8DC", Offset = "0x32FD8DC", VA = "0x32FD8DC")]
    public AreaQuestAreaNodeReleaseConditionDescriptionMaster LoadAreaQuestAreaNodeReleaseConditionDescription(
      string path)
    {
      return (AreaQuestAreaNodeReleaseConditionDescriptionMaster) null;
    }

    [Token(Token = "0x6004EFF")]
    [Address(RVA = "0x32FD934", Offset = "0x32FD934", VA = "0x32FD934")]
    private void LoadAreaQuestAreaNodeReleaseConditionDescriptionDefault()
    {
    }

    [Token(Token = "0x6004F00")]
    [Address(RVA = "0x32FD99C", Offset = "0x32FD99C", VA = "0x32FD99C")]
    public AreaQuestAreaNodeShortcutMaster LoadAreaQuestAreaNodeShortcut(string path)
    {
      return (AreaQuestAreaNodeShortcutMaster) null;
    }

    [Token(Token = "0x6004F01")]
    [Address(RVA = "0x32FD9F4", Offset = "0x32FD9F4", VA = "0x32FD9F4")]
    private void LoadAreaQuestAreaNodeShortcutDefault()
    {
    }

    [Token(Token = "0x6004F02")]
    [Address(RVA = "0x32FDA5C", Offset = "0x32FDA5C", VA = "0x32FDA5C")]
    public AreaQuestAreaNodeMaster LoadAreaQuestAreaNode(string path)
    {
      return (AreaQuestAreaNodeMaster) null;
    }

    [Token(Token = "0x6004F03")]
    [Address(RVA = "0x32FDAB4", Offset = "0x32FDAB4", VA = "0x32FDAB4")]
    private void LoadAreaQuestAreaNodeDefault()
    {
    }

    [Token(Token = "0x6004F04")]
    [Address(RVA = "0x32FDB1C", Offset = "0x32FDB1C", VA = "0x32FDB1C")]
    public AreaQuestAreaReleaseConditionDescriptionMaster LoadAreaQuestAreaReleaseConditionDescription(
      string path)
    {
      return (AreaQuestAreaReleaseConditionDescriptionMaster) null;
    }

    [Token(Token = "0x6004F05")]
    [Address(RVA = "0x32FDB74", Offset = "0x32FDB74", VA = "0x32FDB74")]
    private void LoadAreaQuestAreaReleaseConditionDescriptionDefault()
    {
    }

    [Token(Token = "0x6004F06")]
    [Address(RVA = "0x32FDBDC", Offset = "0x32FDBDC", VA = "0x32FDBDC")]
    public AreaQuestAreaReleaseConditionMaster LoadAreaQuestAreaReleaseCondition(string path)
    {
      return (AreaQuestAreaReleaseConditionMaster) null;
    }

    [Token(Token = "0x6004F07")]
    [Address(RVA = "0x32FDC34", Offset = "0x32FDC34", VA = "0x32FDC34")]
    private void LoadAreaQuestAreaReleaseConditionDefault()
    {
    }

    [Token(Token = "0x6004F08")]
    [Address(RVA = "0x32FDC9C", Offset = "0x32FDC9C", VA = "0x32FDC9C")]
    public AreaQuestAreaMaster LoadAreaQuestArea(string path) => (AreaQuestAreaMaster) null;

    [Token(Token = "0x6004F09")]
    [Address(RVA = "0x32FDCF4", Offset = "0x32FDCF4", VA = "0x32FDCF4")]
    private void LoadAreaQuestAreaDefault()
    {
    }

    [Token(Token = "0x6004F0A")]
    [Address(RVA = "0x32FDD5C", Offset = "0x32FDD5C", VA = "0x32FDD5C")]
    public AreaQuestEventPageMaster LoadAreaQuestEventPage(string path)
    {
      return (AreaQuestEventPageMaster) null;
    }

    [Token(Token = "0x6004F0B")]
    [Address(RVA = "0x32FDDB4", Offset = "0x32FDDB4", VA = "0x32FDDB4")]
    private void LoadAreaQuestEventPageDefault()
    {
    }

    [Token(Token = "0x6004F0C")]
    [Address(RVA = "0x32FDE1C", Offset = "0x32FDE1C", VA = "0x32FDE1C")]
    public ClearTurnScoreMaster LoadClearTurnScore(string path) => (ClearTurnScoreMaster) null;

    [Token(Token = "0x6004F0D")]
    [Address(RVA = "0x32FDE74", Offset = "0x32FDE74", VA = "0x32FDE74")]
    private void LoadClearTurnScoreDefault()
    {
    }

    [Token(Token = "0x6004F0E")]
    [Address(RVA = "0x32FDEDC", Offset = "0x32FDEDC", VA = "0x32FDEDC")]
    public ScoreAttackRewardGroupMaster LoadScoreAttackRewardGroup(string path)
    {
      return (ScoreAttackRewardGroupMaster) null;
    }

    [Token(Token = "0x6004F0F")]
    [Address(RVA = "0x32FDF34", Offset = "0x32FDF34", VA = "0x32FDF34")]
    private void LoadScoreAttackRewardGroupDefault()
    {
    }

    [Token(Token = "0x6004F10")]
    [Address(RVA = "0x32FDF9C", Offset = "0x32FDF9C", VA = "0x32FDF9C")]
    public DifficultyScoreMaster LoadDifficultyScore(string path) => (DifficultyScoreMaster) null;

    [Token(Token = "0x6004F11")]
    [Address(RVA = "0x32FDFF4", Offset = "0x32FDFF4", VA = "0x32FDFF4")]
    private void LoadDifficultyScoreDefault()
    {
    }

    [Token(Token = "0x6004F12")]
    [Address(RVA = "0x32FE05C", Offset = "0x32FE05C", VA = "0x32FE05C")]
    public DifficultyMaster LoadDifficulty(string path) => (DifficultyMaster) null;

    [Token(Token = "0x6004F13")]
    [Address(RVA = "0x32FE0B4", Offset = "0x32FE0B4", VA = "0x32FE0B4")]
    private void LoadDifficultyDefault()
    {
    }

    [Token(Token = "0x6004F14")]
    [Address(RVA = "0x32FE11C", Offset = "0x32FE11C", VA = "0x32FE11C")]
    public EventMissionCharacterMaster LoadEventMissionCharacter(string path)
    {
      return (EventMissionCharacterMaster) null;
    }

    [Token(Token = "0x6004F15")]
    [Address(RVA = "0x32FE174", Offset = "0x32FE174", VA = "0x32FE174")]
    private void LoadEventMissionCharacterDefault()
    {
    }

    [Token(Token = "0x6004F16")]
    [Address(RVA = "0x32FE1DC", Offset = "0x32FE1DC", VA = "0x32FE1DC")]
    public EventQuestScheduleMaster LoadEventQuestSchedule(string path)
    {
      return (EventQuestScheduleMaster) null;
    }

    [Token(Token = "0x6004F17")]
    [Address(RVA = "0x32FE234", Offset = "0x32FE234", VA = "0x32FE234")]
    private void LoadEventQuestScheduleDefault()
    {
    }

    [Token(Token = "0x6004F18")]
    [Address(RVA = "0x32FE29C", Offset = "0x32FE29C", VA = "0x32FE29C")]
    public FreeQuestScheduleMaster LoadFreeQuestSchedule(string path)
    {
      return (FreeQuestScheduleMaster) null;
    }

    [Token(Token = "0x6004F19")]
    [Address(RVA = "0x32FE2F4", Offset = "0x32FE2F4", VA = "0x32FE2F4")]
    private void LoadFreeQuestScheduleDefault()
    {
    }

    [Token(Token = "0x6004F1A")]
    [Address(RVA = "0x32FE35C", Offset = "0x32FE35C", VA = "0x32FE35C")]
    public GuildRaidStageMaster LoadGuildRaidStage(string path) => (GuildRaidStageMaster) null;

    [Token(Token = "0x6004F1B")]
    [Address(RVA = "0x32FE3B4", Offset = "0x32FE3B4", VA = "0x32FE3B4")]
    private void LoadGuildRaidStageDefault()
    {
    }

    [Token(Token = "0x6004F1C")]
    [Address(RVA = "0x32FE41C", Offset = "0x32FE41C", VA = "0x32FE41C")]
    public KilledSpecifiedUnitScoreMaster LoadKilledSpecifiedUnitScore(string path)
    {
      return (KilledSpecifiedUnitScoreMaster) null;
    }

    [Token(Token = "0x6004F1D")]
    [Address(RVA = "0x32FE474", Offset = "0x32FE474", VA = "0x32FE474")]
    private void LoadKilledSpecifiedUnitScoreDefault()
    {
    }

    [Token(Token = "0x6004F1E")]
    [Address(RVA = "0x32FE4DC", Offset = "0x32FE4DC", VA = "0x32FE4DC")]
    public LimitedEventQuestStageMaster LoadLimitedEventQuestStage(string path)
    {
      return (LimitedEventQuestStageMaster) null;
    }

    [Token(Token = "0x6004F1F")]
    [Address(RVA = "0x32FE534", Offset = "0x32FE534", VA = "0x32FE534")]
    private void LoadLimitedEventQuestStageDefault()
    {
    }

    [Token(Token = "0x6004F20")]
    [Address(RVA = "0x32FE59C", Offset = "0x32FE59C", VA = "0x32FE59C")]
    public LimitedEventMaster LoadLimitedEvent(string path) => (LimitedEventMaster) null;

    [Token(Token = "0x6004F21")]
    [Address(RVA = "0x32FE5F4", Offset = "0x32FE5F4", VA = "0x32FE5F4")]
    private void LoadLimitedEventDefault()
    {
    }

    [Token(Token = "0x6004F22")]
    [Address(RVA = "0x32FE65C", Offset = "0x32FE65C", VA = "0x32FE65C")]
    public QuestCorrectionMaster LoadQuestCorrection(string path) => (QuestCorrectionMaster) null;

    [Token(Token = "0x6004F23")]
    [Address(RVA = "0x32FE6B4", Offset = "0x32FE6B4", VA = "0x32FE6B4")]
    private void LoadQuestCorrectionDefault()
    {
    }

    [Token(Token = "0x6004F24")]
    [Address(RVA = "0x32FE71C", Offset = "0x32FE71C", VA = "0x32FE71C")]
    public QuestMapPositionMaster LoadQuestMapPosition(string path)
    {
      return (QuestMapPositionMaster) null;
    }

    [Token(Token = "0x6004F25")]
    [Address(RVA = "0x32FE774", Offset = "0x32FE774", VA = "0x32FE774")]
    private void LoadQuestMapPositionDefault()
    {
    }

    [Token(Token = "0x6004F26")]
    [Address(RVA = "0x32FE7DC", Offset = "0x32FE7DC", VA = "0x32FE7DC")]
    public QuestStageMaster LoadQuestStage(string path) => (QuestStageMaster) null;

    [Token(Token = "0x6004F27")]
    [Address(RVA = "0x32FE834", Offset = "0x32FE834", VA = "0x32FE834")]
    private void LoadQuestStageDefault()
    {
    }

    [Token(Token = "0x6004F28")]
    [Address(RVA = "0x32FE89C", Offset = "0x32FE89C", VA = "0x32FE89C")]
    public RaidQuestMaster LoadRaidQuest(string path) => (RaidQuestMaster) null;

    [Token(Token = "0x6004F29")]
    [Address(RVA = "0x32FE8F4", Offset = "0x32FE8F4", VA = "0x32FE8F4")]
    private void LoadRaidQuestDefault()
    {
    }

    [Token(Token = "0x6004F2A")]
    [Address(RVA = "0x32FE95C", Offset = "0x32FE95C", VA = "0x32FE95C")]
    public ScenarioQuestScheduleMaster LoadScenarioQuestSchedule(string path)
    {
      return (ScenarioQuestScheduleMaster) null;
    }

    [Token(Token = "0x6004F2B")]
    [Address(RVA = "0x32FE9B4", Offset = "0x32FE9B4", VA = "0x32FE9B4")]
    private void LoadScenarioQuestScheduleDefault()
    {
    }

    [Token(Token = "0x6004F2C")]
    [Address(RVA = "0x32FEA1C", Offset = "0x32FEA1C", VA = "0x32FEA1C")]
    public ScoreAttackDetailMaster LoadScoreAttackDetail(string path)
    {
      return (ScoreAttackDetailMaster) null;
    }

    [Token(Token = "0x6004F2D")]
    [Address(RVA = "0x32FEA74", Offset = "0x32FEA74", VA = "0x32FEA74")]
    private void LoadScoreAttackDetailDefault()
    {
    }

    [Token(Token = "0x6004F2E")]
    [Address(RVA = "0x32FEADC", Offset = "0x32FEADC", VA = "0x32FEADC")]
    public ScoreAttackEventMaster LoadScoreAttackEvent(string path)
    {
      return (ScoreAttackEventMaster) null;
    }

    [Token(Token = "0x6004F2F")]
    [Address(RVA = "0x32FEB34", Offset = "0x32FEB34", VA = "0x32FEB34")]
    private void LoadScoreAttackEventDefault()
    {
    }

    [Token(Token = "0x6004F30")]
    [Address(RVA = "0x32FEB9C", Offset = "0x32FEB9C", VA = "0x32FEB9C")]
    public ScoreAttackQuestMaster LoadScoreAttackQuest(string path)
    {
      return (ScoreAttackQuestMaster) null;
    }

    [Token(Token = "0x6004F31")]
    [Address(RVA = "0x32FEBF4", Offset = "0x32FEBF4", VA = "0x32FEBF4")]
    private void LoadScoreAttackQuestDefault()
    {
    }

    [Token(Token = "0x6004F32")]
    [Address(RVA = "0x32FEC5C", Offset = "0x32FEC5C", VA = "0x32FEC5C")]
    public ScoreAttackRankingRewardSetMaster LoadScoreAttackRankingRewardSet(string path)
    {
      return (ScoreAttackRankingRewardSetMaster) null;
    }

    [Token(Token = "0x6004F33")]
    [Address(RVA = "0x32FECB4", Offset = "0x32FECB4", VA = "0x32FECB4")]
    private void LoadScoreAttackRankingRewardSetDefault()
    {
    }

    [Token(Token = "0x6004F34")]
    [Address(RVA = "0x32FED1C", Offset = "0x32FED1C", VA = "0x32FED1C")]
    public ScoreAttackRankingRewardMaster LoadScoreAttackRankingReward(string path)
    {
      return (ScoreAttackRankingRewardMaster) null;
    }

    [Token(Token = "0x6004F35")]
    [Address(RVA = "0x32FED74", Offset = "0x32FED74", VA = "0x32FED74")]
    private void LoadScoreAttackRankingRewardDefault()
    {
    }

    [Token(Token = "0x6004F36")]
    [Address(RVA = "0x32FEDDC", Offset = "0x32FEDDC", VA = "0x32FEDDC")]
    public ScoreAttackScoreRewardSetMaster LoadScoreAttackScoreRewardSet(string path)
    {
      return (ScoreAttackScoreRewardSetMaster) null;
    }

    [Token(Token = "0x6004F37")]
    [Address(RVA = "0x32FEE34", Offset = "0x32FEE34", VA = "0x32FEE34")]
    private void LoadScoreAttackScoreRewardSetDefault()
    {
    }

    [Token(Token = "0x6004F38")]
    [Address(RVA = "0x32FEE9C", Offset = "0x32FEE9C", VA = "0x32FEE9C")]
    public ScoreAttackScoreRewardMaster LoadScoreAttackScoreReward(string path)
    {
      return (ScoreAttackScoreRewardMaster) null;
    }

    [Token(Token = "0x6004F39")]
    [Address(RVA = "0x32FEEF4", Offset = "0x32FEEF4", VA = "0x32FEEF4")]
    private void LoadScoreAttackScoreRewardDefault()
    {
    }

    [Token(Token = "0x6004F3A")]
    [Address(RVA = "0x32FEF5C", Offset = "0x32FEF5C", VA = "0x32FEF5C")]
    public SpecialPeriodMaster LoadSpecialPeriod(string path) => (SpecialPeriodMaster) null;

    [Token(Token = "0x6004F3B")]
    [Address(RVA = "0x32FEFB4", Offset = "0x32FEFB4", VA = "0x32FEFB4")]
    private void LoadSpecialPeriodDefault()
    {
    }

    [Token(Token = "0x6004F3C")]
    [Address(RVA = "0x32FF01C", Offset = "0x32FF01C", VA = "0x32FF01C")]
    public SpecialQuestStageMaster LoadSpecialQuestStage(string path)
    {
      return (SpecialQuestStageMaster) null;
    }

    [Token(Token = "0x6004F3D")]
    [Address(RVA = "0x32FF074", Offset = "0x32FF074", VA = "0x32FF074")]
    private void LoadSpecialQuestStageDefault()
    {
    }

    [Token(Token = "0x6004F3E")]
    [Address(RVA = "0x32FF0DC", Offset = "0x32FF0DC", VA = "0x32FF0DC")]
    public SpecialQuestMaster LoadSpecialQuest(string path) => (SpecialQuestMaster) null;

    [Token(Token = "0x6004F3F")]
    [Address(RVA = "0x32FF134", Offset = "0x32FF134", VA = "0x32FF134")]
    private void LoadSpecialQuestDefault()
    {
    }

    [Token(Token = "0x6004F40")]
    [Address(RVA = "0x32FF19C", Offset = "0x32FF19C", VA = "0x32FF19C")]
    public StageLevelMaster LoadStageLevel(string path) => (StageLevelMaster) null;

    [Token(Token = "0x6004F41")]
    [Address(RVA = "0x32FF1F4", Offset = "0x32FF1F4", VA = "0x32FF1F4")]
    private void LoadStageLevelDefault()
    {
    }

    [Token(Token = "0x6004F42")]
    [Address(RVA = "0x32FF25C", Offset = "0x32FF25C", VA = "0x32FF25C")]
    public StoryFreeQuestMaster LoadStoryFreeQuest(string path) => (StoryFreeQuestMaster) null;

    [Token(Token = "0x6004F43")]
    [Address(RVA = "0x32FF2B4", Offset = "0x32FF2B4", VA = "0x32FF2B4")]
    private void LoadStoryFreeQuestDefault()
    {
    }

    [Token(Token = "0x6004F44")]
    [Address(RVA = "0x32FF31C", Offset = "0x32FF31C", VA = "0x32FF31C")]
    public StoryMainHardSelectConditionDescriptionMaster LoadStoryMainHardSelectConditionDescription(
      string path)
    {
      return (StoryMainHardSelectConditionDescriptionMaster) null;
    }

    [Token(Token = "0x6004F45")]
    [Address(RVA = "0x32FF374", Offset = "0x32FF374", VA = "0x32FF374")]
    private void LoadStoryMainHardSelectConditionDescriptionDefault()
    {
    }

    [Token(Token = "0x6004F46")]
    [Address(RVA = "0x32FF3DC", Offset = "0x32FF3DC", VA = "0x32FF3DC")]
    public StoryMainQuestMaster LoadStoryMainQuest(string path) => (StoryMainQuestMaster) null;

    [Token(Token = "0x6004F47")]
    [Address(RVA = "0x32FF434", Offset = "0x32FF434", VA = "0x32FF434")]
    private void LoadStoryMainQuestDefault()
    {
    }

    [Token(Token = "0x6004F48")]
    [Address(RVA = "0x32FF49C", Offset = "0x32FF49C", VA = "0x32FF49C")]
    public StoryObliviaeQuestMaster LoadStoryObliviaeQuest(string path)
    {
      return (StoryObliviaeQuestMaster) null;
    }

    [Token(Token = "0x6004F49")]
    [Address(RVA = "0x32FF4F4", Offset = "0x32FF4F4", VA = "0x32FF4F4")]
    private void LoadStoryObliviaeQuestDefault()
    {
    }

    [Token(Token = "0x6004F4A")]
    [Address(RVA = "0x32FF55C", Offset = "0x32FF55C", VA = "0x32FF55C")]
    public StoryScenarioQuestFreeMaster LoadStoryScenarioQuestFree(string path)
    {
      return (StoryScenarioQuestFreeMaster) null;
    }

    [Token(Token = "0x6004F4B")]
    [Address(RVA = "0x32FF5B4", Offset = "0x32FF5B4", VA = "0x32FF5B4")]
    private void LoadStoryScenarioQuestFreeDefault()
    {
    }

    [Token(Token = "0x6004F4C")]
    [Address(RVA = "0x32FF61C", Offset = "0x32FF61C", VA = "0x32FF61C")]
    public StoryScenarioQuestMainMaster LoadStoryScenarioQuestMain(string path)
    {
      return (StoryScenarioQuestMainMaster) null;
    }

    [Token(Token = "0x6004F4D")]
    [Address(RVA = "0x32FF674", Offset = "0x32FF674", VA = "0x32FF674")]
    private void LoadStoryScenarioQuestMainDefault()
    {
    }

    [Token(Token = "0x6004F4E")]
    [Address(RVA = "0x32FF6DC", Offset = "0x32FF6DC", VA = "0x32FF6DC")]
    public StoryScenarioQuestSubMaster LoadStoryScenarioQuestSub(string path)
    {
      return (StoryScenarioQuestSubMaster) null;
    }

    [Token(Token = "0x6004F4F")]
    [Address(RVA = "0x32FF734", Offset = "0x32FF734", VA = "0x32FF734")]
    private void LoadStoryScenarioQuestSubDefault()
    {
    }

    [Token(Token = "0x6004F50")]
    [Address(RVA = "0x32FF79C", Offset = "0x32FF79C", VA = "0x32FF79C")]
    public StorySubQuestMaster LoadStorySubQuest(string path) => (StorySubQuestMaster) null;

    [Token(Token = "0x6004F51")]
    [Address(RVA = "0x32FF7F4", Offset = "0x32FF7F4", VA = "0x32FF7F4")]
    private void LoadStorySubQuestDefault()
    {
    }

    [Token(Token = "0x6004F52")]
    [Address(RVA = "0x32FF85C", Offset = "0x32FF85C", VA = "0x32FF85C")]
    public UseItemScoreMaster LoadUseItemScore(string path) => (UseItemScoreMaster) null;

    [Token(Token = "0x6004F53")]
    [Address(RVA = "0x32FF8B4", Offset = "0x32FF8B4", VA = "0x32FF8B4")]
    private void LoadUseItemScoreDefault()
    {
    }

    [Token(Token = "0x6004F54")]
    [Address(RVA = "0x32FF91C", Offset = "0x32FF91C", VA = "0x32FF91C")]
    public MedalTradeItemMaster LoadMedalTradeItem(string path) => (MedalTradeItemMaster) null;

    [Token(Token = "0x6004F55")]
    [Address(RVA = "0x32FF974", Offset = "0x32FF974", VA = "0x32FF974")]
    private void LoadMedalTradeItemDefault()
    {
    }

    [Token(Token = "0x6004F56")]
    [Address(RVA = "0x32FF9DC", Offset = "0x32FF9DC", VA = "0x32FF9DC")]
    public MedalTradePrizeResetMaster LoadMedalTradePrizeReset(string path)
    {
      return (MedalTradePrizeResetMaster) null;
    }

    [Token(Token = "0x6004F57")]
    [Address(RVA = "0x32FFA34", Offset = "0x32FFA34", VA = "0x32FFA34")]
    private void LoadMedalTradePrizeResetDefault()
    {
    }

    [Token(Token = "0x6004F58")]
    [Address(RVA = "0x32FFA9C", Offset = "0x32FFA9C", VA = "0x32FFA9C")]
    public MedalTradePrizeMaster LoadMedalTradePrize(string path) => (MedalTradePrizeMaster) null;

    [Token(Token = "0x6004F59")]
    [Address(RVA = "0x32FFAF4", Offset = "0x32FFAF4", VA = "0x32FFAF4")]
    private void LoadMedalTradePrizeDefault()
    {
    }

    [Token(Token = "0x6004F5A")]
    [Address(RVA = "0x32FFB5C", Offset = "0x32FFB5C", VA = "0x32FFB5C")]
    public MedalTradeShopMaster LoadMedalTradeShop(string path) => (MedalTradeShopMaster) null;

    [Token(Token = "0x6004F5B")]
    [Address(RVA = "0x32FFBB4", Offset = "0x32FFBB4", VA = "0x32FFBB4")]
    private void LoadMedalTradeShopDefault()
    {
    }

    [Token(Token = "0x6004F5C")]
    [Address(RVA = "0x32FFC1C", Offset = "0x32FFC1C", VA = "0x32FFC1C")]
    public MedalTradeUsableMedalListMaster LoadMedalTradeUsableMedalList(string path)
    {
      return (MedalTradeUsableMedalListMaster) null;
    }

    [Token(Token = "0x6004F5D")]
    [Address(RVA = "0x32FFC74", Offset = "0x32FFC74", VA = "0x32FFC74")]
    private void LoadMedalTradeUsableMedalListDefault()
    {
    }

    [Token(Token = "0x6004F5E")]
    [Address(RVA = "0x32FFCDC", Offset = "0x32FFCDC", VA = "0x32FFCDC")]
    public ShopConstMaster LoadShopConst(string path) => (ShopConstMaster) null;

    [Token(Token = "0x6004F5F")]
    [Address(RVA = "0x32FFD34", Offset = "0x32FFD34", VA = "0x32FFD34")]
    private void LoadShopConstDefault()
    {
    }

    [Token(Token = "0x6004F60")]
    [Address(RVA = "0x32FFD9C", Offset = "0x32FFD9C", VA = "0x32FFD9C")]
    public ShopLayoutMaster LoadShopLayout(string path) => (ShopLayoutMaster) null;

    [Token(Token = "0x6004F61")]
    [Address(RVA = "0x32FFDF4", Offset = "0x32FFDF4", VA = "0x32FFDF4")]
    private void LoadShopLayoutDefault()
    {
    }

    [Token(Token = "0x6004F62")]
    [Address(RVA = "0x32FFE5C", Offset = "0x32FFE5C", VA = "0x32FFE5C")]
    public ShopRelatedChapterMaster LoadShopRelatedChapter(string path)
    {
      return (ShopRelatedChapterMaster) null;
    }

    [Token(Token = "0x6004F63")]
    [Address(RVA = "0x32FFEB4", Offset = "0x32FFEB4", VA = "0x32FFEB4")]
    private void LoadShopRelatedChapterDefault()
    {
    }

    [Token(Token = "0x6004F64")]
    [Address(RVA = "0x32FFF1C", Offset = "0x32FFF1C", VA = "0x32FFF1C")]
    public StoryShopArticleMaster LoadStoryShopArticle(string path)
    {
      return (StoryShopArticleMaster) null;
    }

    [Token(Token = "0x6004F65")]
    [Address(RVA = "0x32FFF74", Offset = "0x32FFF74", VA = "0x32FFF74")]
    private void LoadStoryShopArticleDefault()
    {
    }

    [Token(Token = "0x6004F66")]
    [Address(RVA = "0x32FFFDC", Offset = "0x32FFFDC", VA = "0x32FFFDC")]
    public StoryShopGrowthMaster LoadStoryShopGrowth(string path) => (StoryShopGrowthMaster) null;

    [Token(Token = "0x6004F67")]
    [Address(RVA = "0x3300034", Offset = "0x3300034", VA = "0x3300034")]
    private void LoadStoryShopGrowthDefault()
    {
    }

    [Token(Token = "0x6004F68")]
    [Address(RVA = "0x330009C", Offset = "0x330009C", VA = "0x330009C")]
    public StoryShopGrowthTypeMaster LoadStoryShopGrowthType(string path)
    {
      return (StoryShopGrowthTypeMaster) null;
    }

    [Token(Token = "0x6004F69")]
    [Address(RVA = "0x33000F4", Offset = "0x33000F4", VA = "0x33000F4")]
    private void LoadStoryShopGrowthTypeDefault()
    {
    }

    [Token(Token = "0x6004F6A")]
    [Address(RVA = "0x330015C", Offset = "0x330015C", VA = "0x330015C")]
    public StoryShopLevelMaster LoadStoryShopLevel(string path) => (StoryShopLevelMaster) null;

    [Token(Token = "0x6004F6B")]
    [Address(RVA = "0x33001B4", Offset = "0x33001B4", VA = "0x33001B4")]
    private void LoadStoryShopLevelDefault()
    {
    }

    [Token(Token = "0x6004F6C")]
    [Address(RVA = "0x330021C", Offset = "0x330021C", VA = "0x330021C")]
    public StoryShopPurchaseLimitTypeMaster LoadStoryShopPurchaseLimitType(string path)
    {
      return (StoryShopPurchaseLimitTypeMaster) null;
    }

    [Token(Token = "0x6004F6D")]
    [Address(RVA = "0x3300274", Offset = "0x3300274", VA = "0x3300274")]
    private void LoadStoryShopPurchaseLimitTypeDefault()
    {
    }

    [Token(Token = "0x6004F6E")]
    [Address(RVA = "0x33002DC", Offset = "0x33002DC", VA = "0x33002DC")]
    public AlignmentStratagemSettingsMaster LoadAlignmentStratagemSettings(string path)
    {
      return (AlignmentStratagemSettingsMaster) null;
    }

    [Token(Token = "0x6004F6F")]
    [Address(RVA = "0x3300334", Offset = "0x3300334", VA = "0x3300334")]
    private void LoadAlignmentStratagemSettingsDefault()
    {
    }

    [Token(Token = "0x6004F70")]
    [Address(RVA = "0x330039C", Offset = "0x330039C", VA = "0x330039C")]
    public CustomSkillCategoryMaster LoadCustomSkillCategory(string path)
    {
      return (CustomSkillCategoryMaster) null;
    }

    [Token(Token = "0x6004F71")]
    [Address(RVA = "0x33003F4", Offset = "0x33003F4", VA = "0x33003F4")]
    private void LoadCustomSkillCategoryDefault()
    {
    }

    [Token(Token = "0x6004F72")]
    [Address(RVA = "0x330045C", Offset = "0x330045C", VA = "0x330045C")]
    public CustomSkillCostMaster LoadCustomSkillCost(string path) => (CustomSkillCostMaster) null;

    [Token(Token = "0x6004F73")]
    [Address(RVA = "0x33004B4", Offset = "0x33004B4", VA = "0x33004B4")]
    private void LoadCustomSkillCostDefault()
    {
    }

    [Token(Token = "0x6004F74")]
    [Address(RVA = "0x330051C", Offset = "0x330051C", VA = "0x330051C")]
    public CustomSkillMaster LoadCustomSkill(string path) => (CustomSkillMaster) null;

    [Token(Token = "0x6004F75")]
    [Address(RVA = "0x3300574", Offset = "0x3300574", VA = "0x3300574")]
    private void LoadCustomSkillDefault()
    {
    }

    [Token(Token = "0x6004F76")]
    [Address(RVA = "0x33005DC", Offset = "0x33005DC", VA = "0x33005DC")]
    public CustomSkillTypeEquipmentLimitMaster LoadCustomSkillTypeEquipmentLimit(string path)
    {
      return (CustomSkillTypeEquipmentLimitMaster) null;
    }

    [Token(Token = "0x6004F77")]
    [Address(RVA = "0x3300634", Offset = "0x3300634", VA = "0x3300634")]
    private void LoadCustomSkillTypeEquipmentLimitDefault()
    {
    }

    [Token(Token = "0x6004F78")]
    [Address(RVA = "0x330069C", Offset = "0x330069C", VA = "0x330069C")]
    public EffectDetailMaster LoadEffectDetail(string path) => (EffectDetailMaster) null;

    [Token(Token = "0x6004F79")]
    [Address(RVA = "0x33006F4", Offset = "0x33006F4", VA = "0x33006F4")]
    private void LoadEffectDetailDefault()
    {
    }

    [Token(Token = "0x6004F7A")]
    [Address(RVA = "0x330075C", Offset = "0x330075C", VA = "0x330075C")]
    public RangeShapeMaster LoadRangeShape(string path) => (RangeShapeMaster) null;

    [Token(Token = "0x6004F7B")]
    [Address(RVA = "0x33007B4", Offset = "0x33007B4", VA = "0x33007B4")]
    private void LoadRangeShapeDefault()
    {
    }

    [Token(Token = "0x6004F7C")]
    [Address(RVA = "0x330081C", Offset = "0x330081C", VA = "0x330081C")]
    public SkillDetailMaster LoadSkillDetail(string path) => (SkillDetailMaster) null;

    [Token(Token = "0x6004F7D")]
    [Address(RVA = "0x3300874", Offset = "0x3300874", VA = "0x3300874")]
    private void LoadSkillDetailDefault()
    {
    }

    [Token(Token = "0x6004F7E")]
    [Address(RVA = "0x33008DC", Offset = "0x33008DC", VA = "0x33008DC")]
    public SkillExpDescriptionMaster LoadSkillExpDescription(string path)
    {
      return (SkillExpDescriptionMaster) null;
    }

    [Token(Token = "0x6004F7F")]
    [Address(RVA = "0x3300934", Offset = "0x3300934", VA = "0x3300934")]
    private void LoadSkillExpDescriptionDefault()
    {
    }

    [Token(Token = "0x6004F80")]
    [Address(RVA = "0x330099C", Offset = "0x330099C", VA = "0x330099C")]
    public SkillMaster LoadSkill(string path) => (SkillMaster) null;

    [Token(Token = "0x6004F81")]
    [Address(RVA = "0x33009F4", Offset = "0x33009F4", VA = "0x33009F4")]
    private void LoadSkillDefault()
    {
    }

    [Token(Token = "0x6004F82")]
    [Address(RVA = "0x3300A5C", Offset = "0x3300A5C", VA = "0x3300A5C")]
    public SkillTagsDetailMaster LoadSkillTagsDetail(string path) => (SkillTagsDetailMaster) null;

    [Token(Token = "0x6004F83")]
    [Address(RVA = "0x3300AB4", Offset = "0x3300AB4", VA = "0x3300AB4")]
    private void LoadSkillTagsDetailDefault()
    {
    }

    [Token(Token = "0x6004F84")]
    [Address(RVA = "0x3300B1C", Offset = "0x3300B1C", VA = "0x3300B1C")]
    public SkillTriggerConditionDetailMaster LoadSkillTriggerConditionDetail(string path)
    {
      return (SkillTriggerConditionDetailMaster) null;
    }

    [Token(Token = "0x6004F85")]
    [Address(RVA = "0x3300B74", Offset = "0x3300B74", VA = "0x3300B74")]
    private void LoadSkillTriggerConditionDetailDefault()
    {
    }

    [Token(Token = "0x6004F86")]
    [Address(RVA = "0x3300BDC", Offset = "0x3300BDC", VA = "0x3300BDC")]
    public SupportSkillActivateRateMaster LoadSupportSkillActivateRate(string path)
    {
      return (SupportSkillActivateRateMaster) null;
    }

    [Token(Token = "0x6004F87")]
    [Address(RVA = "0x3300C34", Offset = "0x3300C34", VA = "0x3300C34")]
    private void LoadSupportSkillActivateRateDefault()
    {
    }

    [Token(Token = "0x6004F88")]
    [Address(RVA = "0x3300C9C", Offset = "0x3300C9C", VA = "0x3300C9C")]
    public SupportSkillDetailMaster LoadSupportSkillDetail(string path)
    {
      return (SupportSkillDetailMaster) null;
    }

    [Token(Token = "0x6004F89")]
    [Address(RVA = "0x3300CF4", Offset = "0x3300CF4", VA = "0x3300CF4")]
    private void LoadSupportSkillDetailDefault()
    {
    }

    [Token(Token = "0x6004F8A")]
    [Address(RVA = "0x3300D5C", Offset = "0x3300D5C", VA = "0x3300D5C")]
    public StoryAbilityMaster LoadStoryAbility(string path) => (StoryAbilityMaster) null;

    [Token(Token = "0x6004F8B")]
    [Address(RVA = "0x3300DB4", Offset = "0x3300DB4", VA = "0x3300DB4")]
    private void LoadStoryAbilityDefault()
    {
    }

    [Token(Token = "0x6004F8C")]
    [Address(RVA = "0x3300E1C", Offset = "0x3300E1C", VA = "0x3300E1C")]
    public StoryAreaMovableBuildSettingMaster LoadStoryAreaMovableBuildSetting(string path)
    {
      return (StoryAreaMovableBuildSettingMaster) null;
    }

    [Token(Token = "0x6004F8D")]
    [Address(RVA = "0x3300E74", Offset = "0x3300E74", VA = "0x3300E74")]
    private void LoadStoryAreaMovableBuildSettingDefault()
    {
    }

    [Token(Token = "0x6004F8E")]
    [Address(RVA = "0x3300EDC", Offset = "0x3300EDC", VA = "0x3300EDC")]
    public StoryAreaMovableGroupPatternMaster LoadStoryAreaMovableGroupPattern(string path)
    {
      return (StoryAreaMovableGroupPatternMaster) null;
    }

    [Token(Token = "0x6004F8F")]
    [Address(RVA = "0x3300F34", Offset = "0x3300F34", VA = "0x3300F34")]
    private void LoadStoryAreaMovableGroupPatternDefault()
    {
    }

    [Token(Token = "0x6004F90")]
    [Address(RVA = "0x3300F9C", Offset = "0x3300F9C", VA = "0x3300F9C")]
    public StoryAreaMovableSettingMaster LoadStoryAreaMovableSetting(string path)
    {
      return (StoryAreaMovableSettingMaster) null;
    }

    [Token(Token = "0x6004F91")]
    [Address(RVA = "0x3300FF4", Offset = "0x3300FF4", VA = "0x3300FF4")]
    private void LoadStoryAreaMovableSettingDefault()
    {
    }

    [Token(Token = "0x6004F92")]
    [Address(RVA = "0x330105C", Offset = "0x330105C", VA = "0x330105C")]
    public StoryAreaMovableSoundEffectMaster LoadStoryAreaMovableSoundEffect(string path)
    {
      return (StoryAreaMovableSoundEffectMaster) null;
    }

    [Token(Token = "0x6004F93")]
    [Address(RVA = "0x33010B4", Offset = "0x33010B4", VA = "0x33010B4")]
    private void LoadStoryAreaMovableSoundEffectDefault()
    {
    }

    [Token(Token = "0x6004F94")]
    [Address(RVA = "0x330111C", Offset = "0x330111C", VA = "0x330111C")]
    public StoryAreaMovableSpawnPatternMaster LoadStoryAreaMovableSpawnPattern(string path)
    {
      return (StoryAreaMovableSpawnPatternMaster) null;
    }

    [Token(Token = "0x6004F95")]
    [Address(RVA = "0x3301174", Offset = "0x3301174", VA = "0x3301174")]
    private void LoadStoryAreaMovableSpawnPatternDefault()
    {
    }

    [Token(Token = "0x6004F96")]
    [Address(RVA = "0x33011DC", Offset = "0x33011DC", VA = "0x33011DC")]
    public StoryAreaMovableSwitchingPatternMaster LoadStoryAreaMovableSwitchingPattern(string path)
    {
      return (StoryAreaMovableSwitchingPatternMaster) null;
    }

    [Token(Token = "0x6004F97")]
    [Address(RVA = "0x3301234", Offset = "0x3301234", VA = "0x3301234")]
    private void LoadStoryAreaMovableSwitchingPatternDefault()
    {
    }

    [Token(Token = "0x6004F98")]
    [Address(RVA = "0x330129C", Offset = "0x330129C", VA = "0x330129C")]
    public StoryAreaEventQuestRewardPaymentMaster LoadStoryAreaEventQuestRewardPayment(string path)
    {
      return (StoryAreaEventQuestRewardPaymentMaster) null;
    }

    [Token(Token = "0x6004F99")]
    [Address(RVA = "0x33012F4", Offset = "0x33012F4", VA = "0x33012F4")]
    private void LoadStoryAreaEventQuestRewardPaymentDefault()
    {
    }

    [Token(Token = "0x6004F9A")]
    [Address(RVA = "0x330135C", Offset = "0x330135C", VA = "0x330135C")]
    public StoryAreaEventQuestMaster LoadStoryAreaEventQuest(string path)
    {
      return (StoryAreaEventQuestMaster) null;
    }

    [Token(Token = "0x6004F9B")]
    [Address(RVA = "0x33013B4", Offset = "0x33013B4", VA = "0x33013B4")]
    private void LoadStoryAreaEventQuestDefault()
    {
    }

    [Token(Token = "0x6004F9C")]
    [Address(RVA = "0x330141C", Offset = "0x330141C", VA = "0x330141C")]
    public StoryAreaEventQuestTaskFlagMaster LoadStoryAreaEventQuestTaskFlag(string path)
    {
      return (StoryAreaEventQuestTaskFlagMaster) null;
    }

    [Token(Token = "0x6004F9D")]
    [Address(RVA = "0x3301474", Offset = "0x3301474", VA = "0x3301474")]
    private void LoadStoryAreaEventQuestTaskFlagDefault()
    {
    }

    [Token(Token = "0x6004F9E")]
    [Address(RVA = "0x33014DC", Offset = "0x33014DC", VA = "0x33014DC")]
    public StoryAreaEventQuestTaskMaster LoadStoryAreaEventQuestTask(string path)
    {
      return (StoryAreaEventQuestTaskMaster) null;
    }

    [Token(Token = "0x6004F9F")]
    [Address(RVA = "0x3301534", Offset = "0x3301534", VA = "0x3301534")]
    private void LoadStoryAreaEventQuestTaskDefault()
    {
    }

    [Token(Token = "0x6004FA0")]
    [Address(RVA = "0x330159C", Offset = "0x330159C", VA = "0x330159C")]
    public StoryAreaEventQuestTaskTextMaster LoadStoryAreaEventQuestTaskText(string path)
    {
      return (StoryAreaEventQuestTaskTextMaster) null;
    }

    [Token(Token = "0x6004FA1")]
    [Address(RVA = "0x33015F4", Offset = "0x33015F4", VA = "0x33015F4")]
    private void LoadStoryAreaEventQuestTaskTextDefault()
    {
    }

    [Token(Token = "0x6004FA2")]
    [Address(RVA = "0x330165C", Offset = "0x330165C", VA = "0x330165C")]
    public StoryCharacterBuildDataMaster LoadStoryCharacterBuildData(string path)
    {
      return (StoryCharacterBuildDataMaster) null;
    }

    [Token(Token = "0x6004FA3")]
    [Address(RVA = "0x33016B4", Offset = "0x33016B4", VA = "0x33016B4")]
    private void LoadStoryCharacterBuildDataDefault()
    {
    }

    [Token(Token = "0x6004FA4")]
    [Address(RVA = "0x330171C", Offset = "0x330171C", VA = "0x330171C")]
    public StoryCharacterSwitchingPatternMaster LoadStoryCharacterSwitchingPattern(string path)
    {
      return (StoryCharacterSwitchingPatternMaster) null;
    }

    [Token(Token = "0x6004FA5")]
    [Address(RVA = "0x3301774", Offset = "0x3301774", VA = "0x3301774")]
    private void LoadStoryCharacterSwitchingPatternDefault()
    {
    }

    [Token(Token = "0x6004FA6")]
    [Address(RVA = "0x33017DC", Offset = "0x33017DC", VA = "0x33017DC")]
    public StoryCommunicationAttachMaster LoadStoryCommunicationAttach(string path)
    {
      return (StoryCommunicationAttachMaster) null;
    }

    [Token(Token = "0x6004FA7")]
    [Address(RVA = "0x3301834", Offset = "0x3301834", VA = "0x3301834")]
    private void LoadStoryCommunicationAttachDefault()
    {
    }

    [Token(Token = "0x6004FA8")]
    [Address(RVA = "0x330189C", Offset = "0x330189C", VA = "0x330189C")]
    public StoryCommunicationGroupLabelMaster LoadStoryCommunicationGroupLabel(string path)
    {
      return (StoryCommunicationGroupLabelMaster) null;
    }

    [Token(Token = "0x6004FA9")]
    [Address(RVA = "0x33018F4", Offset = "0x33018F4", VA = "0x33018F4")]
    private void LoadStoryCommunicationGroupLabelDefault()
    {
    }

    [Token(Token = "0x6004FAA")]
    [Address(RVA = "0x330195C", Offset = "0x330195C", VA = "0x330195C")]
    public StoryCommunicationIdentifierMaster LoadStoryCommunicationIdentifier(string path)
    {
      return (StoryCommunicationIdentifierMaster) null;
    }

    [Token(Token = "0x6004FAB")]
    [Address(RVA = "0x33019B4", Offset = "0x33019B4", VA = "0x33019B4")]
    private void LoadStoryCommunicationIdentifierDefault()
    {
    }

    [Token(Token = "0x6004FAC")]
    [Address(RVA = "0x3301A1C", Offset = "0x3301A1C", VA = "0x3301A1C")]
    public StoryCommunicationLocationCharacterMaster LoadStoryCommunicationLocationCharacter(
      string path)
    {
      return (StoryCommunicationLocationCharacterMaster) null;
    }

    [Token(Token = "0x6004FAD")]
    [Address(RVA = "0x3301A74", Offset = "0x3301A74", VA = "0x3301A74")]
    private void LoadStoryCommunicationLocationCharacterDefault()
    {
    }

    [Token(Token = "0x6004FAE")]
    [Address(RVA = "0x3301ADC", Offset = "0x3301ADC", VA = "0x3301ADC")]
    public StoryCommunicationLocationMaster LoadStoryCommunicationLocation(string path)
    {
      return (StoryCommunicationLocationMaster) null;
    }

    [Token(Token = "0x6004FAF")]
    [Address(RVA = "0x3301B34", Offset = "0x3301B34", VA = "0x3301B34")]
    private void LoadStoryCommunicationLocationDefault()
    {
    }

    [Token(Token = "0x6004FB0")]
    [Address(RVA = "0x3301B9C", Offset = "0x3301B9C", VA = "0x3301B9C")]
    public StoryCommunicationLocationTermMaster LoadStoryCommunicationLocationTerm(string path)
    {
      return (StoryCommunicationLocationTermMaster) null;
    }

    [Token(Token = "0x6004FB1")]
    [Address(RVA = "0x3301BF4", Offset = "0x3301BF4", VA = "0x3301BF4")]
    private void LoadStoryCommunicationLocationTermDefault()
    {
    }

    [Token(Token = "0x6004FB2")]
    [Address(RVA = "0x3301C5C", Offset = "0x3301C5C", VA = "0x3301C5C")]
    public StoryCommunicationParamMaster LoadStoryCommunicationParam(string path)
    {
      return (StoryCommunicationParamMaster) null;
    }

    [Token(Token = "0x6004FB3")]
    [Address(RVA = "0x3301CB4", Offset = "0x3301CB4", VA = "0x3301CB4")]
    private void LoadStoryCommunicationParamDefault()
    {
    }

    [Token(Token = "0x6004FB4")]
    [Address(RVA = "0x3301D1C", Offset = "0x3301D1C", VA = "0x3301D1C")]
    public StoryCommunicationRankupConditionMaster LoadStoryCommunicationRankupCondition(string path)
    {
      return (StoryCommunicationRankupConditionMaster) null;
    }

    [Token(Token = "0x6004FB5")]
    [Address(RVA = "0x3301D74", Offset = "0x3301D74", VA = "0x3301D74")]
    private void LoadStoryCommunicationRankupConditionDefault()
    {
    }

    [Token(Token = "0x6004FB6")]
    [Address(RVA = "0x3301DDC", Offset = "0x3301DDC", VA = "0x3301DDC")]
    public StoryCommunicationRankupHintsMaster LoadStoryCommunicationRankupHints(string path)
    {
      return (StoryCommunicationRankupHintsMaster) null;
    }

    [Token(Token = "0x6004FB7")]
    [Address(RVA = "0x3301E34", Offset = "0x3301E34", VA = "0x3301E34")]
    private void LoadStoryCommunicationRankupHintsDefault()
    {
    }

    [Token(Token = "0x6004FB8")]
    [Address(RVA = "0x3301E9C", Offset = "0x3301E9C", VA = "0x3301E9C")]
    public StoryCommunicationRankupTermMaster LoadStoryCommunicationRankupTerm(string path)
    {
      return (StoryCommunicationRankupTermMaster) null;
    }

    [Token(Token = "0x6004FB9")]
    [Address(RVA = "0x3301EF4", Offset = "0x3301EF4", VA = "0x3301EF4")]
    private void LoadStoryCommunicationRankupTermDefault()
    {
    }

    [Token(Token = "0x6004FBA")]
    [Address(RVA = "0x3301F5C", Offset = "0x3301F5C", VA = "0x3301F5C")]
    public StoryCommunicationReactionTypeMaster LoadStoryCommunicationReactionType(string path)
    {
      return (StoryCommunicationReactionTypeMaster) null;
    }

    [Token(Token = "0x6004FBB")]
    [Address(RVA = "0x3301FB4", Offset = "0x3301FB4", VA = "0x3301FB4")]
    private void LoadStoryCommunicationReactionTypeDefault()
    {
    }

    [Token(Token = "0x6004FBC")]
    [Address(RVA = "0x330201C", Offset = "0x330201C", VA = "0x330201C")]
    public StoryCommunicationRewardPriorityMaster LoadStoryCommunicationRewardPriority(string path)
    {
      return (StoryCommunicationRewardPriorityMaster) null;
    }

    [Token(Token = "0x6004FBD")]
    [Address(RVA = "0x3302074", Offset = "0x3302074", VA = "0x3302074")]
    private void LoadStoryCommunicationRewardPriorityDefault()
    {
    }

    [Token(Token = "0x6004FBE")]
    [Address(RVA = "0x33020DC", Offset = "0x33020DC", VA = "0x33020DC")]
    public StoryCommunicationRewardSetMaster LoadStoryCommunicationRewardSet(string path)
    {
      return (StoryCommunicationRewardSetMaster) null;
    }

    [Token(Token = "0x6004FBF")]
    [Address(RVA = "0x3302134", Offset = "0x3302134", VA = "0x3302134")]
    private void LoadStoryCommunicationRewardSetDefault()
    {
    }

    [Token(Token = "0x6004FC0")]
    [Address(RVA = "0x330219C", Offset = "0x330219C", VA = "0x330219C")]
    public StoryConditionEventMaster LoadStoryConditionEvent(string path)
    {
      return (StoryConditionEventMaster) null;
    }

    [Token(Token = "0x6004FC1")]
    [Address(RVA = "0x33021F4", Offset = "0x33021F4", VA = "0x33021F4")]
    private void LoadStoryConditionEventDefault()
    {
    }

    [Token(Token = "0x6004FC2")]
    [Address(RVA = "0x330225C", Offset = "0x330225C", VA = "0x330225C")]
    public StoryFacilityAttachMaster LoadStoryFacilityAttach(string path)
    {
      return (StoryFacilityAttachMaster) null;
    }

    [Token(Token = "0x6004FC3")]
    [Address(RVA = "0x33022B4", Offset = "0x33022B4", VA = "0x33022B4")]
    private void LoadStoryFacilityAttachDefault()
    {
    }

    [Token(Token = "0x6004FC4")]
    [Address(RVA = "0x330231C", Offset = "0x330231C", VA = "0x330231C")]
    public StoryFacilityBonusMaster LoadStoryFacilityBonus(string path)
    {
      return (StoryFacilityBonusMaster) null;
    }

    [Token(Token = "0x6004FC5")]
    [Address(RVA = "0x3302374", Offset = "0x3302374", VA = "0x3302374")]
    private void LoadStoryFacilityBonusDefault()
    {
    }

    [Token(Token = "0x6004FC6")]
    [Address(RVA = "0x33023DC", Offset = "0x33023DC", VA = "0x33023DC")]
    public StoryFacilityConditionsMaster LoadStoryFacilityConditions(string path)
    {
      return (StoryFacilityConditionsMaster) null;
    }

    [Token(Token = "0x6004FC7")]
    [Address(RVA = "0x3302434", Offset = "0x3302434", VA = "0x3302434")]
    private void LoadStoryFacilityConditionsDefault()
    {
    }

    [Token(Token = "0x6004FC8")]
    [Address(RVA = "0x330249C", Offset = "0x330249C", VA = "0x330249C")]
    public StoryFacilityCostsMaster LoadStoryFacilityCosts(string path)
    {
      return (StoryFacilityCostsMaster) null;
    }

    [Token(Token = "0x6004FC9")]
    [Address(RVA = "0x33024F4", Offset = "0x33024F4", VA = "0x33024F4")]
    private void LoadStoryFacilityCostsDefault()
    {
    }

    [Token(Token = "0x6004FCA")]
    [Address(RVA = "0x330255C", Offset = "0x330255C", VA = "0x330255C")]
    public StoryFacilityDifficultyMaster LoadStoryFacilityDifficulty(string path)
    {
      return (StoryFacilityDifficultyMaster) null;
    }

    [Token(Token = "0x6004FCB")]
    [Address(RVA = "0x33025B4", Offset = "0x33025B4", VA = "0x33025B4")]
    private void LoadStoryFacilityDifficultyDefault()
    {
    }

    [Token(Token = "0x6004FCC")]
    [Address(RVA = "0x330261C", Offset = "0x330261C", VA = "0x330261C")]
    public StoryFacilityEncountBonusDetailMaster LoadStoryFacilityEncountBonusDetail(string path)
    {
      return (StoryFacilityEncountBonusDetailMaster) null;
    }

    [Token(Token = "0x6004FCD")]
    [Address(RVA = "0x3302674", Offset = "0x3302674", VA = "0x3302674")]
    private void LoadStoryFacilityEncountBonusDetailDefault()
    {
    }

    [Token(Token = "0x6004FCE")]
    [Address(RVA = "0x33026DC", Offset = "0x33026DC", VA = "0x33026DC")]
    public StoryFacilityItemBuffEffectParamMaster LoadStoryFacilityItemBuffEffectParam(string path)
    {
      return (StoryFacilityItemBuffEffectParamMaster) null;
    }

    [Token(Token = "0x6004FCF")]
    [Address(RVA = "0x3302734", Offset = "0x3302734", VA = "0x3302734")]
    private void LoadStoryFacilityItemBuffEffectParamDefault()
    {
    }

    [Token(Token = "0x6004FD0")]
    [Address(RVA = "0x330279C", Offset = "0x330279C", VA = "0x330279C")]
    public StoryFacilityMenuMaster LoadStoryFacilityMenu(string path)
    {
      return (StoryFacilityMenuMaster) null;
    }

    [Token(Token = "0x6004FD1")]
    [Address(RVA = "0x33027F4", Offset = "0x33027F4", VA = "0x33027F4")]
    private void LoadStoryFacilityMenuDefault()
    {
    }

    [Token(Token = "0x6004FD2")]
    [Address(RVA = "0x330285C", Offset = "0x330285C", VA = "0x330285C")]
    public StoryFacilityReleaseSequenceMaster LoadStoryFacilityReleaseSequence(string path)
    {
      return (StoryFacilityReleaseSequenceMaster) null;
    }

    [Token(Token = "0x6004FD3")]
    [Address(RVA = "0x33028B4", Offset = "0x33028B4", VA = "0x33028B4")]
    private void LoadStoryFacilityReleaseSequenceDefault()
    {
    }

    [Token(Token = "0x6004FD4")]
    [Address(RVA = "0x330291C", Offset = "0x330291C", VA = "0x330291C")]
    public StoryFacilityRewardsMaster LoadStoryFacilityRewards(string path)
    {
      return (StoryFacilityRewardsMaster) null;
    }

    [Token(Token = "0x6004FD5")]
    [Address(RVA = "0x3302974", Offset = "0x3302974", VA = "0x3302974")]
    private void LoadStoryFacilityRewardsDefault()
    {
    }

    [Token(Token = "0x6004FD6")]
    [Address(RVA = "0x33029DC", Offset = "0x33029DC", VA = "0x33029DC")]
    public StoryFacilityWorkAbilityEffectMaster LoadStoryFacilityWorkAbilityEffect(string path)
    {
      return (StoryFacilityWorkAbilityEffectMaster) null;
    }

    [Token(Token = "0x6004FD7")]
    [Address(RVA = "0x3302A34", Offset = "0x3302A34", VA = "0x3302A34")]
    private void LoadStoryFacilityWorkAbilityEffectDefault()
    {
    }

    [Token(Token = "0x6004FD8")]
    [Address(RVA = "0x3302A9C", Offset = "0x3302A9C", VA = "0x3302A9C")]
    public StoryFacilityWorkMaster LoadStoryFacilityWork(string path)
    {
      return (StoryFacilityWorkMaster) null;
    }

    [Token(Token = "0x6004FD9")]
    [Address(RVA = "0x3302AF4", Offset = "0x3302AF4", VA = "0x3302AF4")]
    private void LoadStoryFacilityWorkDefault()
    {
    }

    [Token(Token = "0x6004FDA")]
    [Address(RVA = "0x3302B5C", Offset = "0x3302B5C", VA = "0x3302B5C")]
    public StoryFreeActionAreaFastTravelMaster LoadStoryFreeActionAreaFastTravel(string path)
    {
      return (StoryFreeActionAreaFastTravelMaster) null;
    }

    [Token(Token = "0x6004FDB")]
    [Address(RVA = "0x3302BB4", Offset = "0x3302BB4", VA = "0x3302BB4")]
    private void LoadStoryFreeActionAreaFastTravelDefault()
    {
    }

    [Token(Token = "0x6004FDC")]
    [Address(RVA = "0x3302C1C", Offset = "0x3302C1C", VA = "0x3302C1C")]
    public StoryFreeActionAreaGroupMaster LoadStoryFreeActionAreaGroup(string path)
    {
      return (StoryFreeActionAreaGroupMaster) null;
    }

    [Token(Token = "0x6004FDD")]
    [Address(RVA = "0x3302C74", Offset = "0x3302C74", VA = "0x3302C74")]
    private void LoadStoryFreeActionAreaGroupDefault()
    {
    }

    [Token(Token = "0x6004FDE")]
    [Address(RVA = "0x3302CDC", Offset = "0x3302CDC", VA = "0x3302CDC")]
    public StoryFreeActionAreaIntroductionMaster LoadStoryFreeActionAreaIntroduction(string path)
    {
      return (StoryFreeActionAreaIntroductionMaster) null;
    }

    [Token(Token = "0x6004FDF")]
    [Address(RVA = "0x3302D34", Offset = "0x3302D34", VA = "0x3302D34")]
    private void LoadStoryFreeActionAreaIntroductionDefault()
    {
    }

    [Token(Token = "0x6004FE0")]
    [Address(RVA = "0x3302D9C", Offset = "0x3302D9C", VA = "0x3302D9C")]
    public StoryFreeActionAreaRegionMaster LoadStoryFreeActionAreaRegion(string path)
    {
      return (StoryFreeActionAreaRegionMaster) null;
    }

    [Token(Token = "0x6004FE1")]
    [Address(RVA = "0x3302DF4", Offset = "0x3302DF4", VA = "0x3302DF4")]
    private void LoadStoryFreeActionAreaRegionDefault()
    {
    }

    [Token(Token = "0x6004FE2")]
    [Address(RVA = "0x3302E5C", Offset = "0x3302E5C", VA = "0x3302E5C")]
    public StoryFreeActionAreaSettingMaster LoadStoryFreeActionAreaSetting(string path)
    {
      return (StoryFreeActionAreaSettingMaster) null;
    }

    [Token(Token = "0x6004FE3")]
    [Address(RVA = "0x3302EB4", Offset = "0x3302EB4", VA = "0x3302EB4")]
    private void LoadStoryFreeActionAreaSettingDefault()
    {
    }

    [Token(Token = "0x6004FE4")]
    [Address(RVA = "0x3302F1C", Offset = "0x3302F1C", VA = "0x3302F1C")]
    public StoryFreeActionAreaMaster LoadStoryFreeActionArea(string path)
    {
      return (StoryFreeActionAreaMaster) null;
    }

    [Token(Token = "0x6004FE5")]
    [Address(RVA = "0x3302F74", Offset = "0x3302F74", VA = "0x3302F74")]
    private void LoadStoryFreeActionAreaDefault()
    {
    }

    [Token(Token = "0x6004FE6")]
    [Address(RVA = "0x3302FDC", Offset = "0x3302FDC", VA = "0x3302FDC")]
    public StoryFreeActionBackgroundMaster LoadStoryFreeActionBackground(string path)
    {
      return (StoryFreeActionBackgroundMaster) null;
    }

    [Token(Token = "0x6004FE7")]
    [Address(RVA = "0x3303034", Offset = "0x3303034", VA = "0x3303034")]
    private void LoadStoryFreeActionBackgroundDefault()
    {
    }

    [Token(Token = "0x6004FE8")]
    [Address(RVA = "0x330309C", Offset = "0x330309C", VA = "0x330309C")]
    public StoryFreeActionBattleEnterLayoutMaster LoadStoryFreeActionBattleEnterLayout(string path)
    {
      return (StoryFreeActionBattleEnterLayoutMaster) null;
    }

    [Token(Token = "0x6004FE9")]
    [Address(RVA = "0x33030F4", Offset = "0x33030F4", VA = "0x33030F4")]
    private void LoadStoryFreeActionBattleEnterLayoutDefault()
    {
    }

    [Token(Token = "0x6004FEA")]
    [Address(RVA = "0x330315C", Offset = "0x330315C", VA = "0x330315C")]
    public StoryFreeActionCameraViewPositionMaster LoadStoryFreeActionCameraViewPosition(string path)
    {
      return (StoryFreeActionCameraViewPositionMaster) null;
    }

    [Token(Token = "0x6004FEB")]
    [Address(RVA = "0x33031B4", Offset = "0x33031B4", VA = "0x33031B4")]
    private void LoadStoryFreeActionCameraViewPositionDefault()
    {
    }

    [Token(Token = "0x6004FEC")]
    [Address(RVA = "0x330321C", Offset = "0x330321C", VA = "0x330321C")]
    public StoryFreeActionCharacterPatternAssignDataMaster LoadStoryFreeActionCharacterPatternAssignData(
      string path)
    {
      return (StoryFreeActionCharacterPatternAssignDataMaster) null;
    }

    [Token(Token = "0x6004FED")]
    [Address(RVA = "0x3303274", Offset = "0x3303274", VA = "0x3303274")]
    private void LoadStoryFreeActionCharacterPatternAssignDataDefault()
    {
    }

    [Token(Token = "0x6004FEE")]
    [Address(RVA = "0x33032DC", Offset = "0x33032DC", VA = "0x33032DC")]
    public StoryFreeActionChestMaster LoadStoryFreeActionChest(string path)
    {
      return (StoryFreeActionChestMaster) null;
    }

    [Token(Token = "0x6004FEF")]
    [Address(RVA = "0x3303334", Offset = "0x3303334", VA = "0x3303334")]
    private void LoadStoryFreeActionChestDefault()
    {
    }

    [Token(Token = "0x6004FF0")]
    [Address(RVA = "0x330339C", Offset = "0x330339C", VA = "0x330339C")]
    public StoryFreeActionChestTypeMaster LoadStoryFreeActionChestType(string path)
    {
      return (StoryFreeActionChestTypeMaster) null;
    }

    [Token(Token = "0x6004FF1")]
    [Address(RVA = "0x33033F4", Offset = "0x33033F4", VA = "0x33033F4")]
    private void LoadStoryFreeActionChestTypeDefault()
    {
    }

    [Token(Token = "0x6004FF2")]
    [Address(RVA = "0x330345C", Offset = "0x330345C", VA = "0x330345C")]
    public StoryFreeActionConstMaster LoadStoryFreeActionConst(string path)
    {
      return (StoryFreeActionConstMaster) null;
    }

    [Token(Token = "0x6004FF3")]
    [Address(RVA = "0x33034B4", Offset = "0x33034B4", VA = "0x33034B4")]
    private void LoadStoryFreeActionConstDefault()
    {
    }

    [Token(Token = "0x6004FF4")]
    [Address(RVA = "0x330351C", Offset = "0x330351C", VA = "0x330351C")]
    public StoryFreeActionEventCircleMaster LoadStoryFreeActionEventCircle(string path)
    {
      return (StoryFreeActionEventCircleMaster) null;
    }

    [Token(Token = "0x6004FF5")]
    [Address(RVA = "0x3303574", Offset = "0x3303574", VA = "0x3303574")]
    private void LoadStoryFreeActionEventCircleDefault()
    {
    }

    [Token(Token = "0x6004FF6")]
    [Address(RVA = "0x33035DC", Offset = "0x33035DC", VA = "0x33035DC")]
    public StoryFreeActionFlavorObjectMaster LoadStoryFreeActionFlavorObject(string path)
    {
      return (StoryFreeActionFlavorObjectMaster) null;
    }

    [Token(Token = "0x6004FF7")]
    [Address(RVA = "0x3303634", Offset = "0x3303634", VA = "0x3303634")]
    private void LoadStoryFreeActionFlavorObjectDefault()
    {
    }

    [Token(Token = "0x6004FF8")]
    [Address(RVA = "0x330369C", Offset = "0x330369C", VA = "0x330369C")]
    public StoryFreeActionFlavorObjectTextMaster LoadStoryFreeActionFlavorObjectText(string path)
    {
      return (StoryFreeActionFlavorObjectTextMaster) null;
    }

    [Token(Token = "0x6004FF9")]
    [Address(RVA = "0x33036F4", Offset = "0x33036F4", VA = "0x33036F4")]
    private void LoadStoryFreeActionFlavorObjectTextDefault()
    {
    }

    [Token(Token = "0x6004FFA")]
    [Address(RVA = "0x330375C", Offset = "0x330375C", VA = "0x330375C")]
    public StoryFreeActionIconTypeMaster LoadStoryFreeActionIconType(string path)
    {
      return (StoryFreeActionIconTypeMaster) null;
    }

    [Token(Token = "0x6004FFB")]
    [Address(RVA = "0x33037B4", Offset = "0x33037B4", VA = "0x33037B4")]
    private void LoadStoryFreeActionIconTypeDefault()
    {
    }

    [Token(Token = "0x6004FFC")]
    [Address(RVA = "0x330381C", Offset = "0x330381C", VA = "0x330381C")]
    public StoryFreeActionLayoutMaster LoadStoryFreeActionLayout(string path)
    {
      return (StoryFreeActionLayoutMaster) null;
    }

    [Token(Token = "0x6004FFD")]
    [Address(RVA = "0x3303874", Offset = "0x3303874", VA = "0x3303874")]
    private void LoadStoryFreeActionLayoutDefault()
    {
    }

    [Token(Token = "0x6004FFE")]
    [Address(RVA = "0x33038DC", Offset = "0x33038DC", VA = "0x33038DC")]
    public StoryFreeActionMinimapMaster LoadStoryFreeActionMinimap(string path)
    {
      return (StoryFreeActionMinimapMaster) null;
    }

    [Token(Token = "0x6004FFF")]
    [Address(RVA = "0x3303934", Offset = "0x3303934", VA = "0x3303934")]
    private void LoadStoryFreeActionMinimapDefault()
    {
    }

    [Token(Token = "0x6005000")]
    [Address(RVA = "0x330399C", Offset = "0x330399C", VA = "0x330399C")]
    public StoryFreeActionObjectMaster LoadStoryFreeActionObject(string path)
    {
      return (StoryFreeActionObjectMaster) null;
    }

    [Token(Token = "0x6005001")]
    [Address(RVA = "0x33039F4", Offset = "0x33039F4", VA = "0x33039F4")]
    private void LoadStoryFreeActionObjectDefault()
    {
    }

    [Token(Token = "0x6005002")]
    [Address(RVA = "0x3303A5C", Offset = "0x3303A5C", VA = "0x3303A5C")]
    public StoryFreeActionObliviaeLayoutMaster LoadStoryFreeActionObliviaeLayout(string path)
    {
      return (StoryFreeActionObliviaeLayoutMaster) null;
    }

    [Token(Token = "0x6005003")]
    [Address(RVA = "0x3303AB4", Offset = "0x3303AB4", VA = "0x3303AB4")]
    private void LoadStoryFreeActionObliviaeLayoutDefault()
    {
    }

    [Token(Token = "0x6005004")]
    [Address(RVA = "0x3303B1C", Offset = "0x3303B1C", VA = "0x3303B1C")]
    public StoryFreeActionOverrideSequeceMaster LoadStoryFreeActionOverrideSequece(string path)
    {
      return (StoryFreeActionOverrideSequeceMaster) null;
    }

    [Token(Token = "0x6005005")]
    [Address(RVA = "0x3303B74", Offset = "0x3303B74", VA = "0x3303B74")]
    private void LoadStoryFreeActionOverrideSequeceDefault()
    {
    }

    [Token(Token = "0x6005006")]
    [Address(RVA = "0x3303BDC", Offset = "0x3303BDC", VA = "0x3303BDC")]
    public StoryFreeActionPassiveTalkMessageMaster LoadStoryFreeActionPassiveTalkMessage(string path)
    {
      return (StoryFreeActionPassiveTalkMessageMaster) null;
    }

    [Token(Token = "0x6005007")]
    [Address(RVA = "0x3303C34", Offset = "0x3303C34", VA = "0x3303C34")]
    private void LoadStoryFreeActionPassiveTalkMessageDefault()
    {
    }

    [Token(Token = "0x6005008")]
    [Address(RVA = "0x3303C9C", Offset = "0x3303C9C", VA = "0x3303C9C")]
    public StoryFreeActionPlayerMovePositionMaster LoadStoryFreeActionPlayerMovePosition(string path)
    {
      return (StoryFreeActionPlayerMovePositionMaster) null;
    }

    [Token(Token = "0x6005009")]
    [Address(RVA = "0x3303CF4", Offset = "0x3303CF4", VA = "0x3303CF4")]
    private void LoadStoryFreeActionPlayerMovePositionDefault()
    {
    }

    [Token(Token = "0x600500A")]
    [Address(RVA = "0x3303D5C", Offset = "0x3303D5C", VA = "0x3303D5C")]
    public StoryFreeActionPlayerMaster LoadStoryFreeActionPlayer(string path)
    {
      return (StoryFreeActionPlayerMaster) null;
    }

    [Token(Token = "0x600500B")]
    [Address(RVA = "0x3303DB4", Offset = "0x3303DB4", VA = "0x3303DB4")]
    private void LoadStoryFreeActionPlayerDefault()
    {
    }

    [Token(Token = "0x600500C")]
    [Address(RVA = "0x3303E1C", Offset = "0x3303E1C", VA = "0x3303E1C")]
    public StoryFreeActionPropMaster LoadStoryFreeActionProp(string path)
    {
      return (StoryFreeActionPropMaster) null;
    }

    [Token(Token = "0x600500D")]
    [Address(RVA = "0x3303E74", Offset = "0x3303E74", VA = "0x3303E74")]
    private void LoadStoryFreeActionPropDefault()
    {
    }

    [Token(Token = "0x600500E")]
    [Address(RVA = "0x3303EDC", Offset = "0x3303EDC", VA = "0x3303EDC")]
    public StoryFreeActionRewardObjectBreakableObjectPropSettingMaster LoadStoryFreeActionRewardObjectBreakableObjectPropSetting(
      string path)
    {
      return (StoryFreeActionRewardObjectBreakableObjectPropSettingMaster) null;
    }

    [Token(Token = "0x600500F")]
    [Address(RVA = "0x3303F34", Offset = "0x3303F34", VA = "0x3303F34")]
    private void LoadStoryFreeActionRewardObjectBreakableObjectPropSettingDefault()
    {
    }

    [Token(Token = "0x6005010")]
    [Address(RVA = "0x3303F9C", Offset = "0x3303F9C", VA = "0x3303F9C")]
    public StoryFreeActionRewardObjectBreakableObjectMaster LoadStoryFreeActionRewardObjectBreakableObject(
      string path)
    {
      return (StoryFreeActionRewardObjectBreakableObjectMaster) null;
    }

    [Token(Token = "0x6005011")]
    [Address(RVA = "0x3303FF4", Offset = "0x3303FF4", VA = "0x3303FF4")]
    private void LoadStoryFreeActionRewardObjectBreakableObjectDefault()
    {
    }

    [Token(Token = "0x6005012")]
    [Address(RVA = "0x330405C", Offset = "0x330405C", VA = "0x330405C")]
    public StoryFreeActionRewardObjectLayoutMaster LoadStoryFreeActionRewardObjectLayout(string path)
    {
      return (StoryFreeActionRewardObjectLayoutMaster) null;
    }

    [Token(Token = "0x6005013")]
    [Address(RVA = "0x33040B4", Offset = "0x33040B4", VA = "0x33040B4")]
    private void LoadStoryFreeActionRewardObjectLayoutDefault()
    {
    }

    [Token(Token = "0x6005014")]
    [Address(RVA = "0x330411C", Offset = "0x330411C", VA = "0x330411C")]
    public StoryFreeActionRewardObjectRewardsMaster LoadStoryFreeActionRewardObjectRewards(
      string path)
    {
      return (StoryFreeActionRewardObjectRewardsMaster) null;
    }

    [Token(Token = "0x6005015")]
    [Address(RVA = "0x3304174", Offset = "0x3304174", VA = "0x3304174")]
    private void LoadStoryFreeActionRewardObjectRewardsDefault()
    {
    }

    [Token(Token = "0x6005016")]
    [Address(RVA = "0x33041DC", Offset = "0x33041DC", VA = "0x33041DC")]
    public StoryFreeActionSettingMaster LoadStoryFreeActionSetting(string path)
    {
      return (StoryFreeActionSettingMaster) null;
    }

    [Token(Token = "0x6005017")]
    [Address(RVA = "0x3304234", Offset = "0x3304234", VA = "0x3304234")]
    private void LoadStoryFreeActionSettingDefault()
    {
    }

    [Token(Token = "0x6005018")]
    [Address(RVA = "0x330429C", Offset = "0x330429C", VA = "0x330429C")]
    public StoryFreeActionSoundEffectMaster LoadStoryFreeActionSoundEffect(string path)
    {
      return (StoryFreeActionSoundEffectMaster) null;
    }

    [Token(Token = "0x6005019")]
    [Address(RVA = "0x33042F4", Offset = "0x33042F4", VA = "0x33042F4")]
    private void LoadStoryFreeActionSoundEffectDefault()
    {
    }

    [Token(Token = "0x600501A")]
    [Address(RVA = "0x330435C", Offset = "0x330435C", VA = "0x330435C")]
    public StoryFreeActionSoundObjectMaster LoadStoryFreeActionSoundObject(string path)
    {
      return (StoryFreeActionSoundObjectMaster) null;
    }

    [Token(Token = "0x600501B")]
    [Address(RVA = "0x33043B4", Offset = "0x33043B4", VA = "0x33043B4")]
    private void LoadStoryFreeActionSoundObjectDefault()
    {
    }

    [Token(Token = "0x600501C")]
    [Address(RVA = "0x330441C", Offset = "0x330441C", VA = "0x330441C")]
    public StoryFreeActionSystemMenuEventMaster LoadStoryFreeActionSystemMenuEvent(string path)
    {
      return (StoryFreeActionSystemMenuEventMaster) null;
    }

    [Token(Token = "0x600501D")]
    [Address(RVA = "0x3304474", Offset = "0x3304474", VA = "0x3304474")]
    private void LoadStoryFreeActionSystemMenuEventDefault()
    {
    }

    [Token(Token = "0x600501E")]
    [Address(RVA = "0x33044DC", Offset = "0x33044DC", VA = "0x33044DC")]
    public StoryFreeActionTalkADVEventMaster LoadStoryFreeActionTalkADVEvent(string path)
    {
      return (StoryFreeActionTalkADVEventMaster) null;
    }

    [Token(Token = "0x600501F")]
    [Address(RVA = "0x3304534", Offset = "0x3304534", VA = "0x3304534")]
    private void LoadStoryFreeActionTalkADVEventDefault()
    {
    }

    [Token(Token = "0x6005020")]
    [Address(RVA = "0x330459C", Offset = "0x330459C", VA = "0x330459C")]
    public StoryFreeActionTalkADVEventTextMaster LoadStoryFreeActionTalkADVEventText(string path)
    {
      return (StoryFreeActionTalkADVEventTextMaster) null;
    }

    [Token(Token = "0x6005021")]
    [Address(RVA = "0x33045F4", Offset = "0x33045F4", VA = "0x33045F4")]
    private void LoadStoryFreeActionTalkADVEventTextDefault()
    {
    }

    [Token(Token = "0x6005022")]
    [Address(RVA = "0x330465C", Offset = "0x330465C", VA = "0x330465C")]
    public StoryFreeActionTalkBalloonEventMaster LoadStoryFreeActionTalkBalloonEvent(string path)
    {
      return (StoryFreeActionTalkBalloonEventMaster) null;
    }

    [Token(Token = "0x6005023")]
    [Address(RVA = "0x33046B4", Offset = "0x33046B4", VA = "0x33046B4")]
    private void LoadStoryFreeActionTalkBalloonEventDefault()
    {
    }

    [Token(Token = "0x6005024")]
    [Address(RVA = "0x330471C", Offset = "0x330471C", VA = "0x330471C")]
    public StoryFreeActionTelopMaster LoadStoryFreeActionTelop(string path)
    {
      return (StoryFreeActionTelopMaster) null;
    }

    [Token(Token = "0x6005025")]
    [Address(RVA = "0x3304774", Offset = "0x3304774", VA = "0x3304774")]
    private void LoadStoryFreeActionTelopDefault()
    {
    }

    [Token(Token = "0x6005026")]
    [Address(RVA = "0x33047DC", Offset = "0x33047DC", VA = "0x33047DC")]
    public StoryFreeActionTimeElapseLayoutMaster LoadStoryFreeActionTimeElapseLayout(string path)
    {
      return (StoryFreeActionTimeElapseLayoutMaster) null;
    }

    [Token(Token = "0x6005027")]
    [Address(RVA = "0x3304834", Offset = "0x3304834", VA = "0x3304834")]
    private void LoadStoryFreeActionTimeElapseLayoutDefault()
    {
    }

    [Token(Token = "0x6005028")]
    [Address(RVA = "0x330489C", Offset = "0x330489C", VA = "0x330489C")]
    public StoryFreeActionUniqueObjectSettingMaster LoadStoryFreeActionUniqueObjectSetting(
      string path)
    {
      return (StoryFreeActionUniqueObjectSettingMaster) null;
    }

    [Token(Token = "0x6005029")]
    [Address(RVA = "0x33048F4", Offset = "0x33048F4", VA = "0x33048F4")]
    private void LoadStoryFreeActionUniqueObjectSettingDefault()
    {
    }

    [Token(Token = "0x600502A")]
    [Address(RVA = "0x330495C", Offset = "0x330495C", VA = "0x330495C")]
    public StoryMainQuestCalendarElapsedGroupMaster LoadStoryMainQuestCalendarElapsedGroup(
      string path)
    {
      return (StoryMainQuestCalendarElapsedGroupMaster) null;
    }

    [Token(Token = "0x600502B")]
    [Address(RVA = "0x33049B4", Offset = "0x33049B4", VA = "0x33049B4")]
    private void LoadStoryMainQuestCalendarElapsedGroupDefault()
    {
    }

    [Token(Token = "0x600502C")]
    [Address(RVA = "0x3304A1C", Offset = "0x3304A1C", VA = "0x3304A1C")]
    public StoryMainQuestCalendarElapsedParamMaster LoadStoryMainQuestCalendarElapsedParam(
      string path)
    {
      return (StoryMainQuestCalendarElapsedParamMaster) null;
    }

    [Token(Token = "0x600502D")]
    [Address(RVA = "0x3304A74", Offset = "0x3304A74", VA = "0x3304A74")]
    private void LoadStoryMainQuestCalendarElapsedParamDefault()
    {
    }

    [Token(Token = "0x600502E")]
    [Address(RVA = "0x3304ADC", Offset = "0x3304ADC", VA = "0x3304ADC")]
    public StoryMainQuestCalendarElapsedMaster LoadStoryMainQuestCalendarElapsed(string path)
    {
      return (StoryMainQuestCalendarElapsedMaster) null;
    }

    [Token(Token = "0x600502F")]
    [Address(RVA = "0x3304B34", Offset = "0x3304B34", VA = "0x3304B34")]
    private void LoadStoryMainQuestCalendarElapsedDefault()
    {
    }

    [Token(Token = "0x6005030")]
    [Address(RVA = "0x3304B9C", Offset = "0x3304B9C", VA = "0x3304B9C")]
    public StoryMainQuestCalendarHoridayMaster LoadStoryMainQuestCalendarHoriday(string path)
    {
      return (StoryMainQuestCalendarHoridayMaster) null;
    }

    [Token(Token = "0x6005031")]
    [Address(RVA = "0x3304BF4", Offset = "0x3304BF4", VA = "0x3304BF4")]
    private void LoadStoryMainQuestCalendarHoridayDefault()
    {
    }

    [Token(Token = "0x6005032")]
    [Address(RVA = "0x3304C5C", Offset = "0x3304C5C", VA = "0x3304C5C")]
    public StoryMainQuestCalendarMaster LoadStoryMainQuestCalendar(string path)
    {
      return (StoryMainQuestCalendarMaster) null;
    }

    [Token(Token = "0x6005033")]
    [Address(RVA = "0x3304CB4", Offset = "0x3304CB4", VA = "0x3304CB4")]
    private void LoadStoryMainQuestCalendarDefault()
    {
    }

    [Token(Token = "0x6005034")]
    [Address(RVA = "0x3304D1C", Offset = "0x3304D1C", VA = "0x3304D1C")]
    public StoryMainQuestSequenceConditionMaster LoadStoryMainQuestSequenceCondition(string path)
    {
      return (StoryMainQuestSequenceConditionMaster) null;
    }

    [Token(Token = "0x6005035")]
    [Address(RVA = "0x3304D74", Offset = "0x3304D74", VA = "0x3304D74")]
    private void LoadStoryMainQuestSequenceConditionDefault()
    {
    }

    [Token(Token = "0x6005036")]
    [Address(RVA = "0x3304DDC", Offset = "0x3304DDC", VA = "0x3304DDC")]
    public StoryMainQuestSequenceConditionTypeMaster LoadStoryMainQuestSequenceConditionType(
      string path)
    {
      return (StoryMainQuestSequenceConditionTypeMaster) null;
    }

    [Token(Token = "0x6005037")]
    [Address(RVA = "0x3304E34", Offset = "0x3304E34", VA = "0x3304E34")]
    private void LoadStoryMainQuestSequenceConditionTypeDefault()
    {
    }

    [Token(Token = "0x6005038")]
    [Address(RVA = "0x3304E9C", Offset = "0x3304E9C", VA = "0x3304E9C")]
    public StoryMainQuestSequenceRewardsPaymentsMaster LoadStoryMainQuestSequenceRewardsPayments(
      string path)
    {
      return (StoryMainQuestSequenceRewardsPaymentsMaster) null;
    }

    [Token(Token = "0x6005039")]
    [Address(RVA = "0x3304EF4", Offset = "0x3304EF4", VA = "0x3304EF4")]
    private void LoadStoryMainQuestSequenceRewardsPaymentsDefault()
    {
    }

    [Token(Token = "0x600503A")]
    [Address(RVA = "0x3304F5C", Offset = "0x3304F5C", VA = "0x3304F5C")]
    public StoryMainQuestSequenceSummaryMaster LoadStoryMainQuestSequenceSummary(string path)
    {
      return (StoryMainQuestSequenceSummaryMaster) null;
    }

    [Token(Token = "0x600503B")]
    [Address(RVA = "0x3304FB4", Offset = "0x3304FB4", VA = "0x3304FB4")]
    private void LoadStoryMainQuestSequenceSummaryDefault()
    {
    }

    [Token(Token = "0x600503C")]
    [Address(RVA = "0x330501C", Offset = "0x330501C", VA = "0x330501C")]
    public StoryMainQuestSequenceMaster LoadStoryMainQuestSequence(string path)
    {
      return (StoryMainQuestSequenceMaster) null;
    }

    [Token(Token = "0x600503D")]
    [Address(RVA = "0x3305074", Offset = "0x3305074", VA = "0x3305074")]
    private void LoadStoryMainQuestSequenceDefault()
    {
    }

    [Token(Token = "0x600503E")]
    [Address(RVA = "0x33050DC", Offset = "0x33050DC", VA = "0x33050DC")]
    public StoryMainquestSequenceTutorialMaster LoadStoryMainquestSequenceTutorial(string path)
    {
      return (StoryMainquestSequenceTutorialMaster) null;
    }

    [Token(Token = "0x600503F")]
    [Address(RVA = "0x3305134", Offset = "0x3305134", VA = "0x3305134")]
    private void LoadStoryMainquestSequenceTutorialDefault()
    {
    }

    [Token(Token = "0x6005040")]
    [Address(RVA = "0x330519C", Offset = "0x330519C", VA = "0x330519C")]
    public StoryMainQuestTimeZoneElapsedGroupMaster LoadStoryMainQuestTimeZoneElapsedGroup(
      string path)
    {
      return (StoryMainQuestTimeZoneElapsedGroupMaster) null;
    }

    [Token(Token = "0x6005041")]
    [Address(RVA = "0x33051F4", Offset = "0x33051F4", VA = "0x33051F4")]
    private void LoadStoryMainQuestTimeZoneElapsedGroupDefault()
    {
    }

    [Token(Token = "0x6005042")]
    [Address(RVA = "0x330525C", Offset = "0x330525C", VA = "0x330525C")]
    public StoryMainQuestTimeZoneElapsedParamMaster LoadStoryMainQuestTimeZoneElapsedParam(
      string path)
    {
      return (StoryMainQuestTimeZoneElapsedParamMaster) null;
    }

    [Token(Token = "0x6005043")]
    [Address(RVA = "0x33052B4", Offset = "0x33052B4", VA = "0x33052B4")]
    private void LoadStoryMainQuestTimeZoneElapsedParamDefault()
    {
    }

    [Token(Token = "0x6005044")]
    [Address(RVA = "0x330531C", Offset = "0x330531C", VA = "0x330531C")]
    public StoryMainQuestTimeZoneElapsedMaster LoadStoryMainQuestTimeZoneElapsed(string path)
    {
      return (StoryMainQuestTimeZoneElapsedMaster) null;
    }

    [Token(Token = "0x6005045")]
    [Address(RVA = "0x3305374", Offset = "0x3305374", VA = "0x3305374")]
    private void LoadStoryMainQuestTimeZoneElapsedDefault()
    {
    }

    [Token(Token = "0x6005046")]
    [Address(RVA = "0x33053DC", Offset = "0x33053DC", VA = "0x33053DC")]
    public StoryMainQuestYearMaster LoadStoryMainQuestYear(string path)
    {
      return (StoryMainQuestYearMaster) null;
    }

    [Token(Token = "0x6005047")]
    [Address(RVA = "0x3305434", Offset = "0x3305434", VA = "0x3305434")]
    private void LoadStoryMainQuestYearDefault()
    {
    }

    [Token(Token = "0x6005048")]
    [Address(RVA = "0x330549C", Offset = "0x330549C", VA = "0x330549C")]
    public StoryMainQuestYearTextMaster LoadStoryMainQuestYearText(string path)
    {
      return (StoryMainQuestYearTextMaster) null;
    }

    [Token(Token = "0x6005049")]
    [Address(RVA = "0x33054F4", Offset = "0x33054F4", VA = "0x33054F4")]
    private void LoadStoryMainQuestYearTextDefault()
    {
    }

    [Token(Token = "0x600504A")]
    [Address(RVA = "0x330555C", Offset = "0x330555C", VA = "0x330555C")]
    public StoryReplayEntryDescriptionMaster LoadStoryReplayEntryDescription(string path)
    {
      return (StoryReplayEntryDescriptionMaster) null;
    }

    [Token(Token = "0x600504B")]
    [Address(RVA = "0x33055B4", Offset = "0x33055B4", VA = "0x33055B4")]
    private void LoadStoryReplayEntryDescriptionDefault()
    {
    }

    [Token(Token = "0x600504C")]
    [Address(RVA = "0x330561C", Offset = "0x330561C", VA = "0x330561C")]
    public StoryReplayEntryMaster LoadStoryReplayEntry(string path)
    {
      return (StoryReplayEntryMaster) null;
    }

    [Token(Token = "0x600504D")]
    [Address(RVA = "0x3305674", Offset = "0x3305674", VA = "0x3305674")]
    private void LoadStoryReplayEntryDefault()
    {
    }

    [Token(Token = "0x600504E")]
    [Address(RVA = "0x33056DC", Offset = "0x33056DC", VA = "0x33056DC")]
    public StoryReplayEntryUnlockMaster LoadStoryReplayEntryUnlock(string path)
    {
      return (StoryReplayEntryUnlockMaster) null;
    }

    [Token(Token = "0x600504F")]
    [Address(RVA = "0x3305734", Offset = "0x3305734", VA = "0x3305734")]
    private void LoadStoryReplayEntryUnlockDefault()
    {
    }

    [Token(Token = "0x6005050")]
    [Address(RVA = "0x330579C", Offset = "0x330579C", VA = "0x330579C")]
    public StoryReplayMaster LoadStoryReplay(string path) => (StoryReplayMaster) null;

    [Token(Token = "0x6005051")]
    [Address(RVA = "0x33057F4", Offset = "0x33057F4", VA = "0x33057F4")]
    private void LoadStoryReplayDefault()
    {
    }

    [Token(Token = "0x6005052")]
    [Address(RVA = "0x330585C", Offset = "0x330585C", VA = "0x330585C")]
    public StorySceneTypeMaster LoadStorySceneType(string path) => (StorySceneTypeMaster) null;

    [Token(Token = "0x6005053")]
    [Address(RVA = "0x33058B4", Offset = "0x33058B4", VA = "0x33058B4")]
    private void LoadStorySceneTypeDefault()
    {
    }

    [Token(Token = "0x6005054")]
    [Address(RVA = "0x330591C", Offset = "0x330591C", VA = "0x330591C")]
    public StoryObliviaeDetailMaster LoadStoryObliviaeDetail(string path)
    {
      return (StoryObliviaeDetailMaster) null;
    }

    [Token(Token = "0x6005055")]
    [Address(RVA = "0x3305974", Offset = "0x3305974", VA = "0x3305974")]
    private void LoadStoryObliviaeDetailDefault()
    {
    }

    [Token(Token = "0x6005056")]
    [Address(RVA = "0x33059DC", Offset = "0x33059DC", VA = "0x33059DC")]
    public StoryObliviaeMaster LoadStoryObliviae(string path) => (StoryObliviaeMaster) null;

    [Token(Token = "0x6005057")]
    [Address(RVA = "0x3305A34", Offset = "0x3305A34", VA = "0x3305A34")]
    private void LoadStoryObliviaeDefault()
    {
    }

    [Token(Token = "0x6005058")]
    [Address(RVA = "0x3305A9C", Offset = "0x3305A9C", VA = "0x3305A9C")]
    public StoryBgTemplateMaster LoadStoryBgTemplate(string path) => (StoryBgTemplateMaster) null;

    [Token(Token = "0x6005059")]
    [Address(RVA = "0x3305AF4", Offset = "0x3305AF4", VA = "0x3305AF4")]
    private void LoadStoryBgTemplateDefault()
    {
    }

    [Token(Token = "0x600505A")]
    [Address(RVA = "0x3305B5C", Offset = "0x3305B5C", VA = "0x3305B5C")]
    public StoryBookCompleteFirstImpressionsMaster LoadStoryBookCompleteFirstImpressions(string path)
    {
      return (StoryBookCompleteFirstImpressionsMaster) null;
    }

    [Token(Token = "0x600505B")]
    [Address(RVA = "0x3305BB4", Offset = "0x3305BB4", VA = "0x3305BB4")]
    private void LoadStoryBookCompleteFirstImpressionsDefault()
    {
    }

    [Token(Token = "0x600505C")]
    [Address(RVA = "0x3305C1C", Offset = "0x3305C1C", VA = "0x3305C1C")]
    public StoryBookCompleteImpressionsMaster LoadStoryBookCompleteImpressions(string path)
    {
      return (StoryBookCompleteImpressionsMaster) null;
    }

    [Token(Token = "0x600505D")]
    [Address(RVA = "0x3305C74", Offset = "0x3305C74", VA = "0x3305C74")]
    private void LoadStoryBookCompleteImpressionsDefault()
    {
    }

    [Token(Token = "0x600505E")]
    [Address(RVA = "0x3305CDC", Offset = "0x3305CDC", VA = "0x3305CDC")]
    public StoryBookEffectMaster LoadStoryBookEffect(string path) => (StoryBookEffectMaster) null;

    [Token(Token = "0x600505F")]
    [Address(RVA = "0x3305D34", Offset = "0x3305D34", VA = "0x3305D34")]
    private void LoadStoryBookEffectDefault()
    {
    }

    [Token(Token = "0x6005060")]
    [Address(RVA = "0x3305D9C", Offset = "0x3305D9C", VA = "0x3305D9C")]
    public StoryBookProgressImpressionsMaster LoadStoryBookProgressImpressions(string path)
    {
      return (StoryBookProgressImpressionsMaster) null;
    }

    [Token(Token = "0x6005061")]
    [Address(RVA = "0x3305DF4", Offset = "0x3305DF4", VA = "0x3305DF4")]
    private void LoadStoryBookProgressImpressionsDefault()
    {
    }

    [Token(Token = "0x6005062")]
    [Address(RVA = "0x3305E5C", Offset = "0x3305E5C", VA = "0x3305E5C")]
    public StoryChapterMaster LoadStoryChapter(string path) => (StoryChapterMaster) null;

    [Token(Token = "0x6005063")]
    [Address(RVA = "0x3305EB4", Offset = "0x3305EB4", VA = "0x3305EB4")]
    private void LoadStoryChapterDefault()
    {
    }

    [Token(Token = "0x6005064")]
    [Address(RVA = "0x3305F1C", Offset = "0x3305F1C", VA = "0x3305F1C")]
    public StoryDayOfWeekMaster LoadStoryDayOfWeek(string path) => (StoryDayOfWeekMaster) null;

    [Token(Token = "0x6005065")]
    [Address(RVA = "0x3305F74", Offset = "0x3305F74", VA = "0x3305F74")]
    private void LoadStoryDayOfWeekDefault()
    {
    }

    [Token(Token = "0x6005066")]
    [Address(RVA = "0x3305FDC", Offset = "0x3305FDC", VA = "0x3305FDC")]
    public StoryEndingMaster LoadStoryEnding(string path) => (StoryEndingMaster) null;

    [Token(Token = "0x6005067")]
    [Address(RVA = "0x3306034", Offset = "0x3306034", VA = "0x3306034")]
    private void LoadStoryEndingDefault()
    {
    }

    [Token(Token = "0x6005068")]
    [Address(RVA = "0x330609C", Offset = "0x330609C", VA = "0x330609C")]
    public StoryHumanParameterLevelMaster LoadStoryHumanParameterLevel(string path)
    {
      return (StoryHumanParameterLevelMaster) null;
    }

    [Token(Token = "0x6005069")]
    [Address(RVA = "0x33060F4", Offset = "0x33060F4", VA = "0x33060F4")]
    private void LoadStoryHumanParameterLevelDefault()
    {
    }

    [Token(Token = "0x600506A")]
    [Address(RVA = "0x330615C", Offset = "0x330615C", VA = "0x330615C")]
    public StoryHumanParameterMaster LoadStoryHumanParameter(string path)
    {
      return (StoryHumanParameterMaster) null;
    }

    [Token(Token = "0x600506B")]
    [Address(RVA = "0x33061B4", Offset = "0x33061B4", VA = "0x33061B4")]
    private void LoadStoryHumanParameterDefault()
    {
    }

    [Token(Token = "0x600506C")]
    [Address(RVA = "0x330621C", Offset = "0x330621C", VA = "0x330621C")]
    public StoryMainQuestSequenceRouteMaster LoadStoryMainQuestSequenceRoute(string path)
    {
      return (StoryMainQuestSequenceRouteMaster) null;
    }

    [Token(Token = "0x600506D")]
    [Address(RVA = "0x3306274", Offset = "0x3306274", VA = "0x3306274")]
    private void LoadStoryMainQuestSequenceRouteDefault()
    {
    }

    [Token(Token = "0x600506E")]
    [Address(RVA = "0x33062DC", Offset = "0x33062DC", VA = "0x33062DC")]
    public StoryNotifyMaster LoadStoryNotify(string path) => (StoryNotifyMaster) null;

    [Token(Token = "0x600506F")]
    [Address(RVA = "0x3306334", Offset = "0x3306334", VA = "0x3306334")]
    private void LoadStoryNotifyDefault()
    {
    }

    [Token(Token = "0x6005070")]
    [Address(RVA = "0x330639C", Offset = "0x330639C", VA = "0x330639C")]
    public StoryPointIdentifierMaster LoadStoryPointIdentifier(string path)
    {
      return (StoryPointIdentifierMaster) null;
    }

    [Token(Token = "0x6005071")]
    [Address(RVA = "0x33063F4", Offset = "0x33063F4", VA = "0x33063F4")]
    private void LoadStoryPointIdentifierDefault()
    {
    }

    [Token(Token = "0x6005072")]
    [Address(RVA = "0x330645C", Offset = "0x330645C", VA = "0x330645C")]
    public StoryRouteMaster LoadStoryRoute(string path) => (StoryRouteMaster) null;

    [Token(Token = "0x6005073")]
    [Address(RVA = "0x33064B4", Offset = "0x33064B4", VA = "0x33064B4")]
    private void LoadStoryRouteDefault()
    {
    }

    [Token(Token = "0x6005074")]
    [Address(RVA = "0x330651C", Offset = "0x330651C", VA = "0x330651C")]
    public StoryScenarioQuestMaster LoadStoryScenarioQuest(string path)
    {
      return (StoryScenarioQuestMaster) null;
    }

    [Token(Token = "0x6005075")]
    [Address(RVA = "0x3306574", Offset = "0x3306574", VA = "0x3306574")]
    private void LoadStoryScenarioQuestDefault()
    {
    }

    [Token(Token = "0x6005076")]
    [Address(RVA = "0x33065DC", Offset = "0x33065DC", VA = "0x33065DC")]
    public StoryTaskFlagMaster LoadStoryTaskFlag(string path) => (StoryTaskFlagMaster) null;

    [Token(Token = "0x6005077")]
    [Address(RVA = "0x3306634", Offset = "0x3306634", VA = "0x3306634")]
    private void LoadStoryTaskFlagDefault()
    {
    }

    [Token(Token = "0x6005078")]
    [Address(RVA = "0x330669C", Offset = "0x330669C", VA = "0x330669C")]
    public StoryTimeSlotGroupMaster LoadStoryTimeSlotGroup(string path)
    {
      return (StoryTimeSlotGroupMaster) null;
    }

    [Token(Token = "0x6005079")]
    [Address(RVA = "0x33066F4", Offset = "0x33066F4", VA = "0x33066F4")]
    private void LoadStoryTimeSlotGroupDefault()
    {
    }

    [Token(Token = "0x600507A")]
    [Address(RVA = "0x330675C", Offset = "0x330675C", VA = "0x330675C")]
    public StoryTimeSlotMaster LoadStoryTimeSlot(string path) => (StoryTimeSlotMaster) null;

    [Token(Token = "0x600507B")]
    [Address(RVA = "0x33067B4", Offset = "0x33067B4", VA = "0x33067B4")]
    private void LoadStoryTimeSlotDefault()
    {
    }

    [Token(Token = "0x600507C")]
    [Address(RVA = "0x330681C", Offset = "0x330681C", VA = "0x330681C")]
    public StoryWeatherMaster LoadStoryWeather(string path) => (StoryWeatherMaster) null;

    [Token(Token = "0x600507D")]
    [Address(RVA = "0x3306874", Offset = "0x3306874", VA = "0x3306874")]
    private void LoadStoryWeatherDefault()
    {
    }

    [Token(Token = "0x600507E")]
    [Address(RVA = "0x33068DC", Offset = "0x33068DC", VA = "0x33068DC")]
    public StoryWeeklyMaster LoadStoryWeekly(string path) => (StoryWeeklyMaster) null;

    [Token(Token = "0x600507F")]
    [Address(RVA = "0x3306934", Offset = "0x3306934", VA = "0x3306934")]
    private void LoadStoryWeeklyDefault()
    {
    }

    [Token(Token = "0x6005080")]
    [Address(RVA = "0x330699C", Offset = "0x330699C", VA = "0x330699C")]
    public StorySubquestCycleTypeMaster LoadStorySubquestCycleType(string path)
    {
      return (StorySubquestCycleTypeMaster) null;
    }

    [Token(Token = "0x6005081")]
    [Address(RVA = "0x33069F4", Offset = "0x33069F4", VA = "0x33069F4")]
    private void LoadStorySubquestCycleTypeDefault()
    {
    }

    [Token(Token = "0x6005082")]
    [Address(RVA = "0x3306A5C", Offset = "0x3306A5C", VA = "0x3306A5C")]
    public StorySubquestFirstPositionMaster LoadStorySubquestFirstPosition(string path)
    {
      return (StorySubquestFirstPositionMaster) null;
    }

    [Token(Token = "0x6005083")]
    [Address(RVA = "0x3306AB4", Offset = "0x3306AB4", VA = "0x3306AB4")]
    private void LoadStorySubquestFirstPositionDefault()
    {
    }

    [Token(Token = "0x6005084")]
    [Address(RVA = "0x3306B1C", Offset = "0x3306B1C", VA = "0x3306B1C")]
    public StorySubquestResetItemSetMaster LoadStorySubquestResetItemSet(string path)
    {
      return (StorySubquestResetItemSetMaster) null;
    }

    [Token(Token = "0x6005085")]
    [Address(RVA = "0x3306B74", Offset = "0x3306B74", VA = "0x3306B74")]
    private void LoadStorySubquestResetItemSetDefault()
    {
    }

    [Token(Token = "0x6005086")]
    [Address(RVA = "0x3306BDC", Offset = "0x3306BDC", VA = "0x3306BDC")]
    public StorySubquestRewardPaymentMaster LoadStorySubquestRewardPayment(string path)
    {
      return (StorySubquestRewardPaymentMaster) null;
    }

    [Token(Token = "0x6005087")]
    [Address(RVA = "0x3306C34", Offset = "0x3306C34", VA = "0x3306C34")]
    private void LoadStorySubquestRewardPaymentDefault()
    {
    }

    [Token(Token = "0x6005088")]
    [Address(RVA = "0x3306C9C", Offset = "0x3306C9C", VA = "0x3306C9C")]
    public StorySubquestRewardSetMaster LoadStorySubquestRewardSet(string path)
    {
      return (StorySubquestRewardSetMaster) null;
    }

    [Token(Token = "0x6005089")]
    [Address(RVA = "0x3306CF4", Offset = "0x3306CF4", VA = "0x3306CF4")]
    private void LoadStorySubquestRewardSetDefault()
    {
    }

    [Token(Token = "0x600508A")]
    [Address(RVA = "0x3306D5C", Offset = "0x3306D5C", VA = "0x3306D5C")]
    public StorySubquestRewardsMaster LoadStorySubquestRewards(string path)
    {
      return (StorySubquestRewardsMaster) null;
    }

    [Token(Token = "0x600508B")]
    [Address(RVA = "0x3306DB4", Offset = "0x3306DB4", VA = "0x3306DB4")]
    private void LoadStorySubquestRewardsDefault()
    {
    }

    [Token(Token = "0x600508C")]
    [Address(RVA = "0x3306E1C", Offset = "0x3306E1C", VA = "0x3306E1C")]
    public StorySubquestMaster LoadStorySubquest(string path) => (StorySubquestMaster) null;

    [Token(Token = "0x600508D")]
    [Address(RVA = "0x3306E74", Offset = "0x3306E74", VA = "0x3306E74")]
    private void LoadStorySubquestDefault()
    {
    }

    [Token(Token = "0x600508E")]
    [Address(RVA = "0x3306EDC", Offset = "0x3306EDC", VA = "0x3306EDC")]
    public StorySubquestTaskFlagMaster LoadStorySubquestTaskFlag(string path)
    {
      return (StorySubquestTaskFlagMaster) null;
    }

    [Token(Token = "0x600508F")]
    [Address(RVA = "0x3306F34", Offset = "0x3306F34", VA = "0x3306F34")]
    private void LoadStorySubquestTaskFlagDefault()
    {
    }

    [Token(Token = "0x6005090")]
    [Address(RVA = "0x3306F9C", Offset = "0x3306F9C", VA = "0x3306F9C")]
    public StorySubquestTaskMaster LoadStorySubquestTask(string path)
    {
      return (StorySubquestTaskMaster) null;
    }

    [Token(Token = "0x6005091")]
    [Address(RVA = "0x3306FF4", Offset = "0x3306FF4", VA = "0x3306FF4")]
    private void LoadStorySubquestTaskDefault()
    {
    }

    [Token(Token = "0x6005092")]
    [Address(RVA = "0x330705C", Offset = "0x330705C", VA = "0x330705C")]
    public StorySubquestTaskTextMaster LoadStorySubquestTaskText(string path)
    {
      return (StorySubquestTaskTextMaster) null;
    }

    [Token(Token = "0x6005093")]
    [Address(RVA = "0x33070B4", Offset = "0x33070B4", VA = "0x33070B4")]
    private void LoadStorySubquestTaskTextDefault()
    {
    }

    [Token(Token = "0x6005094")]
    [Address(RVA = "0x330711C", Offset = "0x330711C", VA = "0x330711C")]
    public StorySubquestTaskTypeMaster LoadStorySubquestTaskType(string path)
    {
      return (StorySubquestTaskTypeMaster) null;
    }

    [Token(Token = "0x6005095")]
    [Address(RVA = "0x3307174", Offset = "0x3307174", VA = "0x3307174")]
    private void LoadStorySubquestTaskTypeDefault()
    {
    }

    [Token(Token = "0x6005096")]
    [Address(RVA = "0x33071DC", Offset = "0x33071DC", VA = "0x33071DC")]
    public TutorialPageMaster LoadTutorialPage(string path) => (TutorialPageMaster) null;

    [Token(Token = "0x6005097")]
    [Address(RVA = "0x3307234", Offset = "0x3307234", VA = "0x3307234")]
    private void LoadTutorialPageDefault()
    {
    }

    [Token(Token = "0x6005098")]
    [Address(RVA = "0x330729C", Offset = "0x330729C", VA = "0x330729C")]
    public AbilityBoardBoardListFormMaster LoadAbilityBoardBoardListForm(string path)
    {
      return (AbilityBoardBoardListFormMaster) null;
    }

    [Token(Token = "0x6005099")]
    [Address(RVA = "0x33072F4", Offset = "0x33072F4", VA = "0x33072F4")]
    private void LoadAbilityBoardBoardListFormDefault()
    {
    }

    [Token(Token = "0x600509A")]
    [Address(RVA = "0x330735C", Offset = "0x330735C", VA = "0x330735C")]
    public AbilityBoardBoardListSettingMaster LoadAbilityBoardBoardListSetting(string path)
    {
      return (AbilityBoardBoardListSettingMaster) null;
    }

    [Token(Token = "0x600509B")]
    [Address(RVA = "0x33073B4", Offset = "0x33073B4", VA = "0x33073B4")]
    private void LoadAbilityBoardBoardListSettingDefault()
    {
    }

    [Token(Token = "0x600509C")]
    [Address(RVA = "0x330741C", Offset = "0x330741C", VA = "0x330741C")]
    public AbilityBoardBoardListMaster LoadAbilityBoardBoardList(string path)
    {
      return (AbilityBoardBoardListMaster) null;
    }

    [Token(Token = "0x600509D")]
    [Address(RVA = "0x3307474", Offset = "0x3307474", VA = "0x3307474")]
    private void LoadAbilityBoardBoardListDefault()
    {
    }

    [Token(Token = "0x600509E")]
    [Address(RVA = "0x33074DC", Offset = "0x33074DC", VA = "0x33074DC")]
    public AbilityBoardBoardSettingMaster LoadAbilityBoardBoardSetting(string path)
    {
      return (AbilityBoardBoardSettingMaster) null;
    }

    [Token(Token = "0x600509F")]
    [Address(RVA = "0x3307534", Offset = "0x3307534", VA = "0x3307534")]
    private void LoadAbilityBoardBoardSettingDefault()
    {
    }

    [Token(Token = "0x60050A0")]
    [Address(RVA = "0x330759C", Offset = "0x330759C", VA = "0x330759C")]
    public AbilityBoardCompleteBonusMaster LoadAbilityBoardCompleteBonus(string path)
    {
      return (AbilityBoardCompleteBonusMaster) null;
    }

    [Token(Token = "0x60050A1")]
    [Address(RVA = "0x33075F4", Offset = "0x33075F4", VA = "0x33075F4")]
    private void LoadAbilityBoardCompleteBonusDefault()
    {
    }

    [Token(Token = "0x60050A2")]
    [Address(RVA = "0x330765C", Offset = "0x330765C", VA = "0x330765C")]
    public AbilityBoardConsumeAllocationMaster LoadAbilityBoardConsumeAllocation(string path)
    {
      return (AbilityBoardConsumeAllocationMaster) null;
    }

    [Token(Token = "0x60050A3")]
    [Address(RVA = "0x33076B4", Offset = "0x33076B4", VA = "0x33076B4")]
    private void LoadAbilityBoardConsumeAllocationDefault()
    {
    }

    [Token(Token = "0x60050A4")]
    [Address(RVA = "0x330771C", Offset = "0x330771C", VA = "0x330771C")]
    public AbilityBoardConsumeGroupMaster LoadAbilityBoardConsumeGroup(string path)
    {
      return (AbilityBoardConsumeGroupMaster) null;
    }

    [Token(Token = "0x60050A5")]
    [Address(RVA = "0x3307774", Offset = "0x3307774", VA = "0x3307774")]
    private void LoadAbilityBoardConsumeGroupDefault()
    {
    }

    [Token(Token = "0x60050A6")]
    [Address(RVA = "0x33077DC", Offset = "0x33077DC", VA = "0x33077DC")]
    public AbilityBoardConsumeItemMaster LoadAbilityBoardConsumeItem(string path)
    {
      return (AbilityBoardConsumeItemMaster) null;
    }

    [Token(Token = "0x60050A7")]
    [Address(RVA = "0x3307834", Offset = "0x3307834", VA = "0x3307834")]
    private void LoadAbilityBoardConsumeItemDefault()
    {
    }

    [Token(Token = "0x60050A8")]
    [Address(RVA = "0x330789C", Offset = "0x330789C", VA = "0x330789C")]
    public AbilityboardCustomACostSettingMaster LoadAbilityboardCustomACostSetting(string path)
    {
      return (AbilityboardCustomACostSettingMaster) null;
    }

    [Token(Token = "0x60050A9")]
    [Address(RVA = "0x33078F4", Offset = "0x33078F4", VA = "0x33078F4")]
    private void LoadAbilityboardCustomACostSettingDefault()
    {
    }

    [Token(Token = "0x60050AA")]
    [Address(RVA = "0x330795C", Offset = "0x330795C", VA = "0x330795C")]
    public AbilityboardCustomAFrameMaster LoadAbilityboardCustomAFrame(string path)
    {
      return (AbilityboardCustomAFrameMaster) null;
    }

    [Token(Token = "0x60050AB")]
    [Address(RVA = "0x33079B4", Offset = "0x33079B4", VA = "0x33079B4")]
    private void LoadAbilityboardCustomAFrameDefault()
    {
    }

    [Token(Token = "0x60050AC")]
    [Address(RVA = "0x3307A1C", Offset = "0x3307A1C", VA = "0x3307A1C")]
    public AbilityboardCustomANodeMaster LoadAbilityboardCustomANode(string path)
    {
      return (AbilityboardCustomANodeMaster) null;
    }

    [Token(Token = "0x60050AD")]
    [Address(RVA = "0x3307A74", Offset = "0x3307A74", VA = "0x3307A74")]
    private void LoadAbilityboardCustomANodeDefault()
    {
    }

    [Token(Token = "0x60050AE")]
    [Address(RVA = "0x3307ADC", Offset = "0x3307ADC", VA = "0x3307ADC")]
    public AbilityboardCustomASettingMaster LoadAbilityboardCustomASetting(string path)
    {
      return (AbilityboardCustomASettingMaster) null;
    }

    [Token(Token = "0x60050AF")]
    [Address(RVA = "0x3307B34", Offset = "0x3307B34", VA = "0x3307B34")]
    private void LoadAbilityboardCustomASettingDefault()
    {
    }

    [Token(Token = "0x60050B0")]
    [Address(RVA = "0x3307B9C", Offset = "0x3307B9C", VA = "0x3307B9C")]
    public AbilityboardCustomBNodeMaster LoadAbilityboardCustomBNode(string path)
    {
      return (AbilityboardCustomBNodeMaster) null;
    }

    [Token(Token = "0x60050B1")]
    [Address(RVA = "0x3307BF4", Offset = "0x3307BF4", VA = "0x3307BF4")]
    private void LoadAbilityboardCustomBNodeDefault()
    {
    }

    [Token(Token = "0x60050B2")]
    [Address(RVA = "0x3307C5C", Offset = "0x3307C5C", VA = "0x3307C5C")]
    public AbilityBoardCustomPatternSettingMaster LoadAbilityBoardCustomPatternSetting(string path)
    {
      return (AbilityBoardCustomPatternSettingMaster) null;
    }

    [Token(Token = "0x60050B3")]
    [Address(RVA = "0x3307CB4", Offset = "0x3307CB4", VA = "0x3307CB4")]
    private void LoadAbilityBoardCustomPatternSettingDefault()
    {
    }

    [Token(Token = "0x60050B4")]
    [Address(RVA = "0x3307D1C", Offset = "0x3307D1C", VA = "0x3307D1C")]
    public AbilityBoardCustomPatternMaster LoadAbilityBoardCustomPattern(string path)
    {
      return (AbilityBoardCustomPatternMaster) null;
    }

    [Token(Token = "0x60050B5")]
    [Address(RVA = "0x3307D74", Offset = "0x3307D74", VA = "0x3307D74")]
    private void LoadAbilityBoardCustomPatternDefault()
    {
    }

    [Token(Token = "0x60050B6")]
    [Address(RVA = "0x3307DDC", Offset = "0x3307DDC", VA = "0x3307DDC")]
    public AbilityBoardFormMaster LoadAbilityBoardForm(string path)
    {
      return (AbilityBoardFormMaster) null;
    }

    [Token(Token = "0x60050B7")]
    [Address(RVA = "0x3307E34", Offset = "0x3307E34", VA = "0x3307E34")]
    private void LoadAbilityBoardFormDefault()
    {
    }

    [Token(Token = "0x60050B8")]
    [Address(RVA = "0x3307E9C", Offset = "0x3307E9C", VA = "0x3307E9C")]
    public AbilityBoardLotteryResultTypeAllocationMaster LoadAbilityBoardLotteryResultTypeAllocation(
      string path)
    {
      return (AbilityBoardLotteryResultTypeAllocationMaster) null;
    }

    [Token(Token = "0x60050B9")]
    [Address(RVA = "0x3307EF4", Offset = "0x3307EF4", VA = "0x3307EF4")]
    private void LoadAbilityBoardLotteryResultTypeAllocationDefault()
    {
    }

    [Token(Token = "0x60050BA")]
    [Address(RVA = "0x3307F5C", Offset = "0x3307F5C", VA = "0x3307F5C")]
    public AbilityBoardLotteryResultTypeMaster LoadAbilityBoardLotteryResultType(string path)
    {
      return (AbilityBoardLotteryResultTypeMaster) null;
    }

    [Token(Token = "0x60050BB")]
    [Address(RVA = "0x3307FB4", Offset = "0x3307FB4", VA = "0x3307FB4")]
    private void LoadAbilityBoardLotteryResultTypeDefault()
    {
    }

    [Token(Token = "0x60050BC")]
    [Address(RVA = "0x330801C", Offset = "0x330801C", VA = "0x330801C")]
    public AbilityBoardNodeIconMaster LoadAbilityBoardNodeIcon(string path)
    {
      return (AbilityBoardNodeIconMaster) null;
    }

    [Token(Token = "0x60050BD")]
    [Address(RVA = "0x3308074", Offset = "0x3308074", VA = "0x3308074")]
    private void LoadAbilityBoardNodeIconDefault()
    {
    }

    [Token(Token = "0x60050BE")]
    [Address(RVA = "0x33080DC", Offset = "0x33080DC", VA = "0x33080DC")]
    public AbilityBoardNodeMaster LoadAbilityBoardNode(string path)
    {
      return (AbilityBoardNodeMaster) null;
    }

    [Token(Token = "0x60050BF")]
    [Address(RVA = "0x3308134", Offset = "0x3308134", VA = "0x3308134")]
    private void LoadAbilityBoardNodeDefault()
    {
    }

    [Token(Token = "0x60050C0")]
    [Address(RVA = "0x330819C", Offset = "0x330819C", VA = "0x330819C")]
    public AbilityBoardRewardAllocationMaster LoadAbilityBoardRewardAllocation(string path)
    {
      return (AbilityBoardRewardAllocationMaster) null;
    }

    [Token(Token = "0x60050C1")]
    [Address(RVA = "0x33081F4", Offset = "0x33081F4", VA = "0x33081F4")]
    private void LoadAbilityBoardRewardAllocationDefault()
    {
    }

    [Token(Token = "0x60050C2")]
    [Address(RVA = "0x330825C", Offset = "0x330825C", VA = "0x330825C")]
    public AbilityBoardRewardGroupMaster LoadAbilityBoardRewardGroup(string path)
    {
      return (AbilityBoardRewardGroupMaster) null;
    }

    [Token(Token = "0x60050C3")]
    [Address(RVA = "0x33082B4", Offset = "0x33082B4", VA = "0x33082B4")]
    private void LoadAbilityBoardRewardGroupDefault()
    {
    }

    [Token(Token = "0x60050C4")]
    [Address(RVA = "0x330831C", Offset = "0x330831C", VA = "0x330831C")]
    public AbilityBoardRewardPatternMaster LoadAbilityBoardRewardPattern(string path)
    {
      return (AbilityBoardRewardPatternMaster) null;
    }

    [Token(Token = "0x60050C5")]
    [Address(RVA = "0x3308374", Offset = "0x3308374", VA = "0x3308374")]
    private void LoadAbilityBoardRewardPatternDefault()
    {
    }

    [Token(Token = "0x60050C6")]
    [Address(RVA = "0x33083DC", Offset = "0x33083DC", VA = "0x33083DC")]
    public AbilityBoardStyleSettingMaster LoadAbilityBoardStyleSetting(string path)
    {
      return (AbilityBoardStyleSettingMaster) null;
    }

    [Token(Token = "0x60050C7")]
    [Address(RVA = "0x3308434", Offset = "0x3308434", VA = "0x3308434")]
    private void LoadAbilityBoardStyleSettingDefault()
    {
    }

    [Token(Token = "0x60050C8")]
    [Address(RVA = "0x330849C", Offset = "0x330849C", VA = "0x330849C")]
    public AbilityBoardMaster LoadAbilityBoard(string path) => (AbilityBoardMaster) null;

    [Token(Token = "0x60050C9")]
    [Address(RVA = "0x33084F4", Offset = "0x33084F4", VA = "0x33084F4")]
    private void LoadAbilityBoardDefault()
    {
    }

    [Token(Token = "0x60050CA")]
    [Address(RVA = "0x330855C", Offset = "0x330855C", VA = "0x330855C")]
    public CharacterConstMaster LoadCharacterConst(string path) => (CharacterConstMaster) null;

    [Token(Token = "0x60050CB")]
    [Address(RVA = "0x33085B4", Offset = "0x33085B4", VA = "0x33085B4")]
    private void LoadCharacterConstDefault()
    {
    }

    [Token(Token = "0x60050CC")]
    [Address(RVA = "0x330861C", Offset = "0x330861C", VA = "0x330861C")]
    public CharacterInfluenceRateMaster LoadCharacterInfluenceRate(string path)
    {
      return (CharacterInfluenceRateMaster) null;
    }

    [Token(Token = "0x60050CD")]
    [Address(RVA = "0x3308674", Offset = "0x3308674", VA = "0x3308674")]
    private void LoadCharacterInfluenceRateDefault()
    {
    }

    [Token(Token = "0x60050CE")]
    [Address(RVA = "0x33086DC", Offset = "0x33086DC", VA = "0x33086DC")]
    public CharacterLimitReleaseDetailMaster LoadCharacterLimitReleaseDetail(string path)
    {
      return (CharacterLimitReleaseDetailMaster) null;
    }

    [Token(Token = "0x60050CF")]
    [Address(RVA = "0x3308734", Offset = "0x3308734", VA = "0x3308734")]
    private void LoadCharacterLimitReleaseDetailDefault()
    {
    }

    [Token(Token = "0x60050D0")]
    [Address(RVA = "0x330879C", Offset = "0x330879C", VA = "0x330879C")]
    public CharacterMaster LoadCharacter(string path) => (CharacterMaster) null;

    [Token(Token = "0x60050D1")]
    [Address(RVA = "0x33087F4", Offset = "0x33087F4", VA = "0x33087F4")]
    private void LoadCharacterDefault()
    {
    }

    [Token(Token = "0x60050D2")]
    [Address(RVA = "0x330885C", Offset = "0x330885C", VA = "0x330885C")]
    public CommunicationSkillMaster LoadCommunicationSkill(string path)
    {
      return (CommunicationSkillMaster) null;
    }

    [Token(Token = "0x60050D3")]
    [Address(RVA = "0x33088B4", Offset = "0x33088B4", VA = "0x33088B4")]
    private void LoadCommunicationSkillDefault()
    {
    }

    [Token(Token = "0x60050D4")]
    [Address(RVA = "0x330891C", Offset = "0x330891C", VA = "0x330891C")]
    public LpRecoveryPaymentMaster LoadLpRecoveryPayment(string path)
    {
      return (LpRecoveryPaymentMaster) null;
    }

    [Token(Token = "0x60050D5")]
    [Address(RVA = "0x3308974", Offset = "0x3308974", VA = "0x3308974")]
    private void LoadLpRecoveryPaymentDefault()
    {
    }

    [Token(Token = "0x60050D6")]
    [Address(RVA = "0x33089DC", Offset = "0x33089DC", VA = "0x33089DC")]
    public SupportRankMaster LoadSupportRank(string path) => (SupportRankMaster) null;

    [Token(Token = "0x60050D7")]
    [Address(RVA = "0x3308A34", Offset = "0x3308A34", VA = "0x3308A34")]
    private void LoadSupportRankDefault()
    {
    }

    [Token(Token = "0x60050D8")]
    [Address(RVA = "0x3308A9C", Offset = "0x3308A9C", VA = "0x3308A9C")]
    public AccessoryClassificationGroupDescriptionMaster LoadAccessoryClassificationGroupDescription(
      string path)
    {
      return (AccessoryClassificationGroupDescriptionMaster) null;
    }

    [Token(Token = "0x60050D9")]
    [Address(RVA = "0x3308AF4", Offset = "0x3308AF4", VA = "0x3308AF4")]
    private void LoadAccessoryClassificationGroupDescriptionDefault()
    {
    }

    [Token(Token = "0x60050DA")]
    [Address(RVA = "0x3308B5C", Offset = "0x3308B5C", VA = "0x3308B5C")]
    public AccessoryClassificationGroupMaster LoadAccessoryClassificationGroup(string path)
    {
      return (AccessoryClassificationGroupMaster) null;
    }

    [Token(Token = "0x60050DB")]
    [Address(RVA = "0x3308BB4", Offset = "0x3308BB4", VA = "0x3308BB4")]
    private void LoadAccessoryClassificationGroupDefault()
    {
    }

    [Token(Token = "0x60050DC")]
    [Address(RVA = "0x3308C1C", Offset = "0x3308C1C", VA = "0x3308C1C")]
    public ArmorMaster LoadArmor(string path) => (ArmorMaster) null;

    [Token(Token = "0x60050DD")]
    [Address(RVA = "0x3308C74", Offset = "0x3308C74", VA = "0x3308C74")]
    private void LoadArmorDefault()
    {
    }

    [Token(Token = "0x60050DE")]
    [Address(RVA = "0x3308CDC", Offset = "0x3308CDC", VA = "0x3308CDC")]
    public ArmyMaster LoadArmy(string path) => (ArmyMaster) null;

    [Token(Token = "0x60050DF")]
    [Address(RVA = "0x3308D34", Offset = "0x3308D34", VA = "0x3308D34")]
    private void LoadArmyDefault()
    {
    }

    [Token(Token = "0x60050E0")]
    [Address(RVA = "0x3308D9C", Offset = "0x3308D9C", VA = "0x3308D9C")]
    public ClassMaster LoadClass(string path) => (ClassMaster) null;

    [Token(Token = "0x60050E1")]
    [Address(RVA = "0x3308DF4", Offset = "0x3308DF4", VA = "0x3308DF4")]
    private void LoadClassDefault()
    {
    }

    [Token(Token = "0x60050E2")]
    [Address(RVA = "0x3308E5C", Offset = "0x3308E5C", VA = "0x3308E5C")]
    public MoveMaster LoadMove(string path) => (MoveMaster) null;

    [Token(Token = "0x60050E3")]
    [Address(RVA = "0x3308EB4", Offset = "0x3308EB4", VA = "0x3308EB4")]
    private void LoadMoveDefault()
    {
    }

    [Token(Token = "0x60050E4")]
    [Address(RVA = "0x3308F1C", Offset = "0x3308F1C", VA = "0x3308F1C")]
    public SubEquipmentClassificationGroupDescriptionMaster LoadSubEquipmentClassificationGroupDescription(
      string path)
    {
      return (SubEquipmentClassificationGroupDescriptionMaster) null;
    }

    [Token(Token = "0x60050E5")]
    [Address(RVA = "0x3308F74", Offset = "0x3308F74", VA = "0x3308F74")]
    private void LoadSubEquipmentClassificationGroupDescriptionDefault()
    {
    }

    [Token(Token = "0x60050E6")]
    [Address(RVA = "0x3308FDC", Offset = "0x3308FDC", VA = "0x3308FDC")]
    public SubEquipmentClassificationGroupMaster LoadSubEquipmentClassificationGroup(string path)
    {
      return (SubEquipmentClassificationGroupMaster) null;
    }

    [Token(Token = "0x60050E7")]
    [Address(RVA = "0x3309034", Offset = "0x3309034", VA = "0x3309034")]
    private void LoadSubEquipmentClassificationGroupDefault()
    {
    }

    [Token(Token = "0x60050E8")]
    [Address(RVA = "0x330909C", Offset = "0x330909C", VA = "0x330909C")]
    public WeaponProficiencyDescriptionMaster LoadWeaponProficiencyDescription(string path)
    {
      return (WeaponProficiencyDescriptionMaster) null;
    }

    [Token(Token = "0x60050E9")]
    [Address(RVA = "0x33090F4", Offset = "0x33090F4", VA = "0x33090F4")]
    private void LoadWeaponProficiencyDescriptionDefault()
    {
    }

    [Token(Token = "0x60050EA")]
    [Address(RVA = "0x330915C", Offset = "0x330915C", VA = "0x330915C")]
    public WeaponProficiencyLevelMaster LoadWeaponProficiencyLevel(string path)
    {
      return (WeaponProficiencyLevelMaster) null;
    }

    [Token(Token = "0x60050EB")]
    [Address(RVA = "0x33091B4", Offset = "0x33091B4", VA = "0x33091B4")]
    private void LoadWeaponProficiencyLevelDefault()
    {
    }

    [Token(Token = "0x60050EC")]
    [Address(RVA = "0x330921C", Offset = "0x330921C", VA = "0x330921C")]
    public WeaponProficiencyMaster LoadWeaponProficiency(string path)
    {
      return (WeaponProficiencyMaster) null;
    }

    [Token(Token = "0x60050ED")]
    [Address(RVA = "0x3309274", Offset = "0x3309274", VA = "0x3309274")]
    private void LoadWeaponProficiencyDefault()
    {
    }

    [Token(Token = "0x60050EE")]
    [Address(RVA = "0x33092DC", Offset = "0x33092DC", VA = "0x33092DC")]
    public EmblemMaster LoadEmblem(string path) => (EmblemMaster) null;

    [Token(Token = "0x60050EF")]
    [Address(RVA = "0x3309334", Offset = "0x3309334", VA = "0x3309334")]
    private void LoadEmblemDefault()
    {
    }

    [Token(Token = "0x60050F0")]
    [Address(RVA = "0x330939C", Offset = "0x330939C", VA = "0x330939C")]
    public LevelUpParameterMaster LoadLevelUpParameter(string path)
    {
      return (LevelUpParameterMaster) null;
    }

    [Token(Token = "0x60050F1")]
    [Address(RVA = "0x33093F4", Offset = "0x33093F4", VA = "0x33093F4")]
    private void LoadLevelUpParameterDefault()
    {
    }

    [Token(Token = "0x60050F2")]
    [Address(RVA = "0x330945C", Offset = "0x330945C", VA = "0x330945C")]
    public StockCounterMaster LoadStockCounter(string path) => (StockCounterMaster) null;

    [Token(Token = "0x60050F3")]
    [Address(RVA = "0x33094B4", Offset = "0x33094B4", VA = "0x33094B4")]
    private void LoadStockCounterDefault()
    {
    }

    [Token(Token = "0x60050F4")]
    [Address(RVA = "0x330951C", Offset = "0x330951C", VA = "0x330951C")]
    public CharacterVoiceMaster LoadCharacterVoice(string path) => (CharacterVoiceMaster) null;

    [Token(Token = "0x60050F5")]
    [Address(RVA = "0x3309574", Offset = "0x3309574", VA = "0x3309574")]
    private void LoadCharacterVoiceDefault()
    {
    }

    [Token(Token = "0x60050F6")]
    [Address(RVA = "0x33095DC", Offset = "0x33095DC", VA = "0x33095DC")]
    public IllustratorMaster LoadIllustrator(string path) => (IllustratorMaster) null;

    [Token(Token = "0x60050F7")]
    [Address(RVA = "0x3309634", Offset = "0x3309634", VA = "0x3309634")]
    private void LoadIllustratorDefault()
    {
    }

    [Token(Token = "0x60050F8")]
    [Address(RVA = "0x330969C", Offset = "0x330969C", VA = "0x330969C")]
    public OverrideResourceMaster LoadOverrideResource(string path)
    {
      return (OverrideResourceMaster) null;
    }

    [Token(Token = "0x60050F9")]
    [Address(RVA = "0x33096F4", Offset = "0x33096F4", VA = "0x33096F4")]
    private void LoadOverrideResourceDefault()
    {
    }

    [Token(Token = "0x60050FA")]
    [Address(RVA = "0x330975C", Offset = "0x330975C", VA = "0x330975C")]
    public RarityStyleMaster LoadRarityStyle(string path) => (RarityStyleMaster) null;

    [Token(Token = "0x60050FB")]
    [Address(RVA = "0x33097B4", Offset = "0x33097B4", VA = "0x33097B4")]
    private void LoadRarityStyleDefault()
    {
    }

    [Token(Token = "0x60050FC")]
    [Address(RVA = "0x330981C", Offset = "0x330981C", VA = "0x330981C")]
    public RarityUpMaster LoadRarityUp(string path) => (RarityUpMaster) null;

    [Token(Token = "0x60050FD")]
    [Address(RVA = "0x3309874", Offset = "0x3309874", VA = "0x3309874")]
    private void LoadRarityUpDefault()
    {
    }

    [Token(Token = "0x60050FE")]
    [Address(RVA = "0x33098DC", Offset = "0x33098DC", VA = "0x33098DC")]
    public ReincarnationBonusGroupMaster LoadReincarnationBonusGroup(string path)
    {
      return (ReincarnationBonusGroupMaster) null;
    }

    [Token(Token = "0x60050FF")]
    [Address(RVA = "0x3309934", Offset = "0x3309934", VA = "0x3309934")]
    private void LoadReincarnationBonusGroupDefault()
    {
    }

    [Token(Token = "0x6005100")]
    [Address(RVA = "0x330999C", Offset = "0x330999C", VA = "0x330999C")]
    public ReincarnationMaster LoadReincarnation(string path) => (ReincarnationMaster) null;

    [Token(Token = "0x6005101")]
    [Address(RVA = "0x33099F4", Offset = "0x33099F4", VA = "0x33099F4")]
    private void LoadReincarnationDefault()
    {
    }

    [Token(Token = "0x6005102")]
    [Address(RVA = "0x3309A5C", Offset = "0x3309A5C", VA = "0x3309A5C")]
    public StyleAwakeMaterialMaster LoadStyleAwakeMaterial(string path)
    {
      return (StyleAwakeMaterialMaster) null;
    }

    [Token(Token = "0x6005103")]
    [Address(RVA = "0x3309AB4", Offset = "0x3309AB4", VA = "0x3309AB4")]
    private void LoadStyleAwakeMaterialDefault()
    {
    }

    [Token(Token = "0x6005104")]
    [Address(RVA = "0x3309B1C", Offset = "0x3309B1C", VA = "0x3309B1C")]
    public StyleExpDescriptionMaster LoadStyleExpDescription(string path)
    {
      return (StyleExpDescriptionMaster) null;
    }

    [Token(Token = "0x6005105")]
    [Address(RVA = "0x3309B74", Offset = "0x3309B74", VA = "0x3309B74")]
    private void LoadStyleExpDescriptionDefault()
    {
    }

    [Token(Token = "0x6005106")]
    [Address(RVA = "0x3309BDC", Offset = "0x3309BDC", VA = "0x3309BDC")]
    public StyleExpMaster LoadStyleExp(string path) => (StyleExpMaster) null;

    [Token(Token = "0x6005107")]
    [Address(RVA = "0x3309C34", Offset = "0x3309C34", VA = "0x3309C34")]
    private void LoadStyleExpDefault()
    {
    }

    [Token(Token = "0x6005108")]
    [Address(RVA = "0x3309C9C", Offset = "0x3309C9C", VA = "0x3309C9C")]
    public StyleGroupDescriptionMaster LoadStyleGroupDescription(string path)
    {
      return (StyleGroupDescriptionMaster) null;
    }

    [Token(Token = "0x6005109")]
    [Address(RVA = "0x3309CF4", Offset = "0x3309CF4", VA = "0x3309CF4")]
    private void LoadStyleGroupDescriptionDefault()
    {
    }

    [Token(Token = "0x600510A")]
    [Address(RVA = "0x3309D5C", Offset = "0x3309D5C", VA = "0x3309D5C")]
    public StyleGroupMaster LoadStyleGroup(string path) => (StyleGroupMaster) null;

    [Token(Token = "0x600510B")]
    [Address(RVA = "0x3309DB4", Offset = "0x3309DB4", VA = "0x3309DB4")]
    private void LoadStyleGroupDefault()
    {
    }

    [Token(Token = "0x600510C")]
    [Address(RVA = "0x3309E1C", Offset = "0x3309E1C", VA = "0x3309E1C")]
    public StyleLevelUpValueMaster LoadStyleLevelUpValue(string path)
    {
      return (StyleLevelUpValueMaster) null;
    }

    [Token(Token = "0x600510D")]
    [Address(RVA = "0x3309E74", Offset = "0x3309E74", VA = "0x3309E74")]
    private void LoadStyleLevelUpValueDefault()
    {
    }

    [Token(Token = "0x600510E")]
    [Address(RVA = "0x3309EDC", Offset = "0x3309EDC", VA = "0x3309EDC")]
    public StyleSkillSettingMaster LoadStyleSkillSetting(string path)
    {
      return (StyleSkillSettingMaster) null;
    }

    [Token(Token = "0x600510F")]
    [Address(RVA = "0x3309F34", Offset = "0x3309F34", VA = "0x3309F34")]
    private void LoadStyleSkillSettingDefault()
    {
    }

    [Token(Token = "0x6005110")]
    [Address(RVA = "0x3309F9C", Offset = "0x3309F9C", VA = "0x3309F9C")]
    public StyleMaster LoadStyle(string path) => (StyleMaster) null;

    [Token(Token = "0x6005111")]
    [Address(RVA = "0x3309FF4", Offset = "0x3309FF4", VA = "0x3309FF4")]
    private void LoadStyleDefault()
    {
    }

    [Token(Token = "0x6005112")]
    [Address(RVA = "0x330A05C", Offset = "0x330A05C", VA = "0x330A05C")]
    public StyleTrainingRankConstMaster LoadStyleTrainingRankConst(string path)
    {
      return (StyleTrainingRankConstMaster) null;
    }

    [Token(Token = "0x6005113")]
    [Address(RVA = "0x330A0B4", Offset = "0x330A0B4", VA = "0x330A0B4")]
    private void LoadStyleTrainingRankConstDefault()
    {
    }

    [Token(Token = "0x6005114")]
    [Address(RVA = "0x330A11C", Offset = "0x330A11C", VA = "0x330A11C")]
    public StyleTrainingRankMaster LoadStyleTrainingRank(string path)
    {
      return (StyleTrainingRankMaster) null;
    }

    [Token(Token = "0x6005115")]
    [Address(RVA = "0x330A174", Offset = "0x330A174", VA = "0x330A174")]
    private void LoadStyleTrainingRankDefault()
    {
    }

    [Token(Token = "0x6005116")]
    [Address(RVA = "0x330A1DC", Offset = "0x330A1DC", VA = "0x330A1DC")]
    public StyleLimitBreakStatusMaster LoadStyleLimitBreakStatus(string path)
    {
      return (StyleLimitBreakStatusMaster) null;
    }

    [Token(Token = "0x6005117")]
    [Address(RVA = "0x330A234", Offset = "0x330A234", VA = "0x330A234")]
    private void LoadStyleLimitBreakStatusDefault()
    {
    }

    [Token(Token = "0x6005118")]
    [Address(RVA = "0x330A29C", Offset = "0x330A29C", VA = "0x330A29C")]
    public StylePararaLimitMaster LoadStylePararaLimit(string path)
    {
      return (StylePararaLimitMaster) null;
    }

    [Token(Token = "0x6005119")]
    [Address(RVA = "0x330A2F4", Offset = "0x330A2F4", VA = "0x330A2F4")]
    private void LoadStylePararaLimitDefault()
    {
    }

    [Token(Token = "0x600511A")]
    private TMaster ReadMasterData<TMaster, TMasterEntity>(TextAsset asset)
      where TMaster : BaseMaster<TMasterEntity>, new()
      where TMasterEntity : IMasterDataEntity, new()
    {
      return (TMaster) null;
    }

    [Token(Token = "0x600511B")]
    private void LoadMasterData<TMaster, TMasterEntity>(string name, ref TMaster master)
      where TMaster : BaseMaster<TMasterEntity>, new()
      where TMasterEntity : IMasterDataEntity, new()
    {
    }

    [Token(Token = "0x600511C")]
    private TMaster LoadMasterDataAssetBundle<TMaster, TMasterEntity>(string path)
      where TMaster : BaseMaster<TMasterEntity>, new()
      where TMasterEntity : IMasterDataEntity, new()
    {
      return (TMaster) null;
    }

    [Token(Token = "0x600511D")]
    private TMaster ReadMasterDataCSV<TMaster, TMasterEntity>(string path)
      where TMaster : BaseMaster<TMasterEntity>, new()
      where TMasterEntity : IMasterDataEntity, new()
    {
      return (TMaster) null;
    }

    [Token(Token = "0x600511E")]
    private TMaster LoadMasterDataPath<TMaster, TMasterEntity>(string path)
      where TMaster : BaseMaster<TMasterEntity>, new()
      where TMasterEntity : IMasterDataEntity, new()
    {
      return (TMaster) null;
    }

    [Token(Token = "0x17000B24")]
    public ItemSupplierSearcher ItemSupplierSearcher
    {
      [Token(Token = "0x600511F"), Address(RVA = "0x330A35C", Offset = "0x330A35C", VA = "0x330A35C")] get
      {
        return (ItemSupplierSearcher) null;
      }
    }

    [Token(Token = "0x6005120")]
    [Address(RVA = "0x330A364", Offset = "0x330A364", VA = "0x330A364")]
    public void ResetAll()
    {
    }

    [Token(Token = "0x6005121")]
    [Address(RVA = "0x330A470", Offset = "0x330A470", VA = "0x330A470")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6005122")]
    [Address(RVA = "0x330A48C", Offset = "0x330A48C", VA = "0x330A48C")]
    public static void ResetAllIfExists()
    {
    }

    [Token(Token = "0x6005123")]
    [Address(RVA = "0x330A574", Offset = "0x330A574", VA = "0x330A574")]
    public MasterDataManager()
    {
    }

    [Token(Token = "0x6005124")]
    [Address(RVA = "0x330A5F0", Offset = "0x330A5F0", VA = "0x330A5F0")]
    static MasterDataManager()
    {
    }
  }
}
