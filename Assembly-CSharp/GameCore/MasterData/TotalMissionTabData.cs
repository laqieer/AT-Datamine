// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.TotalMissionTabData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010B7")]
  [Serializable]
  public sealed class TotalMissionTabData : IMasterDataEntity
  {
    [Token(Token = "0x4005233")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005234")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int eventId;
    [Token(Token = "0x4005235")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int conditionTypeId;

    [Token(Token = "0x17000E65")]
    public int Key
    {
      [Token(Token = "0x60060AA"), Address(RVA = "0x28D96F4", Offset = "0x28D96F4", VA = "0x28D96F4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60060AB")]
    [Address(RVA = "0x28D96FC", Offset = "0x28D96FC", VA = "0x28D96FC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60060AC")]
    [Address(RVA = "0x28D9868", Offset = "0x28D9868", VA = "0x28D9868", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000E66")]
    public string TabName
    {
      [Token(Token = "0x60060AD"), Address(RVA = "0x28D98FC", Offset = "0x28D98FC", VA = "0x28D98FC")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60060AE")]
    [Address(RVA = "0x28D99D8", Offset = "0x28D99D8", VA = "0x28D99D8")]
    public TotalMissionTabData()
    {
    }
  }
}
