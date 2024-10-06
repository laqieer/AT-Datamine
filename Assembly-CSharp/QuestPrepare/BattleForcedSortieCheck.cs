// Decompiled with JetBrains decompiler
// Type: QuestPrepare.BattleForcedSortieCheck
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using TeamOrganization;

#nullable disable
namespace QuestPrepare
{
  [Token(Token = "0x200096C")]
  public class BattleForcedSortieCheck
  {
    [Token(Token = "0x4002BAC")]
    [FieldOffset(Offset = "0x10")]
    private IReadOnlyList<BattleForcedSortieData> battleForcedSortieDatas;
    [Token(Token = "0x4002BAD")]
    [FieldOffset(Offset = "0x18")]
    public Dictionary<int, List<Tuple<bool, int>>> ViewList;

    [Token(Token = "0x1700077C")]
    public int MasterDataCount
    {
      [Token(Token = "0x6003530"), Address(RVA = "0x3524398", Offset = "0x3524398", VA = "0x3524398")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6003531")]
    [Address(RVA = "0x35244B0", Offset = "0x35244B0", VA = "0x35244B0")]
    public BattleForcedSortieCheck(int forcedSortieGroupId)
    {
    }

    [Token(Token = "0x6003532")]
    [Address(RVA = "0x352459C", Offset = "0x352459C", VA = "0x352459C")]
    public void SetForcedSortie(OrganizationTeam team, int memberNum)
    {
    }

    [Token(Token = "0x6003533")]
    [Address(RVA = "0x3524F00", Offset = "0x3524F00", VA = "0x3524F00")]
    public void ResetForcedSortie(OrganizationTeam team)
    {
    }

    [Token(Token = "0x6003534")]
    [Address(RVA = "0x3524FEC", Offset = "0x3524FEC", VA = "0x3524FEC")]
    public bool CheckForcedSortie(OrganizationTeam team, int memberNum) => new bool();

    [Token(Token = "0x6003535")]
    [Address(RVA = "0x3524CE8", Offset = "0x3524CE8", VA = "0x3524CE8")]
    private bool ForcedStyle(OrganizationTeam team, int styleId, int memberNum) => new bool();

    [Token(Token = "0x6003536")]
    [Address(RVA = "0x3524DF0", Offset = "0x3524DF0", VA = "0x3524DF0")]
    private bool ForcedCharacter(OrganizationTeam team, int characterId, int memberNum)
    {
      return new bool();
    }

    [Token(Token = "0x6003537")]
    [Address(RVA = "0x3524968", Offset = "0x3524968", VA = "0x3524968")]
    private void ForcedGuestStyle(OrganizationTeam team, int npcId)
    {
    }

    [Token(Token = "0x6003538")]
    [Address(RVA = "0x3524A78", Offset = "0x3524A78", VA = "0x3524A78")]
    private void SetByViewData(
      BatteForcedSortieRestrictionTypeEnum typeEnum,
      int data,
      bool isAlert)
    {
    }

    [Token(Token = "0x6003539")]
    [Address(RVA = "0x3525338", Offset = "0x3525338", VA = "0x3525338")]
    public bool CheckSlotForced(OrganizationPartySlot partySlot) => new bool();

    [Token(Token = "0x600353A")]
    [Address(RVA = "0x35256C0", Offset = "0x35256C0", VA = "0x35256C0")]
    public List<int> GetForcedInCharacter() => (List<int>) null;

    [Token(Token = "0x600353B")]
    [Address(RVA = "0x3525A64", Offset = "0x3525A64", VA = "0x3525A64")]
    public List<int> GetForcedInStyle() => (List<int>) null;
  }
}
