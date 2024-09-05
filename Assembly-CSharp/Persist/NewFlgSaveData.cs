// Decompiled with JetBrains decompiler
// Type: Persist.NewFlgSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Persist
{
  [Token(Token = "0x20009ED")]
  public class NewFlgSaveData : FlgSaveData
  {
    [Token(Token = "0x4002DF4")]
    [FieldOffset(Offset = "0x0")]
    public static readonly NewFlgSaveData CommuNewFlg;
    [Token(Token = "0x4002DF5")]
    [FieldOffset(Offset = "0x8")]
    public static readonly NewFlgSaveData FacilityNewFlg;
    [Token(Token = "0x4002DF6")]
    [FieldOffset(Offset = "0x10")]
    public static readonly NewFlgSaveData SubQuestTrackerFlg;

    [Token(Token = "0x600388A")]
    [Address(RVA = "0x310DD2C", Offset = "0x310DD2C", VA = "0x310DD2C")]
    public NewFlgSaveData(string fileName)
    {
    }

    [Token(Token = "0x600388B")]
    [Address(RVA = "0x310DD30", Offset = "0x310DD30", VA = "0x310DD30")]
    static NewFlgSaveData()
    {
    }
  }
}
