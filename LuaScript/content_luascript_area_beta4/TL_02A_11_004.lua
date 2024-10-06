Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","DemoCommonPack")

function Load()
  nofooter_setup()
  load_ui()

  Noir = set_chara_unknown()
  character2DFull(Noir, "Noir", 101009005)
end

function Play()
  nofooter_start()

--change_face(Noir, "Normal")
  open_mind_window("PLAYERNAME_NOIR", nil, nil)
    message("TL_02A_11_0040001")
    message("TL_02A_11_0040002")
  close_mind_window()

  nofooter_end()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
  character2DFull_Preload(Noir, "Noir", 101009005)
end
