// Decompiled with JetBrains decompiler
// Type: DuelSettingsAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000158")]
[CreateAssetMenu(menuName = "Duel/Duel Settings Asset")]
public class DuelSettingsAsset : ScriptableObject
{
  [Token(Token = "0x4000895")]
  [FieldOffset(Offset = "0x18")]
  public int loopTimes;
  [Token(Token = "0x4000896")]
  [FieldOffset(Offset = "0x20")]
  public string backgroundSceneName;
  [Token(Token = "0x4000897")]
  [FieldOffset(Offset = "0x28")]
  public int mementosFloor;
  [Token(Token = "0x4000898")]
  [FieldOffset(Offset = "0x30")]
  public List<string> soundPackNames;
  [Token(Token = "0x4000899")]
  [FieldOffset(Offset = "0x38")]
  public Vector3 attackerDefaultPosition;
  [Token(Token = "0x400089A")]
  [FieldOffset(Offset = "0x44")]
  public Vector3 defenderDefaultPosition;
  [Token(Token = "0x400089B")]
  [FieldOffset(Offset = "0x50")]
  public int attackerHP;
  [Token(Token = "0x400089C")]
  [FieldOffset(Offset = "0x54")]
  public int attackerMaxHP;
  [Token(Token = "0x400089D")]
  [FieldOffset(Offset = "0x58")]
  public int attackerHPStock;
  [Token(Token = "0x400089E")]
  [FieldOffset(Offset = "0x5C")]
  public int attackerSupporterHP;
  [Token(Token = "0x400089F")]
  [FieldOffset(Offset = "0x60")]
  public int attackerSupporterMaxHP;
  [Token(Token = "0x40008A0")]
  [FieldOffset(Offset = "0x64")]
  public int attackerSupporterHPStock;
  [Token(Token = "0x40008A1")]
  [FieldOffset(Offset = "0x68")]
  public int defenderHP;
  [Token(Token = "0x40008A2")]
  [FieldOffset(Offset = "0x6C")]
  public int defenderMaxHP;
  [Token(Token = "0x40008A3")]
  [FieldOffset(Offset = "0x70")]
  public int defenderHPStock;
  [Token(Token = "0x40008A4")]
  [FieldOffset(Offset = "0x74")]
  public int defenderSupporterHP;
  [Token(Token = "0x40008A5")]
  [FieldOffset(Offset = "0x78")]
  public int defenderSupporterMaxHP;
  [Token(Token = "0x40008A6")]
  [FieldOffset(Offset = "0x7C")]
  public int defenderSupporterHPStock;
  [Token(Token = "0x40008A7")]
  private const float defaultLeaderDistance = 10f;
  [Token(Token = "0x40008A8")]
  private const float giantBossQuestLeaderDistance = 12.5f;
  [Token(Token = "0x40008A9")]
  [FieldOffset(Offset = "0x80")]
  public List<DuelCharacterSettings> duelCharacterSettingsList;
  [Token(Token = "0x40008AA")]
  [FieldOffset(Offset = "0x88")]
  public List<DuelTurnActions> duelTurnActionsList;

  [Token(Token = "0x60009C8")]
  [Address(RVA = "0x4768454", Offset = "0x4768454", VA = "0x4768454")]
  [ContextMenu("Set Characters' Position")]
  public void SetCharactersDefaultPositions()
  {
  }

  [Token(Token = "0x60009C9")]
  [Address(RVA = "0x4775D08", Offset = "0x4775D08", VA = "0x4775D08")]
  public DuelSettingsAsset()
  {
  }
}
