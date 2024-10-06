// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.PlayerInfo.AvatarSelect.AvatarSelectPresenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;

#nullable disable
namespace Scenes.OutGame.PlayerInfo.AvatarSelect
{
  [Token(Token = "0x20034D8")]
  internal class AvatarSelectPresenter
  {
    [Token(Token = "0x400E5F6")]
    [FieldOffset(Offset = "0x10")]
    private readonly AvatarSelectView view;
    [Token(Token = "0x400E5F7")]
    [FieldOffset(Offset = "0x18")]
    private readonly AssetCachedSpawner spawner;
    [Token(Token = "0x400E5F8")]
    [FieldOffset(Offset = "0x20")]
    private readonly AvatarSelectModel model;

    [Token(Token = "0x6014BB8")]
    [Address(RVA = "0x1D701F4", Offset = "0x1D701F4", VA = "0x1D701F4")]
    public AvatarSelectPresenter(
      AvatarSelectView view,
      AssetCachedSpawner spawner,
      AvatarSelectModel model)
    {
    }

    [Token(Token = "0x6014BB9")]
    [Address(RVA = "0x1D70938", Offset = "0x1D70938", VA = "0x1D70938")]
    private void OnListItemCreate(int index, AvatarSelectListItem listItem)
    {
    }

    [Token(Token = "0x6014BBA")]
    [Address(RVA = "0x1D70A6C", Offset = "0x1D70A6C", VA = "0x1D70A6C")]
    private void OnListItemSelected(int index, AvatarSelectListItem listItem)
    {
    }

    [Token(Token = "0x6014BBB")]
    [Address(RVA = "0x1D70AB0", Offset = "0x1D70AB0", VA = "0x1D70AB0")]
    private void OnSelectionChanged()
    {
    }

    [Token(Token = "0x6014BBC")]
    [Address(RVA = "0x1D70AE8", Offset = "0x1D70AE8", VA = "0x1D70AE8")]
    private void OnDecideButtonClicked()
    {
    }
  }
}
