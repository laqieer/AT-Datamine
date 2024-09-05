// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.Battle.ResultUnit.EmptyCellApplyer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Scenes.OutGame.Battle.ResultUnit
{
  [Token(Token = "0x20037B5")]
  public class EmptyCellApplyer : IEquipCellApplyer
  {
    [Token(Token = "0x6015EE4")]
    [Address(RVA = "0x2321668", Offset = "0x2321668", VA = "0x2321668")]
    public static EmptyCellApplyer CreateEmpty(ResultEquipCell view, bool isUnlock)
    {
      return (EmptyCellApplyer) null;
    }

    [Token(Token = "0x6015EE5")]
    [Address(RVA = "0x2329DFC", Offset = "0x2329DFC", VA = "0x2329DFC")]
    private EmptyCellApplyer(ResultEquipCell view, bool isUnlock)
    {
    }

    [Token(Token = "0x6015EE6")]
    [Address(RVA = "0x2329E40", Offset = "0x2329E40", VA = "0x2329E40", Slot = "4")]
    public void ApplyExp(int exp)
    {
    }
  }
}
