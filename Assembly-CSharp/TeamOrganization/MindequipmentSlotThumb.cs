// Decompiled with JetBrains decompiler
// Type: TeamOrganization.MindequipmentSlotThumb
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace TeamOrganization
{
  [Token(Token = "0x20007DE")]
  public class MindequipmentSlotThumb : EquipmentSlotThumb
  {
    [Token(Token = "0x40024D8")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private GameObject thumbObj;
    [Token(Token = "0x40024D9")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private GameObject attentionIcon;

    [Token(Token = "0x6002C7B")]
    [Address(RVA = "0x387EC38", Offset = "0x387EC38", VA = "0x387EC38")]
    public void SetSpawner()
    {
    }

    [Token(Token = "0x6002C7C")]
    [Address(RVA = "0x387ECB8", Offset = "0x387ECB8", VA = "0x387ECB8")]
    public void ChangePosition()
    {
    }

    [Token(Token = "0x6002C7D")]
    [Address(RVA = "0x387EDC0", Offset = "0x387EDC0", VA = "0x387EDC0")]
    public void SetAttentionIcon(bool isAttention)
    {
    }

    [Token(Token = "0x6002C7E")]
    [Address(RVA = "0x387EDE0", Offset = "0x387EDE0", VA = "0x387EDE0")]
    public void SetActiveThumbnail(bool isActive)
    {
    }

    [Token(Token = "0x6002C7F")]
    [Address(RVA = "0x387EE00", Offset = "0x387EE00", VA = "0x387EE00")]
    public MindequipmentSlotThumb()
    {
    }
  }
}
