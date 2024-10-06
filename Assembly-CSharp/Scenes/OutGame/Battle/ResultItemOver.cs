// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Battle.ResultItemOver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.UIControls;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Battle
{
  [Token(Token = "0x2003770")]
  public class ResultItemOver : MonoBehaviour
  {
    [Token(Token = "0x400F21A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UITimelineController timeLineController;
    [Token(Token = "0x400F21B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Transform itemPearent;
    [Token(Token = "0x400F21C")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ItemIcon srcItem;
    [Token(Token = "0x400F21D")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x400F21E")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CommonButton backImageButton;
    [Token(Token = "0x400F21F")]
    [FieldOffset(Offset = "0x40")]
    private bool inDirect;

    [Token(Token = "0x6015D79")]
    [Address(RVA = "0x1B33E5C", Offset = "0x1B33E5C", VA = "0x1B33E5C")]
    public void Initialized(
      List<ResultData.ItemData> itemList,
      AssetCachedSpawner assetCachedSpawner,
      Action finish)
    {
    }

    [Token(Token = "0x6015D7A")]
    [Address(RVA = "0x1B342F8", Offset = "0x1B342F8", VA = "0x1B342F8")]
    private void PlayTimeLine(UITimelineController.DirectionType type, Action finish)
    {
    }

    [Token(Token = "0x6015D7B")]
    [Address(RVA = "0x1B341C4", Offset = "0x1B341C4", VA = "0x1B341C4")]
    private void AddItem(ResultData.ItemData dat, AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x6015D7C")]
    [Address(RVA = "0x1B343E4", Offset = "0x1B343E4", VA = "0x1B343E4")]
    public ResultItemOver()
    {
    }
  }
}
