// Decompiled with JetBrains decompiler
// Type: Scenes.Guild.Detail.GuildPlayerDetailBelowScreen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using Network;
using Network.Param;
using Scenes.Guild.Data;
using Scenes.OutGame.OutGameMenu;
using Scenes.OutGame.PersonalEmblem;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Guild.Detail
{
  [Token(Token = "0x2002C09")]
  public class GuildPlayerDetailBelowScreen : GuildBelowScreenBase
  {
    [Token(Token = "0x400BB7A")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private CommonButton buttonGuildMasterTransfer;
    [Token(Token = "0x400BB7B")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private CommonButton buttonSubMasterNominate;
    [Token(Token = "0x400BB7C")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private CommonButton buttonSubMasterDismiss;
    [Token(Token = "0x400BB7D")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private CommonButton buttonMemberKick;
    [Token(Token = "0x400BB7E")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private CommonButton buttonAccept;
    [Token(Token = "0x400BB7F")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private CommonButton buttonReject;
    [Token(Token = "0x400BB80")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Text playerNameText;
    [Token(Token = "0x400BB81")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Text playerRankText;
    [Token(Token = "0x400BB82")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Text playerRankNextText;
    [Token(Token = "0x400BB83")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private RectTransform playerRankNextUnmask;
    [Token(Token = "0x400BB84")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Text playerIdText;
    [Token(Token = "0x400BB85")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Text lastLoginDayNumText;
    [Token(Token = "0x400BB86")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Text lastLoginDaySuffixText;
    [Token(Token = "0x400BB87")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Text totalPowerText;
    [Token(Token = "0x400BB88")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private Text commentText;
    [Token(Token = "0x400BB89")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private StyleThumb thumbnail;
    [Token(Token = "0x400BB8A")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private CharacterImage imagePlayer;
    [Token(Token = "0x400BB8B")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private PersonalEmblemThumb personalEmblemThumb;
    [Token(Token = "0x400BB8C")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private GameObject playerIdObj;
    [Token(Token = "0x400BB8D")]
    [FieldOffset(Offset = "0xD0")]
    private GuildSubScene guildSubScene;
    [Token(Token = "0x400BB8E")]
    [FieldOffset(Offset = "0xD8")]
    private GuildMemberInfo info;
    [Token(Token = "0x400BB8F")]
    [FieldOffset(Offset = "0xE0")]
    private PlayerOpenProfileType detailInfo;

    [Token(Token = "0x17003B42")]
    private PopupManager popupManager
    {
      [Token(Token = "0x6011320"), Address(RVA = "0x4A14BB4", Offset = "0x4A14BB4", VA = "0x4A14BB4")] get
      {
        return (PopupManager) null;
      }
    }

    [Token(Token = "0x17003B43")]
    private GuildDataManager guildDataManager
    {
      [Token(Token = "0x6011321"), Address(RVA = "0x4A14C20", Offset = "0x4A14C20", VA = "0x4A14C20")] get
      {
        return (GuildDataManager) null;
      }
    }

    [Token(Token = "0x6011322")]
    [Address(RVA = "0x4A14C70", Offset = "0x4A14C70", VA = "0x4A14C70", Slot = "4")]
    public override void Initialize(
      GuildSubScene guildSubScene,
      GuildAssetBundleParam.GuildScreenType? type,
      GuildBelowScreenParam param)
    {
    }

    [Token(Token = "0x6011323")]
    [Address(RVA = "0x4A14D24", Offset = "0x4A14D24", VA = "0x4A14D24", Slot = "5")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6011324")]
    [Address(RVA = "0x4A14DB4", Offset = "0x4A14DB4", VA = "0x4A14DB4", Slot = "7")]
    public override void Open()
    {
    }

    [Token(Token = "0x6011325")]
    [Address(RVA = "0x4A14DDC", Offset = "0x4A14DDC", VA = "0x4A14DDC", Slot = "8")]
    public override void Close()
    {
    }

    [Token(Token = "0x6011326")]
    [Address(RVA = "0x4A14E70", Offset = "0x4A14E70", VA = "0x4A14E70")]
    private void UpdateView()
    {
    }

    [Token(Token = "0x6011327")]
    [Address(RVA = "0x4A15028", Offset = "0x4A15028", VA = "0x4A15028")]
    private void UpdateView(
      string playerName,
      int emblemId,
      int rank,
      int nextExp,
      float nextExpRate,
      long id,
      DateTime signedInAt,
      long totalPower,
      string comment,
      int symbolUnitId)
    {
    }

    [Token(Token = "0x6011328")]
    [Address(RVA = "0x4A15564", Offset = "0x4A15564", VA = "0x4A15564")]
    private void SetButtonActivate()
    {
    }

    [Token(Token = "0x6011329")]
    [Address(RVA = "0x4A15920", Offset = "0x4A15920", VA = "0x4A15920")]
    private void SetActiveAndInteractable(CommonButton button, bool isDefaultColor, bool isActive = true)
    {
    }

    [Token(Token = "0x601132A")]
    [Address(RVA = "0x4A15984", Offset = "0x4A15984", VA = "0x4A15984")]
    public void OnClickGuildMaster()
    {
    }

    [Token(Token = "0x601132B")]
    [Address(RVA = "0x4A15E28", Offset = "0x4A15E28", VA = "0x4A15E28")]
    public void OnClickNominateSubGuildMaster()
    {
    }

    [Token(Token = "0x601132C")]
    [Address(RVA = "0x4A15F2C", Offset = "0x4A15F2C", VA = "0x4A15F2C")]
    public void OnClickDismissSubGuildMaster()
    {
    }

    [Token(Token = "0x601132D")]
    [Address(RVA = "0x4A16030", Offset = "0x4A16030", VA = "0x4A16030")]
    public void OnClickMemberKick()
    {
    }

    [Token(Token = "0x601132E")]
    [Address(RVA = "0x4A16134", Offset = "0x4A16134", VA = "0x4A16134")]
    public void OnClickRequestApprove()
    {
    }

    [Token(Token = "0x601132F")]
    [Address(RVA = "0x4A165A0", Offset = "0x4A165A0", VA = "0x4A165A0")]
    public void OnClickRequestReject()
    {
    }

    [Token(Token = "0x6011330")]
    [Address(RVA = "0x4A15AF8", Offset = "0x4A15AF8", VA = "0x4A15AF8")]
    private void OpenRequestPopup(string title, string message, Action onConfirm)
    {
    }

    [Token(Token = "0x6011331")]
    [Address(RVA = "0x4A16A14", Offset = "0x4A16A14", VA = "0x4A16A14")]
    private void OnRequestComplete(GuildSyncDataSet syncData)
    {
    }

    [Token(Token = "0x6011332")]
    [Address(RVA = "0x4A16ADC", Offset = "0x4A16ADC", VA = "0x4A16ADC")]
    private IEnumerator OnRequestFailed(NetworkErrorResult result) => (IEnumerator) null;

    [Token(Token = "0x6011333")]
    [Address(RVA = "0x4A16B6C", Offset = "0x4A16B6C", VA = "0x4A16B6C")]
    private IEnumerator RequestPlayerDetail(string playerId) => (IEnumerator) null;

    [Token(Token = "0x6011334")]
    [Address(RVA = "0x4A16C08", Offset = "0x4A16C08", VA = "0x4A16C08")]
    private IEnumerator RequestTransferMaster() => (IEnumerator) null;

    [Token(Token = "0x6011335")]
    [Address(RVA = "0x4A16C98", Offset = "0x4A16C98", VA = "0x4A16C98")]
    private IEnumerator RequestAppointSubmaster() => (IEnumerator) null;

    [Token(Token = "0x6011336")]
    [Address(RVA = "0x4A16D28", Offset = "0x4A16D28", VA = "0x4A16D28")]
    private IEnumerator RequestAppointGeneral() => (IEnumerator) null;

    [Token(Token = "0x6011337")]
    [Address(RVA = "0x4A16DB8", Offset = "0x4A16DB8", VA = "0x4A16DB8")]
    private IEnumerator RequestKick() => (IEnumerator) null;

    [Token(Token = "0x6011338")]
    [Address(RVA = "0x4A16E48", Offset = "0x4A16E48", VA = "0x4A16E48")]
    private IEnumerator RequestJoinRequestApprove() => (IEnumerator) null;

    [Token(Token = "0x6011339")]
    [Address(RVA = "0x4A16ED8", Offset = "0x4A16ED8", VA = "0x4A16ED8")]
    private IEnumerator RequestJoinRequestReject() => (IEnumerator) null;

    [Token(Token = "0x601133A")]
    [Address(RVA = "0x4A15A88", Offset = "0x4A15A88", VA = "0x4A15A88")]
    private string GetText(string key) => (string) null;

    [Token(Token = "0x601133B")]
    [Address(RVA = "0x4A16F68", Offset = "0x4A16F68", VA = "0x4A16F68")]
    public GuildPlayerDetailBelowScreen()
    {
    }
  }
}
