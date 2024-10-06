// Decompiled with JetBrains decompiler
// Type: PaymentBalanceView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x2000239")]
public class PaymentBalanceView : MonoBehaviour, IPaymentBalanceView
{
  [Token(Token = "0x4000D0A")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private PaymentBalanceView.BalanceObject paidCoinBalance;
  [Token(Token = "0x4000D0B")]
  [FieldOffset(Offset = "0x40")]
  [SerializeField]
  private PaymentBalanceView.BalanceObject freeCoinBalance;
  [Token(Token = "0x4000D0C")]
  [FieldOffset(Offset = "0x68")]
  [SerializeField]
  private PaymentBalanceView.BalanceObject itemBalance;
  [Token(Token = "0x4000D0D")]
  [FieldOffset(Offset = "0x90")]
  private List<PaymentBalanceView.BalanceObject> balanceObjects;

  [Token(Token = "0x6000DF6")]
  [Address(RVA = "0x1C89794", Offset = "0x1C89794", VA = "0x1C89794")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000DF7")]
  [Address(RVA = "0x1C899C4", Offset = "0x1C899C4", VA = "0x1C899C4", Slot = "4")]
  public void DisableBalanceObjects()
  {
  }

  [Token(Token = "0x6000DF8")]
  [Address(RVA = "0x1C89A80", Offset = "0x1C89A80", VA = "0x1C89A80", Slot = "5")]
  public void SetPaidCoinBalance(int beforeBalance, int afterBalance)
  {
  }

  [Token(Token = "0x6000DF9")]
  [Address(RVA = "0x1C89D18", Offset = "0x1C89D18", VA = "0x1C89D18", Slot = "6")]
  public void SetFreeCoinBalance(int beforeBalance, int afterBalance)
  {
  }

  [Token(Token = "0x6000DFA")]
  [Address(RVA = "0x1C89D54", Offset = "0x1C89D54", VA = "0x1C89D54", Slot = "7")]
  public void SetItemBalance(
    ItemUtility.Parameter parameter,
    int beforeBalance,
    int afterBalance,
    Sprite iconSprite = null)
  {
  }

  [Token(Token = "0x6000DFB")]
  [Address(RVA = "0x1C89AC0", Offset = "0x1C89AC0", VA = "0x1C89AC0")]
  private void SetAnyBalance(
    PaymentBalanceView.BalanceObject balanceObject,
    int beforeBalance,
    int afterBalance,
    Sprite iconSprite = null,
    string textName = null)
  {
  }

  [Token(Token = "0x6000DFC")]
  [Address(RVA = "0x1C89D88", Offset = "0x1C89D88", VA = "0x1C89D88")]
  public PaymentBalanceView()
  {
  }

  [Token(Token = "0x200023A")]
  [Serializable]
  private struct BalanceObject
  {
    [Token(Token = "0x4000D0E")]
    [FieldOffset(Offset = "0x0")]
    public GameObject objectRoot;
    [Token(Token = "0x4000D0F")]
    [FieldOffset(Offset = "0x8")]
    public Image imageIcon;
    [Token(Token = "0x4000D10")]
    [FieldOffset(Offset = "0x10")]
    public Text textName;
    [Token(Token = "0x4000D11")]
    [FieldOffset(Offset = "0x18")]
    public Text textBeforeBalance;
    [Token(Token = "0x4000D12")]
    [FieldOffset(Offset = "0x20")]
    public Text textAfterBalance;
  }
}
