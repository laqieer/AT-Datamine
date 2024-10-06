// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AccessoryClassificationGroupData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001375")]
  [Serializable]
  public sealed class AccessoryClassificationGroupData : IMasterDataEntity
  {
    [Token(Token = "0x4005B2F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005B30")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;

    [Token(Token = "0x1700107C")]
    public int Key
    {
      [Token(Token = "0x6006D82"), Address(RVA = "0x46FD84C", Offset = "0x46FD84C", VA = "0x46FD84C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006D83")]
    [Address(RVA = "0x46FD854", Offset = "0x46FD854", VA = "0x46FD854", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006D84")]
    [Address(RVA = "0x46FD960", Offset = "0x46FD960", VA = "0x46FD960", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006D85")]
    [Address(RVA = "0x46FD9E8", Offset = "0x46FD9E8", VA = "0x46FD9E8")]
    public AccessoryClassificationGroupData()
    {
    }
  }
}
