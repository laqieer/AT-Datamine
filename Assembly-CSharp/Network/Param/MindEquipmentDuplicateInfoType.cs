// Decompiled with JetBrains decompiler
// Type: Network.Param.MindEquipmentDuplicateInfoType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A76")]
  [Serializable]
  public class MindEquipmentDuplicateInfoType
  {
    [Token(Token = "0x400717D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string player_mind_equipment_id;
    [Token(Token = "0x400717E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int duplicate_count;

    [Token(Token = "0x170019C1")]
    public string PlayerMindEquipmentId
    {
      [Token(Token = "0x6009881"), Address(RVA = "0x48F01EC", Offset = "0x48F01EC", VA = "0x48F01EC")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009882"), Address(RVA = "0x48F01F4", Offset = "0x48F01F4", VA = "0x48F01F4")] set
      {
      }
    }

    [Token(Token = "0x170019C2")]
    public int DuplicateCount
    {
      [Token(Token = "0x6009883"), Address(RVA = "0x48F01FC", Offset = "0x48F01FC", VA = "0x48F01FC")] get
      {
        return new int();
      }
      [Token(Token = "0x6009884"), Address(RVA = "0x48F0204", Offset = "0x48F0204", VA = "0x48F0204")] set
      {
      }
    }

    [Token(Token = "0x6009885")]
    [Address(RVA = "0x48F020C", Offset = "0x48F020C", VA = "0x48F020C")]
    public MindEquipmentDuplicateInfoType()
    {
    }
  }
}
