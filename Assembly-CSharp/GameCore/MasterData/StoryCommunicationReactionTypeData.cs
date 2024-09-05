// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryCommunicationReactionTypeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001209")]
  [Serializable]
  public sealed class StoryCommunicationReactionTypeData : IMasterDataEntity
  {
    [Token(Token = "0x4005656")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005657")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;

    [Token(Token = "0x17000F81")]
    public int Key
    {
      [Token(Token = "0x60066DF"), Address(RVA = "0x4D29B90", Offset = "0x4D29B90", VA = "0x4D29B90", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60066E0")]
    [Address(RVA = "0x4D29B98", Offset = "0x4D29B98", VA = "0x4D29B98", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60066E1")]
    [Address(RVA = "0x4D29CA4", Offset = "0x4D29CA4", VA = "0x4D29CA4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60066E2")]
    [Address(RVA = "0x4D29D2C", Offset = "0x4D29D2C", VA = "0x4D29D2C")]
    public StoryCommunicationReactionTypeData()
    {
    }
  }
}
