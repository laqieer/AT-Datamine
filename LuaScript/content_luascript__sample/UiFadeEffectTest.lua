Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")
Include("content_luascript_common", "SceneCommonPack")
Include("content_luascript__sample", "label_camera")

-- アセットなどを読み込む
function Load()
	Load_common(true)
	load_scene("content_areascene_110011", "Area110011") -- 教室
	
	Camera01 = set_camera(-2.74, 1.531, 1.382, 0.0, 0.0, 0.0, 60)
	set_camera_lookat(Camera01, 0.0, 1.01, -5.15)

	setup_Noir({0.0, 0, -1.15, 0});

	sideFade = load_ui_effect("content_effect_adv_ui_effect_adv_side_fade", "effect_adv_side_fade", "content_effect_adv_ui_effect_adv_side_fade_timeline", {"fade_in", "fade_out"}, {"effect_adv_side_fadein", "effect_adv_side_fadeout"})
end

-- シーケンスの実行
function Play()
	-- safe Area外におく
	sideFade.ChangeParent2dRoot()
	
	on_camera(Camera01)
	fadein(0)
	Play_start(true)

	while true do
		open_select_window_direct(nil, "Normal", "フェード開始",  "終了")
		if is_select(1) then
			play_ui_effect(sideFade, "effect_adv_side_fade", "fade_in", true)
			wait_time(2.0)
			play_ui_effect(sideFade, "effect_adv_side_fade", "fade_out", true)
		else
			unload_ui_effect(sideFade, {"fade_in", "fade_out"})
			break;
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
	load_scene_preload("content_areascene_110011", "Area110011")
	setup_Noir_preload({0.0, 0, -1.15, 0})
	load_ui_effect_preload("content_effect_adv_ui_effect_adv_side_fade", "effect_adv_side_fade", "content_effect_adv_ui_effect_adv_side_fade_timeline", {"fade_in", "fade_out"}, {"effect_adv_side_fadein", "effect_adv_side_fadeout"})
end
