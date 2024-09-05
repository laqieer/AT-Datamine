// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerBattleEnemyDrops
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
  [Token(Token = "0x2001A8E")]
  [Serializable]
  public class PlayerBattleEnemyDrops
  {
    [Token(Token = "0x40071CC")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<PlayerBattleEnemyDrop> drops;

    [Token(Token = "0x17001A10")]
    public List<PlayerBattleEnemyDrop> Drops
    {
      [Token(Token = "0x6009937"), Address(RVA = "0x48F07B8", Offset = "0x48F07B8", VA = "0x48F07B8")] get
      {
        return (List<PlayerBattleEnemyDrop>) null;
      }
      [Token(Token = "0x6009938"), Address(RVA = "0x48F07C0", Offset = "0x48F07C0", VA = "0x48F07C0")] set
      {
      }
    }

    [Token(Token = "0x6009939")]
    [Address(RVA = "0x48F07C8", Offset = "0x48F07C8", VA = "0x48F07C8")]
    public PlayerBattleEnemyDrops()
    {
    }
  }
}
