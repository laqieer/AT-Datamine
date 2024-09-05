// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Friend.FriendListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.PlayerInfo;
using StaqData;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.Friend
{
  [Token(Token = "0x2003603")]
  public class FriendListItem : MonoBehaviour
  {
    [Token(Token = "0x400EAD1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CharacterImage characterThumbnail;
    [Token(Token = "0x400EAD2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerTitlePanel playerTitle;
    [Token(Token = "0x400EAD3")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text textPlayerName;
    [Token(Token = "0x400EAD4")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text textPlayerRank;
    [Token(Token = "0x400EAD5")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text textLastSignedInAt;
    [Token(Token = "0x400EAD6")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject friendListObject;
    [Token(Token = "0x400EAD7")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject friendNoticeObject;
    [Token(Token = "0x400EAD8")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject friendRequestObject;
    [Token(Token = "0x400EAD9")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject friendBlockListObject;
    [Token(Token = "0x400EADA")]
    [FieldOffset(Offset = "0x60")]
    private FriendProfileInfo friendProfileInfo;
    [Token(Token = "0x400EADB")]
    [FieldOffset(Offset = "0x68")]
    private IFriendListItemEventListener listItemEventListener;

    [Token(Token = "0x6015413")]
    [Address(RVA = "0x4D9069C", Offset = "0x4D9069C", VA = "0x4D9069C")]
    public static IEnumerable<string> GetDependencyAssetBundleNames(
      FriendProfileInfo friendProfileInfo)
    {
      return (IEnumerable<string>) null;
    }

    [Token(Token = "0x6015414")]
    [Address(RVA = "0x4D8F318", Offset = "0x4D8F318", VA = "0x4D8F318")]
    public void Setup(FriendProfileInfo friendProfileInfo)
    {
    }

    [Token(Token = "0x6015415")]
    [Address(RVA = "0x4D90A6C", Offset = "0x4D90A6C", VA = "0x4D90A6C")]
    public void SetEventListener(IFriendListItemEventListener listener)
    {
    }

    [Token(Token = "0x6015416")]
    [Address(RVA = "0x4D90A74", Offset = "0x4D90A74", VA = "0x4D90A74")]
    public void OnClickFriendRemove()
    {
    }

    [Token(Token = "0x6015417")]
    [Address(RVA = "0x4D90B34", Offset = "0x4D90B34", VA = "0x4D90B34")]
    public void OnClickFriendAccept()
    {
    }

    [Token(Token = "0x6015418")]
    [Address(RVA = "0x4D90BF8", Offset = "0x4D90BF8", VA = "0x4D90BF8")]
    public void OnClickFriendReject()
    {
    }

    [Token(Token = "0x6015419")]
    [Address(RVA = "0x4D90CBC", Offset = "0x4D90CBC", VA = "0x4D90CBC")]
    public void OnClickFriendCancel()
    {
    }

    [Token(Token = "0x601541A")]
    [Address(RVA = "0x4D90D80", Offset = "0x4D90D80", VA = "0x4D90D80")]
    public void OnClickFriendBlock()
    {
    }

    [Token(Token = "0x601541B")]
    [Address(RVA = "0x4D90E44", Offset = "0x4D90E44", VA = "0x4D90E44")]
    public void OnClickFriendBlockRemove()
    {
    }

    [Token(Token = "0x601541C")]
    [Address(RVA = "0x4D90F08", Offset = "0x4D90F08", VA = "0x4D90F08")]
    public void OnClickDetail()
    {
    }

    [Token(Token = "0x601541D")]
    [Address(RVA = "0x4D90FC8", Offset = "0x4D90FC8", VA = "0x4D90FC8")]
    private void DisableObjects()
    {
    }

    [Token(Token = "0x601541E")]
    [Address(RVA = "0x4D8F80C", Offset = "0x4D8F80C", VA = "0x4D8F80C")]
    public void EnableFriendListItem()
    {
    }

    [Token(Token = "0x601541F")]
    [Address(RVA = "0x4D8FC34", Offset = "0x4D8FC34", VA = "0x4D8FC34")]
    public void EnableFriendNotifyListItem()
    {
    }

    [Token(Token = "0x6015420")]
    [Address(RVA = "0x4D9005C", Offset = "0x4D9005C", VA = "0x4D9005C")]
    public void EnableFriendRequestListItem()
    {
    }

    [Token(Token = "0x6015421")]
    [Address(RVA = "0x4D90484", Offset = "0x4D90484", VA = "0x4D90484")]
    public void EnableBlockListItem()
    {
    }

    [Token(Token = "0x6015422")]
    [Address(RVA = "0x4D91104", Offset = "0x4D91104", VA = "0x4D91104")]
    public FriendListItem()
    {
    }
  }
}
