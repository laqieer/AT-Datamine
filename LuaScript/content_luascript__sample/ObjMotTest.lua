Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")

-- アセットなどを読み込む
function Load()
	Load_common(true)
	load_scene("content_areascene_111011", "Area111011") -- 外城謁見の間（カーライル）
	
	-- 扉を見るカメラ
	Camera01 = set_camera(0, 2.37, 20.5, 0, 180, 0, 60)
	
	setup_Noir({1.71, 0.0, 16, 180.0})
	
	-- 扉の親オブジェクトを取ってくる
	door = get_object("Bgarea_127_doorG")
	
	-- 扉のモーションパックを読み込む
	load_animpack(door, "content_animationpack__object", "Area1111011door")
	
end

-- シーケンスの実行
function Play()
	on_camera(Camera01)
	fadein(0)
	Play_start(true)
	
	while true do
		open_select_window_direct(Noir, "Normal", "扉を開く", "扉を閉じる", "終了")
		if is_select(1) then
			local signal = motion(door, "open", 0.0, 1.0, false)
			while signal.IsProccessing() do
				coroutine.yield()
			end
		elseif is_select(2) then
			local signal = motion(door, "close", 0.0, 1.0, false)
			while signal.IsProccessing() do
				coroutine.yield()
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
	load_scene_preload("content_areascene_111011", "Area111011")
	setup_Noir_preload({1.71, 0.0, 16, 180.0})
	load_animpack_preload(door, "content_animationpack__object", "Area1111011door")
end
