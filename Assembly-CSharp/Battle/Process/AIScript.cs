// Decompiled with JetBrains decompiler
// Type: Battle.Process.AIScript
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Score;
using GameCore.MasterData;
using Il2CppDummyDll;
using MoonSharp.Interpreter;
using Routine;
using System;
using System.Collections.Generic;

#nullable disable
namespace Battle.Process
{
  [Token(Token = "0x200267E")]
  public class AIScript
  {
    [Token(Token = "0x400A519")]
    [FieldOffset(Offset = "0x10")]
    private Script script;
    [Token(Token = "0x400A51A")]
    [FieldOffset(Offset = "0x18")]
    private HashSet<AIScript.IncludedScriptInfo> includedScriptList;
    [Token(Token = "0x400A51B")]
    [FieldOffset(Offset = "0x20")]
    private HashSet<string> registeredTypeList;
    [Token(Token = "0x400A51C")]
    [FieldOffset(Offset = "0x28")]
    private HashSet<string> createdStaticObject;
    [Token(Token = "0x400A51E")]
    [FieldOffset(Offset = "0x38")]
    private BattleCore core;
    [Token(Token = "0x400A51F")]
    [FieldOffset(Offset = "0x40")]
    private Routine.Environment environment;
    [Token(Token = "0x400A522")]
    [FieldOffset(Offset = "0x58")]
    private List<(ActionRoutineType routineType, Type routine)> actionRoutineList;
    [Token(Token = "0x400A523")]
    private const string IncludeSymbol = "Include";
    [Token(Token = "0x400A524")]
    private const string CreateStaticSymbol = "CreateStatic";
    [Token(Token = "0x400A525")]
    private const string ActionRoutineTypeSymbol = "ActionRoutineType";
    [Token(Token = "0x400A526")]
    private const string CreateActionRoutineMethodSymbol = "CreateActionRoutine";
    [Token(Token = "0x400A527")]
    private const string SimulateActionMethodSymbol = "SimulateActionRoutine";
    [Token(Token = "0x400A528")]
    private const string DumpCommandMethodSymbol = "DumpCommand";
    [Token(Token = "0x400A529")]
    private const string ExecuteMethodSymbol = "Execute";
    [Token(Token = "0x400A52A")]
    private const string AddSimulatedCommandsMethodSymbol = "AddSimulatedCommands";
    [Token(Token = "0x400A52B")]
    private const string EnvironmentSymbol = "Environment";
    [Token(Token = "0x400A52C")]
    private const string CalcScoreMethodSymbol = "CalcScore";
    [Token(Token = "0x400A52D")]
    private const string AssetBundleNameFactorName = "assetBundleName";
    [Token(Token = "0x400A52E")]
    private const string AITypeNameFactorName = "aiTypeName";
    [Token(Token = "0x400A52F")]
    private const string RoutineFactorName = "routine";
    [Token(Token = "0x400A530")]
    private const string RoutineTypeFactorName = "routineType";

    [Token(Token = "0x1700328E")]
    public ScoreFactory ScoreFactory
    {
      [Token(Token = "0x600EE45"), Address(RVA = "0x4443924", Offset = "0x4443924", VA = "0x4443924")] get
      {
        return (ScoreFactory) null;
      }
      [Token(Token = "0x600EE46"), Address(RVA = "0x444392C", Offset = "0x444392C", VA = "0x444392C")] private set
      {
      }
    }

    [Token(Token = "0x1700328F")]
    public List<CommandScore> DumpedCommands
    {
      [Token(Token = "0x600EE47"), Address(RVA = "0x4443934", Offset = "0x4443934", VA = "0x4443934")] get
      {
        return (List<CommandScore>) null;
      }
      [Token(Token = "0x600EE48"), Address(RVA = "0x444393C", Offset = "0x444393C", VA = "0x444393C")] private set
      {
      }
    }

    [Token(Token = "0x17003290")]
    public Func<bool> IsCanceled
    {
      [Token(Token = "0x600EE49"), Address(RVA = "0x4443944", Offset = "0x4443944", VA = "0x4443944")] get
      {
        return (Func<bool>) null;
      }
      [Token(Token = "0x600EE4A"), Address(RVA = "0x444394C", Offset = "0x444394C", VA = "0x444394C")] set
      {
      }
    }

    [Token(Token = "0x600EE4B")]
    [Address(RVA = "0x4443954", Offset = "0x4443954", VA = "0x4443954")]
    public AIScript()
    {
    }

    [Token(Token = "0x600EE4C")]
    [Address(RVA = "0x4444F28", Offset = "0x4444F28", VA = "0x4444F28")]
    public void Initialize(BoardData board)
    {
    }

    [Token(Token = "0x600EE4D")]
    [Address(RVA = "0x4445A3C", Offset = "0x4445A3C", VA = "0x4445A3C")]
    private void Include(string assetBundleName, string scriptName)
    {
    }

    [Token(Token = "0x600EE4E")]
    [Address(RVA = "0x444553C", Offset = "0x444553C", VA = "0x444553C")]
    private void IncludeImpl(string assetBundleName, string scriptName)
    {
    }

    [Token(Token = "0x600EE4F")]
    [Address(RVA = "0x4445AB0", Offset = "0x4445AB0", VA = "0x4445AB0")]
    private void RegisterType(string typeName)
    {
    }

    [Token(Token = "0x600EE50")]
    [Address(RVA = "0x4444E08", Offset = "0x4444E08", VA = "0x4444E08")]
    public void RegisterType(Type type)
    {
    }

    [Token(Token = "0x600EE51")]
    [Address(RVA = "0x4445B4C", Offset = "0x4445B4C", VA = "0x4445B4C")]
    public void Clear()
    {
    }

    [Token(Token = "0x600EE52")]
    [Address(RVA = "0x4445D18", Offset = "0x4445D18", VA = "0x4445D18")]
    private void CreateStatic(string name, string typeName)
    {
    }

    [Token(Token = "0x600EE53")]
    [Address(RVA = "0x4444F04", Offset = "0x4444F04", VA = "0x4444F04")]
    public void SetGlobals(string name, object obj)
    {
    }

    [Token(Token = "0x600EE54")]
    public void SetGlobals<TDelegate>(string name, TDelegate obj) where TDelegate : Delegate
    {
    }

    [Token(Token = "0x600EE55")]
    [Address(RVA = "0x4445738", Offset = "0x4445738", VA = "0x4445738")]
    public object GetGlobals(string name) => (object) null;

    [Token(Token = "0x600EE56")]
    [Address(RVA = "0x4445E94", Offset = "0x4445E94", VA = "0x4445E94")]
    public void Execute(BattleCore core, int actionUnitId, string aiTypeName)
    {
    }

    [Token(Token = "0x600EE57")]
    [Address(RVA = "0x4446060", Offset = "0x4446060", VA = "0x4446060")]
    public void ClearResult()
    {
    }

    [Token(Token = "0x600EE58")]
    [Address(RVA = "0x44458A8", Offset = "0x44458A8", VA = "0x44458A8")]
    private DynValue ExecFunction(string funcName, params DynValue[] args) => (DynValue) null;

    [Token(Token = "0x600EE59")]
    [Address(RVA = "0x44460E4", Offset = "0x44460E4", VA = "0x44460E4")]
    private bool SimulateAction(
      int actionUnitId,
      ActionRoutine routine,
      int requiredHit,
      int[] args,
      int[] preference)
    {
      return new bool();
    }

    [Token(Token = "0x600EE5A")]
    [Address(RVA = "0x4446358", Offset = "0x4446358", VA = "0x4446358")]
    private bool DumpCommand(CommandScore score) => new bool();

    [Token(Token = "0x600EE5B")]
    [Address(RVA = "0x4446418", Offset = "0x4446418", VA = "0x4446418")]
    private int CalcScore(ScoreTypeEnum scoreType, CommandScore commandScore) => new int();

    [Token(Token = "0x600EE5C")]
    [Address(RVA = "0x4446338", Offset = "0x4446338", VA = "0x4446338")]
    private bool CheckIsCanceled() => new bool();

    [Token(Token = "0x600EE5D")]
    [Address(RVA = "0x4446450", Offset = "0x4446450", VA = "0x4446450")]
    private void Log(string log)
    {
    }

    [Token(Token = "0x600EE5E")]
    [Address(RVA = "0x4445A40", Offset = "0x4445A40", VA = "0x4445A40")]
    public bool IsIncludedScript(string assetBundleName, string scriptName) => new bool();

    [Token(Token = "0x600EE5F")]
    [Address(RVA = "0x444575C", Offset = "0x444575C", VA = "0x444575C")]
    private Table ConvertRoutineIntoDynValue(ActionRoutineType routineType, Type routine)
    {
      return (Table) null;
    }

    [Token(Token = "0x200267F")]
    public struct IncludedScriptInfo
    {
      [Token(Token = "0x400A531")]
      [FieldOffset(Offset = "0x0")]
      private string assetBundleName;
      [Token(Token = "0x400A532")]
      [FieldOffset(Offset = "0x8")]
      private string scriptName;

      [Token(Token = "0x600EE60")]
      [Address(RVA = "0x4445AA8", Offset = "0x4445AA8", VA = "0x4445AA8")]
      public IncludedScriptInfo(string assetBundleName, string scriptName)
      {
      }
    }

    [Token(Token = "0x2002680")]
    public class AssetInfo
    {
      [Token(Token = "0x400A533")]
      public const string AITypeToken = "AIType";
      [Token(Token = "0x400A534")]
      public const string AIAssetBundleName = "content_ai";
      [Token(Token = "0x400A535")]
      public const string InitializeScriptFileName = "AIMain";
      [Token(Token = "0x400A536")]
      public const string ConstScriptFileName = "AIConst";
      [Token(Token = "0x400A537")]
      public const string AIStateAssetBundleName = "content_ai_aistate";
      [Token(Token = "0x400A538")]
      public const string AIModuleAssetBundleName = "content_ai_aimodule";
      [Token(Token = "0x400A539")]
      public const string AITypeAssetBundleName = "content_ai_aitype";
      [Token(Token = "0x400A53A")]
      public const string AIStateOpAssetBundleName = "content_ai_aistate_optimized";
      [Token(Token = "0x400A53B")]
      public const string AIModuleOpAssetBundleName = "content_ai_aimodule_optimized";
      [Token(Token = "0x400A53C")]
      public const string AITypeOpAssetBundleName = "content_ai_aitype_optimized";
      [Token(Token = "0x400A53D")]
      public const string AIConstAssetBundleName = "content_ai_aiconst";
      [Token(Token = "0x400A53E")]
      [FieldOffset(Offset = "0x0")]
      public static readonly List<string> RequireForInitializeList;

      [Token(Token = "0x600EE61")]
      [Address(RVA = "0x4446454", Offset = "0x4446454", VA = "0x4446454")]
      public static string GetOptimizedAITypeName(string aiTypeName) => (string) null;

      [Token(Token = "0x600EE62")]
      [Address(RVA = "0x4446534", Offset = "0x4446534", VA = "0x4446534")]
      public AssetInfo()
      {
      }

      [Token(Token = "0x600EE63")]
      [Address(RVA = "0x444653C", Offset = "0x444653C", VA = "0x444653C")]
      static AssetInfo()
      {
      }
    }
  }
}
