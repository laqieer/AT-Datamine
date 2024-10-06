// Decompiled with JetBrains decompiler
// Type: Scenes.Guild.Menu.GuildMenuPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.Popup;
using Il2CppDummyDll;
using Scenes.Guild.Data;
using System;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes.Guild.Menu
{
  [Token(Token = "0x2002BBF")]
  public class GuildMenuPopup : PopupBase
  {
    [Token(Token = "0x400BA37")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private GuildMenuPopup.ActiveButtonForRole[] activeButtons;
    [Token(Token = "0x400BA38")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private GameObject newRequestBadgeObj;
    [Token(Token = "0x400BA39")]
    [FieldOffset(Offset = "0x98")]
    private GuildBelowScreenBase bottomScreen;
    [Token(Token = "0x400BA3A")]
    [FieldOffset(Offset = "0xA0")]
    private Action onClose;

    [Token(Token = "0x17003AF2")]
    private GuildDataManager guildDataManager
    {
      [Token(Token = "0x6011169"), Address(RVA = "0x1C7E8C8", Offset = "0x1C7E8C8", VA = "0x1C7E8C8")] get
      {
        return (GuildDataManager) null;
      }
    }

    [Token(Token = "0x601116A")]
    [Address(RVA = "0x1C79224", Offset = "0x1C79224", VA = "0x1C79224")]
    public void SetBottomScreen(GuildBelowScreenBase bottomScreen, Action onClose)
    {
    }

    [Token(Token = "0x601116B")]
    [Address(RVA = "0x1C7E918", Offset = "0x1C7E918", VA = "0x1C7E918", Slot = "8")]
    public override void Open()
    {
    }

    [Token(Token = "0x601116C")]
    [Address(RVA = "0x1C7EAB8", Offset = "0x1C7EAB8", VA = "0x1C7EAB8", Slot = "9")]
    public override void Close()
    {
    }

    [Token(Token = "0x601116D")]
    [Address(RVA = "0x1C7EAEC", Offset = "0x1C7EAEC", VA = "0x1C7EAEC", Slot = "5")]
    public override void OnClickClose()
    {
    }

    [Token(Token = "0x601116E")]
    [Address(RVA = "0x1C7EAF8", Offset = "0x1C7EAF8", VA = "0x1C7EAF8")]
    public void OnClickInfo()
    {
    }

    [Token(Token = "0x601116F")]
    [Address(RVA = "0x1C7EB3C", Offset = "0x1C7EB3C", VA = "0x1C7EB3C")]
    public void OnClickMemberManagement()
    {
    }

    [Token(Token = "0x6011170")]
    [Address(RVA = "0x1C7EB80", Offset = "0x1C7EB80", VA = "0x1C7EB80")]
    public void OnClickJoinRequest()
    {
    }

    [Token(Token = "0x6011171")]
    [Address(RVA = "0x1C7EC1C", Offset = "0x1C7EC1C", VA = "0x1C7EC1C")]
    public void OnClickLeave()
    {
    }

    [Token(Token = "0x6011172")]
    [Address(RVA = "0x1C7F0C0", Offset = "0x1C7F0C0", VA = "0x1C7F0C0")]
    public void OnClickSetting()
    {
    }

    [Token(Token = "0x6011173")]
    [Address(RVA = "0x1C7F154", Offset = "0x1C7F154", VA = "0x1C7F154")]
    public void OnClickList()
    {
    }

    [Token(Token = "0x6011174")]
    [Address(RVA = "0x1C7F198", Offset = "0x1C7F198", VA = "0x1C7F198")]
    public void OnClickDismantle()
    {
    }

    [Token(Token = "0x6011175")]
    [Address(RVA = "0x1C7F5CC", Offset = "0x1C7F5CC", VA = "0x1C7F5CC")]
    public IEnumerator RequestGuildLeave(Action onSuccess) => (IEnumerator) null;

    [Token(Token = "0x6011176")]
    [Address(RVA = "0x1C7F65C", Offset = "0x1C7F65C", VA = "0x1C7F65C")]
    private IEnumerator RequestGuildDelete(Action onSuccess) => (IEnumerator) null;

    [Token(Token = "0x6011177")]
    [Address(RVA = "0x1C7F050", Offset = "0x1C7F050", VA = "0x1C7F050")]
    private string GetText(string key) => (string) null;

    [Token(Token = "0x6011178")]
    [Address(RVA = "0x1C7F6EC", Offset = "0x1C7F6EC", VA = "0x1C7F6EC")]
    public GuildMenuPopup()
    {
    }

    [Token(Token = "0x2002BC0")]
    [Serializable]
    public class ActiveButtonForRole
    {
      [Token(Token = "0x400BA3B")]
      [FieldOffset(Offset = "0x10")]
      public CommonButton button;
      [Token(Token = "0x400BA3C")]
      [FieldOffset(Offset = "0x18")]
      public GuildRoleTypeEnum[] roles;

      [Token(Token = "0x601117F")]
      [Address(RVA = "0x1C7FA6C", Offset = "0x1C7FA6C", VA = "0x1C7FA6C")]
      public ActiveButtonForRole()
      {
      }
    }
  }
}
