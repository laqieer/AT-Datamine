// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Armoury.WeaponList.WeaponListSubMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Input;
using Il2CppDummyDll;
using Scenes.OutGame.EquipmentDetail;
using Scenes.OutGame.Favorite;
using Scenes.OutGame.Info.Common.UI;
using Scenes.OutGame.OutGameMenu;
using StaqData;
using System;
using System.Collections;
using TMPro;
using UI.Common;
using UI.Direction;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Armoury.WeaponList
{
  [Token(Token = "0x2003834")]
  public class WeaponListSubMenu : MonoBehaviour
  {
    [Token(Token = "0x400F53D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController timelineController;
    [Token(Token = "0x400F53E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CanvasGroup rightCanvasGroup;
    [Token(Token = "0x400F53F")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x400F540")]
    [FieldOffset(Offset = "0x30")]
    [Header("上部")]
    [SerializeField]
    private TextMeshProUGUI nameText;
    [Token(Token = "0x400F541")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x400F542")]
    [FieldOffset(Offset = "0x40")]
    [Header("情報：ヘッダ部")]
    [SerializeField]
    private RarityIcon rarityIcon;
    [Token(Token = "0x400F543")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Image weaponTypeIcon;
    [Token(Token = "0x400F544")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Image weaponSystemIcon;
    [Token(Token = "0x400F545")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private LimitBreakIcons limitBreakIcons;
    [Token(Token = "0x400F546")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private FavoriteButton favoriteButton;
    [Token(Token = "0x400F547")]
    [FieldOffset(Offset = "0x68")]
    [Header("情報：ステータス部")]
    [SerializeField]
    private TextMeshProUGUI levelText;
    [Token(Token = "0x400F548")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private TextMeshProUGUI maxLevelText;
    [Token(Token = "0x400F549")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private GaugeScale levelExpSlider;
    [Token(Token = "0x400F54A")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private TextMeshProUGUI combatPowerText;
    [Token(Token = "0x400F54B")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private CommonButton detailButton;
    [Token(Token = "0x400F54C")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private TextMeshProUGUI attackText;
    [Token(Token = "0x400F54D")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private TextMeshProUGUI deathBlowText;
    [Token(Token = "0x400F54E")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private TextMeshProUGUI averageText;
    [Token(Token = "0x400F54F")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private TextMeshProUGUI weightText;
    [Token(Token = "0x400F550")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private TextMeshProUGUI dodgeText;
    [Token(Token = "0x400F551")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private Image[] rangeIconImage;
    [Token(Token = "0x400F552")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private TextMeshProUGUI rangeMinText;
    [Token(Token = "0x400F553")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private TextMeshProUGUI rangeMaxText;
    [Token(Token = "0x400F554")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private TextMeshProUGUI enduranceText;
    [Token(Token = "0x400F555")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    [Header("情報：潜在能力")]
    private WeaponOptionEffectContainer[] weaponOptionEffectContainers;
    [Token(Token = "0x400F556")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    [Header("情報：スキル")]
    private DetailSkillListThumb detailSkillList;
    [Token(Token = "0x400F557")]
    [FieldOffset(Offset = "0xE8")]
    [Header("下部")]
    [SerializeField]
    private CommonButton enhancedButton;
    [Token(Token = "0x400F558")]
    [FieldOffset(Offset = "0xF0")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400F559")]
    [FieldOffset(Offset = "0xF8")]
    private IAssetProvider assetProvider;
    [Token(Token = "0x400F55A")]
    [FieldOffset(Offset = "0x100")]
    private bool isLockedOptionEffect;

    [Token(Token = "0x6016189")]
    [Address(RVA = "0x20F4954", Offset = "0x20F4954", VA = "0x20F4954")]
    public static IEnumerator SpawnAsync(
      AssetCachedSpawner spawner,
      Transform parent,
      Action<WeaponListSubMenu> onCompleted)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601618A")]
    [Address(RVA = "0x20F49D0", Offset = "0x20F49D0", VA = "0x20F49D0")]
    public IEnumerator InitializeAsync(
      Action onClickEnhancedButton,
      Action onClickFavoriteButton,
      Action onClickCloseButton)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601618B")]
    [Address(RVA = "0x20F294C", Offset = "0x20F294C", VA = "0x20F294C")]
    public void Refresh(Weapon weapon)
    {
    }

    [Token(Token = "0x601618C")]
    [Address(RVA = "0x20F34A0", Offset = "0x20F34A0", VA = "0x20F34A0")]
    public void PlayIn()
    {
    }

    [Token(Token = "0x601618D")]
    [Address(RVA = "0x20F1F1C", Offset = "0x20F1F1C", VA = "0x20F1F1C")]
    public void PlayOut()
    {
    }

    [Token(Token = "0x601618E")]
    [Address(RVA = "0x20F46D4", Offset = "0x20F46D4", VA = "0x20F46D4")]
    public void SetActiveFavoriteButton(bool isSelectedTThumbFavorite)
    {
    }

    [Token(Token = "0x601618F")]
    [Address(RVA = "0x20F1990", Offset = "0x20F1990", VA = "0x20F1990")]
    public void Disable()
    {
    }

    [Token(Token = "0x6016190")]
    [Address(RVA = "0x20F4D00", Offset = "0x20F4D00", VA = "0x20F4D00")]
    public WeaponListSubMenu()
    {
    }
  }
}
