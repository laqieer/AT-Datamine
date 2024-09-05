// Decompiled with JetBrains decompiler
// Type: Battle.UI.UnitStatusTween
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x200235F")]
  public sealed class UnitStatusTween : TweenWrapper
  {
    [Token(Token = "0x400964D")]
    [FieldOffset(Offset = "0x20")]
    [HideInInspector]
    [SerializeField]
    private string rearName;
    [Token(Token = "0x400964E")]
    [FieldOffset(Offset = "0x28")]
    [HideInInspector]
    [SerializeField]
    private string frontName;
    [Token(Token = "0x400964F")]
    [FieldOffset(Offset = "0x30")]
    [HideInInspector]
    [SerializeField]
    private string doubledName;
    [Token(Token = "0x4009650")]
    [FieldOffset(Offset = "0x38")]
    [HideInInspector]
    [SerializeField]
    private string nonDoubledName;
    [Token(Token = "0x4009651")]
    [FieldOffset(Offset = "0x40")]
    [HideInInspector]
    [SerializeField]
    private string deadName;
    [Token(Token = "0x4009652")]
    [FieldOffset(Offset = "0x48")]
    [HideInInspector]
    [SerializeField]
    private string aliveName;
    [Token(Token = "0x4009653")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    [HideInInspector]
    private string ownColorName;
    [Token(Token = "0x4009654")]
    [FieldOffset(Offset = "0x58")]
    [HideInInspector]
    [SerializeField]
    private string enemyColorName;
    [Token(Token = "0x4009655")]
    [FieldOffset(Offset = "0x60")]
    [HideInInspector]
    [SerializeField]
    private string neutralColorName;
    [Token(Token = "0x4009656")]
    [FieldOffset(Offset = "0x68")]
    [HideInInspector]
    [SerializeField]
    private string allyColorName;

    [Token(Token = "0x600D7F4")]
    [Address(RVA = "0x1B8EE0C", Offset = "0x1B8EE0C", VA = "0x1B8EE0C")]
    public void Rear()
    {
    }

    [Token(Token = "0x600D7F5")]
    [Address(RVA = "0x1B8EEB4", Offset = "0x1B8EEB4", VA = "0x1B8EEB4")]
    public void Front()
    {
    }

    [Token(Token = "0x600D7F6")]
    [Address(RVA = "0x1B8EF5C", Offset = "0x1B8EF5C", VA = "0x1B8EF5C")]
    public void Doubled()
    {
    }

    [Token(Token = "0x600D7F7")]
    [Address(RVA = "0x1B8F004", Offset = "0x1B8F004", VA = "0x1B8F004")]
    public void NonDoubled()
    {
    }

    [Token(Token = "0x600D7F8")]
    [Address(RVA = "0x1B8F0AC", Offset = "0x1B8F0AC", VA = "0x1B8F0AC")]
    public void Dead()
    {
    }

    [Token(Token = "0x600D7F9")]
    [Address(RVA = "0x1B8F154", Offset = "0x1B8F154", VA = "0x1B8F154")]
    public void Alive()
    {
    }

    [Token(Token = "0x600D7FA")]
    [Address(RVA = "0x1B8F1FC", Offset = "0x1B8F1FC", VA = "0x1B8F1FC")]
    public void ColorOwn()
    {
    }

    [Token(Token = "0x600D7FB")]
    [Address(RVA = "0x1B8F2A4", Offset = "0x1B8F2A4", VA = "0x1B8F2A4")]
    public void ColorEnemy()
    {
    }

    [Token(Token = "0x600D7FC")]
    [Address(RVA = "0x1B8F34C", Offset = "0x1B8F34C", VA = "0x1B8F34C")]
    public void ColorNeutral()
    {
    }

    [Token(Token = "0x600D7FD")]
    [Address(RVA = "0x1B8F3F4", Offset = "0x1B8F3F4", VA = "0x1B8F3F4")]
    public void ColorAlly()
    {
    }

    [Token(Token = "0x600D7FE")]
    [Address(RVA = "0x1B8F49C", Offset = "0x1B8F49C", VA = "0x1B8F49C", Slot = "7")]
    protected override void LateUpdate()
    {
    }

    [Token(Token = "0x600D7FF")]
    [Address(RVA = "0x1B8F4A0", Offset = "0x1B8F4A0", VA = "0x1B8F4A0")]
    public UnitStatusTween()
    {
    }
  }
}
