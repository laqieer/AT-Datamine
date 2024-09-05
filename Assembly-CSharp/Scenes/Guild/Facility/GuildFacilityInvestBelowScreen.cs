// Decompiled with JetBrains decompiler
// Type: Scenes.Guild.Facility.GuildFacilityInvestBelowScreen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Scenes.Guild.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Guild.Facility
{
  [Token(Token = "0x2002BF0")]
  public class GuildFacilityInvestBelowScreen : GuildBelowScreenBase
  {
    [Token(Token = "0x400BAF5")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GuildFacilityStoneStatue prosperityStatue;
    [Token(Token = "0x400BAF6")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GuildFacilityStoneStatue valorStatue;
    [Token(Token = "0x400BAF7")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GuildFacilityStoneStatue enduranceStatue;
    [Token(Token = "0x400BAF8")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GuildFacilityStoneStatue celerityStatue;
    [Token(Token = "0x400BAF9")]
    [FieldOffset(Offset = "0x58")]
    private Dictionary<Statue.ID, GuildFacilityStoneStatue> dicIdStatue;
    [Token(Token = "0x400BAFA")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private ScrollRect scrollRect;
    [Token(Token = "0x400BAFB")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private GuildFacilityInvestListItem templateListItem;
    [Token(Token = "0x400BAFC")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Text textFacilityName;
    [Token(Token = "0x400BAFD")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Text textFacilityLevel;
    [Token(Token = "0x400BAFE")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private Text textFacilityMaxLevel;
    [Token(Token = "0x400BAFF")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Slider gaugeFacilityExp;
    [Token(Token = "0x400BB00")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Text textNeedNextLevelExp;
    [Token(Token = "0x400BB01")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Text textResetTime;
    [Token(Token = "0x400BB02")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Dropdown dropdownInvestRate;
    [Token(Token = "0x400BB03")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private GuildFacilityRewardText guildFacilityCurrentLevelReward;
    [Token(Token = "0x400BB04")]
    [FieldOffset(Offset = "0xB0")]
    private List<GuildFacilityRewardText> currentLevelRewardList;
    [Token(Token = "0x400BB05")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private GuildFacilityRewardText guildFacilityNextLevelReward;
    [Token(Token = "0x400BB06")]
    [FieldOffset(Offset = "0xC0")]
    private List<GuildFacilityRewardText> nextLevelRewardList;
    [Token(Token = "0x400BB07")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private Text inVestCount;
    [Token(Token = "0x400BB08")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private Text inVestMaxCount;
    [Token(Token = "0x400BB09")]
    [FieldOffset(Offset = "0xD8")]
    private List<GuildFacilityInvestListItem> listItems;
    [Token(Token = "0x400BB0A")]
    [FieldOffset(Offset = "0xE0")]
    private GuildFacilityDetailInfo info;
    [Token(Token = "0x400BB0B")]
    [FieldOffset(Offset = "0xE8")]
    private DateTime investCountResetTime;
    [Token(Token = "0x400BB0C")]
    [FieldOffset(Offset = "0xF0")]
    private GameObject investPopup;
    [Token(Token = "0x400BB0D")]
    [FieldOffset(Offset = "0xF8")]
    private GameObject toasterPopup;
    [Token(Token = "0x400BB0E")]
    [FieldOffset(Offset = "0x100")]
    private GameObject guildFacilityLevelupEffect;
    [Token(Token = "0x400BB0F")]
    [FieldOffset(Offset = "0x108")]
    private HashSet<string> loadedAssetBundleName;
    [Token(Token = "0x400BB10")]
    [FieldOffset(Offset = "0x110")]
    private GameObject levelupContent;

    [Token(Token = "0x6011285")]
    [Address(RVA = "0x4A0EB40", Offset = "0x4A0EB40", VA = "0x4A0EB40")]
    public static GuildBelowScreenParam CreateChangeSceneParameter(int facilityID)
    {
      return (GuildBelowScreenParam) null;
    }

    [Token(Token = "0x6011286")]
    [Address(RVA = "0x4A0EBAC", Offset = "0x4A0EBAC", VA = "0x4A0EBAC", Slot = "4")]
    public override void Initialize(
      GuildSubScene guildSubScene,
      GuildAssetBundleParam.GuildScreenType? type,
      GuildBelowScreenParam param)
    {
    }

    [Token(Token = "0x6011287")]
    [Address(RVA = "0x4A0EE8C", Offset = "0x4A0EE8C", VA = "0x4A0EE8C", Slot = "5")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6011288")]
    [Address(RVA = "0x4A0EF1C", Offset = "0x4A0EF1C", VA = "0x4A0EF1C", Slot = "7")]
    public override void Open()
    {
    }

    [Token(Token = "0x6011289")]
    [Address(RVA = "0x4A0EF44", Offset = "0x4A0EF44", VA = "0x4A0EF44", Slot = "8")]
    public override void Close()
    {
    }

    [Token(Token = "0x601128A")]
    [Address(RVA = "0x4A0F100", Offset = "0x4A0F100", VA = "0x4A0F100", Slot = "6")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x601128B")]
    [Address(RVA = "0x4A0F108", Offset = "0x4A0F108", VA = "0x4A0F108")]
    public void Update()
    {
    }

    [Token(Token = "0x601128C")]
    [Address(RVA = "0x4A0F2F8", Offset = "0x4A0F2F8", VA = "0x4A0F2F8")]
    public void OnClickBack()
    {
    }

    [Token(Token = "0x601128D")]
    [Address(RVA = "0x4A0F304", Offset = "0x4A0F304", VA = "0x4A0F304")]
    private void SetupGuildFacility()
    {
    }

    [Token(Token = "0x601128E")]
    [Address(RVA = "0x4A0F10C", Offset = "0x4A0F10C", VA = "0x4A0F10C")]
    private void UpdateInvestCountResetTime()
    {
    }

    [Token(Token = "0x601128F")]
    [Address(RVA = "0x4A0F8C4", Offset = "0x4A0F8C4", VA = "0x4A0F8C4")]
    private void RefreshUI()
    {
    }

    [Token(Token = "0x6011290")]
    [Address(RVA = "0x4A10FA0", Offset = "0x4A10FA0", VA = "0x4A10FA0")]
    public List<string> RewardListToText(
      List<GuildFacilityRewardDescriptionData> facilityRewards)
    {
      return (List<string>) null;
    }

    [Token(Token = "0x6011291")]
    [Address(RVA = "0x4A10298", Offset = "0x4A10298", VA = "0x4A10298")]
    private void RefreshCurrentReward()
    {
    }

    [Token(Token = "0x6011292")]
    [Address(RVA = "0x4A10760", Offset = "0x4A10760", VA = "0x4A10760")]
    private void RefreshNextLevelReward()
    {
    }

    [Token(Token = "0x6011293")]
    [Address(RVA = "0x4A0F334", Offset = "0x4A0F334", VA = "0x4A0F334")]
    private void SetupFacilityList()
    {
    }

    [Token(Token = "0x6011294")]
    [Address(RVA = "0x4A11690", Offset = "0x4A11690", VA = "0x4A11690")]
    private IEnumerator SetupFacilityList(
      List<GuildFacilityInvestListItem.UIParameter> uiParameters,
      bool isMaxInvest,
      bool isMaxLevel,
      bool canInvest)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6011295")]
    [Address(RVA = "0x4A11450", Offset = "0x4A11450", VA = "0x4A11450")]
    private GuildFacilityInvestListItem.UIParameter CreateUIParameter(
      GuildFacilityResourceTableDescriptionData guildFacilityResourceTable)
    {
      return (GuildFacilityInvestListItem.UIParameter) null;
    }

    [Token(Token = "0x6011296")]
    [Address(RVA = "0x4A11388", Offset = "0x4A11388", VA = "0x4A11388")]
    private GuildFacilityInvestListItem CreateItem() => (GuildFacilityInvestListItem) null;

    [Token(Token = "0x6011297")]
    [Address(RVA = "0x4A11760", Offset = "0x4A11760", VA = "0x4A11760")]
    public void OnInvest(
      GuildFacilityInvestListItem.UIParameter uIParameter)
    {
    }

    [Token(Token = "0x6011298")]
    [Address(RVA = "0x4A11B98", Offset = "0x4A11B98", VA = "0x4A11B98")]
    private void OnDecideInvest(
      GuildFacilityInvestListItem.UIParameter uIParameter)
    {
    }

    [Token(Token = "0x6011299")]
    [Address(RVA = "0x4A11BB8", Offset = "0x4A11BB8", VA = "0x4A11BB8")]
    private IEnumerator RequestGuildInvest(
      GuildFacilityInvestListItem.UIParameter uIParameter)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601129A")]
    [Address(RVA = "0x4A11C54", Offset = "0x4A11C54", VA = "0x4A11C54")]
    private IEnumerator RequestGuildInvestSend(
      GuildFacilityInvestListItem.UIParameter uIParameter)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601129B")]
    [Address(RVA = "0x4A11CF0", Offset = "0x4A11CF0", VA = "0x4A11CF0")]
    private IEnumerator LoadLevelupContent() => (IEnumerator) null;

    [Token(Token = "0x601129C")]
    [Address(RVA = "0x4A10DDC", Offset = "0x4A10DDC", VA = "0x4A10DDC")]
    private void LevelUpEffect(int fromLevel, int toLevel)
    {
    }

    [Token(Token = "0x601129D")]
    [Address(RVA = "0x4A11E4C", Offset = "0x4A11E4C", VA = "0x4A11E4C")]
    public GuildFacilityInvestBelowScreen()
    {
    }

    [Token(Token = "0x2002BF1")]
    public class GuildFacilityInvestParameter : GuildBelowScreenParam
    {
      [Token(Token = "0x17003B21")]
      public int facilityID
      {
        [Token(Token = "0x60112A2"), Address(RVA = "0x4A12120", Offset = "0x4A12120", VA = "0x4A12120")] get
        {
          return new int();
        }
        [Token(Token = "0x60112A3"), Address(RVA = "0x4A12128", Offset = "0x4A12128", VA = "0x4A12128")] set
        {
        }
      }

      [Token(Token = "0x60112A4")]
      [Address(RVA = "0x4A0EBA4", Offset = "0x4A0EBA4", VA = "0x4A0EBA4")]
      public GuildFacilityInvestParameter()
      {
      }
    }
  }
}
