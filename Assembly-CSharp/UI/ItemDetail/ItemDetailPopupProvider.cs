// Decompiled with JetBrains decompiler
// Type: UI.ItemDetail.ItemDetailPopupProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace UI.ItemDetail
{
  [Token(Token = "0x20008D0")]
  public class ItemDetailPopupProvider
  {
    [Token(Token = "0x4002957")]
    [FieldOffset(Offset = "0x10")]
    private AssetCachedSpawner _assetCachedSpawner;
    [Token(Token = "0x4002958")]
    [FieldOffset(Offset = "0x18")]
    private ItemDetailPopupGenerator _generator;
    [Token(Token = "0x4002959")]
    [FieldOffset(Offset = "0x20")]
    private ItemDetailPopup _popup;
    [Token(Token = "0x400295A")]
    [FieldOffset(Offset = "0x28")]
    private bool _disableSupplier;
    [Token(Token = "0x400295B")]
    [FieldOffset(Offset = "0x30")]
    private Action<ItemSupplierSearcher.ISearchResult, bool> _onClickSupplier;
    [Token(Token = "0x400295C")]
    [FieldOffset(Offset = "0x38")]
    private Action _onBackSceneUpdate;

    [Token(Token = "0x17000737")]
    public bool IsLoaded
    {
      [Token(Token = "0x60031FC"), Address(RVA = "0x3C1DB60", Offset = "0x3C1DB60", VA = "0x3C1DB60")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000738")]
    public Action OnBackSceneUpdate
    {
      [Token(Token = "0x60031FD"), Address(RVA = "0x3C1DB80", Offset = "0x3C1DB80", VA = "0x3C1DB80")] get
      {
        return (Action) null;
      }
    }

    [Token(Token = "0x60031FE")]
    [Address(RVA = "0x3C1DB88", Offset = "0x3C1DB88", VA = "0x3C1DB88")]
    public IEnumerator InitializeAsync(AssetCachedSpawner assetCachedSpawner = null, Action onFinish = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60031FF")]
    [Address(RVA = "0x3C1DC2C", Offset = "0x3C1DC2C", VA = "0x3C1DC2C")]
    public void SetActiveSupplier(
      bool isActive = false,
      Action<ItemSupplierSearcher.ISearchResult, bool> onClickSupplier = null)
    {
    }

    [Token(Token = "0x6003200")]
    [Address(RVA = "0x3C1DC40", Offset = "0x3C1DC40", VA = "0x3C1DC40")]
    public ItemDetailPopup Open(ItemTypeEnum itemType, int itemId, Action onBackScene = null)
    {
      return (ItemDetailPopup) null;
    }

    [Token(Token = "0x6003201")]
    [Address(RVA = "0x3C1DDC4", Offset = "0x3C1DDC4", VA = "0x3C1DDC4")]
    private void GeneratePopup(Transform parent, bool isItemBox)
    {
    }

    [Token(Token = "0x6003202")]
    [Address(RVA = "0x3C1DE74", Offset = "0x3C1DE74", VA = "0x3C1DE74")]
    private void SetOnClickSupplierCallback()
    {
    }

    [Token(Token = "0x6003203")]
    [Address(RVA = "0x3C1DFA4", Offset = "0x3C1DFA4", VA = "0x3C1DFA4")]
    private void OnClickSupplierCallback(ItemSupplierSearcher.ISearchResult result, bool isLock)
    {
    }

    [Token(Token = "0x6003204")]
    [Address(RVA = "0x3C1DFC4", Offset = "0x3C1DFC4", VA = "0x3C1DFC4")]
    public ItemDetailPopup Open(RewardTypeEnum rewardType, int rewardId) => (ItemDetailPopup) null;

    [Token(Token = "0x6003205")]
    [Address(RVA = "0x3C1E074", Offset = "0x3C1E074", VA = "0x3C1E074")]
    public ItemDetailPopup Open(RewardTypeEnum rewardType, int rewardId, Transform parent)
    {
      return (ItemDetailPopup) null;
    }

    [Token(Token = "0x6003206")]
    [Address(RVA = "0x3C1E190", Offset = "0x3C1E190", VA = "0x3C1E190")]
    public ItemDetailPopup Open(PaymentTypeEnum paymentType, int paymentId)
    {
      return (ItemDetailPopup) null;
    }

    [Token(Token = "0x6003207")]
    [Address(RVA = "0x3C1E304", Offset = "0x3C1E304", VA = "0x3C1E304")]
    public void Close()
    {
    }

    [Token(Token = "0x6003208")]
    [Address(RVA = "0x3C1E388", Offset = "0x3C1E388", VA = "0x3C1E388")]
    public ItemDetailPopupProvider()
    {
    }
  }
}
