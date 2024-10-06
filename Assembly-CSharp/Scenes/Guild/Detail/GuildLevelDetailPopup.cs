// Decompiled with JetBrains decompiler
// Type: Scenes.Guild.Detail.GuildLevelDetailPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Popup;
using Il2CppDummyDll;
using Scenes.Guild.Data;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Guild.Detail
{
  [Token(Token = "0x2002C06")]
  public class GuildLevelDetailPopup : PopupBase
  {
    [Token(Token = "0x400BB70")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Text guildName;
    [Token(Token = "0x400BB71")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private TextMeshProUGUI level;
    [Token(Token = "0x400BB72")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private TextMeshProUGUI exp;
    [Token(Token = "0x400BB73")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Slider expGauge;
    [Token(Token = "0x400BB74")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private GuildLevelDetailBenefitParts listParts;
    [Token(Token = "0x400BB75")]
    [FieldOffset(Offset = "0xB0")]
    private Action onClose;

    [Token(Token = "0x17003B40")]
    private GuildDetailInfo info
    {
      [Token(Token = "0x6011311"), Address(RVA = "0x4A14128", Offset = "0x4A14128", VA = "0x4A14128")] get
      {
        return (GuildDetailInfo) null;
      }
    }

    [Token(Token = "0x6011312")]
    [Address(RVA = "0x4A0BB9C", Offset = "0x4A0BB9C", VA = "0x4A0BB9C")]
    public void Init(Action onClose)
    {
    }

    [Token(Token = "0x6011313")]
    [Address(RVA = "0x4A142DC", Offset = "0x4A142DC", VA = "0x4A142DC", Slot = "8")]
    public override void Open()
    {
    }

    [Token(Token = "0x6011314")]
    [Address(RVA = "0x4A142E4", Offset = "0x4A142E4", VA = "0x4A142E4", Slot = "9")]
    public override void Close()
    {
    }

    [Token(Token = "0x6011315")]
    [Address(RVA = "0x4A14318", Offset = "0x4A14318", VA = "0x4A14318")]
    private GuildLevelDetailBenefitParts CreateItem() => (GuildLevelDetailBenefitParts) null;

    [Token(Token = "0x6011316")]
    [Address(RVA = "0x4A14180", Offset = "0x4A14180", VA = "0x4A14180")]
    private void SetupLevelDetailRewardList()
    {
    }

    [Token(Token = "0x6011317")]
    [Address(RVA = "0x4A14410", Offset = "0x4A14410", VA = "0x4A14410")]
    private GuildLevelDetailBenefitParts.UIParameter CreateUIParameter(
      GuildLevelRewardData prev,
      GuildLevelRewardData current,
      bool isUnlocked)
    {
      return (GuildLevelDetailBenefitParts.UIParameter) null;
    }

    [Token(Token = "0x6011318")]
    [Address(RVA = "0x4A144A4", Offset = "0x4A144A4", VA = "0x4A144A4")]
    private static List<string> CreateRewardTexts(
      GuildLevelRewardData prev,
      GuildLevelRewardData current)
    {
      return (List<string>) null;
    }

    [Token(Token = "0x6011319")]
    [Address(RVA = "0x4A14AFC", Offset = "0x4A14AFC", VA = "0x4A14AFC", Slot = "5")]
    public override void OnClickClose()
    {
    }

    [Token(Token = "0x601131A")]
    [Address(RVA = "0x4A14B20", Offset = "0x4A14B20", VA = "0x4A14B20")]
    public GuildLevelDetailPopup()
    {
    }
  }
}
