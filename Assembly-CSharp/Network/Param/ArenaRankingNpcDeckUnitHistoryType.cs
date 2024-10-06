// Decompiled with JetBrains decompiler
// Type: Network.Param.ArenaRankingNpcDeckUnitHistoryType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A41")]
  [Serializable]
  public class ArenaRankingNpcDeckUnitHistoryType
  {
    [Token(Token = "0x400704C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int position_id;
    [Token(Token = "0x400704D")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int damage;

    [Token(Token = "0x17001882")]
    public int PositionId
    {
      [Token(Token = "0x60095DB"), Address(RVA = "0x48EED00", Offset = "0x48EED00", VA = "0x48EED00")] get
      {
        return new int();
      }
      [Token(Token = "0x60095DC"), Address(RVA = "0x48EED08", Offset = "0x48EED08", VA = "0x48EED08")] set
      {
      }
    }

    [Token(Token = "0x17001883")]
    public int Damage
    {
      [Token(Token = "0x60095DD"), Address(RVA = "0x48EED10", Offset = "0x48EED10", VA = "0x48EED10")] get
      {
        return new int();
      }
      [Token(Token = "0x60095DE"), Address(RVA = "0x48EED18", Offset = "0x48EED18", VA = "0x48EED18")] set
      {
      }
    }

    [Token(Token = "0x60095DF")]
    [Address(RVA = "0x48EED20", Offset = "0x48EED20", VA = "0x48EED20")]
    public ArenaRankingNpcDeckUnitHistoryType()
    {
    }
  }
}
