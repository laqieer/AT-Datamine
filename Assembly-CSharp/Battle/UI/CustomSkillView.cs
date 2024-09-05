// Decompiled with JetBrains decompiler
// Type: Battle.UI.CustomSkillView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Scenes.OutGame.Info.Skill;
using Scenes.OutGame.Info.Unit;
using TeamOrganization;
using UnityEngine;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002380")]
  public class CustomSkillView : MonoBehaviour
  {
    [Token(Token = "0x4009728")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CustomSkillSlotUI[] slotUIs;

    [Token(Token = "0x600D8D4")]
    [Address(RVA = "0x1B9989C", Offset = "0x1B9989C", VA = "0x1B9989C")]
    public void UpdateView(UnitModelBase unit)
    {
    }

    [Token(Token = "0x600D8D5")]
    [Address(RVA = "0x1B99A04", Offset = "0x1B99A04", VA = "0x1B99A04")]
    private void UpdateView(CustomSkillSlotUI ui, SkillModelBase skill)
    {
    }

    [Token(Token = "0x600D8D6")]
    [Address(RVA = "0x1B99BB8", Offset = "0x1B99BB8", VA = "0x1B99BB8")]
    private void EmptyView(CustomSkillSlotUI ui)
    {
    }

    [Token(Token = "0x600D8D7")]
    [Address(RVA = "0x1B99C38", Offset = "0x1B99C38", VA = "0x1B99C38")]
    public CustomSkillView()
    {
    }
  }
}
