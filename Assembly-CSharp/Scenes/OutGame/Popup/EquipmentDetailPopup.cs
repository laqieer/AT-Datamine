// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Popup.EquipmentDetailPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.Popup;
using GameCore.Tween;
using Il2CppDummyDll;
using Scenes.OutGame.EquipmentDetail;
using Scenes.OutGame.Info.Common.UI;
using Scenes.OutGame.OutGameMenu;
using StaqData.StatusIcon;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Popup
{
  [Token(Token = "0x2003439")]
  public class EquipmentDetailPopup : PopupBase
  {
    [Token(Token = "0x400E331")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private UITweenGroup tween;
    [Token(Token = "0x400E332")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Text equipmentName;
    [Token(Token = "0x400E333")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private WeaponThumb weaponThumb;
    [Token(Token = "0x400E334")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private AccessoryThumb accessoryThumb;
    [Token(Token = "0x400E335")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private TrustThumb trustThumb;
    [Token(Token = "0x400E336")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private EquipmentDetailPopup.LimitBreakIcon[] limitBreakIcons;
    [Token(Token = "0x400E337")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private Image[] weaponTypeIcons;
    [Token(Token = "0x400E338")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private Text nowLv;
    [Token(Token = "0x400E339")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private Text maxLv;
    [Token(Token = "0x400E33A")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private GameObject levelGroup;
    [Token(Token = "0x400E33B")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private Text totalPower;
    [Token(Token = "0x400E33C")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private GameObject weaponParamGroup;
    [Token(Token = "0x400E33D")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private GameObject accessoryParamGroup;
    [Token(Token = "0x400E33E")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    private GameObject shieldParamGroup;
    [Token(Token = "0x400E33F")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    private GameObject trustParamGroup;
    [Token(Token = "0x400E340")]
    [FieldOffset(Offset = "0x100")]
    [SerializeField]
    private Text[] weaponStatusTexts;
    [Token(Token = "0x400E341")]
    [FieldOffset(Offset = "0x108")]
    [SerializeField]
    private TextMeshProUGUI weaponStatusRangeText;
    [Token(Token = "0x400E342")]
    [FieldOffset(Offset = "0x110")]
    [SerializeField]
    private Text[] accessoryStatusTexts;
    [Token(Token = "0x400E343")]
    [FieldOffset(Offset = "0x118")]
    [SerializeField]
    private Text[] shieldStatusTexts;
    [Token(Token = "0x400E344")]
    [FieldOffset(Offset = "0x120")]
    [SerializeField]
    private Text[] trustStatusTexts;
    [Token(Token = "0x400E345")]
    [FieldOffset(Offset = "0x128")]
    [SerializeField]
    private WeaponOptionEffectContainer[] optionEffectContainers;
    [Token(Token = "0x400E346")]
    [FieldOffset(Offset = "0x130")]
    [SerializeField]
    private DetailSkillListThumb detailSkillListThumb;
    [Token(Token = "0x400E347")]
    [FieldOffset(Offset = "0x138")]
    [SerializeField]
    private Image skillTypeIcon;
    [Token(Token = "0x400E348")]
    [FieldOffset(Offset = "0x140")]
    [SerializeField]
    private Text skillTypeText;
    [Token(Token = "0x400E349")]
    [FieldOffset(Offset = "0x148")]
    [SerializeField]
    private SkillIconSub[] skillIconSubs;
    [Token(Token = "0x400E34A")]
    [FieldOffset(Offset = "0x150")]
    [SerializeField]
    private GameObject emptySubSkillIcon;
    [Token(Token = "0x400E34B")]
    [FieldOffset(Offset = "0x158")]
    [SerializeField]
    private EquipmentDetailPopup.SwapButton addStatusButton;
    [Token(Token = "0x400E34C")]
    [FieldOffset(Offset = "0x160")]
    [SerializeField]
    private EquipmentDetailPopup.SwapButton memoryButton;
    [Token(Token = "0x400E34D")]
    [FieldOffset(Offset = "0x168")]
    [SerializeField]
    private AddStatusView addStatusView;
    [Token(Token = "0x400E34E")]
    [FieldOffset(Offset = "0x170")]
    [SerializeField]
    private Text memoryText;
    [Token(Token = "0x400E34F")]
    [FieldOffset(Offset = "0x178")]
    [SerializeField]
    private GameObject memoruGroup;
    [Token(Token = "0x400E350")]
    [FieldOffset(Offset = "0x180")]
    private IAssetProvider assetProvider;
    [Token(Token = "0x400E351")]
    [FieldOffset(Offset = "0x188")]
    private IconFactory iconFactory;
    [Token(Token = "0x400E353")]
    [FieldOffset(Offset = "0x198")]
    private int skillId;

    [Token(Token = "0x17004447")]
    public Action<int> OnClickSkillDetail
    {
      [Token(Token = "0x6014868"), Address(RVA = "0x1A9AF38", Offset = "0x1A9AF38", VA = "0x1A9AF38")] get
      {
        return (Action<int>) null;
      }
      [Token(Token = "0x6014869"), Address(RVA = "0x1A9AF40", Offset = "0x1A9AF40", VA = "0x1A9AF40")] set
      {
      }
    }

    [Token(Token = "0x601486A")]
    [Address(RVA = "0x1A9AF48", Offset = "0x1A9AF48", VA = "0x1A9AF48")]
    private void SetAccessoryData(int equipmentId, AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x601486B")]
    [Address(RVA = "0x1A9B8B4", Offset = "0x1A9B8B4", VA = "0x1A9B8B4")]
    private void SetWeaponData(int equipmentId, AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x601486C")]
    [Address(RVA = "0x1A9BFC4", Offset = "0x1A9BFC4", VA = "0x1A9BFC4")]
    private void SetTrustData(int equipmentId, AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x601486D")]
    [Address(RVA = "0x1A9B4C8", Offset = "0x1A9B4C8", VA = "0x1A9B4C8")]
    private void SetSkill(int skillId, AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x601486E")]
    [Address(RVA = "0x1A9C4A4", Offset = "0x1A9C4A4", VA = "0x1A9C4A4")]
    public void SetData(
      int equipmentId,
      RewardTypeEnum rewardType,
      AssetCachedSpawner assetCachedSpawner,
      IconFactory iconFactory)
    {
    }

    [Token(Token = "0x601486F")]
    [Address(RVA = "0x1A9C954", Offset = "0x1A9C954", VA = "0x1A9C954")]
    public void OnClickToSkillDetail()
    {
    }

    [Token(Token = "0x6014870")]
    [Address(RVA = "0x1A9C974", Offset = "0x1A9C974", VA = "0x1A9C974")]
    public void OnClickChangeToggleByAddStatus()
    {
    }

    [Token(Token = "0x6014871")]
    [Address(RVA = "0x1A9C9F0", Offset = "0x1A9C9F0", VA = "0x1A9C9F0")]
    public void OnClickChangeToggleByMemory()
    {
    }

    [Token(Token = "0x6014872")]
    [Address(RVA = "0x1A9CA7C", Offset = "0x1A9CA7C", VA = "0x1A9CA7C")]
    public EquipmentDetailPopup()
    {
    }

    [Token(Token = "0x200343A")]
    [Serializable]
    public class SwapButton
    {
      [Token(Token = "0x400E354")]
      [FieldOffset(Offset = "0x10")]
      [SerializeField]
      private GameObject onObj;
      [Token(Token = "0x400E355")]
      [FieldOffset(Offset = "0x18")]
      [SerializeField]
      private GameObject offObj;
      [Token(Token = "0x400E356")]
      [FieldOffset(Offset = "0x20")]
      [SerializeField]
      private bool isOn;

      [Token(Token = "0x17004448")]
      public bool IsOn
      {
        [Token(Token = "0x6014876"), Address(RVA = "0x1A9CC00", Offset = "0x1A9CC00", VA = "0x1A9CC00")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x6014877")]
      [Address(RVA = "0x1A9C908", Offset = "0x1A9C908", VA = "0x1A9C908")]
      public void SetFlg(bool isOn)
      {
      }

      [Token(Token = "0x6014878")]
      [Address(RVA = "0x1A9CC08", Offset = "0x1A9CC08", VA = "0x1A9CC08")]
      public SwapButton()
      {
      }
    }

    [Token(Token = "0x200343B")]
    [Serializable]
    public class LimitBreakIcon
    {
      [Token(Token = "0x400E357")]
      [FieldOffset(Offset = "0x10")]
      [SerializeField]
      private GameObject bg;
      [Token(Token = "0x400E358")]
      [FieldOffset(Offset = "0x18")]
      [SerializeField]
      private GameObject on;

      [Token(Token = "0x6014879")]
      [Address(RVA = "0x1A9C8C0", Offset = "0x1A9C8C0", VA = "0x1A9C8C0")]
      public void Set(bool isOn)
      {
      }

      [Token(Token = "0x601487A")]
      [Address(RVA = "0x1A9CC10", Offset = "0x1A9CC10", VA = "0x1A9CC10")]
      public LimitBreakIcon()
      {
      }
    }
  }
}
