// Decompiled with JetBrains decompiler
// Type: ADV2.LuaScript.Adv2PlayerModelInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace ADV2.LuaScript
{
  [Token(Token = "0x2003EF7")]
  public class Adv2PlayerModelInfo
  {
    [Token(Token = "0x4011417")]
    [FieldOffset(Offset = "0x10")]
    private string PlayerCharacterCharacterId;
    [Token(Token = "0x4011418")]
    [FieldOffset(Offset = "0x18")]
    private string PlayerCharacterStyleId;
    [Token(Token = "0x4011419")]
    [FieldOffset(Offset = "0x20")]
    private string PlayerCharacterAnimationControllerName;
    [Token(Token = "0x401141A")]
    [FieldOffset(Offset = "0x28")]
    private string PlayerCharacterAnimationControllerPath;
    [Token(Token = "0x401141B")]
    [FieldOffset(Offset = "0x30")]
    private string PlayerCharacterDefaultMotion;
    [Token(Token = "0x401141C")]
    [FieldOffset(Offset = "0x38")]
    private string PlayerCharacterFacialName;
    [Token(Token = "0x401141D")]
    [FieldOffset(Offset = "0x40")]
    private string PlayerCharacterFacialPath;
    [Token(Token = "0x401141E")]
    [FieldOffset(Offset = "0x48")]
    private string LabelChara;

    [Token(Token = "0x6019724")]
    [Address(RVA = "0x373DFD8", Offset = "0x373DFD8", VA = "0x373DFD8")]
    public int GetPlayerStyleId() => new int();

    [Token(Token = "0x6019725")]
    [Address(RVA = "0x373E0B8", Offset = "0x373E0B8", VA = "0x373E0B8")]
    public void InitializePlayerModelInfo()
    {
    }

    [Token(Token = "0x6019726")]
    [Address(RVA = "0x373E1F4", Offset = "0x373E1F4", VA = "0x373E1F4")]
    public string GetPlayerModelInfo(string label) => (string) null;

    [Token(Token = "0x6019727")]
    [Address(RVA = "0x373E47C", Offset = "0x373E47C", VA = "0x373E47C")]
    public Adv2PlayerModelInfo()
    {
    }
  }
}
