// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.MasterBonus.ContainerElementMasterBonusGenerator
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
  [Token(Token = "0x200352B")]
  public class ContainerElementMasterBonusGenerator
  {
    [Token(Token = "0x400E74B")]
    private const string AssetBundleName = "ui_page_masterbonus";
    [Token(Token = "0x400E74C")]
    private const string AssetName = "Container_ElementMasterBonus";
    [Token(Token = "0x400E74D")]
    [FieldOffset(Offset = "0x10")]
    private readonly AssetCachedSpawner assetCachedSpawner;

    [Token(Token = "0x6014D81")]
    [Address(RVA = "0x1B40D9C", Offset = "0x1B40D9C", VA = "0x1B40D9C")]
    public ContainerElementMasterBonusGenerator(AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x6014D82")]
    [Address(RVA = "0x1B40DC4", Offset = "0x1B40DC4", VA = "0x1B40DC4")]
    public void Preload()
    {
    }

    [Token(Token = "0x6014D83")]
    [Address(RVA = "0x1B40314", Offset = "0x1B40314", VA = "0x1B40314")]
    public void SpawnAsync(Transform parent, Action<ContainerElementMasterBonus> onCompleted)
    {
    }
  }
}
