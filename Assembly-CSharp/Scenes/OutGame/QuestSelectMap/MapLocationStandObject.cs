// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.QuestSelectMap.MapLocationStandObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.QuestSelectMap
{
  [Token(Token = "0x20033BC")]
  public class MapLocationStandObject
  {
    [Token(Token = "0x400E0D3")]
    [FieldOffset(Offset = "0x10")]
    private GameObject resPrefab;
    [Token(Token = "0x400E0D4")]
    [FieldOffset(Offset = "0x18")]
    private GameObject locgo;
    [Token(Token = "0x400E0D5")]
    [FieldOffset(Offset = "0x20")]
    private MapLocationObjControl con;
    [Token(Token = "0x400E0D6")]
    [FieldOffset(Offset = "0x28")]
    private IDotCharaModelPrefabProvider charaAccess;
    [Token(Token = "0x400E0D7")]
    [FieldOffset(Offset = "0x30")]
    private ILandmarkResourceProvider landAccess;
    [Token(Token = "0x400E0D8")]
    [FieldOffset(Offset = "0x38")]
    private bool isCharaSettuped;
    [Token(Token = "0x400E0D9")]
    [FieldOffset(Offset = "0x39")]
    private bool isLandSettuped;
    [Token(Token = "0x400E0DA")]
    [FieldOffset(Offset = "0x40")]
    private Material haveShaderingPrameter;
    [Token(Token = "0x400E0DB")]
    [FieldOffset(Offset = "0x48")]
    private List<Material> mats;
    [Token(Token = "0x400E0DC")]
    [FieldOffset(Offset = "0x50")]
    private MapLocationStandObject.InOutType nowType;

    [Token(Token = "0x6014574")]
    [Address(RVA = "0x206E734", Offset = "0x206E734", VA = "0x206E734")]
    public void Init(
      GameObject parentGo,
      GameObject prefab,
      MapGroundData mapData,
      ILocationDataProvider.LocationData locData,
      ILandmarkResourceDictProvider landDictAccess,
      IDotCharaModelPrefabProvider charaAccess,
      Material haveShader)
    {
    }

    [Token(Token = "0x6014575")]
    [Address(RVA = "0x206F438", Offset = "0x206F438", VA = "0x206F438")]
    public void InStart()
    {
    }

    [Token(Token = "0x6014576")]
    [Address(RVA = "0x206EAF8", Offset = "0x206EAF8", VA = "0x206EAF8")]
    public void CameraUpdate(Transform cameraTrans)
    {
    }

    [Token(Token = "0x6014577")]
    [Address(RVA = "0x206F5F0", Offset = "0x206F5F0", VA = "0x206F5F0")]
    public void OutStart()
    {
    }

    [Token(Token = "0x6014578")]
    [Address(RVA = "0x206EEF4", Offset = "0x206EEF4", VA = "0x206EEF4")]
    public bool IsStartEnded() => new bool();

    [Token(Token = "0x6014579")]
    [Address(RVA = "0x206EAD8", Offset = "0x206EAD8", VA = "0x206EAD8")]
    public bool IsAsynceSettupEnded() => new bool();

    [Token(Token = "0x601457A")]
    [Address(RVA = "0x206EC80", Offset = "0x206EC80", VA = "0x206EC80")]
    public bool TryGetNamePosW(out Vector3 posW) => new bool();

    [Token(Token = "0x601457B")]
    [Address(RVA = "0x206F164", Offset = "0x206F164", VA = "0x206F164")]
    public void Destroy()
    {
    }

    [Token(Token = "0x601457C")]
    [Address(RVA = "0x206F0E4", Offset = "0x206F0E4", VA = "0x206F0E4")]
    public void Update()
    {
    }

    [Token(Token = "0x601457D")]
    [Address(RVA = "0x206F7B0", Offset = "0x206F7B0", VA = "0x206F7B0")]
    private void UpdateCharaSettup()
    {
    }

    [Token(Token = "0x601457E")]
    [Address(RVA = "0x206FB60", Offset = "0x206FB60", VA = "0x206FB60")]
    private void UpdateLandSettup()
    {
    }

    [Token(Token = "0x601457F")]
    [Address(RVA = "0x206FCA8", Offset = "0x206FCA8", VA = "0x206FCA8")]
    private void OnCharaFadeUpdate(float fadeValue)
    {
    }

    [Token(Token = "0x6014580")]
    [Address(RVA = "0x206E6B8", Offset = "0x206E6B8", VA = "0x206E6B8")]
    public MapLocationStandObject()
    {
    }

    [Token(Token = "0x20033BD")]
    private enum InOutType
    {
      [Token(Token = "0x400E0DE")] None,
      [Token(Token = "0x400E0DF")] In,
      [Token(Token = "0x400E0E0")] Out,
    }
  }
}
