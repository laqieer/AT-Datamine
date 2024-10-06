Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")

-- アセットなどを読み込む
function Load()
	Load_common(true)
	load_scene("content_areascene_110011", "Area110011") -- 教室

	Camera01 = set_camera(-2.74, 1.531, 1.382, 0.0, 0.0, 0.0, 60)
	set_camera_lookat(Camera01, 0.0, 1.01, -5.15)

	setup_Lancelot({0.000, 0.0, -5.440, 0.0})
	
	setup_Noir({1.050, 0.0, -1.610, 180.0})
	motion(Noir, "Sri_Sit_loop_m", 0.0, 1.0, true)
	
	setup_Guinevere({-1.430, 0.0,  0.050, 180.0})
	motion(Guinevere, "Nbl_Sit_loop_f", 0.0, 1.0, true)

	MobGirl01	= set_chara("content_chr_401006_401006001_model", "401006001_Model", "content_animationpack__common", "MotionPack", "content_animationpack__common", "FacialPack",  2.466, 0.0, -1.920, 180.0, "Mob_Sit_loop_f", "Normal")
	MobGirl02	= set_chara("content_chr_401006_401006001_model", "401006001_Model", "content_animationpack__common", "MotionPack", "content_animationpack__common", "FacialPack", -1.430, 0.0, -1.930, 180.0, "Mob_Sit_loop_f", "Normal")
	MobGirl03	= set_chara("content_chr_401006_401006001_model", "401006001_Model", "content_animationpack__common", "MotionPack", "content_animationpack__common", "FacialPack", -2.850, 0.0, -1.890, 180.0, "Mob_Sit_loop_f", "Normal")
	
end

-- シーケンスの実行
function Play()
	on_camera(Camera01)
	fadein(0)
	Play_start(true)

	while true do
		open_select_window_direct(Noir, "Normal", "通常会話", "心の声", "デモ用", "ナレーション")
		if is_select(1) then
			open_speech_window(nil, nil, nil)
			message_direct("通常会話：最小限")
			close_speech_window()
			open_speech_window("Chr_502_02", nil, nil)
			message_direct("通常会話：名札付")
			close_speech_window()
			open_speech_window("Chr_502_02", Noir, nil)
			message_direct("通常会話：キャラ左")
			close_speech_window()
			open_speech_window("Chr_502_02", nil, Noir)
			message_direct("通常会話：キャラ右")
			close_speech_window()
		elseif is_select(2) then
			open_mind_window(nil, nil, nil)
			message_direct("心の声：最小限")
			close_mind_window()
			open_mind_window("Chr_502_02", nil, nil)
			message_direct("心の声：名札付")
			close_mind_window()
			open_mind_window("Chr_502_02", Noir, nil)
			message_direct("心の声：キャラ左")
			close_mind_window()
			open_mind_window("Chr_502_02", nil, Noir)
			message_direct("心の声：キャラ右")
			close_mind_window()
		elseif is_select(3) then
			open_simple_window(nil)
			message_direct("デモ用：最小限")
			close_simple_window()
			open_simple_window("Chr_502_02")
			message_direct("デモ用：名札付")
			close_simple_window()
		else
			open_narration_window()
			message_direct("ナレーション")
			close_narration_window()
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
	setup_Lancelot_preload({0.000, 0.0, -5.440, 0.0})
	setup_Noir_preload({1.050, 0.0, -1.610, 180.0})
	setup_Guinevere_preload({-1.430, 0.0,  0.050, 180.0})
	set_chara_preload("content_chr_401006_401006001_model", "401006001_Model", "content_animationpack__common", "MotionPack", "content_animationpack__common", "FacialPack",  2.466, 0.0, -1.920, 180.0, "Mob_Sit_loop_f", "Normal")
	set_chara_preload("content_chr_401006_401006001_model", "401006001_Model", "content_animationpack__common", "MotionPack", "content_animationpack__common", "FacialPack", -1.430, 0.0, -1.930, 180.0, "Mob_Sit_loop_f", "Normal")
	set_chara_preload("content_chr_401006_401006001_model", "401006001_Model", "content_animationpack__common", "MotionPack", "content_animationpack__common", "FacialPack", -2.850, 0.0, -1.890, 180.0, "Mob_Sit_loop_f", "Normal")
end
