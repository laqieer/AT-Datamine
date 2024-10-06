// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.GachaPaymentContents
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x20039E1")]
  public class GachaPaymentContents : MonoBehaviour
  {
    [Token(Token = "0x400FD37")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text textNotice;
    [Token(Token = "0x400FD38")]
    [FieldOffset(Offset = "0x20")]
    private Func<string> NoticeFormatReam;
    [Token(Token = "0x400FD39")]
    [FieldOffset(Offset = "0x28")]
    private Func<string> NoticeFormatSingle;
    [Token(Token = "0x400FD3A")]
    [FieldOffset(Offset = "0x30")]
    private Func<string> NoticeFormatFree;
    [Token(Token = "0x400FD3B")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text textPaymentAmount;
    [Token(Token = "0x400FD3C")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text textPickCount;
    [Token(Token = "0x400FD3D")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject ream;
    [Token(Token = "0x400FD3E")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject single;
    [Token(Token = "0x400FD3F")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private BalanceView balanceView;
    [Token(Token = "0x400FD40")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GameObject objectDescriptionRoot;

    [Token(Token = "0x6016BAA")]
    [Address(RVA = "0x3F6E8F0", Offset = "0x3F6E8F0", VA = "0x3F6E8F0", Slot = "4")]
    public virtual void SetUp(
      PaymentTypeEnum paymentType,
      int paymentId,
      int paymentAmount,
      int pickCount)
    {
    }

    [Token(Token = "0x6016BAB")]
    [Address(RVA = "0x3F6EB88", Offset = "0x3F6EB88", VA = "0x3F6EB88")]
    public void SetupForFreeGacha(int paymentAmount, int pickCount)
    {
    }

    [Token(Token = "0x6016BAC")]
    [Address(RVA = "0x3F6ECF8", Offset = "0x3F6ECF8", VA = "0x3F6ECF8")]
    public void Hide()
    {
    }

    [Token(Token = "0x6016BAD")]
    [Address(RVA = "0x3F6EB54", Offset = "0x3F6EB54", VA = "0x3F6EB54")]
    private string ReplaceTags(string text) => (string) null;

    [Token(Token = "0x6016BAE")]
    [Address(RVA = "0x3F6ED1C", Offset = "0x3F6ED1C", VA = "0x3F6ED1C")]
    public GachaPaymentContents()
    {
    }
  }
}
