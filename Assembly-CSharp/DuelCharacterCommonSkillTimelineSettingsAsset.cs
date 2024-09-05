// Decompiled with JetBrains decompiler
// Type: DuelCharacterCommonSkillTimelineSettingsAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Timeline;

#nullable disable
[Token(Token = "0x20000F9")]
[CreateAssetMenu(menuName = "Duel/Duel Character Common Skill Timeline Settings Asset")]
public class DuelCharacterCommonSkillTimelineSettingsAsset : ScriptableObject
{
  [Token(Token = "0x40004A6")]
  [FieldOffset(Offset = "0x18")]
  public string skillName;
  [Token(Token = "0x40004A7")]
  [FieldOffset(Offset = "0x20")]
  public DuelCharacterAnimation.MainAnimationRange range;
  [Token(Token = "0x40004A8")]
  [FieldOffset(Offset = "0x28")]
  public TimelineAsset timelineAsset;
  [Token(Token = "0x40004A9")]
  [FieldOffset(Offset = "0x30")]
  public float distanceFromTarget;
  [Token(Token = "0x40004AA")]
  [FieldOffset(Offset = "0x38")]
  public string thrownWeaponHitNodeName;

  [Token(Token = "0x60006DF")]
  [Address(RVA = "0x4188668", Offset = "0x4188668", VA = "0x4188668")]
  public DuelCharacterCommonSkillTimelineSettingsAsset()
  {
  }
}
