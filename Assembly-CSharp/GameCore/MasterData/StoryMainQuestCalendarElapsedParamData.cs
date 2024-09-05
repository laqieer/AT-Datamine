// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryMainQuestCalendarElapsedParamData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001295")]
  [Serializable]
  public sealed class StoryMainQuestCalendarElapsedParamData : IMasterDataEntity
  {
    [Token(Token = "0x40058B3")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40058B4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string label;
    [Token(Token = "0x40058B5")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int prefabID;

    [Token(Token = "0x17000FF4")]
    public int Key
    {
      [Token(Token = "0x6006992"), Address(RVA = "0x48D1680", Offset = "0x48D1680", VA = "0x48D1680", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006993")]
    [Address(RVA = "0x48D1688", Offset = "0x48D1688", VA = "0x48D1688", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006994")]
    [Address(RVA = "0x48D17F4", Offset = "0x48D17F4", VA = "0x48D17F4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006995")]
    [Address(RVA = "0x48D188C", Offset = "0x48D188C", VA = "0x48D188C")]
    public StoryMainQuestCalendarElapsedParamData()
    {
    }
  }
}
