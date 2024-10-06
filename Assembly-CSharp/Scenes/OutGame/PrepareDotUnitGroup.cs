// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.PrepareDotUnitGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using QuestPrepare;
using System.Collections.Generic;
using TeamOrganization;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x2003227")]
  public class PrepareDotUnitGroup : MonoBehaviour
  {
    [Token(Token = "0x400D63D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PrepareDotUnit[] team1;
    [Token(Token = "0x400D63E")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PrepareDotUnit[] team2;
    [Token(Token = "0x400D63F")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private PrepareDotUnit[] team3;
    [Token(Token = "0x400D640")]
    [FieldOffset(Offset = "0x30")]
    private List<PrepareDotUnit> prepareDotUnitList;
    [Token(Token = "0x400D641")]
    [FieldOffset(Offset = "0x38")]
    private Dictionary<int, PrepareDotUnit[]> dotUnitMap;

    [Token(Token = "0x601390D")]
    [Address(RVA = "0x49C8BF0", Offset = "0x49C8BF0", VA = "0x49C8BF0")]
    public void Initialize(
      int maxLength,
      int onePartyUnitMax,
      int battleMenberNum,
      int memberMaxNum,
      OrganizationTeam team,
      BattleForcedSortieCheck sortieCheck,
      BattleSortieRestrictionsCheck sortieRestrictionsCheck,
      QuestPrepareAssetLoader loader)
    {
    }

    [Token(Token = "0x601390E")]
    [Address(RVA = "0x49C959C", Offset = "0x49C959C", VA = "0x49C959C")]
    public void InitializeArena(
      int maxLength,
      int onePartyUnitMax,
      int battleMenberNum,
      OrganizationTeam team,
      QuestPrepareAssetLoader loader)
    {
    }

    [Token(Token = "0x601390F")]
    [Address(RVA = "0x49CAA30", Offset = "0x49CAA30", VA = "0x49CAA30")]
    public void Delete()
    {
    }

    [Token(Token = "0x6013910")]
    [Address(RVA = "0x49CB2E8", Offset = "0x49CB2E8", VA = "0x49CB2E8")]
    public PrepareDotUnitGroup()
    {
    }
  }
}
