// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.LobbyFreeActionLeaderUnitLayoutData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001085")]
  [Serializable]
  public sealed class LobbyFreeActionLeaderUnitLayoutData : IMasterDataEntity
  {
    [Token(Token = "0x40051A7")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40051A8")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int layoutGroupLabel;
    [Token(Token = "0x40051A9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int conditionID;
    [Token(Token = "0x40051AA")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string anchorName;
    [Token(Token = "0x40051AB")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int styleID;
    [Token(Token = "0x40051AC")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int characterPatternAssignID;
    [Token(Token = "0x40051AD")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public int objectRotationY;
    [Token(Token = "0x40051AE")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public float positionOffsetX;
    [Token(Token = "0x40051AF")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public float positionOffsetY;
    [Token(Token = "0x40051B0")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public float positionOffsetZ;

    [Token(Token = "0x17000E44")]
    public int Key
    {
      [Token(Token = "0x6005FCB"), Address(RVA = "0x28D1F78", Offset = "0x28D1F78", VA = "0x28D1F78", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005FCC")]
    [Address(RVA = "0x28D1F80", Offset = "0x28D1F80", VA = "0x28D1F80", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005FCD")]
    [Address(RVA = "0x28D238C", Offset = "0x28D238C", VA = "0x28D238C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005FCE")]
    [Address(RVA = "0x28D2494", Offset = "0x28D2494", VA = "0x28D2494")]
    public LobbyFreeActionLeaderUnitLayoutData()
    {
    }
  }
}
