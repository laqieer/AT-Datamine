// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.Popup.ExpeditionStageSelectPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.Popup;
using GameCore.UIControls;
using Il2CppDummyDll;
using Scenes.Expedition.Main;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UI.ItemDetail;
using UnityEngine;

#nullable disable
namespace Scenes.Expedition.Popup
{
  [Token(Token = "0x2002C6F")]
  public class ExpeditionStageSelectPopup : PopupBase
  {
    [Token(Token = "0x400BD56")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x400BD57")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private CommonButton changeButton;
    [Token(Token = "0x400BD58")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Transform bannerParent;
    [Token(Token = "0x400BD59")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Transform itemParent;
    [Token(Token = "0x400BD5A")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private TextMeshProUGUI styleExpText;
    [Token(Token = "0x400BD5D")]
    [FieldOffset(Offset = "0xC0")]
    private ItemDetailPopupProvider itemDetailPopupGenerator;
    [Token(Token = "0x400BD5E")]
    [FieldOffset(Offset = "0xC8")]
    private bool isOpenItemDetail;
    [Token(Token = "0x400BD5F")]
    [FieldOffset(Offset = "0xD0")]
    private ExpeditionFieldBanner fieldBannerPrefab;
    [Token(Token = "0x400BD60")]
    [FieldOffset(Offset = "0xD8")]
    private ItemIcon itemThumbPrefab;
    [Token(Token = "0x400BD61")]
    [FieldOffset(Offset = "0xE0")]
    private string selectStageId;
    [Token(Token = "0x400BD62")]
    [FieldOffset(Offset = "0xE8")]
    private List<ExpeditionFieldBanner> fieldBannerList;
    [Token(Token = "0x400BD63")]
    [FieldOffset(Offset = "0xF0")]
    private List<ItemIcon> itemIconList;
    [Token(Token = "0x400BD64")]
    [FieldOffset(Offset = "0xF8")]
    private List<ExpeditionStageSelectPopup.ViewItemData> viewItemDatas;
    [Token(Token = "0x400BD65")]
    [FieldOffset(Offset = "0x100")]
    private AssetCachedSpawner assetCachedSpawner;

    [Token(Token = "0x17003BFA")]
    public Action CallbackDecision
    {
      [Token(Token = "0x601164E"), Address(RVA = "0x4E1E654", Offset = "0x4E1E654", VA = "0x4E1E654")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x601164F"), Address(RVA = "0x4E1E65C", Offset = "0x4E1E65C", VA = "0x4E1E65C")] set
      {
      }
    }

    [Token(Token = "0x17003BFB")]
    public Action<string> CallbackChange
    {
      [Token(Token = "0x6011650"), Address(RVA = "0x4E1E664", Offset = "0x4E1E664", VA = "0x4E1E664")] get
      {
        return (Action<string>) null;
      }
      [Token(Token = "0x6011651"), Address(RVA = "0x4E1E66C", Offset = "0x4E1E66C", VA = "0x4E1E66C")] set
      {
      }
    }

    [Token(Token = "0x6011652")]
    [Address(RVA = "0x4E1E674", Offset = "0x4E1E674", VA = "0x4E1E674")]
    public void Initialize(AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x6011653")]
    [Address(RVA = "0x4E1E948", Offset = "0x4E1E948", VA = "0x4E1E948")]
    public void SetData(string selectId)
    {
    }

    [Token(Token = "0x6011654")]
    [Address(RVA = "0x4E1E974", Offset = "0x4E1E974", VA = "0x4E1E974")]
    private void CreateBanner()
    {
    }

    [Token(Token = "0x6011655")]
    [Address(RVA = "0x4E1EB50", Offset = "0x4E1EB50", VA = "0x4E1EB50")]
    private void UpdateBanner()
    {
    }

    [Token(Token = "0x6011656")]
    [Address(RVA = "0x4E1EF78", Offset = "0x4E1EF78", VA = "0x4E1EF78")]
    private void UpdateItemThumb()
    {
    }

    [Token(Token = "0x6011657")]
    [Address(RVA = "0x4E1EDCC", Offset = "0x4E1EDCC", VA = "0x4E1EDCC")]
    private void UpdateStyleExpValue()
    {
    }

    [Token(Token = "0x6011658")]
    [Address(RVA = "0x4E1FB1C", Offset = "0x4E1FB1C", VA = "0x4E1FB1C")]
    private void OnSelectStage(string stageId)
    {
    }

    [Token(Token = "0x6011659")]
    [Address(RVA = "0x4E1FB6C", Offset = "0x4E1FB6C", VA = "0x4E1FB6C")]
    private void OpenItemDetailPopup(RewardTypeEnum rewardType, int rewardId)
    {
    }

    [Token(Token = "0x601165A")]
    [Address(RVA = "0x4E1FC38", Offset = "0x4E1FC38", VA = "0x4E1FC38")]
    private void OpenItemDetail(RewardTypeEnum rewardType, int rewardId)
    {
    }

    [Token(Token = "0x601165B")]
    [Address(RVA = "0x4E1FBBC", Offset = "0x4E1FBBC", VA = "0x4E1FBBC")]
    private IEnumerator ItemDetailInit(RewardTypeEnum rewardType, int rewardId)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601165C")]
    [Address(RVA = "0x4E1F998", Offset = "0x4E1F998", VA = "0x4E1F998")]
    private bool CheckViewItemData(RewardTypeEnum rewardType, int rewardId) => new bool();

    [Token(Token = "0x601165D")]
    [Address(RVA = "0x4E1FB58", Offset = "0x4E1FB58", VA = "0x4E1FB58")]
    private void CloseDetailPopup()
    {
    }

    [Token(Token = "0x601165E")]
    [Address(RVA = "0x4E1F7D8", Offset = "0x4E1F7D8", VA = "0x4E1F7D8")]
    private ExpeditionStageDescriptionData GetStageDescriptionData(int stageId, int stageLevel)
    {
      return (ExpeditionStageDescriptionData) null;
    }

    [Token(Token = "0x601165F")]
    [Address(RVA = "0x4E1FD84", Offset = "0x4E1FD84", VA = "0x4E1FD84")]
    public ExpeditionStageSelectPopup()
    {
    }

    [Token(Token = "0x2002C70")]
    private struct ViewItemData
    {
      [Token(Token = "0x400BD66")]
      [FieldOffset(Offset = "0x0")]
      public RewardTypeEnum rewardType;
      [Token(Token = "0x400BD67")]
      [FieldOffset(Offset = "0x4")]
      public int rewardId;

      [Token(Token = "0x6011664")]
      [Address(RVA = "0x4E1FD58", Offset = "0x4E1FD58", VA = "0x4E1FD58")]
      public bool IsEqual(RewardTypeEnum type, int id) => new bool();
    }
  }
}
