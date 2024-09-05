// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerStoryBattleMissionLogType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AE3")]
  [Serializable]
  public class PlayerStoryBattleMissionLogType
  {
    [Token(Token = "0x4007351")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int sequence_id;
    [Token(Token = "0x4007352")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int story_battle_mission_id;

    [Token(Token = "0x17001BB3")]
    public int SequenceId
    {
      [Token(Token = "0x6009CB4"), Address(RVA = "0x48F2640", Offset = "0x48F2640", VA = "0x48F2640")] get
      {
        return new int();
      }
      [Token(Token = "0x6009CB5"), Address(RVA = "0x48F2648", Offset = "0x48F2648", VA = "0x48F2648")] set
      {
      }
    }

    [Token(Token = "0x17001BB4")]
    public int StoryBattleMissionId
    {
      [Token(Token = "0x6009CB6"), Address(RVA = "0x48F2650", Offset = "0x48F2650", VA = "0x48F2650")] get
      {
        return new int();
      }
      [Token(Token = "0x6009CB7"), Address(RVA = "0x48F2658", Offset = "0x48F2658", VA = "0x48F2658")] set
      {
      }
    }

    [Token(Token = "0x6009CB8")]
    [Address(RVA = "0x48F2660", Offset = "0x48F2660", VA = "0x48F2660")]
    public PlayerStoryBattleMissionLogType()
    {
    }
  }
}
