// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.BoxItemUseConfirmPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Input;
using GameCore.MasterData;
using GameCore.Popup;
using GameCore.UIControls;
using Il2CppDummyDll;
using Network.Param;
using Scenes.OutGame.OutGameMenu;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x20031E4")]
  public class BoxItemUseConfirmPopup : PopupBase
  {
    [Token(Token = "0x400D4CF")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private CommonButton cancelButton;
    [Token(Token = "0x400D4D0")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private CommonButton decideButton;
    [Token(Token = "0x400D4D1")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private ItemIcon itemIcon;
    [Token(Token = "0x400D4D2")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private StyleThumb styleThumb;
    [Token(Token = "0x400D4D3")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private MindequipmentThumb mnemnographThumb;
    [Token(Token = "0x400D4D4")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private RectTransform thumbParent;
    [Token(Token = "0x400D4D5")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;

    [Token(Token = "0x601378E")]
    [Address(RVA = "0x4E103AC", Offset = "0x4E103AC", VA = "0x4E103AC")]
    public void Initialize(
      AssetCachedSpawner assetCachedSpawner,
      List<BoxItemContentsData> boxItemContentsDataList,
      int useCount,
      Action onDecide,
      Action onCancel)
    {
    }

    [Token(Token = "0x601378F")]
    [Address(RVA = "0x4E106F0", Offset = "0x4E106F0", VA = "0x4E106F0")]
    public void Initialize(
      AssetCachedSpawner assetCachedSpawner,
      List<BoxItemContentSelectType> selectContents,
      Action onDecide,
      Action onCancel)
    {
    }

    [Token(Token = "0x6013790")]
    [Address(RVA = "0x4E1059C", Offset = "0x4E1059C", VA = "0x4E1059C")]
    private void InitializeItemThumb(
      AssetCachedSpawner assetCachedSpawner,
      List<BoxItemContentsData> boxItemContentsDataList,
      int useCount)
    {
    }

    [Token(Token = "0x6013791")]
    [Address(RVA = "0x4E108D0", Offset = "0x4E108D0", VA = "0x4E108D0")]
    private void InitializeItemThumb(
      AssetCachedSpawner assetCachedSpawner,
      List<BoxItemContentSelectType> selectContents)
    {
    }

    [Token(Token = "0x6013792")]
    [Address(RVA = "0x4E10AC8", Offset = "0x4E10AC8", VA = "0x4E10AC8")]
    private void CreateRewardIcon(
      BoxItemContentsData reward,
      int useCount,
      AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x6013793")]
    [Address(RVA = "0x4E10DE0", Offset = "0x4E10DE0", VA = "0x4E10DE0")]
    public BoxItemUseConfirmPopup()
    {
    }
  }
}
