// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.UnitDetail.AbilityBoard.AbilityBoardSelectContent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Tween;
using GameCore.UIControls;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.UnitDetail.AbilityBoard
{
  [Token(Token = "0x200333C")]
  public class AbilityBoardSelectContent : MonoBehaviour
  {
    [Token(Token = "0x400DDC5")]
    [FieldOffset(Offset = "0x18")]
    public IItemDetailController itemDetailController;
    [Token(Token = "0x400DDC6")]
    [FieldOffset(Offset = "0x20")]
    public IAbilityBoardIconLoader iconLoader;
    [Token(Token = "0x400DDC7")]
    [FieldOffset(Offset = "0x28")]
    public Action<int, int> selectAction;
    [Token(Token = "0x400DDC8")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ItemIcon icon;
    [Token(Token = "0x400DDC9")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CommonButton button;
    [Token(Token = "0x400DDCA")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text name;
    [Token(Token = "0x400DDCB")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private UITweenGroup tween;
    [Token(Token = "0x400DDCC")]
    [FieldOffset(Offset = "0x50")]
    private int index;
    [Token(Token = "0x400DDCD")]
    [FieldOffset(Offset = "0x58")]
    private ItemData itemData;

    [Token(Token = "0x601421A")]
    [Address(RVA = "0x20BFD10", Offset = "0x20BFD10", VA = "0x20BFD10")]
    public void SetData(int index, ItemData item)
    {
    }

    [Token(Token = "0x601421B")]
    [Address(RVA = "0x20CE18C", Offset = "0x20CE18C", VA = "0x20CE18C")]
    private void ItemSelect()
    {
    }

    [Token(Token = "0x601421C")]
    [Address(RVA = "0x20BFCF0", Offset = "0x20BFCF0", VA = "0x20BFCF0")]
    public void PlayTween(string tweenName)
    {
    }

    [Token(Token = "0x601421D")]
    [Address(RVA = "0x20CE1C0", Offset = "0x20CE1C0", VA = "0x20CE1C0")]
    public void OnClickItemIcon(ItemIcon itemIcon)
    {
    }

    [Token(Token = "0x601421E")]
    [Address(RVA = "0x20CE030", Offset = "0x20CE030", VA = "0x20CE030")]
    private string GetDispItemName(int moldType) => (string) null;

    [Token(Token = "0x601421F")]
    [Address(RVA = "0x20CE1C4", Offset = "0x20CE1C4", VA = "0x20CE1C4")]
    public AbilityBoardSelectContent()
    {
    }
  }
}
