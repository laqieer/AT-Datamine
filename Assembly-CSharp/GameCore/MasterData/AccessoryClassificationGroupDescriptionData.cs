// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AccessoryClassificationGroupDescriptionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001373")]
  [Serializable]
  public sealed class AccessoryClassificationGroupDescriptionData : IMasterDataEntity
  {
    [Token(Token = "0x4005B2C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005B2D")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int accessoryClassificationGroup;
    [Token(Token = "0x4005B2E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int accessoryClassification;

    [Token(Token = "0x1700107B")]
    public int Key
    {
      [Token(Token = "0x6006D7A"), Address(RVA = "0x46FD534", Offset = "0x46FD534", VA = "0x46FD534", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006D7B")]
    [Address(RVA = "0x46FD53C", Offset = "0x46FD53C", VA = "0x46FD53C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006D7C")]
    [Address(RVA = "0x46FD6A8", Offset = "0x46FD6A8", VA = "0x46FD6A8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006D7D")]
    [Address(RVA = "0x46FD73C", Offset = "0x46FD73C", VA = "0x46FD73C")]
    public AccessoryClassificationGroupDescriptionData()
    {
    }
  }
}
