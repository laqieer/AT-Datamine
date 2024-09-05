// Decompiled with JetBrains decompiler
// Type: Area.MovableMob.MovableMobManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Area.MovableMob.Data;
using Area.MovableMob.Scriptable;
using FreeMap.Parameter;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Area.MovableMob
{
  [Token(Token = "0x2002826")]
  public class MovableMobManager
  {
    [Token(Token = "0x400AB49")]
    [FieldOffset(Offset = "0x10")]
    private List<MovableMobRouteHandler> movableMobLineHandlerList;
    [Token(Token = "0x400AB4A")]
    [FieldOffset(Offset = "0x18")]
    private MovableSettingDataHandler loader;
    [Token(Token = "0x400AB4B")]
    [FieldOffset(Offset = "0x20")]
    private GameObject rootObject;
    [Token(Token = "0x400AB4C")]
    [FieldOffset(Offset = "0x28")]
    private MonoBehaviour coroutineHandler;
    [Token(Token = "0x400AB4D")]
    [FieldOffset(Offset = "0x30")]
    private int movableSettingID;
    [Token(Token = "0x400AB4E")]
    [FieldOffset(Offset = "0x34")]
    private int movableSoundID;
    [Token(Token = "0x400AB4F")]
    [FieldOffset(Offset = "0x38")]
    private StoryCharacterLookWeatherTypeEnum weatherLookType;
    [Token(Token = "0x400AB50")]
    [FieldOffset(Offset = "0x3C")]
    private FreeMapAreaSituationData? areaParam;

    [Token(Token = "0x600FCBB")]
    [Address(RVA = "0x44260A8", Offset = "0x44260A8", VA = "0x44260A8")]
    public MovableMobManager()
    {
    }

    [Token(Token = "0x600FCBC")]
    [Address(RVA = "0x4426124", Offset = "0x4426124", VA = "0x4426124")]
    public void SetInitializeSettings(
      MonoBehaviour coroutineHandler,
      int movableSettingID,
      int movableSoundID,
      StoryCharacterLookWeatherTypeEnum weatherLookType,
      FreeMapAreaSituationData? areaParam)
    {
    }

    [Token(Token = "0x600FCBD")]
    [Address(RVA = "0x4426138", Offset = "0x4426138", VA = "0x4426138")]
    public void SetInitializeSettings(
      MonoBehaviour coroutineHandler,
      int movableSettingID,
      int movableSoundID)
    {
    }

    [Token(Token = "0x600FCBE")]
    [Address(RVA = "0x442614C", Offset = "0x442614C", VA = "0x442614C")]
    public IEnumerator Initialize(
      MovableRouteObject movableObject,
      Transform parent,
      Transform player = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600FCBF")]
    [Address(RVA = "0x44261FC", Offset = "0x44261FC", VA = "0x44261FC")]
    public void SetParameter(
      string targetRouteName,
      float moveSpeed,
      float popMobTime,
      float popMinTime,
      float popMaxTime,
      int maxPopCount,
      MovablePartialRouteParameter.MobOffsetParameter mobOffsetParameter)
    {
    }

    [Token(Token = "0x600FCC0")]
    [Address(RVA = "0x442647C", Offset = "0x442647C", VA = "0x442647C")]
    public void SetMoveSpeed(string targetRouteName, float moveSpeed)
    {
    }

    [Token(Token = "0x600FCC1")]
    [Address(RVA = "0x442659C", Offset = "0x442659C", VA = "0x442659C")]
    public void SetPopMobTimes(
      string targetRouteName,
      float popMobTime,
      float popMinTime,
      float popMaxTime)
    {
    }

    [Token(Token = "0x600FCC2")]
    [Address(RVA = "0x44266D4", Offset = "0x44266D4", VA = "0x44266D4")]
    public void SetMaxMobCount(string targetRouteName, int count)
    {
    }

    [Token(Token = "0x600FCC3")]
    [Address(RVA = "0x44267EC", Offset = "0x44267EC", VA = "0x44267EC")]
    public void SetMobOffset(
      string targetRouteName,
      MovablePartialRouteParameter.MobOffsetParameter parameter)
    {
    }

    [Token(Token = "0x600FCC4")]
    [Address(RVA = "0x4426814", Offset = "0x4426814", VA = "0x4426814")]
    private MovableMobRouteHandler GetHandler(string targetRouteName)
    {
      return (MovableMobRouteHandler) null;
    }

    [Token(Token = "0x600FCC5")]
    [Address(RVA = "0x4426914", Offset = "0x4426914", VA = "0x4426914")]
    public void MovableUpdate(Transform playerTransform)
    {
    }

    [Token(Token = "0x600FCC6")]
    [Address(RVA = "0x4426CB0", Offset = "0x4426CB0", VA = "0x4426CB0")]
    public void ViewUpdate(Camera usingCamera, Transform playerTransform)
    {
    }

    [Token(Token = "0x600FCC7")]
    [Address(RVA = "0x4426FA0", Offset = "0x4426FA0", VA = "0x4426FA0")]
    public void SetActive(bool isActive)
    {
    }

    [Token(Token = "0x600FCC8")]
    [Address(RVA = "0x4427038", Offset = "0x4427038", VA = "0x4427038")]
    public void Release()
    {
    }
  }
}
