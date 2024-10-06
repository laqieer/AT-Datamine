// Decompiled with JetBrains decompiler
// Type: Network.Param.None
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
  [Token(Token = "0x2001A77")]
  [Serializable]
  public class None
  {
    [Token(Token = "0x400717F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<int> killed_enemy_ids;

    [Token(Token = "0x170019C3")]
    public List<int> KilledEnemyIds
    {
      [Token(Token = "0x6009886"), Address(RVA = "0x48F0214", Offset = "0x48F0214", VA = "0x48F0214")] get
      {
        return (List<int>) null;
      }
      [Token(Token = "0x6009887"), Address(RVA = "0x48F021C", Offset = "0x48F021C", VA = "0x48F021C")] set
      {
      }
    }

    [Token(Token = "0x6009888")]
    [Address(RVA = "0x48F0224", Offset = "0x48F0224", VA = "0x48F0224")]
    public None()
    {
    }
  }
}
