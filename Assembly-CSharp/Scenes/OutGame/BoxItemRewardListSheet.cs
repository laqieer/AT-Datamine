// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.BoxItemRewardListSheet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.UIControls;
using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x20031E2")]
  public class BoxItemRewardListSheet : MonoBehaviour
  {
    [Token(Token = "0x400D4BD")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image imgListBaseEven;
    [Token(Token = "0x400D4BE")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ItemIcon itemIcon;
    [Token(Token = "0x400D4BF")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private MindequipmentThumb mindequipmentThumb;
    [Token(Token = "0x400D4C0")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private StyleThumb styleThumb;
    [Token(Token = "0x400D4C1")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject probability;
    [Token(Token = "0x400D4C2")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private TextMeshProUGUI txtProbability;
    [Token(Token = "0x400D4C3")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private TextMeshProUGUI txtItemName;
    [Token(Token = "0x400D4C4")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private TextMeshProUGUI txtPossessionValue;
    [Token(Token = "0x400D4C5")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject selectionButton;
    [Token(Token = "0x400D4C6")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private TextMeshProUGUI txtCountValue;
    [Token(Token = "0x400D4C7")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private LongPressButton prevButton;
    [Token(Token = "0x400D4C8")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private LongPressButton nextButton;
    [Token(Token = "0x400D4C9")]
    [FieldOffset(Offset = "0x78")]
    private BoxItemContentsData boxItemContentsData;
    [Token(Token = "0x400D4CA")]
    [FieldOffset(Offset = "0x80")]
    private int selectCount;
    [Token(Token = "0x400D4CB")]
    [FieldOffset(Offset = "0x88")]
    private Func<int, bool> addUseCount;
    [Token(Token = "0x400D4CC")]
    [FieldOffset(Offset = "0x90")]
    private Func<bool> getCanAddUseCount;
    [Token(Token = "0x400D4CD")]
    [FieldOffset(Offset = "0x98")]
    private bool canAddUseCount;

    [Token(Token = "0x170040F8")]
    public int SelectId
    {
      [Token(Token = "0x6013780"), Address(RVA = "0x4E0F910", Offset = "0x4E0F910", VA = "0x4E0F910")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170040F9")]
    public int SelectCount
    {
      [Token(Token = "0x6013781"), Address(RVA = "0x4E0F92C", Offset = "0x4E0F92C", VA = "0x4E0F92C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6013782")]
    [Address(RVA = "0x4E0F934", Offset = "0x4E0F934", VA = "0x4E0F934")]
    public void Initialize(
      AssetCachedSpawner assetCachedSpawner,
      BoxItemData boxItemData,
      BoxItemContentsData boxItemContentsData,
      int sheetNumber,
      int maxLotteryWeight,
      Func<int, bool> addUseCount,
      Func<bool> getCanAddUseCount,
      Action<Action> updateAction,
      Action onClickItemIcon)
    {
    }

    [Token(Token = "0x6013783")]
    [Address(RVA = "0x4E0F64C", Offset = "0x4E0F64C", VA = "0x4E0F64C")]
    public void Initialize(
      AssetCachedSpawner assetCachedSpawner,
      BoxItemData boxItemData,
      BoxItemContentsData boxItemContentsData,
      int sheetNumber,
      int maxLotteryWeight,
      Action onClickItemIcon)
    {
    }

    [Token(Token = "0x6013784")]
    [Address(RVA = "0x4E0FFD0", Offset = "0x4E0FFD0", VA = "0x4E0FFD0")]
    private void InitializeBoxItemOpenTypeSelect()
    {
    }

    [Token(Token = "0x6013785")]
    [Address(RVA = "0x4E101C4", Offset = "0x4E101C4", VA = "0x4E101C4")]
    private void TryAddUseCount()
    {
    }

    [Token(Token = "0x6013786")]
    [Address(RVA = "0x4E102FC", Offset = "0x4E102FC", VA = "0x4E102FC")]
    private void TrySubtractUseCount()
    {
    }

    [Token(Token = "0x6013787")]
    [Address(RVA = "0x4E10124", Offset = "0x4E10124", VA = "0x4E10124")]
    private void SetButtonInteractable()
    {
    }

    [Token(Token = "0x6013788")]
    [Address(RVA = "0x4E1018C", Offset = "0x4E1018C", VA = "0x4E1018C")]
    private void UpdateTxtCountValue()
    {
    }

    [Token(Token = "0x6013789")]
    [Address(RVA = "0x4E10350", Offset = "0x4E10350", VA = "0x4E10350")]
    public BoxItemRewardListSheet()
    {
    }
  }
}
