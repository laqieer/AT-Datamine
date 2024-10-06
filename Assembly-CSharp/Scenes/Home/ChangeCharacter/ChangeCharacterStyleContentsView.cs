// Decompiled with JetBrains decompiler
// Type: Scenes.Home.ChangeCharacter.ChangeCharacterStyleContentsView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.Home.ChangeCharacter
{
  [Token(Token = "0x2002B4E")]
  public class ChangeCharacterStyleContentsView : MonoBehaviour
  {
    [Token(Token = "0x400B864")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Transform contentsRoot;
    [Token(Token = "0x400B865")]
    [FieldOffset(Offset = "0x20")]
    private int _selectingStyleId;
    [Token(Token = "0x400B866")]
    private const string ListItemAssetBundleName = "ui_page_stylelist";
    [Token(Token = "0x400B867")]
    private const string ListItemAssetName = "Container_Column_StyleChange";
    [Token(Token = "0x400B868")]
    private const int NumberOfRowsInListItem = 3;
    [Token(Token = "0x400B869")]
    [FieldOffset(Offset = "0x28")]
    private readonly List<ChangeCharacterStyleContentsListItem> _listItems;
    [Token(Token = "0x400B86A")]
    [FieldOffset(Offset = "0x30")]
    private Action<int> OnConfirm;
    [Token(Token = "0x400B86B")]
    [FieldOffset(Offset = "0x38")]
    private Action OnBack;

    [Token(Token = "0x17003A6A")]
    public int SelectingStyleId
    {
      [Token(Token = "0x6010EBD"), Address(RVA = "0x1C40BC8", Offset = "0x1C40BC8", VA = "0x1C40BC8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6010EBE")]
    [Address(RVA = "0x1C40BD0", Offset = "0x1C40BD0", VA = "0x1C40BD0")]
    public IEnumerator InitializeAsync(
      int characterId,
      int equippingStyleId,
      ChangeCharacterSubScene.CharacterSettings saveData)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6010EBF")]
    [Address(RVA = "0x1C40C84", Offset = "0x1C40C84", VA = "0x1C40C84")]
    private void OnClickStyle(int styleId)
    {
    }

    [Token(Token = "0x6010EC0")]
    [Address(RVA = "0x1C40DFC", Offset = "0x1C40DFC", VA = "0x1C40DFC")]
    private void SetOnClickStyle(Action<int> action)
    {
    }

    [Token(Token = "0x6010EC1")]
    [Address(RVA = "0x1C40F34", Offset = "0x1C40F34", VA = "0x1C40F34")]
    private IReadOnlyList<StyleData> GetAcquiredStyles(int characterId)
    {
      return (IReadOnlyList<StyleData>) null;
    }

    [Token(Token = "0x6010EC2")]
    [Address(RVA = "0x1C41450", Offset = "0x1C41450", VA = "0x1C41450")]
    public ChangeCharacterStyleContentsView()
    {
    }
  }
}
