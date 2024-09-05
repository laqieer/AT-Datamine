// Decompiled with JetBrains decompiler
// Type: Battle.Asset.AssetNames
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;
using System.Text;

#nullable disable
namespace Battle.Asset
{
  [Token(Token = "0x20022BF")]
  public static class AssetNames
  {
    [Token(Token = "0x4009275")]
    public const string BattleUnitSimplePanelConfig = "BattleUnitSimplePanelConfig";
    [Token(Token = "0x4009276")]
    public const string AllysLifeGaugePrefab = "Ig_HPgauge001";
    [Token(Token = "0x4009277")]
    public const string FacilityStatusPrefab = "FacilityStatus";
    [Token(Token = "0x4009278")]
    public const string FieldUnitLstElementPrefab = "Container_Cell";
    [Token(Token = "0x4009279")]
    public const string DirectionGameStart = "Ig_GameStart";
    [Token(Token = "0x400927A")]
    public const string DirectionGameWin = "Ig_StageClear";
    [Token(Token = "0x400927B")]
    public const string DirectionGameLose = "Ig_StageFailed";
    [Token(Token = "0x400927C")]
    public const string DirectionArenaWin = "Ig_Win";
    [Token(Token = "0x400927D")]
    public const string DirectionArenaLose = "Ig_Lose";
    [Token(Token = "0x400927E")]
    public const string FierceCountPrefab = "Container_OnslaughtCount";
    [Token(Token = "0x400927F")]
    public const string TargetIconPrefab = "Container_Field_TargetUI";
    [Token(Token = "0x4009280")]
    public const string WorldSpaceUIRoot = "WorldSpaceUIRoot";
    [Token(Token = "0x4009281")]
    public const string SupportPointEffect = "Container_supportpoint";
    [Token(Token = "0x4009282")]
    public const string GridObjectPrefab = "GridBehaviour";
    [Token(Token = "0x4009283")]
    public const string GridPanelsPrefab = "GridPanelsMesh";
    [Token(Token = "0x4009284")]
    public const string GridCursorPrefab = "GridCursor";
    [Token(Token = "0x4009285")]
    public const string StageFaderPrefab = "StageFader";
    [Token(Token = "0x4009286")]
    public const string GridTexGrid = "Ig_Grid_Color005";
    [Token(Token = "0x4009287")]
    public const string GridTexMovable = "Ig_Grid_Color001";
    [Token(Token = "0x4009288")]
    public const string GridTexRoute = "Ig_Grid_Color003";
    [Token(Token = "0x4009289")]
    public const string GridTexPlayer = "Ig_Grid_Color006";
    [Token(Token = "0x400928A")]
    public const string GridTexEnemy = "Ig_Grid_Color002";
    [Token(Token = "0x400928B")]
    public const string GridTexAnotherForce = "Ig_Grid_Color004";
    [Token(Token = "0x400928C")]
    public const string CommonActiveSkillAuraEffect = "Ef_C_Cmn_Aura_CS01";
    [Token(Token = "0x400928D")]
    public const string EnemyCommonActiveSkillAuraEffect = "Ef_C_Cmn_EmyAura_CS01";
    [Token(Token = "0x400928E")]
    public const string EnemyFierceSkillAuraEffect = "Ef_C_Cmn_EmyAura_Fierce01";
    [Token(Token = "0x400928F")]
    public const string SingleSkillAuraEffect = "Ef_C_Cmn_Aura_SS01";
    [Token(Token = "0x4009290")]
    public const string StratagemSkillAuraEffect = "Ef_C_Cmn_Aura_KS01";
    [Token(Token = "0x4009291")]
    public const string OtherBuffLoopEffect = "Ef_C_Buf_StUp_Lop";
    [Token(Token = "0x4009292")]
    public const string BuffRaiseEffect = "Ef_C_Buf_StUp";
    [Token(Token = "0x4009293")]
    public const string BuffLoopEffect = "Ef_C_Buf_StUp_Lop";
    [Token(Token = "0x4009294")]
    public const string DebuffRaiseEffect = "Ef_C_Dbf_StDown";
    [Token(Token = "0x4009295")]
    public const string DebuffLoopEffect = "Ef_C_Dbf_StDown_Lop";
    [Token(Token = "0x4009296")]
    public const string CommonActiveSkillReachEffect = "Ef_C_Cmn_Hit_CS01";
    [Token(Token = "0x4009297")]
    public const string StratagemSkillReachEffect = "Ef_C_Cmn_Hit_KS01";
    [Token(Token = "0x4009298")]
    public const string SingleSkillReachEffect = "Ef_C_Cmn_Hit_SS01";
    [Token(Token = "0x4009299")]
    public const string CriticalHitEffect = "Ef_C_Cmn_N_Hit_Critical01";
    [Token(Token = "0x400929A")]
    public const string PlayerDyingEffect = "Ef_C_Cmn_Die01";
    [Token(Token = "0x400929B")]
    public const string EnemyDyingEffect = "Ef_C_Cmn_DieEmy01";
    [Token(Token = "0x400929C")]
    public const string BossDyingEffect = "Ef_C_Cmn_DieBos01";
    [Token(Token = "0x400929D")]
    public const string HealingEffect = "Ef_C_Buf_Heal01";
    [Token(Token = "0x400929E")]
    public const string DrainEffect = "Ef_C_Buf_Drain01";
    [Token(Token = "0x400929F")]
    public const string CureEffect = "Ef_C_Buf_Cure01";
    [Token(Token = "0x40092A0")]
    public const string BreakWeaponEffect = "Ef_C_Cmn_WepBreak01";
    [Token(Token = "0x40092A1")]
    public const string LostWeaponEffect = "Ef_C_Cmn_WepLost01";
    [Token(Token = "0x40092A2")]
    public const string DestinationLopEffect = "Ef_C_Cmn_Destination_Lop";
    [Token(Token = "0x40092A3")]
    public const string WinDestinationLopEffect = "Ef_C_Cmn_Destination_Lop_Win";
    [Token(Token = "0x40092A4")]
    public const string LoseDestinationLopEffect = "Ef_C_Cmn_Destination_Lop_Lose";
    [Token(Token = "0x40092A5")]
    public const string FierceAttackChargeEffect = "Ef_C_Bst_Standby01";
    [Token(Token = "0x40092A6")]
    public const string FierceAttackChargeLoopEffect = "Ef_C_Bst_Standby01_Lop";
    [Token(Token = "0x40092A7")]
    public const string BreakableCounterBarrierParticle = "Ef_C_Cmn_Barrier01_1_Lop";
    [Token(Token = "0x40092A8")]
    public const string UnBreakableBarrierParticle = "Ef_C_Cmn_Barrier01_2_Lop";
    [Token(Token = "0x40092A9")]
    public const string BarrierDestructionEffect = "Ef_C_Cmn_Barrier01_4";
    [Token(Token = "0x40092AA")]
    public const string WarpInParticleName = "Ef_F_Map_Warp_IN";
    [Token(Token = "0x40092AB")]
    public const string WarpOutParticleName = "Ef_F_Map_Warp_OUT";
    [Token(Token = "0x40092AC")]
    public const string SupportGuardEffect = "Ef_C_Cmn_Guard01";
    [Token(Token = "0x40092AD")]
    public const string SupportHealingEffect = "Ef_C_Buf_Heal01";
    [Token(Token = "0x40092AE")]
    public const string BattleRewindPrefab = "Container_Battle_Rewind";
    [Token(Token = "0x40092AF")]
    private const string RewindDeadUnitMessage = "Container_Battle_Rewind_Message_";
    [Token(Token = "0x40092B0")]
    public const string BattleOptionMenuConfig = "BattleOptionMenuConfigAsset";
    [Token(Token = "0x40092B1")]
    public const string BattleUnitList = "Container_Battle_UnitList";
    [Token(Token = "0x40092B2")]
    public const string BattleUnitListHeaderParts = "Container_Battle_UnitList_Parts_Unit";
    [Token(Token = "0x40092B3")]
    public const string BattleUnitListStatusParts = "Container_Battle_UnitList_Parts_Status";
    [Token(Token = "0x40092B4")]
    public const string BattleUnitListUnitFeatureTable = "Container_Battle_UnitList_Parts_UnitFeatureTable";
    [Token(Token = "0x40092B5")]
    public const string InitialPlacementPrefab = "Container_FirstPlacement_Command";
    [Token(Token = "0x40092B6")]
    public const string SelectArrowPrefab = "Container_SelectArrow_Parts";
    [Token(Token = "0x40092B7")]
    public const string AbnormalStateEffectSettingsAsset = "AbnormalStateEffectSettingsAsset";
    [Token(Token = "0x40092B8")]
    public const string BattleLog = "Container_BattleLog_Open";
    [Token(Token = "0x40092B9")]
    public const string ReinForceAllyParticle = "Ef_C_Cmn_Redeployment01";
    [Token(Token = "0x40092BA")]
    public const string ReinForceEnemyParticle = "Ef_C_Cmn_EmyPortal_01";
    [Token(Token = "0x40092BB")]
    [FieldOffset(Offset = "0x0")]
    public static readonly Dictionary<BattleEffectTypeEnum, string> LoopEffectKeyDic;
    [Token(Token = "0x40092BC")]
    public const string AdvScriptPackage = "content_luascript__sample";
    [Token(Token = "0x40092BD")]
    public const string AlignmentStratagem = "effect_CommandChain_CutIn";
    [Token(Token = "0x40092BE")]
    private const string MnemnographAssetNameSuffix = "_MnemnographImage";
    [Token(Token = "0x40092BF")]
    public const string StratagemMnemnographEffectAssetNameSuffix = "_Kcard";
    [Token(Token = "0x40092C0")]
    [FieldOffset(Offset = "0x8")]
    private static StringBuilder resultString;
    [Token(Token = "0x40092C1")]
    [FieldOffset(Offset = "0x10")]
    private static readonly Dictionary<(string, string), DotWeaponMotionAssetNameData> DotWeaponMotionNamesMap;

    [Token(Token = "0x600D3ED")]
    [Address(RVA = "0x19DB71C", Offset = "0x19DB71C", VA = "0x19DB71C")]
    public static string GetRewindDeadUnitMessage() => (string) null;

    [Token(Token = "0x600D3EE")]
    [Address(RVA = "0x19DB794", Offset = "0x19DB794", VA = "0x19DB794")]
    public static DotWeaponMotionAssetNameData Get2DWeaponMotionNames(
      string styleDuelMotionType,
      EquipmentClassificationData equipmentClassificationData)
    {
      return new DotWeaponMotionAssetNameData();
    }

    [Token(Token = "0x600D3EF")]
    [Address(RVA = "0x19DB92C", Offset = "0x19DB92C", VA = "0x19DB92C")]
    public static string GetActiveSkillFieldUniquePrefabName(Battle.Data.Board.SkillData skill)
    {
      return (string) null;
    }

    [Token(Token = "0x600D3F0")]
    [Address(RVA = "0x19DB9DC", Offset = "0x19DB9DC", VA = "0x19DB9DC")]
    public static (string, string) GetUsingWeaponFieldVfxName(
      EquipmentClassificationData classification,
      GameCore.MasterData.WeaponData weaponData)
    {
      return ();
    }

    [Token(Token = "0x600D3F1")]
    [Address(RVA = "0x19DBDDC", Offset = "0x19DBDDC", VA = "0x19DBDDC")]
    public static string GetWeaponHitFieldVfxName(
      AttackTypeEnum type,
      WeaponParameterData weaponParameterData)
    {
      return (string) null;
    }

    [Token(Token = "0x600D3F2")]
    [Address(RVA = "0x19DBEBC", Offset = "0x19DBEBC", VA = "0x19DBEBC")]
    public static string GetElementHitFieldVfxName(
      ElementTypeEnum type,
      WeaponParameterData weaponParameterData)
    {
      return (string) null;
    }

    [Token(Token = "0x600D3F3")]
    [Address(RVA = "0x19DC110", Offset = "0x19DC110", VA = "0x19DC110")]
    public static AssetNames.MagicFieldVfxName? GetMagicFieldVfxNameFromElement(ElementTypeEnum type)
    {
      return new AssetNames.MagicFieldVfxName?();
    }

    [Token(Token = "0x600D3F4")]
    [Address(RVA = "0x19DC320", Offset = "0x19DC320", VA = "0x19DC320")]
    public static string GetRaiseStatusEffectVfxName(EffectData effect) => (string) null;

    [Token(Token = "0x600D3F5")]
    [Address(RVA = "0x19DC574", Offset = "0x19DC574", VA = "0x19DC574")]
    public static string GetLoopStatusEffectVfxName(EffectData effect) => (string) null;

    [Token(Token = "0x600D3F6")]
    [Address(RVA = "0x19DC498", Offset = "0x19DC498", VA = "0x19DC498")]
    public static string GetBuffEffectName(BattleBuffTagEnum? tag) => (string) null;

    [Token(Token = "0x600D3F7")]
    [Address(RVA = "0x19D90CC", Offset = "0x19D90CC", VA = "0x19D90CC")]
    public static string GetMnemnographAssetName(int id) => (string) null;

    [Token(Token = "0x600D3F8")]
    [Address(RVA = "0x19D8DDC", Offset = "0x19D8DDC", VA = "0x19D8DDC")]
    public static string GetStratagemMnemnographEffectAssetName(string typeName) => (string) null;

    [Token(Token = "0x600D3F9")]
    [Address(RVA = "0x19DC6E0", Offset = "0x19DC6E0", VA = "0x19DC6E0")]
    public static string GetBarrierAssetNames(bool isBreakableCounter) => (string) null;

    [Token(Token = "0x600D3FA")]
    [Address(RVA = "0x19DC748", Offset = "0x19DC748", VA = "0x19DC748")]
    static AssetNames()
    {
    }

    [Token(Token = "0x20022C0")]
    public class Sound
    {
      [Token(Token = "0x40092C2")]
      public const string ExpeditionBgmPackName = "alpha5_BGM";
      [Token(Token = "0x40092C3")]
      public const string DefaultBgmPlayerTurn = "Test_Battle_BGM_Playerturn";
      [Token(Token = "0x40092C4")]
      public const string DefaultBgmEnemyTurn = "Test_Battle_BGM_Enemyturn";
      [Token(Token = "0x40092C5")]
      public const string BgmWin = "Test_Battle_BGM_Result";
      [Token(Token = "0x40092C6")]
      public const string PhaseStartAlly = "SE_UI_Battle_Phase_Player";
      [Token(Token = "0x40092C7")]
      public const string PhaseStartEnemy = "SE_UI_Battle_Phase_Enemy";
      [Token(Token = "0x40092C8")]
      public const string PhaseStartGuest = "SE_UI_Battle_Phase_Ally";
      [Token(Token = "0x40092C9")]
      public const string PhaseStartAnother = "SE_UI_Battle_Phase_Neutral";
      [Token(Token = "0x40092CA")]
      public const string LevelUpGaugeStart = "SE_UI_Battle_EXP_Gage";
      [Token(Token = "0x40092CB")]
      public const string LevelUpGaugeEnd = "SE_UI_Battle_EXP_LevelUp";
      [Token(Token = "0x40092CC")]
      public const string LevelUpGauge = "SE_UI_Battle_EXP_Gage_Out";
      [Token(Token = "0x40092CD")]
      public const string SelectGrid = "SE_02003";
      [Token(Token = "0x40092CE")]
      public const string BreakHpStock = "SE_UI_StockHp";
      [Token(Token = "0x40092CF")]
      public const string RecoveryHpStock = "SE_UI_StockHp_Gage";

      [Token(Token = "0x600D3FB")]
      [Address(RVA = "0x19DC8D4", Offset = "0x19DC8D4", VA = "0x19DC8D4")]
      public Sound()
      {
      }
    }

    [Token(Token = "0x20022C1")]
    public struct MagicFieldVfxName
    {
      [Token(Token = "0x40092D0")]
      [FieldOffset(Offset = "0x0")]
      public string Aura;
      [Token(Token = "0x40092D1")]
      [FieldOffset(Offset = "0x8")]
      public string Charge;
      [Token(Token = "0x40092D2")]
      [FieldOffset(Offset = "0x10")]
      public string Attack;
      [Token(Token = "0x40092D3")]
      [FieldOffset(Offset = "0x18")]
      public string Bullet;
      [Token(Token = "0x40092D4")]
      [FieldOffset(Offset = "0x20")]
      public string Hit;
      [Token(Token = "0x40092D5")]
      [FieldOffset(Offset = "0x28")]
      public string SpreadHit;
    }
  }
}
