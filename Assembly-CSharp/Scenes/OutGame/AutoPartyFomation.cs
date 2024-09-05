// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.AutoPartyFomation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections.Generic;
using TeamOrganization;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x2003287")]
  public static class AutoPartyFomation
  {
    [Token(Token = "0x6013B4A")]
    [Address(RVA = "0x18574BC", Offset = "0x18574BC", VA = "0x18574BC")]
    public static void AutoExpeditionOrganization(
      int slotNum,
      ElementTypeEnum stageElementType,
      Action<List<Style>> action)
    {
    }

    [Token(Token = "0x6013B4B")]
    [Address(RVA = "0x1857870", Offset = "0x1857870", VA = "0x1857870")]
    private static List<Style> AutoExpeditionOrganization(
      int slotNum,
      ElementTypeEnum stageElementType)
    {
      return (List<Style>) null;
    }

    [Token(Token = "0x6013B4C")]
    [Address(RVA = "0x1858120", Offset = "0x1858120", VA = "0x1858120")]
    public static void AutoTeamFomation(
      AutoFormationSetting autoSetting,
      OrganizationTeam originalTeam,
      bool isTemplate,
      Action<OrganizationTeam, bool> action,
      bool isAllowSameCharacter,
      bool isGuildRaid,
      List<string> usedStyleIds)
    {
    }

    [Token(Token = "0x6013B4D")]
    [Address(RVA = "0x1858164", Offset = "0x1858164", VA = "0x1858164")]
    private static OrganizationTeam CallAutoTeamFomation(
      AutoFormationSetting autoSetting,
      OrganizationTeam originalTeam,
      bool isTemplate,
      bool isAllowSameCharacter,
      bool isGuildRaid,
      List<string> usedStyleIds)
    {
      return (OrganizationTeam) null;
    }
  }
}
