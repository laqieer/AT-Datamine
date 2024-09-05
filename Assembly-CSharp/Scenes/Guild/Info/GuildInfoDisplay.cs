// Decompiled with JetBrains decompiler
// Type: Scenes.Guild.Info.GuildInfoDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.Guild.Data;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Guild.Info
{
  [Token(Token = "0x2002BE4")]
  public class GuildInfoDisplay : MonoBehaviour
  {
    [Token(Token = "0x400BAC2")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GuildInfoDisplay.EitherText textGuildName;
    [Token(Token = "0x400BAC3")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GuildInfoDisplay.EitherText textGuildLevel;
    [Token(Token = "0x400BAC4")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GuildInfoDisplay.EitherText textGuildMasterName;
    [Token(Token = "0x400BAC5")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GuildInfoDisplay.EitherText textGuildMember;
    [Token(Token = "0x400BAC6")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GuildInfoDisplay.EitherText textGuildMaxMember;
    [Token(Token = "0x400BAC7")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Slider sliderExp;

    [Token(Token = "0x6011256")]
    [Address(RVA = "0x4A0C6E0", Offset = "0x4A0C6E0", VA = "0x4A0C6E0")]
    public void Initialize(GuildDetailInfo guildDetailInfo = null)
    {
    }

    [Token(Token = "0x6011257")]
    [Address(RVA = "0x4A0C944", Offset = "0x4A0C944", VA = "0x4A0C944")]
    public GuildInfoDisplay()
    {
    }

    [Token(Token = "0x2002BE5")]
    [Serializable]
    public class EitherText
    {
      [Token(Token = "0x400BAC8")]
      [FieldOffset(Offset = "0x10")]
      [SerializeField]
      private Text uguiText;
      [Token(Token = "0x400BAC9")]
      [FieldOffset(Offset = "0x18")]
      [SerializeField]
      private TextMeshProUGUI tmpText;

      [Token(Token = "0x17003B1C")]
      public string text
      {
        [Token(Token = "0x6011258"), Address(RVA = "0x4A0C94C", Offset = "0x4A0C94C", VA = "0x4A0C94C")] get
        {
          return (string) null;
        }
        [Token(Token = "0x6011259"), Address(RVA = "0x4A0C864", Offset = "0x4A0C864", VA = "0x4A0C864")] set
        {
        }
      }

      [Token(Token = "0x601125A")]
      [Address(RVA = "0x4A0CA38", Offset = "0x4A0CA38", VA = "0x4A0CA38")]
      public EitherText()
      {
      }
    }
  }
}
