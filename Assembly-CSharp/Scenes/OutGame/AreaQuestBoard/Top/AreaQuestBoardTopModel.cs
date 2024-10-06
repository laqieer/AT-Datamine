// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.AreaQuestBoard.Top.AreaQuestBoardTopModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.API;
using System;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Scenes.OutGame.AreaQuestBoard.Top
{
  [Token(Token = "0x20038D4")]
  internal class AreaQuestBoardTopModel : IAreaQuestBoardModel
  {
    [Token(Token = "0x400F888")]
    [FieldOffset(Offset = "0x0")]
    private static readonly string AreaChangeButtonAssetBundlePath;
    [Token(Token = "0x400F889")]
    [FieldOffset(Offset = "0x8")]
    private static readonly string AreaChangeButtonAssetName;
    [Token(Token = "0x400F88A")]
    [FieldOffset(Offset = "0x10")]
    private readonly List<AreaQuestBoardTopModel.AssetBundlePath> assetBundlePaths;
    [Token(Token = "0x400F88B")]
    [FieldOffset(Offset = "0x18")]
    private readonly Dictionary<int, Scenes.OutGame.AreaQuestBoard.Top.CacheAreaData> cacheAreaData;
    [Token(Token = "0x400F88C")]
    [FieldOffset(Offset = "0x20")]
    private readonly AreaQuestBoardSubScene.SceneParam.TransitionReasonType reasonType;
    [Token(Token = "0x400F88D")]
    [FieldOffset(Offset = "0x28")]
    private readonly AreaQuestError areaQuestError;
    [Token(Token = "0x400F88E")]
    [FieldOffset(Offset = "0x30")]
    private AreaQuestDifficultyData difficultyData;
    [Token(Token = "0x400F88F")]
    [FieldOffset(Offset = "0x40")]
    private AreaQuestScenarioSettingData scenarioSettingData;
    [Token(Token = "0x400F890")]
    [FieldOffset(Offset = "0x48")]
    private AreaQuestTopNodeDirectedData nodeDirectedData;
    [Token(Token = "0x400F891")]
    [FieldOffset(Offset = "0x50")]
    private AreaQuestTopAreaDirectedData areaDirectedData;
    [Token(Token = "0x400F892")]
    [FieldOffset(Offset = "0x58")]
    private int currentAssignAreaNodeShortcutId;
    [Token(Token = "0x400F89A")]
    [FieldOffset(Offset = "0x78")]
    private Action<int, QuestDifficultyTypeEnum> onChangeCurrentAssignAreaNodeShortcutId;
    [Token(Token = "0x400F89B")]
    [FieldOffset(Offset = "0x80")]
    private Action<int> onChangeArea;
    [Token(Token = "0x400F89C")]
    [FieldOffset(Offset = "0x88")]
    private Action<int> onChangeAreaNotPlayableNextArea;
    [Token(Token = "0x400F89D")]
    [FieldOffset(Offset = "0x90")]
    private Action<int> onChangeDifficulty;
    [Token(Token = "0x400F89E")]
    [FieldOffset(Offset = "0x98")]
    private Action<bool> onChangeScenarioSkip;
    [Token(Token = "0x400F89F")]
    [FieldOffset(Offset = "0xA0")]
    private Action<int> onChangeDifficultyLockNextDifficulty;
    [Token(Token = "0x400F8A0")]
    [FieldOffset(Offset = "0xA8")]
    private Action<int, bool, bool> onChangePlayableArea;
    [Token(Token = "0x400F8A1")]
    [FieldOffset(Offset = "0xB0")]
    private Action<IEnumerator> startCoroutine;

    [Token(Token = "0x17004980")]
    public List<AreaQuestBoardTopModel.AssetBundlePath> AssetBundlePaths
    {
      [Token(Token = "0x601656B"), Address(RVA = "0x207C62C", Offset = "0x207C62C", VA = "0x207C62C")] get
      {
        return (List<AreaQuestBoardTopModel.AssetBundlePath>) null;
      }
    }

    [Token(Token = "0x17004981")]
    public Scenes.OutGame.AreaQuestBoard.Top.CacheAreaData CurrentCacheAreaData
    {
      [Token(Token = "0x601656C"), Address(RVA = "0x207C634", Offset = "0x207C634", VA = "0x207C634", Slot = "4")] get
      {
        return (Scenes.OutGame.AreaQuestBoard.Top.CacheAreaData) null;
      }
      [Token(Token = "0x601656D"), Address(RVA = "0x207C63C", Offset = "0x207C63C", VA = "0x207C63C")] private set
      {
      }
    }

    [Token(Token = "0x17004982")]
    public int SelectedAreaGroupId
    {
      [Token(Token = "0x601656E"), Address(RVA = "0x207C644", Offset = "0x207C644", VA = "0x207C644", Slot = "6")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004983")]
    public int SelectedAreaId
    {
      [Token(Token = "0x601656F"), Address(RVA = "0x207C64C", Offset = "0x207C64C", VA = "0x207C64C", Slot = "7")] get
      {
        return new int();
      }
      [Token(Token = "0x6016570"), Address(RVA = "0x207C654", Offset = "0x207C654", VA = "0x207C654")] private set
      {
      }
    }

    [Token(Token = "0x17004984")]
    public int SelectedNodeId
    {
      [Token(Token = "0x6016571"), Address(RVA = "0x207C65C", Offset = "0x207C65C", VA = "0x207C65C", Slot = "8")] get
      {
        return new int();
      }
      [Token(Token = "0x6016572"), Address(RVA = "0x207C664", Offset = "0x207C664", VA = "0x207C664")] private set
      {
      }
    }

    [Token(Token = "0x17004985")]
    public int SelectedDifficultyId
    {
      [Token(Token = "0x6016573"), Address(RVA = "0x20740E8", Offset = "0x20740E8", VA = "0x20740E8", Slot = "9")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17004986")]
    public List<Scenes.OutGame.AreaQuestBoard.Top.CacheAreaData> CacheAreaData
    {
      [Token(Token = "0x6016574"), Address(RVA = "0x207AF10", Offset = "0x207AF10", VA = "0x207AF10")] get
      {
        return (List<Scenes.OutGame.AreaQuestBoard.Top.CacheAreaData>) null;
      }
    }

    [Token(Token = "0x17004987")]
    public AreaQuestDifficultyData DifficultyData
    {
      [Token(Token = "0x6016575"), Address(RVA = "0x207C66C", Offset = "0x207C66C", VA = "0x207C66C", Slot = "5")] get
      {
        return new AreaQuestDifficultyData();
      }
    }

    [Token(Token = "0x17004988")]
    public bool ScenarioSkipSettingStatus
    {
      [Token(Token = "0x6016576"), Address(RVA = "0x207B200", Offset = "0x207B200", VA = "0x207B200")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17004989")]
    public bool ExistRequestPlayUnlockAreaAnimation
    {
      [Token(Token = "0x6016577"), Address(RVA = "0x207C67C", Offset = "0x207C67C", VA = "0x207C67C")] get
      {
        return new bool();
      }
      [Token(Token = "0x6016578"), Address(RVA = "0x207C684", Offset = "0x207C684", VA = "0x207C684")] private set
      {
      }
    }

    [Token(Token = "0x1700498A")]
    public bool InvalidPlayableArea
    {
      [Token(Token = "0x6016579"), Address(RVA = "0x207C690", Offset = "0x207C690", VA = "0x207C690")] get
      {
        return new bool();
      }
      [Token(Token = "0x601657A"), Address(RVA = "0x207C698", Offset = "0x207C698", VA = "0x207C698")] private set
      {
      }
    }

    [Token(Token = "0x1700498B")]
    public bool IsNetConnectingSelf
    {
      [Token(Token = "0x601657B"), Address(RVA = "0x207C6A4", Offset = "0x207C6A4", VA = "0x207C6A4")] get
      {
        return new bool();
      }
      [Token(Token = "0x601657C"), Address(RVA = "0x207C6AC", Offset = "0x207C6AC", VA = "0x207C6AC")] private set
      {
      }
    }

    [Token(Token = "0x601657D")]
    [Address(RVA = "0x207C6B8", Offset = "0x207C6B8", VA = "0x207C6B8")]
    public void SetStartCoroutine(Action<IEnumerator> startCoroutine)
    {
    }

    [Token(Token = "0x601657E")]
    [Address(RVA = "0x207C6C0", Offset = "0x207C6C0", VA = "0x207C6C0")]
    public void SetActionChangeCurrentAssignAreaNodeShortcutId(
      Action<int, QuestDifficultyTypeEnum> onChangeCurrentAssignAreaNodeShortcutId)
    {
    }

    [Token(Token = "0x601657F")]
    [Address(RVA = "0x207AD34", Offset = "0x207AD34", VA = "0x207AD34")]
    public void SetActionChangeArea(Action<int> onNextArea, Action<int> onLockArea)
    {
    }

    [Token(Token = "0x6016580")]
    [Address(RVA = "0x207AD3C", Offset = "0x207AD3C", VA = "0x207AD3C")]
    public void SetActionChangeDifficulty(
      Action<int> onNextDifficulty,
      Action<int> onLockDifficulty)
    {
    }

    [Token(Token = "0x6016581")]
    [Address(RVA = "0x207C6C8", Offset = "0x207C6C8", VA = "0x207C6C8")]
    public void SetActionChangeScenarioSkipSetting(Action<bool> onNextSetting)
    {
    }

    [Token(Token = "0x6016582")]
    [Address(RVA = "0x207C6D0", Offset = "0x207C6D0", VA = "0x207C6D0")]
    public void SetActionChangePlayableArea(Action<int, bool, bool> onPlayableAreaDirection)
    {
    }

    [Token(Token = "0x6016583")]
    [Address(RVA = "0x20731B0", Offset = "0x20731B0", VA = "0x20731B0")]
    public static AreaQuestBoardTopModel Create(
      int areaGroupId,
      AreaQuestBoardSubScene.SceneParam.TransitionReasonType reasonType,
      Action<string> onInvalidPlayableArea)
    {
      return (AreaQuestBoardTopModel) null;
    }

    [Token(Token = "0x6016584")]
    [Address(RVA = "0x207C6D8", Offset = "0x207C6D8", VA = "0x207C6D8")]
    private AreaQuestBoardTopModel(
      int areaGroupId,
      AreaQuestBoardSubScene.SceneParam.TransitionReasonType reasonType,
      Action<string> onInvalidPlayableArea)
    {
    }

    [Token(Token = "0x6016585")]
    [Address(RVA = "0x207C7FC", Offset = "0x207C7FC", VA = "0x207C7FC")]
    private void Init(int areaGroupId)
    {
    }

    [Token(Token = "0x6016586")]
    [Address(RVA = "0x207D108", Offset = "0x207D108", VA = "0x207D108")]
    private void SetDifficultyData(AreaQuestDifficultyData data)
    {
    }

    [Token(Token = "0x6016587")]
    [Address(RVA = "0x207D114", Offset = "0x207D114", VA = "0x207D114")]
    public void ChangeDifficulty(int nextDiff)
    {
    }

    [Token(Token = "0x6016588")]
    [Address(RVA = "0x207C148", Offset = "0x207C148", VA = "0x207C148")]
    public void ChangeScenarionSkipSetting(bool on)
    {
    }

    [Token(Token = "0x6016589")]
    [Address(RVA = "0x207AD60", Offset = "0x207AD60", VA = "0x207AD60", Slot = "11")]
    public void Execute()
    {
    }

    [Token(Token = "0x601658A")]
    [Address(RVA = "0x207C420", Offset = "0x207C420", VA = "0x207C420", Slot = "12")]
    public void ChangeArea(int nextAreaId)
    {
    }

    [Token(Token = "0x601658B")]
    [Address(RVA = "0x2075D90", Offset = "0x2075D90", VA = "0x2075D90")]
    public void JumpNode(int nextNode)
    {
    }

    [Token(Token = "0x601658C")]
    [Address(RVA = "0x2073C0C", Offset = "0x2073C0C", VA = "0x2073C0C", Slot = "13")]
    public void UpdateCurrentCacheAreaData(int updatedNodeId = 0, int updatedAreaId = 0)
    {
    }

    [Token(Token = "0x601658D")]
    [Address(RVA = "0x207D2E0", Offset = "0x207D2E0", VA = "0x207D2E0")]
    private void UpdateCurrentAssignAreaNodeShortcutId()
    {
    }

    [Token(Token = "0x601658E")]
    [Address(RVA = "0x207BC00", Offset = "0x207BC00", VA = "0x207BC00")]
    public int GetJumpGroupIdBySelectedNodeId() => new int();

    [Token(Token = "0x601658F")]
    [Address(RVA = "0x207B268", Offset = "0x207B268", VA = "0x207B268")]
    public List<AreaQuestBoardTopModel.JumpNodeInfo> GetJumpNodes()
    {
      return (List<AreaQuestBoardTopModel.JumpNodeInfo>) null;
    }

    [Token(Token = "0x6016590")]
    [Address(RVA = "0x207D334", Offset = "0x207D334", VA = "0x207D334")]
    public (string, string) GetRawDataURL(int resourceId) => ();

    [Token(Token = "0x6016591")]
    [Address(RVA = "0x2073A4C", Offset = "0x2073A4C", VA = "0x2073A4C")]
    public bool IsPlayableThisArea() => new bool();

    [Token(Token = "0x6016592")]
    [Address(RVA = "0x2074CF8", Offset = "0x2074CF8", VA = "0x2074CF8")]
    public List<int> GetRequestUnlockAreaAnimAreaId() => (List<int>) null;

    [Token(Token = "0x6016593")]
    [Address(RVA = "0x207D52C", Offset = "0x207D52C", VA = "0x207D52C", Slot = "10")]
    public bool IsDirectedNode(int nodeId) => new bool();

    [Token(Token = "0x6016594")]
    [Address(RVA = "0x20766D0", Offset = "0x20766D0", VA = "0x20766D0")]
    public void CheckClearedThisNode(Action<int> onActionNotClearedThisNode)
    {
    }

    [Token(Token = "0x6016595")]
    [Address(RVA = "0x207473C", Offset = "0x207473C", VA = "0x207473C", Slot = "15")]
    public void SetSelectedDifficultyId(int selectedDifficultyId)
    {
    }

    [Token(Token = "0x6016596")]
    [Address(RVA = "0x207D5D8", Offset = "0x207D5D8", VA = "0x207D5D8")]
    private void ApplyResponse(APIAreaQuestResponse response)
    {
    }

    [Token(Token = "0x6016597")]
    [Address(RVA = "0x207DA90", Offset = "0x207DA90", VA = "0x207DA90")]
    private void UpdateRequestUnlockAnim()
    {
    }

    [Token(Token = "0x6016598")]
    [Address(RVA = "0x207DDFC", Offset = "0x207DDFC", VA = "0x207DDFC")]
    private bool IsNeedUnlockAnim(Scenes.OutGame.AreaQuestBoard.Top.CacheAreaData data)
    {
      return new bool();
    }

    [Token(Token = "0x6016599")]
    [Address(RVA = "0x2077720", Offset = "0x2077720", VA = "0x2077720", Slot = "14")]
    public IEnumerator ConnectAPIAreaQuest() => (IEnumerator) null;

    [Token(Token = "0x601659A")]
    [Address(RVA = "0x2075650", Offset = "0x2075650", VA = "0x2075650")]
    public void ConnectAPIAreaDirectionForAreaIds(Action onFinished = null)
    {
    }

    [Token(Token = "0x601659B")]
    [Address(RVA = "0x207DF10", Offset = "0x207DF10", VA = "0x207DF10")]
    private IEnumerator ConnectAPIAreaDirectionForAreaIdsSequence(Action onFinished = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601659C")]
    [Address(RVA = "0x20758EC", Offset = "0x20758EC", VA = "0x20758EC")]
    public void ConnectAPIAreaDirectionForNodeIds(
      IReadOnlyCollection<int> directedNodeIds,
      Action onFinished)
    {
    }

    [Token(Token = "0x601659D")]
    [Address(RVA = "0x207DFAC", Offset = "0x207DFAC", VA = "0x207DFAC")]
    private IEnumerator ConnectAPIAreaDirectionForNodeIdsSequence(
      IReadOnlyCollection<int> directedNodeIds,
      Action onFinished)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601659E")]
    [Address(RVA = "0x207E050", Offset = "0x207E050", VA = "0x207E050")]
    static AreaQuestBoardTopModel()
    {
    }

    [Token(Token = "0x20038D5")]
    internal struct AssetBundlePath
    {
      [Token(Token = "0x400F8A2")]
      [FieldOffset(Offset = "0x0")]
      public readonly string AssetBundleName;
      [Token(Token = "0x400F8A3")]
      [FieldOffset(Offset = "0x8")]
      public readonly string AssetName;

      [Token(Token = "0x601659F")]
      [Address(RVA = "0x207D010", Offset = "0x207D010", VA = "0x207D010")]
      public AssetBundlePath(int resourceId)
      {
      }
    }

    [Token(Token = "0x20038D6")]
    public struct JumpNodeInfo
    {
      [Token(Token = "0x400F8A4")]
      [FieldOffset(Offset = "0x0")]
      public readonly string Text;
      [Token(Token = "0x400F8A5")]
      [FieldOffset(Offset = "0x8")]
      public readonly int NodeId;
      [Token(Token = "0x400F8A6")]
      [FieldOffset(Offset = "0xC")]
      public readonly int AssignAreaNodeShortcutId;

      [Token(Token = "0x60165A0")]
      [Address(RVA = "0x207D328", Offset = "0x207D328", VA = "0x207D328")]
      public JumpNodeInfo(int nodeId, int assignAreaNodeShortcutId, string text)
      {
      }
    }
  }
}
