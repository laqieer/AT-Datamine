// Decompiled with JetBrains decompiler
// Type: Scenes.QuestNodeTree.AreaQuestNodeTreeTest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using Scenes.OutGame.AreaQuestBoard;
using System.Collections;
using UnityEngine;

#nullable disable
namespace Scenes.QuestNodeTree
{
  [Token(Token = "0x2002A11")]
  internal class AreaQuestNodeTreeTest : MonoBehaviour
  {
    [Token(Token = "0x400B306")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Vector2 cameraPosition;
    [Token(Token = "0x400B307")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private float cameraDistance;
    [Token(Token = "0x400B308")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private QuestNodeTreeView treeView;
    [Token(Token = "0x400B309")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private AreaQuestBackgroundController bgController;
    [Token(Token = "0x400B30A")]
    [FieldOffset(Offset = "0x38")]
    private AssetCachedSpawner usedSpawner;
    [Token(Token = "0x400B30B")]
    [FieldOffset(Offset = "0x40")]
    private int movieIndex;
    [Token(Token = "0x400B30C")]
    [FieldOffset(Offset = "0x44")]
    private int touchNodeId;

    [Token(Token = "0x60107A6")]
    [Address(RVA = "0x4894564", Offset = "0x4894564", VA = "0x4894564")]
    private void Awake()
    {
    }

    [Token(Token = "0x60107A7")]
    [Address(RVA = "0x48945D4", Offset = "0x48945D4", VA = "0x48945D4")]
    private void Start()
    {
    }

    [Token(Token = "0x60107A8")]
    [Address(RVA = "0x48946F4", Offset = "0x48946F4", VA = "0x48946F4")]
    private void Update()
    {
    }

    [Token(Token = "0x60107A9")]
    [Address(RVA = "0x489468C", Offset = "0x489468C", VA = "0x489468C")]
    private IEnumerator LoadAsync() => (IEnumerator) null;

    [Token(Token = "0x60107AA")]
    [Address(RVA = "0x48948F4", Offset = "0x48948F4", VA = "0x48948F4")]
    public AreaQuestNodeTreeTest()
    {
    }
  }
}
