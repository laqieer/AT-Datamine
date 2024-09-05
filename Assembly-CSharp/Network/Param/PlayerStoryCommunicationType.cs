// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerStoryCommunicationType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AE7")]
  [Serializable]
  public class PlayerStoryCommunicationType
  {
    [Token(Token = "0x400735C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int communication_id;
    [Token(Token = "0x400735D")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private bool is_opened;
    [Token(Token = "0x400735E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int rank;
    [Token(Token = "0x400735F")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private int relationship_point;
    [Token(Token = "0x4007360")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private int max_rank;

    [Token(Token = "0x17001BBE")]
    public int CommunicationId
    {
      [Token(Token = "0x6009CCE"), Address(RVA = "0x48F2714", Offset = "0x48F2714", VA = "0x48F2714")] get
      {
        return new int();
      }
      [Token(Token = "0x6009CCF"), Address(RVA = "0x48F271C", Offset = "0x48F271C", VA = "0x48F271C")] set
      {
      }
    }

    [Token(Token = "0x17001BBF")]
    public bool IsOpened
    {
      [Token(Token = "0x6009CD0"), Address(RVA = "0x48F2724", Offset = "0x48F2724", VA = "0x48F2724")] get
      {
        return new bool();
      }
      [Token(Token = "0x6009CD1"), Address(RVA = "0x48F272C", Offset = "0x48F272C", VA = "0x48F272C")] set
      {
      }
    }

    [Token(Token = "0x17001BC0")]
    public int Rank
    {
      [Token(Token = "0x6009CD2"), Address(RVA = "0x48F2738", Offset = "0x48F2738", VA = "0x48F2738")] get
      {
        return new int();
      }
      [Token(Token = "0x6009CD3"), Address(RVA = "0x48F2740", Offset = "0x48F2740", VA = "0x48F2740")] set
      {
      }
    }

    [Token(Token = "0x17001BC1")]
    public int RelationshipPoint
    {
      [Token(Token = "0x6009CD4"), Address(RVA = "0x48F2748", Offset = "0x48F2748", VA = "0x48F2748")] get
      {
        return new int();
      }
      [Token(Token = "0x6009CD5"), Address(RVA = "0x48F2750", Offset = "0x48F2750", VA = "0x48F2750")] set
      {
      }
    }

    [Token(Token = "0x17001BC2")]
    public int MaxRank
    {
      [Token(Token = "0x6009CD6"), Address(RVA = "0x48F2758", Offset = "0x48F2758", VA = "0x48F2758")] get
      {
        return new int();
      }
      [Token(Token = "0x6009CD7"), Address(RVA = "0x48F2760", Offset = "0x48F2760", VA = "0x48F2760")] set
      {
      }
    }

    [Token(Token = "0x6009CD8")]
    [Address(RVA = "0x48F2768", Offset = "0x48F2768", VA = "0x48F2768")]
    public PlayerStoryCommunicationType()
    {
    }
  }
}
