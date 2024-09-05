// Decompiled with JetBrains decompiler
// Type: Scenes.Guild.Member.GuildMemberListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.Guild.Data;
using Scenes.OutGame.OutGameMenu;
using Scenes.OutGame.PersonalEmblem;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Guild.Member
{
  [Token(Token = "0x2002BDB")]
  public class GuildMemberListItem : MonoBehaviour
  {
    [Token(Token = "0x400BA9B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text textPlayerName;
    [Token(Token = "0x400BA9C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private StyleThumb thumbnail;
    [Token(Token = "0x400BA9D")]
    [FieldOffset(Offset = "0x28")]
    [Header("Member")]
    [SerializeField]
    private GameObject guildMemberItem;
    [Token(Token = "0x400BA9E")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GuildMemberRoleSelect roleSelect;
    [Token(Token = "0x400BA9F")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TextMeshProUGUI textLastSignedInAt;
    [Token(Token = "0x400BAA0")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private TextMeshProUGUI textPlayerLevel;
    [Token(Token = "0x400BAA1")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private PersonalEmblemThumb personalEmblemThumb;
    [Token(Token = "0x400BAA2")]
    [FieldOffset(Offset = "0x50")]
    [Header("Request")]
    [SerializeField]
    private GameObject requestMemberItem;
    [Token(Token = "0x400BAA3")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private TextMeshProUGUI textRequestLastSignedInAt;
    [Token(Token = "0x400BAA4")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private TextMeshProUGUI textRequestPlayerLevel;
    [Token(Token = "0x400BAA5")]
    [FieldOffset(Offset = "0x68")]
    private GuildMemberInfo guildMemberInfo;
    [Token(Token = "0x400BAA6")]
    [FieldOffset(Offset = "0x70")]
    private Action<GuildMemberInfo> onClick;
    [Token(Token = "0x400BAA7")]
    [FieldOffset(Offset = "0x78")]
    private Action<string> onClickAccept;
    [Token(Token = "0x400BAA8")]
    [FieldOffset(Offset = "0x80")]
    private Action<string> onClickReject;

    [Token(Token = "0x6011220")]
    [Address(RVA = "0x4A0A610", Offset = "0x4A0A610", VA = "0x4A0A610")]
    public void Setup(
      GuildMemberInfo param,
      Action<GuildMemberInfo> onClick,
      Action<string> onClickAccept,
      Action<string> onClickReject,
      Sprite sprite)
    {
    }

    [Token(Token = "0x6011221")]
    [Address(RVA = "0x4A0A61C", Offset = "0x4A0A61C", VA = "0x4A0A61C")]
    public void Setup(GuildMemberInfo param, Action<GuildMemberInfo> onClick, Sprite sprite)
    {
    }

    [Token(Token = "0x6011222")]
    [Address(RVA = "0x4A0A964", Offset = "0x4A0A964", VA = "0x4A0A964")]
    public void OnClickDetail()
    {
    }

    [Token(Token = "0x6011223")]
    [Address(RVA = "0x4A0A984", Offset = "0x4A0A984", VA = "0x4A0A984")]
    public void OnClickAccept()
    {
    }

    [Token(Token = "0x6011224")]
    [Address(RVA = "0x4A0A9BC", Offset = "0x4A0A9BC", VA = "0x4A0A9BC")]
    public void OnClickReject()
    {
    }

    [Token(Token = "0x6011225")]
    [Address(RVA = "0x4A0A9F4", Offset = "0x4A0A9F4", VA = "0x4A0A9F4")]
    public GuildMemberListItem()
    {
    }
  }
}
