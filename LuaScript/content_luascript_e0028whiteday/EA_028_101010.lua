Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")

function Load()
  Load_common(false)

  setup2D_Lancelot()
  load_image("EA_028_101010", "content_still_20101055_image", "201010550_StillImage")
  show_image("EA_028_101010", 0.0, 0.0, STILL_SWITCH_TIME, true, true) 
end

function Play()
  Play_start(true)

  change_face(Lancelot,"Smile")
  open_speech_window("CHRNAME_LANCELOT", Lancelot, nil)

  message("EA_028_1010100001")
  message("EA_028_1010100002")
  change_face(Lancelot,"Normal")
  message("EA_028_1010100003")
  message("EA_028_1010100004")

  close_speech_window()

  Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
  setup2D_Lancelot_preload()
  load_image_preload("EA_028_101010", "content_still_20101055_image", "201010550_StillImage")
end
