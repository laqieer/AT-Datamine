// Decompiled with JetBrains decompiler
// Type: Network.Param.DebugSerialInfoType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A50")]
  [Serializable]
  public class DebugSerialInfoType
  {
    [Token(Token = "0x4007084")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int campaign_id;
    [Token(Token = "0x4007085")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string common_code;
    [Token(Token = "0x4007086")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private bool is_accepted;

    [Token(Token = "0x170018BA")]
    public int CampaignId
    {
      [Token(Token = "0x600965A"), Address(RVA = "0x48EF10C", Offset = "0x48EF10C", VA = "0x48EF10C")] get
      {
        return new int();
      }
      [Token(Token = "0x600965B"), Address(RVA = "0x48EF114", Offset = "0x48EF114", VA = "0x48EF114")] set
      {
      }
    }

    [Token(Token = "0x170018BB")]
    public string CommonCode
    {
      [Token(Token = "0x600965C"), Address(RVA = "0x48EF11C", Offset = "0x48EF11C", VA = "0x48EF11C")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600965D"), Address(RVA = "0x48EF124", Offset = "0x48EF124", VA = "0x48EF124")] set
      {
      }
    }

    [Token(Token = "0x170018BC")]
    public bool IsAccepted
    {
      [Token(Token = "0x600965E"), Address(RVA = "0x48EF12C", Offset = "0x48EF12C", VA = "0x48EF12C")] get
      {
        return new bool();
      }
      [Token(Token = "0x600965F"), Address(RVA = "0x48EF134", Offset = "0x48EF134", VA = "0x48EF134")] set
      {
      }
    }

    [Token(Token = "0x6009660")]
    [Address(RVA = "0x48EF140", Offset = "0x48EF140", VA = "0x48EF140")]
    public DebugSerialInfoType()
    {
    }
  }
}
