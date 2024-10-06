// Decompiled with JetBrains decompiler
// Type: Gacha.GachaPayButtonGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections.Generic;
using UI;
using UnityEngine;

#nullable disable
namespace Gacha
{
  [Token(Token = "0x200150B")]
  internal class GachaPayButtonGroup : MonoBehaviour
  {
    [Token(Token = "0x40060AC")]
    [FieldOffset(Offset = "0x18")]
    [Header("無料ガチャ")]
    [SerializeField]
    private GameObject freeRoot;
    [Token(Token = "0x40060AD")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GachaPayButtonView freeButton;
    [Token(Token = "0x40060AE")]
    [FieldOffset(Offset = "0x28")]
    [Header("無償石ガチャ")]
    [SerializeField]
    private GameObject freeCoinRoot;
    [Token(Token = "0x40060AF")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GachaPayButtonView freeCoinSingleButton;
    [Token(Token = "0x40060B0")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GachaPayButtonView freeCoinMultipleButton;
    [Token(Token = "0x40060B1")]
    [FieldOffset(Offset = "0x40")]
    [Header("有償石ガチャ")]
    [SerializeField]
    private GameObject paidCoinRoot;
    [Token(Token = "0x40060B2")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GachaPayButtonView paidCoinSingleButton;
    [Token(Token = "0x40060B3")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GachaPayButtonView paidCoinMultipleButton;
    [Token(Token = "0x40060B4")]
    [FieldOffset(Offset = "0x58")]
    [Header("チケットガチャ")]
    [SerializeField]
    private GameObject ticketRoot;
    [Token(Token = "0x40060B5")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GachaPayButtonView ticketSingleButton;
    [Token(Token = "0x40060B6")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private GachaPayButtonView ticketMultipleButton;
    [Token(Token = "0x40060B7")]
    [FieldOffset(Offset = "0x70")]
    [Header("広告動画ガチャ")]
    [SerializeField]
    private GameObject advertisementRoot;
    [Token(Token = "0x40060B8")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private GachaPayButtonView adSingleButton;
    [Token(Token = "0x40060B9")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private GachaPayButtonView adMultipleButton;
    [Token(Token = "0x40060BA")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private GachaPayButtonView adFreeCoinSingleButton;
    [Token(Token = "0x40060BB")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private GachaPayButtonView adFreeCoinMultipleButton;
    [Token(Token = "0x40060BC")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    [Header("ステップタグ")]
    private GameObject stepTagRoot;
    [Token(Token = "0x40060BD")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private TextAccessor textStepCurrent;
    [Token(Token = "0x40060BE")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private TextAccessor textStepMax;
    [Token(Token = "0x40060BF")]
    [FieldOffset(Offset = "0xB0")]
    [Header("無料タグ")]
    [SerializeField]
    private GameObject freeTagRoot;
    [Token(Token = "0x40060C0")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private TextAccessor textFreeTag;
    [Token(Token = "0x40060C1")]
    [FieldOffset(Offset = "0xC0")]
    private GachaDetailGroupInfo gachaDetailGroupInfo;
    [Token(Token = "0x40060C2")]
    [FieldOffset(Offset = "0xC8")]
    private int groupId;
    [Token(Token = "0x40060C3")]
    [FieldOffset(Offset = "0xD0")]
    private AssetCachedSpawner spawner;
    [Token(Token = "0x40060C4")]
    [FieldOffset(Offset = "0xD8")]
    public Action<GachaPaymentModel> PayButtonClicked;

    [Token(Token = "0x6007718")]
    [Address(RVA = "0x44EE710", Offset = "0x44EE710", VA = "0x44EE710")]
    public void Initialize(AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x6007719")]
    [Address(RVA = "0x44EE718", Offset = "0x44EE718", VA = "0x44EE718")]
    public void SetupButton(GachaDetailGroupInfo gachaDetailGroupInfo, int groupId)
    {
    }

    [Token(Token = "0x600771A")]
    [Address(RVA = "0x44EE724", Offset = "0x44EE724", VA = "0x44EE724")]
    public void SwitchActiveButtons(GachaPayButtonGroupType buttonGroupType)
    {
    }

    [Token(Token = "0x600771B")]
    [Address(RVA = "0x44EE8E4", Offset = "0x44EE8E4", VA = "0x44EE8E4")]
    private void DisableAllTags()
    {
    }

    [Token(Token = "0x600771C")]
    [Address(RVA = "0x44EE934", Offset = "0x44EE934", VA = "0x44EE934")]
    private void DisableAllButtons()
    {
    }

    [Token(Token = "0x600771D")]
    [Address(RVA = "0x44EFF8C", Offset = "0x44EFF8C", VA = "0x44EFF8C")]
    private void SetupFreeText(string text)
    {
    }

    [Token(Token = "0x600771E")]
    [Address(RVA = "0x44EFFC0", Offset = "0x44EFFC0", VA = "0x44EFFC0")]
    private void SetupRemainingText(string text)
    {
    }

    [Token(Token = "0x600771F")]
    [Address(RVA = "0x44EFFF4", Offset = "0x44EFFF4", VA = "0x44EFFF4")]
    private void SetupStepText(int current, int max)
    {
    }

    [Token(Token = "0x6007720")]
    [Address(RVA = "0x44F007C", Offset = "0x44F007C", VA = "0x44F007C")]
    private void SetupStepText(IEnumerable<GachaPaymentModel> paymentModels)
    {
    }

    [Token(Token = "0x6007721")]
    [Address(RVA = "0x44F01A8", Offset = "0x44F01A8", VA = "0x44F01A8")]
    private void SetupRemainingText(IEnumerable<GachaPaymentModel> paymentModels)
    {
    }

    [Token(Token = "0x6007722")]
    [Address(RVA = "0x44EF1E4", Offset = "0x44EF1E4", VA = "0x44EF1E4")]
    private void AssignFreeButtonView(List<GachaDetailInfo> gachaDetailInfos)
    {
    }

    [Token(Token = "0x6007723")]
    [Address(RVA = "0x44EF3AC", Offset = "0x44EF3AC", VA = "0x44EF3AC")]
    private void AssignFreeCoinButtonView(List<GachaDetailInfo> gachaDetailInfos)
    {
    }

    [Token(Token = "0x6007724")]
    [Address(RVA = "0x44EF734", Offset = "0x44EF734", VA = "0x44EF734")]
    private void AssignPaidCoinButtonView(List<GachaDetailInfo> gachaDetailInfos)
    {
    }

    [Token(Token = "0x6007725")]
    [Address(RVA = "0x44EFABC", Offset = "0x44EFABC", VA = "0x44EFABC")]
    private void AssignTicketButtonView(List<GachaDetailInfo> gachaDetailInfos)
    {
    }

    [Token(Token = "0x6007726")]
    [Address(RVA = "0x44EEB08", Offset = "0x44EEB08", VA = "0x44EEB08")]
    private void AssignAdvertisementButtonView(
      List<GachaDetailInfo> adGachaDetailInfos,
      List<GachaDetailInfo> coinGachaDetailInfos)
    {
    }

    [Token(Token = "0x6007727")]
    [Address(RVA = "0x44F05EC", Offset = "0x44F05EC", VA = "0x44F05EC")]
    private void OnPaymentButtonClicked(GachaPaymentModel gachaPaymentModel)
    {
    }

    [Token(Token = "0x6007728")]
    [Address(RVA = "0x44F0608", Offset = "0x44F0608", VA = "0x44F0608")]
    public GachaPayButtonGroup()
    {
    }
  }
}
