Include("content_luascript_system","LuaCommonPack")
Include("content_luascript_common","DemoCommonPack")

function Load()
	nofooter_setup()
	load_ui()
	
	Noir = get_chara("Player")
    motion(Noir, "Sri_Std_loop_m", 0.3, 1.0, true)
--	character2D(Noir,		"Noir",			"content_unit_101000102", "101000102_UnitFace", "101000102_UnitCutin", "101000102_UnitThumb", "101000102_UnitImage_Full", "101000102_UnitImage_HiRes")
	character2D(Noir, "Noir", "content_chr_101009_101009001_face", "101009001_UnitFace", nil, nil, nil, nil)
	character2D(Noir, "Noir", "content_chr_101009_default_cutin", nil, "101009_UnitCutin", nil, nil, nil)
	character2D(Noir, "Noir", "content_chr_101009_101009001_thumb", nil, nil, "101009001_UnitThumb", nil, nil)
	character2D(Noir, "Noir", "content_chr_101009_101009001_full", nil, nil, nil, "101009001_UnitImage_Full", nil)
	character2D(Noir, "Noir", "content_chr_101009_101009001_hires", nil, nil, nil, nil, "101009001_UnitImage_HiRes")
	change_face(Noir, "Normal")
	
end

function Play()
    nofooter_start()
    
        Telop()
    
    nofooter_end()
end

function Telop()
    change_face(Noir, "Normal")
	open_mind_window("PLAYERNAME_NOIR", Noir, nil)
		message_direct("今日は講堂で劇があるな。")
	close_mind_window()
end
-- EOF ------------------------------------


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	get_chara_preload("Player")
end
