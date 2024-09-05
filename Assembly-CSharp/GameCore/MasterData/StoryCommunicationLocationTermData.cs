// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryCommunicationLocationTermData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20011FC")]
  [Serializable]
  public sealed class StoryCommunicationLocationTermData : IMasterDataEntity
  {
    [Token(Token = "0x4005628")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005629")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int locationID;
    [Token(Token = "0x400562A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int routeID;
    [Token(Token = "0x400562B")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int termBegin;
    [Token(Token = "0x400562C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int termEnd;

    [Token(Token = "0x17000F7A")]
    public int Key
    {
      [Token(Token = "0x60066A4"), Address(RVA = "0x4D2751C", Offset = "0x4D2751C", VA = "0x4D2751C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60066A5")]
    [Address(RVA = "0x4D27524", Offset = "0x4D27524", VA = "0x4D27524", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60066A6")]
    [Address(RVA = "0x4D27750", Offset = "0x4D27750", VA = "0x4D27750", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60066A7")]
    [Address(RVA = "0x4D27804", Offset = "0x4D27804", VA = "0x4D27804")]
    public StoryCommunicationLocationTermData()
    {
    }
  }
}
