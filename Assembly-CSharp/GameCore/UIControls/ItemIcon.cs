// Decompiled with JetBrains decompiler
// Type: GameCore.UIControls.ItemIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Tween;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace GameCore.UIControls
{
  [Token(Token = "0x2000BEC")]
  public class ItemIcon : MonoBehaviour
  {
    [Token(Token = "0x4003608")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image iconBase;
    [Token(Token = "0x4003609")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image iconImage;
    [Token(Token = "0x400360A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Image loadingImage;
    [Token(Token = "0x400360B")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Image newBadge;
    [Token(Token = "0x400360C")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private OrdinalBadge ordinalBadge;
    [Token(Token = "0x400360D")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text itemNum;
    [Token(Token = "0x400360E")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Transform layoutRarityTrans;
    [Token(Token = "0x400360F")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject[] layoutRarityStar;
    [Token(Token = "0x4003610")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject elementObj;
    [Token(Token = "0x4003611")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private ElementIconView elementView;
    [Token(Token = "0x4003612")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Transform itemNameTrans;
    [Token(Token = "0x4003613")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private TextMeshProUGUI itemName;
    [Token(Token = "0x4003614")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Image rarityImage;
    [Token(Token = "0x4003615")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private Image equipImgae;
    [Token(Token = "0x4003616")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Image favoriteImage;
    [Token(Token = "0x4003617")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x4003618")]
    [FieldOffset(Offset = "0x98")]
    public Action<ItemIcon> clickAction;
    [Token(Token = "0x4003619")]
    [FieldOffset(Offset = "0xA0")]
    private List<string> onEnablePlayTweenGroupIDs;
    [Token(Token = "0x400361A")]
    [FieldOffset(Offset = "0xA8")]
    private AssetSpawnOperation<Sprite> AcsOperationItem;

    [Token(Token = "0x600441C")]
    [Address(RVA = "0x3645E2C", Offset = "0x3645E2C", VA = "0x3645E2C")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x600441D")]
    [Address(RVA = "0x3645E30", Offset = "0x3645E30", VA = "0x3645E30")]
    public void PlayReservedTween()
    {
    }

    [Token(Token = "0x600441E")]
    [Address(RVA = "0x3645F18", Offset = "0x3645F18", VA = "0x3645F18")]
    private void OnValidate()
    {
    }

    [Token(Token = "0x600441F")]
    [Address(RVA = "0x3645F68", Offset = "0x3645F68", VA = "0x3645F68")]
    public void FinishSetup()
    {
    }

    [Token(Token = "0x6004420")]
    [Address(RVA = "0x3645FE8", Offset = "0x3645FE8", VA = "0x3645FE8")]
    public void CancelRequest(AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x6004421")]
    [Address(RVA = "0x3646018", Offset = "0x3646018", VA = "0x3646018")]
    public void LoadItemImage(ItemTypeEnum itemType, int id)
    {
    }

    [Token(Token = "0x6004422")]
    [Address(RVA = "0x36461A8", Offset = "0x36461A8", VA = "0x36461A8")]
    public void LoadItemImage(RewardTypeEnum rewardType, int id)
    {
    }

    [Token(Token = "0x6004423")]
    [Address(RVA = "0x3646220", Offset = "0x3646220", VA = "0x3646220")]
    public void LoadItemImageWithOption(
      ItemUtility.Parameter param,
      int quantity = 0,
      ElementTypeEnum element = ElementTypeEnum.NON,
      int order = 0,
      bool isName = false,
      bool isNum = false,
      bool isElement = false,
      bool isFavorite = false,
      bool isLoading = false,
      bool isNewBadge = false,
      bool isOrdinalBadge = false,
      bool isOrdinalBadgeFlick = false)
    {
    }

    [Token(Token = "0x6004424")]
    [Address(RVA = "0x3646724", Offset = "0x3646724", VA = "0x3646724")]
    private bool ValidateIconAssetName(ItemUtility.Parameter param) => new bool();

    [Token(Token = "0x6004425")]
    [Address(RVA = "0x3646088", Offset = "0x3646088", VA = "0x3646088")]
    public void LoadItemImage(ItemUtility.Parameter param)
    {
    }

    [Token(Token = "0x6004426")]
    [Address(RVA = "0x3646888", Offset = "0x3646888", VA = "0x3646888")]
    public void LoadItemImage(
      AssetCachedSpawner assetCachedSpawner,
      ItemUtility.Parameter param,
      bool spawnerRequestStart = true)
    {
    }

    [Token(Token = "0x6004427")]
    [Address(RVA = "0x3646B0C", Offset = "0x3646B0C", VA = "0x3646B0C")]
    public void LoadItemImageHighResolution(
      AssetCachedSpawner assetCachedSpawner,
      ItemUtility.Parameter param,
      bool spawnerRequestStart)
    {
    }

    [Token(Token = "0x6004428")]
    [Address(RVA = "0x3646C70", Offset = "0x3646C70", VA = "0x3646C70")]
    public IEnumerator ItemIconLoadAsync(
      AssetCachedSpawner assetCachedSpawner,
      ItemUtility.Parameter param)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6004429")]
    [Address(RVA = "0x3646744", Offset = "0x3646744", VA = "0x3646744")]
    public void SetBaseImage(Sprite sprite)
    {
    }

    [Token(Token = "0x600442A")]
    [Address(RVA = "0x36467DC", Offset = "0x36467DC", VA = "0x36467DC")]
    public void SetIconImage(Sprite sprite)
    {
    }

    [Token(Token = "0x600442B")]
    [Address(RVA = "0x36469EC", Offset = "0x36469EC", VA = "0x36469EC")]
    public void SetLoadingActive(bool isActive)
    {
    }

    [Token(Token = "0x600442C")]
    [Address(RVA = "0x3646564", Offset = "0x3646564", VA = "0x3646564")]
    public void SetNewBadgeActive(bool isActive)
    {
    }

    [Token(Token = "0x600442D")]
    [Address(RVA = "0x3646D20", Offset = "0x3646D20", VA = "0x3646D20")]
    public void SetNewBadgeActive(bool isActive, bool isFlick)
    {
    }

    [Token(Token = "0x600442E")]
    [Address(RVA = "0x3646570", Offset = "0x3646570", VA = "0x3646570")]
    public void SetOrdinalBadgeActive(bool isActive, int order, bool isFlick)
    {
    }

    [Token(Token = "0x600442F")]
    [Address(RVA = "0x3646E80", Offset = "0x3646E80", VA = "0x3646E80")]
    public void SetRarityImageActive(bool isActive)
    {
    }

    [Token(Token = "0x6004430")]
    [Address(RVA = "0x3646EB8", Offset = "0x3646EB8", VA = "0x3646EB8")]
    public void SetRarityStarActive(bool isActive)
    {
    }

    [Token(Token = "0x6004431")]
    [Address(RVA = "0x36463E4", Offset = "0x36463E4", VA = "0x36463E4")]
    public void SetItemNumActive(bool isActive)
    {
    }

    [Token(Token = "0x6004432")]
    [Address(RVA = "0x3646534", Offset = "0x3646534", VA = "0x3646534")]
    public void SetElementActive(bool isActive)
    {
    }

    [Token(Token = "0x6004433")]
    [Address(RVA = "0x364654C", Offset = "0x364654C", VA = "0x364654C")]
    public void SetElementIcon(ElementTypeEnum elementType)
    {
    }

    [Token(Token = "0x6004434")]
    [Address(RVA = "0x364641C", Offset = "0x364641C", VA = "0x364641C")]
    public void SetItemNum(int itemNum, bool isReward = false)
    {
    }

    [Token(Token = "0x6004435")]
    [Address(RVA = "0x3646EF0", Offset = "0x3646EF0", VA = "0x3646EF0")]
    public void SetItemNum(int numerator, int denominator)
    {
    }

    [Token(Token = "0x6004436")]
    [Address(RVA = "0x3647038", Offset = "0x3647038", VA = "0x3647038")]
    public void SetItemNumWithNotEnoughColor(int numerator, int denominator, string colorCode = "#FF0000")
    {
    }

    [Token(Token = "0x6004437")]
    [Address(RVA = "0x3647064", Offset = "0x3647064", VA = "0x3647064")]
    public void SetItemNumWithNotEnoughColor(int numerator, int denominator, in Color color)
    {
    }

    [Token(Token = "0x6004438")]
    [Address(RVA = "0x3646F78", Offset = "0x3646F78", VA = "0x3646F78")]
    public void SetItemNumText(string text)
    {
    }

    [Token(Token = "0x6004439")]
    [Address(RVA = "0x3647100", Offset = "0x3647100", VA = "0x3647100")]
    public void SetItemNumTextColor(Color color)
    {
    }

    [Token(Token = "0x600443A")]
    [Address(RVA = "0x36471C4", Offset = "0x36471C4", VA = "0x36471C4")]
    public void SetPaymentDisplay(
      ItemTypeEnum itemType,
      int id,
      string numText,
      Color numTextCOlor)
    {
    }

    [Token(Token = "0x600443B")]
    [Address(RVA = "0x36473F0", Offset = "0x36473F0", VA = "0x36473F0")]
    public void SetDetailDisplay(
      ItemUtility.Parameter param,
      AssetCachedSpawner assetCachedSpawner = null,
      bool spawnerRequestStart = true)
    {
    }

    [Token(Token = "0x600443C")]
    [Address(RVA = "0x36475F8", Offset = "0x36475F8", VA = "0x36475F8")]
    public void SetSoulDetail(
      ItemUtility.Parameter param,
      AssetCachedSpawner assetCachedSpawner = null,
      bool spawnerRequestStart = true)
    {
    }

    [Token(Token = "0x600443D")]
    [Address(RVA = "0x36477F8", Offset = "0x36477F8", VA = "0x36477F8")]
    public void SetRewardDisplay(
      ItemUtility.Parameter param,
      int num,
      bool isReward = false,
      AssetCachedSpawner assetCachedSpawner = null,
      bool isRequestStart = true)
    {
    }

    [Token(Token = "0x600443E")]
    [Address(RVA = "0x3647ABC", Offset = "0x3647ABC", VA = "0x3647ABC")]
    public void SetRewardDisplay(
      ItemUtility.Parameter param,
      AssetCachedSpawner assetCachedSpawner = null,
      bool spawnerRequestStart = true)
    {
    }

    [Token(Token = "0x600443F")]
    [Address(RVA = "0x3647CC4", Offset = "0x3647CC4", VA = "0x3647CC4")]
    public void SetItemSetDisplay(
      ItemUtility.Parameter param,
      AssetCachedSpawner assetCachedSpawner,
      bool spawnerRequestStart = false)
    {
    }

    [Token(Token = "0x6004440")]
    [Address(RVA = "0x3647E38", Offset = "0x3647E38", VA = "0x3647E38")]
    public void SetRewardDisplayIgnoreImage(ItemUtility.Parameter param, int num, bool isReward = false)
    {
    }

    [Token(Token = "0x6004441")]
    [Address(RVA = "0x3647F80", Offset = "0x3647F80", VA = "0x3647F80")]
    public IEnumerator SetRewardDisplayAsync(
      AssetCachedSpawner assetCachedSpawner,
      ItemUtility.Parameter param,
      int num,
      bool isReward = false)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6004442")]
    [Address(RVA = "0x364804C", Offset = "0x364804C", VA = "0x364804C")]
    public void SetWeaponLimitBreakDisplay(
      AssetCachedSpawner assetCachedSpawner,
      ItemUtility.Parameter param)
    {
    }

    [Token(Token = "0x6004443")]
    [Address(RVA = "0x36481B8", Offset = "0x36481B8", VA = "0x36481B8")]
    public void SetSkillLvUpDisplay(ItemUtility.Parameter param)
    {
    }

    [Token(Token = "0x6004444")]
    [Address(RVA = "0x3648310", Offset = "0x3648310", VA = "0x3648310")]
    public void SetSkillLvUpDisplay(
      AssetCachedSpawner assetCachedSpawner,
      ItemUtility.Parameter param)
    {
    }

    [Token(Token = "0x6004445")]
    [Address(RVA = "0x364847C", Offset = "0x364847C", VA = "0x364847C")]
    public void SetChapterItemDisplay(int itemId, int num)
    {
    }

    [Token(Token = "0x6004446")]
    [Address(RVA = "0x3648590", Offset = "0x3648590", VA = "0x3648590")]
    public void SetRarityStar(RarityTypeEnum rarityTypeEnum)
    {
    }

    [Token(Token = "0x6004447")]
    [Address(RVA = "0x3648670", Offset = "0x3648670", VA = "0x3648670")]
    public void SetRarityImage(RarityTypeEnum rarityTypeEnum)
    {
    }

    [Token(Token = "0x6004448")]
    [Address(RVA = "0x36487D0", Offset = "0x36487D0", VA = "0x36487D0")]
    public void SetRarityImage(AssetCachedSpawner assetCachedSpawner, RarityTypeEnum rarityTypeEnum)
    {
    }

    [Token(Token = "0x6004449")]
    [Address(RVA = "0x3648938", Offset = "0x3648938", VA = "0x3648938")]
    public IEnumerator LoadAsyncRarityImage(
      AssetCachedSpawner assetCachedSpawner,
      RarityTypeEnum rarityTypeEnum)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600444A")]
    [Address(RVA = "0x36489E0", Offset = "0x36489E0", VA = "0x36489E0")]
    public void OnClick()
    {
    }

    [Token(Token = "0x600444B")]
    [Address(RVA = "0x3646698", Offset = "0x3646698", VA = "0x3646698")]
    public void SetRarityView(
      ItemUtility.RarityViewTypeEnum rarityViewTypeEnum,
      RarityTypeEnum rarityTypeEnum)
    {
    }

    [Token(Token = "0x600444C")]
    [Address(RVA = "0x3647A30", Offset = "0x3647A30", VA = "0x3647A30")]
    public void SetRarityView(
      AssetCachedSpawner assetCachedSpawner,
      ItemUtility.RarityViewTypeEnum rarityViewTypeEnum,
      RarityTypeEnum rarityTypeEnum)
    {
    }

    [Token(Token = "0x600444D")]
    [Address(RVA = "0x3648A00", Offset = "0x3648A00", VA = "0x3648A00")]
    public ItemIcon()
    {
    }
  }
}
