// Decompiled with JetBrains decompiler
// Type: TeamOrganization.PartySlotSortingView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x20007FA")]
  public class PartySlotSortingView : MonoBehaviour
  {
    [Token(Token = "0x400257A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text teamNameText;
    [Token(Token = "0x400257B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject[] partyObj;
    [Token(Token = "0x400257C")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private PartySlotSortingCell[] sortingCells;
    [Token(Token = "0x400257D")]
    [FieldOffset(Offset = "0x30")]
    private OrganizationTeam organizationTeam;
    [Token(Token = "0x400257E")]
    [FieldOffset(Offset = "0x38")]
    private bool isSelect;
    [Token(Token = "0x400257F")]
    [FieldOffset(Offset = "0x3C")]
    private int selectIndex;
    [Token(Token = "0x4002580")]
    [FieldOffset(Offset = "0x40")]
    private AssetCachedSpawner assetCachedSpawner;

    [Token(Token = "0x6002D8F")]
    [Address(RVA = "0x3A89718", Offset = "0x3A89718", VA = "0x3A89718")]
    public void Initialize(
      OrganizationTeam team,
      bool isNeedLp,
      bool isGuildRaid,
      List<string> usedStyleIds,
      AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x6002D90")]
    [Address(RVA = "0x3A8993C", Offset = "0x3A8993C", VA = "0x3A8993C")]
    public void InitSelect()
    {
    }

    [Token(Token = "0x6002D91")]
    [Address(RVA = "0x3A8994C", Offset = "0x3A8994C", VA = "0x3A8994C")]
    public void UpdateView()
    {
    }

    [Token(Token = "0x6002D92")]
    [Address(RVA = "0x3A89A64", Offset = "0x3A89A64", VA = "0x3A89A64")]
    public void OnClickPartyUnitSlot(int index)
    {
    }

    [Token(Token = "0x6002D93")]
    [Address(RVA = "0x3A89AF4", Offset = "0x3A89AF4", VA = "0x3A89AF4")]
    private void ChangeCellSelect(int index, bool isSelect)
    {
    }

    [Token(Token = "0x6002D94")]
    [Address(RVA = "0x3A89C1C", Offset = "0x3A89C1C", VA = "0x3A89C1C")]
    public PartySlotSortingView()
    {
    }
  }
}
