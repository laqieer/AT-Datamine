// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.HomeSeasonScheduleData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001027")]
  [Serializable]
  public sealed class HomeSeasonScheduleData : IMasterDataEntity
  {
    [Token(Token = "0x400503A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400503B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x400503C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public DateTime start;
    [Token(Token = "0x400503D")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public DateTime end;

    [Token(Token = "0x17000DDB")]
    public int Key
    {
      [Token(Token = "0x6005DFC"), Address(RVA = "0x2798E0C", Offset = "0x2798E0C", VA = "0x2798E0C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005DFD")]
    [Address(RVA = "0x2798E14", Offset = "0x2798E14", VA = "0x2798E14", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005DFE")]
    [Address(RVA = "0x2798FE0", Offset = "0x2798FE0", VA = "0x2798FE0", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005DFF")]
    [Address(RVA = "0x27990E0", Offset = "0x27990E0", VA = "0x27990E0")]
    public HomeSeasonScheduleData()
    {
    }
  }
}
