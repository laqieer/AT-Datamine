// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryCommunicationGroupLabelData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011F2")]
  [Serializable]
  public sealed class StoryCommunicationGroupLabelData : IMasterDataEntity
  {
    [Token(Token = "0x4005611")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005612")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;

    [Token(Token = "0x17000F75")]
    public int Key
    {
      [Token(Token = "0x600667B"), Address(RVA = "0x4D26014", Offset = "0x4D26014", VA = "0x4D26014", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600667C")]
    [Address(RVA = "0x4D2601C", Offset = "0x4D2601C", VA = "0x4D2601C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600667D")]
    [Address(RVA = "0x4D26128", Offset = "0x4D26128", VA = "0x4D26128", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600667E")]
    [Address(RVA = "0x4D261B0", Offset = "0x4D261B0", VA = "0x4D261B0")]
    public StoryCommunicationGroupLabelData()
    {
    }
  }
}
