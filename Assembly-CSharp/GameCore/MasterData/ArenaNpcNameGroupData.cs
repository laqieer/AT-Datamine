// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ArenaNpcNameGroupData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DDF")]
  [Serializable]
  public sealed class ArenaNpcNameGroupData : IMasterDataEntity
  {
    [Token(Token = "0x4004267")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004268")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int nameGroup;
    [Token(Token = "0x4004269")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;

    [Token(Token = "0x17000C2F")]
    public int Key
    {
      [Token(Token = "0x60054BE"), Address(RVA = "0x3AA7A90", Offset = "0x3AA7A90", VA = "0x3AA7A90", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60054BF")]
    [Address(RVA = "0x3AA7A98", Offset = "0x3AA7A98", VA = "0x3AA7A98", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60054C0")]
    [Address(RVA = "0x3AA7C04", Offset = "0x3AA7C04", VA = "0x3AA7C04", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60054C1")]
    [Address(RVA = "0x3AA7C9C", Offset = "0x3AA7C9C", VA = "0x3AA7C9C")]
    public ArenaNpcNameGroupData()
    {
    }
  }
}
