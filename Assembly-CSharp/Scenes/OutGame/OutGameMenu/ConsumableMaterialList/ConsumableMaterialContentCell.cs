// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.ConsumableMaterialList.ConsumableMaterialContentCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.ConsumableMaterialList
{
  [Token(Token = "0x2003BDD")]
  public class ConsumableMaterialContentCell : InfiniteCellBase
  {
    [Token(Token = "0x4010965")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ConsumableMaterialTitle Container_TitleSpacer;
    [Token(Token = "0x4010966")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ConsumableMaterialItemLine Layout_ItemThumbs;
    [Token(Token = "0x4010967")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject Container_LineSpacer;

    [Token(Token = "0x60178A7")]
    [Address(RVA = "0x2378128", Offset = "0x2378128", VA = "0x2378128", Slot = "4")]
    public override void OnUpdate()
    {
    }

    [Token(Token = "0x60178A8")]
    [Address(RVA = "0x23786B8", Offset = "0x23786B8", VA = "0x23786B8")]
    public ConsumableMaterialContentCell()
    {
    }

    [Token(Token = "0x2003BDE")]
    public class TitleCellData
    {
      [Token(Token = "0x4010968")]
      [FieldOffset(Offset = "0x10")]
      public string Title;

      [Token(Token = "0x60178A9")]
      [Address(RVA = "0x23786C0", Offset = "0x23786C0", VA = "0x23786C0")]
      public TitleCellData()
      {
      }
    }

    [Token(Token = "0x2003BDF")]
    public class ItemLineCellData
    {
      [Token(Token = "0x4010969")]
      [FieldOffset(Offset = "0x10")]
      public AssetCachedSpawner Spawner;
      [Token(Token = "0x401096A")]
      [FieldOffset(Offset = "0x18")]
      public ItemParam[] Items;
      [Token(Token = "0x401096B")]
      [FieldOffset(Offset = "0x20")]
      public Action<ItemTypeEnum, int> OnClick;

      [Token(Token = "0x60178AA")]
      [Address(RVA = "0x23786C8", Offset = "0x23786C8", VA = "0x23786C8")]
      public ItemLineCellData()
      {
      }
    }

    [Token(Token = "0x2003BE0")]
    public class LineCellData
    {
      [Token(Token = "0x60178AB")]
      [Address(RVA = "0x23786D0", Offset = "0x23786D0", VA = "0x23786D0")]
      public LineCellData()
      {
      }
    }
  }
}
