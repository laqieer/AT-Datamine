// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.PlayerInfo.FavoriteSelect.StyleScrollColumn
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.PlayerInfo.FavoriteSelect
{
  [Token(Token = "0x20034CC")]
  [AddComponentMenu("Scenes/OutGame/PlayerInfo/FavoriteSelect/StyleScrollColumn")]
  public class StyleScrollColumn : InfiniteCellBase
  {
    [Token(Token = "0x400E5CE")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private StyleThumb[] styleThumbs;
    [Token(Token = "0x400E5CF")]
    [FieldOffset(Offset = "0x30")]
    private IStyleInventory styleInventory;

    [Token(Token = "0x170044B5")]
    private IStyleInventory StyleInventory
    {
      [Token(Token = "0x6014B7E"), Address(RVA = "0x1D6ED68", Offset = "0x1D6ED68", VA = "0x1D6ED68")] get
      {
        return (IStyleInventory) null;
      }
    }

    [Token(Token = "0x6014B7F")]
    [Address(RVA = "0x1D6EDC0", Offset = "0x1D6EDC0", VA = "0x1D6EDC0", Slot = "4")]
    public override void OnUpdate()
    {
    }

    [Token(Token = "0x6014B80")]
    [Address(RVA = "0x1D6F75C", Offset = "0x1D6F75C", VA = "0x1D6F75C")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x6014B81")]
    [Address(RVA = "0x1D6F668", Offset = "0x1D6F668", VA = "0x1D6F668")]
    private void RemoveAllStyleCells()
    {
    }

    [Token(Token = "0x6014B82")]
    [Address(RVA = "0x1D6F760", Offset = "0x1D6F760", VA = "0x1D6F760")]
    public StyleScrollColumn()
    {
    }
  }
}
