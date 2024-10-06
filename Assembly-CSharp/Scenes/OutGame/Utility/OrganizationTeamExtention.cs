// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Utility.OrganizationTeamExtention
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using System.Collections.Generic;
using TeamOrganization;

#nullable disable
namespace Scenes.OutGame.Utility
{
  [Token(Token = "0x20032C8")]
  public static class OrganizationTeamExtention
  {
    [Token(Token = "0x6013E7D")]
    [Address(RVA = "0x1AEB808", Offset = "0x1AEB808", VA = "0x1AEB808")]
    public static int GetMemberLimitNum(this OrganizationTeam team, QuestInfo questInfo)
    {
      return new int();
    }

    [Token(Token = "0x6013E7E")]
    [Address(RVA = "0x1AEB8DC", Offset = "0x1AEB8DC", VA = "0x1AEB8DC")]
    public static int[] GetSortieDeckSlots(this OrganizationTeam team, QuestInfo questInfo)
    {
      return (int[]) null;
    }

    [Token(Token = "0x6013E7F")]
    [Address(RVA = "0x1AEBAD0", Offset = "0x1AEBAD0", VA = "0x1AEBAD0")]
    public static List<string> GetSortieDeckSlotsStringList(
      this OrganizationTeam team,
      QuestInfo questInfo)
    {
      return (List<string>) null;
    }

    [Token(Token = "0x6013E80")]
    [Address(RVA = "0x1AEBD10", Offset = "0x1AEBD10", VA = "0x1AEBD10")]
    public static List<string> GetUnitIdListWhoNeedsLevelupType(
      this OrganizationTeam team,
      QuestInfo questInfo)
    {
      return (List<string>) null;
    }

    [Token(Token = "0x6013E81")]
    [Address(RVA = "0x1AEBF48", Offset = "0x1AEBF48", VA = "0x1AEBF48")]
    public static int GetTotalCombatPower(this OrganizationTeam team, QuestInfo questInfo)
    {
      return new int();
    }
  }
}
