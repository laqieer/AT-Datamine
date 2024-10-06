// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.AreaMap.UI.DebugAreaMapUIModelLayoutCreate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Data;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Scenes.DebugViewer.AreaMap.UI
{
  [Token(Token = "0x2002F4A")]
  internal class DebugAreaMapUIModelLayoutCreate
  {
    [Token(Token = "0x400CABB")]
    [FieldOffset(Offset = "0x10")]
    private DebugAreaMapUIModel parent;

    [Token(Token = "0x17003EA1")]
    public TableData SettingList
    {
      [Token(Token = "0x60127C1"), Address(RVA = "0x211F488", Offset = "0x211F488", VA = "0x211F488")] private set
      {
      }
      [Token(Token = "0x60127C2"), Address(RVA = "0x211F490", Offset = "0x211F490", VA = "0x211F490")] get
      {
        return (TableData) null;
      }
    }

    [Token(Token = "0x17003EA2")]
    public BindingParam<List<AreaConnectParam>> AreaConnectParams
    {
      [Token(Token = "0x60127C3"), Address(RVA = "0x211F498", Offset = "0x211F498", VA = "0x211F498")] private set
      {
      }
      [Token(Token = "0x60127C4"), Address(RVA = "0x211F4A0", Offset = "0x211F4A0", VA = "0x211F4A0")] get
      {
        return (BindingParam<List<AreaConnectParam>>) null;
      }
    }

    [Token(Token = "0x60127C5")]
    [Address(RVA = "0x211DBF0", Offset = "0x211DBF0", VA = "0x211DBF0")]
    public DebugAreaMapUIModelLayoutCreate(DebugAreaMapUIModel parent)
    {
    }

    [Token(Token = "0x60127C6")]
    [Address(RVA = "0x211D194", Offset = "0x211D194", VA = "0x211D194")]
    public void RequestCreate(int settingIndex)
    {
    }

    [Token(Token = "0x60127C7")]
    [Address(RVA = "0x211D2D0", Offset = "0x211D2D0", VA = "0x211D2D0")]
    public void RequestDelete()
    {
    }

    [Token(Token = "0x60127C8")]
    [Address(RVA = "0x211D3E4", Offset = "0x211D3E4", VA = "0x211D3E4")]
    public void WarpToAreaConnectAnchor(int paramIndex)
    {
    }

    [Token(Token = "0x60127C9")]
    [Address(RVA = "0x211D500", Offset = "0x211D500", VA = "0x211D500")]
    public void TransitionArea(int paramIndex)
    {
    }

    [Token(Token = "0x60127CA")]
    [Address(RVA = "0x211F660", Offset = "0x211F660", VA = "0x211F660")]
    private void UpdateAreaConnectParam(int areaId)
    {
    }

    [Token(Token = "0x60127CB")]
    [Address(RVA = "0x211F4A8", Offset = "0x211F4A8", VA = "0x211F4A8")]
    private void BuildTable()
    {
    }
  }
}
