// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.PartyItemManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using TeamOrganization;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x2003220")]
  [Serializable]
  public class PartyItemManager
  {
    [Token(Token = "0x400D60E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private UseItemIcon[] useItemIcons;
    [Token(Token = "0x400D610")]
    [FieldOffset(Offset = "0x20")]
    private int itemSetNo;
    [Token(Token = "0x400D611")]
    [FieldOffset(Offset = "0x28")]
    private List<OrganizationItemSet> itemSets;
    [Token(Token = "0x400D612")]
    [FieldOffset(Offset = "0x30")]
    private ItemSetListPopup itemSetListPopup;
    [Token(Token = "0x400D613")]
    [FieldOffset(Offset = "0x38")]
    private bool isOpenItemSetList;
    [Token(Token = "0x400D614")]
    [FieldOffset(Offset = "0x3C")]
    private int openItemSetListTeamId;
    [Token(Token = "0x400D615")]
    [FieldOffset(Offset = "0x40")]
    private QuestPrepareSubScene questPrepareSubScene;
    [Token(Token = "0x400D616")]
    [FieldOffset(Offset = "0x48")]
    private QuestPrepareAssetLoader loader;
    [Token(Token = "0x400D617")]
    [FieldOffset(Offset = "0x50")]
    private int nowTeamId;
    [Token(Token = "0x400D618")]
    private const int ItemSetMax = 6;

    [Token(Token = "0x17004122")]
    public Action CallApiFinish
    {
      [Token(Token = "0x60138C3"), Address(RVA = "0x49C59F8", Offset = "0x49C59F8", VA = "0x49C59F8")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x60138C4"), Address(RVA = "0x49C5A00", Offset = "0x49C5A00", VA = "0x49C5A00")] set
      {
      }
    }

    [Token(Token = "0x17004123")]
    private OrganizationItemSet CurrentItemSet
    {
      [Token(Token = "0x60138C5"), Address(RVA = "0x49C5A08", Offset = "0x49C5A08", VA = "0x49C5A08")] get
      {
        return (OrganizationItemSet) null;
      }
    }

    [Token(Token = "0x60138C6")]
    [Address(RVA = "0x49C5A5C", Offset = "0x49C5A5C", VA = "0x49C5A5C")]
    public void SetItemSetNo(int itemSetNo)
    {
    }

    [Token(Token = "0x60138C7")]
    [Address(RVA = "0x49C5A64", Offset = "0x49C5A64", VA = "0x49C5A64")]
    public void SetTeamID(int teamId)
    {
    }

    [Token(Token = "0x60138C8")]
    [Address(RVA = "0x49C5A6C", Offset = "0x49C5A6C", VA = "0x49C5A6C")]
    public void Initialize(int itemSetNo)
    {
    }

    [Token(Token = "0x60138C9")]
    [Address(RVA = "0x49C5ADC", Offset = "0x49C5ADC", VA = "0x49C5ADC")]
    private void CreateItemSet(IReadOnlyList<BattleItemset> itemSetList)
    {
    }

    [Token(Token = "0x60138CA")]
    [Address(RVA = "0x49C5D94", Offset = "0x49C5D94", VA = "0x49C5D94")]
    public void UpdateItemSetImage()
    {
    }

    [Token(Token = "0x60138CB")]
    [Address(RVA = "0x49C6120", Offset = "0x49C6120", VA = "0x49C6120")]
    public void BattleItemSettings(
      QuestPrepareAssetLoader loader,
      QuestPrepareSubScene questPrepareSubScene)
    {
    }

    [Token(Token = "0x60138CC")]
    [Address(RVA = "0x49C5E48", Offset = "0x49C5E48", VA = "0x49C5E48")]
    private void OpenItemPopup()
    {
    }

    [Token(Token = "0x60138CD")]
    [Address(RVA = "0x49C6128", Offset = "0x49C6128", VA = "0x49C6128")]
    public void Delete()
    {
    }

    [Token(Token = "0x60138CE")]
    [Address(RVA = "0x49C6188", Offset = "0x49C6188", VA = "0x49C6188")]
    protected IEnumerator ConnectAPIDeckItemSetSetting(OrganizationTeam team) => (IEnumerator) null;

    [Token(Token = "0x60138CF")]
    [Address(RVA = "0x49C6224", Offset = "0x49C6224", VA = "0x49C6224")]
    public PartyItemManager()
    {
    }
  }
}
