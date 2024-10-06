// Decompiled with JetBrains decompiler
// Type: DuelTurnActions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
[Token(Token = "0x200015C")]
[Serializable]
public class DuelTurnActions
{
  [Token(Token = "0x40008B7")]
  [FieldOffset(Offset = "0x10")]
  public List<DuelCharacterAction> duelCharacterActions;
  [Token(Token = "0x40008B8")]
  [FieldOffset(Offset = "0x18")]
  public ActiveSkillActionGroup actionGroup;

  [Token(Token = "0x60009D1")]
  [Address(RVA = "0x47682A0", Offset = "0x47682A0", VA = "0x47682A0")]
  public DuelTurnActions()
  {
  }

  [Token(Token = "0x200015D")]
  public enum VirtualCameraType
  {
    [Token(Token = "0x40008BA")] None,
    [Token(Token = "0x40008BB")] MainBackNear,
    [Token(Token = "0x40008BC")] MainFrontNear,
    [Token(Token = "0x40008BD")] MainBackMedium,
    [Token(Token = "0x40008BE")] MainFrontMedium,
    [Token(Token = "0x40008BF")] MainBackFar,
    [Token(Token = "0x40008C0")] MainFrontFar,
    [Token(Token = "0x40008C1")] MainFrontAhead,
    [Token(Token = "0x40008C2")] MainRightBehind,
    [Token(Token = "0x40008C3")] TargetBackNear,
    [Token(Token = "0x40008C4")] TargetFrontNear,
    [Token(Token = "0x40008C5")] TargetBackMedium,
    [Token(Token = "0x40008C6")] TargetFrontMedium,
    [Token(Token = "0x40008C7")] TargetBackFar,
    [Token(Token = "0x40008C8")] TargetFrontFar,
    [Token(Token = "0x40008C9")] TargetFrontAhead,
    [Token(Token = "0x40008CA")] TargetRightBehind,
    [Token(Token = "0x40008CB")] ActioningCharacterCenter,
    [Token(Token = "0x40008CC")] FlyingObject,
    [Token(Token = "0x40008CD")] MainTeamCenter,
    [Token(Token = "0x40008CE")] TargetTeamCenter,
  }
}
