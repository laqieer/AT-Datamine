// Decompiled with JetBrains decompiler
// Type: DuelAbnormalStateEffectData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
[Token(Token = "0x20000F6")]
[Serializable]
public class DuelAbnormalStateEffectData
{
  [Token(Token = "0x400047A")]
  [FieldOffset(Offset = "0x10")]
  public BattleBadStatusTypeEnum abnormalState;
  [Token(Token = "0x400047B")]
  [FieldOffset(Offset = "0x18")]
  [Space(5f)]
  public GameObject startEffect;
  [Token(Token = "0x400047C")]
  [FieldOffset(Offset = "0x20")]
  public string startEffectParentName;
  [Token(Token = "0x400047D")]
  [FieldOffset(Offset = "0x28")]
  [Space(5f)]
  public GameObject loopEffect;
  [Token(Token = "0x400047E")]
  [FieldOffset(Offset = "0x30")]
  public string loopEffectParentName;
  [Token(Token = "0x400047F")]
  [FieldOffset(Offset = "0x38")]
  [Space(5f)]
  public bool isDownState;
  [Token(Token = "0x4000480")]
  [FieldOffset(Offset = "0x39")]
  [Space(5f)]
  public bool isActionStop;
  [Token(Token = "0x4000481")]
  [FieldOffset(Offset = "0x3C")]
  public float actionStopDelay;
  [Token(Token = "0x4000482")]
  [FieldOffset(Offset = "0x40")]
  [Header("Apply Material Settings")]
  public bool applyMaterialSettings;
  [Token(Token = "0x4000483")]
  [FieldOffset(Offset = "0x41")]
  [Header("Base Color")]
  public bool overrideBaseColor;
  [Token(Token = "0x4000484")]
  [FieldOffset(Offset = "0x44")]
  [Space(10f)]
  public Color characterAndVehicleBaseColor;
  [Token(Token = "0x4000485")]
  [FieldOffset(Offset = "0x54")]
  public Color weaponBaseColor;
  [Token(Token = "0x4000486")]
  [FieldOffset(Offset = "0x64")]
  [Header("Condition Texture")]
  public bool overrideConditionTexture;
  [Token(Token = "0x4000487")]
  [FieldOffset(Offset = "0x65")]
  [Space(10f)]
  public bool conditionTexture;
  [Token(Token = "0x4000488")]
  [FieldOffset(Offset = "0x68")]
  public float conditionTextureBlend;
  [Token(Token = "0x4000489")]
  [FieldOffset(Offset = "0x6C")]
  public float monochrome;
  [Token(Token = "0x400048A")]
  [FieldOffset(Offset = "0x70")]
  public float hardlightBlend;
  [Token(Token = "0x400048B")]
  [FieldOffset(Offset = "0x74")]
  public Color hardlightColor;
  [Token(Token = "0x400048C")]
  [FieldOffset(Offset = "0x84")]
  public float mixBlend;
  [Token(Token = "0x400048D")]
  [FieldOffset(Offset = "0x88")]
  public Color mixBlendColor;
  [Token(Token = "0x400048E")]
  [FieldOffset(Offset = "0x98")]
  [Header("Rim Light")]
  public bool overrideRimLight;
  [Token(Token = "0x400048F")]
  [FieldOffset(Offset = "0x9C")]
  [Space(10f)]
  public Color rimLightColor;
  [Token(Token = "0x4000490")]
  [FieldOffset(Offset = "0xAC")]
  public float rimLightPower;
  [Token(Token = "0x4000491")]
  [FieldOffset(Offset = "0xB0")]
  public float rimLightInsideMask;
  [Token(Token = "0x4000492")]
  [FieldOffset(Offset = "0xB4")]
  public bool enableRimLightMask;
  [Token(Token = "0x4000493")]
  [FieldOffset(Offset = "0xB5")]
  [Header("Outline")]
  public bool overrideOutline;
  [Token(Token = "0x4000494")]
  [FieldOffset(Offset = "0xB8")]
  [Space(10f)]
  public Color outlineColor;
  [Token(Token = "0x4000495")]
  [FieldOffset(Offset = "0xC8")]
  public bool enableOutline;
  [Token(Token = "0x4000496")]
  [FieldOffset(Offset = "0xC9")]
  [Header("Emission")]
  public bool overrideEmission;
  [Token(Token = "0x4000497")]
  [FieldOffset(Offset = "0xCA")]
  [Space(10f)]
  public bool emission;
  [Token(Token = "0x4000498")]
  [FieldOffset(Offset = "0xCC")]
  public Color emissionColor1;
  [Token(Token = "0x4000499")]
  [FieldOffset(Offset = "0xDC")]
  public Color emissionColor2;
  [Token(Token = "0x400049A")]
  [FieldOffset(Offset = "0xEC")]
  public float emissionThreshold;
  [Token(Token = "0x400049B")]
  [FieldOffset(Offset = "0xF0")]
  public float emissionPower;
  [Token(Token = "0x400049C")]
  [FieldOffset(Offset = "0xF4")]
  public bool useHDR;

  [Token(Token = "0x60006DC")]
  [Address(RVA = "0x41885C4", Offset = "0x41885C4", VA = "0x41885C4")]
  public DuelAbnormalStateEffectData()
  {
  }
}
