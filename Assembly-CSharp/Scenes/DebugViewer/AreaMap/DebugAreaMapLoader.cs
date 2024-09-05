// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.AreaMap.DebugAreaMapLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap;
using FreeMap.Data;
using FreeMap.Instance;
using FreeMap.Parameter;
using FreeMap.Sound;
using FreeMap.UI;
using GameCore.MasterData;
using GameCore.Tween;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.DebugViewer.AreaMap
{
  [Token(Token = "0x2002F23")]
  public class DebugAreaMapLoader
  {
    [Token(Token = "0x400CA34")]
    private const int PlayerCharacterID = 101009003;
    [Token(Token = "0x400CA3A")]
    [FieldOffset(Offset = "0x38")]
    private Coroutine debugLoadCoroutine;
    [Token(Token = "0x400CA3B")]
    [FieldOffset(Offset = "0x40")]
    private Dictionary<int, FreeMapInstance> aloneInstances;
    [Token(Token = "0x400CA3C")]
    [FieldOffset(Offset = "0x48")]
    private List<FreeMapInstance> layoutInstance;

    [Token(Token = "0x17003E73")]
    public FreeMapCommonElement element
    {
      [Token(Token = "0x60126B3"), Address(RVA = "0x2113C38", Offset = "0x2113C38", VA = "0x2113C38")] get
      {
        return (FreeMapCommonElement) null;
      }
    }

    [Token(Token = "0x17003E74")]
    public FreeMapLocationHolder LocationHolder
    {
      [Token(Token = "0x60126B4"), Address(RVA = "0x2113C40", Offset = "0x2113C40", VA = "0x2113C40")] get
      {
        return (FreeMapLocationHolder) null;
      }
    }

    [Token(Token = "0x17003E75")]
    private Canvas swipeCanvas
    {
      [Token(Token = "0x60126B5"), Address(RVA = "0x2113C48", Offset = "0x2113C48", VA = "0x2113C48")] get
      {
        return (Canvas) null;
      }
    }

    [Token(Token = "0x17003E76")]
    private Transform componentParent
    {
      [Token(Token = "0x60126B6"), Address(RVA = "0x2113C50", Offset = "0x2113C50", VA = "0x2113C50")] get
      {
        return (Transform) null;
      }
    }

    [Token(Token = "0x17003E77")]
    private UITweenGroup testFadeTweenGroup
    {
      [Token(Token = "0x60126B7"), Address(RVA = "0x2113C58", Offset = "0x2113C58", VA = "0x2113C58")] get
      {
        return (UITweenGroup) null;
      }
    }

    [Token(Token = "0x17003E78")]
    private FreeMapScenesParam CurrentSceneParam
    {
      [Token(Token = "0x60126B8"), Address(RVA = "0x2113C60", Offset = "0x2113C60", VA = "0x2113C60")] set
      {
      }
      [Token(Token = "0x60126B9"), Address(RVA = "0x2113C68", Offset = "0x2113C68", VA = "0x2113C68")] get
      {
        return (FreeMapScenesParam) null;
      }
    }

    [Token(Token = "0x17003E79")]
    public int CurrentAreaId
    {
      [Token(Token = "0x60126BA"), Address(RVA = "0x2113C70", Offset = "0x2113C70", VA = "0x2113C70")] private set
      {
      }
      [Token(Token = "0x60126BB"), Address(RVA = "0x2113C78", Offset = "0x2113C78", VA = "0x2113C78")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003E7A")]
    public int CurrentAreaSettingId
    {
      [Token(Token = "0x60126BC"), Address(RVA = "0x2113C80", Offset = "0x2113C80", VA = "0x2113C80")] private set
      {
      }
      [Token(Token = "0x60126BD"), Address(RVA = "0x2113C88", Offset = "0x2113C88", VA = "0x2113C88")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003E7B")]
    public int CurrentLobbySettingKey
    {
      [Token(Token = "0x60126BE"), Address(RVA = "0x2113C90", Offset = "0x2113C90", VA = "0x2113C90")] private set
      {
      }
      [Token(Token = "0x60126BF"), Address(RVA = "0x2113C98", Offset = "0x2113C98", VA = "0x2113C98")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003E7C")]
    public int CurrentLobbyAreaSettingID
    {
      [Token(Token = "0x60126C0"), Address(RVA = "0x2113CA0", Offset = "0x2113CA0", VA = "0x2113CA0")] private set
      {
      }
      [Token(Token = "0x60126C1"), Address(RVA = "0x2113CA8", Offset = "0x2113CA8", VA = "0x2113CA8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17003E7D")]
    public FreeMapInstanceHolder InstanceHolder
    {
      [Token(Token = "0x60126C2"), Address(RVA = "0x2113CB0", Offset = "0x2113CB0", VA = "0x2113CB0")] get
      {
        return (FreeMapInstanceHolder) null;
      }
    }

    [Token(Token = "0x17003E7E")]
    public FreeMapTransformHolderList TransformHolderList
    {
      [Token(Token = "0x60126C3"), Address(RVA = "0x2113CCC", Offset = "0x2113CCC", VA = "0x2113CCC")] get
      {
        return (FreeMapTransformHolderList) null;
      }
    }

    [Token(Token = "0x17003E7F")]
    public FreeMapSceneManager SceneManager
    {
      [Token(Token = "0x60126C4"), Address(RVA = "0x2113CE8", Offset = "0x2113CE8", VA = "0x2113CE8")] get
      {
        return (FreeMapSceneManager) null;
      }
    }

    [Token(Token = "0x17003E80")]
    private FreeMapManager manager
    {
      [Token(Token = "0x60126C5"), Address(RVA = "0x2113D04", Offset = "0x2113D04", VA = "0x2113D04")] get
      {
        return (FreeMapManager) null;
      }
    }

    [Token(Token = "0x17003E81")]
    private AudioListenerConrtol audioListener
    {
      [Token(Token = "0x60126C6"), Address(RVA = "0x2113D20", Offset = "0x2113D20", VA = "0x2113D20")] get
      {
        return (AudioListenerConrtol) null;
      }
    }

    [Token(Token = "0x14000192")]
    public event EventHandler OnDeleteMap
    {
      [Token(Token = "0x60126C7"), Address(RVA = "0x2113D3C", Offset = "0x2113D3C", VA = "0x2113D3C")] add
      {
      }
      [Token(Token = "0x60126C8"), Address(RVA = "0x2113DD8", Offset = "0x2113DD8", VA = "0x2113DD8")] remove
      {
      }
    }

    [Token(Token = "0x14000193")]
    public event EventHandler OnCreateMap
    {
      [Token(Token = "0x60126C9"), Address(RVA = "0x2113E74", Offset = "0x2113E74", VA = "0x2113E74")] add
      {
      }
      [Token(Token = "0x60126CA"), Address(RVA = "0x2113F10", Offset = "0x2113F10", VA = "0x2113F10")] remove
      {
      }
    }

    [Token(Token = "0x14000194")]
    public event EventHandler<DebugAreaMapPlayer> OnCreatePlayer
    {
      [Token(Token = "0x60126CB"), Address(RVA = "0x2113FAC", Offset = "0x2113FAC", VA = "0x2113FAC")] add
      {
      }
      [Token(Token = "0x60126CC"), Address(RVA = "0x211405C", Offset = "0x211405C", VA = "0x211405C")] remove
      {
      }
    }

    [Token(Token = "0x60126CD")]
    [Address(RVA = "0x211410C", Offset = "0x211410C", VA = "0x211410C")]
    public DebugAreaMapLoader(
      FreeMapCommonElement element,
      Canvas canvas,
      Transform parent,
      UITweenGroup fadeTweens)
    {
    }

    [Token(Token = "0x60126CE")]
    [Address(RVA = "0x211423C", Offset = "0x211423C", VA = "0x211423C")]
    public void DestroyDebugAreaMapLoader()
    {
    }

    [Token(Token = "0x60126CF")]
    [Address(RVA = "0x21143A0", Offset = "0x21143A0", VA = "0x21143A0")]
    public void ReleaseMap()
    {
    }

    [Token(Token = "0x60126D0")]
    [Address(RVA = "0x21143A8", Offset = "0x21143A8", VA = "0x21143A8")]
    private void ReleaseMapInternal()
    {
    }

    [Token(Token = "0x60126D1")]
    [Address(RVA = "0x211446C", Offset = "0x211446C", VA = "0x211446C")]
    public void LoadFreeMapByBackgroundId(
      int backgroundId,
      bool loadLayout = false,
      string startAnchor = "",
      Vector3 playerOffset = default (Vector3),
      float playerRotate = 0.0f)
    {
    }

    [Token(Token = "0x60126D2")]
    [Address(RVA = "0x211477C", Offset = "0x211477C", VA = "0x211477C")]
    public void LoadFreeMapByAreaSettingId(
      int areaSettingId,
      bool loadLayout = false,
      string startAnchor = "",
      Vector3 playerOffset = default (Vector3),
      float playerRotate = 0.0f)
    {
    }

    [Token(Token = "0x60126D3")]
    [Address(RVA = "0x2114688", Offset = "0x2114688", VA = "0x2114688")]
    private void LoadFreeMap(
      FreeMapScenesParam sceneParam,
      bool isLobby,
      bool loadLayout,
      string startAnchor,
      Vector3 playerOffset = default (Vector3),
      float playerRotate = 0.0f)
    {
    }

    [Token(Token = "0x60126D4")]
    [Address(RVA = "0x21148FC", Offset = "0x21148FC", VA = "0x21148FC")]
    private IEnumerator CoLoadFreeMap(
      FreeMapScenesParam sceneParam,
      bool isLobby = false,
      bool loadLayout = false,
      string startAnchor = "",
      Vector3 playerOffset = default (Vector3),
      float playerRotate = 0.0f)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60126D5")]
    [Address(RVA = "0x21144D4", Offset = "0x21144D4", VA = "0x21144D4")]
    private FreeMapScenesParam CreateScenesParamFromBackgroundId(int backgroundId)
    {
      return (FreeMapScenesParam) null;
    }

    [Token(Token = "0x60126D6")]
    [Address(RVA = "0x21147E4", Offset = "0x21147E4", VA = "0x21147E4")]
    private FreeMapScenesParam CreateScenesParam(int areaSettingId) => (FreeMapScenesParam) null;

    [Token(Token = "0x60126D7")]
    [Address(RVA = "0x21149F0", Offset = "0x21149F0", VA = "0x21149F0")]
    public void LoadPlayer(
      int characterSwitchPatternID,
      string anchorName = "",
      bool isChange = false,
      Vector3 offset = default (Vector3),
      float rotate = 0.0f)
    {
    }

    [Token(Token = "0x60126D8")]
    [Address(RVA = "0x2114C64", Offset = "0x2114C64", VA = "0x2114C64")]
    public void UnloadPlayer()
    {
    }

    [Token(Token = "0x60126D9")]
    [Address(RVA = "0x2114E10", Offset = "0x2114E10", VA = "0x2114E10")]
    public void SetPlayerPosition(string anchorName = "DefaultStartPoint", Vector3 offset = default (Vector3), float rotate = 0.0f)
    {
    }

    [Token(Token = "0x60126DA")]
    [Address(RVA = "0x2114E78", Offset = "0x2114E78", VA = "0x2114E78")]
    public FreeMapPlayerInstance GetPlayerBase() => (FreeMapPlayerInstance) null;

    [Token(Token = "0x60126DB")]
    [Address(RVA = "0x2114E9C", Offset = "0x2114E9C", VA = "0x2114E9C")]
    public void SetSwipeControllerModeEnable(bool enable)
    {
    }

    [Token(Token = "0x60126DC")]
    [Address(RVA = "0x2114EC4", Offset = "0x2114EC4", VA = "0x2114EC4")]
    public void LoadAloneInstanceNpc(
      int id,
      string anchorName,
      int characterId,
      string animationName)
    {
    }

    [Token(Token = "0x60126DD")]
    [Address(RVA = "0x2115304", Offset = "0x2115304", VA = "0x2115304")]
    public void LoadAloneInstanceBreakable(int id, string anchorName, int propID)
    {
    }

    [Token(Token = "0x60126DE")]
    [Address(RVA = "0x21153F8", Offset = "0x21153F8", VA = "0x21153F8")]
    public void LoadAloneInstanceChest(int id, string anchorName, int propID)
    {
    }

    [Token(Token = "0x60126DF")]
    [Address(RVA = "0x21151C0", Offset = "0x21151C0", VA = "0x21151C0")]
    private void AddAloneInstance(int id, IFreeMapInstanceBuilder builder)
    {
    }

    [Token(Token = "0x60126E0")]
    [Address(RVA = "0x21150E8", Offset = "0x21150E8", VA = "0x21150E8")]
    public void UnloadAloneInstance(int id)
    {
    }

    [Token(Token = "0x60126E1")]
    [Address(RVA = "0x21154F8", Offset = "0x21154F8", VA = "0x21154F8")]
    public FreeMapInstance GetAloneInstance(int id) => (FreeMapInstance) null;

    [Token(Token = "0x60126E2")]
    [Address(RVA = "0x2115570", Offset = "0x2115570", VA = "0x2115570")]
    public IEnumerable<FreeMapInstance> GetAllAloneInstance()
    {
      return (IEnumerable<FreeMapInstance>) null;
    }

    [Token(Token = "0x60126E3")]
    [Address(RVA = "0x21155C0", Offset = "0x21155C0", VA = "0x21155C0")]
    public void LocationSettingByAutoSequence(int settingId)
    {
    }

    [Token(Token = "0x60126E4")]
    [Address(RVA = "0x211577C", Offset = "0x211577C", VA = "0x211577C")]
    public void LocationSetting(int settingId, int sequenceID)
    {
    }

    [Token(Token = "0x60126E5")]
    [Address(RVA = "0x21159F4", Offset = "0x21159F4", VA = "0x21159F4")]
    public void LoadLayoutInstance(bool isTransition = false)
    {
    }

    [Token(Token = "0x60126E6")]
    [Address(RVA = "0x2115DFC", Offset = "0x2115DFC", VA = "0x2115DFC")]
    public void AddInstance(
      int targetAreaID,
      StoryFreeActionLayoutData layout,
      Action<FreeMapInstance> onCreate)
    {
    }

    [Token(Token = "0x60126E7")]
    [Address(RVA = "0x2115E70", Offset = "0x2115E70", VA = "0x2115E70")]
    private void OnAddSceneInstance(IFreeMapInstanceBuilder param, Action<FreeMapInstance> onCreate)
    {
    }

    [Token(Token = "0x60126E8")]
    [Address(RVA = "0x2115C4C", Offset = "0x2115C4C", VA = "0x2115C4C")]
    public void UnloadLayoutInstance()
    {
    }

    [Token(Token = "0x60126E9")]
    [Address(RVA = "0x2115FB4", Offset = "0x2115FB4", VA = "0x2115FB4")]
    public void LobbyLocationSetting(int lobbySettingKey, int chapterID)
    {
    }

    [Token(Token = "0x60126EA")]
    [Address(RVA = "0x2116108", Offset = "0x2116108", VA = "0x2116108")]
    public void LoadLobbyLayout(bool isTransition = false)
    {
    }

    [Token(Token = "0x60126EB")]
    [Address(RVA = "0x21162D8", Offset = "0x21162D8", VA = "0x21162D8")]
    public void ReleaseLeaderUnit()
    {
    }

    [Token(Token = "0x60126EC")]
    [Address(RVA = "0x2116468", Offset = "0x2116468", VA = "0x2116468")]
    private IEnumerator TestFadeIn() => (IEnumerator) null;

    [Token(Token = "0x60126ED")]
    [Address(RVA = "0x21164F8", Offset = "0x21164F8", VA = "0x21164F8")]
    private IEnumerator TestFadeOut() => (IEnumerator) null;
  }
}
