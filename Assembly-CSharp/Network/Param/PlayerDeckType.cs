// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerDeckType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AA2")]
  [Serializable]
  public class PlayerDeckType
  {
    [Token(Token = "0x4007229")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int deck_type_id;
    [Token(Token = "0x400722A")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int deck_number;
    [Token(Token = "0x400722B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int cost_limit;
    [Token(Token = "0x400722C")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private int member_limit;
    [Token(Token = "0x400722D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<PlayerDeckSlotInfo> deck_units;
    [Token(Token = "0x400722E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private string name;
    [Token(Token = "0x400722F")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private int ai_type_id;
    [Token(Token = "0x4007230")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private bool is_item_set_setting;
    [Token(Token = "0x4007231")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private int player_item_set_id;

    [Token(Token = "0x17001A76")]
    public int DeckTypeId
    {
      [Token(Token = "0x6009A0E"), Address(RVA = "0x48F0F68", Offset = "0x48F0F68", VA = "0x48F0F68")] get
      {
        return new int();
      }
      [Token(Token = "0x6009A0F"), Address(RVA = "0x48F0F70", Offset = "0x48F0F70", VA = "0x48F0F70")] set
      {
      }
    }

    [Token(Token = "0x17001A77")]
    public int DeckNumber
    {
      [Token(Token = "0x6009A10"), Address(RVA = "0x48F0F78", Offset = "0x48F0F78", VA = "0x48F0F78")] get
      {
        return new int();
      }
      [Token(Token = "0x6009A11"), Address(RVA = "0x48F0F80", Offset = "0x48F0F80", VA = "0x48F0F80")] set
      {
      }
    }

    [Token(Token = "0x17001A78")]
    public int CostLimit
    {
      [Token(Token = "0x6009A12"), Address(RVA = "0x48F0F88", Offset = "0x48F0F88", VA = "0x48F0F88")] get
      {
        return new int();
      }
      [Token(Token = "0x6009A13"), Address(RVA = "0x48F0F90", Offset = "0x48F0F90", VA = "0x48F0F90")] set
      {
      }
    }

    [Token(Token = "0x17001A79")]
    public int MemberLimit
    {
      [Token(Token = "0x6009A14"), Address(RVA = "0x48F0F98", Offset = "0x48F0F98", VA = "0x48F0F98")] get
      {
        return new int();
      }
      [Token(Token = "0x6009A15"), Address(RVA = "0x48F0FA0", Offset = "0x48F0FA0", VA = "0x48F0FA0")] set
      {
      }
    }

    [Token(Token = "0x17001A7A")]
    public List<PlayerDeckSlotInfo> DeckUnits
    {
      [Token(Token = "0x6009A16"), Address(RVA = "0x48F0FA8", Offset = "0x48F0FA8", VA = "0x48F0FA8")] get
      {
        return (List<PlayerDeckSlotInfo>) null;
      }
      [Token(Token = "0x6009A17"), Address(RVA = "0x48F0FB0", Offset = "0x48F0FB0", VA = "0x48F0FB0")] set
      {
      }
    }

    [Token(Token = "0x17001A7B")]
    public string Name
    {
      [Token(Token = "0x6009A18"), Address(RVA = "0x48F0FB8", Offset = "0x48F0FB8", VA = "0x48F0FB8")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009A19"), Address(RVA = "0x48F0FC0", Offset = "0x48F0FC0", VA = "0x48F0FC0")] set
      {
      }
    }

    [Token(Token = "0x17001A7C")]
    public int AiTypeId
    {
      [Token(Token = "0x6009A1A"), Address(RVA = "0x48F0FC8", Offset = "0x48F0FC8", VA = "0x48F0FC8")] get
      {
        return new int();
      }
      [Token(Token = "0x6009A1B"), Address(RVA = "0x48F0FD0", Offset = "0x48F0FD0", VA = "0x48F0FD0")] set
      {
      }
    }

    [Token(Token = "0x17001A7D")]
    public bool IsItemSetSetting
    {
      [Token(Token = "0x6009A1C"), Address(RVA = "0x48F0FD8", Offset = "0x48F0FD8", VA = "0x48F0FD8")] get
      {
        return new bool();
      }
      [Token(Token = "0x6009A1D"), Address(RVA = "0x48F0FE0", Offset = "0x48F0FE0", VA = "0x48F0FE0")] set
      {
      }
    }

    [Token(Token = "0x17001A7E")]
    public int PlayerItemSetId
    {
      [Token(Token = "0x6009A1E"), Address(RVA = "0x48F0FEC", Offset = "0x48F0FEC", VA = "0x48F0FEC")] get
      {
        return new int();
      }
      [Token(Token = "0x6009A1F"), Address(RVA = "0x48F0FF4", Offset = "0x48F0FF4", VA = "0x48F0FF4")] set
      {
      }
    }

    [Token(Token = "0x6009A20")]
    [Address(RVA = "0x48F0FFC", Offset = "0x48F0FFC", VA = "0x48F0FFC")]
    public PlayerDeckType()
    {
    }
  }
}
