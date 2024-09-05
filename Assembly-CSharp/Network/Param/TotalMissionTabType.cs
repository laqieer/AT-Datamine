// Decompiled with JetBrains decompiler
// Type: Network.Param.TotalMissionTabType
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
  [Token(Token = "0x2001B13")]
  [Serializable]
  public class TotalMissionTabType
  {
    [Token(Token = "0x4007449")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int tab_id;
    [Token(Token = "0x400744A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private long value;
    [Token(Token = "0x400744B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<int> accepted_mission_ids;

    [Token(Token = "0x17001CAB")]
    public int TabId
    {
      [Token(Token = "0x6009ED4"), Address(RVA = "0x48F3788", Offset = "0x48F3788", VA = "0x48F3788")] get
      {
        return new int();
      }
      [Token(Token = "0x6009ED5"), Address(RVA = "0x48F3790", Offset = "0x48F3790", VA = "0x48F3790")] set
      {
      }
    }

    [Token(Token = "0x17001CAC")]
    public long Value
    {
      [Token(Token = "0x6009ED6"), Address(RVA = "0x48F3798", Offset = "0x48F3798", VA = "0x48F3798")] get
      {
        return new long();
      }
      [Token(Token = "0x6009ED7"), Address(RVA = "0x48F37A0", Offset = "0x48F37A0", VA = "0x48F37A0")] set
      {
      }
    }

    [Token(Token = "0x17001CAD")]
    public List<int> AcceptedMissionIds
    {
      [Token(Token = "0x6009ED8"), Address(RVA = "0x48F37A4", Offset = "0x48F37A4", VA = "0x48F37A4")] get
      {
        return (List<int>) null;
      }
      [Token(Token = "0x6009ED9"), Address(RVA = "0x48F37AC", Offset = "0x48F37AC", VA = "0x48F37AC")] set
      {
      }
    }

    [Token(Token = "0x6009EDA")]
    [Address(RVA = "0x48F37B4", Offset = "0x48F37B4", VA = "0x48F37B4")]
    public TotalMissionTabType()
    {
    }
  }
}
