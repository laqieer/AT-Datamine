// Decompiled with JetBrains decompiler
// Type: UI.ItemDetail.ItemDetailRecommendPresenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace UI.ItemDetail
{
  [Token(Token = "0x20008DF")]
  public class ItemDetailRecommendPresenter : MonoBehaviour
  {
    [Token(Token = "0x400299D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ContentRecommendBtnView _contentBase;
    [Token(Token = "0x400299F")]
    [FieldOffset(Offset = "0x28")]
    private AssetCachedSpawner _assetCachedSpawner;
    [Token(Token = "0x40029A0")]
    [FieldOffset(Offset = "0x30")]
    private List<ContentRecommendBtnView> _recommendContents;

    [Token(Token = "0x17000749")]
    public Action<ItemSupplierSearcher.ISearchResult, bool> OnClickSupplier
    {
      [Token(Token = "0x6003254"), Address(RVA = "0x3C21E98", Offset = "0x3C21E98", VA = "0x3C21E98")] get
      {
        return (Action<ItemSupplierSearcher.ISearchResult, bool>) null;
      }
      [Token(Token = "0x6003255"), Address(RVA = "0x3C21EA0", Offset = "0x3C21EA0", VA = "0x3C21EA0")] set
      {
      }
    }

    [Token(Token = "0x6003256")]
    [Address(RVA = "0x3C21EA8", Offset = "0x3C21EA8", VA = "0x3C21EA8")]
    private void Awake()
    {
    }

    [Token(Token = "0x6003257")]
    [Address(RVA = "0x3C21ED4", Offset = "0x3C21ED4", VA = "0x3C21ED4")]
    private void Update()
    {
    }

    [Token(Token = "0x6003258")]
    [Address(RVA = "0x3C1C900", Offset = "0x3C1C900", VA = "0x3C1C900")]
    public void Initialize(
      ItemTypeEnum itemType,
      int itemId,
      AssetCachedSpawner assetCachedSpawner = null,
      IReadOnlyList<ItemSupplierSearcher.ISearchResult> searchResults = null)
    {
    }

    [Token(Token = "0x6003259")]
    [Address(RVA = "0x3C1B610", Offset = "0x3C1B610", VA = "0x3C1B610")]
    public void OnItemDetailClose()
    {
    }

    [Token(Token = "0x600325A")]
    [Address(RVA = "0x3C1C7AC", Offset = "0x3C1C7AC", VA = "0x3C1C7AC")]
    public void SetActive(bool isActive)
    {
    }

    [Token(Token = "0x600325B")]
    [Address(RVA = "0x3C21F58", Offset = "0x3C21F58", VA = "0x3C21F58")]
    private ContentRecommendBtnView AddContent(string title) => (ContentRecommendBtnView) null;

    [Token(Token = "0x600325C")]
    [Address(RVA = "0x3C22034", Offset = "0x3C22034", VA = "0x3C22034")]
    public ItemDetailRecommendPresenter()
    {
    }
  }
}
