// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.IMindEquipmentDataHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027F1")]
  public interface IMindEquipmentDataHandler
  {
    [Token(Token = "0x600F97F")]
    int CreateMindEquipmentId();

    [Token(Token = "0x600F980")]
    bool TryGetMindEquipment(int id, out MindEquipmentData mindEquipment);

    [Token(Token = "0x600F981")]
    bool RegisterMindEquipment(MindEquipmentData mindEquipment);
  }
}
