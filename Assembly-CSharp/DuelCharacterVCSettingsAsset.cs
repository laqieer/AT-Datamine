// Decompiled with JetBrains decompiler
// Type: DuelCharacterVCSettingsAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000110")]
[CreateAssetMenu(menuName = "Duel/Duel Character VC Settings Asset")]
public class DuelCharacterVCSettingsAsset : ScriptableObject
{
  [Token(Token = "0x4000594")]
  [FieldOffset(Offset = "0x18")]
  [Header("前のカメラ")]
  [Range(0.0f, 90f)]
  public float frontVCAngle;
  [Token(Token = "0x4000595")]
  [FieldOffset(Offset = "0x1C")]
  public float frontVCHeight;
  [Token(Token = "0x4000596")]
  [FieldOffset(Offset = "0x20")]
  [Space(10f)]
  public float frontNearVCDistance;
  [Token(Token = "0x4000597")]
  [FieldOffset(Offset = "0x24")]
  public Vector2 frontNearVCScreenXY;
  [Token(Token = "0x4000598")]
  [FieldOffset(Offset = "0x2C")]
  [Space(5f)]
  public float frontMediumVCDistance;
  [Token(Token = "0x4000599")]
  [FieldOffset(Offset = "0x30")]
  public Vector2 frontMediumVCScreenXY;
  [Token(Token = "0x400059A")]
  [FieldOffset(Offset = "0x38")]
  [Space(5f)]
  public float frontFarVCDistance;
  [Token(Token = "0x400059B")]
  [FieldOffset(Offset = "0x3C")]
  public Vector2 frontFarVCScreenXY;
  [Token(Token = "0x400059C")]
  [FieldOffset(Offset = "0x44")]
  [Header("真正面のカメラ")]
  public float frontAheadVCHeight;
  [Token(Token = "0x400059D")]
  [FieldOffset(Offset = "0x48")]
  public float frontAheadVCDistance;
  [Token(Token = "0x400059E")]
  [FieldOffset(Offset = "0x4C")]
  public Vector2 frontAheadVCScreenXY;
  [Token(Token = "0x400059F")]
  [FieldOffset(Offset = "0x54")]
  [Range(90f, 180f)]
  [Header("後ろのカメラ")]
  public float backVCAngle;
  [Token(Token = "0x40005A0")]
  [FieldOffset(Offset = "0x58")]
  public float backVCHeight;
  [Token(Token = "0x40005A1")]
  [FieldOffset(Offset = "0x5C")]
  [Space(10f)]
  public float backNearVCDistance;
  [Token(Token = "0x40005A2")]
  [FieldOffset(Offset = "0x60")]
  public Vector2 backNearVCScreenXY;
  [Token(Token = "0x40005A3")]
  [FieldOffset(Offset = "0x68")]
  [Space(5f)]
  public float backMediumVCDistance;
  [Token(Token = "0x40005A4")]
  [FieldOffset(Offset = "0x6C")]
  public Vector2 backMediumVCScreenXY;
  [Token(Token = "0x40005A5")]
  [FieldOffset(Offset = "0x74")]
  [Space(5f)]
  public float backFarVCDistance;
  [Token(Token = "0x40005A6")]
  [FieldOffset(Offset = "0x78")]
  public Vector2 backFarVCScreenXY;
  [Token(Token = "0x40005A7")]
  [FieldOffset(Offset = "0x80")]
  [Header("真後ろのカメラ")]
  public float rightBehindVCHeight;
  [Token(Token = "0x40005A8")]
  [FieldOffset(Offset = "0x84")]
  public float rightBehindVCDistance;
  [Token(Token = "0x40005A9")]
  [FieldOffset(Offset = "0x88")]
  public Vector2 rightBehindVCScreenXY;

  [Token(Token = "0x6000768")]
  [Address(RVA = "0x4854DC8", Offset = "0x4854DC8", VA = "0x4854DC8")]
  public DuelCharacterVCSettingsAsset()
  {
  }
}
