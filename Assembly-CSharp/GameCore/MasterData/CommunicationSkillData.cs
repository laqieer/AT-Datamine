// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.CommunicationSkillData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200136D")]
  [Serializable]
  public sealed class CommunicationSkillData : IMasterDataEntity
  {
    [Token(Token = "0x4005B1E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005B1F")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int characterID;
    [Token(Token = "0x4005B20")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int skillID;

    [Token(Token = "0x17001078")]
    public int Key
    {
      [Token(Token = "0x6006D5E"), Address(RVA = "0x46FC320", Offset = "0x46FC320", VA = "0x46FC320", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006D5F")]
    [Address(RVA = "0x46FC328", Offset = "0x46FC328", VA = "0x46FC328", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006D60")]
    [Address(RVA = "0x46FC494", Offset = "0x46FC494", VA = "0x46FC494", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006D61")]
    [Address(RVA = "0x46FC528", Offset = "0x46FC528", VA = "0x46FC528")]
    public CommunicationSkillData()
    {
    }
  }
}
