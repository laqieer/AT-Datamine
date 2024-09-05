// Decompiled with JetBrains decompiler
// Type: Gacha.GachaResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections;

#nullable disable
namespace Gacha
{
  [Token(Token = "0x200151D")]
  internal class GachaResult
  {
    [Token(Token = "0x4006100")]
    [FieldOffset(Offset = "0x10")]
    private GachaResultView view;
    [Token(Token = "0x4006101")]
    [FieldOffset(Offset = "0x18")]
    public Action OKButtonClicked;
    [Token(Token = "0x4006102")]
    [FieldOffset(Offset = "0x20")]
    public Action<GachaPaymentModel> OneMoreButtonClicked;
    [Token(Token = "0x4006103")]
    [FieldOffset(Offset = "0x28")]
    public Action GachaResultClosed;
    [Token(Token = "0x4006104")]
    [FieldOffset(Offset = "0x30")]
    private GachaInfo gachaInfo;
    [Token(Token = "0x4006105")]
    [FieldOffset(Offset = "0x38")]
    private GachaDetailInfo nextGachaDetailInfo;
    [Token(Token = "0x4006106")]
    [FieldOffset(Offset = "0x40")]
    private GachaDetailInfo currentGachaDetailInfo;
    [Token(Token = "0x4006107")]
    [FieldOffset(Offset = "0x48")]
    private GachaPaymentModel nextGachaPaymentModel;
    [Token(Token = "0x4006108")]
    [FieldOffset(Offset = "0x50")]
    private GachaResultInfo gachaResultInfo;
    [Token(Token = "0x4006109")]
    [FieldOffset(Offset = "0x58")]
    private IBunusThumbnailPresenter[] bunusThumbnailPresenter;
    [Token(Token = "0x400610A")]
    [FieldOffset(Offset = "0x60")]
    private IRewardListItemPresenter[] listItemPresenters;
    [Token(Token = "0x400610B")]
    [FieldOffset(Offset = "0x68")]
    private IGachaPayButtonPresenter oneMoreButtonPresenter;
    [Token(Token = "0x400610C")]
    [FieldOffset(Offset = "0x70")]
    private AssetCachedSpawner spawner;

    [Token(Token = "0x6007773")]
    [Address(RVA = "0x44F21C4", Offset = "0x44F21C4", VA = "0x44F21C4")]
    public GachaResult(GachaResultView gachaResultView, AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x6007774")]
    [Address(RVA = "0x44F21F4", Offset = "0x44F21F4", VA = "0x44F21F4")]
    public void Preload(AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x6007775")]
    [Address(RVA = "0x44F239C", Offset = "0x44F239C", VA = "0x44F239C")]
    public void Initialize(
      GachaInfo gachaInfo,
      GachaDetailInfo nextGachaDetailInfo,
      GachaResultInfo gachaResultInfo)
    {
    }

    [Token(Token = "0x6007776")]
    [Address(RVA = "0x44F26C8", Offset = "0x44F26C8", VA = "0x44F26C8")]
    public void SetupView()
    {
    }

    [Token(Token = "0x6007777")]
    [Address(RVA = "0x44F2CF4", Offset = "0x44F2CF4", VA = "0x44F2CF4")]
    public void UpdateView()
    {
    }

    [Token(Token = "0x6007778")]
    [Address(RVA = "0x44F2D6C", Offset = "0x44F2D6C", VA = "0x44F2D6C")]
    public void Open(Action onAnimationComplete = null)
    {
    }

    [Token(Token = "0x6007779")]
    [Address(RVA = "0x44F2F24", Offset = "0x44F2F24", VA = "0x44F2F24")]
    public IEnumerator OpenAsync() => (IEnumerator) null;

    [Token(Token = "0x600777A")]
    [Address(RVA = "0x44F2FB4", Offset = "0x44F2FB4", VA = "0x44F2FB4")]
    public void Close(Action onAnimationComplete = null)
    {
    }

    [Token(Token = "0x600777B")]
    [Address(RVA = "0x44F30EC", Offset = "0x44F30EC", VA = "0x44F30EC")]
    private void OnOKButtonClicked()
    {
    }

    [Token(Token = "0x600777C")]
    [Address(RVA = "0x44F312C", Offset = "0x44F312C", VA = "0x44F312C")]
    private void OnOneModeButtonClicked(GachaPaymentModel nextGachaPaymentModel)
    {
    }
  }
}
