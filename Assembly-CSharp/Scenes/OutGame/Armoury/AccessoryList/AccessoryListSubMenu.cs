// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Armoury.AccessoryList.AccessoryListSubMenu
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
namespace Scenes.OutGame.Armoury.AccessoryList
{
  [Token(Token = "0x200389D")]
  public class AccessoryListSubMenu : MonoBehaviour
  {
    [Token(Token = "0x400F78E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController timelineController;
    [Token(Token = "0x400F78F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CanvasGroup rightCanvasGroup;
    [Token(Token = "0x400F790")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x400F791")]
    [FieldOffset(Offset = "0x30")]
    [Header("上部")]
    [SerializeField]
    private TextMeshProUGUI nameText;
    [Token(Token = "0x400F792")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x400F793")]
    [FieldOffset(Offset = "0x40")]
    [Header("情報：ヘッダ部")]
    [SerializeField]
    private RarityIcon rarityIcon;
    [Token(Token = "0x400F794")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Image typeIcon;
    [Token(Token = "0x400F795")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private LimitBreakIcons limitBreakIcons;
    [Token(Token = "0x400F796")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private FavoriteButton favoriteButton;
    [Token(Token = "0x400F797")]
    [FieldOffset(Offset = "0x60")]
    [Header("情報：ステータス部")]
    [SerializeField]
    private TextMeshProUGUI levelText;
    [Token(Token = "0x400F798")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private TextMeshProUGUI maxLevelText;
    [Token(Token = "0x400F799")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private GaugeScale levelExpSlider;
    [Token(Token = "0x400F79A")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private TextMeshProUGUI combatPowerText;
    [Token(Token = "0x400F79B")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private CommonButton detailButton;
    [Token(Token = "0x400F79C")]
    [FieldOffset(Offset = "0x88")]
    [Header("情報：盾ステータス部")]
    [SerializeField]
    private GameObject shieldParent;
    [Token(Token = "0x400F79D")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private TextMeshProUGUI attackDefText;
    [Token(Token = "0x400F79E")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private TextMeshProUGUI criticalAvoidText;
    [Token(Token = "0x400F79F")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private TextMeshProUGUI magicalDefText;
    [Token(Token = "0x400F7A0")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private TextMeshProUGUI weightText;
    [Token(Token = "0x400F7A1")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    [Header("情報：装飾品ステータス部")]
    private GameObject accessoryParent;
    [Token(Token = "0x400F7A2")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private TextMeshProUGUI lifeText;
    [Token(Token = "0x400F7A3")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private TextMeshProUGUI speedText;
    [Token(Token = "0x400F7A4")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private TextMeshProUGUI powerText;
    [Token(Token = "0x400F7A5")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private TextMeshProUGUI dexterityText;
    [Token(Token = "0x400F7A6")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private TextMeshProUGUI magicText;
    [Token(Token = "0x400F7A7")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private TextMeshProUGUI luckText;
    [Token(Token = "0x400F7A8")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private TextMeshProUGUI defenceText;
    [Token(Token = "0x400F7A9")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    private TextMeshProUGUI accessoryWeightText;
    [Token(Token = "0x400F7AA")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    private TextMeshProUGUI mindText;
    [Token(Token = "0x400F7AB")]
    [FieldOffset(Offset = "0x100")]
    [Header("情報：潜在能力")]
    [SerializeField]
    private WeaponOptionEffectContainer[] weaponOptionEffectContainers;
    [Token(Token = "0x400F7AC")]
    [FieldOffset(Offset = "0x108")]
    [Header("情報：スキル")]
    [SerializeField]
    private DetailSkillListThumb detailSkillList;
    [Token(Token = "0x400F7AD")]
    [FieldOffset(Offset = "0x110")]
    [SerializeField]
    [Header("下部")]
    private CommonButton enhancedButton;
    [Token(Token = "0x400F7AE")]
    [FieldOffset(Offset = "0x118")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400F7AF")]
    [FieldOffset(Offset = "0x120")]
    private IAssetProvider assetProvider;

    [Token(Token = "0x6016427")]
    [Address(RVA = "0x1DFFCA4", Offset = "0x1DFFCA4", VA = "0x1DFFCA4")]
    public static IEnumerator SpawnAsync(
      AssetCachedSpawner spawner,
      Transform parent,
      Action<AccessoryListSubMenu> onCompleted)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6016428")]
    [Address(RVA = "0x1DFFD20", Offset = "0x1DFFD20", VA = "0x1DFFD20")]
    public IEnumerator InitializeAsync(
      Action onClickEnhancedButton,
      Action onClickFavoriteButton,
      Action onClickCloseButton)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6016429")]
    [Address(RVA = "0x1DFDD1C", Offset = "0x1DFDD1C", VA = "0x1DFDD1C")]
    public void Refresh(Accessory accessory)
    {
    }

    [Token(Token = "0x601642A")]
    [Address(RVA = "0x1DFE7A4", Offset = "0x1DFE7A4", VA = "0x1DFE7A4")]
    public void PlayIn()
    {
    }

    [Token(Token = "0x601642B")]
    [Address(RVA = "0x1DFD3A4", Offset = "0x1DFD3A4", VA = "0x1DFD3A4")]
    public void PlayOut()
    {
    }

    [Token(Token = "0x601642C")]
    [Address(RVA = "0x1DFFA20", Offset = "0x1DFFA20", VA = "0x1DFFA20")]
    public void SetActiveFavoriteButton(bool isSelectedTThumbFavorite)
    {
    }

    [Token(Token = "0x601642D")]
    [Address(RVA = "0x1DFCE30", Offset = "0x1DFCE30", VA = "0x1DFCE30")]
    public void Disable()
    {
    }

    [Token(Token = "0x601642E")]
    [Address(RVA = "0x1E00048", Offset = "0x1E00048", VA = "0x1E00048")]
    private void UpdateStatusText(Accessory accessory)
    {
    }

    [Token(Token = "0x601642F")]
    [Address(RVA = "0x1E00258", Offset = "0x1E00258", VA = "0x1E00258")]
    public AccessoryListSubMenu()
    {
    }
  }
}
