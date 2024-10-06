// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.QuestSelectMap.MapLocationControlObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.QuestSelectMap
{
  [Token(Token = "0x20033B9")]
  public class MapLocationControlObject
  {
    [Token(Token = "0x400E0C9")]
    [FieldOffset(Offset = "0x10")]
    private MapLocationStandObject loc;
    [Token(Token = "0x400E0CA")]
    [FieldOffset(Offset = "0x18")]
    private MapLocationNamePlateObject namePlate;

    [Token(Token = "0x6014565")]
    [Address(RVA = "0x206DF38", Offset = "0x206DF38", VA = "0x206DF38")]
    public MapLocationControlObject(
      GameObject parentGo,
      GameObject locationPrefab,
      MapGroundData mapData,
      ILocationDataProvider.LocationData? locData,
      ILandmarkResourceDictProvider landDictAccess,
      IDotCharaModelPrefabProvider charaAccess,
      Material haveShader,
      GameObject namePrefab,
      Canvas plateCanvas)
    {
    }

    [Token(Token = "0x6014566")]
    [Address(RVA = "0x206E638", Offset = "0x206E638", VA = "0x206E638")]
    public bool IsAsynceSettupEnded() => new bool();

    [Token(Token = "0x6014567")]
    [Address(RVA = "0x206E3A8", Offset = "0x206E3A8", VA = "0x206E3A8")]
    public void OnCameraUpdate(Camera targetRendringCamera)
    {
    }

    [Token(Token = "0x6014568")]
    [Address(RVA = "0x206E2F8", Offset = "0x206E2F8", VA = "0x206E2F8")]
    public bool IsStartEnded() => new bool();

    [Token(Token = "0x6014569")]
    [Address(RVA = "0x206E2E8", Offset = "0x206E2E8", VA = "0x206E2E8")]
    public void Update()
    {
    }

    [Token(Token = "0x601456A")]
    [Address(RVA = "0x206E180", Offset = "0x206E180", VA = "0x206E180")]
    public void Destroy()
    {
    }

    [Token(Token = "0x601456B")]
    [Address(RVA = "0x206E338", Offset = "0x206E338", VA = "0x206E338")]
    public void InStart()
    {
    }

    [Token(Token = "0x601456C")]
    [Address(RVA = "0x206E550", Offset = "0x206E550", VA = "0x206E550")]
    public void OutStart()
    {
    }
  }
}
