// Decompiled with JetBrains decompiler
// Type: Scenes.Guild.Attend.AttendInfoPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using Scenes.Guild.Data;
using System;
using TMPro;
using UnityEngine;

#nullable disable
namespace Scenes.Guild.Attend
{
  [Token(Token = "0x2002C47")]
  public class AttendInfoPopup : PopupBase
  {
    [Token(Token = "0x400BCA7")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private TextMeshProUGUI yesterdayAttend;
    [Token(Token = "0x400BCA8")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private TextMeshProUGUI todayAttend;
    [Token(Token = "0x400BCA9")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x400BCAA")]
    private const string AttendCountTextKey = "Popup_Text_GuildAttendanceStatus_NumberOfPeople_size_color";
    [Token(Token = "0x400BCAB")]
    [FieldOffset(Offset = "0xA0")]
    private Action onReward;
    [Token(Token = "0x400BCAC")]
    [FieldOffset(Offset = "0xA8")]
    private Action onClose;

    [Token(Token = "0x17003BEC")]
    private GuildDataManager guildDataManager
    {
      [Token(Token = "0x60115A4"), Address(RVA = "0x4E17240", Offset = "0x4E17240", VA = "0x4E17240")] get
      {
        return (GuildDataManager) null;
      }
    }

    [Token(Token = "0x60115A5")]
    [Address(RVA = "0x4E17290", Offset = "0x4E17290", VA = "0x4E17290")]
    public void Initialize()
    {
    }

    [Token(Token = "0x60115A6")]
    [Address(RVA = "0x4E17454", Offset = "0x4E17454", VA = "0x4E17454")]
    public void SetButtonEvent(Action onReward, Action onClose)
    {
    }

    [Token(Token = "0x60115A7")]
    [Address(RVA = "0x4E1745C", Offset = "0x4E1745C", VA = "0x4E1745C")]
    public void OnClickRewardInfo()
    {
    }

    [Token(Token = "0x60115A8")]
    [Address(RVA = "0x4E17478", Offset = "0x4E17478", VA = "0x4E17478", Slot = "9")]
    public override void Close()
    {
    }

    [Token(Token = "0x60115A9")]
    [Address(RVA = "0x4E174AC", Offset = "0x4E174AC", VA = "0x4E174AC", Slot = "5")]
    public override void OnClickClose()
    {
    }

    [Token(Token = "0x60115AA")]
    [Address(RVA = "0x4E174D0", Offset = "0x4E174D0", VA = "0x4E174D0")]
    public AttendInfoPopup()
    {
    }
  }
}
