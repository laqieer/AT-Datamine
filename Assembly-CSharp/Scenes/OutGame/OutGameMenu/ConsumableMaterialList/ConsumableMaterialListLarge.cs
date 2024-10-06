// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.ConsumableMaterialList.ConsumableMaterialListLarge
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
  [Token(Token = "0x2003BE7")]
  public class ConsumableMaterialListLarge : ConsumableMaterialListBase
  {
    [Token(Token = "0x401097D")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private InfiniteScrollView _scrollView;

    [Token(Token = "0x17004C79")]
    protected override string OpenTweenGroupId
    {
      [Token(Token = "0x60178C7"), Address(RVA = "0x2379474", Offset = "0x2379474", VA = "0x2379474", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17004C7A")]
    protected override string CloseTweenGroupId
    {
      [Token(Token = "0x60178C8"), Address(RVA = "0x23794B4", Offset = "0x23794B4", VA = "0x23794B4", Slot = "5")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60178C9")]
    [Address(RVA = "0x23794F4", Offset = "0x23794F4", VA = "0x23794F4", Slot = "6")]
    public override void Initialize(
      ItemListModel model,
      ItemDetailPopupProvider itemDetailPopupGenerator,
      AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x60178CA")]
    [Address(RVA = "0x23796C4", Offset = "0x23796C4", VA = "0x23796C4", Slot = "7")]
    public override void PlayInAnim()
    {
    }

    [Token(Token = "0x60178CB")]
    [Address(RVA = "0x23796F0", Offset = "0x23796F0", VA = "0x23796F0")]
    public ConsumableMaterialListLarge()
    {
    }
  }
}
