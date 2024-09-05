// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.QuestSelect.MapWorldGroundPrefabProvider
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
  [Token(Token = "0x20033D3")]
  public class MapWorldGroundPrefabProvider : IGroundPrefabProvider
  {
    [Token(Token = "0x400E12F")]
    [FieldOffset(Offset = "0x10")]
    private AssetSpawnOperation<GameObject> asset;

    [Token(Token = "0x60145E6")]
    [Address(RVA = "0x18860E0", Offset = "0x18860E0", VA = "0x18860E0")]
    public MapWorldGroundPrefabProvider(AssetCachedSpawner asp, int mapWorldResId)
    {
    }

    [Token(Token = "0x60145E7")]
    [Address(RVA = "0x188712C", Offset = "0x188712C", VA = "0x188712C", Slot = "5")]
    private GameObject Scenes\u002EOutGame\u002EQuestSelectMap\u002EIGroundPrefabProvider\u002EGetPrefabResource()
    {
      return (GameObject) null;
    }

    [Token(Token = "0x60145E8")]
    [Address(RVA = "0x1887174", Offset = "0x1887174", VA = "0x1887174", Slot = "4")]
    private bool Scenes\u002EOutGame\u002EQuestSelectMap\u002EIGroundPrefabProvider\u002ECanGetPrefabResource()
    {
      return new bool();
    }
  }
}
