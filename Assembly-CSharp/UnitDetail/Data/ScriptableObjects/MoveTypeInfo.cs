// Decompiled with JetBrains decompiler
// Type: UnitDetail.Data.ScriptableObjects.MoveTypeInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace UnitDetail.Data.ScriptableObjects
{
  [Token(Token = "0x20004D9")]
  [Serializable]
  public class MoveTypeInfo : FeatureBase
  {
    [Token(Token = "0x4001957")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private MoveTypeEnum moveTypeEnum;

    [Token(Token = "0x1700036E")]
    public MoveTypeEnum MoveTypeEnum
    {
      [Token(Token = "0x6001B9A"), Address(RVA = "0x2C2CC70", Offset = "0x2C2CC70", VA = "0x2C2CC70")] get
      {
        return new MoveTypeEnum();
      }
    }

    [Token(Token = "0x1700036F")]
    public override int Key
    {
      [Token(Token = "0x6001B9B"), Address(RVA = "0x2C2CC78", Offset = "0x2C2CC78", VA = "0x2C2CC78", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6001B9C")]
    [Address(RVA = "0x2C2CC80", Offset = "0x2C2CC80", VA = "0x2C2CC80")]
    public MoveTypeInfo()
    {
    }
  }
}
