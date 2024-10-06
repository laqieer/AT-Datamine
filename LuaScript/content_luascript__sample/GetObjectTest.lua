Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")

-- アセットなどを読み込む
function Load()
	Load_common(true)
	load_scene("content_areascene_110011", "Area110011") -- 教室
	
	-- 椅子を見るカメラ
	Camera01 = set_camera(-1, 1, -1.78, 0, 90, 0, 60)
	
	setup_Lancelot({0.000, 0.0, -5.440, 0.0})
	
	setup_Noir({1.050, 0.0, -1.610, 180.0})
	motion(Noir, "Sri_Sit_loop_m", 0.0, 1.0, true)
	
	setup_Guinevere({-1.430, 0.0,  0.050, 180.0})
	motion(Guinevere, "Nbl_Sit_loop_f", 0.0, 1.0, true)
	
	
	MobGirl01	= set_chara("content_chr_401006_401006001_model", "401006001_Model", "content_animationpack__common", "MotionPack", "content_animationpack__common", "FacialPack",  2.466, 0.0, -1.920, 180.0, "Mob_Sit_loop_f", "Normal")
	MobGirl02	= set_chara("content_chr_401006_401006001_model", "401006001_Model", "content_animationpack__common", "MotionPack", "content_animationpack__common", "FacialPack", -1.430, 0.0, -1.930, 180.0, "Mob_Sit_loop_f", "Normal")
	MobGirl03	= set_chara("content_chr_401006_401006001_model", "401006001_Model", "content_animationpack__common", "MotionPack", "content_animationpack__common", "FacialPack", -2.850, 0.0, -1.890, 180.0, "Mob_Sit_loop_f", "Normal")

	
	-- ノワールの座っている椅子を取得
	chair = get_object("geo_chair_02")
	
	-- 椅子のモーションパックを読み込む
	load_animpack(chair, "content_animationpack__object", "ObjTestPack")
	
	--椅子の座標を取ってくる
	chair_original_pos = get_pos(chair)
	
	-- 椅子を注視点にする
	set_camera_lookat(Camera01, chair_original_pos)
	
	--配列をコピーするにはunpackを使う。使わないと参照扱いになる
	chair_now_pos = {unpack(chair_original_pos)}
	
end

-- シーケンスの実行
function Play()
	on_camera(Camera01)
	fadein(0)
	Play_start(true)
	
	while true do
		--set_pos(chair, chair_original_pos)
		--chair_now_pos = {unpack(chair_original_pos)}
		open_select_window_direct(Noir, "Normal", "椅子を前に移動", "椅子を後ろに移動", "椅子を回転", "椅子モーション", "終了")
		if is_select(1) then
			on_camera(Camera01)
			motion(Noir, "Sri_Sit_loop_m", 0.1, 1.0, true)
			chair_now_pos[3] = chair_original_pos[3]
			-- local signal = localmove(chair, chair_now_pos, 0.5)
			local signal = motion(chair, "front", 0.0, 1.0, false)
			slidemove(Noir, 1.050, 0.0, -1.610, 1.0)
			while signal.IsProccessing() do
				local nowpos = get_pos(chair)
				set_camera_lookat(Camera01, nowpos)
				coroutine.yield()
			end
		elseif is_select(2) then
			on_camera(Camera01)
			motion(Noir, "Sri_Sit_Std_m", 0.1, 1.0, false)
			wait_time(0.5)

			chair_now_pos[3] = chair_original_pos[3] + 0.3
			local signal = localmove(chair, chair_now_pos, 0.5)
			--local signal = motion(chair, "back", 0.0, 1.0, false)
			slidemove(Noir, 1.050, 0.0, -1.610+0.15, 1.0)
			while signal.IsProccessing() do
				local nowpos = get_pos(chair)
				set_camera_lookat(Camera01, nowpos)
				coroutine.yield()
			end
		elseif is_select(3) then
			on_camera(Camera01)
			local signal
			local rot = get_rot(chair)
			if rot[2] == 0 then
				signal = localturn(chair, 0, 180, 0, 2.0)
			else
				signal = localturn(chair, 0, 0, 0, 2.0)
			end
			while signal.IsProccessing() do
				coroutine.yield()
			end
		elseif is_select(4) then
			motion(chair, "uptest", 0.0, 1.0, false)
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
	load_scene_preload("content_areascene_110011", "Area110011")
	setup_Lancelot_preload({0.000, 0.0, -5.440, 0.0})
	setup_Noir_preload({1.050, 0.0, -1.610, 180.0})
	setup_Guinevere_preload({-1.430, 0.0,  0.050, 180.0})
	set_chara_preload("content_chr_401006_401006001_model", "401006001_Model", "content_animationpack__common", "MotionPack", "content_animationpack__common", "FacialPack",  2.466, 0.0, -1.920, 180.0, "Mob_Sit_loop_f", "Normal")
	set_chara_preload("content_chr_401006_401006001_model", "401006001_Model", "content_animationpack__common", "MotionPack", "content_animationpack__common", "FacialPack", -1.430, 0.0, -1.930, 180.0, "Mob_Sit_loop_f", "Normal")
	set_chara_preload("content_chr_401006_401006001_model", "401006001_Model", "content_animationpack__common", "MotionPack", "content_animationpack__common", "FacialPack", -2.850, 0.0, -1.890, 180.0, "Mob_Sit_loop_f", "Normal")
	load_animpack_preload(chair, "content_animationpack__object", "ObjTestPack")
end
