// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitDetail.AbilityBoard.AbilityBoardPaymentItemContent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.UIControls;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.UnitDetail.AbilityBoard
{
  [Token(Token = "0x2003339")]
  internal class AbilityBoardPaymentItemContent : MonoBehaviour
  {
    [Token(Token = "0x400DDBF")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ItemIcon icon;
    [Token(Token = "0x400DDC0")]
    [FieldOffset(Offset = "0x20")]
    public IItemDetailController itemDetailController;
    [Token(Token = "0x400DDC1")]
    [FieldOffset(Offset = "0x28")]
    public IAbilityBoardIconLoader iconLoader;
    [Token(Token = "0x400DDC2")]
    [FieldOffset(Offset = "0x30")]
    private ItemData item;

    [Token(Token = "0x601420C")]
    [Address(RVA = "0x20CCAC8", Offset = "0x20CCAC8", VA = "0x20CCAC8")]
    public void SetBulkReleasePaymentItemData(ItemData item)
    {
    }

    [Token(Token = "0x601420D")]
    [Address(RVA = "0x20CCC80", Offset = "0x20CCC80", VA = "0x20CCC80")]
    public void OnClickItemIcon(ItemIcon itemIcon)
    {
    }

    [Token(Token = "0x601420E")]
    [Address(RVA = "0x20CCD28", Offset = "0x20CCD28", VA = "0x20CCD28")]
    public AbilityBoardPaymentItemContent()
    {
    }
  }
}
