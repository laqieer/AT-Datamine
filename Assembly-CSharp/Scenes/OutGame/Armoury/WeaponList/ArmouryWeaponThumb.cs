// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Armoury.WeaponList.ArmouryWeaponThumb
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Armoury.WeaponList
{
  [Token(Token = "0x2003827")]
  internal class ArmouryWeaponThumb : InfiniteCellBase
  {
    [Token(Token = "0x400F506")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ArmoryCommonThumbBase thumbBase;
    [Token(Token = "0x400F507")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ArmouryDisplayLevel displayLevel;
    [Token(Token = "0x400F508")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private ArmouryDisplayEquippedIcon equippedIcon;
    [Token(Token = "0x400F509")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private ArmouryDisplayFavoriteIcon favoriteIcon;
    [Token(Token = "0x400F50A")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private ArmouryDisplaySortIcon sortIcon;

    [Token(Token = "0x170048E6")]
    private ArmouryWeaponThumbResource Resource
    {
      [Token(Token = "0x6016127"), Address(RVA = "0x20F0698", Offset = "0x20F0698", VA = "0x20F0698")] get
      {
        return (ArmouryWeaponThumbResource) null;
      }
    }

    [Token(Token = "0x6016128")]
    [Address(RVA = "0x20F0720", Offset = "0x20F0720", VA = "0x20F0720", Slot = "4")]
    public override void OnUpdate()
    {
    }

    [Token(Token = "0x6016129")]
    [Address(RVA = "0x20F0D9C", Offset = "0x20F0D9C", VA = "0x20F0D9C")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x601612A")]
    [Address(RVA = "0x20F0C50", Offset = "0x20F0C50", VA = "0x20F0C50")]
    private void UpdateView()
    {
    }

    [Token(Token = "0x601612B")]
    [Address(RVA = "0x20F0DB4", Offset = "0x20F0DB4", VA = "0x20F0DB4")]
    private void SetActiveFavoriteButton(bool isFavorite)
    {
    }

    [Token(Token = "0x601612C")]
    [Address(RVA = "0x20F0DD0", Offset = "0x20F0DD0", VA = "0x20F0DD0")]
    public ArmouryWeaponThumb()
    {
    }
  }
}
