// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Friend.FriendApplyPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.API;
using System.Collections;

#nullable disable
namespace Scenes.OutGame.Friend
{
  [Token(Token = "0x20035FC")]
  public class FriendApplyPopup : 
    APIConfirmPopupBase<FriendApplyPopup, APIFriendApply, APIFriendApplyRequest, APIFriendApplyResponse>
  {
    [Token(Token = "0x400EABC")]
    private const string PopupTitle = "フレンド申請";
    [Token(Token = "0x400EABD")]
    private const string PopupMessage = "{0}\nにフレンド申請しますか？";

    [Token(Token = "0x60153EB")]
    [Address(RVA = "0x4D8E900", Offset = "0x4D8E900", VA = "0x4D8E900", Slot = "4")]
    protected override void OnCreate(APIConfirmPopupParameter popupParameter)
    {
    }

    [Token(Token = "0x60153EC")]
    [Address(RVA = "0x4D8E9E8", Offset = "0x4D8E9E8", VA = "0x4D8E9E8", Slot = "5")]
    protected override IEnumerator SendRequest() => (IEnumerator) null;

    [Token(Token = "0x60153ED")]
    [Address(RVA = "0x4D8EA78", Offset = "0x4D8EA78", VA = "0x4D8EA78")]
    public FriendApplyPopup()
    {
    }
  }
}
