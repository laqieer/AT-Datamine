Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")

-- アセットなどを読み込む
function Load()
	Load_common(true)
	load_sound("Bgarea_001_v001")
	--load_scene("content_areascene_110011", "Area110011") -- 教室
	--load_scene("content_areascene_110061", "Area110061") -- 大図書
	load_scene("content_areascene_115117", "Area115117") -- 城下町
	load_scene("content_areascene_110071", "Area110071") -- 前庭
	load_scene("content_bg_duel_bgd_s0100_00_1_2", "Bgd_S0100_00_1_2") -- デュエル背景
	change_scene("Area115117")
	
    Camera01 = set_camera(0, 1.88211, 6.86173,   6.567, 180, -0.005,   21)
    
    setup_Noir({0.0, 0.0, 0.0, 0.0})

	--Camera01 = set_camera({0.2, 1.56, 7.24241,   357.8011, 354.8386, -0.00085,   22})
	--setup_Noir({0.04, 0.1, 8.74,   180})
end

-- シーケンスの実行
function Play()
	on_camera(Camera01)
	fadein(0)
	Play_start(true)
	
	local envseflag = true
	
	open_narration_window()
	message_direct("シーン切り替えテスト")
	close_narration_window()
	
	while true do
		open_select_window_direct(Noir, "Normal", "城下町", "前庭", "デュエル背景", "環境音切り替え", "終了")
		if is_select(1) then
			change_scene("Area115117")
			open_narration_window()
			message_direct("シーンを切り替えました")
			close_narration_window()
		elseif is_select(2) then
			change_scene("Area110071")
			play_env_se(true)
			open_narration_window()
			message_direct("シーンを切り替えました")
			close_narration_window()
		elseif is_select(3) then
			change_scene("Bgd_S0100_00_1_2")
			play_env_se(true)
			open_narration_window()
			message_direct("シーンを切り替えました")
			close_narration_window()
		elseif is_select(4) then
			play_env_se(envseflag)
			if envseflag == true then
				envseflag = false
			else
				envseflag = true
			end
		else
			break
		end
	end

	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_scene_preload("content_areascene_115117", "Area115117")
	load_scene_preload("content_areascene_110071", "Area110071")
	load_scene_preload("content_bg_duel_bgd_s0100_00_1_2", "Bgd_S0100_00_1_2")
    setup_Noir_preload({0.0, 0.0, 0.0, 0.0})
end
