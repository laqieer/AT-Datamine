// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Friend.FriendRemovePopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.API;
using System.Collections;

#nullable disable
namespace Scenes.OutGame.Friend
{
  [Token(Token = "0x200361A")]
  public class FriendRemovePopup : 
    APIConfirmPopupBase<FriendRemovePopup, APIFriendRemove, APIFriendRemoveRequest, APIFriendRemoveResponse>
  {
    [Token(Token = "0x400EB41")]
    private const string PopupTitle = "フレンド登録解除";
    [Token(Token = "0x400EB42")]
    private const string PopupMessage = "{0}\nとのフレンドを解除しますか？";

    [Token(Token = "0x60154DC")]
    [Address(RVA = "0x4D9623C", Offset = "0x4D9623C", VA = "0x4D9623C", Slot = "4")]
    protected override void OnCreate(APIConfirmPopupParameter popupParameter)
    {
    }

    [Token(Token = "0x60154DD")]
    [Address(RVA = "0x4D96324", Offset = "0x4D96324", VA = "0x4D96324", Slot = "5")]
    protected override IEnumerator SendRequest() => (IEnumerator) null;

    [Token(Token = "0x60154DE")]
    [Address(RVA = "0x4D963B4", Offset = "0x4D963B4", VA = "0x4D963B4")]
    public FriendRemovePopup()
    {
    }
  }
}
