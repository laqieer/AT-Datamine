// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerExpeditionStageBossPartyUnitType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AAD")]
  [Serializable]
  public class PlayerExpeditionStageBossPartyUnitType
  {
    [Token(Token = "0x400724F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string id;
    [Token(Token = "0x4007250")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int stage_id;
    [Token(Token = "0x4007251")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private int slot;
    [Token(Token = "0x4007252")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string player_unit_id;

    [Token(Token = "0x17001A9C")]
    public string Id
    {
      [Token(Token = "0x6009A65"), Address(RVA = "0x48F1224", Offset = "0x48F1224", VA = "0x48F1224")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009A66"), Address(RVA = "0x48F122C", Offset = "0x48F122C", VA = "0x48F122C")] set
      {
      }
    }

    [Token(Token = "0x17001A9D")]
    public int StageId
    {
      [Token(Token = "0x6009A67"), Address(RVA = "0x48F1234", Offset = "0x48F1234", VA = "0x48F1234")] get
      {
        return new int();
      }
      [Token(Token = "0x6009A68"), Address(RVA = "0x48F123C", Offset = "0x48F123C", VA = "0x48F123C")] set
      {
      }
    }

    [Token(Token = "0x17001A9E")]
    public int Slot
    {
      [Token(Token = "0x6009A69"), Address(RVA = "0x48F1244", Offset = "0x48F1244", VA = "0x48F1244")] get
      {
        return new int();
      }
      [Token(Token = "0x6009A6A"), Address(RVA = "0x48F124C", Offset = "0x48F124C", VA = "0x48F124C")] set
      {
      }
    }

    [Token(Token = "0x17001A9F")]
    public string PlayerUnitId
    {
      [Token(Token = "0x6009A6B"), Address(RVA = "0x48F1254", Offset = "0x48F1254", VA = "0x48F1254")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009A6C"), Address(RVA = "0x48F125C", Offset = "0x48F125C", VA = "0x48F125C")] set
      {
      }
    }

    [Token(Token = "0x6009A6D")]
    [Address(RVA = "0x48F1264", Offset = "0x48F1264", VA = "0x48F1264")]
    public PlayerExpeditionStageBossPartyUnitType()
    {
    }
  }
}
