// Decompiled with JetBrains decompiler
// Type: GameCore.UIControls.ItemRewardPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.ItemDetail;
using UnityEngine;

#nullable disable
namespace GameCore.UIControls
{
  [Token(Token = "0x2000BF4")]
  public class ItemRewardPopup : MonoBehaviour
  {
    [Token(Token = "0x4003638")]
    [FieldOffset(Offset = "0x18")]
    public ItemRewardPopup.RewardPopType rewardPopType;
    [Token(Token = "0x4003639")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x400363A")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ItemRewardPopupContainer itemRewardContainer;
    [Token(Token = "0x400363B")]
    [FieldOffset(Offset = "0x30")]
    private List<DisplayItemRewardInfoData> displayItemInfos;
    [Token(Token = "0x400363C")]
    [FieldOffset(Offset = "0x38")]
    private DisplayItemRewardInfoData displayCustomSkillInfo;
    [Token(Token = "0x400363D")]
    [FieldOffset(Offset = "0x48")]
    private bool isRewardCustomSkillSet;
    [Token(Token = "0x400363E")]
    [FieldOffset(Offset = "0x50")]
    private Action outEndCallback;
    [Token(Token = "0x400363F")]
    [FieldOffset(Offset = "0x58")]
    private bool showEffect;
    [Token(Token = "0x4003640")]
    [FieldOffset(Offset = "0x60")]
    private ItemDetailPopupProvider itemDetailPopupGenerator;
    [Token(Token = "0x4003641")]
    [FieldOffset(Offset = "0x68")]
    private AssetCachedSpawner assetCachedSpawner;

    [Token(Token = "0x600447C")]
    [Address(RVA = "0x3649600", Offset = "0x3649600", VA = "0x3649600")]
    public void Setup(ItemRewardPopupContainer popupui)
    {
    }

    [Token(Token = "0x600447D")]
    [Address(RVA = "0x3649608", Offset = "0x3649608", VA = "0x3649608")]
    private void Update()
    {
    }

    [Token(Token = "0x600447E")]
    [Address(RVA = "0x3649620", Offset = "0x3649620", VA = "0x3649620")]
    public List<string> SetContentsDataAndGetNeedResourceData(
      List<DisplayItemRewardInfoData> infos,
      string contentText)
    {
      return (List<string>) null;
    }

    [Token(Token = "0x600447F")]
    [Address(RVA = "0x3649BC0", Offset = "0x3649BC0", VA = "0x3649BC0")]
    public IEnumerator SystemInitializeProcess() => (IEnumerator) null;

    [Token(Token = "0x6004480")]
    [Address(RVA = "0x3649C50", Offset = "0x3649C50", VA = "0x3649C50")]
    public void ContentsInitializeProcess(bool numDisplay = true)
    {
    }

    [Token(Token = "0x6004481")]
    [Address(RVA = "0x364A2A4", Offset = "0x364A2A4", VA = "0x364A2A4")]
    public void TurnOnItemIcon()
    {
    }

    [Token(Token = "0x6004482")]
    [Address(RVA = "0x364A338", Offset = "0x364A338", VA = "0x364A338")]
    public void ShowItemIcons()
    {
    }

    [Token(Token = "0x6004483")]
    [Address(RVA = "0x364A4C8", Offset = "0x364A4C8", VA = "0x364A4C8")]
    private void OnClickRewardItem(DisplayItemRewardInfoData info)
    {
    }

    [Token(Token = "0x6004484")]
    [Address(RVA = "0x364A6CC", Offset = "0x364A6CC", VA = "0x364A6CC")]
    private void OpenItemDetailPopup(RewardTypeEnum rewardType, int rewardId)
    {
    }

    [Token(Token = "0x6004485")]
    [Address(RVA = "0x364A684", Offset = "0x364A684", VA = "0x364A684")]
    private void OpenItemDetailPopup(PaymentTypeEnum rewardType, int rewardId)
    {
    }

    [Token(Token = "0x6004486")]
    [Address(RVA = "0x364A50C", Offset = "0x364A50C", VA = "0x364A50C")]
    private void OpenOtherDetailPopup(RewardTypeEnum rewardType, int rewardId)
    {
    }

    [Token(Token = "0x6004487")]
    [Address(RVA = "0x364A730", Offset = "0x364A730", VA = "0x364A730")]
    public void AddEndedCallback(Action callback)
    {
    }

    [Token(Token = "0x6004488")]
    [Address(RVA = "0x364A7B0", Offset = "0x364A7B0", VA = "0x364A7B0")]
    public void RemoveEndedCallback(Action callback)
    {
    }

    [Token(Token = "0x6004489")]
    [Address(RVA = "0x364A830", Offset = "0x364A830", VA = "0x364A830")]
    public void PlayIn(bool isShowEffect)
    {
    }

    [Token(Token = "0x600448A")]
    [Address(RVA = "0x364AA30", Offset = "0x364AA30", VA = "0x364AA30")]
    private void OnPlayInEnded()
    {
    }

    [Token(Token = "0x600448B")]
    [Address(RVA = "0x364ACEC", Offset = "0x364ACEC", VA = "0x364ACEC")]
    public void OnCloseUIButton()
    {
    }

    [Token(Token = "0x600448C")]
    [Address(RVA = "0x364ADA8", Offset = "0x364ADA8", VA = "0x364ADA8")]
    private void PlayOut()
    {
    }

    [Token(Token = "0x600448D")]
    [Address(RVA = "0x364AEF4", Offset = "0x364AEF4", VA = "0x364AEF4")]
    private void OnPlayOutEnd()
    {
    }

    [Token(Token = "0x600448E")]
    [Address(RVA = "0x364AF40", Offset = "0x364AF40", VA = "0x364AF40")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600448F")]
    [Address(RVA = "0x364A714", Offset = "0x364A714", VA = "0x364A714")]
    private void CloseDetailPopup()
    {
    }

    [Token(Token = "0x6004490")]
    [Address(RVA = "0x364AF54", Offset = "0x364AF54", VA = "0x364AF54")]
    public void Show()
    {
    }

    [Token(Token = "0x6004491")]
    [Address(RVA = "0x364AF8C", Offset = "0x364AF8C", VA = "0x364AF8C")]
    public void Hide()
    {
    }

    [Token(Token = "0x6004492")]
    [Address(RVA = "0x364AFC4", Offset = "0x364AFC4", VA = "0x364AFC4")]
    public ItemRewardPopup()
    {
    }

    [Token(Token = "0x2000BF5")]
    public enum RewardPopType
    {
      [Token(Token = "0x4003643")] LoginBonus,
      [Token(Token = "0x4003644")] Reward,
      [Token(Token = "0x4003645")] RewardFast,
    }
  }
}
