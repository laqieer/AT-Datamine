// Decompiled with JetBrains decompiler
// Type: DuelCharacterCommonTimelineSettingsAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

#nullable disable
[Token(Token = "0x20000FA")]
[CreateAssetMenu(menuName = "Duel/Duel Character Common Timeline Settings Asset")]
public class DuelCharacterCommonTimelineSettingsAsset : ScriptableObject
{
  [Token(Token = "0x40004AB")]
  [FieldOffset(Offset = "0x18")]
  [Header("通常攻撃")]
  public List<NormalAttackTimelineData> normalAttackTimelineDataList;
  [Token(Token = "0x40004AC")]
  [FieldOffset(Offset = "0x20")]
  [Header("ダメージ")]
  public TimelineAsset normalDamage;
  [Token(Token = "0x40004AD")]
  [FieldOffset(Offset = "0x28")]
  public TimelineAsset lightDamage;
  [Token(Token = "0x40004AE")]
  [FieldOffset(Offset = "0x30")]
  public TimelineAsset continuousDamage;
  [Token(Token = "0x40004AF")]
  [FieldOffset(Offset = "0x38")]
  public TimelineAsset continuousDamageEnd;
  [Token(Token = "0x40004B0")]
  [FieldOffset(Offset = "0x40")]
  [Header("死亡")]
  public TimelineAsset death;
  [Token(Token = "0x40004B1")]
  [FieldOffset(Offset = "0x48")]
  [Header("回避")]
  public TimelineAsset escapeStart;
  [Token(Token = "0x40004B2")]
  [FieldOffset(Offset = "0x50")]
  [Header("ガード")]
  public TimelineAsset guardStart;
  [Token(Token = "0x40004B3")]
  [FieldOffset(Offset = "0x58")]
  public TimelineAsset guardLoop;
  [Token(Token = "0x40004B4")]
  [FieldOffset(Offset = "0x60")]
  public TimelineAsset guardLoopOverwrite;
  [Token(Token = "0x40004B5")]
  [FieldOffset(Offset = "0x68")]
  public TimelineAsset guardLoopOverwriteForDeath;
  [Token(Token = "0x40004B6")]
  [FieldOffset(Offset = "0x70")]
  public TimelineAsset guardEnd;

  [Token(Token = "0x60006E0")]
  [Address(RVA = "0x4188670", Offset = "0x4188670", VA = "0x4188670")]
  public DuelCharacterCommonTimelineSettingsAsset()
  {
  }
}
