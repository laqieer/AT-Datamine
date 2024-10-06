// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.MasterBonus.ContainerWeaponMasterBonusGenerator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.MasterBonus
{
  [Token(Token = "0x2003534")]
  public class ContainerWeaponMasterBonusGenerator
  {
    [Token(Token = "0x400E766")]
    private const string AssetBundleName = "ui_page_masterbonus";
    [Token(Token = "0x400E767")]
    private const string AssetName = "Container_WeaponMasterBonus";
    [Token(Token = "0x400E768")]
    [FieldOffset(Offset = "0x10")]
    private readonly AssetCachedSpawner assetCachedSpawner;

    [Token(Token = "0x6014DB8")]
    [Address(RVA = "0x1B414D8", Offset = "0x1B414D8", VA = "0x1B414D8")]
    public ContainerWeaponMasterBonusGenerator(AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x6014DB9")]
    [Address(RVA = "0x1B41500", Offset = "0x1B41500", VA = "0x1B41500")]
    public void Preload()
    {
    }

    [Token(Token = "0x6014DBA")]
    [Address(RVA = "0x1B4082C", Offset = "0x1B4082C", VA = "0x1B4082C")]
    public void SpawnAsync(Transform parent, Action<ContainerWeaponMasterBonus> onCompleted)
    {
    }
  }
}
