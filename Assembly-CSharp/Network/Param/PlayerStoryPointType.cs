// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerStoryPointType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AEA")]
  [Serializable]
  public class PlayerStoryPointType
  {
    [Token(Token = "0x4007368")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int story_point_id;
    [Token(Token = "0x4007369")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int value;

    [Token(Token = "0x17001BCA")]
    public int StoryPointId
    {
      [Token(Token = "0x6009CE9"), Address(RVA = "0x48F27EC", Offset = "0x48F27EC", VA = "0x48F27EC")] get
      {
        return new int();
      }
      [Token(Token = "0x6009CEA"), Address(RVA = "0x48F27F4", Offset = "0x48F27F4", VA = "0x48F27F4")] set
      {
      }
    }

    [Token(Token = "0x17001BCB")]
    public int Value
    {
      [Token(Token = "0x6009CEB"), Address(RVA = "0x48F27FC", Offset = "0x48F27FC", VA = "0x48F27FC")] get
      {
        return new int();
      }
      [Token(Token = "0x6009CEC"), Address(RVA = "0x48F2804", Offset = "0x48F2804", VA = "0x48F2804")] set
      {
      }
    }

    [Token(Token = "0x6009CED")]
    [Address(RVA = "0x48F2808", Offset = "0x48F2808", VA = "0x48F2808")]
    public PlayerStoryPointType()
    {
    }
  }
}
