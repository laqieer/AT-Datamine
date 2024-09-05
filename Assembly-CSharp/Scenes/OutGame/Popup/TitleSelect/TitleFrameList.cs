// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Popup.TitleSelect.TitleFrameList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Scenes.OutGame.TitleEmblem;
using System;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Popup.TitleSelect
{
  [Token(Token = "0x2003468")]
  public class TitleFrameList : MonoBehaviour
  {
    [Token(Token = "0x400E3EE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TitleFrameListItem itemPrefab;
    [Token(Token = "0x400E3EF")]
    [FieldOffset(Offset = "0x20")]
    private Dictionary<int, TitleFrameListItem> listItems;
    [Token(Token = "0x400E3F0")]
    [FieldOffset(Offset = "0x28")]
    private int? selectedTitleId;

    [Token(Token = "0x601490E")]
    [Address(RVA = "0x1AA5E64", Offset = "0x1AA5E64", VA = "0x1AA5E64")]
    private void ClearItems()
    {
    }

    [Token(Token = "0x601490F")]
    [Address(RVA = "0x1AA6028", Offset = "0x1AA6028", VA = "0x1AA6028")]
    public void Reset(
      IReadOnlyList<ITitleMasterData> titles,
      ITitleLoader titleLoader,
      int? selectedTitleId,
      Action<TitleFrameListItem> onClickAction,
      CancellationToken cancellationToken)
    {
    }

    [Token(Token = "0x6014910")]
    [Address(RVA = "0x1AA68B0", Offset = "0x1AA68B0", VA = "0x1AA68B0")]
    private void OnItemClick(int titleId)
    {
    }

    [Token(Token = "0x6014911")]
    [Address(RVA = "0x1AA69BC", Offset = "0x1AA69BC", VA = "0x1AA69BC")]
    public TitleFrameList()
    {
    }
  }
}
