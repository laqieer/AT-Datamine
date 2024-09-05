// Decompiled with JetBrains decompiler
// Type: Gacha.GachaResultRewardListItemView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.UIControls;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections.Generic;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Gacha
{
  [Token(Token = "0x2001524")]
  public class GachaResultRewardListItemView : MonoBehaviour
  {
    [Token(Token = "0x4006118")]
    public const string ThumbnailPrefabAssetBundleName = "ui_common_thumb";
    [Token(Token = "0x4006119")]
    public const string ItemThumbnailPrefabAssetName = "Com_ItemThumb";
    [Token(Token = "0x400611A")]
    public const string ElementIconPrefabAssetBundleName = "ui_common_prefabs";
    [Token(Token = "0x400611B")]
    public const string ElementIconPrefabAssetName = "Com_ElementIcon";
    [Token(Token = "0x400611C")]
    [FieldOffset(Offset = "0x18")]
    [Header("報酬種別 [スタイル] の表示に使用")]
    [SerializeField]
    private GachaResultRewardListItemView.RewardView styleObjects;
    [Token(Token = "0x400611D")]
    [FieldOffset(Offset = "0x20")]
    [Header("報酬種別 [スタイルの欠片] の表示に使用")]
    [SerializeField]
    private GachaResultRewardListItemView.RewardView stylePieceObjects;
    [Token(Token = "0x400611E")]
    [FieldOffset(Offset = "0x28")]
    [Header("報酬種別 [念装] の表示に使用")]
    [SerializeField]
    private GachaResultRewardListItemView.RewardView mnemnographObjects;
    [Token(Token = "0x400611F")]
    [FieldOffset(Offset = "0x30")]
    [Header("報酬種別 [念装(獲得済み)] の表示に使用")]
    [SerializeField]
    private GachaResultRewardListItemView.RewardView acquiredMnemnographObjects;
    [Token(Token = "0x4006120")]
    [FieldOffset(Offset = "0x38")]
    [Header("報酬種別 [アイテム] の表示に使用")]
    [SerializeField]
    private GachaResultRewardListItemView.RewardView itemObjects;
    [Token(Token = "0x4006121")]
    [FieldOffset(Offset = "0x40")]
    [Header("レアリティごとの表示の切り替えに使用")]
    [SerializeField]
    private RarityView[] rarityViews;
    [Token(Token = "0x4006122")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    [Header("欠片アイコンの生成先の親")]
    private RectTransform rewardPieceParent;
    [Token(Token = "0x4006123")]
    [FieldOffset(Offset = "0x50")]
    [Header("巻物アイコンの生成先の親")]
    [SerializeField]
    private RectTransform rewardScrollParent;
    [Token(Token = "0x4006124")]
    [FieldOffset(Offset = "0x58")]
    [Header("属性アイコンの生成先の親")]
    [SerializeField]
    private RectTransform elementIconParent;
    [Token(Token = "0x4006125")]
    [FieldOffset(Offset = "0x60")]
    [Header("New バッジ")]
    [SerializeField]
    private GameObject newBadge;
    [Token(Token = "0x4006126")]
    [FieldOffset(Offset = "0x68")]
    [Header("アイテム表示用サムネ")]
    [SerializeField]
    private ItemIcon itemThumbnailPrefab;
    [Token(Token = "0x4006127")]
    [FieldOffset(Offset = "0x70")]
    private ElementIconView elementIconPrefab;
    [Token(Token = "0x4006128")]
    [FieldOffset(Offset = "0x78")]
    private ElementIconView elementIconView;
    [Token(Token = "0x4006129")]
    [FieldOffset(Offset = "0x80")]
    private ItemIcon pieceIcon;
    [Token(Token = "0x400612A")]
    [FieldOffset(Offset = "0x88")]
    private List<GachaResultRewardListItemView.RewardView> rewardViews;
    [Token(Token = "0x400612B")]
    [FieldOffset(Offset = "0x90")]
    private IRewardListItemPresenter presenter;

    [Token(Token = "0x1700126A")]
    public IRewardListItemPresenter Presenter
    {
      [Token(Token = "0x6007790"), Address(RVA = "0x44F3760", Offset = "0x44F3760", VA = "0x44F3760")] set
      {
      }
    }

    [Token(Token = "0x6007791")]
    [Address(RVA = "0x44F3808", Offset = "0x44F3808", VA = "0x44F3808")]
    public void PrepareSetup(bool isNew, RarityTypeEnum rarityType)
    {
    }

    [Token(Token = "0x6007792")]
    [Address(RVA = "0x44F3AA4", Offset = "0x44F3AA4", VA = "0x44F3AA4")]
    private void DisableAllRewardView()
    {
    }

    [Token(Token = "0x6007793")]
    [Address(RVA = "0x44F3CDC", Offset = "0x44F3CDC", VA = "0x44F3CDC")]
    public void SetupStyleImage(Sprite sprite)
    {
    }

    [Token(Token = "0x6007794")]
    [Address(RVA = "0x44F3D40", Offset = "0x44F3D40", VA = "0x44F3D40")]
    public void SetupStylePieceImage(Sprite fullImageSprite)
    {
    }

    [Token(Token = "0x6007795")]
    [Address(RVA = "0x44F3D88", Offset = "0x44F3D88", VA = "0x44F3D88")]
    public void SetupNewMindEquipmentImage(Sprite sprite)
    {
    }

    [Token(Token = "0x6007796")]
    [Address(RVA = "0x44F3DD0", Offset = "0x44F3DD0", VA = "0x44F3DD0")]
    public void SetupAcquiredMindEquipmentImage(Sprite sprite)
    {
    }

    [Token(Token = "0x6007797")]
    [Address(RVA = "0x44F3E18", Offset = "0x44F3E18", VA = "0x44F3E18")]
    public void SetupItemImage(Sprite sprite)
    {
    }

    [Token(Token = "0x6007798")]
    [Address(RVA = "0x44F3E60", Offset = "0x44F3E60", VA = "0x44F3E60")]
    public void SetupItemQuantity(int num)
    {
    }

    [Token(Token = "0x6007799")]
    [Address(RVA = "0x44F3BE8", Offset = "0x44F3BE8", VA = "0x44F3BE8")]
    public void SetIsNew(bool isNew)
    {
    }

    [Token(Token = "0x600779A")]
    [Address(RVA = "0x44F3C08", Offset = "0x44F3C08", VA = "0x44F3C08")]
    public void SetRarity(RarityTypeEnum rarityType)
    {
    }

    [Token(Token = "0x600779B")]
    [Address(RVA = "0x44F3F80", Offset = "0x44F3F80", VA = "0x44F3F80")]
    public void SetElementIcon(ElementTypeEnum elementType)
    {
    }

    [Token(Token = "0x600779C")]
    [Address(RVA = "0x44F40CC", Offset = "0x44F40CC", VA = "0x44F40CC")]
    public void SetupPieceThumbnail(
      Sprite iconSprite,
      ItemUtility.Parameter itemParameter,
      int rewardQuantity)
    {
    }

    [Token(Token = "0x600779D")]
    private T GetPrefab<T>(string assetBundleName, string assetName) where T : Component
    {
      return (T) null;
    }

    [Token(Token = "0x600779E")]
    [Address(RVA = "0x44F418C", Offset = "0x44F418C", VA = "0x44F418C")]
    private ItemIcon GetItemThumbnailPrefabAsset() => (ItemIcon) null;

    [Token(Token = "0x600779F")]
    [Address(RVA = "0x44F404C", Offset = "0x44F404C", VA = "0x44F404C")]
    private ElementIconView GetElementIconPrefabAsset() => (ElementIconView) null;

    [Token(Token = "0x60077A0")]
    [Address(RVA = "0x44F420C", Offset = "0x44F420C", VA = "0x44F420C")]
    public GachaResultRewardListItemView()
    {
    }

    [Token(Token = "0x2001525")]
    [Serializable]
    private class RewardView
    {
      [Token(Token = "0x400612C")]
      [FieldOffset(Offset = "0x10")]
      [SerializeField]
      private Image imageLarge;
      [Token(Token = "0x400612D")]
      [FieldOffset(Offset = "0x18")]
      [SerializeField]
      private GameObject[] activateObjects;
      [Token(Token = "0x400612E")]
      [FieldOffset(Offset = "0x20")]
      [SerializeField]
      private TextMeshProUGUI itemNumText;

      [Token(Token = "0x60077A1")]
      [Address(RVA = "0x44F3C74", Offset = "0x44F3C74", VA = "0x44F3C74")]
      public void SetActive(bool isActive)
      {
      }

      [Token(Token = "0x60077A2")]
      [Address(RVA = "0x44F3D24", Offset = "0x44F3D24", VA = "0x44F3D24")]
      public void SetImage(Sprite sprite)
      {
      }

      [Token(Token = "0x60077A3")]
      [Address(RVA = "0x44F3E9C", Offset = "0x44F3E9C", VA = "0x44F3E9C")]
      public void SetQuantity(int quantity)
      {
      }

      [Token(Token = "0x60077A4")]
      [Address(RVA = "0x44F4288", Offset = "0x44F4288", VA = "0x44F4288")]
      public RewardView()
      {
      }
    }
  }
}
