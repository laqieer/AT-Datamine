// Decompiled with JetBrains decompiler
// Type: Scenes.QuestNodeTree.NodeAssetUnitContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.QuestNodeTree
{
  [Token(Token = "0x2002A1A")]
  public class NodeAssetUnitContainer
  {
    [Token(Token = "0x400B323")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<int, GameObject> unitList;
    [Token(Token = "0x400B324")]
    [FieldOffset(Offset = "0x18")]
    private List<int> loadRequestList;
    [Token(Token = "0x400B325")]
    [FieldOffset(Offset = "0x20")]
    private QuestNodeUnit unitPrefab;

    [Token(Token = "0x60107CC")]
    [Address(RVA = "0x4895C7C", Offset = "0x4895C7C", VA = "0x4895C7C")]
    public void Initialize()
    {
    }

    [Token(Token = "0x60107CD")]
    [Address(RVA = "0x4895C80", Offset = "0x4895C80", VA = "0x4895C80")]
    public void Destroy()
    {
    }

    [Token(Token = "0x60107CE")]
    [Address(RVA = "0x4895C84", Offset = "0x4895C84", VA = "0x4895C84")]
    public void Clear()
    {
    }

    [Token(Token = "0x60107CF")]
    [Address(RVA = "0x4895CD4", Offset = "0x4895CD4", VA = "0x4895CD4")]
    public void SetNodePrefab(QuestNodeUnit prefab)
    {
    }

    [Token(Token = "0x60107D0")]
    [Address(RVA = "0x4895CDC", Offset = "0x4895CDC", VA = "0x4895CDC")]
    public void AddRequest(int styleId)
    {
    }

    [Token(Token = "0x60107D1")]
    [Address(RVA = "0x4895DB4", Offset = "0x4895DB4", VA = "0x4895DB4")]
    public void StartRequests(AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x60107D2")]
    [Address(RVA = "0x4896070", Offset = "0x4896070", VA = "0x4896070")]
    public QuestNodeUnit Create(int styleId) => (QuestNodeUnit) null;

    [Token(Token = "0x60107D3")]
    [Address(RVA = "0x4895F24", Offset = "0x4895F24", VA = "0x4895F24")]
    private void LoadRequest(AssetCachedSpawner spawner, int styleId)
    {
    }

    [Token(Token = "0x60107D4")]
    [Address(RVA = "0x4896170", Offset = "0x4896170", VA = "0x4896170")]
    public NodeAssetUnitContainer()
    {
    }
  }
}
