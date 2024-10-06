// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.WeaponProficiencyLevelData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200138A")]
  [Serializable]
  public sealed class WeaponProficiencyLevelData : IMasterDataEntity
  {
    [Token(Token = "0x4005B5B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005B5C")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public ProficiencyTypeEnum proficiencyType;
    [Token(Token = "0x4005B5D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int from;
    [Token(Token = "0x4005B5E")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int to;

    [Token(Token = "0x1700108A")]
    public int Key
    {
      [Token(Token = "0x6006DE3"), Address(RVA = "0x47008E4", Offset = "0x47008E4", VA = "0x47008E4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006DE4")]
    [Address(RVA = "0x47008EC", Offset = "0x47008EC", VA = "0x47008EC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006DE5")]
    [Address(RVA = "0x4700AB8", Offset = "0x4700AB8", VA = "0x4700AB8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006DE6")]
    [Address(RVA = "0x4700B5C", Offset = "0x4700B5C", VA = "0x4700B5C")]
    public WeaponProficiencyLevelData()
    {
    }
  }
}
