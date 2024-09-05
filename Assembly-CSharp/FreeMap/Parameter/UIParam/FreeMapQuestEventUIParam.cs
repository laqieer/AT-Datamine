// Decompiled with JetBrains decompiler
// Type: FreeMap.Parameter.UIParam.FreeMapQuestEventUIParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance;
using GameCore.MasterData;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.Parameter.UIParam
{
  [Token(Token = "0x200186F")]
  public abstract class FreeMapQuestEventUIParam : FreeMapUIParamBase
  {
    [Token(Token = "0x1700160A")]
    public abstract int ID { [Token(Token = "0x6008A7F")] get; }

    [Token(Token = "0x1700160B")]
    public virtual bool IsTracking
    {
      [Token(Token = "0x6008A80"), Address(RVA = "0x45221E4", Offset = "0x45221E4", VA = "0x45221E4", Slot = "16")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6008A81")]
    [Address(RVA = "0x45221EC", Offset = "0x45221EC", VA = "0x45221EC")]
    public FreeMapQuestEventUIParam(
      int objectID,
      Vector3 iconOffset,
      int cameraMoveID,
      int playerMoveID,
      EventNpcActEnum eventNpcAct)
    {
    }

    [Token(Token = "0x6008A82")]
    [Address(RVA = "0x4522270", Offset = "0x4522270", VA = "0x4522270")]
    public FreeMapQuestEventUIParam(
      InstanceID objectID,
      Vector3 iconOffset,
      int cameraMoveID,
      int playerMoveID,
      EventNpcActEnum eventNpcAct)
    {
    }
  }
}
