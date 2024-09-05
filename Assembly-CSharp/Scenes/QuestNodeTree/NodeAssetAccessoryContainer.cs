// Decompiled with JetBrains decompiler
// Type: Scenes.QuestNodeTree.NodeAssetAccessoryContainer
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
  [Token(Token = "0x2002A15")]
  public class NodeAssetAccessoryContainer
  {
    [Token(Token = "0x400B314")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<int, GameObject> accessoryList;
    [Token(Token = "0x400B315")]
    [FieldOffset(Offset = "0x18")]
    private List<int> loadRequestList;

    [Token(Token = "0x60107B7")]
    [Address(RVA = "0x4895018", Offset = "0x4895018", VA = "0x4895018")]
    public void Initialize()
    {
    }

    [Token(Token = "0x60107B8")]
    [Address(RVA = "0x489501C", Offset = "0x489501C", VA = "0x489501C")]
    public void Destroy()
    {
    }

    [Token(Token = "0x60107B9")]
    [Address(RVA = "0x4895020", Offset = "0x4895020", VA = "0x4895020")]
    public void Clear()
    {
    }

    [Token(Token = "0x60107BA")]
    [Address(RVA = "0x4895070", Offset = "0x4895070", VA = "0x4895070")]
    public void AddRequest(int accessoryId)
    {
    }

    [Token(Token = "0x60107BB")]
    [Address(RVA = "0x4895148", Offset = "0x4895148", VA = "0x4895148")]
    public void StartRequests(AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x60107BC")]
    [Address(RVA = "0x4895470", Offset = "0x4895470", VA = "0x4895470")]
    public QuestNodeAccessory Create(int accessoryId) => (QuestNodeAccessory) null;

    [Token(Token = "0x60107BD")]
    [Address(RVA = "0x48952B8", Offset = "0x48952B8", VA = "0x48952B8")]
    private void LoadRequest(AssetCachedSpawner spawner, int accessoryId)
    {
    }

    [Token(Token = "0x60107BE")]
    [Address(RVA = "0x4895558", Offset = "0x4895558", VA = "0x4895558")]
    public NodeAssetAccessoryContainer()
    {
    }
  }
}
