// Decompiled with JetBrains decompiler
// Type: DuelVehicleModelSettingsAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000189")]
[CreateAssetMenu(menuName = "Duel/Duel Vehicle Model Settings Asset")]
public class DuelVehicleModelSettingsAsset : ScriptableObject
{
  [Token(Token = "0x4000A1E")]
  [FieldOffset(Offset = "0x18")]
  public GameObject modelPrefab;
  [Token(Token = "0x4000A1F")]
  [FieldOffset(Offset = "0x20")]
  public List<EffectNodeSettingsData> effectNodeSettingsDataList;
  [Token(Token = "0x4000A20")]
  [FieldOffset(Offset = "0x28")]
  [Space(5f)]
  public GameObject footSmokeEffectPrefab;
  [Token(Token = "0x4000A21")]
  [FieldOffset(Offset = "0x30")]
  public float footSmokeEffectScale;

  [Token(Token = "0x6000AB3")]
  [Address(RVA = "0x4BBA394", Offset = "0x4BBA394", VA = "0x4BBA394")]
  public DuelVehicleModelSettingsAsset()
  {
  }
}
