// Decompiled with JetBrains decompiler
// Type: PlayerDetailPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Popup;
using Il2CppDummyDll;
using Network.API;
using Scenes.OutGame.PlayerInfo;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x20002A2")]
public class PlayerDetailPopup : PopupBase
{
  [Token(Token = "0x4000F8C")]
  public const string FriendDetailAssetBundleName = "2dassets_ui_friend";
  [Token(Token = "0x4000F8D")]
  public const string FriendDetailAssetName = "Container_Popup_FriendDetail";
  [Token(Token = "0x4000F8E")]
  public const string AnimationKeyIn = "In";
  [Token(Token = "0x4000F8F")]
  public const string AnimationKeyOut = "Out";
  [Token(Token = "0x4000F90")]
  [FieldOffset(Offset = "0x88")]
  [SerializeField]
  private CharacterImage imagePlayer;
  [Token(Token = "0x4000F91")]
  [FieldOffset(Offset = "0x90")]
  [SerializeField]
  private PlayerTitlePanel playerTitle;
  [Token(Token = "0x4000F92")]
  [FieldOffset(Offset = "0x98")]
  [SerializeField]
  private Text textPlayerName;
  [Token(Token = "0x4000F93")]
  [FieldOffset(Offset = "0xA0")]
  [SerializeField]
  private Text textPlayerRank;
  [Token(Token = "0x4000F94")]
  [FieldOffset(Offset = "0xA8")]
  [SerializeField]
  private Text textPlayerId;
  [Token(Token = "0x4000F95")]
  [FieldOffset(Offset = "0xB0")]
  [SerializeField]
  private Text textComment;
  [Token(Token = "0x4000F96")]
  [FieldOffset(Offset = "0xB8")]
  [SerializeField]
  private Text textLastSignedInAt;
  [Token(Token = "0x4000F97")]
  [FieldOffset(Offset = "0xC0")]
  [SerializeField]
  private GameObject objRemove;
  [Token(Token = "0x4000F98")]
  [FieldOffset(Offset = "0xC8")]
  [SerializeField]
  private GameObject objRequest;
  [Token(Token = "0x4000F99")]
  [FieldOffset(Offset = "0xD0")]
  [SerializeField]
  private GameObject objApply;
  [Token(Token = "0x4000F9A")]
  [FieldOffset(Offset = "0xD8")]
  [SerializeField]
  private GameObject objCancel;
  [Token(Token = "0x4000F9B")]
  [FieldOffset(Offset = "0xE0")]
  [SerializeField]
  private GameObject objBlockRemove;
  [Token(Token = "0x4000F9C")]
  [FieldOffset(Offset = "0xE8")]
  [SerializeField]
  private GameObject objBlock;
  [Token(Token = "0x4000F9D")]
  [FieldOffset(Offset = "0xF0")]
  private PlayerDetailPopup.UIParameter uiParameter;
  [Token(Token = "0x4000F9E")]
  [FieldOffset(Offset = "0xF8")]
  private List<string> loadedAssetBundleNames;
  [Token(Token = "0x4000F9F")]
  [FieldOffset(Offset = "0x100")]
  private bool isOwnPlayerDetail;

  [Token(Token = "0x17000184")]
  public Action OnClose
  {
    [Token(Token = "0x6001055"), Address(RVA = "0x1BE6EF0", Offset = "0x1BE6EF0", VA = "0x1BE6EF0")] get
    {
      return (Action) null;
    }
    [Token(Token = "0x6001056"), Address(RVA = "0x1BE6EF8", Offset = "0x1BE6EF8", VA = "0x1BE6EF8")] set
    {
    }
  }

  [Token(Token = "0x17000185")]
  public Action<APIPlayerDetailResponse> OnSuccessPlayerDetail
  {
    [Token(Token = "0x6001057"), Address(RVA = "0x1BE6F00", Offset = "0x1BE6F00", VA = "0x1BE6F00")] get
    {
      return (Action<APIPlayerDetailResponse>) null;
    }
    [Token(Token = "0x6001058"), Address(RVA = "0x1BE6F08", Offset = "0x1BE6F08", VA = "0x1BE6F08")] set
    {
    }
  }

  [Token(Token = "0x17000186")]
  public Action<APIFriendApplyResponse> OnSuccessFriendApply
  {
    [Token(Token = "0x6001059"), Address(RVA = "0x1BE6F10", Offset = "0x1BE6F10", VA = "0x1BE6F10")] get
    {
      return (Action<APIFriendApplyResponse>) null;
    }
    [Token(Token = "0x600105A"), Address(RVA = "0x1BE6F18", Offset = "0x1BE6F18", VA = "0x1BE6F18")] set
    {
    }
  }

  [Token(Token = "0x17000187")]
  public Action<APIFriendCancelResponse> OnSuccessFriendCancel
  {
    [Token(Token = "0x600105B"), Address(RVA = "0x1BE6F20", Offset = "0x1BE6F20", VA = "0x1BE6F20")] get
    {
      return (Action<APIFriendCancelResponse>) null;
    }
    [Token(Token = "0x600105C"), Address(RVA = "0x1BE6F28", Offset = "0x1BE6F28", VA = "0x1BE6F28")] set
    {
    }
  }

  [Token(Token = "0x17000188")]
  public Action<APIFriendRemoveResponse> OnSuccessFriendRemove
  {
    [Token(Token = "0x600105D"), Address(RVA = "0x1BE6F30", Offset = "0x1BE6F30", VA = "0x1BE6F30")] get
    {
      return (Action<APIFriendRemoveResponse>) null;
    }
    [Token(Token = "0x600105E"), Address(RVA = "0x1BE6F38", Offset = "0x1BE6F38", VA = "0x1BE6F38")] set
    {
    }
  }

  [Token(Token = "0x17000189")]
  public Action<APIFriendAcceptResponse> OnSuccessFriendAccept
  {
    [Token(Token = "0x600105F"), Address(RVA = "0x1BE6F40", Offset = "0x1BE6F40", VA = "0x1BE6F40")] get
    {
      return (Action<APIFriendAcceptResponse>) null;
    }
    [Token(Token = "0x6001060"), Address(RVA = "0x1BE6F48", Offset = "0x1BE6F48", VA = "0x1BE6F48")] set
    {
    }
  }

  [Token(Token = "0x1700018A")]
  public Action<APIFriendRejectResponse> OnSuccessFriendReject
  {
    [Token(Token = "0x6001061"), Address(RVA = "0x1BE6F50", Offset = "0x1BE6F50", VA = "0x1BE6F50")] get
    {
      return (Action<APIFriendRejectResponse>) null;
    }
    [Token(Token = "0x6001062"), Address(RVA = "0x1BE6F58", Offset = "0x1BE6F58", VA = "0x1BE6F58")] set
    {
    }
  }

  [Token(Token = "0x1700018B")]
  public Action<APIBlockAddResponse> OnSuccessBlockAdd
  {
    [Token(Token = "0x6001063"), Address(RVA = "0x1BE6F60", Offset = "0x1BE6F60", VA = "0x1BE6F60")] get
    {
      return (Action<APIBlockAddResponse>) null;
    }
    [Token(Token = "0x6001064"), Address(RVA = "0x1BE6F68", Offset = "0x1BE6F68", VA = "0x1BE6F68")] set
    {
    }
  }

  [Token(Token = "0x1700018C")]
  public Action<APIBlockRemoveResponse> OnSuccessBlockRemove
  {
    [Token(Token = "0x6001065"), Address(RVA = "0x1BE6F70", Offset = "0x1BE6F70", VA = "0x1BE6F70")] get
    {
      return (Action<APIBlockRemoveResponse>) null;
    }
    [Token(Token = "0x6001066"), Address(RVA = "0x1BE6F78", Offset = "0x1BE6F78", VA = "0x1BE6F78")] set
    {
    }
  }

  [Token(Token = "0x6001067")]
  [Address(RVA = "0x1BE6F80", Offset = "0x1BE6F80", VA = "0x1BE6F80")]
  public static IEnumerator Open(
    string playerId,
    Action onClose = null,
    Action<PlayerDetailPopup> onCreate = null)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x6001068")]
  [Address(RVA = "0x1BE7024", Offset = "0x1BE7024", VA = "0x1BE7024")]
  public static IEnumerator Open(
    PlayerDetailPopup.UIParameter uiParameter,
    Action onClose = null,
    Action<PlayerDetailPopup> onCreate = null)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x6001069")]
  [Address(RVA = "0x1BE70C8", Offset = "0x1BE70C8", VA = "0x1BE70C8", Slot = "9")]
  public override void Close()
  {
  }

  [Token(Token = "0x600106A")]
  [Address(RVA = "0x1BE7178", Offset = "0x1BE7178", VA = "0x1BE7178")]
  private void PlayCloseAnimation()
  {
  }

  [Token(Token = "0x600106B")]
  [Address(RVA = "0x1BE71C8", Offset = "0x1BE71C8", VA = "0x1BE71C8")]
  private void PlayOpenAnimation()
  {
  }

  [Token(Token = "0x600106C")]
  [Address(RVA = "0x1BE7218", Offset = "0x1BE7218", VA = "0x1BE7218")]
  private IEnumerator InitializeAsync(string playerId) => (IEnumerator) null;

  [Token(Token = "0x600106D")]
  [Address(RVA = "0x1BE72B4", Offset = "0x1BE72B4", VA = "0x1BE72B4")]
  private IEnumerator InitializeAsync(PlayerDetailPopup.UIParameter uiParameter)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x600106E")]
  [Address(RVA = "0x1BE7350", Offset = "0x1BE7350", VA = "0x1BE7350")]
  private void Setup(PlayerDetailPopup.UIParameter uiParameter)
  {
  }

  [Token(Token = "0x600106F")]
  [Address(RVA = "0x1BE790C", Offset = "0x1BE790C", VA = "0x1BE790C", Slot = "4")]
  public override void Destroy()
  {
  }

  [Token(Token = "0x6001070")]
  [Address(RVA = "0x1BE7AC4", Offset = "0x1BE7AC4", VA = "0x1BE7AC4")]
  private IEnumerator LoadDependencyAssets() => (IEnumerator) null;

  [Token(Token = "0x6001071")]
  [Address(RVA = "0x1BE7928", Offset = "0x1BE7928", VA = "0x1BE7928")]
  private void UnloadDependencyAssets()
  {
  }

  [Token(Token = "0x6001072")]
  [Address(RVA = "0x1BE7B54", Offset = "0x1BE7B54", VA = "0x1BE7B54")]
  private IEnumerator RequestPlayerDetail(string playerId) => (IEnumerator) null;

  [Token(Token = "0x6001073")]
  [Address(RVA = "0x1BE7BF0", Offset = "0x1BE7BF0", VA = "0x1BE7BF0", Slot = "5")]
  public override void OnClickClose()
  {
  }

  [Token(Token = "0x6001074")]
  [Address(RVA = "0x1BE7C28", Offset = "0x1BE7C28", VA = "0x1BE7C28")]
  public void OnClickUnitInfo()
  {
  }

  [Token(Token = "0x6001075")]
  [Address(RVA = "0x1BE7C2C", Offset = "0x1BE7C2C", VA = "0x1BE7C2C")]
  public void OnClickGuildInfo()
  {
  }

  [Token(Token = "0x6001076")]
  [Address(RVA = "0x1BE7C30", Offset = "0x1BE7C30", VA = "0x1BE7C30")]
  public void OnClickFriendApply()
  {
  }

  [Token(Token = "0x6001077")]
  [Address(RVA = "0x1BE7EA4", Offset = "0x1BE7EA4", VA = "0x1BE7EA4")]
  public void OnClickFriendRemove()
  {
  }

  [Token(Token = "0x6001078")]
  [Address(RVA = "0x1BE8118", Offset = "0x1BE8118", VA = "0x1BE8118")]
  public void OnClickFriendAccept()
  {
  }

  [Token(Token = "0x6001079")]
  [Address(RVA = "0x1BE838C", Offset = "0x1BE838C", VA = "0x1BE838C")]
  public void OnClickFriendReject()
  {
  }

  [Token(Token = "0x600107A")]
  [Address(RVA = "0x1BE8600", Offset = "0x1BE8600", VA = "0x1BE8600")]
  public void OnClickFriendCancel()
  {
  }

  [Token(Token = "0x600107B")]
  [Address(RVA = "0x1BE8874", Offset = "0x1BE8874", VA = "0x1BE8874")]
  public void OnClickFriendBlockAdd()
  {
  }

  [Token(Token = "0x600107C")]
  [Address(RVA = "0x1BE8AE8", Offset = "0x1BE8AE8", VA = "0x1BE8AE8")]
  public void OnClickFriendBlockRemove()
  {
  }

  [Token(Token = "0x600107D")]
  [Address(RVA = "0x1BE77AC", Offset = "0x1BE77AC", VA = "0x1BE77AC")]
  private void UpdateButtonActive()
  {
  }

  [Token(Token = "0x600107E")]
  [Address(RVA = "0x1BE8D5C", Offset = "0x1BE8D5C", VA = "0x1BE8D5C")]
  public PlayerDetailPopup()
  {
  }

  [Token(Token = "0x20002A3")]
  public class UIParameter
  {
    [Token(Token = "0x1700018D")]
    public IPlayerBasicProfileInfo PlayerBasicProfile
    {
      [Token(Token = "0x6001086"), Address(RVA = "0x1BE9014", Offset = "0x1BE9014", VA = "0x1BE9014")] get
      {
        return (IPlayerBasicProfileInfo) null;
      }
      [Token(Token = "0x6001087"), Address(RVA = "0x1BE901C", Offset = "0x1BE901C", VA = "0x1BE901C")] set
      {
      }
    }

    [Token(Token = "0x1700018E")]
    public IPlayerPublicDetailProfileInfo PlayerPublicDetailProfile
    {
      [Token(Token = "0x6001088"), Address(RVA = "0x1BE9024", Offset = "0x1BE9024", VA = "0x1BE9024")] get
      {
        return (IPlayerPublicDetailProfileInfo) null;
      }
      [Token(Token = "0x6001089"), Address(RVA = "0x1BE902C", Offset = "0x1BE902C", VA = "0x1BE902C")] set
      {
      }
    }

    [Token(Token = "0x1700018F")]
    public IPlayerTitleInfo PlayerTitleInfo
    {
      [Token(Token = "0x600108A"), Address(RVA = "0x1BE77A4", Offset = "0x1BE77A4", VA = "0x1BE77A4")] get
      {
        return (IPlayerTitleInfo) null;
      }
    }

    [Token(Token = "0x17000190")]
    public FriendStatusTypeEnum FriendStatus
    {
      [Token(Token = "0x600108B"), Address(RVA = "0x1BE9034", Offset = "0x1BE9034", VA = "0x1BE9034")] set
      {
      }
      [Token(Token = "0x600108C"), Address(RVA = "0x1BE903C", Offset = "0x1BE903C", VA = "0x1BE903C")] get
      {
        return new FriendStatusTypeEnum();
      }
    }

    [Token(Token = "0x17000191")]
    public bool IsBlocked
    {
      [Token(Token = "0x600108D"), Address(RVA = "0x1BE9044", Offset = "0x1BE9044", VA = "0x1BE9044")] set
      {
      }
      [Token(Token = "0x600108E"), Address(RVA = "0x1BE9050", Offset = "0x1BE9050", VA = "0x1BE9050")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000192")]
    public int Rank
    {
      [Token(Token = "0x600108F"), Address(RVA = "0x1BE9058", Offset = "0x1BE9058", VA = "0x1BE9058")] set
      {
      }
      [Token(Token = "0x6001090"), Address(RVA = "0x1BE9060", Offset = "0x1BE9060", VA = "0x1BE9060")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6001091")]
    [Address(RVA = "0x1BE9068", Offset = "0x1BE9068", VA = "0x1BE9068")]
    public UIParameter()
    {
    }

    [Token(Token = "0x6001092")]
    [Address(RVA = "0x1BE9070", Offset = "0x1BE9070", VA = "0x1BE9070")]
    public UIParameter(FriendProfileInfo friendProfileInfo)
    {
    }

    [Token(Token = "0x6001093")]
    [Address(RVA = "0x1BE90D4", Offset = "0x1BE90D4", VA = "0x1BE90D4")]
    public IEnumerable<string> GetDependencyAssetBundleNames() => (IEnumerable<string>) null;
  }
}
