// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.QuestMapPositionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001129")]
  [Serializable]
  public sealed class QuestMapPositionData : IMasterDataEntity
  {
    [Token(Token = "0x4005391")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005392")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string referenceName;
    [Token(Token = "0x4005393")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public float positionX;
    [Token(Token = "0x4005394")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public float positionY;
    [Token(Token = "0x4005395")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int landmarkResourceId;
    [Token(Token = "0x4005396")]
    public const string TEXT_AB = "text_masterdata_quest";

    [Token(Token = "0x17000EC5")]
    public int Key
    {
      [Token(Token = "0x60062C4"), Address(RVA = "0x4AE2840", Offset = "0x4AE2840", VA = "0x4AE2840", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60062C5")]
    [Address(RVA = "0x4AE2848", Offset = "0x4AE2848", VA = "0x4AE2848", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60062C6")]
    [Address(RVA = "0x4AE2A74", Offset = "0x4AE2A74", VA = "0x4AE2A74", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000EC6")]
    public string Name
    {
      [Token(Token = "0x60062C7"), Address(RVA = "0x4AE2B2C", Offset = "0x4AE2B2C", VA = "0x4AE2B2C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60062C8")]
    [Address(RVA = "0x4AE2C08", Offset = "0x4AE2C08", VA = "0x4AE2C08")]
    public QuestMapPositionData()
    {
    }
  }
}
