// Decompiled with JetBrains decompiler
// Type: Network.Param.ChatMessageType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A4C")]
  [Serializable]
  public class ChatMessageType
  {
    [Token(Token = "0x400706E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string player_id;
    [Token(Token = "0x400706F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string player_name;
    [Token(Token = "0x4007070")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private int emblem_id;
    [Token(Token = "0x4007071")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private int pre_title_id;
    [Token(Token = "0x4007072")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private int post_title_id;
    [Token(Token = "0x4007073")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private int title_frame_id;
    [Token(Token = "0x4007074")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private int symbol_unit_master_id;
    [Token(Token = "0x4007075")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private string message_id;
    [Token(Token = "0x4007076")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private string message_content;
    [Token(Token = "0x4007077")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private int message_type_id;
    [Token(Token = "0x4007078")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private int post_time;

    [Token(Token = "0x170018A4")]
    public string PlayerId
    {
      [Token(Token = "0x600962A"), Address(RVA = "0x48EEF8C", Offset = "0x48EEF8C", VA = "0x48EEF8C")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600962B"), Address(RVA = "0x48EEF94", Offset = "0x48EEF94", VA = "0x48EEF94")] set
      {
      }
    }

    [Token(Token = "0x170018A5")]
    public string PlayerName
    {
      [Token(Token = "0x600962C"), Address(RVA = "0x48EEF9C", Offset = "0x48EEF9C", VA = "0x48EEF9C")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600962D"), Address(RVA = "0x48EEFA4", Offset = "0x48EEFA4", VA = "0x48EEFA4")] set
      {
      }
    }

    [Token(Token = "0x170018A6")]
    public int EmblemId
    {
      [Token(Token = "0x600962E"), Address(RVA = "0x48EEFAC", Offset = "0x48EEFAC", VA = "0x48EEFAC")] get
      {
        return new int();
      }
      [Token(Token = "0x600962F"), Address(RVA = "0x48EEFB4", Offset = "0x48EEFB4", VA = "0x48EEFB4")] set
      {
      }
    }

    [Token(Token = "0x170018A7")]
    public int PreTitleId
    {
      [Token(Token = "0x6009630"), Address(RVA = "0x48EEFBC", Offset = "0x48EEFBC", VA = "0x48EEFBC")] get
      {
        return new int();
      }
      [Token(Token = "0x6009631"), Address(RVA = "0x48EEFC4", Offset = "0x48EEFC4", VA = "0x48EEFC4")] set
      {
      }
    }

    [Token(Token = "0x170018A8")]
    public int PostTitleId
    {
      [Token(Token = "0x6009632"), Address(RVA = "0x48EEFCC", Offset = "0x48EEFCC", VA = "0x48EEFCC")] get
      {
        return new int();
      }
      [Token(Token = "0x6009633"), Address(RVA = "0x48EEFD4", Offset = "0x48EEFD4", VA = "0x48EEFD4")] set
      {
      }
    }

    [Token(Token = "0x170018A9")]
    public int TitleFrameId
    {
      [Token(Token = "0x6009634"), Address(RVA = "0x48EEFDC", Offset = "0x48EEFDC", VA = "0x48EEFDC")] get
      {
        return new int();
      }
      [Token(Token = "0x6009635"), Address(RVA = "0x48EEFE4", Offset = "0x48EEFE4", VA = "0x48EEFE4")] set
      {
      }
    }

    [Token(Token = "0x170018AA")]
    public int SymbolUnitMasterId
    {
      [Token(Token = "0x6009636"), Address(RVA = "0x48EEFEC", Offset = "0x48EEFEC", VA = "0x48EEFEC")] get
      {
        return new int();
      }
      [Token(Token = "0x6009637"), Address(RVA = "0x48EEFF4", Offset = "0x48EEFF4", VA = "0x48EEFF4")] set
      {
      }
    }

    [Token(Token = "0x170018AB")]
    public string MessageId
    {
      [Token(Token = "0x6009638"), Address(RVA = "0x48EEFFC", Offset = "0x48EEFFC", VA = "0x48EEFFC")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009639"), Address(RVA = "0x48EF004", Offset = "0x48EF004", VA = "0x48EF004")] set
      {
      }
    }

    [Token(Token = "0x170018AC")]
    public string MessageContent
    {
      [Token(Token = "0x600963A"), Address(RVA = "0x48EF00C", Offset = "0x48EF00C", VA = "0x48EF00C")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600963B"), Address(RVA = "0x48EF014", Offset = "0x48EF014", VA = "0x48EF014")] set
      {
      }
    }

    [Token(Token = "0x170018AD")]
    public int MessageTypeId
    {
      [Token(Token = "0x600963C"), Address(RVA = "0x48EF01C", Offset = "0x48EF01C", VA = "0x48EF01C")] get
      {
        return new int();
      }
      [Token(Token = "0x600963D"), Address(RVA = "0x48EF024", Offset = "0x48EF024", VA = "0x48EF024")] set
      {
      }
    }

    [Token(Token = "0x170018AE")]
    public int PostTime
    {
      [Token(Token = "0x600963E"), Address(RVA = "0x48EF02C", Offset = "0x48EF02C", VA = "0x48EF02C")] get
      {
        return new int();
      }
      [Token(Token = "0x600963F"), Address(RVA = "0x48EF034", Offset = "0x48EF034", VA = "0x48EF034")] set
      {
      }
    }

    [Token(Token = "0x6009640")]
    [Address(RVA = "0x48EF03C", Offset = "0x48EF03C", VA = "0x48EF03C")]
    public ChatMessageType()
    {
    }
  }
}
