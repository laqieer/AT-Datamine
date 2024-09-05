// Decompiled with JetBrains decompiler
// Type: Scenes.Guild.Build.GuildEstablishedBelowScreen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Toaster;
using Il2CppDummyDll;
using Network;
using Scenes.Guild.Data;
using Scenes.Guild.Setting;
using Scenes.Guild.Top;
using System;
using System.Collections;
using TMPro;
using UnityEngine;

#nullable disable
namespace Scenes.Guild.Build
{
  [Token(Token = "0x2002C40")]
  public class GuildEstablishedBelowScreen : GuildBelowScreenBase
  {
    [Token(Token = "0x400BC89")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GuildSettingPullDown settingPullDown;
    [Token(Token = "0x400BC8A")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private TMP_InputField inputField;
    [Token(Token = "0x400BC8B")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private CommonButton button;
    [Token(Token = "0x400BC8C")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private CommonButton decideButton;
    [Token(Token = "0x400BC8D")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GuildTopBulletinBoard bulletinBoard;
    [Token(Token = "0x400BC8E")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private int nameMaxCharaCount;
    [Token(Token = "0x400BC8F")]
    [FieldOffset(Offset = "0x64")]
    private bool isJoined;

    [Token(Token = "0x17003BDE")]
    private ToasterManager toasterManager
    {
      [Token(Token = "0x601156F"), Address(RVA = "0x4E15F34", Offset = "0x4E15F34", VA = "0x4E15F34")] get
      {
        return (ToasterManager) null;
      }
    }

    [Token(Token = "0x17003BDF")]
    private GuildDataManager guildDataManager
    {
      [Token(Token = "0x6011570"), Address(RVA = "0x4E15FA0", Offset = "0x4E15FA0", VA = "0x4E15FA0")] get
      {
        return (GuildDataManager) null;
      }
    }

    [Token(Token = "0x6011571")]
    [Address(RVA = "0x4E15FF0", Offset = "0x4E15FF0", VA = "0x4E15FF0", Slot = "4")]
    public override void Initialize(
      GuildSubScene guildSubScene,
      GuildAssetBundleParam.GuildScreenType? type,
      GuildBelowScreenParam param)
    {
    }

    [Token(Token = "0x6011572")]
    [Address(RVA = "0x4E162D8", Offset = "0x4E162D8", VA = "0x4E162D8", Slot = "5")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6011573")]
    [Address(RVA = "0x4E16368", Offset = "0x4E16368", VA = "0x4E16368", Slot = "7")]
    public override void Open()
    {
    }

    [Token(Token = "0x6011574")]
    [Address(RVA = "0x4E16390", Offset = "0x4E16390", VA = "0x4E16390", Slot = "8")]
    public override void Close()
    {
    }

    [Token(Token = "0x6011575")]
    [Address(RVA = "0x4E163B8", Offset = "0x4E163B8", VA = "0x4E163B8")]
    public void OnClickEditGuildName()
    {
    }

    [Token(Token = "0x6011576")]
    [Address(RVA = "0x4E162A4", Offset = "0x4E162A4", VA = "0x4E162A4")]
    private void OnValueChangedGuildName(string text)
    {
    }

    [Token(Token = "0x6011577")]
    [Address(RVA = "0x4E163D4", Offset = "0x4E163D4", VA = "0x4E163D4")]
    public void OnClickCreateGuild()
    {
    }

    [Token(Token = "0x6011578")]
    [Address(RVA = "0x4E16474", Offset = "0x4E16474", VA = "0x4E16474")]
    private IEnumerator GuildBuildAsync() => (IEnumerator) null;

    [Token(Token = "0x6011579")]
    [Address(RVA = "0x4E1640C", Offset = "0x4E1640C", VA = "0x4E1640C")]
    private IEnumerator GuildChangeSettingAsync() => (IEnumerator) null;

    [Token(Token = "0x601157A")]
    [Address(RVA = "0x4E1652C", Offset = "0x4E1652C", VA = "0x4E1652C")]
    private IEnumerator RequestGuildBuild(Action onSuccess) => (IEnumerator) null;

    [Token(Token = "0x601157B")]
    [Address(RVA = "0x4E165C8", Offset = "0x4E165C8", VA = "0x4E165C8")]
    private IEnumerator RequestGuildSetting(Action onSuccess) => (IEnumerator) null;

    [Token(Token = "0x601157C")]
    [Address(RVA = "0x4E16664", Offset = "0x4E16664", VA = "0x4E16664")]
    private IEnumerator ShowToasterNGWord(NetworkErrorResult networkErrorResult)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601157D")]
    [Address(RVA = "0x4E16700", Offset = "0x4E16700", VA = "0x4E16700")]
    public GuildEstablishedBelowScreen()
    {
    }
  }
}
