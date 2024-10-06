// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerStyleMasterBonusType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AEC")]
  [Serializable]
  public class PlayerStyleMasterBonusType
  {
    [Token(Token = "0x4007370")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int style_master_id;
    [Token(Token = "0x4007371")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int experience;

    [Token(Token = "0x17001BD2")]
    public int StyleMasterId
    {
      [Token(Token = "0x6009CFB"), Address(RVA = "0x48F2880", Offset = "0x48F2880", VA = "0x48F2880")] get
      {
        return new int();
      }
      [Token(Token = "0x6009CFC"), Address(RVA = "0x48F2888", Offset = "0x48F2888", VA = "0x48F2888")] set
      {
      }
    }

    [Token(Token = "0x17001BD3")]
    public int Experience
    {
      [Token(Token = "0x6009CFD"), Address(RVA = "0x48F2890", Offset = "0x48F2890", VA = "0x48F2890")] get
      {
        return new int();
      }
      [Token(Token = "0x6009CFE"), Address(RVA = "0x48F2898", Offset = "0x48F2898", VA = "0x48F2898")] set
      {
      }
    }

    [Token(Token = "0x6009CFF")]
    [Address(RVA = "0x48F28A0", Offset = "0x48F28A0", VA = "0x48F28A0")]
    public PlayerStyleMasterBonusType()
    {
    }
  }
}
