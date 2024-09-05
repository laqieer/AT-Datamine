// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.AreaMap.UI.DebugAreaMapUIModelPlayerSetting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Scenes.DebugViewer.AreaMap.UI
{
  [Token(Token = "0x2002F55")]
  internal class DebugAreaMapUIModelPlayerSetting
  {
    [Token(Token = "0x400CADB")]
    [FieldOffset(Offset = "0x10")]
    private DebugAreaMapUIModel parent;
    [Token(Token = "0x400CADC")]
    [FieldOffset(Offset = "0x18")]
    public TableData CharacterModel;

    [Token(Token = "0x601280C")]
    [Address(RVA = "0x211DE14", Offset = "0x211DE14", VA = "0x211DE14")]
    public DebugAreaMapUIModelPlayerSetting(DebugAreaMapUIModel parent)
    {
    }

    [Token(Token = "0x601280D")]
    [Address(RVA = "0x2121324", Offset = "0x2121324", VA = "0x2121324")]
    public void ChangePlayerPosition(string anchorName)
    {
    }

    [Token(Token = "0x601280E")]
    [Address(RVA = "0x21213E0", Offset = "0x21213E0", VA = "0x21213E0")]
    public void ChangePlayerModel(int characterModelIdx, string anchorName)
    {
    }

    [Token(Token = "0x601280F")]
    [Address(RVA = "0x212116C", Offset = "0x212116C", VA = "0x212116C")]
    private void BuildTable()
    {
    }
  }
}
