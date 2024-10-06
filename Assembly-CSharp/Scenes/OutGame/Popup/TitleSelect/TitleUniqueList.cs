// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Popup.TitleSelect.TitleUniqueList
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
  [Token(Token = "0x2003477")]
  public class TitleUniqueList : MonoBehaviour
  {
    [Token(Token = "0x400E437")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TitleUniqueListItem itemPrefab;
    [Token(Token = "0x400E438")]
    [FieldOffset(Offset = "0x20")]
    private Dictionary<int, TitleUniqueListItem> listItems;
    [Token(Token = "0x400E439")]
    [FieldOffset(Offset = "0x28")]
    private int? selectedTitleId;

    [Token(Token = "0x6014958")]
    [Address(RVA = "0x1AAA5B8", Offset = "0x1AAA5B8", VA = "0x1AAA5B8")]
    private void ClearItems()
    {
    }

    [Token(Token = "0x6014959")]
    [Address(RVA = "0x1AA8FC8", Offset = "0x1AA8FC8", VA = "0x1AA8FC8")]
    public void Reset(
      IReadOnlyList<ITitleMasterData> titles,
      ITitleLoader titleLoader,
      int? selectedTitleId,
      Action<TitleUniqueListItem> onClickAction,
      CancellationToken cancellationToken)
    {
    }

    [Token(Token = "0x601495A")]
    [Address(RVA = "0x1AAA950", Offset = "0x1AAA950", VA = "0x1AAA950")]
    private void OnItemClick(int titleId)
    {
    }

    [Token(Token = "0x601495B")]
    [Address(RVA = "0x1AAAA5C", Offset = "0x1AAAA5C", VA = "0x1AAAA5C")]
    public TitleUniqueList()
    {
    }
  }
}
