// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AbilityBoardRewardGroupData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001358")]
  [Serializable]
  public sealed class AbilityBoardRewardGroupData : IMasterDataEntity
  {
    [Token(Token = "0x4005AE7")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005AE8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4005AE9")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string nodeName;
    [Token(Token = "0x4005AEA")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public string explanation;
    [Token(Token = "0x4005AEB")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int allocationType;

    [Token(Token = "0x1700106E")]
    public int Key
    {
      [Token(Token = "0x6006CFD"), Address(RVA = "0x46F883C", Offset = "0x46F883C", VA = "0x46F883C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006CFE")]
    [Address(RVA = "0x46F8844", Offset = "0x46F8844", VA = "0x46F8844", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006CFF")]
    [Address(RVA = "0x46F8A70", Offset = "0x46F8A70", VA = "0x46F8A70", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006D00")]
    [Address(RVA = "0x46F8B30", Offset = "0x46F8B30", VA = "0x46F8B30")]
    public AbilityBoardRewardGroupData()
    {
    }
  }
}
