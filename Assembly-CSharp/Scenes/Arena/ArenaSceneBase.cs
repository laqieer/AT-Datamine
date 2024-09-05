// Decompiled with JetBrains decompiler
// Type: Scenes.Arena.ArenaSceneBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Scene;
using Il2CppDummyDll;
using System;
using UI.Direction;
using UnityEngine;

#nullable disable
namespace Scenes.Arena
{
  [Token(Token = "0x2003115")]
  public class ArenaSceneBase : SubScene
  {
    [Token(Token = "0x400D0F0")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    protected UITimelineController timelineController;
    [Token(Token = "0x400D0F1")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    protected AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400D0F3")]
    [FieldOffset(Offset = "0x70")]
    public bool isAnimation;

    [Token(Token = "0x1700403A")]
    public ArenaLoader ArenaLoader
    {
      [Token(Token = "0x60132AA"), Address(RVA = "0x45E1EF8", Offset = "0x45E1EF8", VA = "0x45E1EF8")] get
      {
        return (ArenaLoader) null;
      }
      [Token(Token = "0x60132AB"), Address(RVA = "0x45E1F00", Offset = "0x45E1F00", VA = "0x45E1F00")] private set
      {
      }
    }

    [Token(Token = "0x60132AC")]
    [Address(RVA = "0x45E1F08", Offset = "0x45E1F08", VA = "0x45E1F08", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x60132AD")]
    [Address(RVA = "0x45E1F70", Offset = "0x45E1F70", VA = "0x45E1F70")]
    public void InAnimation(
      string key,
      ArenaAssetBundleParam.TimelineSettingType settingType,
      Action finishAction = null)
    {
    }

    [Token(Token = "0x60132AE")]
    [Address(RVA = "0x45E21AC", Offset = "0x45E21AC", VA = "0x45E21AC")]
    public void OutAnimation(
      string key,
      ArenaAssetBundleParam.TimelineSettingType settingType,
      Action finishAction = null)
    {
    }

    [Token(Token = "0x60132AF")]
    [Address(RVA = "0x45E2394", Offset = "0x45E2394", VA = "0x45E2394")]
    public ArenaSceneBase()
    {
    }
  }
}
