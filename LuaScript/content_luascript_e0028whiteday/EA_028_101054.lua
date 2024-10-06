Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")

function Load()
  Load_common(false)

  setup2D_Adam()
  load_image("EA_028_101054", "content_still_20101064_image", "201010640_StillImage")
  show_image("EA_028_101054", 0.0, 0.0, STILL_SWITCH_TIME, true, true) 
end

function Play()
  Play_start(true)

  change_face(Adam,"Normal")
  open_speech_window("CHRNAME_ADAM", Adam, nil)

  message("EA_028_1010540001")
  message("EA_028_1010540002")

  close_speech_window()

  Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
  setup2D_Adam_preload()
  load_image_preload("EA_028_101054", "content_still_20101064_image", "201010640_StillImage")
end
