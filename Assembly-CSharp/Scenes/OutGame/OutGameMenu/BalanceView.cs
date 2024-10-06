// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.BalanceView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003A43")]
  public class BalanceView : MonoBehaviour
  {
    [Token(Token = "0x400FF38")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text[] balance;
    [Token(Token = "0x400FF39")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text[] afterPayment;
    [Token(Token = "0x400FF3A")]
    [FieldOffset(Offset = "0x28")]
    private Color nomalColor;
    [Token(Token = "0x400FF3B")]
    [FieldOffset(Offset = "0x38")]
    private Color shortageColor;

    [Token(Token = "0x6016E58")]
    [Address(RVA = "0x2C5F8C0", Offset = "0x2C5F8C0", VA = "0x2C5F8C0")]
    public void SetBalancePositive(PaymentTypeEnum paymentType, int paymentId, int paymentAmount)
    {
    }

    [Token(Token = "0x6016E59")]
    [Address(RVA = "0x2C5FA88", Offset = "0x2C5FA88", VA = "0x2C5FA88")]
    public void SetBalanceNegative(PaymentTypeEnum paymentType, int paymentId, int paymentAmount)
    {
    }

    [Token(Token = "0x6016E5A")]
    [Address(RVA = "0x2C5FBE0", Offset = "0x2C5FBE0", VA = "0x2C5FBE0")]
    public void SetBalanceGachaStart(PaymentTypeEnum paymentType, int paymentId, int paymentAmount)
    {
    }

    [Token(Token = "0x6016E5B")]
    [Address(RVA = "0x2C60058", Offset = "0x2C60058", VA = "0x2C60058")]
    public BalanceView()
    {
    }
  }
}
