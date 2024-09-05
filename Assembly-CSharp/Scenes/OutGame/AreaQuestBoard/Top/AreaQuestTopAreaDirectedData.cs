// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.AreaQuestBoard.Top.AreaQuestTopAreaDirectedData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Scenes.OutGame.AreaQuestBoard.Top
{
  [Token(Token = "0x20038F4")]
  public class AreaQuestTopAreaDirectedData
  {
    [Token(Token = "0x400F90B")]
    [FieldOffset(Offset = "0x10")]
    private readonly Dictionary<int, HashSet<int>> directedAreaIds;

    [Token(Token = "0x6016637")]
    [Address(RVA = "0x207D9B0", Offset = "0x207D9B0", VA = "0x207D9B0")]
    public AreaQuestTopAreaDirectedData(int areaGroupId, List<int> directedAreaIds)
    {
    }

    [Token(Token = "0x6016638")]
    [Address(RVA = "0x2081F14", Offset = "0x2081F14", VA = "0x2081F14")]
    private AreaQuestTopAreaDirectedData(Dictionary<int, HashSet<int>> source)
    {
    }

    [Token(Token = "0x6016639")]
    [Address(RVA = "0x207E470", Offset = "0x207E470", VA = "0x207E470")]
    public AreaQuestTopAreaDirectedData Add(AreaQuestTopAreaDirectedData source)
    {
      return (AreaQuestTopAreaDirectedData) null;
    }

    [Token(Token = "0x601663A")]
    [Address(RVA = "0x207DE60", Offset = "0x207DE60", VA = "0x207DE60")]
    public bool IsDirectedArea(int areaGroupId, int areaId) => new bool();
  }
}
