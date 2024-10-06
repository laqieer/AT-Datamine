// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ExpeditionStageOwnPlacementDescriptionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FB4")]
  [Serializable]
  public sealed class ExpeditionStageOwnPlacementDescriptionData : IMasterDataEntity
  {
    [Token(Token = "0x4004F07")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004F08")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int placementID;
    [Token(Token = "0x4004F09")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int x;
    [Token(Token = "0x4004F0A")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int y;
    [Token(Token = "0x4004F0B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int slotID;

    [Token(Token = "0x17000D98")]
    public int Key
    {
      [Token(Token = "0x6005C26"), Address(RVA = "0x27897F0", Offset = "0x27897F0", VA = "0x27897F0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005C27")]
    [Address(RVA = "0x27897F8", Offset = "0x27897F8", VA = "0x27897F8", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005C28")]
    [Address(RVA = "0x2789A24", Offset = "0x2789A24", VA = "0x2789A24", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005C29")]
    [Address(RVA = "0x2789AD8", Offset = "0x2789AD8", VA = "0x2789AD8")]
    public ExpeditionStageOwnPlacementDescriptionData()
    {
    }
  }
}
