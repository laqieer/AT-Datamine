// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.PlayerInfo.AvatarSelect.AvatarSelectPopupProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Scenes.OutGame.PlayerInfo.AvatarSelect
{
  [Token(Token = "0x20034D3")]
  public class AvatarSelectPopupProvider
  {
    [Token(Token = "0x400E5E5")]
    private const string AssetbundleName = "ui_page_outgame_playerprofile_prefab";
    [Token(Token = "0x400E5E6")]
    private const string AvatarSelectAssetName = "Com_Popup_Base_L_AvatarSelect";
    [Token(Token = "0x400E5E7")]
    [FieldOffset(Offset = "0x10")]
    private AvatarSelectPopup popup;
    [Token(Token = "0x400E5E8")]
    [FieldOffset(Offset = "0x18")]
    private AssetCachedSpawner spawner;

    [Token(Token = "0x6014BA4")]
    [Address(RVA = "0x1D6B500", Offset = "0x1D6B500", VA = "0x1D6B500")]
    public IEnumerator InitializeAsync(AssetCachedSpawner spawner) => (IEnumerator) null;

    [Token(Token = "0x6014BA5")]
    [Address(RVA = "0x1D6B574", Offset = "0x1D6B574", VA = "0x1D6B574")]
    public IEnumerator Open(Action onApplied) => (IEnumerator) null;

    [Token(Token = "0x6014BA6")]
    [Address(RVA = "0x1D6B4F8", Offset = "0x1D6B4F8", VA = "0x1D6B4F8")]
    public AvatarSelectPopupProvider()
    {
    }
  }
}
