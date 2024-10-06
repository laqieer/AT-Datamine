// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.ConsumableMaterialList.ConsumableMaterialListMini
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using UI.ItemDetail;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.ConsumableMaterialList
{
  [Token(Token = "0x2003BE9")]
  public class ConsumableMaterialListMini : ConsumableMaterialListBase
  {
    [Token(Token = "0x4010981")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private ConsumableMaterialTitle Container_TitleSpacer;
    [Token(Token = "0x4010982")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private ConsumableMaterialItemLine Layout_ItemThumbs;
    [Token(Token = "0x4010983")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject Container_LineSpacer;
    [Token(Token = "0x4010984")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private RectTransform Content_ALL;

    [Token(Token = "0x17004C7B")]
    protected override string OpenTweenGroupId
    {
      [Token(Token = "0x60178D0"), Address(RVA = "0x2379AB4", Offset = "0x2379AB4", VA = "0x2379AB4", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17004C7C")]
    protected override string CloseTweenGroupId
    {
      [Token(Token = "0x60178D1"), Address(RVA = "0x2379AF4", Offset = "0x2379AF4", VA = "0x2379AF4", Slot = "5")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60178D2")]
    [Address(RVA = "0x2379B34", Offset = "0x2379B34", VA = "0x2379B34")]
    private void Awake()
    {
    }

    [Token(Token = "0x60178D3")]
    [Address(RVA = "0x2379B98", Offset = "0x2379B98", VA = "0x2379B98", Slot = "6")]
    public override void Initialize(
      ItemListModel model,
      ItemDetailPopupProvider itemDetailPopupGenerator,
      AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x60178D4")]
    [Address(RVA = "0x2379D10", Offset = "0x2379D10", VA = "0x2379D10")]
    public ConsumableMaterialListMini()
    {
    }
  }
}
