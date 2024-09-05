// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.ShortageContents
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x2003A46")]
  public class ShortageContents : MonoBehaviour
  {
    [Token(Token = "0x400FF41")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private BalanceView balanceView;
    [Token(Token = "0x400FF42")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ItemIconNameView itemIconNameView;

    [Token(Token = "0x6016E61")]
    [Address(RVA = "0x2C606C8", Offset = "0x2C606C8", VA = "0x2C606C8")]
    public void SetUp(PaymentTypeEnum paymentType, int paymentId, int paymentAmount)
    {
    }

    [Token(Token = "0x6016E62")]
    [Address(RVA = "0x2C60724", Offset = "0x2C60724", VA = "0x2C60724")]
    public void Hide()
    {
    }

    [Token(Token = "0x6016E63")]
    [Address(RVA = "0x2C60748", Offset = "0x2C60748", VA = "0x2C60748")]
    public ShortageContents()
    {
    }
  }
}
