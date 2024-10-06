// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.MasterBonus.MasterBonusDetailPopupGenerator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.MasterBonus
{
  [Token(Token = "0x2003519")]
  public class MasterBonusDetailPopupGenerator
  {
    [Token(Token = "0x400E703")]
    [FieldOffset(Offset = "0x0")]
    private static readonly string PopupAssetBundleName;
    [Token(Token = "0x400E704")]
    [FieldOffset(Offset = "0x8")]
    private static readonly string PopupAssetName;
    [Token(Token = "0x400E705")]
    [FieldOffset(Offset = "0x10")]
    private static readonly string WeaponMasterBonusIconAssetBundleName;
    [Token(Token = "0x400E706")]
    [FieldOffset(Offset = "0x10")]
    private readonly Dictionary<int, string> weaponMasterBonusIconDict;
    [Token(Token = "0x400E707")]
    [FieldOffset(Offset = "0x18")]
    private readonly AssetCachedSpawner assetCachedSpawner;

    [Token(Token = "0x6014D32")]
    [Address(RVA = "0x1B3CE28", Offset = "0x1B3CE28", VA = "0x1B3CE28")]
    public MasterBonusDetailPopupGenerator(AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x6014D33")]
    [Address(RVA = "0x1B3D198", Offset = "0x1B3D198", VA = "0x1B3D198")]
    public void Preload()
    {
    }

    [Token(Token = "0x6014D34")]
    [Address(RVA = "0x1B3D21C", Offset = "0x1B3D21C", VA = "0x1B3D21C")]
    public IEnumerator GenerateStyleMasterBonusAsync(
      IMasterBonusData masterbonusdata,
      Action<MasterBonusDetailPopup> onCreated,
      Transform parent = null,
      int maxLv = 1)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6014D35")]
    [Address(RVA = "0x1B3D2D8", Offset = "0x1B3D2D8", VA = "0x1B3D2D8")]
    static MasterBonusDetailPopupGenerator()
    {
    }
  }
}
