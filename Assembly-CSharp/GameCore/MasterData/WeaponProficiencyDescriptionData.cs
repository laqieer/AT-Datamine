// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.WeaponProficiencyDescriptionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001384")]
  [Serializable]
  public sealed class WeaponProficiencyDescriptionData : IMasterDataEntity
  {
    [Token(Token = "0x4005B50")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005B51")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int proficiency;
    [Token(Token = "0x4005B52")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public WeaponTypeEnum weaponType;
    [Token(Token = "0x4005B53")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public ProficiencyTypeEnum proficiencyType;

    [Token(Token = "0x17001089")]
    public int Key
    {
      [Token(Token = "0x6006DCB"), Address(RVA = "0x46FFC00", Offset = "0x46FFC00", VA = "0x46FFC00", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006DCC")]
    [Address(RVA = "0x46FFC08", Offset = "0x46FFC08", VA = "0x46FFC08", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006DCD")]
    [Address(RVA = "0x46FFDD4", Offset = "0x46FFDD4", VA = "0x46FFDD4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006DCE")]
    [Address(RVA = "0x46FFE78", Offset = "0x46FFE78", VA = "0x46FFE78")]
    public WeaponProficiencyDescriptionData()
    {
    }
  }
}
