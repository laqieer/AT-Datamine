// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.QuestPrepareAssetLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using TeamOrganization;
using UI.Direction;
using UnityEngine;
using UnityEngine.U2D;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x200323E")]
  public class QuestPrepareAssetLoader : MonoBehaviour
  {
    [Token(Token = "0x400D693")]
    private const string COMMON_UI_ASSET_BUNDLE_NAME = "2dassets_ui_common";
    [Token(Token = "0x400D694")]
    private const string ICOM_SPRITE_ATLAS_BUNDLE_NAME = "2dassets_ui_spriteatlases";
    [Token(Token = "0x400D695")]
    public const string DECK_SLOT_PARTS_ASSET_BUNDLE_NAME = "2dassets_ui_partyorganization";
    [Token(Token = "0x400D696")]
    public const string QUEST_PREPARE_ASSET_BUNDLE_NAME = "ui_page_questdetail_prefab";
    [Token(Token = "0x400D697")]
    public const string PARTY_SKILL_PREFAB_NAME = "Com_Popup_PartySkill";
    [Token(Token = "0x400D698")]
    public const string BATTLE_ITEM_PREFAB_NAME = "Com_Popup_BattleItem";
    [Token(Token = "0x400D699")]
    public const string BATTLE_PARTY_AI_PREFAB_NAME = "Dummy_Popup_PartyAI";
    [Token(Token = "0x400D69A")]
    private const string OBLIVIAE_FIRST_ATTACK_POPUP_NAME = "Com_Popup_Obliviae_Check";
    [Token(Token = "0x400D69B")]
    private const string OUTGAME_BATTLESETTINGS_ASSETBUNDLE_NAME = "ui_page_outgame_battlesettings";
    [Token(Token = "0x400D69C")]
    public const string BATTLE_CONFIG_SETTING_PREFAB_NAME = "Com_Popup_BattleSettings";
    [Token(Token = "0x400D69D")]
    private const string PARTY_LISY_ASSETBUNDLE_NAME = "ui_page_partylist";
    [Token(Token = "0x400D69E")]
    private const string PARTY_AI_POPUP_NAME = "Com_Popup_PartyAI";
    [Token(Token = "0x400D69F")]
    private const string PARTY_LISY_SKILL_ASSETBUNDLE_NAME = "ui_page_partylist_partyskill";
    [Token(Token = "0x400D6A0")]
    private const string PARTY_SKILL_POPUP_NAME = "Com_Popup_PartySkill";
    [Token(Token = "0x400D6A1")]
    private const string PARTY_LIST_ITEM_ASSETBUNDLE_NAME = "ui_page_partylist_itemedit";
    [Token(Token = "0x400D6A2")]
    private const string PARTY_ITEM_EDIT_POPUP_NAME = "Com_Popup_ItemList";
    [Token(Token = "0x400D6A3")]
    public const string POPUP_BASE_TIMELINE_LABEL_NAME = "ui_common_timeline";
    [Token(Token = "0x400D6A4")]
    public const string POPUP_BASE_TIMELINE_ASSET_NAME = "Com_Popup_Base_New";
    [Token(Token = "0x400D6A5")]
    private const string ICON_SPRITE_ATLAS_NAME = "IconUI_Atlas";
    [Token(Token = "0x400D6A6")]
    private const string SORITE_LIMIT_POPUP_PREFAB_NANE = "Com_Popup_QuestDetail_SortieRestrictOnly";
    [Token(Token = "0x400D6A7")]
    private const string QUEST_PREPARE_BG_BUNDLE_NAME = "ui_bg";
    [Token(Token = "0x400D6A8")]
    private const string QUEST_PREPARE_BG_ASSET_NAME = "Container_QuestBG";
    [Token(Token = "0x400D6A9")]
    private const string QUEST_PREPARE_BG_ASSET_NAME_ARENA = "Container_ArenaBG";
    [Token(Token = "0x400D6AA")]
    private const string UNIT_NUMBER_ASSETBUNDLE_NAME = "ui_page_partylist_texture";
    [Token(Token = "0x400D6AB")]
    private const string UNIT_NUMBER_ASSETNAME = "Img_Num_UnitNumber_Atlas";
    [Token(Token = "0x400D6AC")]
    private const string PLATOON_NUMBER_ASSETBUNDLE_NAME = "ui_common_thumb_icon_army";
    [Token(Token = "0x400D6AD")]
    private const string SCENE_TIMELINE_BUNDLE_NAME = "ui_page_sortie_timeline";
    [Token(Token = "0x400D6AE")]
    private const string SCENE_TIMELINE_ASSET_NAME = "Sortie";
    [Token(Token = "0x400D6AF")]
    private const string COMMON_POPUP_PREFAB_BUNDLE_LABEL = "ui_common_prefabs";
    [Token(Token = "0x400D6B0")]
    private const string COMMON_POPUP_ONE_BUTTON_ASSET_NAME = "Com_Popup_Base_S2_Text";
    [Token(Token = "0x400D6B1")]
    private const string COMMON_POPUP_TWO_BUTTON_ASSET_NAME = "Com_Popup_Base_S_Text";
    [Token(Token = "0x400D6B2")]
    [FieldOffset(Offset = "0x18")]
    public readonly Dictionary<int, string> TimelineMap;
    [Token(Token = "0x400D6B4")]
    [FieldOffset(Offset = "0x20")]
    private int? bgResourceId;

    [Token(Token = "0x17004134")]
    public static List<string> LoadedList
    {
      [Token(Token = "0x601395D"), Address(RVA = "0x460DC8C", Offset = "0x460DC8C", VA = "0x460DC8C")] get
      {
        return (List<string>) null;
      }
      [Token(Token = "0x601395E"), Address(RVA = "0x460DCE4", Offset = "0x460DCE4", VA = "0x460DCE4")] private set
      {
      }
    }

    [Token(Token = "0x601395F")]
    [Address(RVA = "0x460DD40", Offset = "0x460DD40", VA = "0x460DD40")]
    private string[] GetLoadAssetBundleLabelList() => (string[]) null;

    [Token(Token = "0x6013960")]
    [Address(RVA = "0x460EA28", Offset = "0x460EA28", VA = "0x460EA28")]
    public IEnumerator ChangeDeckAssetLoad(bool isDeckChange, Action finishCallback = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6013961")]
    [Address(RVA = "0x460EACC", Offset = "0x460EACC", VA = "0x460EACC")]
    public IEnumerator ChangeDeckAssetLoad(bool isDeckChange, Deck deck, Action finishCallback = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6013962")]
    [Address(RVA = "0x460EB78", Offset = "0x460EB78", VA = "0x460EB78")]
    public IEnumerator LoadAsync() => (IEnumerator) null;

    [Token(Token = "0x6013963")]
    [Address(RVA = "0x460EC08", Offset = "0x460EC08", VA = "0x460EC08")]
    public IEnumerator LoadAsync(Deck deck) => (IEnumerator) null;

    [Token(Token = "0x6013964")]
    [Address(RVA = "0x460ECA4", Offset = "0x460ECA4", VA = "0x460ECA4")]
    public void UnloadBundle()
    {
    }

    [Token(Token = "0x6013965")]
    [Address(RVA = "0x460EE28", Offset = "0x460EE28", VA = "0x460EE28")]
    public Sprite GetUnitThumb(int styleId) => (Sprite) null;

    [Token(Token = "0x6013966")]
    [Address(RVA = "0x460EEE8", Offset = "0x460EEE8", VA = "0x460EEE8")]
    public GameObject GetDotUnit(int styleId) => (GameObject) null;

    [Token(Token = "0x6013967")]
    [Address(RVA = "0x460F098", Offset = "0x460F098", VA = "0x460F098")]
    public CommonPopup GetOblivieFirstAttackPopup() => (CommonPopup) null;

    [Token(Token = "0x6013968")]
    [Address(RVA = "0x460F17C", Offset = "0x460F17C", VA = "0x460F17C")]
    public ItemSetListPopup GetItemEditPopup() => (ItemSetListPopup) null;

    [Token(Token = "0x6013969")]
    [Address(RVA = "0x460F260", Offset = "0x460F260", VA = "0x460F260")]
    public PartySkillPopup GetPartySkillPopup() => (PartySkillPopup) null;

    [Token(Token = "0x601396A")]
    [Address(RVA = "0x460F344", Offset = "0x460F344", VA = "0x460F344")]
    public PartyAIView GetPartyAIPopup() => (PartyAIView) null;

    [Token(Token = "0x601396B")]
    [Address(RVA = "0x460F428", Offset = "0x460F428", VA = "0x460F428")]
    public BattleConfigPopup GetBattleConfigPopup() => (BattleConfigPopup) null;

    [Token(Token = "0x601396C")]
    [Address(RVA = "0x460F50C", Offset = "0x460F50C", VA = "0x460F50C")]
    public void SetBG(int? resourceId = null)
    {
    }

    [Token(Token = "0x601396D")]
    [Address(RVA = "0x460F514", Offset = "0x460F514", VA = "0x460F514")]
    public GameObject GetBgObject() => (GameObject) null;

    [Token(Token = "0x601396E")]
    [Address(RVA = "0x460F6EC", Offset = "0x460F6EC", VA = "0x460F6EC")]
    public GameObject GetBgObjectArena() => (GameObject) null;

    [Token(Token = "0x601396F")]
    [Address(RVA = "0x460EFE4", Offset = "0x460EFE4", VA = "0x460EFE4")]
    private GameObject CreateInstance(GameObject loadAsset) => (GameObject) null;

    [Token(Token = "0x6013970")]
    [Address(RVA = "0x460F7B0", Offset = "0x460F7B0", VA = "0x460F7B0")]
    public SpriteAtlas GetElementIconSpriteAtlas() => (SpriteAtlas) null;

    [Token(Token = "0x6013971")]
    [Address(RVA = "0x460F86C", Offset = "0x460F86C", VA = "0x460F86C")]
    public SpriteAtlas GetTeamNoIconSpriteAtlas() => (SpriteAtlas) null;

    [Token(Token = "0x6013972")]
    [Address(RVA = "0x460F928", Offset = "0x460F928", VA = "0x460F928")]
    public SortieLimitPopup CreateSortieLimitPopup() => (SortieLimitPopup) null;

    [Token(Token = "0x6013973")]
    [Address(RVA = "0x460FA0C", Offset = "0x460FA0C", VA = "0x460FA0C")]
    public CommonPopup CreateOneButtonPopup() => (CommonPopup) null;

    [Token(Token = "0x6013974")]
    [Address(RVA = "0x460FAF0", Offset = "0x460FAF0", VA = "0x460FAF0")]
    public CommonPopup CreateTwoButtonPopup() => (CommonPopup) null;

    [Token(Token = "0x6013975")]
    [Address(RVA = "0x460FBD4", Offset = "0x460FBD4", VA = "0x460FBD4")]
    public UITimelineSettingAsset LoadSceneTimelineSetting() => (UITimelineSettingAsset) null;

    [Token(Token = "0x6013976")]
    [Address(RVA = "0x460FC2C", Offset = "0x460FC2C", VA = "0x460FC2C")]
    public UITimelineSettingAsset LoadUITimelineAsset(string label = "ui_common_timeline", string assetName = "Com_Popup_Base_New")
    {
      return (UITimelineSettingAsset) null;
    }

    [Token(Token = "0x6013977")]
    [Address(RVA = "0x460FD2C", Offset = "0x460FD2C", VA = "0x460FD2C")]
    public QuestPrepareAssetLoader()
    {
    }

    [Token(Token = "0x6013978")]
    [Address(RVA = "0x460FEEC", Offset = "0x460FEEC", VA = "0x460FEEC")]
    static QuestPrepareAssetLoader()
    {
    }

    [Token(Token = "0x200323F")]
    public enum TimelineType
    {
      [Token(Token = "0x400D6B6")] COMMON_POPUP_IN,
      [Token(Token = "0x400D6B7")] COMMON_POPUP_OUT,
      [Token(Token = "0x400D6B8")] COMMON_S_POPUP_IN,
      [Token(Token = "0x400D6B9")] COMMON_S_POPUP_OUT,
      [Token(Token = "0x400D6BA")] COMMON_S2_POPUP_IN,
      [Token(Token = "0x400D6BB")] COMMON_S2_POPUP_OUT,
      [Token(Token = "0x400D6BC")] SCENE_IN,
      [Token(Token = "0x400D6BD")] SCENE_OUT,
      [Token(Token = "0x400D6BE")] SCENE_GENERAL,
    }

    [Token(Token = "0x2003240")]
    public enum TimelinePattern
    {
      [Token(Token = "0x400D6C0")] SCENE,
      [Token(Token = "0x400D6C1")] COMMON_POPUP,
      [Token(Token = "0x400D6C2")] COMMON_S_POPUP,
      [Token(Token = "0x400D6C3")] COMMON_S2_POPUP,
      [Token(Token = "0x400D6C4")] SORTIE_LIMIT_POPUP,
      [Token(Token = "0x400D6C5")] PATY_AI_VIEW,
    }
  }
}
