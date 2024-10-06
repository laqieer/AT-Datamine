// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.AreaQuestBoard.MapController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using Il2CppDummyDll;
using Scenes.OutGame.AreaQuestBoard.Top;
using Scenes.QuestNodeTree;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.AreaQuestBoard
{
  [Token(Token = "0x20038C8")]
  internal class MapController
  {
    [Token(Token = "0x400F85C")]
    [FieldOffset(Offset = "0x18")]
    private QuestNodeTreeView _nodeTree;
    [Token(Token = "0x400F85D")]
    [FieldOffset(Offset = "0x20")]
    private Action<Vector2> _tapAction;
    [Token(Token = "0x400F85E")]
    [FieldOffset(Offset = "0x28")]
    private Action<int, bool> _onSelectedNode;
    [Token(Token = "0x400F85F")]
    [FieldOffset(Offset = "0x30")]
    private Action _closeSubMenu;
    [Token(Token = "0x400F860")]
    [FieldOffset(Offset = "0x38")]
    private CameraController _cameraController;
    [Token(Token = "0x400F861")]
    [FieldOffset(Offset = "0x40")]
    private int areaId;

    [Token(Token = "0x17004978")]
    public bool IsInitialized
    {
      [Token(Token = "0x601651C"), Address(RVA = "0x2078974", Offset = "0x2078974", VA = "0x2078974")] get
      {
        return new bool();
      }
      [Token(Token = "0x601651D"), Address(RVA = "0x207897C", Offset = "0x207897C", VA = "0x207897C")] private set
      {
      }
    }

    [Token(Token = "0x17004979")]
    public bool IsUnleashEffectNode
    {
      [Token(Token = "0x601651E"), Address(RVA = "0x2078988", Offset = "0x2078988", VA = "0x2078988")] get
      {
        return new bool();
      }
      [Token(Token = "0x601651F"), Address(RVA = "0x2078990", Offset = "0x2078990", VA = "0x2078990")] private set
      {
      }
    }

    [Token(Token = "0x6016520")]
    [Address(RVA = "0x20777F0", Offset = "0x20777F0", VA = "0x20777F0")]
    public MapController(
      IAreaQuestBoardModel model,
      AssetCachedSpawner spawner,
      QuestNodeTreeView treeView,
      Action<int, bool> onSelectNode,
      Action closeSubMenu,
      Action<IReadOnlyCollection<int>> onScheduledDirectionNodes)
    {
    }

    [Token(Token = "0x6016521")]
    [Address(RVA = "0x2076354", Offset = "0x2076354", VA = "0x2076354")]
    public void ChangeArea(
      IAreaQuestBoardModel model,
      Action onInitializeFinish,
      Action<IReadOnlyCollection<int>> onScheduledDirectionNodes)
    {
    }

    [Token(Token = "0x6016522")]
    [Address(RVA = "0x20741CC", Offset = "0x20741CC", VA = "0x20741CC")]
    public void ChangeDifficulty(int areaId, QuestDifficultyTypeEnum diffType)
    {
    }

    [Token(Token = "0x6016523")]
    [Address(RVA = "0x207655C", Offset = "0x207655C", VA = "0x207655C")]
    public IEnumerator EnableEffect() => (IEnumerator) null;

    [Token(Token = "0x6016524")]
    [Address(RVA = "0x2073F18", Offset = "0x2073F18", VA = "0x2073F18")]
    public void SetFocusNode(int nodeId, bool isMove = true, Action<bool> onFinish = null)
    {
    }

    [Token(Token = "0x6016525")]
    [Address(RVA = "0x20765C4", Offset = "0x20765C4", VA = "0x20765C4")]
    public void TryAutoMoveNextNode(int currentNodeId, Action<int> onMoveFinish)
    {
    }

    [Token(Token = "0x6016526")]
    [Address(RVA = "0x2078C8C", Offset = "0x2078C8C", VA = "0x2078C8C")]
    public void EnableCamera(bool enable)
    {
    }

    [Token(Token = "0x6016527")]
    [Address(RVA = "0x2073DA4", Offset = "0x2073DA4", VA = "0x2073DA4")]
    public void ChangeCameraPosForOpenSubMenu(int nodeId)
    {
    }

    [Token(Token = "0x6016528")]
    [Address(RVA = "0x20766A8", Offset = "0x20766A8", VA = "0x20766A8")]
    public void OnEnable()
    {
    }

    [Token(Token = "0x6016529")]
    [Address(RVA = "0x2075314", Offset = "0x2075314", VA = "0x2075314")]
    public void OnDisabled()
    {
    }

    [Token(Token = "0x601652A")]
    [Address(RVA = "0x207899C", Offset = "0x207899C", VA = "0x207899C")]
    private void Initialize(
      IAreaQuestBoardModel model,
      Action onInitializeFinish = null,
      Action<IReadOnlyCollection<int>> onScheduledDirectionNodes = null)
    {
    }

    [Token(Token = "0x601652B")]
    [Address(RVA = "0x2078CB4", Offset = "0x2078CB4", VA = "0x2078CB4")]
    private void AddNodeTree(int areaId, QuestDifficultyTypeEnum diffType)
    {
    }

    [Token(Token = "0x601652C")]
    [Address(RVA = "0x2079038", Offset = "0x2079038", VA = "0x2079038")]
    private void SetUnleashEffectNode(
      int currentNodeId,
      Action<IReadOnlyCollection<int>> onScheduledDirectionNodes,
      IAreaQuestBoardModel model)
    {
    }

    [Token(Token = "0x601652D")]
    [Address(RVA = "0x2078BC0", Offset = "0x2078BC0", VA = "0x2078BC0")]
    private NodeStateType GetNodeStateType(int nodeId, QuestDifficultyTypeEnum diffType)
    {
      return new NodeStateType();
    }

    [Token(Token = "0x601652E")]
    [Address(RVA = "0x207953C", Offset = "0x207953C", VA = "0x207953C")]
    private void CheckNode(Vector2 position)
    {
    }

    [Token(Token = "0x601652F")]
    [Address(RVA = "0x2078F60", Offset = "0x2078F60", VA = "0x2078F60")]
    private int GetAvatarStyleId() => new int();
  }
}
