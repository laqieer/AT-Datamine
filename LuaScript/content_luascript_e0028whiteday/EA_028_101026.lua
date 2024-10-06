Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")

function Load()
  Load_common(false)

  setup2D_Percival()
  load_image("EA_028_101026", "content_still_20101061_image", "201010610_StillImage")
  show_image("EA_028_101026", 0.0, 0.0, STILL_SWITCH_TIME, true, true) 
end

function Play()
  Play_start(true)

  change_face(Percival,"Smile")
  open_speech_window("CHRNAME_PERCIVAL", Percival, nil)

  message("EA_028_1010260001")
  message("EA_028_1010260002")
  message("EA_028_1010260003")

  close_speech_window()

  Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
  setup2D_Percival_preload()
  load_image_preload("EA_028_101026", "content_still_20101061_image", "201010610_StillImage")
end
