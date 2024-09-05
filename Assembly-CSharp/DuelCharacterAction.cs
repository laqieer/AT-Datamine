// Decompiled with JetBrains decompiler
// Type: DuelCharacterAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle;
using Battle.DuelScene;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine.Serialization;

#nullable disable
[Token(Token = "0x200015E")]
[Serializable]
public class DuelCharacterAction
{
  [Token(Token = "0x40008CF")]
  [FieldOffset(Offset = "0x10")]
  public DuelCharacterController.DuelCharacterRole actionCharacter;
  [Token(Token = "0x40008D0")]
  [FieldOffset(Offset = "0x18")]
  public DuelCharacterAnimation actionAnimation;
  [Token(Token = "0x40008D1")]
  [FieldOffset(Offset = "0x20")]
  public List<DuelCharacterDamageResult> damageResults;
  [Token(Token = "0x40008D2")]
  [FieldOffset(Offset = "0x28")]
  public List<ActionData> actionData;
  [Token(Token = "0x40008D3")]
  [FieldOffset(Offset = "0x30")]
  public ActiveSkillActionGroup activeSkillActionGroup;
  [Token(Token = "0x40008D4")]
  [FieldOffset(Offset = "0x34")]
  [FormerlySerializedAs("isDefenderFirstStrikeAction")]
  public bool attackerForceFirstStrikeAction;

  [Token(Token = "0x60009D2")]
  [Address(RVA = "0x47682A8", Offset = "0x47682A8", VA = "0x47682A8")]
  public DuelCharacterAction()
  {
  }
}
