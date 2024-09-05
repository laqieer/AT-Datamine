// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFreeActionBattleEnterLayoutData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001249")]
  [Serializable]
  public sealed class StoryFreeActionBattleEnterLayoutData : IMasterDataEntity
  {
    [Token(Token = "0x4005783")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005784")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int layoutLabelID;
    [Token(Token = "0x4005785")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int objectID;
    [Token(Token = "0x4005786")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public float positionOffsetX;
    [Token(Token = "0x4005787")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public float positionOffsetY;
    [Token(Token = "0x4005788")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public float positionOffsetZ;

    [Token(Token = "0x17000FB1")]
    public int Key
    {
      [Token(Token = "0x6006801"), Address(RVA = "0x4D34BD4", Offset = "0x4D34BD4", VA = "0x4D34BD4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006802")]
    [Address(RVA = "0x4D34BDC", Offset = "0x4D34BDC", VA = "0x4D34BDC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006803")]
    [Address(RVA = "0x4D34E68", Offset = "0x4D34E68", VA = "0x4D34E68", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006804")]
    [Address(RVA = "0x4D34F2C", Offset = "0x4D34F2C", VA = "0x4D34F2C")]
    public StoryFreeActionBattleEnterLayoutData()
    {
    }
  }
}
