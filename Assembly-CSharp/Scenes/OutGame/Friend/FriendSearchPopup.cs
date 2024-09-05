// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Friend.FriendSearchPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.API;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Friend
{
  [Token(Token = "0x200361C")]
  public class FriendSearchPopup : 
    APIConfirmPopupBase<FriendSearchPopup, APIFriendSearch, APIFriendSearchRequest, APIFriendSearchResponse>
  {
    [Token(Token = "0x400EB47")]
    public const string AssetBundleName = "2dassets_ui_friend";
    [Token(Token = "0x400EB48")]
    public const string PrefabName = "Com_Popup_FriendSearch";
    [Token(Token = "0x400EB49")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Text textPlayerShortID;
    [Token(Token = "0x400EB4A")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private InputField inputField;
    [Token(Token = "0x400EB4B")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Button searchButton;
    [Token(Token = "0x400EB4C")]
    [FieldOffset(Offset = "0x60")]
    private long ownShortPlayerID;

    [Token(Token = "0x60154E5")]
    [Address(RVA = "0x4D92A34", Offset = "0x4D92A34", VA = "0x4D92A34")]
    public new static void Open(
      APIFriendSearchRequest requestParameter,
      Action<APIFriendSearchResponse> onSuccess,
      Action onFailure,
      Action onCancel,
      APIConfirmPopupParameter parameter = null)
    {
    }

    [Token(Token = "0x60154E6")]
    [Address(RVA = "0x4D965F4", Offset = "0x4D965F4", VA = "0x4D965F4", Slot = "4")]
    protected override void OnCreate(APIConfirmPopupParameter popupParameter)
    {
    }

    [Token(Token = "0x60154E7")]
    [Address(RVA = "0x4D967C4", Offset = "0x4D967C4", VA = "0x4D967C4")]
    public void OnClickPlayerIdCopy()
    {
    }

    [Token(Token = "0x60154E8")]
    [Address(RVA = "0x4D96788", Offset = "0x4D96788", VA = "0x4D96788")]
    private void SetExecuteButtonInteractable()
    {
    }

    [Token(Token = "0x60154E9")]
    [Address(RVA = "0x4D968F0", Offset = "0x4D968F0", VA = "0x4D968F0")]
    public void OnValueChange()
    {
    }

    [Token(Token = "0x60154EA")]
    [Address(RVA = "0x4D968F4", Offset = "0x4D968F4", VA = "0x4D968F4")]
    public void OnEndEdit()
    {
    }

    [Token(Token = "0x60154EB")]
    [Address(RVA = "0x4D96960", Offset = "0x4D96960", VA = "0x4D96960")]
    private char OnValidateInput(string text, int index, char addedChar) => new char();

    [Token(Token = "0x60154EC")]
    [Address(RVA = "0x4D969C4", Offset = "0x4D969C4", VA = "0x4D969C4", Slot = "5")]
    protected override IEnumerator SendRequest() => (IEnumerator) null;

    [Token(Token = "0x60154ED")]
    [Address(RVA = "0x4D96A54", Offset = "0x4D96A54", VA = "0x4D96A54")]
    public FriendSearchPopup()
    {
    }
  }
}
