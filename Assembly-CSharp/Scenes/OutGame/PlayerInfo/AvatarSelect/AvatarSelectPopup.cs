// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.PlayerInfo.AvatarSelect.AvatarSelectPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Popup;
using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.PlayerInfo.AvatarSelect
{
  [Token(Token = "0x20034D1")]
  public class AvatarSelectPopup : PopupBase
  {
    [Token(Token = "0x400E5DD")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private AvatarSelectView avatarSelectView;
    [Token(Token = "0x400E5DE")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private CommonButton cancelButton;
    [Token(Token = "0x400E5DF")]
    [FieldOffset(Offset = "0x98")]
    private AvatarSelectPresenter presenter;
    [Token(Token = "0x400E5E0")]
    [FieldOffset(Offset = "0xA0")]
    public Action OnApplied;

    [Token(Token = "0x6014B99")]
    [Address(RVA = "0x1D6FE7C", Offset = "0x1D6FE7C", VA = "0x1D6FE7C")]
    public IEnumerator InitializeAsync(AssetCachedSpawner spawner = null) => (IEnumerator) null;

    [Token(Token = "0x6014B9A")]
    [Address(RVA = "0x1D6FF18", Offset = "0x1D6FF18", VA = "0x1D6FF18")]
    public AvatarSelectPopup()
    {
    }
  }
}
