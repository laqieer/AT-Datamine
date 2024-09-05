// Decompiled with JetBrains decompiler
// Type: Scenes.Guild.Facility.GuildFacilityDetailPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Popup;
using Il2CppDummyDll;
using Scenes.Guild.Data;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Guild.Facility
{
  [Token(Token = "0x2002BED")]
  public class GuildFacilityDetailPopup : PopupBase
  {
    [Token(Token = "0x400BAE7")]
    [FieldOffset(Offset = "0x88")]
    private GuildFacilityBelowScreen scene;
    [Token(Token = "0x400BAE8")]
    [FieldOffset(Offset = "0x90")]
    private GuildFacilityDetailInfo info;
    [Token(Token = "0x400BAE9")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Text statueName;
    [Token(Token = "0x400BAEA")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private GuildFacilityStoneStatue pStatue;
    [Token(Token = "0x400BAEB")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private GuildFacilityStoneStatue vStatue;
    [Token(Token = "0x400BAEC")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private GuildFacilityStoneStatue eStatue;
    [Token(Token = "0x400BAED")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private GuildFacilityStoneStatue cStatue;
    [Token(Token = "0x400BAEE")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private TextMeshProUGUI level;
    [Token(Token = "0x400BAEF")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private TextMeshProUGUI exp;
    [Token(Token = "0x400BAF0")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private Slider expGauge;
    [Token(Token = "0x400BAF1")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private GuildFacilityBenefitParts listParts;
    [Token(Token = "0x400BAF2")]
    [FieldOffset(Offset = "0xE0")]
    private List<GuildFacilityBenefitParts> list;
    [Token(Token = "0x400BAF3")]
    [FieldOffset(Offset = "0xE8")]
    private Dictionary<Statue.ID, GuildFacilityStoneStatue> dicIdStatue;

    [Token(Token = "0x6011279")]
    [Address(RVA = "0x4A0D894", Offset = "0x4A0D894", VA = "0x4A0D894")]
    public void Init(GuildFacilityBelowScreen scene, GuildFacilityDetailInfo info)
    {
    }

    [Token(Token = "0x601127A")]
    [Address(RVA = "0x4A0E5C8", Offset = "0x4A0E5C8", VA = "0x4A0E5C8", Slot = "8")]
    public override void Open()
    {
    }

    [Token(Token = "0x601127B")]
    [Address(RVA = "0x4A0E5D0", Offset = "0x4A0E5D0", VA = "0x4A0E5D0", Slot = "9")]
    public override void Close()
    {
    }

    [Token(Token = "0x601127C")]
    [Address(RVA = "0x4A0E5FC", Offset = "0x4A0E5FC", VA = "0x4A0E5FC")]
    private GuildFacilityBenefitParts CreateItem() => (GuildFacilityBenefitParts) null;

    [Token(Token = "0x601127D")]
    [Address(RVA = "0x4A0E240", Offset = "0x4A0E240", VA = "0x4A0E240")]
    private void SetupFacilityRewardList()
    {
    }

    [Token(Token = "0x601127E")]
    [Address(RVA = "0x4A0E6F4", Offset = "0x4A0E6F4", VA = "0x4A0E6F4")]
    private GuildFacilityRewardListItem.UIParameter CreateUIParameter(
      GuildFacilityLevelRewardData guildFacilityLevelRewardData,
      bool isUnlocked)
    {
      return (GuildFacilityRewardListItem.UIParameter) null;
    }

    [Token(Token = "0x601127F")]
    [Address(RVA = "0x4A0E7DC", Offset = "0x4A0E7DC", VA = "0x4A0E7DC")]
    public void onFacilityInvest()
    {
    }

    [Token(Token = "0x6011280")]
    [Address(RVA = "0x4A0E814", Offset = "0x4A0E814", VA = "0x4A0E814")]
    public GuildFacilityDetailPopup()
    {
    }
  }
}
