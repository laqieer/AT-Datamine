// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.QuestSelectMap.MapLocationManage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.QuestSelectMap
{
  [Token(Token = "0x20033B6")]
  public class MapLocationManage
  {
    [Token(Token = "0x400E0B5")]
    [FieldOffset(Offset = "0x10")]
    private MapGroundData mapData;
    [Token(Token = "0x400E0B6")]
    [FieldOffset(Offset = "0x18")]
    private ILandmarkResourceDictProvider landDictAccess;
    [Token(Token = "0x400E0B7")]
    [FieldOffset(Offset = "0x20")]
    private IDotCharaModelPrefabProvider charaAccess;
    [Token(Token = "0x400E0B8")]
    [FieldOffset(Offset = "0x28")]
    private Canvas namePlateCanvas;
    [Token(Token = "0x400E0B9")]
    [FieldOffset(Offset = "0x30")]
    private GameObject parentGo;
    [Token(Token = "0x400E0BA")]
    [FieldOffset(Offset = "0x38")]
    private GameObject locationPrefab;
    [Token(Token = "0x400E0BB")]
    [FieldOffset(Offset = "0x40")]
    private Material haveDotCharaShaderingParam;
    [Token(Token = "0x400E0BC")]
    [FieldOffset(Offset = "0x48")]
    private GameObject locationNameUIPrefab;
    [Token(Token = "0x400E0BD")]
    [FieldOffset(Offset = "0x50")]
    private Camera mapModelRenderingCamera;
    [Token(Token = "0x400E0BE")]
    [FieldOffset(Offset = "0x58")]
    private MapLocationManage.UpdateStatusType status;
    [Token(Token = "0x400E0BF")]
    [FieldOffset(Offset = "0x60")]
    private ILocationDataProvider.LocationData? nextLocData;
    [Token(Token = "0x400E0C0")]
    [FieldOffset(Offset = "0x80")]
    private MapLocationControlObject locObj;

    [Token(Token = "0x6014557")]
    [Address(RVA = "0x206DDFC", Offset = "0x206DDFC", VA = "0x206DDFC")]
    public MapLocationManage(
      GameObject parentGo,
      GameObject locationPrefab,
      Material haveDotCharaShaderParam,
      GameObject locationNameUIPrefab,
      Canvas namePlateCanvas,
      Camera mapModelRenderingCamera,
      MapGroundData mapData,
      ILandmarkResourceDictProvider landDictAccess,
      IDotCharaModelPrefabProvider charaAccess)
    {
    }

    [Token(Token = "0x6014558")]
    [Address(RVA = "0x206DE70", Offset = "0x206DE70", VA = "0x206DE70")]
    private MapLocationControlObject Create(ILocationDataProvider.LocationData? nowData)
    {
      return (MapLocationControlObject) null;
    }

    [Token(Token = "0x6014559")]
    [Address(RVA = "0x206E0B8", Offset = "0x206E0B8", VA = "0x206E0B8")]
    public IEnumerator Initialize(ILocationDataProvider.LocationData? nowData)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601455A")]
    [Address(RVA = "0x206E160", Offset = "0x206E160", VA = "0x206E160")]
    public void Destory()
    {
    }

    [Token(Token = "0x601455B")]
    [Address(RVA = "0x206E1B0", Offset = "0x206E1B0", VA = "0x206E1B0")]
    public void Update()
    {
    }

    [Token(Token = "0x601455C")]
    [Address(RVA = "0x206E368", Offset = "0x206E368", VA = "0x206E368")]
    public void MapStart()
    {
    }

    [Token(Token = "0x601455D")]
    [Address(RVA = "0x206E390", Offset = "0x206E390", VA = "0x206E390")]
    public void OnCameraUpdate()
    {
    }

    [Token(Token = "0x601455E")]
    [Address(RVA = "0x206E424", Offset = "0x206E424", VA = "0x206E424")]
    public void RequestLocationChange(ILocationDataProvider.LocationData? locData)
    {
    }

    [Token(Token = "0x20033B7")]
    private enum UpdateStatusType
    {
      [Token(Token = "0x400E0C2")] None,
      [Token(Token = "0x400E0C3")] Ining,
      [Token(Token = "0x400E0C4")] Outing,
    }
  }
}
