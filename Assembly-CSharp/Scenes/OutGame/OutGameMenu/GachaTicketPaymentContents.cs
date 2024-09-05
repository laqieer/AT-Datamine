// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.GachaTicketPaymentContents
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.UIControls;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003A08")]
  public class GachaTicketPaymentContents : GachaPaymentContents
  {
    [Token(Token = "0x400FDFD")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private ItemIcon miniIcon;
    [Token(Token = "0x400FDFE")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private ItemIcon icon;
    [Token(Token = "0x400FDFF")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Text nameText;

    [Token(Token = "0x6016CC9")]
    [Address(RVA = "0x2C53554", Offset = "0x2C53554", VA = "0x2C53554", Slot = "4")]
    public override void SetUp(
      PaymentTypeEnum paymentType,
      int paymentId,
      int paymentAmount,
      int pickCount)
    {
    }

    [Token(Token = "0x6016CCA")]
    [Address(RVA = "0x2C53884", Offset = "0x2C53884", VA = "0x2C53884")]
    private void SetIconState(ItemIcon _icon)
    {
    }

    [Token(Token = "0x6016CCB")]
    [Address(RVA = "0x2C538D8", Offset = "0x2C538D8", VA = "0x2C538D8")]
    public GachaTicketPaymentContents()
    {
    }
  }
}
