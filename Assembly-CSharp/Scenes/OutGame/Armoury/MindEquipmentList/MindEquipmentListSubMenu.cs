// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Armoury.MindEquipmentList.MindEquipmentListSubMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Input;
using Il2CppDummyDll;
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

#nullable disable
namespace Scenes.OutGame.Armoury.MindEquipmentList
{
  [Token(Token = "0x200385F")]
  public class MindEquipmentListSubMenu : MonoBehaviour
  {
    [Token(Token = "0x400F615")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController timelineController;
    [Token(Token = "0x400F616")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CanvasGroup rightCanvasGroup;
    [Token(Token = "0x400F617")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x400F618")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    [Header("上部")]
    private TextMeshProUGUI nameText;
    [Token(Token = "0x400F619")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x400F61A")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    [Header("情報：ヘッダ部")]
    private RarityIcon rarityIcon;
    [Token(Token = "0x400F61B")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private LimitBreakIcons limitBreakIcons;
    [Token(Token = "0x400F61C")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private FavoriteButton favoriteButton;
    [Token(Token = "0x400F61D")]
    [FieldOffset(Offset = "0x58")]
    [Header("情報：ステータス部")]
    [SerializeField]
    private TextMeshProUGUI levelText;
    [Token(Token = "0x400F61E")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private TextMeshProUGUI maxLevelText;
    [Token(Token = "0x400F61F")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private GaugeScale levelExpSlider;
    [Token(Token = "0x400F620")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private TextMeshProUGUI combatPowerText;
    [Token(Token = "0x400F621")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private CommonButton detailButton;
    [Token(Token = "0x400F622")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private TextMeshProUGUI hpText;
    [Token(Token = "0x400F623")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private TextMeshProUGUI hitText;
    [Token(Token = "0x400F624")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private TextMeshProUGUI physicalAttackText;
    [Token(Token = "0x400F625")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private TextMeshProUGUI avoidText;
    [Token(Token = "0x400F626")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private TextMeshProUGUI magicalAttackText;
    [Token(Token = "0x400F627")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private TextMeshProUGUI criticalText;
    [Token(Token = "0x400F628")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private TextMeshProUGUI physicalDefText;
    [Token(Token = "0x400F629")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private TextMeshProUGUI criticalAvoidText;
    [Token(Token = "0x400F62A")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private TextMeshProUGUI magicalDefText;
    [Token(Token = "0x400F62B")]
    [FieldOffset(Offset = "0xC8")]
    [Header("情報：スキル")]
    [SerializeField]
    private DetailSkillListThumb detailSkillList;
    [Token(Token = "0x400F62C")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private DetailSkillListThumb customSkillList;
    [Token(Token = "0x400F62D")]
    [FieldOffset(Offset = "0xD8")]
    [Header("下部")]
    [SerializeField]
    private CommonButton enhancedButton;
    [Token(Token = "0x400F62E")]
    [FieldOffset(Offset = "0xE0")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400F62F")]
    [FieldOffset(Offset = "0xE8")]
    private IAssetProvider assetProvider;

    [Token(Token = "0x6016297")]
    [Address(RVA = "0x1DEDD88", Offset = "0x1DEDD88", VA = "0x1DEDD88")]
    public static IEnumerator SpawnAsync(
      AssetCachedSpawner spawner,
      Transform parent,
      Action<MindEquipmentListSubMenu> onCompleted)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6016298")]
    [Address(RVA = "0x1DEDE2C", Offset = "0x1DEDE2C", VA = "0x1DEDE2C")]
    public IEnumerator InitializeAsync(
      Action onClickStatusButton,
      Action onClickFavoriteButton,
      Action onClickCloseButton)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6016299")]
    [Address(RVA = "0x1DEDEDC", Offset = "0x1DEDEDC", VA = "0x1DEDEDC")]
    public void Refresh(MindEquipment mindEquipment, bool isPossessing)
    {
    }

    [Token(Token = "0x601629A")]
    [Address(RVA = "0x1DEE4C8", Offset = "0x1DEE4C8", VA = "0x1DEE4C8")]
    public void PlayIn()
    {
    }

    [Token(Token = "0x601629B")]
    [Address(RVA = "0x1DEE544", Offset = "0x1DEE544", VA = "0x1DEE544")]
    public void PlayOut()
    {
    }

    [Token(Token = "0x601629C")]
    [Address(RVA = "0x1DEE5C0", Offset = "0x1DEE5C0", VA = "0x1DEE5C0")]
    public void SetActiveFavoriteButton(bool isSelectedTThumbFavorite)
    {
    }

    [Token(Token = "0x601629D")]
    [Address(RVA = "0x1DEE5E0", Offset = "0x1DEE5E0", VA = "0x1DEE5E0")]
    public void Disable()
    {
    }

    [Token(Token = "0x601629E")]
    [Address(RVA = "0x1DEE618", Offset = "0x1DEE618", VA = "0x1DEE618")]
    public MindEquipmentListSubMenu()
    {
    }
  }
}
