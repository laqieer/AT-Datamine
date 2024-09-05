// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.AreaQuestAreaNodeNormalDescriptionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010F2")]
  [Serializable]
  public sealed class AreaQuestAreaNodeNormalDescriptionData : IMasterDataEntity
  {
    [Token(Token = "0x40052CC")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40052CD")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int areaNodeNormalId;
    [Token(Token = "0x40052CE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public AreaNodeNormalDescriptionTypeEnum areaNodeNormalDescriptionType;
    [Token(Token = "0x40052CF")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int areaNodeNormalDescriptionContentId;

    [Token(Token = "0x17000E89")]
    public int Key
    {
      [Token(Token = "0x60061AF"), Address(RVA = "0x28E33BC", Offset = "0x28E33BC", VA = "0x28E33BC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60061B0")]
    [Address(RVA = "0x28E33C4", Offset = "0x28E33C4", VA = "0x28E33C4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60061B1")]
    [Address(RVA = "0x28E3590", Offset = "0x28E3590", VA = "0x28E3590", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60061B2")]
    [Address(RVA = "0x28E3634", Offset = "0x28E3634", VA = "0x28E3634")]
    public AreaQuestAreaNodeNormalDescriptionData()
    {
    }
  }
}
