// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AbilityboardCustomBNodeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001344")]
  [Serializable]
  public sealed class AbilityboardCustomBNodeData : IMasterDataEntity
  {
    [Token(Token = "0x4005ABC")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005ABD")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int customBID;
    [Token(Token = "0x4005ABE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int rotteryRewardType;
    [Token(Token = "0x4005ABF")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int minValue;
    [Token(Token = "0x4005AC0")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int maxMagnification;

    [Token(Token = "0x17001065")]
    public int Key
    {
      [Token(Token = "0x6006CA7"), Address(RVA = "0x46F5C4C", Offset = "0x46F5C4C", VA = "0x46F5C4C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006CA8")]
    [Address(RVA = "0x46F5C54", Offset = "0x46F5C54", VA = "0x46F5C54", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006CA9")]
    [Address(RVA = "0x46F5E80", Offset = "0x46F5E80", VA = "0x46F5E80", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006CAA")]
    [Address(RVA = "0x46F5F34", Offset = "0x46F5F34", VA = "0x46F5F34")]
    public AbilityboardCustomBNodeData()
    {
    }
  }
}
