// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Info.Common.UI.SpawnAssetProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.U2D;

#nullable disable
namespace Scenes.OutGame.Info.Common.UI
{
  [Token(Token = "0x20035DA")]
  public class SpawnAssetProvider : IAssetProvider
  {
    [Token(Token = "0x400EA63")]
    [FieldOffset(Offset = "0x18")]
    private AssetCachedSpawner _assetCachedSpawner;

    [Token(Token = "0x601536B")]
    [Address(RVA = "0x4D8BB3C", Offset = "0x4D8BB3C", VA = "0x4D8BB3C")]
    public SpawnAssetProvider(AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x170046AC")]
    public bool IsLoading
    {
      [Token(Token = "0x601536C"), Address(RVA = "0x4D8BB64", Offset = "0x4D8BB64", VA = "0x4D8BB64", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x601536D"), Address(RVA = "0x4D8BB6C", Offset = "0x4D8BB6C", VA = "0x4D8BB6C")] private set
      {
      }
    }

    [Token(Token = "0x601536E")]
    [Address(RVA = "0x4D8BB78", Offset = "0x4D8BB78", VA = "0x4D8BB78", Slot = "5")]
    public void LoadRequest(string assetbundlelabel, string assetname, Action<UnityEngine.Object> onloaded)
    {
    }

    [Token(Token = "0x601536F")]
    [Address(RVA = "0x4D8BC7C", Offset = "0x4D8BC7C", VA = "0x4D8BC7C", Slot = "6")]
    public void LoadRequest(string assetbundlelabel, string assetname, Action<Sprite> onloaded)
    {
    }

    [Token(Token = "0x6015370")]
    [Address(RVA = "0x4D8BD80", Offset = "0x4D8BD80", VA = "0x4D8BD80", Slot = "7")]
    public void LoadRequest(
      string assetbundlelabel,
      string assetname,
      Action<SpriteAtlas> onloaded)
    {
    }
  }
}
