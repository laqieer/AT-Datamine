// Decompiled with JetBrains decompiler
// Type: Home.Guild.GuildButtonGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Home.Guild
{
  [Token(Token = "0x2000B61")]
  [Serializable]
  internal class GuildButtonGroup
  {
    [Token(Token = "0x40033FB")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Button normalGuildButton;
    [Token(Token = "0x40033FC")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Button guildRaidInProgressButton;
    [Token(Token = "0x40033FD")]
    [FieldOffset(Offset = "0x20")]
    private Button validButton;

    [Token(Token = "0x17000971")]
    public Button ValidButton
    {
      [Token(Token = "0x60040CA"), Address(RVA = "0x2A29B54", Offset = "0x2A29B54", VA = "0x2A29B54")] get
      {
        return (Button) null;
      }
    }

    [Token(Token = "0x60040CB")]
    [Address(RVA = "0x2A29B5C", Offset = "0x2A29B5C", VA = "0x2A29B5C")]
    public void Setup()
    {
    }

    [Token(Token = "0x60040CC")]
    [Address(RVA = "0x2A29D00", Offset = "0x2A29D00", VA = "0x2A29D00")]
    private void SetActivateButton(Button activeButton, Button disableButton)
    {
    }

    [Token(Token = "0x60040CD")]
    [Address(RVA = "0x2A29D64", Offset = "0x2A29D64", VA = "0x2A29D64")]
    public GuildButtonGroup()
    {
    }
  }
}
