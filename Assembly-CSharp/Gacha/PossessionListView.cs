// Decompiled with JetBrains decompiler
// Type: Gacha.PossessionListView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Input;
using GameCore.Tween;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Gacha
{
  [Token(Token = "0x2001559")]
  internal class PossessionListView : MonoBehaviour
  {
    [Token(Token = "0x400620A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [Header("所持数の合計")]
    private Text textTotalAmount;
    [Token(Token = "0x400620B")]
    [FieldOffset(Offset = "0x20")]
    [Space(10f)]
    [Header("リストアイテムの複製元")]
    [SerializeField]
    private PossessionListItemView template;
    [Token(Token = "0x400620C")]
    [FieldOffset(Offset = "0x28")]
    [Space(10f)]
    [Header("アニメーション制御")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400620D")]
    [FieldOffset(Offset = "0x30")]
    [Header("閉じるボタン")]
    [SerializeField]
    [Space(10f)]
    private CommonButton buttonClose;
    [Token(Token = "0x400620E")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CommonButton buttonOutOfRange;
    [Token(Token = "0x400620F")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x4006210")]
    [FieldOffset(Offset = "0x48")]
    [Space(10f)]
    [SerializeField]
    [Header("別画面遷移ボタン（交換所等）")]
    private CommonButton buttonJump;
    [Token(Token = "0x4006211")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Image image;
    [Token(Token = "0x4006212")]
    [FieldOffset(Offset = "0x58")]
    private List<PossessionListItemView> listItems;
    [Token(Token = "0x4006213")]
    [FieldOffset(Offset = "0x60")]
    private IPossessionListPresenter presenter;

    [Token(Token = "0x17001291")]
    public IPossessionListPresenter Presenter
    {
      [Token(Token = "0x60078EA"), Address(RVA = "0x44FED48", Offset = "0x44FED48", VA = "0x44FED48")] set
      {
      }
    }

    [Token(Token = "0x60078EB")]
    [Address(RVA = "0x44FEDF0", Offset = "0x44FEDF0", VA = "0x44FEDF0")]
    public static void Create(
      AssetCachedSpawner spawner,
      GachaAssetBundleInfo.AssetBundleInfo assetBundleInfo,
      Transform parent,
      Action<PossessionListView> onCreate)
    {
    }

    [Token(Token = "0x60078EC")]
    [Address(RVA = "0x44FEEF4", Offset = "0x44FEEF4", VA = "0x44FEEF4")]
    private void Awake()
    {
    }

    [Token(Token = "0x60078ED")]
    [Address(RVA = "0x44FE5A0", Offset = "0x44FE5A0", VA = "0x44FE5A0")]
    public void InitializeList(int size)
    {
    }

    [Token(Token = "0x60078EE")]
    [Address(RVA = "0x44FE76C", Offset = "0x44FE76C", VA = "0x44FE76C")]
    public void SetTotalAmountText(string text)
    {
    }

    [Token(Token = "0x60078EF")]
    [Address(RVA = "0x44FF0E8", Offset = "0x44FF0E8", VA = "0x44FF0E8")]
    private void OnCloseButtonClicked()
    {
    }

    [Token(Token = "0x60078F0")]
    [Address(RVA = "0x44FF18C", Offset = "0x44FF18C", VA = "0x44FF18C")]
    private void OnOutOfRangeButtonClicked()
    {
    }

    [Token(Token = "0x60078F1")]
    [Address(RVA = "0x44FF230", Offset = "0x44FF230", VA = "0x44FF230")]
    private void OnJumpButtonClicked()
    {
    }

    [Token(Token = "0x60078F2")]
    [Address(RVA = "0x44FF2D4", Offset = "0x44FF2D4", VA = "0x44FF2D4")]
    public void SetHeaderIcon(AssetCachedSpawner spawner, ItemUtility.Parameter param)
    {
    }

    [Token(Token = "0x60078F3")]
    [Address(RVA = "0x44FE85C", Offset = "0x44FE85C", VA = "0x44FE85C")]
    public void Close()
    {
    }

    [Token(Token = "0x60078F4")]
    [Address(RVA = "0x44FE998", Offset = "0x44FE998", VA = "0x44FE998")]
    public void Open()
    {
    }

    [Token(Token = "0x60078F5")]
    [Address(RVA = "0x44FF390", Offset = "0x44FF390", VA = "0x44FF390")]
    public PossessionListView()
    {
    }
  }
}
