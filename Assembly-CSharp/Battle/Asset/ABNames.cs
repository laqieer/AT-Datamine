// Decompiled with JetBrains decompiler
// Type: Battle.Asset.ABNames
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Text;

#nullable disable
namespace Battle.Asset
{
  [Token(Token = "0x20022C2")]
  public static class ABNames
  {
    [Token(Token = "0x40092D6")]
    public const string AssetBundleTag = "Battle";
    [Token(Token = "0x40092D7")]
    public const string UICommon = "ui_common";
    [Token(Token = "0x40092D8")]
    public const string Ingame2DUI = "2dassets_ui_ingame";
    [Token(Token = "0x40092D9")]
    public const string IngameUI = "2dassets_ui_ingameui";
    [Token(Token = "0x40092DA")]
    public const string UIPageIngame = "ui_page_ingame";
    [Token(Token = "0x40092DB")]
    public const string UIDirectionGameStart = "ui_page_ingame_gamestart_prefab";
    [Token(Token = "0x40092DC")]
    public const string UIDirectionGameClearFailed = "ui_page_ingame_stageclearfailed_prefab";
    [Token(Token = "0x40092DD")]
    public const string IngameUISpriteAtlases = "2dassets_ui_ingameui_spriteatlases";
    [Token(Token = "0x40092DE")]
    public const string UIPageIngameFieldDamage = "ui_page_ingame_damageui_field";
    [Token(Token = "0x40092DF")]
    public const string UIPageIngameFieldDamagePrefab = "ui_page_ingame_damageui_field_prefab";
    [Token(Token = "0x40092E0")]
    public const string ContentDuelSettings = "content_duel_settings";
    [Token(Token = "0x40092E1")]
    public const string FieldUIPrefab = "ui_page_ingame_field_ui_prefab";
    [Token(Token = "0x40092E2")]
    public const string ArenaPopupPrefab = "ui_page_arena_popup_prefab";
    [Token(Token = "0x40092E3")]
    public const string ArenaFieldPrefab = "ui_page_arena_arena_field_prefab";
    [Token(Token = "0x40092E4")]
    public const string UICommonThumb = "ui_common_thumb";
    [Token(Token = "0x40092E5")]
    public const string Materials = "materials";
    [Token(Token = "0x40092E6")]
    public const string DummyUnit = "units_dummyunit";
    [Token(Token = "0x40092E7")]
    public const string Unit2Ds = "units_test";
    [Token(Token = "0x40092E8")]
    public const string FieldEffect = "effects_field";
    [Token(Token = "0x40092E9")]
    public const string CommonEffect = "content_effect3d_common_common";
    [Token(Token = "0x40092EA")]
    public const string LandEffect = "content_effect3d_common_fieldmap";
    [Token(Token = "0x40092EB")]
    public const string AbnormalStateEffect = "content_effect3d_common_abnormalstate";
    [Token(Token = "0x40092EC")]
    public const string MotionsEnemySwd = "motions_emy_swd";
    [Token(Token = "0x40092ED")]
    public const string DotMotionPrefix = "content_dot_wpn_motion_";
    [Token(Token = "0x40092EE")]
    private const string MapDataPrefix = "content_bg_field_{0}";
    [Token(Token = "0x40092EF")]
    private const string MapDataYamlPrefix = "content_bg_field_{0}_map";
    [Token(Token = "0x40092F0")]
    private const string MnemnographAssetBundleLabelPrefix = "content_mnemnograph_";
    [Token(Token = "0x40092F1")]
    private const string MnemnographAssetBundleLabelSuffix = "_image";
    [Token(Token = "0x40092F2")]
    private const string duelBGSceneAssetbundleNamePrefix = "content_bg_duel_{0}";
    [Token(Token = "0x40092F3")]
    public const string AlignmentStratagem = "ui_page_ingame_visionchain_cutin";
    [Token(Token = "0x40092F4")]
    public const string InGameFieldUiPrefabs = "ui_page_ingame_field_ui_prefab";
    [Token(Token = "0x40092F5")]
    private const string MnemnographEffectTypeAssetBundleLabelPrefix = "content_effect3d_battle_stratagem_mnemnograph_";
    [Token(Token = "0x40092F6")]
    public const string InGameBattleMenuPrefabs = "ui_page_ingame_battlemenu_prefab";
    [Token(Token = "0x40092F7")]
    [FieldOffset(Offset = "0x0")]
    private static readonly StringBuilder ResultString;

    [Token(Token = "0x600D3FC")]
    [Address(RVA = "0x19DC8DC", Offset = "0x19DC8DC", VA = "0x19DC8DC")]
    public static string GetFacilityContentBundleName(int id) => (string) null;

    [Token(Token = "0x600D3FD")]
    [Address(RVA = "0x19DC95C", Offset = "0x19DC95C", VA = "0x19DC95C")]
    public static string GetMapDataSceneBundleName(string mapName) => (string) null;

    [Token(Token = "0x600D3FE")]
    [Address(RVA = "0x19DC9C0", Offset = "0x19DC9C0", VA = "0x19DC9C0")]
    public static string GetMapDataYamlBundleName(string mapName) => (string) null;

    [Token(Token = "0x600D3FF")]
    [Address(RVA = "0x19DCA24", Offset = "0x19DCA24", VA = "0x19DCA24")]
    public static string GetDuelBgSceneBundleName(string primaryDuelSceneName) => (string) null;

    [Token(Token = "0x600D400")]
    [Address(RVA = "0x19DCA88", Offset = "0x19DCA88", VA = "0x19DCA88")]
    public static string GetActiveSkillFieldUniquePrefabBundleName(Battle.Data.Board.SkillData skill)
    {
      return (string) null;
    }

    [Token(Token = "0x600D401")]
    [Address(RVA = "0x19DCBE8", Offset = "0x19DCBE8", VA = "0x19DCBE8")]
    public static string GetActiveSkillFieldUniquePrefabBundleName(int id) => (string) null;

    [Token(Token = "0x600D402")]
    [Address(RVA = "0x19DCD74", Offset = "0x19DCD74", VA = "0x19DCD74")]
    public static string Get2DUnitWeaponMotionBundleName(WeaponTypeEnum weaponType)
    {
      return (string) null;
    }

    [Token(Token = "0x600D403")]
    [Address(RVA = "0x19D8FA0", Offset = "0x19D8FA0", VA = "0x19D8FA0")]
    public static string GetMnemnographImageAssetBundleName(int id) => (string) null;

    [Token(Token = "0x600D404")]
    [Address(RVA = "0x19D8CF8", Offset = "0x19D8CF8", VA = "0x19D8CF8")]
    public static string GetMnemnographEffectAssetBundleName(string typeName) => (string) null;

    [Token(Token = "0x600D405")]
    [Address(RVA = "0x19DCDF4", Offset = "0x19DCDF4", VA = "0x19DCDF4")]
    static ABNames()
    {
    }
  }
}
