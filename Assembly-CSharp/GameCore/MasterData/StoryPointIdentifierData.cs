// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryPointIdentifierData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20012EE")]
  [Serializable]
  public sealed class StoryPointIdentifierData : IMasterDataEntity
  {
    [Token(Token = "0x40059B0")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40059B1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x40059B2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int styleID;
    [Token(Token = "0x40059B3")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int splitDlNum;

    [Token(Token = "0x17001030")]
    public int Key
    {
      [Token(Token = "0x6006B18"), Address(RVA = "0x48DEF44", Offset = "0x48DEF44", VA = "0x48DEF44", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006B19")]
    [Address(RVA = "0x48DEF4C", Offset = "0x48DEF4C", VA = "0x48DEF4C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006B1A")]
    [Address(RVA = "0x48DF118", Offset = "0x48DF118", VA = "0x48DF118", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17001031")]
    public int characterID
    {
      [Token(Token = "0x6006B1B"), Address(RVA = "0x48DF1C0", Offset = "0x48DF1C0", VA = "0x48DF1C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006B1C")]
    [Address(RVA = "0x48DF268", Offset = "0x48DF268", VA = "0x48DF268")]
    public StoryPointIdentifierData()
    {
    }
  }
}
