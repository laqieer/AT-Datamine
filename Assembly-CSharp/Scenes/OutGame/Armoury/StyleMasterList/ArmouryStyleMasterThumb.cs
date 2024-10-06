// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Armoury.StyleMasterList.ArmouryStyleMasterThumb
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Armoury.StyleMasterList
{
  [Token(Token = "0x200383C")]
  internal class ArmouryStyleMasterThumb : InfiniteCellBase
  {
    [Token(Token = "0x400F574")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ArmoryCommonThumbBase thumbBase;
    [Token(Token = "0x400F575")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ArmouryDisplayEquippedIcon equippedIcon;
    [Token(Token = "0x400F576")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private ArmouryDisplayFavoriteIcon favoriteIcon;
    [Token(Token = "0x400F577")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private ArmouryDisplaySortIcon sortIcon;

    [Token(Token = "0x170048FB")]
    private ArmouryStyleMasterThumbResource Resource
    {
      [Token(Token = "0x60161AE"), Address(RVA = "0x20F5670", Offset = "0x20F5670", VA = "0x20F5670")] get
      {
        return (ArmouryStyleMasterThumbResource) null;
      }
    }

    [Token(Token = "0x60161AF")]
    [Address(RVA = "0x20F56F8", Offset = "0x20F56F8", VA = "0x20F56F8", Slot = "4")]
    public override void OnUpdate()
    {
    }

    [Token(Token = "0x60161B0")]
    [Address(RVA = "0x20F5C48", Offset = "0x20F5C48", VA = "0x20F5C48")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x60161B1")]
    [Address(RVA = "0x20F5C60", Offset = "0x20F5C60", VA = "0x20F5C60")]
    public void SetActiveFavoriteButton(bool isFavorite)
    {
    }

    [Token(Token = "0x60161B2")]
    [Address(RVA = "0x20F5C7C", Offset = "0x20F5C7C", VA = "0x20F5C7C")]
    public ArmouryStyleMasterThumb()
    {
    }
  }
}
