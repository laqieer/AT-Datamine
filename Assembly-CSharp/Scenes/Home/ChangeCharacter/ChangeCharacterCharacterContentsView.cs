// Decompiled with JetBrains decompiler
// Type: Scenes.Home.ChangeCharacter.ChangeCharacterCharacterContentsView
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
  [Token(Token = "0x2002B38")]
  public class ChangeCharacterCharacterContentsView : MonoBehaviour
  {
    [Token(Token = "0x400B807")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Transform contentsRoot;
    [Token(Token = "0x400B808")]
    private const string ListItemAssetBundleName = "ui_page_home_charachenge_prefab";
    [Token(Token = "0x400B809")]
    private const string ListItemAssetName = "Contents_Chara_List";
    [Token(Token = "0x400B80A")]
    [FieldOffset(Offset = "0x20")]
    private readonly List<ChangeCharacterCharacterContentsListItem> _listItems;
    [Token(Token = "0x400B80B")]
    [FieldOffset(Offset = "0x28")]
    public Action<int, int> OnChangeCharacter;
    [Token(Token = "0x400B80C")]
    [FieldOffset(Offset = "0x30")]
    private int _selectingIndex;

    [Token(Token = "0x6010E3A")]
    [Address(RVA = "0x1C3D290", Offset = "0x1C3D290", VA = "0x1C3D290")]
    public IEnumerator InitializeAsync(
      ChangeCharacterSubScene.CharacterSettings saveData,
      int selectingIndex)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6010E3B")]
    [Address(RVA = "0x1C3D338", Offset = "0x1C3D338", VA = "0x1C3D338")]
    private void OnUnselect()
    {
    }

    [Token(Token = "0x6010E3C")]
    [Address(RVA = "0x1C3D458", Offset = "0x1C3D458", VA = "0x1C3D458")]
    private void OnSelect(int characterId)
    {
    }

    [Token(Token = "0x6010E3D")]
    [Address(RVA = "0x1C3D6C8", Offset = "0x1C3D6C8", VA = "0x1C3D6C8")]
    public void SetOnChangeCharacter(Action<int, int> action)
    {
    }

    [Token(Token = "0x6010E3E")]
    [Address(RVA = "0x1C3D6D0", Offset = "0x1C3D6D0", VA = "0x1C3D6D0")]
    private IReadOnlyList<CharacterData> GetAcquiredCharacters(
      ChangeCharacterSubScene.CharacterSettings saveData)
    {
      return (IReadOnlyList<CharacterData>) null;
    }

    [Token(Token = "0x6010E3F")]
    [Address(RVA = "0x1C3DD58", Offset = "0x1C3DD58", VA = "0x1C3DD58")]
    private int GetIndex(int characterId, ChangeCharacterSubScene.CharacterSettings saveData)
    {
      return new int();
    }

    [Token(Token = "0x6010E40")]
    [Address(RVA = "0x1C3E034", Offset = "0x1C3E034", VA = "0x1C3E034")]
    public ChangeCharacterCharacterContentsView()
    {
    }
  }
}
