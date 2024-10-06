// Decompiled with JetBrains decompiler
// Type: Battle.Data.Board.ISkillParameterDataHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Data.Board
{
  [Token(Token = "0x20027FD")]
  public interface ISkillParameterDataHandler
  {
    [Token(Token = "0x600FA3A")]
    int RequestSkillParameterId();

    [Token(Token = "0x600FA3B")]
    bool TryGetSkillParameter(int id, out SkillParameterData skillParam);

    [Token(Token = "0x600FA3C")]
    bool RegisterSkillParameter(SkillParameterData skillParam);
  }
}
