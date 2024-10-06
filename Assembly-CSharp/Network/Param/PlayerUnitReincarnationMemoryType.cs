// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerUnitReincarnationMemoryType
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
  [Token(Token = "0x2001AFE")]
  [Serializable]
  public class PlayerUnitReincarnationMemoryType
  {
    [Token(Token = "0x40073E7")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string player_unit_id;
    [Token(Token = "0x40073E8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<ReincarnationMemoryType> memories;

    [Token(Token = "0x17001C49")]
    public string PlayerUnitId
    {
      [Token(Token = "0x6009DFB"), Address(RVA = "0x48F308C", Offset = "0x48F308C", VA = "0x48F308C")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009DFC"), Address(RVA = "0x48F3094", Offset = "0x48F3094", VA = "0x48F3094")] set
      {
      }
    }

    [Token(Token = "0x17001C4A")]
    public List<ReincarnationMemoryType> Memories
    {
      [Token(Token = "0x6009DFD"), Address(RVA = "0x48F309C", Offset = "0x48F309C", VA = "0x48F309C")] get
      {
        return (List<ReincarnationMemoryType>) null;
      }
      [Token(Token = "0x6009DFE"), Address(RVA = "0x48F30A4", Offset = "0x48F30A4", VA = "0x48F30A4")] set
      {
      }
    }

    [Token(Token = "0x6009DFF")]
    [Address(RVA = "0x48F30AC", Offset = "0x48F30AC", VA = "0x48F30AC")]
    public PlayerUnitReincarnationMemoryType()
    {
    }
  }
}
