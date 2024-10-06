// Decompiled with JetBrains decompiler
// Type: Gacha.BunusThumbnailPresenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using StaqData;
using UnityEngine;

#nullable disable
namespace Gacha
{
  [Token(Token = "0x200155B")]
  internal class BunusThumbnailPresenter : IBunusThumbnailPresenter
  {
    [Token(Token = "0x4006216")]
    private const string ThumbnailPrefabAssetBundleName = "ui_common_thumb";
    [Token(Token = "0x4006217")]
    private const string ItemThumbnailPrefabAssetName = "Com_ItemThumb";
    [Token(Token = "0x4006218")]
    [FieldOffset(Offset = "0x10")]
    private ItemUtility.Parameter parameter;
    [Token(Token = "0x4006219")]
    [FieldOffset(Offset = "0x70")]
    private Sprite iconSprite;
    [Token(Token = "0x400621A")]
    [FieldOffset(Offset = "0x78")]
    private GachaBonusRewardInfo bonusRewardInfo;
    [Token(Token = "0x400621B")]
    [FieldOffset(Offset = "0x80")]
    private GameObject thumbnailAsset;

    [Token(Token = "0x60078F9")]
    [Address(RVA = "0x44F324C", Offset = "0x44F324C", VA = "0x44F324C")]
    public BunusThumbnailPresenter(GachaBonusRewardInfo bonusRewardInfo)
    {
    }

    [Token(Token = "0x60078FA")]
    [Address(RVA = "0x44FF508", Offset = "0x44FF508", VA = "0x44FF508", Slot = "4")]
    public void AssignView(GachaBonusThumbnailView view)
    {
    }

    [Token(Token = "0x60078FB")]
    [Address(RVA = "0x44FF5CC", Offset = "0x44FF5CC", VA = "0x44FF5CC", Slot = "5")]
    public void Preload(AssetCachedSpawner spawner)
    {
    }
  }
}
