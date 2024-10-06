// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.SubEquipmentClassificationGroupData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001382")]
  [Serializable]
  public sealed class SubEquipmentClassificationGroupData : IMasterDataEntity
  {
    [Token(Token = "0x4005B4D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005B4E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;

    [Token(Token = "0x17001088")]
    public int Key
    {
      [Token(Token = "0x6006DC0"), Address(RVA = "0x46FF6DC", Offset = "0x46FF6DC", VA = "0x46FF6DC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006DC1")]
    [Address(RVA = "0x46FF6E4", Offset = "0x46FF6E4", VA = "0x46FF6E4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006DC2")]
    [Address(RVA = "0x46FF7F0", Offset = "0x46FF7F0", VA = "0x46FF7F0", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006DC3")]
    [Address(RVA = "0x46FF878", Offset = "0x46FF878", VA = "0x46FF878")]
    public SubEquipmentClassificationGroupData()
    {
    }
  }
}
