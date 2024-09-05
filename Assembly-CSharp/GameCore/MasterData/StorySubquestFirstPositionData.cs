// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StorySubquestFirstPositionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001307")]
  [Serializable]
  public sealed class StorySubquestFirstPositionData : IMasterDataEntity
  {
    [Token(Token = "0x4005A04")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005A05")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int chapter;
    [Token(Token = "0x4005A06")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int eventId;
    [Token(Token = "0x4005A07")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string positionName;
    [Token(Token = "0x4005A08")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public float posX;
    [Token(Token = "0x4005A09")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public float posY;

    [Token(Token = "0x1700103B")]
    public int Key
    {
      [Token(Token = "0x6006B77"), Address(RVA = "0x48E289C", Offset = "0x48E289C", VA = "0x48E289C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006B78")]
    [Address(RVA = "0x48E28A4", Offset = "0x48E28A4", VA = "0x48E28A4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006B79")]
    [Address(RVA = "0x48E2B30", Offset = "0x48E2B30", VA = "0x48E2B30", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006B7A")]
    [Address(RVA = "0x48E2BF8", Offset = "0x48E2BF8", VA = "0x48E2BF8")]
    public StorySubquestFirstPositionData()
    {
    }
  }
}
