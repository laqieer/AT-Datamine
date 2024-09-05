// Decompiled with JetBrains decompiler
// Type: Battle.UI.StatusConditionModelList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002399")]
  public class StatusConditionModelList
  {
    [Token(Token = "0x17002ED6")]
    public List<StatusConditionModel> Models
    {
      [Token(Token = "0x600D988"), Address(RVA = "0x22CE6A0", Offset = "0x22CE6A0", VA = "0x22CE6A0")] get
      {
        return (List<StatusConditionModel>) null;
      }
      [Token(Token = "0x600D989"), Address(RVA = "0x22CE6A8", Offset = "0x22CE6A8", VA = "0x22CE6A8")] private set
      {
      }
    }

    [Token(Token = "0x17002ED7")]
    public List<StatusConditionModel> SimpleModels
    {
      [Token(Token = "0x600D98A"), Address(RVA = "0x22CE6B0", Offset = "0x22CE6B0", VA = "0x22CE6B0")] get
      {
        return (List<StatusConditionModel>) null;
      }
      [Token(Token = "0x600D98B"), Address(RVA = "0x22CE6B8", Offset = "0x22CE6B8", VA = "0x22CE6B8")] private set
      {
      }
    }

    [Token(Token = "0x600D98C")]
    [Address(RVA = "0x22CE6C0", Offset = "0x22CE6C0", VA = "0x22CE6C0")]
    public void Set(UnitParameterData unit)
    {
    }

    [Token(Token = "0x600D98D")]
    [Address(RVA = "0x22CE9E0", Offset = "0x22CE9E0", VA = "0x22CE9E0")]
    private void SetSimpleModel(List<EffectParameterData> effectParameters)
    {
    }

    [Token(Token = "0x600D98E")]
    [Address(RVA = "0x22CEE98", Offset = "0x22CEE98", VA = "0x22CEE98")]
    private void SetDetailModel(UnitParameterData unit, List<EffectParameterData> effectParameters)
    {
    }

    [Token(Token = "0x600D98F")]
    private (Sprite, string) GetModifierText<TModifierEffect>(TModifierEffect effect, int key) where TModifierEffect : ModifierEffectData
    {
      return ();
    }

    [Token(Token = "0x600D990")]
    [Address(RVA = "0x22CFD74", Offset = "0x22CFD74", VA = "0x22CFD74")]
    public StatusConditionModelList()
    {
    }
  }
}
