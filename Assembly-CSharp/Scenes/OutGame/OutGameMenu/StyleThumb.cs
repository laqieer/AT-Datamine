// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.StyleThumb
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.Tween;
using Il2CppDummyDll;
using System;
using System.Collections;
using TMPro;
using UI;
using UI.Common;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003ADD")]
  public class StyleThumb : MonoBehaviour
  {
    [Token(Token = "0x4010338")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x4010339")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private LongPressButton longPressButton;
    [Token(Token = "0x401033A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Image thumbnailImage;
    [Token(Token = "0x401033B")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject starObj;
    [Token(Token = "0x401033C")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Image[] starImage;
    [Token(Token = "0x401033D")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private LimitBreakIcons gemController;
    [Token(Token = "0x401033E")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private ElementIconView elementView;
    [Token(Token = "0x401033F")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject elementObj;
    [Token(Token = "0x4010340")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private TextMeshProUGUI combatPowerText;
    [Token(Token = "0x4010341")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Text levelText;
    [Token(Token = "0x4010342")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private TextMeshProUGUI levelTMP;
    [Token(Token = "0x4010343")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private TextMeshProUGUI releaseRatioText;
    [Token(Token = "0x4010344")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Text amountText;
    [Token(Token = "0x4010345")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private Image disenabledMask;
    [Token(Token = "0x4010346")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private GameObject settingUpperObj;
    [Token(Token = "0x4010347")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private GameObject organized;
    [Token(Token = "0x4010348")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private GameObject alreadyDispatched;
    [Token(Token = "0x4010349")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private StyleTrainingRankIcon rankIcon;
    [Token(Token = "0x401034A")]
    [FieldOffset(Offset = "0xA8")]
    private string NotPossessedLevelText;
    [Token(Token = "0x401034B")]
    [FieldOffset(Offset = "0xB0")]
    private int styleID;
    [Token(Token = "0x401034C")]
    [FieldOffset(Offset = "0xB4")]
    public int itemIndex;
    [Token(Token = "0x401034D")]
    [FieldOffset(Offset = "0xB8")]
    public bool enable;
    [Token(Token = "0x401034E")]
    [FieldOffset(Offset = "0xB9")]
    public bool selected;
    [Token(Token = "0x401034F")]
    [FieldOffset(Offset = "0xC0")]
    private StyleScreen _styleScreen;
    [Token(Token = "0x4010350")]
    [FieldOffset(Offset = "0xC8")]
    public StyleThumb.ThumbnailState thumbnailState;
    [Token(Token = "0x4010351")]
    [FieldOffset(Offset = "0xD0")]
    private string thumbAssetBundleName;
    [Token(Token = "0x4010352")]
    [FieldOffset(Offset = "0xD8")]
    private Sprite thumbSprite;
    [Token(Token = "0x4010353")]
    [FieldOffset(Offset = "0xE0")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x4010354")]
    [FieldOffset(Offset = "0xE8")]
    private AssetSpawnOperation<Sprite> AcsOperationItem;

    [Token(Token = "0x17004BA5")]
    public LongPressButton thumbnailButton
    {
      [Token(Token = "0x6017289"), Address(RVA = "0x300FBCC", Offset = "0x300FBCC", VA = "0x300FBCC")] get
      {
        return (LongPressButton) null;
      }
    }

    [Token(Token = "0x17004BA6")]
    public int StyleID
    {
      [Token(Token = "0x601728A"), Address(RVA = "0x300FBD4", Offset = "0x300FBD4", VA = "0x300FBD4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x601728B")]
    [Address(RVA = "0x300FBDC", Offset = "0x300FBDC", VA = "0x300FBDC")]
    public void Initialize()
    {
    }

    [Token(Token = "0x601728C")]
    [Address(RVA = "0x300FE60", Offset = "0x300FE60", VA = "0x300FE60")]
    public void Initialize(
      int styleId,
      int idx,
      Action<int> onClickAction,
      Action<int> onLongPressAction,
      bool isApplyLost = false,
      AssetCachedSpawner spawner = null)
    {
    }

    [Token(Token = "0x601728D")]
    [Address(RVA = "0x30102EC", Offset = "0x30102EC", VA = "0x30102EC")]
    public void Initialize(Sprite sprite, Action onClickAction)
    {
    }

    [Token(Token = "0x601728E")]
    [Address(RVA = "0x3010504", Offset = "0x3010504", VA = "0x3010504")]
    public IEnumerator InitializeAsync(
      int styleId,
      int idx,
      Action<int> onClickAction,
      Action<int> onLongPressAction,
      AssetCachedSpawner spawner = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601728F")]
    [Address(RVA = "0x30105CC", Offset = "0x30105CC", VA = "0x30105CC")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x6017290")]
    [Address(RVA = "0x3010670", Offset = "0x3010670", VA = "0x3010670")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6017291")]
    [Address(RVA = "0x30106CC", Offset = "0x30106CC", VA = "0x30106CC")]
    public IEnumerator LoadThumb(int styleId) => (IEnumerator) null;

    [Token(Token = "0x6017292")]
    [Address(RVA = "0x3010188", Offset = "0x3010188", VA = "0x3010188")]
    private IEnumerator SetLoadThumb() => (IEnumerator) null;

    [Token(Token = "0x6017293")]
    [Address(RVA = "0x30106A0", Offset = "0x30106A0", VA = "0x30106A0")]
    private void CancelThumb()
    {
    }

    [Token(Token = "0x6017294")]
    [Address(RVA = "0x30105D0", Offset = "0x30105D0", VA = "0x30105D0")]
    private void DestroyThumbSprite()
    {
    }

    [Token(Token = "0x6017295")]
    [Address(RVA = "0x30103EC", Offset = "0x30103EC", VA = "0x30103EC")]
    public void SetThumbnailImage(Sprite sprite)
    {
    }

    [Token(Token = "0x6017296")]
    [Address(RVA = "0x3010794", Offset = "0x3010794", VA = "0x3010794")]
    public void SetupEmptyIcon(bool isEmpty)
    {
    }

    [Token(Token = "0x6017297")]
    [Address(RVA = "0x30107C8", Offset = "0x30107C8", VA = "0x30107C8")]
    public void SetStar(RarityStarTypeEnum rarityStar, bool isTweenSetting)
    {
    }

    [Token(Token = "0x6017298")]
    [Address(RVA = "0x3010AD4", Offset = "0x3010AD4", VA = "0x3010AD4")]
    public void SetActiveStar(bool isActive)
    {
    }

    [Token(Token = "0x6017299")]
    [Address(RVA = "0x3010914", Offset = "0x3010914", VA = "0x3010914")]
    public void SetStar(RarityStarTypeEnum rarityStar)
    {
    }

    [Token(Token = "0x601729A")]
    [Address(RVA = "0x3010B6C", Offset = "0x3010B6C", VA = "0x3010B6C")]
    public void SetStar(int rarityStar)
    {
    }

    [Token(Token = "0x601729B")]
    [Address(RVA = "0x3010C10", Offset = "0x3010C10", VA = "0x3010C10")]
    public void SetLimitBreak(int limitBreak)
    {
    }

    [Token(Token = "0x601729C")]
    [Address(RVA = "0x3010CAC", Offset = "0x3010CAC", VA = "0x3010CAC")]
    public void SetActiveLimitBreak(bool value)
    {
    }

    [Token(Token = "0x601729D")]
    [Address(RVA = "0x3010D50", Offset = "0x3010D50", VA = "0x3010D50")]
    public void SetElement(ElementTypeEnum element, bool enable)
    {
    }

    [Token(Token = "0x601729E")]
    [Address(RVA = "0x3010DA0", Offset = "0x3010DA0", VA = "0x3010DA0")]
    public void SetElement(ElementTypeEnum element)
    {
    }

    [Token(Token = "0x601729F")]
    [Address(RVA = "0x3010DC0", Offset = "0x3010DC0", VA = "0x3010DC0")]
    public void SetActiveElement(bool value)
    {
    }

    [Token(Token = "0x60172A0")]
    [Address(RVA = "0x3010DF0", Offset = "0x3010DF0", VA = "0x3010DF0")]
    public void SetCombatPowerText(int combatPower)
    {
    }

    [Token(Token = "0x60172A1")]
    [Address(RVA = "0x3010ED4", Offset = "0x3010ED4", VA = "0x3010ED4")]
    public void SetActiveCombatPowerlText(bool value)
    {
    }

    [Token(Token = "0x60172A2")]
    [Address(RVA = "0x300FCE4", Offset = "0x300FCE4", VA = "0x300FCE4")]
    public void SetLevelText(int level)
    {
    }

    [Token(Token = "0x60172A3")]
    [Address(RVA = "0x3010F1C", Offset = "0x3010F1C", VA = "0x3010F1C")]
    public void SetActiveLevelText(bool value)
    {
    }

    [Token(Token = "0x60172A4")]
    [Address(RVA = "0x3010F64", Offset = "0x3010F64", VA = "0x3010F64")]
    public void SetActiveLevelTMP(bool value)
    {
    }

    [Token(Token = "0x60172A5")]
    [Address(RVA = "0x3010FAC", Offset = "0x3010FAC", VA = "0x3010FAC")]
    public void SetReleaseRatioText(float releaseRatio)
    {
    }

    [Token(Token = "0x60172A6")]
    [Address(RVA = "0x3011090", Offset = "0x3011090", VA = "0x3011090")]
    public void SetActiveReleaseRatioText(bool value)
    {
    }

    [Token(Token = "0x60172A7")]
    [Address(RVA = "0x301114C", Offset = "0x301114C", VA = "0x301114C")]
    public void SetDisenabledMask(bool flg)
    {
    }

    [Token(Token = "0x60172A8")]
    [Address(RVA = "0x30111AC", Offset = "0x30111AC", VA = "0x30111AC")]
    public void SetDisenabledMask(bool flg, bool enableButton)
    {
    }

    [Token(Token = "0x60172A9")]
    [Address(RVA = "0x3011210", Offset = "0x3011210", VA = "0x3011210")]
    public void PlaySelectTween(bool select)
    {
    }

    [Token(Token = "0x60172AA")]
    [Address(RVA = "0x3011288", Offset = "0x3011288", VA = "0x3011288")]
    public void PlaySelectTweenV2(bool select)
    {
    }

    [Token(Token = "0x60172AB")]
    [Address(RVA = "0x30101F0", Offset = "0x30101F0", VA = "0x30101F0")]
    private void ApplyLost()
    {
    }

    [Token(Token = "0x60172AC")]
    [Address(RVA = "0x3011300", Offset = "0x3011300", VA = "0x3011300")]
    public void PlayLostTween(bool isLost)
    {
    }

    [Token(Token = "0x60172AD")]
    [Address(RVA = "0x3011378", Offset = "0x3011378", VA = "0x3011378")]
    public void SetFavorite(bool isFavorite)
    {
    }

    [Token(Token = "0x60172AE")]
    [Address(RVA = "0x30113F0", Offset = "0x30113F0", VA = "0x30113F0")]
    public void PlayNew(bool isNew)
    {
    }

    [Token(Token = "0x60172AF")]
    [Address(RVA = "0x3011468", Offset = "0x3011468", VA = "0x3011468")]
    public void SetEnhancedBadge(bool canEnhanced)
    {
    }

    [Token(Token = "0x60172B0")]
    [Address(RVA = "0x30114E0", Offset = "0x30114E0", VA = "0x30114E0")]
    public void SetRewardDisplay(
      int rewardId,
      int amount,
      bool showAmount,
      AssetCachedSpawner assetCachedSpawner,
      Action onClick = null)
    {
    }

    [Token(Token = "0x60172B1")]
    [Address(RVA = "0x3011810", Offset = "0x3011810", VA = "0x3011810")]
    public void SetRarityStarActive(int rarityStarType)
    {
    }

    [Token(Token = "0x60172B2")]
    [Address(RVA = "0x3011900", Offset = "0x3011900", VA = "0x3011900")]
    public void SettingUpperSetActive(bool is_active)
    {
    }

    [Token(Token = "0x60172B3")]
    [Address(RVA = "0x3011918", Offset = "0x3011918", VA = "0x3011918")]
    public void SetActiveOrganized(bool value)
    {
    }

    [Token(Token = "0x60172B4")]
    [Address(RVA = "0x30119B0", Offset = "0x30119B0", VA = "0x30119B0")]
    public void SetActiveAlreadyDispatched(bool value)
    {
    }

    [Token(Token = "0x60172B5")]
    [Address(RVA = "0x3011A48", Offset = "0x3011A48", VA = "0x3011A48")]
    public StyleThumb()
    {
    }

    [Token(Token = "0x2003ADE")]
    public enum ThumbnailState
    {
      [Token(Token = "0x4010356")] Nothing,
      [Token(Token = "0x4010357")] Enable,
    }
  }
}
