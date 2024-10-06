// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.ItemListThumb
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using Il2CppDummyDll;
using Scenes.OutGame.Armoury.ItemList;
using Scenes.OutGame.Common;
using StaqData;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x20039D6")]
  public class ItemListThumb : MonoBehaviour
  {
    [Token(Token = "0x400FD01")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400FD02")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private LongPressButton longPressButton;
    [Token(Token = "0x400FD03")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Image thumbnailImage;
    [Token(Token = "0x400FD04")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Image thumbnailImageLoadingIcon;
    [Token(Token = "0x400FD05")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Image rarityBaseImage;
    [Token(Token = "0x400FD06")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject[] itemRarity;
    [Token(Token = "0x400FD07")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private TextMeshProUGUI itemName;
    [Token(Token = "0x400FD08")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private NewBadge newBadge;
    [Token(Token = "0x400FD09")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Text itemPossession;
    [Token(Token = "0x400FD0A")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GameObject timeLimit;
    [Token(Token = "0x400FD0B")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private TextMeshProUGUI timeLimitText;
    [Token(Token = "0x400FD0C")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private GameObject AcquiredBadge;
    [Token(Token = "0x400FD0D")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private GameObject EquipBadge;
    [Token(Token = "0x400FD0E")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private GameObject elementImage;
    [Token(Token = "0x400FD0F")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private GameObject ordinalNum;
    [Token(Token = "0x400FD10")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Image rarityImage;
    [Token(Token = "0x400FD11")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private GameObject FavoriteImage;
    [Token(Token = "0x400FD12")]
    [FieldOffset(Offset = "0xA0")]
    public bool use;
    [Token(Token = "0x400FD13")]
    [FieldOffset(Offset = "0xA4")]
    private int itemIndex;
    [Token(Token = "0x400FD14")]
    [FieldOffset(Offset = "0xA8")]
    private ItemListBelowScreen.eItemListKind itemKind;
    [Token(Token = "0x400FD15")]
    [FieldOffset(Offset = "0xB0")]
    private ItemListBelowScreen itemListBelowScreen;
    [Token(Token = "0x400FD16")]
    [FieldOffset(Offset = "0xB8")]
    private ItemListThumb.eThumbAssetBundleState thumbAssetBundleState;
    [Token(Token = "0x400FD17")]
    [FieldOffset(Offset = "0xBC")]
    public bool onDisp;
    [Token(Token = "0x400FD18")]
    [FieldOffset(Offset = "0xC0")]
    private string thumbAssetBundleName;
    [Token(Token = "0x400FD19")]
    [FieldOffset(Offset = "0xC8")]
    private string thumbAssetName;
    [Token(Token = "0x400FD1A")]
    [FieldOffset(Offset = "0xD0")]
    private Sprite thumbSprite;
    [Token(Token = "0x400FD1B")]
    [FieldOffset(Offset = "0xD8")]
    private ArmouryItemThumbResource armouryItemResource;

    [Token(Token = "0x17004AB1")]
    public LongPressButton thumbnailButton
    {
      [Token(Token = "0x6016B75"), Address(RVA = "0x3F6CE68", Offset = "0x3F6CE68", VA = "0x3F6CE68")] get
      {
        return (LongPressButton) null;
      }
    }

    [Token(Token = "0x6016B76")]
    [Address(RVA = "0x3F6CE70", Offset = "0x3F6CE70", VA = "0x3F6CE70")]
    public void Initialize(
      ItemListBelowScreen belowScreen,
      int idx,
      ItemListBelowScreen.eItemListKind kind,
      Action<int, ItemListBelowScreen.eItemListKind> onClick,
      Action<int, ItemListBelowScreen.eItemListKind> onLongPress)
    {
    }

    [Token(Token = "0x6016B77")]
    [Address(RVA = "0x3F6D980", Offset = "0x3F6D980", VA = "0x3F6D980")]
    public void RemoveCallBack()
    {
    }

    [Token(Token = "0x6016B78")]
    [Address(RVA = "0x3F6D550", Offset = "0x3F6D550", VA = "0x3F6D550")]
    private void SetTimeLimit(Item item)
    {
    }

    [Token(Token = "0x6016B79")]
    [Address(RVA = "0x3F6D9E0", Offset = "0x3F6D9E0", VA = "0x3F6D9E0")]
    private void ShowTimeLimit(string text)
    {
    }

    [Token(Token = "0x6016B7A")]
    [Address(RVA = "0x3F6D9C0", Offset = "0x3F6D9C0", VA = "0x3F6D9C0")]
    private void HideTimeLimit()
    {
    }

    [Token(Token = "0x6016B7B")]
    [Address(RVA = "0x3F6DA1C", Offset = "0x3F6DA1C", VA = "0x3F6DA1C")]
    public UITweenGroup GetUITweenGroup() => (UITweenGroup) null;

    [Token(Token = "0x6016B7C")]
    [Address(RVA = "0x3F6DA24", Offset = "0x3F6DA24", VA = "0x3F6DA24")]
    public void SelectOut()
    {
    }

    [Token(Token = "0x6016B7D")]
    [Address(RVA = "0x3F6DA7C", Offset = "0x3F6DA7C", VA = "0x3F6DA7C")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x6016B7E")]
    [Address(RVA = "0x3F6DC04", Offset = "0x3F6DC04", VA = "0x3F6DC04")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6016B7F")]
    [Address(RVA = "0x3F6DAE4", Offset = "0x3F6DAE4", VA = "0x3F6DAE4")]
    private void DestroyThumbSprite()
    {
    }

    [Token(Token = "0x6016B80")]
    [Address(RVA = "0x3F6D918", Offset = "0x3F6D918", VA = "0x3F6D918")]
    public void UpdatePrameter()
    {
    }

    [Token(Token = "0x6016B81")]
    [Address(RVA = "0x3F6D4BC", Offset = "0x3F6D4BC", VA = "0x3F6D4BC")]
    public void SetNew(bool isNew)
    {
    }

    [Token(Token = "0x6016B82")]
    [Address(RVA = "0x3F6DC08", Offset = "0x3F6DC08", VA = "0x3F6DC08")]
    public ItemListThumb()
    {
    }

    [Token(Token = "0x20039D7")]
    private enum eThumbAssetBundleState
    {
      [Token(Token = "0x400FD1D")] Nothing,
      [Token(Token = "0x400FD1E")] Loading,
      [Token(Token = "0x400FD1F")] Display,
    }
  }
}
