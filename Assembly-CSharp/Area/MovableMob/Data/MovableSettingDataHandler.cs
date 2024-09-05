// Decompiled with JetBrains decompiler
// Type: Area.MovableMob.Data.MovableSettingDataHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Parameter;
using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Area.MovableMob.Data
{
  [Token(Token = "0x2002845")]
  public class MovableSettingDataHandler
  {
    [Token(Token = "0x400ABB1")]
    [FieldOffset(Offset = "0x10")]
    private List<MovablePartialRouteParameter> movablePartialRouteParamList;
    [Token(Token = "0x400ABB2")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<IMovableMobLoader>> mobBuilderDic;
    [Token(Token = "0x400ABB3")]
    [FieldOffset(Offset = "0x20")]
    private MonoBehaviour coroutineHandler;
    [Token(Token = "0x400ABB4")]
    [FieldOffset(Offset = "0x28")]
    private Coroutine LoadModelCoroutine;

    [Token(Token = "0x170037D7")]
    private bool isLoadingAssets
    {
      [Token(Token = "0x600FD94"), Address(RVA = "0x442F68C", Offset = "0x442F68C", VA = "0x442F68C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600FD95")]
    [Address(RVA = "0x4427E70", Offset = "0x4427E70", VA = "0x4427E70")]
    public MovableSettingDataHandler(
      MonoBehaviour coroutineHandler,
      int settingID,
      int soundGroupID,
      StoryCharacterLookWeatherTypeEnum weatherLookType,
      FreeMapAreaSituationData? areaParam)
    {
    }

    [Token(Token = "0x600FD96")]
    [Address(RVA = "0x442F69C", Offset = "0x442F69C", VA = "0x442F69C")]
    private void OnInternalInitialize(
      List<MovablePartialRouteParameter> settingList,
      StoryCharacterLookWeatherTypeEnum weatherLookType,
      FreeMapAreaSituationData? areaParam)
    {
    }

    [Token(Token = "0x600FD97")]
    [Address(RVA = "0x443035C", Offset = "0x443035C", VA = "0x443035C")]
    private IEnumerator CoLoadAsset() => (IEnumerator) null;

    [Token(Token = "0x600FD98")]
    [Address(RVA = "0x442821C", Offset = "0x442821C", VA = "0x442821C")]
    public IEnumerator WaitForLoadingAsset() => (IEnumerator) null;

    [Token(Token = "0x600FD99")]
    [Address(RVA = "0x4428284", Offset = "0x4428284", VA = "0x4428284")]
    public List<MovablePartialRouteParameter> GetSettingParameterList(
      IReadOnlyList<MovableRouteData> routes)
    {
      return (List<MovablePartialRouteParameter>) null;
    }

    [Token(Token = "0x600FD9A")]
    [Address(RVA = "0x443041C", Offset = "0x443041C", VA = "0x443041C")]
    protected List<MovableMobInstanceDataBase> GenerateInstance(List<IMovableMobLoader> builderList)
    {
      return (List<MovableMobInstanceDataBase>) null;
    }

    [Token(Token = "0x600FD9B")]
    [Address(RVA = "0x4427520", Offset = "0x4427520", VA = "0x4427520")]
    public void UnloadAssetBundle()
    {
    }

    [Token(Token = "0x600FD9C")]
    [Address(RVA = "0x442FAB0", Offset = "0x442FAB0", VA = "0x442FAB0")]
    private List<IMovableMobLoader> CreateMobBuilderList(
      int spawnGroupLabel,
      int soundGroupLabel,
      StoryCharacterLookWeatherTypeEnum weatherLookType,
      FreeMapAreaSituationData? areaParam)
    {
      return (List<IMovableMobLoader>) null;
    }
  }
}
