// Decompiled with JetBrains decompiler
// Type: TeamOrganization.ItemSetEditView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x200077F")]
  public class ItemSetEditView : MonoBehaviour
  {
    [Token(Token = "0x400225C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ItemSetThumbSetView itemSetThumbSetView;
    [Token(Token = "0x400225D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text setName;
    [Token(Token = "0x400225E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Button prevButton;
    [Token(Token = "0x400225F")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Button nextButton;
    [Token(Token = "0x4002260")]
    private const string ItemSetEditAssetBundleName = "ui_page_partylist_itemedit";
    [Token(Token = "0x4002261")]
    private const string ItemListPopupPrefabName = "Com_Popup_Bottom_Edit_Item";
    [Token(Token = "0x4002262")]
    private const string ThumbBaseAssetbundleName = "ui_common_thumb";
    [Token(Token = "0x4002263")]
    [FieldOffset(Offset = "0x38")]
    private readonly string[] thumbBaseAssetName;
    [Token(Token = "0x4002264")]
    [FieldOffset(Offset = "0x40")]
    private Coroutine loadAssetBundleCoroutine;
    [Token(Token = "0x4002265")]
    [FieldOffset(Offset = "0x48")]
    private List<Expendable>[] loadWaitList;
    [Token(Token = "0x4002266")]
    [FieldOffset(Offset = "0x50")]
    private int loadWaitIdOfs;
    [Token(Token = "0x4002267")]
    [FieldOffset(Offset = "0x58")]
    private ItemSetEditItemListPopup itemSetEditPrefab;
    [Token(Token = "0x4002268")]
    [FieldOffset(Offset = "0x60")]
    private ItemSetEditItemListPopup itemSetEditPopup;
    [Token(Token = "0x4002269")]
    [FieldOffset(Offset = "0x68")]
    private int selectItemsetId;
    [Token(Token = "0x400226A")]
    [FieldOffset(Offset = "0x70")]
    private OrganizationItemSet organizationItem;
    [Token(Token = "0x400226B")]
    [FieldOffset(Offset = "0x78")]
    private int selectItemIndex;
    [Token(Token = "0x400226C")]
    private const int ITEMSET_MAX = 6;
    [Token(Token = "0x400226D")]
    [FieldOffset(Offset = "0x80")]
    private AssetCachedSpawner assetCachedSpawner;

    [Token(Token = "0x60029D8")]
    [Address(RVA = "0x34FAF54", Offset = "0x34FAF54", VA = "0x34FAF54")]
    public void InitItemSetEditView(AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x60029D9")]
    [Address(RVA = "0x34FB168", Offset = "0x34FB168", VA = "0x34FB168")]
    public void UpdateView(int selectItemsetId, Action closeAction)
    {
    }

    [Token(Token = "0x60029DA")]
    [Address(RVA = "0x34FB810", Offset = "0x34FB810", VA = "0x34FB810")]
    public BattleItemset GetBattleItemSetData(int selectId) => (BattleItemset) null;

    [Token(Token = "0x60029DB")]
    [Address(RVA = "0x34FB684", Offset = "0x34FB684", VA = "0x34FB684")]
    public void UpdateItemSetView()
    {
    }

    [Token(Token = "0x60029DC")]
    [Address(RVA = "0x34FC408", Offset = "0x34FC408", VA = "0x34FC408")]
    public void DestroyPopup()
    {
    }

    [Token(Token = "0x60029DD")]
    [Address(RVA = "0x34FC4B0", Offset = "0x34FC4B0", VA = "0x34FC4B0")]
    public void AddThumbAssetBundle(Expendable expendable)
    {
    }

    [Token(Token = "0x60029DE")]
    [Address(RVA = "0x34FB53C", Offset = "0x34FB53C", VA = "0x34FB53C")]
    public IEnumerator SetLoadThumbAssetBundle() => (IEnumerator) null;

    [Token(Token = "0x60029DF")]
    [Address(RVA = "0x34FC5A0", Offset = "0x34FC5A0", VA = "0x34FC5A0")]
    public string GetAseetBundleName(Expendable expendable) => (string) null;

    [Token(Token = "0x60029E0")]
    [Address(RVA = "0x34FC5BC", Offset = "0x34FC5BC", VA = "0x34FC5BC")]
    public string GetAseetName(Expendable expendable) => (string) null;

    [Token(Token = "0x60029E1")]
    [Address(RVA = "0x34FC5D8", Offset = "0x34FC5D8", VA = "0x34FC5D8")]
    public Sprite GetRarityBaseImage(Expendable expendable) => (Sprite) null;

    [Token(Token = "0x60029E2")]
    [Address(RVA = "0x34FC358", Offset = "0x34FC358", VA = "0x34FC358")]
    private void UpdatePrevNextButton()
    {
    }

    [Token(Token = "0x60029E3")]
    [Address(RVA = "0x34FC6D4", Offset = "0x34FC6D4", VA = "0x34FC6D4")]
    public void OnClickLeftArrow()
    {
    }

    [Token(Token = "0x60029E4")]
    [Address(RVA = "0x34FCB18", Offset = "0x34FCB18", VA = "0x34FCB18")]
    public void OnClickRightArrow()
    {
    }

    [Token(Token = "0x60029E5")]
    [Address(RVA = "0x34FCAA4", Offset = "0x34FCAA4", VA = "0x34FCAA4")]
    protected IEnumerator ConnectAPIItemSetEdit(Action finishAction) => (IEnumerator) null;

    [Token(Token = "0x60029E6")]
    [Address(RVA = "0x34FCC20", Offset = "0x34FCC20", VA = "0x34FCC20")]
    public void ThumbnailOnClickSelect(
      int index,
      ItemSetEditItemListPopup.eItemListKind kind,
      ItemSetThumb thumb)
    {
    }

    [Token(Token = "0x60029E7")]
    [Address(RVA = "0x34FCC74", Offset = "0x34FCC74", VA = "0x34FCC74")]
    public void OnPopupThumbChangeButton(Expendable expendable)
    {
    }

    [Token(Token = "0x60029E8")]
    [Address(RVA = "0x34FCE08", Offset = "0x34FCE08", VA = "0x34FCE08")]
    public void OnPopupThumbRemoveButton()
    {
    }

    [Token(Token = "0x60029E9")]
    [Address(RVA = "0x34FCEB8", Offset = "0x34FCEB8", VA = "0x34FCEB8")]
    public ItemSetEditView()
    {
    }
  }
}
