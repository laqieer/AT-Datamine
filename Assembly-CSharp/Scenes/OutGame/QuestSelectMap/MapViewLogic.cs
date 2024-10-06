// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.QuestSelectMap.MapViewLogic
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.QuestSelectMap
{
  [Token(Token = "0x20033CD")]
  public class MapViewLogic : MonoBehaviour
  {
    [Token(Token = "0x400E111")]
    [FieldOffset(Offset = "0x18")]
    private ILocationDataProvider locDataAccess;
    [Token(Token = "0x400E112")]
    [FieldOffset(Offset = "0x20")]
    private MapCameraManage mapcameraManage;
    [Token(Token = "0x400E113")]
    [FieldOffset(Offset = "0x28")]
    private MapLocationManage locationManage;
    [Token(Token = "0x400E114")]
    [FieldOffset(Offset = "0x30")]
    private MapGroundObj mapObj;
    [Token(Token = "0x400E115")]
    [FieldOffset(Offset = "0x38")]
    private int nowLocHandleId;

    [Token(Token = "0x60145C4")]
    [Address(RVA = "0x2070638", Offset = "0x2070638", VA = "0x2070638")]
    public IEnumerator Initialize(
      MapSceneInitSettingsHolder initSettings,
      IGroundPrefabProvider groundAccess,
      IDotCharaModelPrefabProvider charaAccess,
      ILandmarkResourceDictProvider landDictAccess,
      ILocationDataProvider locDataAccess,
      int locHandleId)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60145C5")]
    [Address(RVA = "0x207056C", Offset = "0x207056C", VA = "0x207056C")]
    public void Destroy()
    {
    }

    [Token(Token = "0x60145C6")]
    [Address(RVA = "0x2070758", Offset = "0x2070758", VA = "0x2070758")]
    private void Update()
    {
    }

    [Token(Token = "0x60145C7")]
    [Address(RVA = "0x2070378", Offset = "0x2070378", VA = "0x2070378")]
    public void MapStart()
    {
    }

    [Token(Token = "0x60145C8")]
    [Address(RVA = "0x2070404", Offset = "0x2070404", VA = "0x2070404")]
    public void RequestChangeLocation(int locationHandleId)
    {
    }

    [Token(Token = "0x60145C9")]
    [Address(RVA = "0x2070768", Offset = "0x2070768", VA = "0x2070768")]
    public MapViewLogic()
    {
    }
  }
}
