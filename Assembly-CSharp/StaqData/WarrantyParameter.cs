// Decompiled with JetBrains decompiler
// Type: StaqData.WarrantyParameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Network.Param;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x2002110")]
  public class WarrantyParameter : MonoBehaviour
  {
    [Token(Token = "0x4008C6A")]
    [FieldOffset(Offset = "0x20")]
    private int selectedParameterType;
    [Token(Token = "0x4008C6B")]
    [FieldOffset(Offset = "0x28")]
    public Dictionary<ParameterTypeEnum, bool> ParameterFlags;

    [Token(Token = "0x17002C09")]
    public UniqueID TargetStyleUniqueID
    {
      [Token(Token = "0x600CA30"), Address(RVA = "0x1BA1814", Offset = "0x1BA1814", VA = "0x1BA1814")] get
      {
        return new UniqueID();
      }
      [Token(Token = "0x600CA31"), Address(RVA = "0x1BA181C", Offset = "0x1BA181C", VA = "0x1BA181C")] private set
      {
      }
    }

    [Token(Token = "0x600CA32")]
    [Address(RVA = "0x1BA1824", Offset = "0x1BA1824", VA = "0x1BA1824")]
    public void SetSelectedParamType(int selectedParameterType)
    {
    }

    [Token(Token = "0x600CA33")]
    [Address(RVA = "0x1BA192C", Offset = "0x1BA192C", VA = "0x1BA192C")]
    public ParameterTypeEnum? GetSelectedParamType() => new ParameterTypeEnum?();

    [Token(Token = "0x600CA34")]
    [Address(RVA = "0x1BA1A64", Offset = "0x1BA1A64", VA = "0x1BA1A64")]
    private void Reset()
    {
    }

    [Token(Token = "0x600CA35")]
    [Address(RVA = "0x1BA1AC0", Offset = "0x1BA1AC0", VA = "0x1BA1AC0")]
    public void Apply(PlayerUnitWarrantyParameterType entity)
    {
    }

    [Token(Token = "0x600CA36")]
    [Address(RVA = "0x1BA1C28", Offset = "0x1BA1C28", VA = "0x1BA1C28")]
    public void UpdateParam(ParameterTypeEnum parameterType, bool isWarrantyData)
    {
    }

    [Token(Token = "0x600CA37")]
    [Address(RVA = "0x1BA1C90", Offset = "0x1BA1C90", VA = "0x1BA1C90")]
    public WarrantyParameter()
    {
    }
  }
}
