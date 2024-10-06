Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","AreaCommonPack")
Include("content_luascript_common","DemoCommonPack")
Include("content_luascript_system","BattleAdvFunctions")

function Load()
  Load_common(false)

  setup2D_Galahad()
  load_image("EA_045_101028", "content_still_20101043_image", "201010430_StillImage")
  show_image("EA_045_101028", 0.0, 0.0, STILL_SWITCH_TIME, true, true) 
end

function Play()
  Play_start(true)

  change_face(Galahad,"Normal")
  open_speech_window("CHRNAME_GALAHAD", Galahad, nil)

  message("EA_045_1010280001")
  message("EA_045_1010280002")
  message("EA_045_1010280003")
  change_face(Galahad,"Shy")
  message("EA_045_1010280004")

  close_speech_window()

  Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
  setup2D_Galahad_preload()
  load_image_preload("EA_045_101028", "content_still_20101043_image", "201010430_StillImage")
end
