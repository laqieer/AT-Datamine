// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Armoury.MindEquipmentList.ArmouryMindEquipmentThumb
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Armoury.MindEquipmentList
{
  [Token(Token = "0x200384F")]
  internal class ArmouryMindEquipmentThumb : InfiniteCellBase
  {
    [Token(Token = "0x400F5CD")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private LongPressButton longPressButton;
    [Token(Token = "0x400F5CE")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Image thumbnailImage;
    [Token(Token = "0x400F5CF")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Image rarityImage;
    [Token(Token = "0x400F5D0")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject newBadge;
    [Token(Token = "0x400F5D1")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Transform selectedFrameIcon;
    [Token(Token = "0x400F5D2")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private ArmouryDisplayLevel displayLevel;
    [Token(Token = "0x400F5D3")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private ArmouryDisplayEquippedIcon equippedIcon;
    [Token(Token = "0x400F5D4")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private ArmouryDisplayFavoriteIcon favoriteIcon;
    [Token(Token = "0x400F5D5")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private ArmouryDisplaySortIcon sortIcon;
    [Token(Token = "0x400F5D6")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private GameObject disableImage;
    [Token(Token = "0x400F5D7")]
    [FieldOffset(Offset = "0x78")]
    private AssetSpawnOperationBase thumbOperation;
    [Token(Token = "0x400F5D8")]
    [FieldOffset(Offset = "0x80")]
    private AssetSpawnOperationBase rarityOperation;

    [Token(Token = "0x1700490D")]
    private ArmouryMindEquipmentThumbResource Resource
    {
      [Token(Token = "0x601621E"), Address(RVA = "0x20F94C4", Offset = "0x20F94C4", VA = "0x20F94C4")] get
      {
        return (ArmouryMindEquipmentThumbResource) null;
      }
    }

    [Token(Token = "0x601621F")]
    [Address(RVA = "0x20F954C", Offset = "0x20F954C", VA = "0x20F954C", Slot = "4")]
    public override void OnUpdate()
    {
    }

    [Token(Token = "0x6016220")]
    [Address(RVA = "0x20F9D58", Offset = "0x20F9D58", VA = "0x20F9D58")]
    public void SetActiveFavoriteButton(bool isFavorite)
    {
    }

    [Token(Token = "0x6016221")]
    [Address(RVA = "0x20F9D74", Offset = "0x20F9D74", VA = "0x20F9D74")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x6016222")]
    [Address(RVA = "0x20F9EEC", Offset = "0x20F9EEC", VA = "0x20F9EEC")]
    private void SetActiveSelected(bool isActive)
    {
    }

    [Token(Token = "0x6016223")]
    [Address(RVA = "0x20F983C", Offset = "0x20F983C", VA = "0x20F983C")]
    private void SetupPossessedView()
    {
    }

    [Token(Token = "0x6016224")]
    [Address(RVA = "0x20FA060", Offset = "0x20FA060", VA = "0x20FA060")]
    private void UpdateView()
    {
    }

    [Token(Token = "0x6016225")]
    [Address(RVA = "0x20F9B9C", Offset = "0x20F9B9C", VA = "0x20F9B9C")]
    private void SetupNotPossessedView()
    {
    }

    [Token(Token = "0x6016226")]
    [Address(RVA = "0x20FA1AC", Offset = "0x20FA1AC", VA = "0x20FA1AC")]
    public ArmouryMindEquipmentThumb()
    {
    }
  }
}
