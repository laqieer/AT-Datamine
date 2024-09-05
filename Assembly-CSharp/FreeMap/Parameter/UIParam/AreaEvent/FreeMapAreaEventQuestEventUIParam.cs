// Decompiled with JetBrains decompiler
// Type: FreeMap.Parameter.UIParam.AreaEvent.FreeMapAreaEventQuestEventUIParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.Parameter.UIParam.AreaEvent
{
  [Token(Token = "0x2001880")]
  public abstract class FreeMapAreaEventQuestEventUIParam : FreeMapQuestEventUIParam
  {
    [Token(Token = "0x17001634")]
    public override int ID
    {
      [Token(Token = "0x6008B0D"), Address(RVA = "0x45256D0", Offset = "0x45256D0", VA = "0x45256D0", Slot = "15")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001635")]
    public int AreaEventQuestID
    {
      [Token(Token = "0x6008B0E"), Address(RVA = "0x45256D8", Offset = "0x45256D8", VA = "0x45256D8")] get
      {
        return new int();
      }
      [Token(Token = "0x6008B0F"), Address(RVA = "0x45256E0", Offset = "0x45256E0", VA = "0x45256E0")] private set
      {
      }
    }

    [Token(Token = "0x17001636")]
    public int AreaEventQuestTaskID
    {
      [Token(Token = "0x6008B10"), Address(RVA = "0x45256E8", Offset = "0x45256E8", VA = "0x45256E8")] get
      {
        return new int();
      }
      [Token(Token = "0x6008B11"), Address(RVA = "0x45256F0", Offset = "0x45256F0", VA = "0x45256F0")] private set
      {
      }
    }

    [Token(Token = "0x17001637")]
    public int ADVID
    {
      [Token(Token = "0x6008B12"), Address(RVA = "0x45256F8", Offset = "0x45256F8", VA = "0x45256F8")] get
      {
        return new int();
      }
      [Token(Token = "0x6008B13"), Address(RVA = "0x4525700", Offset = "0x4525700", VA = "0x4525700")] private set
      {
      }
    }

    [Token(Token = "0x6008B14")]
    [Address(RVA = "0x4525708", Offset = "0x4525708", VA = "0x4525708", Slot = "9")]
    public override bool AlwaysPurposeMark() => new bool();

    [Token(Token = "0x6008B15")]
    [Address(RVA = "0x4525710", Offset = "0x4525710", VA = "0x4525710")]
    public FreeMapAreaEventQuestEventUIParam(
      int objectID,
      Vector3 iconOffset,
      int cameraMoveID,
      int playerMoveID,
      int areaeventQuestID,
      int areaEventQuestTaskID,
      int advID,
      EventNpcActEnum eventNpcAct)
    {
    }

    [Token(Token = "0x6008B16")]
    [Address(RVA = "0x452574C", Offset = "0x452574C", VA = "0x452574C", Slot = "0")]
    public override bool Equals(object obj) => new bool();

    [Token(Token = "0x6008B17")]
    [Address(RVA = "0x4525814", Offset = "0x4525814", VA = "0x4525814", Slot = "11")]
    public override UIParameterType GetParamType() => new UIParameterType();

    [Token(Token = "0x6008B18")]
    [Address(RVA = "0x452581C", Offset = "0x452581C", VA = "0x452581C", Slot = "2")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x6008B19")]
    public abstract AreaEventQuestEventType GetAreaEventQuestEventType();
  }
}
