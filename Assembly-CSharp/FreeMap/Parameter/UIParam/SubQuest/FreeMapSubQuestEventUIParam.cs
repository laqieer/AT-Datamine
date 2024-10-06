// Decompiled with JetBrains decompiler
// Type: FreeMap.Parameter.UIParam.SubQuest.FreeMapSubQuestEventUIParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using StaqData;
using UnityEngine;

#nullable disable
namespace FreeMap.Parameter.UIParam.SubQuest
{
  [Token(Token = "0x200187B")]
  public abstract class FreeMapSubQuestEventUIParam : FreeMapQuestEventUIParam
  {
    [Token(Token = "0x17001627")]
    public virtual bool ShowPocketBookList
    {
      [Token(Token = "0x6008AE7"), Address(RVA = "0x4523C18", Offset = "0x4523C18", VA = "0x4523C18", Slot = "17")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001628")]
    public override int ID
    {
      [Token(Token = "0x6008AE8"), Address(RVA = "0x4523C20", Offset = "0x4523C20", VA = "0x4523C20", Slot = "15")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001629")]
    public int SubQuestID
    {
      [Token(Token = "0x6008AE9"), Address(RVA = "0x4523C28", Offset = "0x4523C28", VA = "0x4523C28")] get
      {
        return new int();
      }
      [Token(Token = "0x6008AEA"), Address(RVA = "0x4523C30", Offset = "0x4523C30", VA = "0x4523C30")] private set
      {
      }
    }

    [Token(Token = "0x1700162A")]
    public int SubQuestTaskID
    {
      [Token(Token = "0x6008AEB"), Address(RVA = "0x4523C38", Offset = "0x4523C38", VA = "0x4523C38")] get
      {
        return new int();
      }
      [Token(Token = "0x6008AEC"), Address(RVA = "0x4523C40", Offset = "0x4523C40", VA = "0x4523C40")] private set
      {
      }
    }

    [Token(Token = "0x1700162B")]
    public int PlaySubQuestADVID
    {
      [Token(Token = "0x6008AED"), Address(RVA = "0x4523C48", Offset = "0x4523C48", VA = "0x4523C48")] get
      {
        return new int();
      }
      [Token(Token = "0x6008AEE"), Address(RVA = "0x4523C50", Offset = "0x4523C50", VA = "0x4523C50")] private set
      {
      }
    }

    [Token(Token = "0x6008AEF")]
    [Address(RVA = "0x4523C58", Offset = "0x4523C58", VA = "0x4523C58")]
    public FreeMapSubQuestEventUIParam(
      int objectID,
      Vector3 iconOffset,
      int cameraMoveID,
      int playerMoveID,
      int subQuestID,
      int subQuestTaskID,
      int playADVEventName,
      EventNpcActEnum eventNpcAct)
    {
    }

    [Token(Token = "0x6008AF0")]
    [Address(RVA = "0x4523D08", Offset = "0x4523D08", VA = "0x4523D08", Slot = "0")]
    public override bool Equals(object obj) => new bool();

    [Token(Token = "0x6008AF1")]
    [Address(RVA = "0x4523E04", Offset = "0x4523E04", VA = "0x4523E04", Slot = "11")]
    public override UIParameterType GetParamType() => new UIParameterType();

    [Token(Token = "0x6008AF2")]
    [Address(RVA = "0x4523E0C", Offset = "0x4523E0C", VA = "0x4523E0C", Slot = "2")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x6008AF3")]
    [Address(RVA = "0x4523E14", Offset = "0x4523E14", VA = "0x4523E14", Slot = "10")]
    public override string GetTitle() => (string) null;

    [Token(Token = "0x6008AF4")]
    public abstract SubQuestEventType GetSubQuestEventType();

    [Token(Token = "0x6008AF5")]
    [Address(RVA = "0x4523EBC", Offset = "0x4523EBC", VA = "0x4523EBC")]
    public static FreeMapUIParamBase CreateUIParam(
      SubQuestData subquest,
      int sequenceID,
      bool isreceived)
    {
      return (FreeMapUIParamBase) null;
    }
  }
}
