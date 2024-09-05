// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.QuestSelect.MapWorldLandmarkResourceDictProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using Scenes.OutGame.QuestSelectMap;
using System.Collections.Generic;

#nullable disable
namespace Scenes.OutGame.QuestSelect
{
  [Token(Token = "0x20033D5")]
  public class MapWorldLandmarkResourceDictProvider : ILandmarkResourceDictProvider
  {
    [Token(Token = "0x400E131")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<int, MapWorldLandmarkResourceDictProvider.LandmarkResourceProvider> dict;

    [Token(Token = "0x60145EC")]
    [Address(RVA = "0x1886238", Offset = "0x1886238", VA = "0x1886238")]
    public MapWorldLandmarkResourceDictProvider(
      AssetCachedSpawner asp,
      List<int> landmarkResourceIds)
    {
    }

    [Token(Token = "0x60145ED")]
    [Address(RVA = "0x1887288", Offset = "0x1887288", VA = "0x1887288", Slot = "4")]
    private List<int> Scenes\u002EOutGame\u002EQuestSelectMap\u002EILandmarkResourceDictProvider\u002EGetLandmarkHandleIdList()
    {
      return (List<int>) null;
    }

    [Token(Token = "0x60145EE")]
    [Address(RVA = "0x188732C", Offset = "0x188732C", VA = "0x188732C", Slot = "5")]
    private ILandmarkResourceProvider Scenes\u002EOutGame\u002EQuestSelectMap\u002EILandmarkResourceDictProvider\u002EGetLandmarkSpriteProviter(
      int landHandleSpId)
    {
      return (ILandmarkResourceProvider) null;
    }

    [Token(Token = "0x20033D6")]
    public class LandmarkResourceProvider : ILandmarkResourceProvider
    {
      [Token(Token = "0x400E132")]
      [FieldOffset(Offset = "0x10")]
      private AssetSpawnOperation<MapLandmarkResource> asset;

      [Token(Token = "0x60145EF")]
      [Address(RVA = "0x18871F4", Offset = "0x18871F4", VA = "0x18871F4")]
      public LandmarkResourceProvider(AssetCachedSpawner asp, int landmarkResourceId)
      {
      }

      [Token(Token = "0x60145F0")]
      [Address(RVA = "0x1887384", Offset = "0x1887384", VA = "0x1887384", Slot = "5")]
      private MapLandmarkResource Scenes\u002EOutGame\u002EQuestSelectMap\u002EILandmarkResourceProvider\u002EGetMapLandmarkResource()
      {
        return (MapLandmarkResource) null;
      }

      [Token(Token = "0x60145F1")]
      [Address(RVA = "0x18873CC", Offset = "0x18873CC", VA = "0x18873CC", Slot = "4")]
      private bool Scenes\u002EOutGame\u002EQuestSelectMap\u002EILandmarkResourceProvider\u002ECanGetMapLandmarkResource()
      {
        return new bool();
      }
    }
  }
}
