// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ArmyData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001379")]
  [Serializable]
  public sealed class ArmyData : IMasterDataEntity
  {
    [Token(Token = "0x4005B35")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005B36")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int move;
    [Token(Token = "0x4005B37")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int armor;
    [Token(Token = "0x4005B38")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public RideTypeEnum ride;

    [Token(Token = "0x1700107E")]
    public int Key
    {
      [Token(Token = "0x6006D93"), Address(RVA = "0x46FDED4", Offset = "0x46FDED4", VA = "0x46FDED4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006D94")]
    [Address(RVA = "0x46FDEDC", Offset = "0x46FDEDC", VA = "0x46FDEDC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006D95")]
    [Address(RVA = "0x46FE0A8", Offset = "0x46FE0A8", VA = "0x46FE0A8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006D96")]
    [Address(RVA = "0x46FE14C", Offset = "0x46FE14C", VA = "0x46FE14C")]
    public ArmyData()
    {
    }
  }
}
