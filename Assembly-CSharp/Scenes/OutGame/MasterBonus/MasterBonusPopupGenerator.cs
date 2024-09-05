// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.MasterBonus.MasterBonusPopupGenerator
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
  [Token(Token = "0x200351E")]
  public class MasterBonusPopupGenerator
  {
    [Token(Token = "0x400E71F")]
    private const string AssetBundleName = "ui_page_masterbonus";
    [Token(Token = "0x400E720")]
    private const string AssetName = "Com_Popup_MasterBonus_Base";
    [Token(Token = "0x400E721")]
    private const string AssetNameStyle = "Com_Popup_MasterBonus_Base_M";
    [Token(Token = "0x400E722")]
    [FieldOffset(Offset = "0x10")]
    private readonly AssetCachedSpawner assetCachedSpawner;

    [Token(Token = "0x6014D4F")]
    [Address(RVA = "0x1B3E77C", Offset = "0x1B3E77C", VA = "0x1B3E77C")]
    public MasterBonusPopupGenerator(AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x6014D50")]
    [Address(RVA = "0x1B3E7A4", Offset = "0x1B3E7A4", VA = "0x1B3E7A4")]
    public void Preload()
    {
    }

    [Token(Token = "0x6014D51")]
    [Address(RVA = "0x1B3E850", Offset = "0x1B3E850", VA = "0x1B3E850")]
    public void SpawnAsync(Transform parent = null, bool style = false, Action<MasterBonusPopup> onCompleted = null)
    {
    }
  }
}
