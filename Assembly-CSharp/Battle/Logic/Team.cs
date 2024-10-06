// Decompiled with JetBrains decompiler
// Type: Battle.Logic.Team
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Battle.Logic
{
  [Token(Token = "0x20024E7")]
  public class Team : ITargettable
  {
    [Token(Token = "0x170030B6")]
    public TargetPair Front
    {
      [Token(Token = "0x600E369"), Address(RVA = "0x4029CB4", Offset = "0x4029CB4", VA = "0x4029CB4")] get
      {
        return (TargetPair) null;
      }
      [Token(Token = "0x600E36A"), Address(RVA = "0x4029CBC", Offset = "0x4029CBC", VA = "0x4029CBC")] private set
      {
      }
    }

    [Token(Token = "0x170030B7")]
    public List<Vector2Int> Coordinates
    {
      [Token(Token = "0x600E36B"), Address(RVA = "0x4029CC4", Offset = "0x4029CC4", VA = "0x4029CC4", Slot = "4")] get
      {
        return (List<Vector2Int>) null;
      }
    }

    [Token(Token = "0x600E36C")]
    [Address(RVA = "0x4029DD4", Offset = "0x4029DD4", VA = "0x4029DD4")]
    public Team(TargetPair front)
    {
    }
  }
}
