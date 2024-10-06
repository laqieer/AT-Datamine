// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ArmorData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001377")]
  [Serializable]
  public sealed class ArmorData : IMasterDataEntity
  {
    [Token(Token = "0x4005B31")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005B32")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4005B33")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public ArmorTypeEnum type;
    [Token(Token = "0x4005B34")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int mobility;

    [Token(Token = "0x1700107D")]
    public int Key
    {
      [Token(Token = "0x6006D8A"), Address(RVA = "0x46FDAF8", Offset = "0x46FDAF8", VA = "0x46FDAF8", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006D8B")]
    [Address(RVA = "0x46FDB00", Offset = "0x46FDB00", VA = "0x46FDB00", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006D8C")]
    [Address(RVA = "0x46FDCCC", Offset = "0x46FDCCC", VA = "0x46FDCCC", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006D8D")]
    [Address(RVA = "0x46FDD74", Offset = "0x46FDD74", VA = "0x46FDD74")]
    public ArmorData()
    {
    }
  }
}
