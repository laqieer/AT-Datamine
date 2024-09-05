// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Friend.FriendList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.Friend
{
  [Token(Token = "0x2003600")]
  public class FriendList : MonoBehaviour
  {
    [Token(Token = "0x400EAC8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform listItemParent;
    [Token(Token = "0x400EAC9")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private FriendListItem templateListItem;
    [Token(Token = "0x400EACA")]
    [FieldOffset(Offset = "0x28")]
    private List<FriendListItem> listItems;
    [Token(Token = "0x400EACB")]
    [FieldOffset(Offset = "0x30")]
    private IFriendListItemEventListener listItemEventListener;

    [Token(Token = "0x60153FD")]
    [Address(RVA = "0x4D8F070", Offset = "0x4D8F070", VA = "0x4D8F070")]
    public void Initialize()
    {
    }

    [Token(Token = "0x60153FE")]
    [Address(RVA = "0x4D8F09C", Offset = "0x4D8F09C", VA = "0x4D8F09C")]
    public void SetEventListener(IFriendListItemEventListener listener)
    {
    }

    [Token(Token = "0x60153FF")]
    [Address(RVA = "0x4D8F0A4", Offset = "0x4D8F0A4", VA = "0x4D8F0A4")]
    public void Setup(List<FriendProfileInfo> uiParameters)
    {
    }

    [Token(Token = "0x6015400")]
    [Address(RVA = "0x4D8F474", Offset = "0x4D8F474", VA = "0x4D8F474")]
    public void EnableFriendListItem()
    {
    }

    [Token(Token = "0x6015401")]
    [Address(RVA = "0x4D8F89C", Offset = "0x4D8F89C", VA = "0x4D8F89C")]
    public void EnableFriendNotifyListItem()
    {
    }

    [Token(Token = "0x6015402")]
    [Address(RVA = "0x4D8FCC4", Offset = "0x4D8FCC4", VA = "0x4D8FCC4")]
    public void EnableFriendRequestListItem()
    {
    }

    [Token(Token = "0x6015403")]
    [Address(RVA = "0x4D900EC", Offset = "0x4D900EC", VA = "0x4D900EC")]
    public void EnableBlockListItem()
    {
    }

    [Token(Token = "0x6015404")]
    [Address(RVA = "0x4D8F274", Offset = "0x4D8F274", VA = "0x4D8F274")]
    private FriendListItem CreateItem() => (FriendListItem) null;

    [Token(Token = "0x6015405")]
    [Address(RVA = "0x4D90514", Offset = "0x4D90514", VA = "0x4D90514")]
    public FriendList()
    {
    }
  }
}
