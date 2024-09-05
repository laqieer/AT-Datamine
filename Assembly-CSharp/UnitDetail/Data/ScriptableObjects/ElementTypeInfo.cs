// Decompiled with JetBrains decompiler
// Type: UnitDetail.Data.ScriptableObjects.ElementTypeInfo
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
  [Token(Token = "0x20004D5")]
  [Serializable]
  public class ElementTypeInfo : FeatureBase
  {
    [Token(Token = "0x4001953")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ElementTypeEnum elementType;

    [Token(Token = "0x17000366")]
    public ElementTypeEnum ElementType
    {
      [Token(Token = "0x6001B8E"), Address(RVA = "0x2C2CC10", Offset = "0x2C2CC10", VA = "0x2C2CC10")] get
      {
        return new ElementTypeEnum();
      }
    }

    [Token(Token = "0x17000367")]
    public override int Key
    {
      [Token(Token = "0x6001B8F"), Address(RVA = "0x2C2CC18", Offset = "0x2C2CC18", VA = "0x2C2CC18", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6001B90")]
    [Address(RVA = "0x2C2CC20", Offset = "0x2C2CC20", VA = "0x2C2CC20")]
    public ElementTypeInfo()
    {
    }
  }
}
