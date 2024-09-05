// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AbilityBoardData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200135F")]
  [Serializable]
  public sealed class AbilityBoardData : IMasterDataEntity
  {
    [Token(Token = "0x4005B00")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005B01")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4005B02")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int formId;

    [Token(Token = "0x17001071")]
    public int Key
    {
      [Token(Token = "0x6006D1F"), Address(RVA = "0x46FA204", Offset = "0x46FA204", VA = "0x46FA204", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006D20")]
    [Address(RVA = "0x46FA20C", Offset = "0x46FA20C", VA = "0x46FA20C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006D21")]
    [Address(RVA = "0x46FA378", Offset = "0x46FA378", VA = "0x46FA378", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006D22")]
    [Address(RVA = "0x46FA410", Offset = "0x46FA410", VA = "0x46FA410")]
    public AbilityBoardData()
    {
    }
  }
}
