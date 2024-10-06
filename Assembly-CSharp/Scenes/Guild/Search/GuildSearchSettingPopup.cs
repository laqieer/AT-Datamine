// Decompiled with JetBrains decompiler
// Type: Scenes.Guild.Search.GuildSearchSettingPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using Scenes.Guild.Data;
using Scenes.Guild.Setting;
using System;
using TMPro;
using UnityEngine;

#nullable disable
namespace Scenes.Guild.Search
{
  [Token(Token = "0x2002BBE")]
  public class GuildSearchSettingPopup : PopupBase
  {
    [Token(Token = "0x400BA31")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private GuildSettingPullDown settingPullDown;
    [Token(Token = "0x400BA32")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private TMP_InputField inputField;
    [Token(Token = "0x400BA33")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private CommonButton button;
    [Token(Token = "0x400BA34")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private CommonToggle toggleCheck;
    [Token(Token = "0x400BA35")]
    [FieldOffset(Offset = "0xA8")]
    private Action<GuildSearchSettings> onClose;
    [Token(Token = "0x400BA36")]
    [FieldOffset(Offset = "0xB0")]
    private GuildSearchSettings guildSearchSettings;

    [Token(Token = "0x6011162")]
    [Address(RVA = "0x1C7D540", Offset = "0x1C7D540", VA = "0x1C7D540")]
    public void Setup(GuildSearchSettings guildSearchSettings, Action<GuildSearchSettings> onClose)
    {
    }

    [Token(Token = "0x6011163")]
    [Address(RVA = "0x1C7E6D8", Offset = "0x1C7E6D8", VA = "0x1C7E6D8", Slot = "8")]
    public override void Open()
    {
    }

    [Token(Token = "0x6011164")]
    [Address(RVA = "0x1C7E80C", Offset = "0x1C7E80C", VA = "0x1C7E80C")]
    public void OnClickEditGuildName()
    {
    }

    [Token(Token = "0x6011165")]
    [Address(RVA = "0x1C7E828", Offset = "0x1C7E828", VA = "0x1C7E828")]
    public void OnClickChange()
    {
    }

    [Token(Token = "0x6011166")]
    [Address(RVA = "0x1C7E87C", Offset = "0x1C7E87C", VA = "0x1C7E87C", Slot = "5")]
    public override void OnClickClose()
    {
    }

    [Token(Token = "0x6011167")]
    [Address(RVA = "0x1C7E888", Offset = "0x1C7E888", VA = "0x1C7E888", Slot = "9")]
    public override void Close()
    {
    }

    [Token(Token = "0x6011168")]
    [Address(RVA = "0x1C7E8C0", Offset = "0x1C7E8C0", VA = "0x1C7E8C0")]
    public GuildSearchSettingPopup()
    {
    }
  }
}
