// Decompiled with JetBrains decompiler
// Type: Scenes.Guild.Search.GuildSearchListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.Guild.Data;
using Scenes.Guild.Info;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Guild.Search
{
  [Token(Token = "0x2002BBD")]
  public class GuildSearchListItem : MonoBehaviour
  {
    [Token(Token = "0x400BA2C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GuildInfoDisplay infoDisplay;
    [Token(Token = "0x400BA2D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text txtPolicyValue;
    [Token(Token = "0x400BA2E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject requestedObj;
    [Token(Token = "0x400BA2F")]
    [FieldOffset(Offset = "0x30")]
    private Action<GuildDetailInfo> onClick;
    [Token(Token = "0x400BA30")]
    [FieldOffset(Offset = "0x38")]
    private GuildDetailInfo guildDetailInfo;

    [Token(Token = "0x601115F")]
    [Address(RVA = "0x1C7CDA8", Offset = "0x1C7CDA8", VA = "0x1C7CDA8")]
    public void Setup(
      GuildDetailInfo guildDetailInfo,
      Action<GuildDetailInfo> onClick,
      bool isRequested)
    {
    }

    [Token(Token = "0x6011160")]
    [Address(RVA = "0x1C7E6B0", Offset = "0x1C7E6B0", VA = "0x1C7E6B0")]
    public void OnClick()
    {
    }

    [Token(Token = "0x6011161")]
    [Address(RVA = "0x1C7E6D0", Offset = "0x1C7E6D0", VA = "0x1C7E6D0")]
    public GuildSearchListItem()
    {
    }
  }
}
