// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.PostProcessingModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace UnityEngine.PostProcessing
{
  [Token(Token = "0x2003FB2")]
  [Serializable]
  public abstract class PostProcessingModel
  {
    [Token(Token = "0x40116F9")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    [GetSet("enabled")]
    private bool m_Enabled;

    [Token(Token = "0x17005296")]
    public bool enabled
    {
      [Token(Token = "0x60199EC"), Address(RVA = "0x343E5C8", Offset = "0x343E5C8", VA = "0x343E5C8")] get
      {
        return new bool();
      }
      [Token(Token = "0x60199ED"), Address(RVA = "0x343E5D0", Offset = "0x343E5D0", VA = "0x343E5D0")] set
      {
      }
    }

    [Token(Token = "0x60199EE")]
    public abstract void Reset();

    [Token(Token = "0x60199EF")]
    [Address(RVA = "0x343E5EC", Offset = "0x343E5EC", VA = "0x343E5EC", Slot = "5")]
    public virtual void OnValidate()
    {
    }

    [Token(Token = "0x60199F0")]
    [Address(RVA = "0x343B144", Offset = "0x343B144", VA = "0x343B144")]
    protected PostProcessingModel()
    {
    }
  }
}
