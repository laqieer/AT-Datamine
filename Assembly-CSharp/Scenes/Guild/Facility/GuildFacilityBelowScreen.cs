// Decompiled with JetBrains decompiler
// Type: Scenes.Guild.Facility.GuildFacilityBelowScreen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.Guild.Data;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.Guild.Facility
{
  [Token(Token = "0x2002BE8")]
  public class GuildFacilityBelowScreen : GuildBelowScreenBase
  {
    [Token(Token = "0x400BAD2")]
    public const string SceneAssetBundleName = "ui_page_guild_prefab";
    [Token(Token = "0x400BAD3")]
    public const string ScenePrefabName = "Containts_GuildFacility";
    [Token(Token = "0x400BAD4")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GuildFacilityStoneStatueStatus prosperityStatueStatus;
    [Token(Token = "0x400BAD5")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GuildFacilityStoneStatueStatus valorStatueStatus;
    [Token(Token = "0x400BAD6")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GuildFacilityStoneStatueStatus enduranceStatueStatus;
    [Token(Token = "0x400BAD7")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GuildFacilityStoneStatueStatus celerityStatueStatus;
    [Token(Token = "0x400BAD8")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GuildFacilityStoneStatue prosperityStatue;
    [Token(Token = "0x400BAD9")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GuildFacilityStoneStatue valorStatue;
    [Token(Token = "0x400BADA")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private GuildFacilityStoneStatue enduranceStatue;
    [Token(Token = "0x400BADB")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private GuildFacilityStoneStatue celerityStatue;
    [Token(Token = "0x400BADC")]
    [FieldOffset(Offset = "0x78")]
    private Dictionary<Statue.ID, Statue> dicIdStatueStatus;

    [Token(Token = "0x6011260")]
    [Address(RVA = "0x4A0D064", Offset = "0x4A0D064", VA = "0x4A0D064", Slot = "5")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6011261")]
    [Address(RVA = "0x4A0D0F4", Offset = "0x4A0D0F4", VA = "0x4A0D0F4", Slot = "7")]
    public override void Open()
    {
    }

    [Token(Token = "0x6011262")]
    [Address(RVA = "0x4A0D520", Offset = "0x4A0D520", VA = "0x4A0D520", Slot = "8")]
    public override void Close()
    {
    }

    [Token(Token = "0x6011263")]
    [Address(RVA = "0x4A0D548", Offset = "0x4A0D548", VA = "0x4A0D548")]
    private IEnumerator RequestGuildFacility() => (IEnumerator) null;

    [Token(Token = "0x6011264")]
    [Address(RVA = "0x4A0D124", Offset = "0x4A0D124", VA = "0x4A0D124")]
    public void SetupFacilityList()
    {
    }

    [Token(Token = "0x6011265")]
    [Address(RVA = "0x4A0D5D8", Offset = "0x4A0D5D8", VA = "0x4A0D5D8")]
    public void OnFacilityDetail(GuildFacilityDetailInfo info)
    {
    }

    [Token(Token = "0x6011266")]
    [Address(RVA = "0x4A0D718", Offset = "0x4A0D718", VA = "0x4A0D718")]
    private void FacilityDetailOpen(
      GuildFacilityDetailPopup guildFacilityDetail,
      GuildFacilityDetailInfo info)
    {
    }

    [Token(Token = "0x6011267")]
    [Address(RVA = "0x4A0DDC4", Offset = "0x4A0DDC4", VA = "0x4A0DDC4")]
    public GuildFacilityBelowScreen()
    {
    }
  }
}
