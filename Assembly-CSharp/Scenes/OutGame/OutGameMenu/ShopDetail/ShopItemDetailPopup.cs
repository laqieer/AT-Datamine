// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.ShopDetail.ShopItemDetailPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.Popup;
using GameCore.UIControls;
using Il2CppDummyDll;
using Scenes.OutGame.Info.Skill.UI;
using Scenes.OutGame.Popup;
using StaqData.StatusIcon;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.Direction;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.ShopDetail
{
  [Token(Token = "0x2003B33")]
  public class ShopItemDetailPopup : MonoBehaviour
  {
    [Token(Token = "0x4010566")]
    [FieldOffset(Offset = "0x18")]
    private string TARGET_ASSET_BUMDLE_LABLE;
    [Token(Token = "0x4010567")]
    [FieldOffset(Offset = "0x20")]
    private string TARGET_DETAIL_POPUP_TIMELINE_LABEL;
    [Token(Token = "0x4010568")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private UISafeAreaInsets safeArea;
    [Token(Token = "0x4010569")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private RectTransform childPopupParent;
    [Token(Token = "0x401056A")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private SkillInfoUI skillInfo;
    [Token(Token = "0x401056B")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private PlayableDirector detailIn;
    [Token(Token = "0x401056C")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private PlayableDirector detailOut;
    [Token(Token = "0x401056D")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private PlayableDirector swapDetailIn;
    [Token(Token = "0x401056E")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private PlayableDirector swapDetailOut;
    [Token(Token = "0x401056F")]
    [FieldOffset(Offset = "0x60")]
    private readonly Dictionary<int, string> prefabMap;
    [Token(Token = "0x4010570")]
    [FieldOffset(Offset = "0x68")]
    private bool isOpend;
    [Token(Token = "0x4010571")]
    [FieldOffset(Offset = "0x69")]
    private bool isSkillDetailOpend;
    [Token(Token = "0x4010572")]
    [FieldOffset(Offset = "0x6A")]
    private bool isPlaying;
    [Token(Token = "0x4010573")]
    [FieldOffset(Offset = "0x6B")]
    private bool isPopupOpening;
    [Token(Token = "0x4010574")]
    [FieldOffset(Offset = "0x6C")]
    private bool isCloseing;
    [Token(Token = "0x4010575")]
    [FieldOffset(Offset = "0x70")]
    private Action onPlayInEnd;
    [Token(Token = "0x4010576")]
    [FieldOffset(Offset = "0x78")]
    private PlayableDirector playingDirector;
    [Token(Token = "0x4010577")]
    [FieldOffset(Offset = "0x80")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x4010578")]
    [FieldOffset(Offset = "0x88")]
    private MindEquipmentData mindEquipmentData;
    [Token(Token = "0x4010579")]
    [FieldOffset(Offset = "0x90")]
    private UITimelineSettingAsset settingAsset;
    [Token(Token = "0x401057A")]
    [FieldOffset(Offset = "0x98")]
    private MindequipmentDetailPopup mindequipmentDetailPopup;
    [Token(Token = "0x401057B")]
    [FieldOffset(Offset = "0xA0")]
    private EquipmentDetailPopup equipmentDetailPopup;
    [Token(Token = "0x401057C")]
    [FieldOffset(Offset = "0xA8")]
    private StyleDetailPopup styleDetailPopup;
    [Token(Token = "0x401057D")]
    [FieldOffset(Offset = "0xB0")]
    private RewardTypeEnum rewardType;
    [Token(Token = "0x401057E")]
    [FieldOffset(Offset = "0xB4")]
    private int rewardId;
    [Token(Token = "0x401057F")]
    [FieldOffset(Offset = "0xB8")]
    public Action OnClickClose;
    [Token(Token = "0x4010580")]
    [FieldOffset(Offset = "0xC0")]
    private IconFactory iconFactory;

    [Token(Token = "0x17004BFC")]
    public UISafeAreaInsets SafeArea
    {
      [Token(Token = "0x60174C1"), Address(RVA = "0x271E290", Offset = "0x271E290", VA = "0x271E290")] get
      {
        return (UISafeAreaInsets) null;
      }
    }

    [Token(Token = "0x60174C2")]
    [Address(RVA = "0x271E298", Offset = "0x271E298", VA = "0x271E298")]
    private IEnumerator InitializeAsync(AssetCachedSpawner assetCachedSpawner, Action onFinish)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60174C3")]
    [Address(RVA = "0x271E33C", Offset = "0x271E33C", VA = "0x271E33C")]
    private void PopupLoad(
      ShopItemDetailPopup.PopupType popupType,
      AssetCachedSpawner assetCachedSpawner,
      Action<GameObject> action)
    {
    }

    [Token(Token = "0x60174C4")]
    [Address(RVA = "0x271E468", Offset = "0x271E468", VA = "0x271E468")]
    private IEnumerator OpenInternal(PopupBase popupBase) => (IEnumerator) null;

    [Token(Token = "0x60174C5")]
    [Address(RVA = "0x271E504", Offset = "0x271E504", VA = "0x271E504")]
    private void CloseInternal(PopupBase popupBase, Action onFinish = null)
    {
    }

    [Token(Token = "0x60174C6")]
    [Address(RVA = "0x271E59C", Offset = "0x271E59C", VA = "0x271E59C")]
    private GameObject CreatePopup(GameObject resourceObj) => (GameObject) null;

    [Token(Token = "0x60174C7")]
    [Address(RVA = "0x271E6F8", Offset = "0x271E6F8", VA = "0x271E6F8")]
    private IEnumerator CreateMindEquipmentPopup(
      GameObject popup,
      RewardTypeEnum rewardType,
      int rewardId,
      AssetCachedSpawner assetCachedSpawner)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60174C8")]
    [Address(RVA = "0x271E7B0", Offset = "0x271E7B0", VA = "0x271E7B0")]
    private IEnumerator CreateEqupimentPopup(
      GameObject popup,
      RewardTypeEnum rewardType,
      int rewardId,
      AssetCachedSpawner assetCachedSpawner)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60174C9")]
    [Address(RVA = "0x271E868", Offset = "0x271E868", VA = "0x271E868")]
    private IEnumerator CreateStylePopup(GameObject popup, int rewardId) => (IEnumerator) null;

    [Token(Token = "0x60174CA")]
    [Address(RVA = "0x27179AC", Offset = "0x27179AC", VA = "0x27179AC")]
    public void Open(
      RewardTypeEnum rewardType,
      int rewardId,
      AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x60174CB")]
    [Address(RVA = "0x271E914", Offset = "0x271E914", VA = "0x271E914")]
    public void OnClickToSkillDetail(int skillId)
    {
    }

    [Token(Token = "0x60174CC")]
    [Address(RVA = "0x271F110", Offset = "0x271F110", VA = "0x271F110")]
    public void OnClickToClose()
    {
    }

    [Token(Token = "0x60174CD")]
    [Address(RVA = "0x271EAC0", Offset = "0x271EAC0", VA = "0x271EAC0")]
    private void SetupSkillInfoUI(int skillId, RewardTypeEnum rewardType)
    {
    }

    [Token(Token = "0x60174CE")]
    [Address(RVA = "0x271F2A8", Offset = "0x271F2A8", VA = "0x271F2A8")]
    public void OnClickToSkillViewClose()
    {
    }

    [Token(Token = "0x60174CF")]
    [Address(RVA = "0x271F8EC", Offset = "0x271F8EC", VA = "0x271F8EC")]
    public void OnSkillViewFinish()
    {
    }

    [Token(Token = "0x60174D0")]
    [Address(RVA = "0x271F378", Offset = "0x271F378", VA = "0x271F378")]
    private EquipmentClassificationData GetSkillWeaponSysTemType(SkillDetailData detailData)
    {
      return (EquipmentClassificationData) null;
    }

    [Token(Token = "0x60174D1")]
    [Address(RVA = "0x271F5A4", Offset = "0x271F5A4", VA = "0x271F5A4")]
    private string[] GetSkillTags(int tagId) => (string[]) null;

    [Token(Token = "0x60174D2")]
    [Address(RVA = "0x271F834", Offset = "0x271F834", VA = "0x271F834")]
    public void SetTags(string[] tags)
    {
    }

    [Token(Token = "0x60174D3")]
    [Address(RVA = "0x271F9A4", Offset = "0x271F9A4", VA = "0x271F9A4")]
    public ShopItemDetailPopup()
    {
    }

    [Token(Token = "0x2003B34")]
    public enum PopupType
    {
      [Token(Token = "0x4010582")] Style,
      [Token(Token = "0x4010583")] Equipment,
      [Token(Token = "0x4010584")] MindEquipment,
    }
  }
}
