// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Popup.TitleSelect.TitleNameList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Scenes.OutGame.TitleEmblem;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Popup.TitleSelect
{
  [Token(Token = "0x200346D")]
  public class TitleNameList : MonoBehaviour
  {
    [Token(Token = "0x400E404")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TitleNameListItem itemPrefab;
    [Token(Token = "0x400E405")]
    [FieldOffset(Offset = "0x20")]
    private Dictionary<int, TitleNameListItem> listItems;
    [Token(Token = "0x400E406")]
    [FieldOffset(Offset = "0x28")]
    private int? selectedTitleId;

    [Token(Token = "0x6014920")]
    [Address(RVA = "0x1AA71F8", Offset = "0x1AA71F8", VA = "0x1AA71F8")]
    private void ClearItems()
    {
    }

    [Token(Token = "0x6014921")]
    [Address(RVA = "0x1AA73BC", Offset = "0x1AA73BC", VA = "0x1AA73BC")]
    public void Reset(
      IReadOnlyList<ITitleMasterData> titles,
      ITitleLoader titleLoader,
      int? selectedTitleId,
      int defaultFontSize,
      Action<TitleNameListItem> onClickAction)
    {
    }

    [Token(Token = "0x6014922")]
    [Address(RVA = "0x1AA7E28", Offset = "0x1AA7E28", VA = "0x1AA7E28")]
    private void OnItemClick(int titleId)
    {
    }

    [Token(Token = "0x6014923")]
    [Address(RVA = "0x1AA7F34", Offset = "0x1AA7F34", VA = "0x1AA7F34")]
    public TitleNameList()
    {
    }
  }
}
