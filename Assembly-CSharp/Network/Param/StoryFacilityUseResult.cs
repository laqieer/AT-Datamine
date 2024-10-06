// Decompiled with JetBrains decompiler
// Type: Network.Param.StoryFacilityUseResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001B11")]
  [Serializable]
  public class StoryFacilityUseResult
  {
    [Token(Token = "0x400743F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private bool failed;
    [Token(Token = "0x4007440")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int target_communication_id;
    [Token(Token = "0x4007441")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int target_work_id;

    [Token(Token = "0x17001CA1")]
    public bool Failed
    {
      [Token(Token = "0x6009EBE"), Address(RVA = "0x48F36D0", Offset = "0x48F36D0", VA = "0x48F36D0")] get
      {
        return new bool();
      }
      [Token(Token = "0x6009EBF"), Address(RVA = "0x48F36D8", Offset = "0x48F36D8", VA = "0x48F36D8")] set
      {
      }
    }

    [Token(Token = "0x17001CA2")]
    public int TargetCommunicationId
    {
      [Token(Token = "0x6009EC0"), Address(RVA = "0x48F36E4", Offset = "0x48F36E4", VA = "0x48F36E4")] get
      {
        return new int();
      }
      [Token(Token = "0x6009EC1"), Address(RVA = "0x48F36EC", Offset = "0x48F36EC", VA = "0x48F36EC")] set
      {
      }
    }

    [Token(Token = "0x17001CA3")]
    public int TargetWorkId
    {
      [Token(Token = "0x6009EC2"), Address(RVA = "0x48F36F4", Offset = "0x48F36F4", VA = "0x48F36F4")] get
      {
        return new int();
      }
      [Token(Token = "0x6009EC3"), Address(RVA = "0x48F36FC", Offset = "0x48F36FC", VA = "0x48F36FC")] set
      {
      }
    }

    [Token(Token = "0x6009EC4")]
    [Address(RVA = "0x48F3704", Offset = "0x48F3704", VA = "0x48F3704")]
    public StoryFacilityUseResult()
    {
    }
  }
}
