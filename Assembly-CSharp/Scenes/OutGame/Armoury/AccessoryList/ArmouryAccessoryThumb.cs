// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Armoury.AccessoryList.ArmouryAccessoryThumb
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Armoury.AccessoryList
{
  [Token(Token = "0x20038A5")]
  internal class ArmouryAccessoryThumb : InfiniteCellBase
  {
    [Token(Token = "0x400F7C9")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ArmoryCommonThumbBase thumbBase;
    [Token(Token = "0x400F7CA")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ArmouryDisplayLevel displayLevel;
    [Token(Token = "0x400F7CB")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private ArmouryDisplayEquippedIcon equippedIcon;
    [Token(Token = "0x400F7CC")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private ArmouryDisplayFavoriteIcon favoriteIcon;
    [Token(Token = "0x400F7CD")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private ArmouryDisplaySortIcon sortIcon;

    [Token(Token = "0x1700495B")]
    private ArmouryAccessoryThumbResource Resource
    {
      [Token(Token = "0x601644E"), Address(RVA = "0x1E00C10", Offset = "0x1E00C10", VA = "0x1E00C10")] get
      {
        return (ArmouryAccessoryThumbResource) null;
      }
    }

    [Token(Token = "0x601644F")]
    [Address(RVA = "0x1E00C98", Offset = "0x1E00C98", VA = "0x1E00C98", Slot = "4")]
    public override void OnUpdate()
    {
    }

    [Token(Token = "0x6016450")]
    [Address(RVA = "0x1E01368", Offset = "0x1E01368", VA = "0x1E01368")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x6016451")]
    [Address(RVA = "0x1E01204", Offset = "0x1E01204", VA = "0x1E01204")]
    private void UpdateView()
    {
    }

    [Token(Token = "0x6016452")]
    [Address(RVA = "0x1E01384", Offset = "0x1E01384", VA = "0x1E01384")]
    private void SetActiveFavoriteButton(bool isFavorite)
    {
    }

    [Token(Token = "0x6016453")]
    [Address(RVA = "0x1E013A4", Offset = "0x1E013A4", VA = "0x1E013A4")]
    public ArmouryAccessoryThumb()
    {
    }
  }
}
