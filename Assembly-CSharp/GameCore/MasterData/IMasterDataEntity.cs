// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.IMasterDataEntity
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013E6")]
  public interface IMasterDataEntity
  {
    [Token(Token = "0x170010BD")]
    int Key { [Token(Token = "0x6006FB2")] get; }

    [Token(Token = "0x6006FB3")]
    void Load(IMasterDataReader reader);

    [Token(Token = "0x6006FB4")]
    [Address(RVA = "0x4206904", Offset = "0x4206904", VA = "0x4206904", Slot = "2")]
    bool Compare(IMasterDataEntity other) => new bool();
  }
}
