// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.ConsumableMaterialList.ConsumableMaterialListBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Input;
using GameCore.MasterData;
using GameCore.Tween;
using Il2CppDummyDll;
using System;
using UI.Common;
using UI.ItemDetail;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.ConsumableMaterialList
{
  [Token(Token = "0x2003BE5")]
  public abstract class ConsumableMaterialListBase : MonoBehaviour
  {
    [Token(Token = "0x4010975")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CommonButton _openButton;
    [Token(Token = "0x4010976")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private UITweenGroup _tweenGroup;
    [Token(Token = "0x4010977")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private BtnFullScreen _btnFullScreen;
    [Token(Token = "0x4010978")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x401097A")]
    [FieldOffset(Offset = "0x40")]
    private ItemDetailPopupProvider _itemDetailPopupGenerator;

    [Token(Token = "0x17004C76")]
    public bool IsOpened
    {
      [Token(Token = "0x60178B5"), Address(RVA = "0x237872C", Offset = "0x237872C", VA = "0x237872C")] get
      {
        return new bool();
      }
      [Token(Token = "0x60178B6"), Address(RVA = "0x2378734", Offset = "0x2378734", VA = "0x2378734")] private set
      {
      }
    }

    [Token(Token = "0x17004C77")]
    protected abstract string OpenTweenGroupId { [Token(Token = "0x60178B7")] get; }

    [Token(Token = "0x17004C78")]
    protected abstract string CloseTweenGroupId { [Token(Token = "0x60178B8")] get; }

    [Token(Token = "0x60178B9")]
    public abstract void Initialize(
      ItemListModel model,
      ItemDetailPopupProvider itemDetailPopupGenerator,
      AssetCachedSpawner spawner);

    [Token(Token = "0x60178BA")]
    [Address(RVA = "0x2378740", Offset = "0x2378740", VA = "0x2378740")]
    protected void BuildContents(
      ItemListModel model,
      Action createLine,
      Action<string> createTitle,
      Action<ItemParam[]> createItemOneLine)
    {
    }

    [Token(Token = "0x60178BB")]
    [Address(RVA = "0x2378F9C", Offset = "0x2378F9C", VA = "0x2378F9C", Slot = "7")]
    public virtual void PlayInAnim()
    {
    }

    [Token(Token = "0x60178BC")]
    [Address(RVA = "0x2379098", Offset = "0x2379098", VA = "0x2379098", Slot = "8")]
    public virtual void PlayOutAnim(Action onFinished = null)
    {
    }

    [Token(Token = "0x60178BD")]
    [Address(RVA = "0x23791F4", Offset = "0x23791F4", VA = "0x23791F4")]
    public void Close()
    {
    }

    [Token(Token = "0x60178BE")]
    [Address(RVA = "0x237927C", Offset = "0x237927C", VA = "0x237927C")]
    protected void Initialize(ItemDetailPopupProvider itemDetailPopupGenerator)
    {
    }

    [Token(Token = "0x60178BF")]
    [Address(RVA = "0x23793D4", Offset = "0x23793D4", VA = "0x23793D4")]
    protected void OnClickItemIcon(ItemTypeEnum itemType, int itemId)
    {
    }

    [Token(Token = "0x60178C0")]
    [Address(RVA = "0x23791E0", Offset = "0x23791E0", VA = "0x23791E0")]
    private void CloseItemDetailPopup()
    {
    }

    [Token(Token = "0x60178C1")]
    [Address(RVA = "0x23793EC", Offset = "0x23793EC", VA = "0x23793EC")]
    protected ConsumableMaterialListBase()
    {
    }
  }
}
