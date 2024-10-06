Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript__sample", "label_camera")
Include("content_luascript_common", "DemoCommonPack")

-- アセットなどを読み込む
function Load()
	Load_common(true)
	load_area_scene(110011) -- 教室
	
	Camera01 = set_camera(LABEL_CAMERA_POSROTFOV)
	set_camera_lookat(Camera01, LABEL_CAMERA_LOOKAT)
	
	setup_Lancelot({0.000, 0.0, -5.440, 0.0})
	
	setup_Noir({1.050, 0.0, -1.610, 180.0})
	motion(Noir, "Sri_Sit_loop_m", 0.0, 1.0, true)
	
	setup_Guinevere({-1.430, 0.0,  0.050, 180.0})
	motion(Guinevere, "Nbl_Sit_loop_f", 0.0, 1.0, true)
	
	MobGirl01	= set_chara("content_chr_401006_401006001_model", "401006001_Model", "content_animationpack__common", "MotionPack", "content_animationpack__common", "FacialPack",  2.466, 0.0, -1.920, 180.0, "Mob_Sit_loop_f", "Normal")
	MobGirl02	= set_chara("content_chr_401006_401006001_model", "401006001_Model", "content_animationpack__common", "MotionPack", "content_animationpack__common", "FacialPack", -1.430, 0.0, -1.930, 180.0, "Mob_Sit_loop_f", "Normal")
	MobGirl03	= set_chara("content_chr_401006_401006001_model", "401006001_Model", "content_animationpack__common", "MotionPack", "content_animationpack__common", "FacialPack", -2.850, 0.0, -1.890, 180.0, "Mob_Sit_loop_f", "Normal")
	
	-- 適当なpngファイルをロード
	load_image("unit1901", "2dassets_contents_units_1901", "Full_1901")
	load_image("icon_item_001", "content_icon_item", "icon_item_001")
	load_image("minimap", "content_areascene_116015_minimap", "Minimap_116015")
end

-- シーケンスの実行
function Play()
	on_camera(Camera01)
	fadein(0)
	Play_start(true)
	
	local signal
	
	while true do
		open_select_window_direct(Noir, "Normal", "画像1表示", "画像2表示", "画像3表示", "画像オフ", "終了")
		if is_select(1) then
			on_screencolor("#FFFFFF", 0, -100)
			signal = show_image("unit1901", 0.0, 0.0, 0.5)
			while signal.IsProccessing() do
				coroutine.yield()
			end
		elseif is_select(2) then
			on_cameraframe(3)
			signal = show_image("icon_item_001", -0.5, 0.5, 1.0)
			while signal.IsProccessing() do
				coroutine.yield()
			end
		elseif is_select(3) then
			off_cameraframe()
			off_screencolor()
			show_image("minimap", 0.0, 0.2, 0.0)
		elseif is_select(4) then
			signal = hide_image(0.5)
			while signal.IsProccessing() do
				coroutine.yield()
			end
		else
			break
		end

		wait_time(5)
	end

	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_area_scene_preload(110011)
	setup_Lancelot_preload({0.000, 0.0, -5.440, 0.0})
	setup_Noir_preload({1.050, 0.0, -1.610, 180.0})
	setup_Guinevere_preload({-1.430, 0.0,  0.050, 180.0})
	set_chara_preload("content_chr_401006_401006001_model", "401006001_Model", "content_animationpack__common", "MotionPack", "content_animationpack__common", "FacialPack",  2.466, 0.0, -1.920, 180.0, "Mob_Sit_loop_f", "Normal")
	set_chara_preload("content_chr_401006_401006001_model", "401006001_Model", "content_animationpack__common", "MotionPack", "content_animationpack__common", "FacialPack", -1.430, 0.0, -1.930, 180.0, "Mob_Sit_loop_f", "Normal")
	set_chara_preload("content_chr_401006_401006001_model", "401006001_Model", "content_animationpack__common", "MotionPack", "content_animationpack__common", "FacialPack", -2.850, 0.0, -1.890, 180.0, "Mob_Sit_loop_f", "Normal")
	load_image_preload("unit1901", "2dassets_contents_units_1901", "Full_1901")
	load_image_preload("icon_item_001", "content_icon_item", "icon_item_001")
	load_image_preload("minimap", "content_areascene_116015_minimap", "Minimap_116015")
end
