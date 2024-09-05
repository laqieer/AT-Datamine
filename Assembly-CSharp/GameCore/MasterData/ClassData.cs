// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ClassData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200137B")]
  [Serializable]
  public sealed class ClassData : IMasterDataEntity
  {
    [Token(Token = "0x4005B3A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005B3B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4005B3C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int army;
    [Token(Token = "0x4005B3D")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int footsteps;
    [Token(Token = "0x4005B3E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int mainEquipmentClassification;
    [Token(Token = "0x4005B3F")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int subEquipmentClassificationGroup;
    [Token(Token = "0x4005B40")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int accessoryClassificationGroup;
    [Token(Token = "0x4005B41")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int maxProficiency;

    [Token(Token = "0x1700107F")]
    public int Key
    {
      [Token(Token = "0x6006D9B"), Address(RVA = "0x46FE25C", Offset = "0x46FE25C", VA = "0x46FE25C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006D9C")]
    [Address(RVA = "0x46FE264", Offset = "0x46FE264", VA = "0x46FE264", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006D9D")]
    [Address(RVA = "0x46FE5B0", Offset = "0x46FE5B0", VA = "0x46FE5B0", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17001080")]
    public string Name
    {
      [Token(Token = "0x6006D9E"), Address(RVA = "0x46FE698", Offset = "0x46FE698", VA = "0x46FE698")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001081")]
    public string EnglishName
    {
      [Token(Token = "0x6006D9F"), Address(RVA = "0x46FE774", Offset = "0x46FE774", VA = "0x46FE774")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001082")]
    public string Flavor
    {
      [Token(Token = "0x6006DA0"), Address(RVA = "0x46FE850", Offset = "0x46FE850", VA = "0x46FE850")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6006DA1")]
    [Address(RVA = "0x46FE92C", Offset = "0x46FE92C", VA = "0x46FE92C")]
    public ClassData()
    {
    }
  }
}
