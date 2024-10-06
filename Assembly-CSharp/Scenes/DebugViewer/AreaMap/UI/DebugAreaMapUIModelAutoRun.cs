// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.AreaMap.UI.DebugAreaMapUIModelAutoRun
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Instance;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

#nullable disable
namespace Scenes.DebugViewer.AreaMap.UI
{
  [Token(Token = "0x2002F41")]
  internal class DebugAreaMapUIModelAutoRun
  {
    [Token(Token = "0x400CA9C")]
    [FieldOffset(Offset = "0x10")]
    private DebugAreaMapUIModel parent;
    [Token(Token = "0x400CA9D")]
    [FieldOffset(Offset = "0x18")]
    private NavMeshAgent navMeshAgent;

    [Token(Token = "0x17003E9B")]
    public BindingParam<MeshFilter[]> Meshes
    {
      [Token(Token = "0x601278C"), Address(RVA = "0x211DF94", Offset = "0x211DF94", VA = "0x211DF94")] private set
      {
      }
      [Token(Token = "0x601278D"), Address(RVA = "0x211DF9C", Offset = "0x211DF9C", VA = "0x211DF9C")] get
      {
        return (BindingParam<MeshFilter[]>) null;
      }
    }

    [Token(Token = "0x601278E")]
    [Address(RVA = "0x211DE40", Offset = "0x211DE40", VA = "0x211DE40")]
    public DebugAreaMapUIModelAutoRun(DebugAreaMapUIModel parent)
    {
    }

    [Token(Token = "0x601278F")]
    [Address(RVA = "0x211D8C0", Offset = "0x211D8C0", VA = "0x211D8C0")]
    public void StartAutoRun(string anchorName)
    {
    }

    [Token(Token = "0x6012790")]
    [Address(RVA = "0x211D998", Offset = "0x211D998", VA = "0x211D998")]
    public void StopAutoRun()
    {
    }

    [Token(Token = "0x6012791")]
    [Address(RVA = "0x211D9EC", Offset = "0x211D9EC", VA = "0x211D9EC")]
    public void ShowGizmos()
    {
    }

    [Token(Token = "0x6012792")]
    [Address(RVA = "0x211E014", Offset = "0x211E014", VA = "0x211E014")]
    public NavMeshPath CalculatePath(string anchorName) => (NavMeshPath) null;

    [Token(Token = "0x6012793")]
    [Address(RVA = "0x211E0D8", Offset = "0x211E0D8", VA = "0x211E0D8")]
    private void CreateNavMeshData()
    {
    }

    [Token(Token = "0x6012794")]
    [Address(RVA = "0x211E350", Offset = "0x211E350", VA = "0x211E350")]
    private void GetNavMeshAgent(FreeMapPlayerInstance playerBase)
    {
    }
  }
}
