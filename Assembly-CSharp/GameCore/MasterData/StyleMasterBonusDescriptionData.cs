// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StyleMasterBonusDescriptionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010CC")]
  [Serializable]
  public sealed class StyleMasterBonusDescriptionData : IMasterDataEntity
  {
    [Token(Token = "0x4005268")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005269")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int styleMasterBonusCategory;
    [Token(Token = "0x400526A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int level;
    [Token(Token = "0x400526B")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int physicalDamage;
    [Token(Token = "0x400526C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int magicDamage;
    [Token(Token = "0x400526D")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int takenPhysicalDamage;
    [Token(Token = "0x400526E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int takenMagicDamage;
    [Token(Token = "0x400526F")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int takenHit;
    [Token(Token = "0x4005270")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int hit;
    [Token(Token = "0x4005271")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public int critical;
    [Token(Token = "0x4005272")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public int takenCritical;
    [Token(Token = "0x4005273")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public int hp;

    [Token(Token = "0x17000E7A")]
    public int Key
    {
      [Token(Token = "0x6006117"), Address(RVA = "0x28DD1F8", Offset = "0x28DD1F8", VA = "0x28DD1F8", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006118")]
    [Address(RVA = "0x28DD200", Offset = "0x28DD200", VA = "0x28DD200", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006119")]
    [Address(RVA = "0x28DD6CC", Offset = "0x28DD6CC", VA = "0x28DD6CC", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600611A")]
    [Address(RVA = "0x28DD7F0", Offset = "0x28DD7F0", VA = "0x28DD7F0")]
    public StyleMasterBonusDescriptionData()
    {
    }
  }
}
