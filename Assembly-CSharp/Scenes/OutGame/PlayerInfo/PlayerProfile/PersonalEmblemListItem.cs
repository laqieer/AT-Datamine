// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.PlayerInfo.PlayerProfile.PersonalEmblemListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.PlayerInfo.PlayerProfile
{
  [Token(Token = "0x20034A7")]
  public class PersonalEmblemListItem : InfiniteCellBase
  {
    [Token(Token = "0x400E510")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private PersonalEmblemListItemChild removeButton;
    [Token(Token = "0x400E511")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private PersonalEmblemListItemChild selectableButton;
    [Token(Token = "0x400E512")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private PersonalEmblemListItemChild unselectableButton;
    [Token(Token = "0x400E513")]
    [FieldOffset(Offset = "0x40")]
    public PersonalEmblemListItem.PersonalEmblemCellData cellData;

    [Token(Token = "0x6014A81")]
    [Address(RVA = "0x1D66400", Offset = "0x1D66400", VA = "0x1D66400")]
    private PersonalEmblemListItemChild GetCurrentChild() => (PersonalEmblemListItemChild) null;

    [Token(Token = "0x6014A82")]
    [Address(RVA = "0x1D66440", Offset = "0x1D66440", VA = "0x1D66440")]
    public void SetData(
      PersonalEmblemListItem.PersonalEmblemCellData cellData)
    {
    }

    [Token(Token = "0x6014A83")]
    [Address(RVA = "0x1D66814", Offset = "0x1D66814", VA = "0x1D66814")]
    public void Update()
    {
    }

    [Token(Token = "0x6014A84")]
    [Address(RVA = "0x1D66874", Offset = "0x1D66874", VA = "0x1D66874", Slot = "4")]
    public override void OnUpdate()
    {
    }

    [Token(Token = "0x6014A85")]
    [Address(RVA = "0x1D66904", Offset = "0x1D66904", VA = "0x1D66904")]
    public PersonalEmblemListItem()
    {
    }

    [Token(Token = "0x20034A8")]
    public class PersonalEmblemInfo
    {
      [Token(Token = "0x400E514")]
      [FieldOffset(Offset = "0x10")]
      public PersonalEmblemData PersonalEmblemItem;
      [Token(Token = "0x400E515")]
      [FieldOffset(Offset = "0x18")]
      public DateTime CreatedAt;

      [Token(Token = "0x6014A86")]
      [Address(RVA = "0x1D64BA8", Offset = "0x1D64BA8", VA = "0x1D64BA8")]
      public PersonalEmblemInfo()
      {
      }
    }

    [Token(Token = "0x20034A9")]
    public class PersonalEmblemCellData
    {
      [Token(Token = "0x400E516")]
      [FieldOffset(Offset = "0x10")]
      public AssetCachedSpawner AssetCachedSpawner;
      [Token(Token = "0x400E517")]
      [FieldOffset(Offset = "0x18")]
      public PersonalEmblemListItem.PersonalEmblemInfo EmblemInfo;
      [Token(Token = "0x400E518")]
      [FieldOffset(Offset = "0x20")]
      public bool IsOwning;
      [Token(Token = "0x400E519")]
      [FieldOffset(Offset = "0x21")]
      public bool RemoveButton;
      [Token(Token = "0x400E51A")]
      [FieldOffset(Offset = "0x22")]
      public bool IsNew;
      [Token(Token = "0x400E51B")]
      [FieldOffset(Offset = "0x23")]
      public bool IsSelecting;
      [Token(Token = "0x400E51C")]
      [FieldOffset(Offset = "0x28")]
      public Action<int> OnClickAction;

      [Token(Token = "0x6014A87")]
      [Address(RVA = "0x1D64BA0", Offset = "0x1D64BA0", VA = "0x1D64BA0")]
      public PersonalEmblemCellData()
      {
      }
    }
  }
}
