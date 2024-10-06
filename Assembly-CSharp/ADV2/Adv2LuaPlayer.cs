// Decompiled with JetBrains decompiler
// Type: ADV2.Adv2LuaPlayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Lua;
using MoonSharp.Interpreter;
using MoonSharp.Interpreter.Debugging;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace ADV2
{
  [Token(Token = "0x2003DF9")]
  public class Adv2LuaPlayer : MonoBehaviour
  {
    [Token(Token = "0x4010F9A")]
    [FieldOffset(Offset = "0x18")]
    protected Script luaScript;
    [Token(Token = "0x4010F9B")]
    [FieldOffset(Offset = "0x20")]
    protected List<string> includedPath;
    [Token(Token = "0x4010F9C")]
    [FieldOffset(Offset = "0x28")]
    protected Dictionary<string, Dictionary<string, List<string>>> includeFileNames;
    [Token(Token = "0x4010F9D")]
    [FieldOffset(Offset = "0x30")]
    protected Dictionary<string, List<string>> includedFileNames;
    [Token(Token = "0x4010F9E")]
    [FieldOffset(Offset = "0x38")]
    protected List<Adv2Manager.OnProccessSignal> signalList;
    [Token(Token = "0x4010F9F")]
    [FieldOffset(Offset = "0x40")]
    protected List<DynValue> subCoroutineList;

    [Token(Token = "0x17005115")]
    public bool IsExistScript
    {
      [Token(Token = "0x6018EAF"), Address(RVA = "0x2CAB4C4", Offset = "0x2CAB4C4", VA = "0x2CAB4C4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6018EB0")]
    [Address(RVA = "0x2CAB4D4", Offset = "0x2CAB4D4", VA = "0x2CAB4D4")]
    public bool IsIncludedPath(string path) => new bool();

    [Token(Token = "0x17005116")]
    public bool scriptEndFlag
    {
      [Token(Token = "0x6018EB1"), Address(RVA = "0x2CAB52C", Offset = "0x2CAB52C", VA = "0x2CAB52C")] get
      {
        return new bool();
      }
      [Token(Token = "0x6018EB2"), Address(RVA = "0x2CAB534", Offset = "0x2CAB534", VA = "0x2CAB534")] set
      {
      }
    }

    [Token(Token = "0x6018EB3")]
    [Address(RVA = "0x2CAB540", Offset = "0x2CAB540", VA = "0x2CAB540")]
    public void AddSubCoroutine(DynValue coroutine)
    {
    }

    [Token(Token = "0x6018EB4")]
    [Address(RVA = "0x2CAB5E8", Offset = "0x2CAB5E8", VA = "0x2CAB5E8")]
    private void Awake()
    {
    }

    [Token(Token = "0x6018EB5")]
    [Address(RVA = "0x2CAB5EC", Offset = "0x2CAB5EC", VA = "0x2CAB5EC")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6018EB6")]
    [Address(RVA = "0x2CABA3C", Offset = "0x2CABA3C", VA = "0x2CABA3C")]
    protected string OutputSourceRef(SourceRef source, string functionName) => (string) null;

    [Token(Token = "0x6018EB7")]
    [Address(RVA = "0x2CABDC0", Offset = "0x2CABDC0", VA = "0x2CABDC0")]
    protected void OutputScriptRuntimeException(ScriptRuntimeException e)
    {
    }

    [Token(Token = "0x6018EB8")]
    [Address(RVA = "0x2CAC1C8", Offset = "0x2CAC1C8", VA = "0x2CAC1C8")]
    protected void InputScriptFile(string fileName, string codeText)
    {
    }

    [Token(Token = "0x6018EB9")]
    [Address(RVA = "0x2CAC2C0", Offset = "0x2CAC2C0", VA = "0x2CAC2C0")]
    protected void OutputSyntaxErrorException(SyntaxErrorException e)
    {
    }

    [Token(Token = "0x6018EBA")]
    [Address(RVA = "0x2CAC3B4", Offset = "0x2CAC3B4", VA = "0x2CAC3B4")]
    protected bool isUsedFunction(List<string> functionNames) => new bool();

    [Token(Token = "0x6018EBB")]
    [Address(RVA = "0x2CAC518", Offset = "0x2CAC518", VA = "0x2CAC518")]
    protected bool isUsedFunction(string functionName) => new bool();

    [Token(Token = "0x6018EBC")]
    [Address(RVA = "0x2CAB3F8", Offset = "0x2CAB3F8", VA = "0x2CAB3F8")]
    protected IEnumerator SetFile(LuaScriptableObject luaFile, Dictionary<string, object> classList)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6018EBD")]
    [Address(RVA = "0x2CAC690", Offset = "0x2CAC690", VA = "0x2CAC690")]
    private static void LoadIncludeFileSelect(
      string assetbundleName,
      string fileName,
      string[] checkTexts)
    {
    }

    [Token(Token = "0x6018EBE")]
    [Address(RVA = "0x2CAA494", Offset = "0x2CAA494", VA = "0x2CAA494", Slot = "4")]
    public virtual void Clear()
    {
    }

    [Token(Token = "0x6018EBF")]
    [Address(RVA = "0x2CACA38", Offset = "0x2CACA38", VA = "0x2CACA38")]
    public void SetLuaValue(string key, int value)
    {
    }

    [Token(Token = "0x6018EC0")]
    [Address(RVA = "0x2CACAC8", Offset = "0x2CACAC8", VA = "0x2CACAC8")]
    public void SetLuaValue(string key, bool value)
    {
    }

    [Token(Token = "0x6018EC1")]
    [Address(RVA = "0x2CACB58", Offset = "0x2CACB58", VA = "0x2CACB58")]
    public void SetLuaValue(string key, string value)
    {
    }

    [Token(Token = "0x6018EC2")]
    [Address(RVA = "0x2CACBE8", Offset = "0x2CACBE8", VA = "0x2CACBE8")]
    public IEnumerator PlayFunction(string functionName) => (IEnumerator) null;

    [Token(Token = "0x6018EC3")]
    [Address(RVA = "0x2CACC84", Offset = "0x2CACC84", VA = "0x2CACC84")]
    public void AddScriptText(string assetPath, string scriptText)
    {
    }

    [Token(Token = "0x6018EC4")]
    [Address(RVA = "0x2CACD7C", Offset = "0x2CACD7C", VA = "0x2CACD7C")]
    public void AddScriptText(string assetbundleName, string fileName, string scriptText)
    {
    }

    [Token(Token = "0x6018EC5")]
    [Address(RVA = "0x2CACF54", Offset = "0x2CACF54", VA = "0x2CACF54")]
    public DynValue ConvertValue(Vector3 input) => (DynValue) null;

    [Token(Token = "0x6018EC6")]
    [Address(RVA = "0x2CAB0AC", Offset = "0x2CAB0AC", VA = "0x2CAB0AC")]
    public Adv2LuaPlayer()
    {
    }
  }
}
