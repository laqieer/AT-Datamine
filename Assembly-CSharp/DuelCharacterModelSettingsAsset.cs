// Decompiled with JetBrains decompiler
// Type: DuelCharacterModelSettingsAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x200010A")]
[CreateAssetMenu(menuName = "Duel/Duel Character Model Settings Asset")]
public class DuelCharacterModelSettingsAsset : ScriptableObject
{
  [Token(Token = "0x4000571")]
  [FieldOffset(Offset = "0x18")]
  public bool isGiantBoss;
  [Token(Token = "0x4000572")]
  [FieldOffset(Offset = "0x20")]
  public GameObject modelPrefab;
  [Token(Token = "0x4000573")]
  [FieldOffset(Offset = "0x28")]
  public List<EffectNodeSettingsData> effectNodeSettingsDataList;
  [Token(Token = "0x4000574")]
  [FieldOffset(Offset = "0x30")]
  public float weaponScale;
  [Token(Token = "0x4000575")]
  [FieldOffset(Offset = "0x34")]
  public float abnormalEffectScale;
  [Token(Token = "0x4000576")]
  [FieldOffset(Offset = "0x38")]
  public float aimTargetScaleY;
  [Token(Token = "0x4000577")]
  [FieldOffset(Offset = "0x40")]
  [Space(5f)]
  public GameObject footSmokeEffectPrefab;
  [Token(Token = "0x4000578")]
  [FieldOffset(Offset = "0x48")]
  public float footSmokeEffectScale;

  [Token(Token = "0x600075E")]
  [Address(RVA = "0x4854B18", Offset = "0x4854B18", VA = "0x4854B18")]
  public DuelCharacterModelSettingsAsset()
  {
  }
}
