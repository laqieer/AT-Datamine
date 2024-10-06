// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Friend.FriendSearchResultPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using Network.API;
using StaqData;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Friend
{
  [Token(Token = "0x200361F")]
  public class FriendSearchResultPopup : ConfirmationPopup
  {
    [Token(Token = "0x400EB53")]
    public const string AssetBundleName = "2dassets_ui_friend";
    [Token(Token = "0x400EB54")]
    public const string PrefabName = "Com_Popup_FriendSearchHit";
    [Token(Token = "0x400EB55")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private FriendListItem friendListItem;
    [Token(Token = "0x400EB56")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Text textPlayerShortId;
    [Token(Token = "0x400EB5F")]
    [FieldOffset(Offset = "0xE8")]
    private FriendProfileInfo friendProfileInfo;

    [Token(Token = "0x170046DD")]
    public Action OnClose
    {
      [Token(Token = "0x60154F7"), Address(RVA = "0x4D96D40", Offset = "0x4D96D40", VA = "0x4D96D40")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x60154F8"), Address(RVA = "0x4D96D48", Offset = "0x4D96D48", VA = "0x4D96D48")] set
      {
      }
    }

    [Token(Token = "0x170046DE")]
    public Action<APIFriendApplyResponse> OnSuccessFriendApply
    {
      [Token(Token = "0x60154F9"), Address(RVA = "0x4D96D50", Offset = "0x4D96D50", VA = "0x4D96D50")] get
      {
        return (Action<APIFriendApplyResponse>) null;
      }
      [Token(Token = "0x60154FA"), Address(RVA = "0x4D96D58", Offset = "0x4D96D58", VA = "0x4D96D58")] set
      {
      }
    }

    [Token(Token = "0x170046DF")]
    public Action<APIFriendCancelResponse> OnSuccessFriendCancel
    {
      [Token(Token = "0x60154FB"), Address(RVA = "0x4D96D60", Offset = "0x4D96D60", VA = "0x4D96D60")] get
      {
        return (Action<APIFriendCancelResponse>) null;
      }
      [Token(Token = "0x60154FC"), Address(RVA = "0x4D96D68", Offset = "0x4D96D68", VA = "0x4D96D68")] set
      {
      }
    }

    [Token(Token = "0x170046E0")]
    public Action<APIFriendRemoveResponse> OnSuccessFriendRemove
    {
      [Token(Token = "0x60154FD"), Address(RVA = "0x4D96D70", Offset = "0x4D96D70", VA = "0x4D96D70")] get
      {
        return (Action<APIFriendRemoveResponse>) null;
      }
      [Token(Token = "0x60154FE"), Address(RVA = "0x4D96D78", Offset = "0x4D96D78", VA = "0x4D96D78")] set
      {
      }
    }

    [Token(Token = "0x170046E1")]
    public Action<APIFriendAcceptResponse> OnSuccessFriendAccept
    {
      [Token(Token = "0x60154FF"), Address(RVA = "0x4D96D80", Offset = "0x4D96D80", VA = "0x4D96D80")] get
      {
        return (Action<APIFriendAcceptResponse>) null;
      }
      [Token(Token = "0x6015500"), Address(RVA = "0x4D96D88", Offset = "0x4D96D88", VA = "0x4D96D88")] set
      {
      }
    }

    [Token(Token = "0x170046E2")]
    public Action<APIFriendRejectResponse> OnSuccessFriendReject
    {
      [Token(Token = "0x6015501"), Address(RVA = "0x4D96D90", Offset = "0x4D96D90", VA = "0x4D96D90")] get
      {
        return (Action<APIFriendRejectResponse>) null;
      }
      [Token(Token = "0x6015502"), Address(RVA = "0x4D96D98", Offset = "0x4D96D98", VA = "0x4D96D98")] set
      {
      }
    }

    [Token(Token = "0x170046E3")]
    public Action<APIBlockAddResponse> OnSuccessBlockAdd
    {
      [Token(Token = "0x6015503"), Address(RVA = "0x4D96DA0", Offset = "0x4D96DA0", VA = "0x4D96DA0")] get
      {
        return (Action<APIBlockAddResponse>) null;
      }
      [Token(Token = "0x6015504"), Address(RVA = "0x4D96DA8", Offset = "0x4D96DA8", VA = "0x4D96DA8")] set
      {
      }
    }

    [Token(Token = "0x170046E4")]
    public Action<APIBlockRemoveResponse> OnSuccessBlockRemove
    {
      [Token(Token = "0x6015505"), Address(RVA = "0x4D96DB0", Offset = "0x4D96DB0", VA = "0x4D96DB0")] get
      {
        return (Action<APIBlockRemoveResponse>) null;
      }
      [Token(Token = "0x6015506"), Address(RVA = "0x4D96DB8", Offset = "0x4D96DB8", VA = "0x4D96DB8")] set
      {
      }
    }

    [Token(Token = "0x6015507")]
    [Address(RVA = "0x4D955B0", Offset = "0x4D955B0", VA = "0x4D955B0")]
    public static void Open(
      FriendProfileInfo friendProfileInfo,
      Action<FriendSearchResultPopup> onCreate = null)
    {
    }

    [Token(Token = "0x6015508")]
    [Address(RVA = "0x4D970A8", Offset = "0x4D970A8", VA = "0x4D970A8", Slot = "9")]
    public override void Close()
    {
    }

    [Token(Token = "0x6015509")]
    [Address(RVA = "0x4D97158", Offset = "0x4D97158", VA = "0x4D97158")]
    private void PlayCloseAnimation()
    {
    }

    [Token(Token = "0x601550A")]
    [Address(RVA = "0x4D971A8", Offset = "0x4D971A8", VA = "0x4D971A8")]
    private void PlayOpenAnimation()
    {
    }

    [Token(Token = "0x601550B")]
    [Address(RVA = "0x4D96DC0", Offset = "0x4D96DC0", VA = "0x4D96DC0")]
    public void OnCreate(FriendProfileInfo param)
    {
    }

    [Token(Token = "0x601550C")]
    [Address(RVA = "0x4D971F8", Offset = "0x4D971F8", VA = "0x4D971F8")]
    private void OnClickCancel()
    {
    }

    [Token(Token = "0x601550D")]
    [Address(RVA = "0x4D97230", Offset = "0x4D97230", VA = "0x4D97230")]
    private void OnClickFriendApply()
    {
    }

    [Token(Token = "0x601550E")]
    [Address(RVA = "0x4D974C0", Offset = "0x4D974C0", VA = "0x4D974C0")]
    public void OnClickDetail()
    {
    }

    [Token(Token = "0x601550F")]
    [Address(RVA = "0x4D974E0", Offset = "0x4D974E0", VA = "0x4D974E0")]
    private IEnumerator OpenPlayerDetailPopupAsync() => (IEnumerator) null;

    [Token(Token = "0x6015510")]
    [Address(RVA = "0x4D97570", Offset = "0x4D97570", VA = "0x4D97570")]
    public FriendSearchResultPopup()
    {
    }

    [Token(Token = "0x2003620")]
    public delegate void OnDetailButtonClickEvent(string playerId);
  }
}
