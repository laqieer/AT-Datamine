// Decompiled with JetBrains decompiler
// Type: Battle.UI.CharacterActorUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x20023B0")]
  public class CharacterActorUI
  {
    [Token(Token = "0x4009810")]
    [FieldOffset(Offset = "0x10")]
    private BattleUnitSimplePanel simplePanel;
    [Token(Token = "0x4009811")]
    [FieldOffset(Offset = "0x18")]
    private BattleUnitSupportPointUpEffect supportEffect;
    [Token(Token = "0x4009812")]
    [FieldOffset(Offset = "0x20")]
    private BattleUnitFierceCount fierceCountPanel;
    [Token(Token = "0x4009813")]
    [FieldOffset(Offset = "0x28")]
    private List<BattleUnitTargetIcon> targetIcons;
    [Token(Token = "0x4009814")]
    [FieldOffset(Offset = "0x30")]
    private Dictionary<(int X, int Y), BattleUnitTargetIcon> targetIconsMap;
    [Token(Token = "0x4009815")]
    [FieldOffset(Offset = "0x38")]
    private Dictionary<int, Vector3> targetIconsOffset;
    [Token(Token = "0x4009816")]
    [FieldOffset(Offset = "0x40")]
    private List<string> rootObjectNames;
    [Token(Token = "0x4009817")]
    [FieldOffset(Offset = "0x48")]
    private WorldSpaceCanvasManager WorldSpaceCanvasManager;

    [Token(Token = "0x17002F18")]
    public BattleUnitSimplePanel SimplePanel
    {
      [Token(Token = "0x600DA68"), Address(RVA = "0x22D87D4", Offset = "0x22D87D4", VA = "0x22D87D4")] get
      {
        return (BattleUnitSimplePanel) null;
      }
    }

    [Token(Token = "0x17002F19")]
    private BattleUnitSupportPointUpEffect SupportEffect
    {
      [Token(Token = "0x600DA69"), Address(RVA = "0x22D87DC", Offset = "0x22D87DC", VA = "0x22D87DC")] get
      {
        return (BattleUnitSupportPointUpEffect) null;
      }
    }

    [Token(Token = "0x17002F1A")]
    public BattleUnitFierceCount FierceCountPanel
    {
      [Token(Token = "0x600DA6A"), Address(RVA = "0x22D87E4", Offset = "0x22D87E4", VA = "0x22D87E4")] get
      {
        return (BattleUnitFierceCount) null;
      }
    }

    [Token(Token = "0x600DA6B")]
    [Address(RVA = "0x22D87EC", Offset = "0x22D87EC", VA = "0x22D87EC")]
    public CharacterActorUI(
      string name,
      WorldSpaceCanvasManager worldSpaceCanvasManager,
      ISystemFlags systemFlags,
      BattleConfigAsset config,
      UnitParameterData unit)
    {
    }

    [Token(Token = "0x600DA6C")]
    [Address(RVA = "0x22D9094", Offset = "0x22D9094", VA = "0x22D9094")]
    public void Release()
    {
    }

    [Token(Token = "0x600DA6D")]
    [Address(RVA = "0x22D935C", Offset = "0x22D935C", VA = "0x22D935C")]
    public void Show()
    {
    }

    [Token(Token = "0x600DA6E")]
    [Address(RVA = "0x22D94E8", Offset = "0x22D94E8", VA = "0x22D94E8")]
    public void Hide()
    {
    }

    [Token(Token = "0x600DA6F")]
    [Address(RVA = "0x22D9674", Offset = "0x22D9674", VA = "0x22D9674")]
    public void UpdateLocalPosition(Vector3 position)
    {
    }

    [Token(Token = "0x600DA70")]
    [Address(RVA = "0x22D98E8", Offset = "0x22D98E8", VA = "0x22D98E8")]
    public void SetVisibleTargetableIcon(
      BattleUnitTargetIcon.TargetType type,
      (int X, int Y)? indexGridData = null,
      bool isSelectGrid = false)
    {
    }

    [Token(Token = "0x600DA71")]
    [Address(RVA = "0x22D9ABC", Offset = "0x22D9ABC", VA = "0x22D9ABC")]
    public void SetUnitNumber(int num)
    {
    }

    [Token(Token = "0x600DA72")]
    [Address(RVA = "0x22D9AD8", Offset = "0x22D9AD8", VA = "0x22D9AD8")]
    public void PlaySupportEffect(Transform transform, CameraDirector camera)
    {
    }

    [Token(Token = "0x20023B1")]
    public enum LargeUnitPanelAmount
    {
      [Token(Token = "0x4009819")] Four = 4,
      [Token(Token = "0x400981A")] Nine = 9,
    }
  }
}
