// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.PlayerInfo.PlayerInfoSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Scene;
using GameCore.UIControls;
using Il2CppDummyDll;
using Scenes.OutGame.PlayerInfo.PlayerProfile;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.PlayerInfo
{
  [Token(Token = "0x2003496")]
  public class PlayerInfoSubScene : SubScene
  {
    [Token(Token = "0x400E4CE")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private RectTransform safeAreaRectTransform;
    [Token(Token = "0x400E4CF")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private UISafeAreaInsets safeArea;
    [Token(Token = "0x400E4D0")]
    [FieldOffset(Offset = "0x68")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400E4D1")]
    [FieldOffset(Offset = "0x70")]
    private PlayerProfileInfo playerProfileInfo;

    [Token(Token = "0x6014A06")]
    [Address(RVA = "0x1AB0610", Offset = "0x1AB0610", VA = "0x1AB0610", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x6014A07")]
    [Address(RVA = "0x1AB0704", Offset = "0x1AB0704", VA = "0x1AB0704")]
    private void InitAssetCachedSpawner()
    {
    }

    [Token(Token = "0x6014A08")]
    [Address(RVA = "0x1AB07F8", Offset = "0x1AB07F8", VA = "0x1AB07F8", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6014A09")]
    [Address(RVA = "0x1AB0888", Offset = "0x1AB0888", VA = "0x1AB0888", Slot = "21")]
    public override IEnumerator EnableEffect() => (IEnumerator) null;

    [Token(Token = "0x6014A0A")]
    [Address(RVA = "0x1AB0918", Offset = "0x1AB0918", VA = "0x1AB0918", Slot = "22")]
    public override IEnumerator DisableEffect() => (IEnumerator) null;

    [Token(Token = "0x6014A0B")]
    [Address(RVA = "0x1AB09A8", Offset = "0x1AB09A8", VA = "0x1AB09A8", Slot = "26")]
    public override IEnumerator OnBackSceneAsync() => (IEnumerator) null;

    [Token(Token = "0x6014A0C")]
    [Address(RVA = "0x1AB0A10", Offset = "0x1AB0A10", VA = "0x1AB0A10")]
    public PlayerInfoSubScene()
    {
    }
  }
}
