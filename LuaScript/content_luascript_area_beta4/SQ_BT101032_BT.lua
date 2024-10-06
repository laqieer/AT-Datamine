Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")
Include("content_luascript_common", "SceneCommonPack")
Include("content_luascript_system", "BattleAdvFunctions")

function Load()
  Load_common(false)
  setup2D_Gareth()
end

function Play()
  Play_start(false)

  open_speech_window("CHRNAME_GARETH", Gareth, nil)
    message("SQ_BT101032_BT0001")
  close_speech_window()

  Play_end(false)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
  setup2D_Gareth_preload()
end
