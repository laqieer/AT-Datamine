// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Armoury.SortIconLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using StaqData.Sort;
using System;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Armoury
{
  [Token(Token = "0x200381C")]
  internal class SortIconLoader
  {
    [Token(Token = "0x400F4D7")]
    [FieldOffset(Offset = "0x10")]
    private readonly AssetCachedSpawner spawner;

    [Token(Token = "0x60160EB")]
    [Address(RVA = "0x20EF114", Offset = "0x20EF114", VA = "0x20EF114")]
    public SortIconLoader(AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x60160EC")]
    [Address(RVA = "0x20EF13C", Offset = "0x20EF13C", VA = "0x20EF13C")]
    public void LoadSortIcon(
      EquipmentSortCondition equipmentSortCondition,
      Action<Sprite> onCompleted)
    {
    }
  }
}
