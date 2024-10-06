// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.PlayerInfo.AvatarSelect.AvatarSelectView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.PlayerInfo.AvatarSelect
{
  [Token(Token = "0x20034DA")]
  public class AvatarSelectView : MonoBehaviour
  {
    [Token(Token = "0x400E5FC")]
    private const string ListItemAssetBundleName = "ui_page_outgame_playerprofile_prefab";
    [Token(Token = "0x400E5FD")]
    private const string ListItemAssetName = "Contents_Avatar_List";
    [Token(Token = "0x400E5FE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Transform listItemParent;
    [Token(Token = "0x400E5FF")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CommonButton buttonDecide;
    [Token(Token = "0x400E600")]
    [FieldOffset(Offset = "0x28")]
    public Action<int, AvatarSelectListItem> OnListItemSelected;
    [Token(Token = "0x400E601")]
    [FieldOffset(Offset = "0x30")]
    public Action<int, AvatarSelectListItem> OnListItemCreate;
    [Token(Token = "0x400E602")]
    [FieldOffset(Offset = "0x38")]
    public Action OnDecide;
    [Token(Token = "0x400E603")]
    [FieldOffset(Offset = "0x40")]
    private List<AvatarSelectListItem> listItems;
    [Token(Token = "0x400E604")]
    [FieldOffset(Offset = "0x48")]
    private AvatarSelectListItem listItemTemplate;

    [Token(Token = "0x6014BBF")]
    [Address(RVA = "0x1D70B60", Offset = "0x1D70B60", VA = "0x1D70B60")]
    private void Awake()
    {
    }

    [Token(Token = "0x6014BC0")]
    [Address(RVA = "0x1D70370", Offset = "0x1D70370", VA = "0x1D70370")]
    public IEnumerator InitializeAsync(int listCount, AssetCachedSpawner spawner)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6014BC1")]
    [Address(RVA = "0x1D70C1C", Offset = "0x1D70C1C", VA = "0x1D70C1C")]
    private AvatarSelectListItem CreateListItem(int index) => (AvatarSelectListItem) null;

    [Token(Token = "0x6014BC2")]
    [Address(RVA = "0x1D70918", Offset = "0x1D70918", VA = "0x1D70918")]
    public void SetDecideButtonEnable(bool enable)
    {
    }

    [Token(Token = "0x6014BC3")]
    [Address(RVA = "0x1D70D6C", Offset = "0x1D70D6C", VA = "0x1D70D6C")]
    public AvatarSelectView()
    {
    }
  }
}
