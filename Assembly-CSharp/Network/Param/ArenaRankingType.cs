// Decompiled with JetBrains decompiler
// Type: Network.Param.ArenaRankingType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A42")]
  [Serializable]
  public class ArenaRankingType
  {
    [Token(Token = "0x400704E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int ranking;

    [Token(Token = "0x17001884")]
    public int Ranking
    {
      [Token(Token = "0x60095E0"), Address(RVA = "0x48EED28", Offset = "0x48EED28", VA = "0x48EED28")] get
      {
        return new int();
      }
      [Token(Token = "0x60095E1"), Address(RVA = "0x48EED30", Offset = "0x48EED30", VA = "0x48EED30")] set
      {
      }
    }

    [Token(Token = "0x60095E2")]
    [Address(RVA = "0x48EED38", Offset = "0x48EED38", VA = "0x48EED38")]
    public ArenaRankingType()
    {
    }
  }
}
