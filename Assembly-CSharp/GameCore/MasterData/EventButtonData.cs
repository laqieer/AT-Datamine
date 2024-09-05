// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.EventButtonData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001020")]
  [Serializable]
  public sealed class EventButtonData : IMasterDataEntity
  {
    [Token(Token = "0x4005021")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005022")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public ButtonFunctionTypeEnum functionType;
    [Token(Token = "0x4005023")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int functionID;
    [Token(Token = "0x4005024")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string path;
    [Token(Token = "0x4005025")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public DateTime startAt;
    [Token(Token = "0x4005026")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public DateTime endAt;

    [Token(Token = "0x17000DD5")]
    public int Key
    {
      [Token(Token = "0x6005DD9"), Address(RVA = "0x27976A4", Offset = "0x27976A4", VA = "0x27976A4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005DDA")]
    [Address(RVA = "0x27976AC", Offset = "0x27976AC", VA = "0x27976AC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005DDB")]
    [Address(RVA = "0x2797938", Offset = "0x2797938", VA = "0x2797938", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000DD6")]
    public string Title
    {
      [Token(Token = "0x6005DDC"), Address(RVA = "0x2797A58", Offset = "0x2797A58", VA = "0x2797A58")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6005DDD")]
    [Address(RVA = "0x2797B34", Offset = "0x2797B34", VA = "0x2797B34")]
    public EventButtonData()
    {
    }
  }
}
