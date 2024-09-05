// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerEquipmentSkillEnhanceItemType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AA5")]
  [Serializable]
  public class PlayerEquipmentSkillEnhanceItemType
  {
    [Token(Token = "0x4007237")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int item_id;
    [Token(Token = "0x4007238")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int stack_count;

    [Token(Token = "0x17001A84")]
    public int ItemId
    {
      [Token(Token = "0x6009A2D"), Address(RVA = "0x48F1064", Offset = "0x48F1064", VA = "0x48F1064")] get
      {
        return new int();
      }
      [Token(Token = "0x6009A2E"), Address(RVA = "0x48F106C", Offset = "0x48F106C", VA = "0x48F106C")] set
      {
      }
    }

    [Token(Token = "0x17001A85")]
    public int StackCount
    {
      [Token(Token = "0x6009A2F"), Address(RVA = "0x48F1074", Offset = "0x48F1074", VA = "0x48F1074")] get
      {
        return new int();
      }
      [Token(Token = "0x6009A30"), Address(RVA = "0x48F107C", Offset = "0x48F107C", VA = "0x48F107C")] set
      {
      }
    }

    [Token(Token = "0x6009A31")]
    [Address(RVA = "0x48F1084", Offset = "0x48F1084", VA = "0x48F1084")]
    public PlayerEquipmentSkillEnhanceItemType()
    {
    }
  }
}
