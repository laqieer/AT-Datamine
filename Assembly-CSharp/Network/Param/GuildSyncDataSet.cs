// Decompiled with JetBrains decompiler
// Type: Network.Param.GuildSyncDataSet
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
  [Token(Token = "0x2001A6D")]
  [Serializable]
  public class GuildSyncDataSet
  {
    [Token(Token = "0x400715D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GuildType guild;
    [Token(Token = "0x400715E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<GuildMemberType> members;

    [Token(Token = "0x17001994")]
    public GuildType Guild
    {
      [Token(Token = "0x600982A"), Address(RVA = "0x48EFFB8", Offset = "0x48EFFB8", VA = "0x48EFFB8")] get
      {
        return (GuildType) null;
      }
      [Token(Token = "0x600982B"), Address(RVA = "0x48EFFC0", Offset = "0x48EFFC0", VA = "0x48EFFC0")] set
      {
      }
    }

    [Token(Token = "0x17001995")]
    public List<GuildMemberType> Members
    {
      [Token(Token = "0x600982C"), Address(RVA = "0x48EFFC8", Offset = "0x48EFFC8", VA = "0x48EFFC8")] get
      {
        return (List<GuildMemberType>) null;
      }
      [Token(Token = "0x600982D"), Address(RVA = "0x48EFFD0", Offset = "0x48EFFD0", VA = "0x48EFFD0")] set
      {
      }
    }

    [Token(Token = "0x600982E")]
    [Address(RVA = "0x48EFFD8", Offset = "0x48EFFD8", VA = "0x48EFFD8")]
    public GuildSyncDataSet()
    {
    }
  }
}
