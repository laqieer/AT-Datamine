// Decompiled with JetBrains decompiler
// Type: Story.Chart.StructureSave.ChartStructureScriptableObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Story.Chart.StructureSave
{
  [Token(Token = "0x2000719")]
  [CreateAssetMenu(fileName = "ChartStructure", menuName = "ScriptableObjects/ChartStructureScriptableObject")]
  public class ChartStructureScriptableObject : ScriptableObject
  {
    [Token(Token = "0x40020F8")]
    [FieldOffset(Offset = "0x18")]
    public int chapter;
    [Token(Token = "0x40020F9")]
    [FieldOffset(Offset = "0x20")]
    public SerializeNode[] nodes;

    [Token(Token = "0x60027FC")]
    [Address(RVA = "0x3671C88", Offset = "0x3671C88", VA = "0x3671C88")]
    public ChartStructureScriptableObject()
    {
    }
  }
}
