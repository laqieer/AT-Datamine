// Decompiled with JetBrains decompiler
// Type: Battle.DuelScene.SupportData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;

#nullable disable
namespace Battle.DuelScene
{
  [Token(Token = "0x200254A")]
  public struct SupportData
  {
    [Token(Token = "0x400A075")]
    [FieldOffset(Offset = "0x0")]
    public SkillParameterData skillParam;
    [Token(Token = "0x400A076")]
    [FieldOffset(Offset = "0x8")]
    public int count;

    [Token(Token = "0x600E635")]
    [Address(RVA = "0x486DB28", Offset = "0x486DB28", VA = "0x486DB28")]
    public void AddCount(int value = 1)
    {
    }
  }
}
