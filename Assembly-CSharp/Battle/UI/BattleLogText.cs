// Decompiled with JetBrains decompiler
// Type: Battle.UI.BattleLogText
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002309")]
  public sealed class BattleLogText : InfiniteCellBase
  {
    [Token(Token = "0x400943E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text text;
    [Token(Token = "0x400943F")]
    [FieldOffset(Offset = "0x30")]
    private string textData;

    [Token(Token = "0x600D615")]
    [Address(RVA = "0x1D1A858", Offset = "0x1D1A858", VA = "0x1D1A858")]
    public void SetLogText()
    {
    }

    [Token(Token = "0x600D616")]
    [Address(RVA = "0x1D1A884", Offset = "0x1D1A884", VA = "0x1D1A884", Slot = "4")]
    public override void OnUpdate()
    {
    }

    [Token(Token = "0x600D617")]
    [Address(RVA = "0x1D1A928", Offset = "0x1D1A928", VA = "0x1D1A928")]
    public BattleLogText()
    {
    }
  }
}
