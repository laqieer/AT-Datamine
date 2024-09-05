// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.ConsumableMaterialList.Generator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.ConsumableMaterialList
{
  [Token(Token = "0x2003BF1")]
  public class Generator
  {
    [Token(Token = "0x4010991")]
    [FieldOffset(Offset = "0x0")]
    private static readonly string AssetBundleName;
    [Token(Token = "0x4010992")]
    [FieldOffset(Offset = "0x8")]
    private static readonly string AssetNameConsumeLarge;
    [Token(Token = "0x4010993")]
    [FieldOffset(Offset = "0x10")]
    private static readonly string AssetNameConsumeMini;
    [Token(Token = "0x4010994")]
    [FieldOffset(Offset = "0x10")]
    private readonly AssetCachedSpawner assetCachedSpawner;

    [Token(Token = "0x60178FD")]
    [Address(RVA = "0x237AFDC", Offset = "0x237AFDC", VA = "0x237AFDC")]
    public Generator(AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x60178FE")]
    [Address(RVA = "0x237B004", Offset = "0x237B004", VA = "0x237B004")]
    public void Preload()
    {
    }

    [Token(Token = "0x60178FF")]
    [Address(RVA = "0x237B0B0", Offset = "0x237B0B0", VA = "0x237B0B0")]
    public void SpawnAsync(
      bool isMini,
      Transform parent,
      Action<ConsumableMaterialListBase> onCompleted)
    {
    }

    [Token(Token = "0x6017900")]
    [Address(RVA = "0x237B220", Offset = "0x237B220", VA = "0x237B220")]
    static Generator()
    {
    }
  }
}
