// Decompiled with JetBrains decompiler
// Type: DuelCharacterSingleSkillTimelineSettingsAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Timeline;

#nullable disable
[Token(Token = "0x200010D")]
[CreateAssetMenu(menuName = "Duel/Duel Character Single Skill Timeline Settings Asset")]
public class DuelCharacterSingleSkillTimelineSettingsAsset : ScriptableObject
{
  [Token(Token = "0x400058A")]
  [FieldOffset(Offset = "0x18")]
  public string skillName;
  [Token(Token = "0x400058B")]
  [FieldOffset(Offset = "0x20")]
  public TimelineAsset timelineAsset;
  [Token(Token = "0x400058C")]
  [FieldOffset(Offset = "0x28")]
  public string sceneName;
  [Token(Token = "0x400058D")]
  [FieldOffset(Offset = "0x30")]
  public float distanceFromTarget;
  [Token(Token = "0x400058E")]
  [FieldOffset(Offset = "0x38")]
  public TimelineAsset cutinAsset;

  [Token(Token = "0x6000761")]
  [Address(RVA = "0x4854CD4", Offset = "0x4854CD4", VA = "0x4854CD4")]
  public DuelCharacterSingleSkillTimelineSettingsAsset()
  {
  }
}
