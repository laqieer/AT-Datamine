// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerCommunicationSkillType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A9E")]
  [Serializable]
  public class PlayerCommunicationSkillType
  {
    [Token(Token = "0x4007217")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int communication_skill_id;
    [Token(Token = "0x4007218")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int skill_level;

    [Token(Token = "0x17001A64")]
    public int CommunicationSkillId
    {
      [Token(Token = "0x60099E6"), Address(RVA = "0x48F0E28", Offset = "0x48F0E28", VA = "0x48F0E28")] get
      {
        return new int();
      }
      [Token(Token = "0x60099E7"), Address(RVA = "0x48F0E30", Offset = "0x48F0E30", VA = "0x48F0E30")] set
      {
      }
    }

    [Token(Token = "0x17001A65")]
    public int SkillLevel
    {
      [Token(Token = "0x60099E8"), Address(RVA = "0x48F0E38", Offset = "0x48F0E38", VA = "0x48F0E38")] get
      {
        return new int();
      }
      [Token(Token = "0x60099E9"), Address(RVA = "0x48F0E40", Offset = "0x48F0E40", VA = "0x48F0E40")] set
      {
      }
    }

    [Token(Token = "0x60099EA")]
    [Address(RVA = "0x48F0E48", Offset = "0x48F0E48", VA = "0x48F0E48")]
    public PlayerCommunicationSkillType()
    {
    }
  }
}
