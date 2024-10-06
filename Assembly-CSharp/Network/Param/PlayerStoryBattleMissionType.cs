// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerStoryBattleMissionType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AE4")]
  [Serializable]
  public class PlayerStoryBattleMissionType
  {
    [Token(Token = "0x4007353")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int sequence_id;
    [Token(Token = "0x4007354")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int story_battle_mission_id;

    [Token(Token = "0x17001BB5")]
    public int SequenceId
    {
      [Token(Token = "0x6009CB9"), Address(RVA = "0x48F2668", Offset = "0x48F2668", VA = "0x48F2668")] get
      {
        return new int();
      }
      [Token(Token = "0x6009CBA"), Address(RVA = "0x48F2670", Offset = "0x48F2670", VA = "0x48F2670")] set
      {
      }
    }

    [Token(Token = "0x17001BB6")]
    public int StoryBattleMissionId
    {
      [Token(Token = "0x6009CBB"), Address(RVA = "0x48F2678", Offset = "0x48F2678", VA = "0x48F2678")] get
      {
        return new int();
      }
      [Token(Token = "0x6009CBC"), Address(RVA = "0x48F2680", Offset = "0x48F2680", VA = "0x48F2680")] set
      {
      }
    }

    [Token(Token = "0x6009CBD")]
    [Address(RVA = "0x48F2688", Offset = "0x48F2688", VA = "0x48F2688")]
    public PlayerStoryBattleMissionType()
    {
    }
  }
}
