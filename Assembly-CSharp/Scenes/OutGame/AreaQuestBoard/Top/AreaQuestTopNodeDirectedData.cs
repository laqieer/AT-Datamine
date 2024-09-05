// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.AreaQuestBoard.Top.AreaQuestTopNodeDirectedData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Scenes.OutGame.AreaQuestBoard.Top
{
  [Token(Token = "0x20038F5")]
  public class AreaQuestTopNodeDirectedData
  {
    [Token(Token = "0x400F90C")]
    [FieldOffset(Offset = "0x10")]
    private readonly Dictionary<int, HashSet<int>> directedNodeIds;

    [Token(Token = "0x601663B")]
    [Address(RVA = "0x207DD1C", Offset = "0x207DD1C", VA = "0x207DD1C")]
    public AreaQuestTopNodeDirectedData(int areaGroupId, List<int> directedNodeIds)
    {
    }

    [Token(Token = "0x601663C")]
    [Address(RVA = "0x2081F3C", Offset = "0x2081F3C", VA = "0x2081F3C")]
    private AreaQuestTopNodeDirectedData(Dictionary<int, HashSet<int>> source)
    {
    }

    [Token(Token = "0x601663D")]
    [Address(RVA = "0x207E9D4", Offset = "0x207E9D4", VA = "0x207E9D4")]
    public AreaQuestTopNodeDirectedData Add(AreaQuestTopNodeDirectedData source)
    {
      return (AreaQuestTopNodeDirectedData) null;
    }

    [Token(Token = "0x601663E")]
    [Address(RVA = "0x207D550", Offset = "0x207D550", VA = "0x207D550")]
    public bool IsDirectedNode(int areaGroupId, int nodeId) => new bool();
  }
}
