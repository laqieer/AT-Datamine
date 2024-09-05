// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ExpeditionWeaponCoeffcicentData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FA0")]
  [Serializable]
  public sealed class ExpeditionWeaponCoeffcicentData : IMasterDataEntity
  {
    [Token(Token = "0x4004EC8")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004EC9")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int equipmentClassification;
    [Token(Token = "0x4004ECA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public ProficiencyTypeEnum proficiencyType;
    [Token(Token = "0x4004ECB")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public float powerCoefficient;
    [Token(Token = "0x4004ECC")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public float hitCoefficient;
    [Token(Token = "0x4004ECD")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public float avoidCoefficient;
    [Token(Token = "0x4004ECE")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public float criticalAvoidCoefficient;

    [Token(Token = "0x17000D8E")]
    public int Key
    {
      [Token(Token = "0x6005BC6"), Address(RVA = "0x2786158", Offset = "0x2786158", VA = "0x2786158", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005BC7")]
    [Address(RVA = "0x2786160", Offset = "0x2786160", VA = "0x2786160", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005BC8")]
    [Address(RVA = "0x278644C", Offset = "0x278644C", VA = "0x278644C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005BC9")]
    [Address(RVA = "0x2786520", Offset = "0x2786520", VA = "0x2786520")]
    public ExpeditionWeaponCoeffcicentData()
    {
    }
  }
}
