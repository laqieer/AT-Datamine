Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")

-- アセットなどを読み込む
function Load()
	Load_common(true)
	load_scene("content_areascene_115061", "Area115061") -- 大図書院
	
	load_scene("content_areascene_115034", "Area115034") -- 廊下
	
	
	Camera01 = set_camera(2.1, 0.87, 12.76, 0.0, -49.72, 0.0, 60)
	
	Camera02 = set_camera(24.1, 1.3, 24.0, 0.0, -156.6, 0.0, 60)
	

	--Noir = set_chara("content_chr_1010001_101000102_model", "Chr_1010001_101000102_Model", "content_animationpack__common", "MotionPack", "content_animationpack__common", "FacialPack", 0.0, 0.0, 13.8, 0, "Sri_Std_loop_m", "Normal")
	setup_Noir({0.0, 0.0, 13.8, 0})
	
	
	-- キャラクターを地面の高さに合わせる
	set_groundpos(Noir)
	
	--Guinevere = set_chara("content_chr_1010003_101000301_model", "Chr_1010003_101000301_Model", "content_animationpack__common", "MotionPack", "content_animationpack__common", "FacialPack",	23.6, 0.0,  21.5, 180, "Nbl_Std_loop_f", "Normal")
	setup_Guinevere({23.6, 0.0,  21.5, 180})
	
end

-- 
function Area115061_Walk()
	motion(Noir, "Sri_Wlk_loop_m", 0.4, 1.0, true)
	signal = groundmove(Noir, 0.0, 0.0, 13.8 + 3.5, 2.5, usenavimesh)	-- 地面の沿って移動させる
	
	while signal.IsProccessing() do
		coroutine.yield()
	end
	
	motion(Noir, "Sri_Std_loop_m", 0.1, 1.0, true)
	
	signal = turn_chara(Noir, 180, 0.5)
	
	while signal.IsProccessing() do
		coroutine.yield()
	end
	
	motion(Noir, "Sri_Wlk_loop_m", 0.4, 1.0, true)
	signal = groundmove(Noir, 0.0, 0.0, 13.8, 2.5)
	
	while signal.IsProccessing() do
		coroutine.yield()
	end
	
	motion(Noir, "Sri_Std_loop_m", 0.1, 1.0, true)
	turn_chara(Noir, 0, 0.5)
end

function Area115034_Walk(usenavimesh)
	
	motion(Guinevere, "Nbl_Wlk_loop_f", 0.4, 1.0, true)
	signal = groundmove(Guinevere, 23.6, 0.0,  21.5 - 3.5, 2.5)
	
	while signal.IsProccessing() do
		coroutine.yield()
	end
	
	motion(Guinevere, "Nbl_Std_180turn_right_f", 0.3, 1.0, true)
	
	signal = turn_chara(Guinevere, -1.0, 0.7)
	
	while signal.IsProccessing() do
		coroutine.yield()
	end
	
	motion(Guinevere, "Nbl_Wlk_loop_f", 0.4, 1.0, true)
	signal = groundmove(Guinevere, 23.6, 0.0,  21.5, 2.5)
	
	while signal.IsProccessing() do
		coroutine.yield()
	end
	
	motion(Guinevere, "Nbl_Std_loop_f", 0.1, 1.0, true)
	
	turn_chara(Guinevere, 180, 0.7)
end



-- シーケンスの実行
function Play()
	on_camera(Camera01)
	fadein(0)
	Play_start(true)
	
	
	while true do
		open_select_window_direct(Noir, "Normal", "大図書院の階段","廊下の階段", "終了")
		if is_select(1) then
			on_camera(Camera01)
			Area115061_Walk()
		elseif is_select(2) then
			on_camera(Camera02)
			Area115034_Walk()
		else
			break
		end
	end
	
	open_narration_window()
	message_direct("終了します。")
	close_speech_window()
	
	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_scene_preload("content_areascene_115061", "Area115061")
	load_scene_preload("content_areascene_115034", "Area115034")
	setup_Noir_preload({0.0, 0.0, 13.8, 0})
	setup_Guinevere_preload({23.6, 0.0,  21.5, 180})
end
