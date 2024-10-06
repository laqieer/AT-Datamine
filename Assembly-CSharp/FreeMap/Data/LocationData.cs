// Decompiled with JetBrains decompiler
// Type: FreeMap.Data.LocationData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance;
using FreeMap.Instance.Builder;
using FreeMap.Parameter;
using FreeMap.Parameter.UIParam;
using FreeMap.Parameter.UIParam.AreaEvent;
using FreeMap.Parameter.UIParam.SubQuest;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace FreeMap.Data
{
  [Token(Token = "0x200193A")]
  public class LocationData
  {
    [Token(Token = "0x4006CA0")]
    [FieldOffset(Offset = "0x10")]
    private FreeMapAreaBGMData currentBGM;
    [Token(Token = "0x4006CA1")]
    [FieldOffset(Offset = "0x28")]
    private ILocationCollectData currentCollectData;
    [Token(Token = "0x4006CA3")]
    [FieldOffset(Offset = "0x34")]
    private int currentAreaGroupID;
    [Token(Token = "0x4006CA4")]
    [FieldOffset(Offset = "0x38")]
    private List<FreeMapInstanceBuildHandler> instanceBuildHandlers;
    [Token(Token = "0x4006CA5")]
    [FieldOffset(Offset = "0x40")]
    private List<FreeMapUIParamBase> uiParameterList;

    [Token(Token = "0x17001707")]
    public int AreaID
    {
      [Token(Token = "0x6008F8E"), Address(RVA = "0x4B0B460", Offset = "0x4B0B460", VA = "0x4B0B460")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001708")]
    public int MovableSettingID
    {
      [Token(Token = "0x6008F8F"), Address(RVA = "0x4B0B500", Offset = "0x4B0B500", VA = "0x4B0B500")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001709")]
    public int MovableSoundID
    {
      [Token(Token = "0x6008F90"), Address(RVA = "0x4B0B5A4", Offset = "0x4B0B5A4", VA = "0x4B0B5A4")] get
      {
        return new int();
      }
      [Token(Token = "0x6008F91"), Address(RVA = "0x4B0B5AC", Offset = "0x4B0B5AC", VA = "0x4B0B5AC")] private set
      {
      }
    }

    [Token(Token = "0x1700170A")]
    public int IntroductionTableID
    {
      [Token(Token = "0x6008F92"), Address(RVA = "0x4B0B5B4", Offset = "0x4B0B5B4", VA = "0x4B0B5B4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700170B")]
    public List<FreeMapInstanceBuildHandler> InstanceBuildHandlers
    {
      [Token(Token = "0x6008F93"), Address(RVA = "0x4B0B658", Offset = "0x4B0B658", VA = "0x4B0B658")] get
      {
        return (List<FreeMapInstanceBuildHandler>) null;
      }
    }

    [Token(Token = "0x1700170C")]
    private IEnumerable<FreeMapUIParamBase> actionIconUIs
    {
      [Token(Token = "0x6008F94"), Address(RVA = "0x4B0B660", Offset = "0x4B0B660", VA = "0x4B0B660")] get
      {
        return (IEnumerable<FreeMapUIParamBase>) null;
      }
    }

    [Token(Token = "0x1700170D")]
    public IEnumerable<FreeMapUIParamBase> ActionIconUIs
    {
      [Token(Token = "0x6008F95"), Address(RVA = "0x4B0B75C", Offset = "0x4B0B75C", VA = "0x4B0B75C")] get
      {
        return (IEnumerable<FreeMapUIParamBase>) null;
      }
    }

    [Token(Token = "0x1700170E")]
    public List<AreaConnectParam> ConnectParameterList
    {
      [Token(Token = "0x6008F96"), Address(RVA = "0x4B0B760", Offset = "0x4B0B760", VA = "0x4B0B760")] get
      {
        return (List<AreaConnectParam>) null;
      }
      [Token(Token = "0x6008F97"), Address(RVA = "0x4B0B768", Offset = "0x4B0B768", VA = "0x4B0B768")] private set
      {
      }
    }

    [Token(Token = "0x6008F98")]
    [Address(RVA = "0x4B0B770", Offset = "0x4B0B770", VA = "0x4B0B770")]
    public LocationData(
      int areaGroupID,
      ILocationCollectData collectData,
      FreeMapAreaBGMData BGMData,
      int movableSoundID)
    {
    }

    [Token(Token = "0x6008F99")]
    [Address(RVA = "0x4B0B8C4", Offset = "0x4B0B8C4", VA = "0x4B0B8C4")]
    public void AddConnectParameter(AreaConnectParam param)
    {
    }

    [Token(Token = "0x6008F9A")]
    [Address(RVA = "0x4B0B9B4", Offset = "0x4B0B9B4", VA = "0x4B0B9B4")]
    public void AddInstanceBuilder(IFreeMapInstanceBuilder param)
    {
    }

    [Token(Token = "0x6008F9B")]
    [Address(RVA = "0x4B0BB90", Offset = "0x4B0BB90", VA = "0x4B0BB90")]
    private bool TryGetInstanceBuildHandler(
      InstanceID instanceID,
      out FreeMapInstanceBuildHandler param)
    {
      return new bool();
    }

    [Token(Token = "0x6008F9C")]
    [Address(RVA = "0x4B0BC8C", Offset = "0x4B0BC8C", VA = "0x4B0BC8C")]
    public FreeMapInstanceBuildHandler GetInstansBuildHandler(InstanceID instanceID)
    {
      return (FreeMapInstanceBuildHandler) null;
    }

    [Token(Token = "0x6008F9D")]
    [Address(RVA = "0x4B06848", Offset = "0x4B06848", VA = "0x4B06848")]
    public FreeMapScenesParam GetCurrentSceneParam() => (FreeMapScenesParam) null;

    [Token(Token = "0x6008F9E")]
    [Address(RVA = "0x4B0BD70", Offset = "0x4B0BD70", VA = "0x4B0BD70")]
    private static bool CanCreate(IFreeMapInstanceBuilder builder) => new bool();

    [Token(Token = "0x6008F9F")]
    [Address(RVA = "0x4B0BE74", Offset = "0x4B0BE74", VA = "0x4B0BE74")]
    private static bool CannotCreate(IFreeMapInstanceBuilder builder) => new bool();

    [Token(Token = "0x6008FA0")]
    [Address(RVA = "0x4B0BE8C", Offset = "0x4B0BE8C", VA = "0x4B0BE8C")]
    private static bool CanCreate(FreeMapUIParamBase param) => new bool();

    [Token(Token = "0x6008FA1")]
    [Address(RVA = "0x4B0BF28", Offset = "0x4B0BF28", VA = "0x4B0BF28")]
    private static bool CannotCreate(FreeMapUIParamBase param) => new bool();

    [Token(Token = "0x6008FA2")]
    [Address(RVA = "0x4B0BF40", Offset = "0x4B0BF40", VA = "0x4B0BF40")]
    public IEnumerable<IFreeMapInstanceBuilder> GetCreatableInstanceBuilderList(
      FreeMapCommonElement commonElement)
    {
      return (IEnumerable<IFreeMapInstanceBuilder>) null;
    }

    [Token(Token = "0x6008FA3")]
    [Address(RVA = "0x4B0C140", Offset = "0x4B0C140", VA = "0x4B0C140")]
    public IEnumerable<IFreeMapInstanceBuilder> GetNotCreatableInstanceBuilderList()
    {
      return (IEnumerable<IFreeMapInstanceBuilder>) null;
    }

    [Token(Token = "0x6008FA4")]
    [Address(RVA = "0x4B0C2B0", Offset = "0x4B0C2B0", VA = "0x4B0C2B0")]
    public IEnumerable<FreeMapUIParamBase> GetCreatableActionIconUIList()
    {
      return (IEnumerable<FreeMapUIParamBase>) null;
    }

    [Token(Token = "0x6008FA5")]
    [Address(RVA = "0x4B0C358", Offset = "0x4B0C358", VA = "0x4B0C358")]
    public IEnumerable<FreeMapUIParamBase> GetNotCreatableActionIconUIList()
    {
      return (IEnumerable<FreeMapUIParamBase>) null;
    }

    [Token(Token = "0x6008FA6")]
    [Address(RVA = "0x4B0C400", Offset = "0x4B0C400", VA = "0x4B0C400")]
    public IEnumerable<FreeMapUIParamBase> GetCreatableActionIconUIs(InstanceID instanceID)
    {
      return (IEnumerable<FreeMapUIParamBase>) null;
    }

    [Token(Token = "0x6008FA7")]
    [Address(RVA = "0x4B0C4EC", Offset = "0x4B0C4EC", VA = "0x4B0C4EC")]
    public IEnumerable<IFreeMapInstanceBuilder> GetInstanceBuildersByInstanceType(InstanceType type)
    {
      return (IEnumerable<IFreeMapInstanceBuilder>) null;
    }

    [Token(Token = "0x6008FA8")]
    [Address(RVA = "0x4B0C698", Offset = "0x4B0C698", VA = "0x4B0C698")]
    public bool UIParameterExists(FreeMapUIParamBase param) => new bool();

    [Token(Token = "0x6008FA9")]
    [Address(RVA = "0x4B0C6F0", Offset = "0x4B0C6F0", VA = "0x4B0C6F0")]
    public void AddUIParameter(FreeMapUIParamBase param)
    {
    }

    [Token(Token = "0x6008FAA")]
    [Address(RVA = "0x4B0C7C4", Offset = "0x4B0C7C4", VA = "0x4B0C7C4")]
    public void ChangeUIParameter(FreeMapUIParamBase fromParam, FreeMapUIParamBase toParam)
    {
    }

    [Token(Token = "0x6008FAB")]
    [Address(RVA = "0x4B0C95C", Offset = "0x4B0C95C", VA = "0x4B0C95C")]
    public bool RemoveUIParameter(FreeMapUIParamBase param) => new bool();

    [Token(Token = "0x6008FAC")]
    [Address(RVA = "0x4B0CA70", Offset = "0x4B0CA70", VA = "0x4B0CA70")]
    public IEnumerable<FreeMapUIParamBase> GetUIParameter(InstanceID instanceID)
    {
      return (IEnumerable<FreeMapUIParamBase>) null;
    }

    [Token(Token = "0x6008FAD")]
    [Address(RVA = "0x4B0CB50", Offset = "0x4B0CB50", VA = "0x4B0CB50")]
    public IEnumerable<FreeMapUIParamBase> GetUIParameterByInstanceType(InstanceType type)
    {
      return (IEnumerable<FreeMapUIParamBase>) null;
    }

    [Token(Token = "0x6008FAE")]
    [Address(RVA = "0x4B0CC30", Offset = "0x4B0CC30", VA = "0x4B0CC30")]
    public bool TryGetPassiveMsgParameter(
      InstanceID instanceID,
      out FreeMapPassiveMessageParam param)
    {
      return new bool();
    }

    [Token(Token = "0x6008FAF")]
    [Address(RVA = "0x4B0CD78", Offset = "0x4B0CD78", VA = "0x4B0CD78")]
    public IEnumerable<FreeMapAreaEventQuestTaskEventUIParam> AreaEventQuestTaskParameters()
    {
      return (IEnumerable<FreeMapAreaEventQuestTaskEventUIParam>) null;
    }

    [Token(Token = "0x6008FB0")]
    [Address(RVA = "0x4B0CDC0", Offset = "0x4B0CDC0", VA = "0x4B0CDC0")]
    public IEnumerable<FreeMapSubQuestTaskEventUIParam> SubQuestTaskParameters()
    {
      return (IEnumerable<FreeMapSubQuestTaskEventUIParam>) null;
    }

    [Token(Token = "0x6008FB1")]
    public IEnumerable<T> Parameters<T>() where T : FreeMapUIParamBase => (IEnumerable<T>) null;

    [Token(Token = "0x6008FB2")]
    [Address(RVA = "0x4B0CE08", Offset = "0x4B0CE08", VA = "0x4B0CE08")]
    public bool TryGetSubQuestEventUIList(
      int subQuestID,
      out List<FreeMapSubQuestEventUIParam> subQuestParamList)
    {
      return new bool();
    }

    [Token(Token = "0x6008FB3")]
    [Address(RVA = "0x4B0D2FC", Offset = "0x4B0D2FC", VA = "0x4B0D2FC")]
    public bool TryGetCommunicationEventUI(
      int communicationID,
      out FreeMapCommunicationEventUIParam param)
    {
      return new bool();
    }

    [Token(Token = "0x6008FB4")]
    [Address(RVA = "0x4B0D4BC", Offset = "0x4B0D4BC", VA = "0x4B0D4BC")]
    public bool TryGetFacilityEventUI(int attachID, out FreeMapFacilityEventUIParam param)
    {
      return new bool();
    }

    [Token(Token = "0x6008FB5")]
    [Address(RVA = "0x4B0D66C", Offset = "0x4B0D66C", VA = "0x4B0D66C")]
    public bool IsHoldObjectIDInstance(InstanceID instanceID) => new bool();

    [Token(Token = "0x6008FB6")]
    [Address(RVA = "0x4B0D688", Offset = "0x4B0D688", VA = "0x4B0D688")]
    public int GetBackgroundID() => new int();

    [Token(Token = "0x6008FB7")]
    [Address(RVA = "0x4B0D72C", Offset = "0x4B0D72C", VA = "0x4B0D72C")]
    public int GetMinimapID() => new int();

    [Token(Token = "0x6008FB8")]
    [Address(RVA = "0x4B0D7D0", Offset = "0x4B0D7D0", VA = "0x4B0D7D0")]
    public int GetAreaGroupID() => new int();

    [Token(Token = "0x1700170F")]
    public float RouteCost
    {
      [Token(Token = "0x6008FB9"), Address(RVA = "0x4B0D7D8", Offset = "0x4B0D7D8", VA = "0x4B0D7D8")] get
      {
        return new float();
      }
      [Token(Token = "0x6008FBA"), Address(RVA = "0x4B0D7E0", Offset = "0x4B0D7E0", VA = "0x4B0D7E0")] private set
      {
      }
    }

    [Token(Token = "0x17001710")]
    public bool RouteSearchDone
    {
      [Token(Token = "0x6008FBB"), Address(RVA = "0x4B0D7E8", Offset = "0x4B0D7E8", VA = "0x4B0D7E8")] get
      {
        return new bool();
      }
      [Token(Token = "0x6008FBC"), Address(RVA = "0x4B0D7F0", Offset = "0x4B0D7F0", VA = "0x4B0D7F0")] private set
      {
      }
    }

    [Token(Token = "0x17001711")]
    public int PreviousAreaID
    {
      [Token(Token = "0x6008FBD"), Address(RVA = "0x4B0D7FC", Offset = "0x4B0D7FC", VA = "0x4B0D7FC")] get
      {
        return new int();
      }
      [Token(Token = "0x6008FBE"), Address(RVA = "0x4B0D804", Offset = "0x4B0D804", VA = "0x4B0D804")] private set
      {
      }
    }

    [Token(Token = "0x6008FBF")]
    [Address(RVA = "0x4B0D80C", Offset = "0x4B0D80C", VA = "0x4B0D80C")]
    public void ResetSearchParam()
    {
    }

    [Token(Token = "0x6008FC0")]
    [Address(RVA = "0x4B0D824", Offset = "0x4B0D824", VA = "0x4B0D824")]
    public void SetRouteCost(float cost)
    {
    }

    [Token(Token = "0x6008FC1")]
    [Address(RVA = "0x4B0D82C", Offset = "0x4B0D82C", VA = "0x4B0D82C")]
    public void CalcConnectedRouteCost(FreeMapLocationHolder holder)
    {
    }

    [Token(Token = "0x6008FC2")]
    [Address(RVA = "0x4B0D9E4", Offset = "0x4B0D9E4", VA = "0x4B0D9E4")]
    public FreeMapTransitionEventUIParam GetConnectedTransitionParam(int toAreaID)
    {
      return (FreeMapTransitionEventUIParam) null;
    }
  }
}
