// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.QuestSelect.MapWorldDotCharaModelPrefabProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using Scenes.OutGame.QuestSelectMap;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.QuestSelect
{
  [Token(Token = "0x20033D4")]
  public class MapWorldDotCharaModelPrefabProvider : IDotCharaModelPrefabProvider
  {
    [Token(Token = "0x400E130")]
    [FieldOffset(Offset = "0x10")]
    private AssetSpawnOperation<GameObject> asset;

    [Token(Token = "0x60145E9")]
    [Address(RVA = "0x1886174", Offset = "0x1886174", VA = "0x1886174")]
    public MapWorldDotCharaModelPrefabProvider(AssetCachedSpawner asp, int styleId)
    {
    }

    [Token(Token = "0x60145EA")]
    [Address(RVA = "0x1887190", Offset = "0x1887190", VA = "0x1887190", Slot = "5")]
    private GameObject Scenes\u002EOutGame\u002EQuestSelectMap\u002EIDotCharaModelPrefabProvider\u002EGetDotModelPrefab()
    {
      return (GameObject) null;
    }

    [Token(Token = "0x60145EB")]
    [Address(RVA = "0x18871D8", Offset = "0x18871D8", VA = "0x18871D8", Slot = "4")]
    private bool Scenes\u002EOutGame\u002EQuestSelectMap\u002EIDotCharaModelPrefabProvider\u002ECanGetDotModelPrefab()
    {
      return new bool();
    }
  }
}
