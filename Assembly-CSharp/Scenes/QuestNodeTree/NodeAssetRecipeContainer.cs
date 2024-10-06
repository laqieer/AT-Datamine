// Decompiled with JetBrains decompiler
// Type: Scenes.QuestNodeTree.NodeAssetRecipeContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Scenes.QuestNodeTree
{
  [Token(Token = "0x2002A18")]
  public class NodeAssetRecipeContainer
  {
    [Token(Token = "0x400B31F")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<int, NodeAssetRecipe> nodeAssetConfigList;
    [Token(Token = "0x400B320")]
    [FieldOffset(Offset = "0x18")]
    private List<int> loadRequestList;

    [Token(Token = "0x60107C2")]
    [Address(RVA = "0x4895684", Offset = "0x4895684", VA = "0x4895684")]
    public void Initialize()
    {
    }

    [Token(Token = "0x60107C3")]
    [Address(RVA = "0x4895688", Offset = "0x4895688", VA = "0x4895688")]
    public void Destroy()
    {
    }

    [Token(Token = "0x60107C4")]
    [Address(RVA = "0x489568C", Offset = "0x489568C", VA = "0x489568C")]
    public void Clear()
    {
    }

    [Token(Token = "0x60107C5")]
    [Address(RVA = "0x48956DC", Offset = "0x48956DC", VA = "0x48956DC")]
    public void AddRequest(int resourceId)
    {
    }

    [Token(Token = "0x60107C6")]
    [Address(RVA = "0x48957B0", Offset = "0x48957B0", VA = "0x48957B0")]
    public void StartRequests(AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x60107C7")]
    [Address(RVA = "0x4895AD8", Offset = "0x4895AD8", VA = "0x4895AD8")]
    public NodeAssetRecipe GetRecipe(int resourceId) => (NodeAssetRecipe) null;

    [Token(Token = "0x60107C8")]
    [Address(RVA = "0x4895920", Offset = "0x4895920", VA = "0x4895920")]
    private void LoadRequest(AssetCachedSpawner spawner, int requestId)
    {
    }

    [Token(Token = "0x60107C9")]
    [Address(RVA = "0x4895B58", Offset = "0x4895B58", VA = "0x4895B58")]
    public NodeAssetRecipeContainer()
    {
    }
  }
}
