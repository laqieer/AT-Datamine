// Decompiled with JetBrains decompiler
// Type: Network.Param.UpdatedPlayerUnits
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
  [Token(Token = "0x2001B19")]
  [Serializable]
  public class UpdatedPlayerUnits
  {
    [Token(Token = "0x4007483")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<PlayerUnitCharacterType> new_characters;
    [Token(Token = "0x4007484")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<PlayerUnitType> new_units;

    [Token(Token = "0x17001CE5")]
    public List<PlayerUnitCharacterType> NewCharacters
    {
      [Token(Token = "0x6009F4E"), Address(RVA = "0x46BE72C", Offset = "0x46BE72C", VA = "0x46BE72C")] get
      {
        return (List<PlayerUnitCharacterType>) null;
      }
      [Token(Token = "0x6009F4F"), Address(RVA = "0x46BE734", Offset = "0x46BE734", VA = "0x46BE734")] set
      {
      }
    }

    [Token(Token = "0x17001CE6")]
    public List<PlayerUnitType> NewUnits
    {
      [Token(Token = "0x6009F50"), Address(RVA = "0x46BE73C", Offset = "0x46BE73C", VA = "0x46BE73C")] get
      {
        return (List<PlayerUnitType>) null;
      }
      [Token(Token = "0x6009F51"), Address(RVA = "0x46BE744", Offset = "0x46BE744", VA = "0x46BE744")] set
      {
      }
    }

    [Token(Token = "0x6009F52")]
    [Address(RVA = "0x46BE74C", Offset = "0x46BE74C", VA = "0x46BE74C")]
    public UpdatedPlayerUnits()
    {
    }
  }
}
