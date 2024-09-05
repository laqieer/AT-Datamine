// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitDetail.AbilityBoard.AbilityBoardConfirmNodeComplete
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using GameCore.UIControls;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.UnitDetail.AbilityBoard
{
  [Token(Token = "0x2003316")]
  public class AbilityBoardConfirmNodeComplete : PopupBase
  {
    [Token(Token = "0x400DCB2")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private ItemIcon itemIcon;
    [Token(Token = "0x400DCB3")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Text unlockNode;
    [Token(Token = "0x400DCB4")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Text rewardName;
    [Token(Token = "0x400DCB5")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Text rewardAmount;
    [Token(Token = "0x400DCB6")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private GameObject[] checkMark;
    [Token(Token = "0x400DCB7")]
    [FieldOffset(Offset = "0xB0")]
    private IAbilityBoardIconLoader IconLoader;

    [Token(Token = "0x601413B")]
    [Address(RVA = "0x20BEFF8", Offset = "0x20BEFF8", VA = "0x20BEFF8")]
    public void SetData(
      int boardId,
      int boardListId,
      int unlockedNodeCount,
      int maxNodeCount,
      IAbilityBoardIconLoader iconLoader)
    {
    }

    [Token(Token = "0x601413C")]
    [Address(RVA = "0x20BF40C", Offset = "0x20BF40C", VA = "0x20BF40C")]
    public void OnCloseButton()
    {
    }

    [Token(Token = "0x601413D")]
    [Address(RVA = "0x20BF49C", Offset = "0x20BF49C", VA = "0x20BF49C")]
    public AbilityBoardConfirmNodeComplete()
    {
    }
  }
}
