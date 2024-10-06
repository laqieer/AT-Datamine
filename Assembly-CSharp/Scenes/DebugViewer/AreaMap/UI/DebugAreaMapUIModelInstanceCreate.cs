// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.AreaMap.UI.DebugAreaMapUIModelInstanceCreate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.DebugViewer.AreaMap.UI
{
  [Token(Token = "0x2002F47")]
  internal class DebugAreaMapUIModelInstanceCreate
  {
    [Token(Token = "0x400CAAD")]
    [FieldOffset(Offset = "0x10")]
    private DebugAreaMapUIModel parent;
    [Token(Token = "0x400CAAE")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, DebugAreaMapUIModelInstanceCreate.ModelInfo> ModelInfoList;

    [Token(Token = "0x17003E9E")]
    public BindingParam<List<string>> AnchorList
    {
      [Token(Token = "0x60127AB"), Address(RVA = "0x211EAC0", Offset = "0x211EAC0", VA = "0x211EAC0")] private set
      {
      }
      [Token(Token = "0x60127AC"), Address(RVA = "0x211EAC8", Offset = "0x211EAC8", VA = "0x211EAC8")] get
      {
        return (BindingParam<List<string>>) null;
      }
    }

    [Token(Token = "0x17003E9F")]
    public TableData ObjectBehaviourList
    {
      [Token(Token = "0x60127AD"), Address(RVA = "0x211EAD0", Offset = "0x211EAD0", VA = "0x211EAD0")] private set
      {
      }
      [Token(Token = "0x60127AE"), Address(RVA = "0x211EAD8", Offset = "0x211EAD8", VA = "0x211EAD8")] get
      {
        return (TableData) null;
      }
    }

    [Token(Token = "0x17003EA0")]
    public TableData RewardObjectModelList
    {
      [Token(Token = "0x60127AF"), Address(RVA = "0x211EAE0", Offset = "0x211EAE0", VA = "0x211EAE0")] private set
      {
      }
      [Token(Token = "0x60127B0"), Address(RVA = "0x211EAE8", Offset = "0x211EAE8", VA = "0x211EAE8")] get
      {
        return (TableData) null;
      }
    }

    [Token(Token = "0x60127B1")]
    [Address(RVA = "0x211DA74", Offset = "0x211DA74", VA = "0x211DA74")]
    public DebugAreaMapUIModelInstanceCreate(DebugAreaMapUIModel parent)
    {
    }

    [Token(Token = "0x60127B2")]
    [Address(RVA = "0x211EDE4", Offset = "0x211EDE4", VA = "0x211EDE4")]
    public void RequestCreate(
      int id,
      InstanceType type,
      int anchorIdx,
      int modelIdx,
      string animation)
    {
    }

    [Token(Token = "0x60127B3")]
    [Address(RVA = "0x211F054", Offset = "0x211F054", VA = "0x211F054")]
    public void RequestDelete(int id)
    {
    }

    [Token(Token = "0x60127B4")]
    [Address(RVA = "0x211F0C4", Offset = "0x211F0C4", VA = "0x211F0C4")]
    public void SelectHierarchy(int id)
    {
    }

    [Token(Token = "0x60127B5")]
    [Address(RVA = "0x211F148", Offset = "0x211F148", VA = "0x211F148")]
    public void OpenRewardInstance(int id)
    {
    }

    [Token(Token = "0x60127B6")]
    [Address(RVA = "0x211CCD0", Offset = "0x211CCD0", VA = "0x211CCD0")]
    public void BreakRewardInstance(int id, Vector3 force)
    {
    }

    [Token(Token = "0x60127B7")]
    [Address(RVA = "0x211C528", Offset = "0x211C528", VA = "0x211C528")]
    public void CopyClipboard()
    {
    }

    [Token(Token = "0x60127B8")]
    [Address(RVA = "0x211F230", Offset = "0x211F230", VA = "0x211F230")]
    private void UpdateAnchor()
    {
    }

    [Token(Token = "0x60127B9")]
    [Address(RVA = "0x211EAF0", Offset = "0x211EAF0", VA = "0x211EAF0")]
    private void BuildTable()
    {
    }

    [Token(Token = "0x60127BA")]
    [Address(RVA = "0x211EFA8", Offset = "0x211EFA8", VA = "0x211EFA8")]
    private TableData.Value GetModelParam(InstanceType type, int modelIdx) => new TableData.Value();

    [Token(Token = "0x2002F48")]
    private struct ModelInfo
    {
      [Token(Token = "0x400CAB2")]
      [FieldOffset(Offset = "0x0")]
      public int id;
      [Token(Token = "0x400CAB3")]
      [FieldOffset(Offset = "0x4")]
      public InstanceType type;
      [Token(Token = "0x400CAB4")]
      [FieldOffset(Offset = "0x8")]
      public int modelId;
      [Token(Token = "0x400CAB5")]
      [FieldOffset(Offset = "0x10")]
      public string modelName;
      [Token(Token = "0x400CAB6")]
      [FieldOffset(Offset = "0x18")]
      public string anchorName;
    }
  }
}
