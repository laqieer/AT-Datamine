// Decompiled with JetBrains decompiler
// Type: Gacha.GachaPayButtonTab
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Gacha
{
  [Token(Token = "0x200150F")]
  internal class GachaPayButtonTab : MonoBehaviour
  {
    [Token(Token = "0x40060D4")]
    [FieldOffset(Offset = "0x18")]
    [Tooltip("無料ガチャ")]
    [SerializeField]
    private GameObject areaRoot;
    [Token(Token = "0x40060D5")]
    [FieldOffset(Offset = "0x20")]
    [Tooltip("有償ガチャ")]
    [SerializeField]
    private CommonButton coinButton;
    [Token(Token = "0x40060D6")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    [Tooltip("チケットガチャ")]
    private CommonButton ticketButton;
    [Token(Token = "0x40060D7")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    [Tooltip("バッジ")]
    private GameObject badgeObj;
    [Token(Token = "0x40060D8")]
    [FieldOffset(Offset = "0x38")]
    private CommonButton[] payButtonSwitch;
    [Token(Token = "0x40060D9")]
    [FieldOffset(Offset = "0x40")]
    public Action SwitchHeaderAction;
    [Token(Token = "0x40060DA")]
    [FieldOffset(Offset = "0x48")]
    public Action SwitchCoinAction;
    [Token(Token = "0x40060DB")]
    [FieldOffset(Offset = "0x50")]
    public Action SwitchTicketAction;
    [Token(Token = "0x40060DC")]
    [FieldOffset(Offset = "0x58")]
    public Action SwitchFreeAction;
    [Token(Token = "0x40060DF")]
    [FieldOffset(Offset = "0x68")]
    private bool existFreeGacha;
    [Token(Token = "0x40060E0")]
    [FieldOffset(Offset = "0x69")]
    private bool existCoinGacha;
    [Token(Token = "0x40060E1")]
    [FieldOffset(Offset = "0x6A")]
    private bool existTicketGacha;
    [Token(Token = "0x40060E2")]
    [FieldOffset(Offset = "0x6B")]
    private bool hasPaymentTicket;

    [Token(Token = "0x17001262")]
    public GachaTabType CurrentTab
    {
      [Token(Token = "0x6007736"), Address(RVA = "0x44F0854", Offset = "0x44F0854", VA = "0x44F0854")] get
      {
        return new GachaTabType();
      }
      [Token(Token = "0x6007737"), Address(RVA = "0x44F085C", Offset = "0x44F085C", VA = "0x44F085C")] private set
      {
      }
    }

    [Token(Token = "0x17001263")]
    public int CurrentGachaId
    {
      [Token(Token = "0x6007738"), Address(RVA = "0x44F0864", Offset = "0x44F0864", VA = "0x44F0864")] get
      {
        return new int();
      }
      [Token(Token = "0x6007739"), Address(RVA = "0x44F086C", Offset = "0x44F086C", VA = "0x44F086C")] private set
      {
      }
    }

    [Token(Token = "0x600773A")]
    [Address(RVA = "0x44F0874", Offset = "0x44F0874", VA = "0x44F0874")]
    private void Awake()
    {
    }

    [Token(Token = "0x600773B")]
    [Address(RVA = "0x44F0878", Offset = "0x44F0878", VA = "0x44F0878")]
    private void InitializePayButtons()
    {
    }

    [Token(Token = "0x600773C")]
    [Address(RVA = "0x44F0AA4", Offset = "0x44F0AA4", VA = "0x44F0AA4")]
    public void SetCurrentGachaId(int gachaId)
    {
    }

    [Token(Token = "0x600773D")]
    [Address(RVA = "0x44F0AAC", Offset = "0x44F0AAC", VA = "0x44F0AAC")]
    public void SetButtonActive(GachaTabType groupType, bool isActive)
    {
    }

    [Token(Token = "0x600773E")]
    [Address(RVA = "0x44F0ADC", Offset = "0x44F0ADC", VA = "0x44F0ADC")]
    public void SetHasPaymentTicket(bool hasPaymentTicket)
    {
    }

    [Token(Token = "0x600773F")]
    [Address(RVA = "0x44F0AE8", Offset = "0x44F0AE8", VA = "0x44F0AE8")]
    public void SetTabTypeSafe(GachaTabType groupType)
    {
    }

    [Token(Token = "0x6007740")]
    [Address(RVA = "0x44F0AF0", Offset = "0x44F0AF0", VA = "0x44F0AF0")]
    public void SetButtonView(GachaTabType groupType)
    {
    }

    [Token(Token = "0x6007741")]
    [Address(RVA = "0x44F0CC0", Offset = "0x44F0CC0", VA = "0x44F0CC0")]
    private void OnClickCoin()
    {
    }

    [Token(Token = "0x6007742")]
    [Address(RVA = "0x44F0CD4", Offset = "0x44F0CD4", VA = "0x44F0CD4")]
    private void OnClickTicket()
    {
    }

    [Token(Token = "0x6007743")]
    [Address(RVA = "0x44F0CA0", Offset = "0x44F0CA0", VA = "0x44F0CA0")]
    public void SetTabAreaActive(bool visible)
    {
    }

    [Token(Token = "0x6007744")]
    [Address(RVA = "0x44F0CE8", Offset = "0x44F0CE8", VA = "0x44F0CE8")]
    public void ClearCallbacks()
    {
    }

    [Token(Token = "0x6007745")]
    [Address(RVA = "0x44F0CF4", Offset = "0x44F0CF4", VA = "0x44F0CF4")]
    public GachaPayButtonTab()
    {
    }
  }
}
